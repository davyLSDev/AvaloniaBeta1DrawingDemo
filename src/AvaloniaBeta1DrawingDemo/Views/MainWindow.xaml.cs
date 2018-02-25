using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace AvaloniaBeta1DrawingDemo.Views
{
    public class MainWindow : Window
    {
        private Button btnCreateCircle;
        private Button btnCreateSquare;
        private Button btnCreateTriangle;
        private ContentControl drawingCanvas;

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            this.btnCreateCircle = this.Find<Button>("btnCreateCircle");
            this.btnCreateCircle.Click += BtnCreateCircle_Click;
            this.btnCreateSquare = this.Find<Button>("btnCreateSquare");
            this.btnCreateSquare.Click += BtnCreateSquare_Click;     
            this.btnCreateTriangle = this.Find<Button>("btnCreateTriangle");
            this.btnCreateTriangle.Click += BtnCreateTriangle_Click;
            this.drawingCanvas = this.Find<ContentControl>("drawingCanvas");
        }

        private void DrawShape(Models.Shape shape)
        {
            shape.Draw();
        }

        private void BtnCreateTriangle_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var triangle = new Models.Triangle(this.drawingCanvas, Colors.Blue);
            this.DrawShape(triangle);
        }

        private void BtnCreateSquare_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var square = new Models.Square(this.drawingCanvas, Colors.Green);
            this.DrawShape(square);
        }

        private void BtnCreateCircle_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var circle = new Models.Circle(this.drawingCanvas, Colors.Red);
            this.DrawShape(circle);
        }
    }
}
