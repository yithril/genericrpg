namespace GenericRPGBlazor.Server.Models
{
    public class ArmorLimb : EntityBase
    {
        public int ArmorId { get; set; }
        public Armor Armor { get; set; }
        public int LimbId { get; set; }
        public Limb Limb { get; set; }
    }
}
