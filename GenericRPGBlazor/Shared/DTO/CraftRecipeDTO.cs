using System.ComponentModel.DataAnnotations;


namespace GenericRPGBlazor.Shared.DTO
{
    public class CraftRecipeDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        public List<CraftReagentDTO> Reagents { get; set; }
        public List<CraftSkillDTO> Skills { get; set; }
        public int OutputItemId { get; set; }
    }
}
