using GenericRPGBlazor.Shared.Enum;

namespace GenericRPGBlazor.Shared.DTO
{
    public class ArmorDTO
    {
        public int Durability { get; set; }
        public int AC { get; set; }
        public DamageType? ResistanceType { get; set; }
        public List<ArmorLimbDTO> Limbs { get; set; }
    }
}
