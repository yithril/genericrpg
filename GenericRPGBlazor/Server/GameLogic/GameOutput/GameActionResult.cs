using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.GameLogic.GameOutput
{
    public class GameActionResult
    {
        public string FirstPersonMessage { get; set; }
        public string SecondPersonMessage { get; set; }       

        public bool Success { get; set; }
        public RoomDTO Room { get; set; }
        public int PlayerId { get; set; }

    }
}
