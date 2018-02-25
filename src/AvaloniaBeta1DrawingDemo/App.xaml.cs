using Avalonia;
using Avalonia.Markup.Xaml;

namespace AvaloniaBeta1DrawingDemo
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
