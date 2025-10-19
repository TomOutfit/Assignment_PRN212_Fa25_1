using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using FUMiniHotelSystem.Models;
using StudentNameWPF.ViewModels;

namespace StudentNameWPF.Views
{
    public partial class BookingDialog : Window
    {
        private BookingDialogViewModel _viewModel;
        private Booking? _originalBooking;

        public BookingDialog()
        {
            InitializeComponent();
            _viewModel = new BookingDialogViewModel();
            DataContext = _viewModel;
            InitializeDialog();
        }

        public BookingDialog(Booking booking) : this()
        {
            _originalBooking = booking;
            _viewModel.LoadBooking(booking);
            DialogTitle.Text = "Edit Booking";
            SaveButton.Content = "Update Booking";
            InitializeDialog();
        }

        private void InitializeDialog()
        {
            // Set minimum date to today
            CheckInDatePicker.DisplayDateStart = DateTime.Today;
            CheckOutDatePicker.DisplayDateStart = DateTime.Today.AddDays(1);
            
            // Load rooms
            LoadRooms();
            
            // Set default dates
            if (_originalBooking == null)
            {
                CheckInDatePicker.SelectedDate = DateTime.Today;
                CheckOutDatePicker.SelectedDate = DateTime.Today.AddDays(1);
            }
            else
            {
                CheckInDatePicker.SelectedDate = _originalBooking.CheckInDate;
                CheckOutDatePicker.SelectedDate = _originalBooking.CheckOutDate;
                RoomComboBox.SelectedValue = _originalBooking.RoomID;
                NotesTextBox.Text = _originalBooking.Notes;
            }
            
            UpdatePriceCalculation();
        }

        private async void LoadRooms()
        {
            try
            {
                await _viewModel.LoadRoomsAsync();
                RoomComboBox.ItemsSource = _viewModel.AvailableRooms;
                
                if (_originalBooking != null)
                {
                    RoomComboBox.SelectedValue = _originalBooking.RoomID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rooms: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ViewRoomDetails_Click(object sender, RoutedEventArgs e)
        {
            if (RoomComboBox.SelectedItem is RoomInformation selectedRoom)
            {
                _viewModel.SelectedRoom = selectedRoom;
                ShowRoomDetails(selectedRoom);
            }
            else
            {
                MessageBox.Show("Please select a room first.", "No Room Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ShowRoomDetails(RoomInformation room)
        {
            RoomDetailsPanel.Visibility = Visibility.Visible;
            RoomDetailsText.Text = $"Room Number: {room.RoomNumber}\n" +
                                 $"Description: {room.RoomDescription}\n" +
                                 $"Max Capacity: {room.RoomMaxCapacity} guests\n" +
                                 $"Price per Day: ${room.RoomPricePerDate:F2}\n" +
                                 $"Status: {(room.RoomStatus == 1 ? "Available" : "Unavailable")}";
        }

        private async void DatePicker_SelectedDateChanged(object sender, RoutedPropertyChangedEventArgs<DateTime?> e)
        {
            UpdatePriceCalculation();
            ValidateDates();
            
            // Update available rooms when dates change
            if (CheckInDatePicker.SelectedDate.HasValue && CheckOutDatePicker.SelectedDate.HasValue)
            {
                await UpdateAvailableRooms();
            }
        }

        private void UpdatePriceCalculation()
        {
            if (CheckInDatePicker.SelectedDate.HasValue && 
                CheckOutDatePicker.SelectedDate.HasValue && 
                RoomComboBox.SelectedItem is RoomInformation selectedRoom)
            {
                var checkIn = CheckInDatePicker.SelectedDate.Value;
                var checkOut = CheckOutDatePicker.SelectedDate.Value;
                
                if (checkOut > checkIn)
                {
                    var duration = (checkOut - checkIn).Days;
                    var totalAmount = duration * selectedRoom.RoomPricePerDate;
                    
                    DurationText.Text = duration.ToString();
                    PricePerDayText.Text = $"${selectedRoom.RoomPricePerDate:F2}";
                    TotalAmountText.Text = $"${totalAmount:F2}";
                    
                    _viewModel.TotalAmount = totalAmount;
                }
            }
            else
            {
                DurationText.Text = "0";
                PricePerDayText.Text = "$0";
                TotalAmountText.Text = "$0";
                _viewModel.TotalAmount = 0;
            }
        }

        private void ValidateDates()
        {
            if (CheckInDatePicker.SelectedDate.HasValue && CheckOutDatePicker.SelectedDate.HasValue)
            {
                var checkIn = CheckInDatePicker.SelectedDate.Value;
                var checkOut = CheckOutDatePicker.SelectedDate.Value;
                
                if (checkOut <= checkIn)
                {
                    ValidationMessage.Text = "Check-out date must be after check-in date.";
                    SaveButton.IsEnabled = false;
                }
                else if (checkIn < DateTime.Today)
                {
                    ValidationMessage.Text = "Check-in date cannot be in the past.";
                    SaveButton.IsEnabled = false;
                }
                else
                {
                    ValidationMessage.Text = "";
                    SaveButton.IsEnabled = true;
                }
            }
            else
            {
                ValidationMessage.Text = "Please select both check-in and check-out dates.";
                SaveButton.IsEnabled = false;
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateBooking())
            {
                DialogResult = true;
                Close();
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private bool ValidateBooking()
        {
            if (RoomComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a room.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            if (!CheckInDatePicker.SelectedDate.HasValue || !CheckOutDatePicker.SelectedDate.HasValue)
            {
                MessageBox.Show("Please select both check-in and check-out dates.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            var checkIn = CheckInDatePicker.SelectedDate.Value;
            var checkOut = CheckOutDatePicker.SelectedDate.Value;

            if (checkOut <= checkIn)
            {
                MessageBox.Show("Check-out date must be after check-in date.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            if (checkIn < DateTime.Today)
            {
                MessageBox.Show("Check-in date cannot be in the past.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            return true;
        }

        public Booking? GetBooking()
        {
            if (DialogResult == true && ValidateBooking())
            {
                var booking = new Booking
                {
                    CustomerID = _viewModel.CustomerID,
                    RoomID = (int)RoomComboBox.SelectedValue,
                    CheckInDate = CheckInDatePicker.SelectedDate.Value,
                    CheckOutDate = CheckOutDatePicker.SelectedDate.Value,
                    TotalAmount = _viewModel.TotalAmount,
                    Notes = NotesTextBox.Text,
                    BookingStatus = 1, // Pending
                    CreatedDate = DateTime.Now
                };

                if (_originalBooking != null)
                {
                    booking.BookingID = _originalBooking.BookingID;
                    booking.CreatedDate = _originalBooking.CreatedDate;
                    booking.BookingStatus = _originalBooking.BookingStatus;
                }

                return booking;
            }

            return null;
        }

        private async Task UpdateAvailableRooms()
        {
            try
            {
                if (CheckInDatePicker.SelectedDate.HasValue && CheckOutDatePicker.SelectedDate.HasValue)
                {
                    var checkIn = CheckInDatePicker.SelectedDate.Value;
                    var checkOut = CheckOutDatePicker.SelectedDate.Value;
                    
                    if (checkOut > checkIn)
                    {
                        await _viewModel.LoadAvailableRoomsAsync(checkIn, checkOut);
                        RoomComboBox.ItemsSource = _viewModel.AvailableRooms;
                        
                        // Show message if no rooms available
                        if (_viewModel.AvailableRooms.Count == 0)
                        {
                            ValidationMessage.Text = "No rooms available for the selected dates. Please choose different dates.";
                        }
                        else
                        {
                            ValidationMessage.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ValidationMessage.Text = $"Error checking room availability: {ex.Message}";
            }
        }
    }
}
