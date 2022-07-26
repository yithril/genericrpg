using GenericRPGBlazor.Shared.Enum;

namespace GenericRPGBlazor.Server.Models
{
    public class Armor : Item
    {
        public int Durability { get; set; }
        public int AC { get; set; }
        public DamageType? ResistanceType { get; set; }
        public List<ArmorLimb> Limbs { get; set; }
    }
}
