CMCSGUI

Overview

CMCSGUI is a **.NET 9.0 ASP.NET Core MVC application** that provides a graphical user interface (GUI) for managing claims data. It follows a standard MVC pattern with controllers, models, and views, making it easy to extend and maintain.

Features

* ASP.NET Core MVC architecture
* Claims management module (`ClaimsController`, `Claim` model)
* Configurable settings via `appsettings.json`
* Error handling through `ErrorViewModel`
* Ready-to-run .NET 9.0 executable build

Project Structure

```
CMCSGUI/
├── Controllers/          # MVC controllers (e.g., ClaimsController, HomeController)
├── Models/               # Data models (e.g., Claim, ErrorViewModel)
├── Views/                # Razor views (if implemented)
├── Program.cs            # Application entry point
├── appsettings.json      # Configuration file
├── CMCSGUI.csproj        # Project file
├── CMCSGUI.sln           # Solution file
└── bin/                  # Build outputs (executables, DLLs)
```

Requirements

* **.NET 9.0 SDK** (or higher)
* Visual Studio 2022+ or VS Code with C# extension
* Windows/Linux/macOS supported

Getting Started

1. **Clone or extract** the project files.

   ```bash
   git clone <repo-url>
   cd CMCSGUI
   ```

2. **Restore dependencies**

   ```bash
   dotnet restore
   ```

3. **Build the project**

   ```bash
   dotnet build
   ```

4. **Run the application**

   ```bash
   dotnet run
   ```

   The application will start and be available at `http://localhost:5000` (or as configured).

Configuration

* Update `appsettings.json` and `appsettings.Development.json` with your environment-specific settings.
* Supports standard ASP.NET Core configuration for logging, database connections, etc.

Development Notes

* Controllers are located in `Controllers/`
* Models are located in `Models/`
* Razor views (if present) should be in `Views/`
* Debug builds output to `bin/Debug/net9.0/`

License

This project currently does not specify a license. Please add one if you intend to distribute it.


