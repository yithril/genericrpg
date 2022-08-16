using GenericRPGBlazor.Server.GameLogic.Parser.Interface;
using GenericRPGBlazor.Server.GameLogic.State;
using Microsoft.AspNetCore.SignalR;

namespace GenericRPGBlazor.Server.GameLogic.Hubs
{
    public class GameHub : Hub
    {
        private ICommandRouter _commandrouter;

        public GameHub(ICommandRouter commandRouter)
        {
            _commandrouter = commandRouter; 
        }

        public async Task ReceiveCommand(string sender, string message)
        {
            var commandSplit = message.Split(' ');


        }
    }
}
