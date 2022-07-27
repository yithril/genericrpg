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

        public GameActionResult ReceiveCommand(string command, int playerId, GameState state, Living living, string action, string predicate = "")
        {
            if (string.IsNullOrEmpty(command))
            {
                return new GameActionResult() {FirstPersonMessage = "Please type a command.", PlayerId = playerId };
            }

            //which command is needed?
            var commandToExecute = _gameCommands.Where(x => x.CheckGameCommand(command)).FirstOrDefault();

            //didn't find it
            if(commandToExecute == null)
            {
                return new GameActionResult() { FirstPersonMessage = ReturnRandomErrorMessage(), PlayerId = playerId };
            }

            commandToExecute.ExecuteCommand(state, living, action, predicate);

            return new GameActionResult() { Success = true, PlayerId = playerId };
        }

        private string ReturnRandomErrorMessage()
        {
            var errors = new List<string>()
            {
                "Sorry, what?",
                "Huh?",
                "What?",
                "Command not understood.",
                "You want to do what?"
            };

            var random = new Random();

            return errors[random.Next(0, errors.Count-1)];
        }
    }
}
