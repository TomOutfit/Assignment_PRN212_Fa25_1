using System.Collections.ObjectModel;
using System.Linq;
using FUMiniHotelSystem.BusinessLogic;
using FUMiniHotelSystem.DataAccess;
using FUMiniHotelSystem.Models;
using StudentNameWPF.ViewModels;

namespace StudentNameWPF.ViewModels
{
    public class BookingDialogViewModel : BaseViewModel
    {
        private readonly RoomService _roomService;
        private ObservableCollection<RoomInformation> _availableRooms = new();
        private RoomInformation? _selectedRoom;
        private decimal _totalAmount;
        private int _customerID;

        public BookingDialogViewModel()
        {
            var roomRepository = new RoomRepository();
            var roomTypeRepository = new RoomTypeRepository();
            _roomService = new RoomService(roomRepository, roomTypeRepository);
        }

        public ObservableCollection<RoomInformation> AvailableRooms
        {
            get => _availableRooms;
            set => SetProperty(ref _availableRooms, value);
        }

        public RoomInformation? SelectedRoom
        {
            get => _selectedRoom;
            set => SetProperty(ref _selectedRoom, value);
        }

        public decimal TotalAmount
        {
            get => _totalAmount;
            set => SetProperty(ref _totalAmount, value);
        }

        public int CustomerID
        {
            get => _customerID;
            set => SetProperty(ref _customerID, value);
        }

        public async Task LoadRoomsAsync()
        {
            try
            {
                var rooms = await _roomService.GetActiveRoomsAsync();
                AvailableRooms = new ObservableCollection<RoomInformation>(rooms);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading rooms: {ex.Message}", ex);
            }
        }

        public async Task LoadAvailableRoomsAsync(DateTime checkIn, DateTime checkOut)
        {
            try
            {
                var bookingService = new BookingService(
                    new BookingRepository(), 
                    new RoomRepository(), 
                    new CustomerRepository()
                );
                
                var availableRooms = await bookingService.GetAvailableRoomsAsync(checkIn, checkOut);
                AvailableRooms = new ObservableCollection<RoomInformation>(availableRooms);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading available rooms: {ex.Message}", ex);
            }
        }

        public void LoadBooking(Booking booking)
        {
            CustomerID = booking.CustomerID;
            TotalAmount = booking.TotalAmount;
        }
    }
}
