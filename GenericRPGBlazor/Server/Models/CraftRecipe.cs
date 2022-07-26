using System.ComponentModel.DataAnnotations;

namespace GenericRPGBlazor.Server.Models
{
    public class CraftRecipe : EntityBase
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        public List<CraftReagent> Reagents { get; set; }
        public List<CraftSkill> Skills { get; set; }
        public int OutputItemId { get; set; }
    }
}
