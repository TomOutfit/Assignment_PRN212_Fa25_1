# 🏨 FU Mini Hotel Management System

<div align="center">

![.NET](https://img.shields.io/badge/.NET-9.0-purple.svg)
![WPF](https://img.shields.io/badge/WPF-Desktop-blue.svg)
![C#](https://img.shields.io/badge/C%23-12.0-green.svg)
![MVVM](https://img.shields.io/badge/Pattern-MVVM-orange.svg)
![Architecture](https://img.shields.io/badge/Architecture-3--Layer-red.svg)

**A comprehensive Hotel Management System built with WPF (.NET 9) and following 3-layer architecture with MVVM pattern**

</div>

---

## 📋 Table of Contents

- [🎯 Overview](#-overview)
- [✨ Features](#-features)
- [🏗️ Architecture](#️-architecture)
- [📁 Project Structure](#-project-structure)
- [🔧 Technologies Used](#-technologies-used)
- [🚀 Getting Started](#-getting-started)
- [🎨 UI/UX Features](#-uiux-features)
- [🔐 Security](#-security)
- [📈 Performance](#-performance)

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





