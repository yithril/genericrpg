using GenericRPGBlazor.Shared.Enum;

namespace GenericRPGBlazor.Shared.DTO
{
    public class WeaponDTO
    {
        public int DamageCoefficient { get; set; }
        public int DamageDie { get; set; }
        public int DamageConstant { get; set; }
        public DamageType DamageType { get; set; }
    }
}
