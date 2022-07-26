using GenericRPGBlazor.Server.GameLogic.Actions;
using GenericRPGBlazor.Server.GameLogic.GameOutput;
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

        public GameActionResult ReceiveCommand(string command, GameState state, Living living, string text = "")
        {
            if (string.IsNullOrEmpty(command))
            {
                return new GameActionResult("Please type a command.");
            }

            //which command is needed?
            var commandToExecute = _gameCommands.Where(x => x.CheckGameCommand(command)).FirstOrDefault();

            //didn't find it
            if(commandToExecute == null)
            {
                return new GameActionResult(ReturnRandomErrorMessage());
            }

            commandToExecute.ExecuteCommand(state, living, text);

            return new GameActionResult("", success: true);
        }

        private string ReturnRandomErrorMessage()
        {
            var errors = new List<string>()
            {
                "Sorry, what?",
                "Huh?",
                "What?",
                "Command not understood",
                "You want to do what?"
            };

            var random = new Random();

            return errors[random.Next(0, errors.Count-1)];
        }
    }
}
