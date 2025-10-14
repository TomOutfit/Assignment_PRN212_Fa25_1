using FUMiniHotelSystem.DataAccess.Interfaces;
using FUMiniHotelSystem.Models;

namespace FUMiniHotelSystem.DataAccess
{
    public class RoomTypeRepository : JsonRepository<RoomType>, IRoomTypeRepository
    {
        public RoomTypeRepository() : base("roomtypes.json") { }

        public async Task<List<RoomType>> GetAllRoomTypesAsync()
        {
            return await GetAllAsync();
        }
    }
}
