using GenericRPGBlazor.Server.GameLogic.State;
using Microsoft.AspNetCore.SignalR;

namespace GenericRPGBlazor.Server.GameLogic.Hubs
{
    public class GameHub : Hub
    {
        private GameState _gameState;
    }
}
