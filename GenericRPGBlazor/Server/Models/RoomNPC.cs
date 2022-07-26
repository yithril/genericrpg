namespace GenericRPGBlazor.Server.Models
{
    public class RoomNPC : EntityBase
    {
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int NPCId { get; set; }
        public NPC NPC { get; set; }
    }
}
