using System;

namespace GeometryCalculatorApp.Models
{
    public class ShapeModel
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        public double CalculateDiagonal()
        {
            return Math.Sqrt(Width * Width + Height * Height);
        }

        public double CalculateTotalEdgeLength()
        {
            return 2 * Width + 2 * Height;
        }
    }
}