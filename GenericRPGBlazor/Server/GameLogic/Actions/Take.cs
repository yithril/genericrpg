using GenericRPGBlazor.Server.GameLogic.GameOutput;
using GenericRPGBlazor.Server.GameLogic.State;
using GenericRPGBlazor.Server.Models;

namespace GenericRPGBlazor.Server.GameLogic.Actions
{
    public class Take : GameAction
    {
        public override List<string> ValidCommands
        {
            get
            {
                return new List<string>() {
                "take"
                };
            }
        }

        public override GameActionResult ExecuteCommand(GameState state, Living living, string action, string predicate = "")
        {
            throw new NotImplementedException();
        }
    }
}
