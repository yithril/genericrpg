using GenericRPGBlazor.Server.GameLogic.State;
using GenericRPGBlazor.Server.Models;

namespace GenericRPGBlazor.Server.GameLogic.Actions
{
    public class Drop : GameAction
    {
        public override List<string> ValidCommands
        {
            get
            {
                return new List<string>() {
                "drop"
                };
            }
        }

        public override void ExecuteCommand(GameState state, Living living, string text)
        {

        }
    }
}
