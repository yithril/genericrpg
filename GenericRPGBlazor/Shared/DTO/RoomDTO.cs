using GenericRPGBlazor.Shared.Enum;

namespace GenericRPGBlazor.Shared.DTO
{
    public class RoomDTO
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public RoomTerrain Terrain { get; set; }
        public bool RequireFlyCheck { get; set; }
        public List<RoomExitDTO> ExitList { get; set; } = new List<RoomExitDTO>();
        public List<ItemDTO> Items { get; set; } = new List<ItemDTO>();
        public List<NPCDTO> NPCs { get; set; } = new List<NPCDTO>();
        public List<PlayerDTO> PlayerList { get; set; } = new List<PlayerDTO>();

    }
}
