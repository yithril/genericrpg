using GenericRPGBlazor.Server.GameLogic.Actions;
using GenericRPGBlazor.Server.GameLogic.State;
using GenericRPGBlazor.Server.Models;

namespace GenericRPGBlazor.Server.GameLogic.Parser
{
    public class CommandRouter
    {
        private List<GameAction> _gameCommands = new List<GameAction>();

        public CommandRouter()
        {
            _gameCommands.Add(new Move());
            _gameCommands.Add(new Take());
            _gameCommands.Add(new Drop());
        }

        public void ReceiveCommand(string command, GameState state, Living living, string text)
        {
            if (string.IsNullOrEmpty(command))
            {
                return;
            }

            //which command is needed?
            var commandToExecute = _gameCommands.Where(x => x.CheckGameCommand(command)).FirstOrDefault();

            //didn't find it
            if(commandToExecute == null)
            {
                return;
            }

            commandToExecute.ExecuteCommand(state, living, text);
        }
    }
}
