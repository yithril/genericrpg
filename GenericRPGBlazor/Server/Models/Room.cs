

using GenericRPGBlazor.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace GenericRPGBlazor.Server.Models
{
    public class Room : EntityBase
    {
        [Required]
        public string Header { get; set; }

        [Required]
        public string Description { get; set; }
        public RoomTerrain Terrain { get; set; }
        public bool RequireFlyCheck { get; set; }
        public List<RoomExit> ExitList { get; set; }
        public List<RoomItem> RoomItems { get; set; }
        public List<RoomNPC> NPCs { get; set; }
        public int GameZoneId { get; set; }
        public GameZone GameZone { get; set; }
    }
}
