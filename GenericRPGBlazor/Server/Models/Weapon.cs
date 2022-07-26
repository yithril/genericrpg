using GenericRPGBlazor.Shared.Enum;

namespace GenericRPGBlazor.Server.Models
{
    public class Weapon : Item
    {
       public int DamageCoefficient { get; set; }
       public int DamageDie { get; set; }
       public int DamageConstant { get; set; }
        public DamageType DamageType { get; set; }
     
    }
}
