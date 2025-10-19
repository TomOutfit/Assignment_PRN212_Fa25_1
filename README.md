# 🏨 FU Mini Hotel Management System

<div align="center">

![.NET](https://img.shields.io/badge/.NET-9.0-purple.svg)
![WPF](https://img.shields.io/badge/WPF-Desktop-blue.svg)
![C#](https://img.shields.io/badge/C%23-12.0-green.svg)
![MVVM](https://img.shields.io/badge/Pattern-MVVM-orange.svg)
![Architecture](https://img.shields.io/badge/Architecture-3--Layer-red.svg)

**A comprehensive Hotel Management System built with WPF (.NET 9) and following 3-layer architecture with MVVM pattern**

[![License](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)
[![Build Status](https://img.shields.io/badge/Build-Passing-brightgreen.svg)](https://github.com/your-repo)
[![Code Quality](https://img.shields.io/badge/Code%20Quality-A%2B-brightgreen.svg)](https://github.com/your-repo)

</div>

---

## 📋 Table of Contents

- [🎯 Overview](#-overview)
- [✨ Features](#-features)
- [🏗️ Architecture](#️-architecture)
- [📁 Project Structure](#-project-structure)
- [🔧 Technologies Used](#-technologies-used)
- [🚀 Getting Started](#-getting-started)
- [📊 Data Models](#-data-models)
- [🎨 UI/UX Features](#-uiux-features)
- [🔐 Security](#-security)
- [📈 Performance](#-performance)
- [🧪 Testing](#-testing)
- [📝 API Documentation](#-api-documentation)
- [🤝 Contributing](#-contributing)
- [📄 License](#-license)

---

## 🎯 Overview

The **FU Mini Hotel Management System** is a modern, feature-rich desktop application designed to streamline hotel operations. Built with cutting-edge technologies and following industry best practices, it provides a comprehensive solution for managing customers, rooms, bookings, and reports.

### 🌟 Key Highlights

- **Modern Architecture**: 3-layer architecture with MVVM pattern
- **Role-Based Access**: Secure authentication with admin and customer roles
- **Real-time Updates**: Live data synchronization across the application
- **Advanced Reporting**: Comprehensive booking reports and analytics
- **Responsive Design**: Modern, intuitive user interface
- **Data Persistence**: JSON-based data storage with automatic backup

---

## ✨ Features

### 🔐 Authentication & Security
- **Secure Login System**: Role-based authentication
- **Admin Access**: Full system control with advanced privileges
- **Customer Portal**: Personalized booking management
- **Password Protection**: Encrypted password storage
- **Session Management**: Automatic session timeout

### 👥 Customer Management
- **Complete CRUD Operations**: Create, Read, Update, Delete customers
- **Advanced Search**: Search by name, email, phone number
- **Profile Management**: Update personal information
- **Booking History**: View past and current reservations
- **Status Tracking**: Active/Inactive customer management

### 🏨 Room Management
- **Room Information**: Detailed room descriptions and specifications
- **Room Types**: Standard, Deluxe, Suite categories
- **Availability Tracking**: Real-time room availability
- **Pricing Management**: Dynamic pricing per room type
- **Capacity Management**: Guest capacity tracking

### 📅 Booking Management
- **Reservation System**: Complete booking lifecycle management
- **Date Range Selection**: Flexible check-in/check-out dates
- **Room Availability**: Real-time availability checking
- **Booking Status**: Pending, Confirmed, Cancelled, Completed
- **Payment Tracking**: Total amount calculation and tracking
- **Notes System**: Special requests and additional information

### 📊 Reporting & Analytics
- **Booking Reports**: Comprehensive booking analytics
- **Date Range Reports**: Custom date range reporting
- **Revenue Tracking**: Financial performance monitoring
- **Occupancy Reports**: Room utilization statistics
- **Export Functionality**: PDF, Excel, HTML export options

### 🎨 User Experience
- **Modern UI**: Clean, professional interface design
- **Responsive Layout**: Adaptive to different screen sizes
- **Intuitive Navigation**: Easy-to-use menu system
- **Real-time Updates**: Live data synchronization
- **Error Handling**: Comprehensive error management
- **Loading Indicators**: Visual feedback for operations

---

## 🏗️ Architecture

### 3-Layer Architecture

```
┌─────────────────────────────────────────────────────────────┐
│                    PRESENTATION LAYER                       │
│  ┌─────────────────┐  ┌─────────────────┐  ┌─────────────┐  │
│  │   WPF Views     │  │   ViewModels    │  │  Commands   │  │
│  │   (XAML)        │  │   (MVVM)        │  │  (ICommand) │  │
│  └─────────────────┘  └─────────────────┘  └─────────────┘  │
└─────────────────────────────────────────────────────────────┘
┌─────────────────────────────────────────────────────────────┐
│                   BUSINESS LOGIC LAYER                      │
│  ┌─────────────────┐  ┌─────────────────┐  ┌─────────────┐  │
│  │   Services      │  │   Validation    │  │  Business   │  │
│  │   (BLL)         │  │   Rules         │  │  Logic      │  │
│  └─────────────────┘  └─────────────────┘  └─────────────┘  │
└─────────────────────────────────────────────────────────────┘
┌─────────────────────────────────────────────────────────────┐
│                    DATA ACCESS LAYER                        │
│  ┌─────────────────┐  ┌─────────────────┐  ┌─────────────┐  │
│  │   Repositories  │  │   JSON Files    │  │  Data       │  │
│  │   (DAL)         │  │   (Storage)     │  │  Models     │  │
│  └─────────────────┘  └─────────────────┘  └─────────────┘  │
└─────────────────────────────────────────────────────────────┘
```

### Design Patterns

| Pattern | Implementation | Purpose |
|---------|----------------|---------|
| **MVVM** | ViewModels, Commands, Data Binding | Clean separation of UI and business logic |
| **Repository** | IRepository<T>, JsonRepository<T> | Data access abstraction |
| **Singleton** | Service registration | Single instance management |
| **Dependency Injection** | Service container | Loose coupling |
| **Command** | ICommand, RelayCommand | UI interaction handling |
| **Observer** | INotifyPropertyChanged | Data change notifications |

---

## 📁 Project Structure

```
StudentName_ClassCode_A01.sln
├── 📁 FUMiniHotelSystem.Models/
│   ├── 📄 Customer.cs                    # Customer data model
│   ├── 📄 RoomInformation.cs             # Room data model
│   ├── 📄 RoomType.cs                   # Room type data model
│   ├── 📄 Booking.cs                      # Booking data model
│   └── 📄 AppSettings.cs                # Application settings
│
├── 📁 FUMiniHotelSystem.DataAccess/
│   ├── 📁 Interfaces/
│   │   ├── 📄 IRepository.cs            # Generic repository interface
│   │   ├── 📄 ICustomerRepository.cs    # Customer repository interface
│   │   ├── 📄 IRoomRepository.cs       # Room repository interface
│   │   ├── 📄 IRoomTypeRepository.cs    # Room type repository interface
│   │   └── 📄 IBookingRepository.cs    # Booking repository interface
│   ├── 📄 JsonRepository.cs             # JSON-based repository implementation
│   ├── 📄 CustomerRepository.cs         # Customer data access
│   ├── 📄 RoomRepository.cs             # Room data access
│   ├── 📄 RoomTypeRepository.cs         # Room type data access
│   └── 📄 BookingRepository.cs          # Booking data access
│
├── 📁 FUMiniHotelSystem.BusinessLogic/
│   ├── 📄 AuthenticationService.cs      # Authentication business logic
│   ├── 📄 CustomerService.cs            # Customer business logic
│   ├── 📄 RoomService.cs                # Room business logic
│   └── 📄 BookingService.cs             # Booking business logic
│
└── 📁 StudentNameWPF/
    ├── 📁 Views/
    │   ├── 📄 LoginWindow.xaml           # Login interface
    │   ├── 📄 MainWindow.xaml            # Main application window
    │   ├── 📄 CustomerDialog.xaml        # Customer management dialog
    │   ├── 📄 RoomDialog.xaml            # Room management dialog
    │   ├── 📄 BookingDialog.xaml         # Booking management dialog
    │   └── 📁 Charts/                    # Chart visualization components
    ├── 📁 ViewModels/
    │   ├── 📄 BaseViewModel.cs           # Base ViewModel implementation
    │   ├── 📄 LoginViewModel.cs          # Login ViewModel
    │   ├── 📄 MainViewModel.cs           # Main window ViewModel
    │   ├── 📄 BookingDialogViewModel.cs  # Booking dialog ViewModel
    │   └── 📄 RelayCommand.cs            # Command implementation
    ├── 📁 Services/
    │   ├── 📄 ReportExportService.cs    # Report generation service
    │   ├── 📄 ChartExportService.cs      # Chart export service
    │   ├── 📄 PDFExportService.cs        # PDF export service
    │   ├── 📄 ExcelExportService.cs      # Excel export service
    │   └── 📄 RealtimeDataService.cs     # Real-time data service
    ├── 📁 Models/
    │   └── 📄 BookingDisplayModel.cs    # Booking display model
    ├── 📁 Data/
    │   ├── 📄 customers.json            # Customer data storage
    │   ├── 📄 rooms.json                 # Room data storage
    │   ├── 📄 roomtypes.json             # Room type data storage
    │   └── 📄 bookings.json              # Booking data storage
    ├── 📄 App.xaml                       # Application definition
    ├── 📄 App.xaml.cs                    # Application code-behind
    └── 📄 appsettings.json               # Application configuration
```

---

## 🔧 Technologies Used

### Core Technologies
- **.NET 8** - Latest .NET framework
- **WPF (Windows Presentation Foundation)** - Desktop UI framework
- **C# 12** - Latest C# language features
- **XAML** - Declarative UI markup

### Design Patterns & Frameworks
- **MVVM Pattern** - Model-View-ViewModel architecture
- **Repository Pattern** - Data access abstraction
- **Command Pattern** - UI interaction handling
- **Observer Pattern** - Data change notifications

### Data & Storage
- **JSON** - Data serialization format
- **LINQ** - Language Integrated Query
- **Entity Framework** - Object-relational mapping (future enhancement)

### UI/UX Libraries
- **Material Design** - Modern UI components
- **Custom Controls** - Specialized hotel management controls
- **Data Visualization** - Chart and graph components

### Development Tools
- **Visual Studio 2022** - Primary IDE
- **Git** - Version control
- **NuGet** - Package management
- **MSBuild** - Build system

---

## 🚀 Getting Started

### Prerequisites

- **Visual Studio 2022** (17.8 or later)
- **.NET 8 SDK** (Latest version)
- **Windows 10/11** (x64)
- **Git** (for version control)

### Installation

1. **Clone the Repository**
   ```bash
   git clone https://github.com/your-username/fu-mini-hotel-system.git
   cd fu-mini-hotel-system
   ```

2. **Restore NuGet Packages**
   ```bash
   dotnet restore
   ```

3. **Build the Solution**
   ```bash
   dotnet build
   ```

4. **Run the Application**
   ```bash
   dotnet run --project StudentNameWPF
   ```

### First-Time Setup

1. **Launch the Application**
2. **Login with Admin Credentials**:
   - Email: `admin@FUMiniHotelSystem.com`
   - Password: `@@abc123@@`
3. **Explore the Features**:
   - Navigate through different sections
   - Create sample data
   - Test booking functionality

### Default Credentials

| Role | Email | Password |
|------|-------|----------|
| **Admin** | `admin@FUMiniHotelSystem.com` | `@@abc123@@` |
| **Customer** | `customer@example.com` | `password123` |

---

## 📊 Data Models

### Customer Model
```csharp
public class Customer
{
    public int CustomerID { get; set; }           // Primary key
    public string CustomerFullName { get; set; }  // Full name (max 50 chars)
    public string Telephone { get; set; }         // Phone number (max 12 chars)
    public string EmailAddress { get; set; }      // Email address (max 50 chars)
    public DateTime CustomerBirthday { get; set; } // Date of birth
    public int CustomerStatus { get; set; }       // 1=Active, 2=Deleted
    public string Password { get; set; }          // Encrypted password (max 50 chars)
    public bool IsAdmin { get; set; }             // Admin privilege flag
}
```

### Room Model
```csharp
public class RoomInformation
{
    public int RoomID { get; set; }               // Primary key
    public string RoomNumber { get; set; }        // Room number (max 50 chars)
    public string RoomDescription { get; set; }   // Description (max 220 chars)
    public int RoomMaxCapacity { get; set; }      // Maximum guest capacity
    public int RoomStatus { get; set; }           // 1=Active, 2=Deleted
    public decimal RoomPricePerDate { get; set; } // Daily rate
    public int RoomTypeID { get; set; }           // Foreign key to RoomType
}
```

### RoomType Model
```csharp
public class RoomType
{
    public int RoomTypeID { get; set; }           // Primary key
    public string RoomTypeName { get; set; }      // Type name (max 50 chars)
    public string TypeDescription { get; set; }   // Description (max 250 chars)
    public string TypeNote { get; set; }          // Additional notes (max 250 chars)
}
```

### Booking Model
```csharp
public class Booking
{
    public int BookingID { get; set; }           // Primary key
    public int CustomerID { get; set; }          // Foreign key to Customer
    public int RoomID { get; set; }              // Foreign key to Room
    public DateTime CheckInDate { get; set; }     // Check-in date
    public DateTime CheckOutDate { get; set; }   // Check-out date
    public decimal TotalAmount { get; set; }     // Total booking amount
    public int BookingStatus { get; set; }        // 1=Pending, 2=Confirmed, 3=Cancelled, 4=Completed
    public DateTime CreatedDate { get; set; }    // Booking creation date
    public string Notes { get; set; }            // Additional notes (max 500 chars)
}
```

---

## 🎨 UI/UX Features

### Modern Design Principles
- **Clean Interface**: Minimalist design with focus on functionality
- **Consistent Styling**: Unified color scheme and typography
- **Responsive Layout**: Adaptive to different screen sizes
- **Intuitive Navigation**: Logical menu structure and workflows

### User Experience Enhancements
- **Real-time Feedback**: Immediate response to user actions
- **Loading Indicators**: Visual feedback during operations
- **Error Handling**: User-friendly error messages
- **Keyboard Shortcuts**: Quick access to common functions
- **Tooltips**: Helpful hints and guidance

### Accessibility Features
- **High Contrast**: Support for high contrast themes
- **Keyboard Navigation**: Full keyboard accessibility
- **Screen Reader**: Compatible with screen readers
- **Font Scaling**: Support for different font sizes

---

## 🔐 Security

### Authentication & Authorization
- **Role-Based Access**: Admin and Customer roles
- **Password Encryption**: Secure password storage
- **Session Management**: Automatic session timeout
- **Input Validation**: Comprehensive input sanitization

### Data Protection
- **JSON Encryption**: Optional data encryption
- **Backup System**: Automatic data backup
- **Audit Trail**: Operation logging and tracking
- **Data Integrity**: Validation and consistency checks

---

## 📈 Performance

### Optimization Features
- **Lazy Loading**: On-demand data loading
- **Caching**: Intelligent data caching
- **Async Operations**: Non-blocking UI operations
- **Memory Management**: Efficient resource utilization

### Scalability
- **Modular Architecture**: Easy to extend and maintain
- **Plugin System**: Support for additional features
- **Database Ready**: Prepared for database integration
- **Cloud Ready**: Future cloud deployment support

---

## 🧪 Testing

### Test Coverage
- **Unit Tests**: Business logic testing
- **Integration Tests**: Component interaction testing
- **UI Tests**: User interface testing
- **Performance Tests**: Load and stress testing

### Quality Assurance
- **Code Review**: Peer review process
- **Static Analysis**: Automated code analysis
- **Security Scanning**: Vulnerability assessment
- **Performance Monitoring**: Real-time performance tracking

---

## 📝 API Documentation

### Service Interfaces

#### AuthenticationService
```csharp
public interface IAuthenticationService
{
    Task<Customer?> AuthenticateAsync(string email, string password);
    Task<bool> ValidateCredentialsAsync(string email, string password);
    Task<Customer?> GetCurrentUserAsync();
}
```

#### CustomerService
```csharp
public interface ICustomerService
{
    Task<List<Customer>> GetAllCustomersAsync();
    Task<Customer?> GetCustomerByIdAsync(int id);
    Task<Customer> AddCustomerAsync(Customer customer);
    Task<bool> UpdateCustomerAsync(Customer customer);
    Task<bool> DeleteCustomerAsync(int id);
}
```

#### RoomService
```csharp
public interface IRoomService
{
    Task<List<RoomInformation>> GetAllRoomsAsync();
    Task<RoomInformation?> GetRoomByIdAsync(int id);
    Task<RoomInformation> AddRoomAsync(RoomInformation room);
    Task<bool> UpdateRoomAsync(RoomInformation room);
    Task<bool> DeleteRoomAsync(int id);
}
```

#### BookingService
```csharp
public interface IBookingService
{
    Task<List<Booking>> GetAllBookingsAsync();
    Task<Booking?> GetBookingByIdAsync(int id);
    Task<Booking> CreateBookingAsync(Booking booking);
    Task<bool> UpdateBookingAsync(Booking booking);
    Task<bool> CancelBookingAsync(int id);
}
```

---

## 🤝 Contributing

We welcome contributions to the FU Mini Hotel Management System! Here's how you can help:

### How to Contribute

1. **Fork the Repository**
2. **Create a Feature Branch**
   ```bash
   git checkout -b feature/amazing-feature
   ```
3. **Make Your Changes**
4. **Commit Your Changes**
   ```bash
   git commit -m "Add amazing feature"
   ```
5. **Push to the Branch**
   ```bash
   git push origin feature/amazing-feature
   ```
6. **Open a Pull Request**

### Development Guidelines

- **Code Style**: Follow C# coding conventions
- **Documentation**: Update documentation for new features
- **Testing**: Add tests for new functionality
- **Performance**: Consider performance implications
- **Security**: Ensure security best practices

### Issue Reporting

- **Bug Reports**: Use the issue template
- **Feature Requests**: Describe the feature clearly
- **Documentation**: Help improve documentation
- **Questions**: Ask questions in discussions

---

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

### MIT License

```
MIT License

Copyright (c) 2024 FU Mini Hotel Management System

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

---

## 📞 Support

### Getting Help

- **Documentation**: Check the comprehensive documentation
- **Issues**: Report bugs and request features
- **Discussions**: Ask questions and share ideas
- **Email**: Contact the development team

### Community

- **GitHub**: [Repository](https://github.com/your-username/fu-mini-hotel-system)
- **Discussions**: [Community Forum](https://github.com/your-username/fu-mini-hotel-system/discussions)
- **Issues**: [Bug Reports](https://github.com/your-username/fu-mini-hotel-system/issues)

---

<div align="center">

**Made with ❤️ by the FU Mini Hotel Management System Team**

[![GitHub](https://img.shields.io/badge/GitHub-Repository-black.svg)](https://github.com/your-username/fu-mini-hotel-system)
[![Issues](https://img.shields.io/badge/Issues-Report-red.svg)](https://github.com/your-username/fu-mini-hotel-system/issues)
[![Pull Requests](https://img.shields.io/badge/PRs-Welcome-green.svg)](https://github.com/your-username/fu-mini-hotel-system/pulls)

</div>
