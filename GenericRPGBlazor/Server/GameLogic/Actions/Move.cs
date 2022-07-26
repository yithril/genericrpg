using GenericRPGBlazor.Server.GameLogic.State;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.GameLogic.Actions
{
    public class Move : GameAction
    {
        public override List<string> ValidCommands { 
            get
            {
                return new List<string>() {
                "n", "north", "s", "south", "east", "e", "w", "west", "nw", "sw", "ne", "se",
                "northwest", "southwest", "northeast", "southeast", "up", "down"
                };
            } 
        }

        public override void ExecuteCommand(GameState state, Living living, string text)
        {

        }

        private bool RoomExitExists(string exit)
        {
            return true;
        }

        private bool FlightCheck(Living living, RoomDTO roomDTO)
        {
            return true;
        }

        private bool FatigueCheck(Living living, RoomDTO roomDTO)
        {
            return true;
        }
    }
}
