# FU Mini Hotel Management System

A comprehensive Hotel Management System built with WPF (.NET 8) and following 3-layer architecture with MVVM pattern.

## Features

### Authentication
- Admin login with default credentials: `admin@FUMiniHotelSystem.com` / `@@abc123@@`
- Customer login with registered accounts
- Role-based access control

### Admin Features
- **Customer Management**: Full CRUD operations for customer data
- **Room Management**: Manage room information, types, and availability
- **Booking Management**: Handle reservations and view booking history
- **Reporting**: Generate booking reports by date range

### Customer Features
- **Profile Management**: Update personal information
- **Booking History**: View past and current reservations

## Architecture

### 3-Layer Architecture
1. **Presentation Layer**: WPF Views and ViewModels (MVVM pattern)
2. **Business Logic Layer**: Services for business operations
3. **Data Access Layer**: Repository pattern with JSON file persistence

### Design Patterns
- **MVVM (Model-View-ViewModel)**: Clean separation of concerns
- **Repository Pattern**: Data access abstraction
- **Singleton Pattern**: Service registration
- **Dependency Injection**: Loose coupling

## Project Structure

```
StudentName_ClassCode_A01.sln
├── FUMiniHotelSystem.Models/
│   └── Models/
│       ├── Customer.cs
│       ├── Room.cs
│       ├── RoomType.cs
│       ├── Booking.cs
│       └── AppSettings.cs
├── FUMiniHotelSystem.DataAccess/
│   ├── Data/
│   │   └── DataContext.cs
│   └── Repositories/
│       ├── IRepository.cs
│       ├── Repository.cs
│       ├── CustomerRepository.cs
│       ├── RoomRepository.cs
│       ├── RoomTypeRepository.cs
│       └── BookingRepository.cs
├── FUMiniHotelSystem.BusinessLogic/
│   └── Services/
│       ├── IAuthenticationService.cs
│       ├── AuthenticationService.cs
│       ├── ICustomerService.cs
│       ├── CustomerService.cs
│       ├── IRoomService.cs
│       ├── RoomService.cs
│       ├── IBookingService.cs
│       └── BookingService.cs
└── StudentNameWPF/
    ├── Views/
    │   ├── LoginWindow.xaml
    │   ├── MainWindow.xaml
    │   ├── CustomerManagementWindow.xaml
    │   ├── RoomManagementWindow.xaml
    │   ├── BookingManagementWindow.xaml
    │   ├── CustomerProfileWindow.xaml
    │   ├── CustomerDialog.xaml
    │   ├── RoomDialog.xaml
    │   ├── BookingDialog.xaml
    │   └── ReportWindow.xaml
    ├── ViewModels/
    │   ├── BaseViewModel.cs
    │   ├── LoginViewModel.cs
    │   ├── MainWindowViewModel.cs
    │   ├── CustomerManagementViewModel.cs
    │   ├── RoomManagementViewModel.cs
    │   ├── BookingManagementViewModel.cs
    │   ├── CustomerProfileViewModel.cs
    │   ├── CustomerDialogViewModel.cs
    │   ├── RoomDialogViewModel.cs
    │   ├── BookingDialogViewModel.cs
    │   └── ReportWindowViewModel.cs
    ├── Converters/
    │   ├── BooleanToVisibilityConverter.cs
    │   ├── InverseBooleanConverter.cs
    │   └── StringToVisibilityConverter.cs
    ├── Styles/
    │   └── AppStyles.xaml
    ├── App.xaml
    ├── App.xaml.cs
    └── appsettings.json
```

## Data Models

### Customer
- CustomerID (int)
- CustomerFullName (string, 50)
- Telephone (string, 12)
- EmailAddress (string, 50)
- CustomerBirthday (date)
- CustomerStatus (1 Active, 2 Deleted)
- Password (string, 50)

### Room
- RoomID (int)
- RoomNumber (string, 50)
- RoomDescription (string, 220)
- RoomMaxCapacity (int)
- RoomStatus (1 Active, 2 Deleted)
- RoomPricePerDate (decimal)
- RoomTypeID (int)

### RoomType
- RoomTypeID (int)
- RoomTypeName (string, 50)
- TypeDescription (string, 250)
- TypeNote (string, 250)

### Booking
- BookingID (int)
- CustomerID (int)
- RoomID (int)
- CheckInDate (date)
- CheckOutDate (date)
- TotalAmount (decimal)
- BookingStatus (1 Pending, 2 Confirmed, 3 Cancelled, 4 Completed)
- BookingDate (date)
- Notes (string, 500)

## Technologies Used

- **.NET 8** with WPF
- **C# 12** with nullable reference types
- **CommunityToolkit.Mvvm** for MVVM implementation
- **Microsoft.Extensions.DependencyInjection** for DI container
- **Newtonsoft.Json** for JSON serialization
- **Data Annotations** for validation

## Getting Started

1. Open the solution in Visual Studio 2022 or later
2. Restore NuGet packages
3. Build the solution
4. Run the application
5. Login with admin credentials: `admin@FUMiniHotelSystem.com` / `@@abc123@@`

## Features Implementation

### Data Persistence
- JSON file-based storage (`data.json`)
- In-memory collections for runtime operations
- Automatic data loading and saving

### Validation
- Data annotations for model validation
- Business logic validation in services
- UI validation feedback

### Error Handling
- Comprehensive exception handling
- User-friendly error messages
- Graceful error recovery

### UI/UX
- Modern, responsive design
- Consistent styling across all windows
- Intuitive navigation and workflows
- Loading indicators and progress feedback

## Assignment Requirements Met

✅ **3-Layer Architecture**: Clear separation of concerns
✅ **MVVM Pattern**: Complete implementation with ViewModels
✅ **Repository Pattern**: Data access abstraction
✅ **Singleton Pattern**: Service registration
✅ **CRUD Operations**: Full Create, Read, Update, Delete functionality
✅ **Data Validation**: Comprehensive validation at all layers
✅ **Authentication**: Role-based access control
✅ **Reporting**: Date-range based booking reports
✅ **Search Functionality**: Search across customers and rooms
✅ **JSON File Storage**: No hardcoded data, configurable settings
✅ **Modern UI**: Professional, user-friendly interface

## Default Data

The system comes with pre-populated data:
- 3 Room Types: Standard, Deluxe, Suite
- 5 Sample Rooms with different types and prices
- 1 Admin account for system access

## Notes

- All data is persisted in JSON format for easy inspection and modification
- The system supports both admin and customer roles with different access levels
- Room availability is automatically calculated based on existing bookings
- All operations include proper validation and error handling
- The UI is fully responsive and follows modern design principles
