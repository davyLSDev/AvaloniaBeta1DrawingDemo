using System;
using Avalonia;
using Avalonia.Logging.Serilog;
using AvaloniaBeta1DrawingDemo.ViewModels;
using AvaloniaBeta1DrawingDemo.Views;

namespace AvaloniaBeta1DrawingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildAvaloniaApp().Start<MainWindow>(() => new MainWindowViewModel());
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .UseReactiveUI()
                .LogToDebug();
    }
}
