using GenericRPGBlazor.Shared.Enum;

namespace GenericRPGBlazor.Shared.DTO
{
    public class RoomExitDTO
    {
        public int TargetRoomId { get; set; }
        public Direction Direction { get; set; }
    }
}
