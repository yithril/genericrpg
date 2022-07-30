using System.ComponentModel.DataAnnotations;

namespace GenericRPGBlazor.Shared.DTO
{
    public class LimbDTO
    {
        [Required]
        public string Name { get; set; }
        public bool IsVital { get; set; }
        public bool CanFly { get; set; }
        public bool CanWield { get; set; }
        public bool CanWear { get; set; }
        public List<RaceDTO> Races { get; set; }
    }
}
