using GenericRPGBlazor.Server.GameLogic.Parser.Interface;
using GenericRPGBlazor.Server.Services.Interface;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Caching.Memory;
using System.Security.Claims;

namespace GenericRPGBlazor.Server.GameLogic.Hubs
{
    public class GameHub : Hub
    {
        private readonly ICommandRouter _commandrouter;
        private readonly IPlayerService _playerService;
        private readonly IMemoryCache _memoryCache;
        private readonly IUserActivityService _userActivityService;

        public GameHub(ICommandRouter commandRouter, IPlayerService playerService, IMemoryCache memoryCache, IUserActivityService userActivityService)
        {
            _commandrouter = commandRouter; 
            _playerService = playerService;
            _memoryCache = memoryCache;
            _userActivityService = userActivityService; 
        }

        public override async Task OnConnectedAsync()
        {
            var context = Context.GetHttpContext();

            if(context == null)
            {
                return;
            }

            var playerId = context.Request.Query["playerId"];

            if (string.IsNullOrEmpty(playerId))
            {
                return;
            }

            var canPlay = await _playerService.ValidatePlayerStart(int.Parse(playerId), GetUserAuthId(context.User));

            if (!canPlay)
            {
                return;
            }

            CachePlayer(int.Parse(playerId), GetUserAuthId(context.User));

            await _userActivityService.PostActivity(new Models.UserActivity()
            {
                AuthId = GetUserAuthId(context.User),
                PlayerId = int.Parse(playerId),
                ActivityType = Shared.Enum.ActivityType.Login
            });

            await base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            var context = Context.GetHttpContext();

            if (context == null)
            {
                return base.OnDisconnectedAsync(exception);
            }

            ClearPlayerCache(GetUserAuthId(context.User));

            return base.OnDisconnectedAsync(exception);
        }

        private async void CachePlayer(int id, string authId)
        {
            var player = await _playerService.GetPlayerById(id);

            await _userActivityService.PostActivity(new Models.UserActivity()
            {
                AuthId = authId,
                PlayerId = player.Id,
                ActivityType = Shared.Enum.ActivityType.Logout
            });

            _memoryCache.Set(authId, player, TimeSpan.FromHours(1));
        }

        private void ClearPlayerCache(string authId)
        {
            //TO DO handle multiple connections

            _memoryCache.Remove(authId);
        }

        private string GetUserAuthId(ClaimsPrincipal user)
        {
            var authId = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            if (authId == null)
            {
                return "";
            }

            return authId.Value;
        }
    }
}
