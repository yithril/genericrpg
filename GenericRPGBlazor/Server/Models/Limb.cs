using System.ComponentModel.DataAnnotations;

namespace GenericRPGBlazor.Server.Models
{
    public class Limb : EntityBase
    {
        [Required]
        public string Name { get; set; }
        public bool IsVital { get; set; }
        public bool CanFly { get; set; }
        public bool CanWield { get; set; }
        public bool CanWear { get; set; }
        public List<Race> Races { get; set; }
    }
}
