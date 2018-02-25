using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;
using System.Collections.Generic;

namespace AvaloniaBeta1DrawingDemo.Models
{
    public class Triangle : Shape
    {
        public Triangle(ContentControl drawingCanvas, Color color) : base(drawingCanvas, color) { }

        public override void Draw()
        {
            var triangle = new Polygon();
            triangle.Points = new List<Point>
            {
                new Point(300, 200),
                new Point(400, 125),
                new Point(400, 275),
                new Point(300, 200)
            };

            var colorBrush = new SolidColorBrush();
            colorBrush.Color = Colors.Blue;
            triangle.Fill = colorBrush;

            triangle.Width = 400;
            triangle.Height = 400;
            triangle.Stretch = Stretch.Fill;
            triangle.Margin = new Thickness(0, 50, 0, 0);

            var container = new StackPanel();
            container.Children.Add(triangle);
            this.drawingCanvas.Content = container;
        }
    }
}
