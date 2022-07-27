using GenericRPGBlazor.Server.GameLogic.GameOutput;
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

        public override GameActionResult ExecuteCommand(GameState state, Living living, string action, string predicate = "")
        {
            throw new NotImplementedException();
        }

        public RoomDTO GetCurrentRoom(GameState state, Living living)
        {
            var room = state.GetRooms().Where(x => x.PlayerList.Any(y => y.Id == living.Id)).FirstOrDefault();

            ArgumentNullException.ThrowIfNull(room);

            return room;
        }

        public bool RoomExitExists(string exit)
        {
            return true;
        }

        public bool FlightCheck(Living living, RoomDTO roomDTO)
        {
            return true;
        }

        public bool FatigueCheck(Living living, RoomDTO roomDTO)
        {
            return true;
        }
    }
}
