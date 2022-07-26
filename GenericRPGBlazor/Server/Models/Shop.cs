namespace GenericRPGBlazor.Server.Models
{
    public class Shop : EntityBase
    {
        public int NpcId { get; set; }
        public NPC NPC { get; set; }
        public decimal HaggleModifier { get; set; }
        public decimal MaxDiscount { get; set; }
    }
}
