using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Services.Interface
{
    public interface IRoomService
    {
        Task<RoomDTO> GetRoomById(int id);
        Task<RoomDTO> CreateRoom(RoomDTO dtoRoom);
        Task<bool> DeleteRoom(int id);
    }
}
