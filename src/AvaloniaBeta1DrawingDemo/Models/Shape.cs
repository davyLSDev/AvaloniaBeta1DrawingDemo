using Avalonia.Controls;
using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaBeta1DrawingDemo.Models
{
    public abstract class Shape
    {
        protected ContentControl drawingCanvas;
        protected Color color;

        public Shape(ContentControl drawingCanvas, Color color)
        {
            this.drawingCanvas = drawingCanvas;
            this.color = color;
        }

        public abstract void Draw();
    }
}
