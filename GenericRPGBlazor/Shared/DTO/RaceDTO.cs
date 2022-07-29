using System.ComponentModel.DataAnnotations;

namespace GenericRPGBlazor.Shared.DTO
{
    public class RaceDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        public bool IsPlayable { get; set; }
        public int ConMod { get; set; }
        public int IntMod { get; set; }
        public int DexMod { get; set; }
        public int StrMod { get; set; }
        public int PerMod { get; set; }
        public int ChaMod { get; set; }
        public int CreationPoints { get; set; }
        public int ConMax { get; set; }
        public int IntMax { get; set; }
        public int DexMax { get; set; }
        public int StrMax { get; set; }
        public int PerMax { get; set; }
        public int ChaMax { get; set; }
        public int ConMin { get; set; }
        public int IntMin { get; set; }
        public int DexMin { get; set; }
        public int StrMin { get; set; }
        public int PerMin { get; set; }
        public int ChaMin { get; set; }
    }
}
