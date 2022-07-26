using System.ComponentModel.DataAnnotations;

namespace GenericRPGBlazor.Server.Models
{
    public class Quest : EntityBase
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
