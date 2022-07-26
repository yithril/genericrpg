using System.ComponentModel.DataAnnotations;

namespace GenericRPGBlazor.Server.Models
{
    public class GameZone : EntityBase
    {
        [Required]
        public string Name { get; set; }
        public bool IsPlayable { get; set; }
    }
}
