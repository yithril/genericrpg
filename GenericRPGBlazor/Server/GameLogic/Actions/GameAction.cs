using GenericRPGBlazor.Server.GameLogic.State;
using GenericRPGBlazor.Server.Models;

namespace GenericRPGBlazor.Server.GameLogic.Actions
{
    public abstract class GameAction
    {
        public abstract List<string> ValidCommands { get; }

        public abstract void ExecuteCommand(GameState state, Living living, string text);
        public bool CheckGameCommand(string command)
        {
            return ValidCommands.Contains(command);
        }
    }
}
