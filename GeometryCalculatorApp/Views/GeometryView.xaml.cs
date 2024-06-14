using System.Windows;
using System.Windows.Controls;
using GeometryCalculatorApp.ViewModels;

namespace GeometryCalculatorApp.Views
{
    // Klasa kodu-behind dla widoku GeometryView.xaml
    public partial class GeometryView : UserControl
    {
        private GeometryViewModel _viewModel;

        // Konstruktor inicjalizujący widok i ustawiający DataContext
        public GeometryView()
        {
            InitializeComponent();
            _viewModel = new GeometryViewModel();
            DataContext = _viewModel;
        }

        // Obsługa kliknięcia przycisku Calculate
        private void OnCalculateClick(object sender, RoutedEventArgs e)
        {
            // Sprawdzenie poprawności wprowadzonych danych
            if (double.TryParse(WidthTextBox.Text, out double width) && double.TryParse(HeightTextBox.Text, out double height))
            {
                // Ustawienie wartości szerokości i wysokości w ViewModel
                _viewModel.Width = width;
                _viewModel.Height = height;

                // Wywołanie metody Calculate w ViewModel
                _viewModel.Calculate();

                // Wyświetlenie wyników obliczeń
                ResultTextBlock.Text = _viewModel.Result;
            }
            else
            {
                // Wyświetlenie komunikatu o błędzie w przypadku niepoprawnych danych
                ResultTextBlock.Text = "Invalid input. Please enter numeric values.";
            }
        }

        // Obsługa zdarzenia GotFocus dla TextBox
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && (textBox.Text == "Enter width" || textBox.Text == "Enter height"))
            {
                textBox.Text = string.Empty;
            }
        }

        // Obsługa zdarzenia LostFocus dla TextBox
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Name == "WidthTextBox" ? "Enter width" : "Enter height";
            }
        }
    }
}