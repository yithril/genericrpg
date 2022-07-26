using System.ComponentModel.DataAnnotations;

namespace GenericRPGBlazor.Server.Models
{
    public class Skill : EntityBase
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        public double Modifier { get; set; }
    }
}
