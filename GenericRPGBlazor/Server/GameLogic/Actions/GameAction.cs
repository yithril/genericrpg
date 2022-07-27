using GenericRPGBlazor.Server.GameLogic.GameOutput;
using GenericRPGBlazor.Server.GameLogic.State;
using GenericRPGBlazor.Server.Models;

namespace GenericRPGBlazor.Server.GameLogic.Actions
{
    public abstract class GameAction
    {
        public abstract List<string> ValidCommands { get; }

        public abstract GameActionResult ExecuteCommand(GameState state, Living living, string action, string predicate = "");
        public bool CheckGameCommand(string command)
        {
            return ValidCommands.Contains(command);
        }
    }
}
