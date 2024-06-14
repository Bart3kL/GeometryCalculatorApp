using System.Windows;
using System.Windows.Controls;
using GeometryCalculatorApp.ViewModels;

namespace GeometryCalculatorApp.Views
{
    public partial class GeometryView : UserControl
    {
        private GeometryViewModel _viewModel;

        public GeometryView()
        {
            InitializeComponent();
            _viewModel = new GeometryViewModel();
            DataContext = _viewModel;
        }

        private void OnCalculateClick(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(WidthTextBox.Text, out double width) && double.TryParse(HeightTextBox.Text, out double height))
            {
                _viewModel.Width = width;
                _viewModel.Height = height;
                _viewModel.Calculate();
                ResultTextBlock.Text = _viewModel.Result;
            }
            else
            {
                ResultTextBlock.Text = "Invalid input. Please enter numeric values.";
            }
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && (textBox.Text == "Enter width" || textBox.Text == "Enter height"))
            {
                textBox.Text = string.Empty;
            }
        }

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