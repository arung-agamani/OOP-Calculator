using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private InputHandler inputHandler;
        private MemoryFeature memory;

        public MainWindow()
        {
            InitializeComponent();
            inputHandler = new InputHandler();
            memory = new MemoryFeature();
            this.DisplayField.Text = inputHandler.getFormattedString();
        }

        private void ClearButtonClick(object sender, RoutedEventArgs e)
        {
            inputHandler = new InputHandler();
            memory = new MemoryFeature();
            this.DisplayField.Text = inputHandler.getFormattedString();
        }
    }
}
