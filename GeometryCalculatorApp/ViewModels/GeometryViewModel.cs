using System.ComponentModel;
using System.Runtime.CompilerServices;
using GeometryCalculatorApp.Models;

namespace GeometryCalculatorApp.ViewModels
{
    public class GeometryViewModel : INotifyPropertyChanged
    {
        private double _width;
        private double _height;
        private string _result;

        public double Width
        {
            get => _width;
            set
            {
                _width = value;
                OnPropertyChanged();
            }
        }

        public double Height
        {
            get => _height;
            set
            {
                _height = value;
                OnPropertyChanged();
            }
        }

        public string Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }

        public void Calculate()
        {
            var model = new ShapeModel { Width = this.Width, Height = this.Height };
            double area = model.CalculateArea();
            double perimeter = model.CalculatePerimeter();
            double diagonal = model.CalculateDiagonal();
            double totalEdgeLength = model.CalculateTotalEdgeLength();
            Result = $"Area: {area}, Perimeter: {perimeter}, Diagonal: {diagonal}, Total Edge Length: {totalEdgeLength}";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}