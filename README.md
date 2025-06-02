# BestStoreMVC 

An e-commerce platform built with ASP.NET Core MVC for browsing and purchasing electronic devices. The application demonstrates standard MVC patterns with Entity Framework Core for data persistence and a clean, responsive web interface.

## Features

- **Product Management**: Add, update, and delete product details.
- **Customer Management**: Maintain customer information and purchase history.
- **Order Processing**: Manage order placements, updates, and cancellations.
- **Reporting**: Generate sales and inventory reports.

## Technology Stack

- **Framework**: ASP.NET Core 8.0
- **Language**: C#
- **Database**: SQL Server with Entity Framework Core
- **Frontend**: HTML, CSS, JavaScript, Bootstrap
- **View Engine**: Razor Pages

## Prerequisites

- .NET 8.0 SDK
- SQL Server (LocalDB or full instance)
- Visual Studio 2022 or VS Code

## Installation & Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/Mahmoud-Ayman-Saleh/BestStoreMVC.git
   cd BestStoreMVC
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Configure Database Connection**
   - Update the connection string in `appsettings.json` to point to your SQL Server instance
   - The application uses Entity Framework Core with SQL Server

4. **Run Database Migrations**
   ```bash
   dotnet ef database update
   ```

5. **Build the application**
   ```bash
   dotnet build
   ```

## Running the Application

### Development Mode
```bash
dotnet run
```

The application will start and be available at `https://localhost:5001` or `http://localhost:5000`.




## Configuration

The application uses standard ASP.NET Core configuration:
- Database connection strings in `appsettings.json`
- Static files served from `wwwroot` directory
- Default routing pattern: `{controller=Home}/{action=Index}/{id?}`

## Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Submit a pull request

## License
This project is licensed under the MIT License

## Contact
- Author: Mahmoud Ayman
- Email: mahmoud.ayman.fcai@gmail.com
