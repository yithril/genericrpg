using System.ComponentModel.DataAnnotations;

namespace GenericRPGBlazor.Shared.DTO
{
    public class ItemDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ShortDescription { get; set; }

        [Required]
        public string Nouns { get; set; }
        public int Cost { get; set; }
        public bool IsMagical { get; set; }
        public bool IsEpic { get; set; }
        public bool CanTake { get; set; }
        public int Weight { get; set; }
        public int AppraiseDC { get; set; }
        public int Size { get; set; }
    }
}
