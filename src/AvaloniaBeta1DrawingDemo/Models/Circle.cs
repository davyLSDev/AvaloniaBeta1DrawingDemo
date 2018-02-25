using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;

namespace AvaloniaBeta1DrawingDemo.Models
{
    public class Circle : Shape
    {
        public Circle(ContentControl drawingCanvas, Color color) : base(drawingCanvas, color) { }

        public override void Draw()
        {
            var circle = new Ellipse();
            var colorBrush = new SolidColorBrush();
            colorBrush.Color = this.color;
            circle.Fill = colorBrush;

            circle.Width = 400;
            circle.Height = 400;

            circle.Margin = new Thickness(0, 50, 0, 0);
            var container = new StackPanel();
            container.Children.Add(circle);
            this.drawingCanvas.Content = container;
        }
    }
}
