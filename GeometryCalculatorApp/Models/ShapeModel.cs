using System;

namespace GeometryCalculatorApp.Models
{
    // Model reprezentujący prostokąt i zawierający metody do obliczeń geometrycznych
    public class ShapeModel
    {
        // Szerokość prostokąta
        public double Width { get; set; }

        // Wysokość prostokąta
        public double Height { get; set; }

        // Metoda obliczająca powierzchnię prostokąta
        public double CalculateArea()
        {
            return Width * Height;
        }

        // Metoda obliczająca obwód prostokąta
        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        // Metoda obliczająca przekątną prostokąta
        public double CalculateDiagonal()
        {
            return Math.Sqrt(Width * Width + Height * Height);
        }

        // Metoda obliczająca sumę długości wszystkich boków prostokąta
        public double CalculateTotalEdgeLength()
        {
            return 2 * Width + 2 * Height;
        }
    }
}