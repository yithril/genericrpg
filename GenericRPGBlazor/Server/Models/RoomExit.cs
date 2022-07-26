using GenericRPGBlazor.Shared.Enum;

namespace GenericRPGBlazor.Server.Models
{
    public class RoomExit : EntityBase
    {
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public Direction Direction { get; set; }
        public int TargetRoomId { get; set; }
        public bool IsHidden { get; set; }
        public int FindDC { get; set; }
    }
}
