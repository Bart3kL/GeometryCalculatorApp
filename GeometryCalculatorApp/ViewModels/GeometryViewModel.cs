using System.ComponentModel;
using System.Runtime.CompilerServices;
using GeometryCalculatorApp.Models;

namespace GeometryCalculatorApp.ViewModels
{
    // Klasa ViewModel, która łączy model z widokiem i zarządza stanem aplikacji
    public class GeometryViewModel : INotifyPropertyChanged
    {
        private double _width;
        private double _height;
        private string _result;

        // Właściwość Width z powiadomieniem o zmianie
        public double Width
        {
            get => _width;
            set
            {
                _width = value;
                OnPropertyChanged();
            }
        }

        // Właściwość Height z powiadomieniem o zmianie
        public double Height
        {
            get => _height;
            set
            {
                _height = value;
                OnPropertyChanged();
            }
        }

        // Właściwość Result z powiadomieniem o zmianie
        public string Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }

        // Metoda Calculate wykonująca obliczenia i ustawiająca wynik
        public void Calculate()
        {
            var model = new ShapeModel { Width = this.Width, Height = this.Height };
            double area = model.CalculateArea();
            double perimeter = model.CalculatePerimeter();
            double diagonal = model.CalculateDiagonal();
            double totalEdgeLength = model.CalculateTotalEdgeLength();
            Result = $"Area: {area}, Perimeter: {perimeter}, Diagonal: {diagonal}, Total Edge Length: {totalEdgeLength}";
        }

        // Implementacja interfejsu INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        // Metoda powiadamiająca o zmianie właściwości
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}