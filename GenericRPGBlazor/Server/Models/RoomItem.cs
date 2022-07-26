namespace GenericRPGBlazor.Server.Models
{
    public class RoomItem : EntityBase
    {
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
