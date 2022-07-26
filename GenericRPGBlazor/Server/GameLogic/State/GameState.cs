using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.GameLogic.State
{
    public class GameState
    {
        private List<GameZone> _gameZones { get; set; }
        private List<RoomDTO> _rooms { get; set; }
        private List<PlayerDTO> _players { get; set; }

        public GameState(List<GameZone> zones, List<RoomDTO> roomDTOs, List<PlayerDTO> players)
        {
            _gameZones = zones;
            _rooms = roomDTOs;
            _players = players;
        }
    }
}
