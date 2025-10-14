using FUMiniHotelSystem.DataAccess.Interfaces;
using FUMiniHotelSystem.Models;

namespace FUMiniHotelSystem.DataAccess
{
    public class RoomRepository : JsonRepository<RoomInformation>, IRoomRepository
    {
        public RoomRepository() : base("rooms.json") { }

        public async Task<List<RoomInformation>> GetActiveRoomsAsync()
        {
            var rooms = await GetAllAsync();
            return rooms.Where(r => r.RoomStatus == 1).ToList();
        }

        public async Task<List<RoomInformation>> GetRoomsByTypeAsync(int roomTypeId)
        {
            var rooms = await GetAllAsync();
            return rooms.Where(r => r.RoomTypeID == roomTypeId && r.RoomStatus == 1).ToList();
        }
    }
}
