using System.ComponentModel.DataAnnotations;

namespace GenericRPGBlazor.Shared.DTO
{
    public class QuestDTO
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
        public int Points { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
    }
}
