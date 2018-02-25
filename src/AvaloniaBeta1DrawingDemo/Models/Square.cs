using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;

namespace AvaloniaBeta1DrawingDemo.Models
{
    public class Square : Shape
    {
        public Square(ContentControl drawingCanvas, Color color) : base(drawingCanvas, color) { }

        public override void Draw()
        {
            var square = new Rectangle();
            var colorBrush = new SolidColorBrush();
            colorBrush.Color = this.color;
            square.Fill = colorBrush;

            square.Width = 400;
            square.Height = 400;

            square.Margin = new Thickness(0, 50, 0, 0);
            var container = new StackPanel();
            container.Children.Add(square);
            this.drawingCanvas.Content = container;
        }
    }
}
