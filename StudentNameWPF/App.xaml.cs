using System.Configuration;
using System.Data;
using System.Windows;

namespace StudentNameWPF;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("Application starting up...");
            base.OnStartup(e);
            
            // Create and show the LoginWindow
            System.Diagnostics.Debug.WriteLine("Creating LoginWindow...");
            var loginWindow = new Views.LoginWindow();
            System.Diagnostics.Debug.WriteLine("LoginWindow created, showing window...");
            loginWindow.Show();
            System.Diagnostics.Debug.WriteLine("LoginWindow shown successfully");
            
            System.Diagnostics.Debug.WriteLine("Application startup completed successfully");
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Application startup failed: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
            MessageBox.Show($"Application startup failed: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            throw;
        }
    }

    protected override void OnExit(ExitEventArgs e)
    {
        System.Diagnostics.Debug.WriteLine($"Application exiting with code: {e.ApplicationExitCode}");
        base.OnExit(e);
    }
}

