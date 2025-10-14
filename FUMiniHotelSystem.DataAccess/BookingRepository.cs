using FUMiniHotelSystem.DataAccess.Interfaces;
using FUMiniHotelSystem.Models;

namespace FUMiniHotelSystem.DataAccess
{
    public class BookingRepository : JsonRepository<Booking>, IBookingRepository
    {
        public BookingRepository() : base("bookings.json") { }

        public async Task<List<Booking>> GetBookingsByCustomerIdAsync(int customerId)
        {
            var bookings = await GetAllAsync();
            return bookings.Where(b => b.CustomerID == customerId).ToList();
        }

        public async Task<List<Booking>> GetBookingsByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            var bookings = await GetAllAsync();
            return bookings.Where(b => b.CheckInDate >= startDate && b.CheckOutDate <= endDate).ToList();
        }
    }
}
