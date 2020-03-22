using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace OOP_Calculator
{
    public partial class MainWindow
    {
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            inputHandler.concatNumber((sender as Button).Content.ToString());
            this.DisplayField.Text = inputHandler.getFormattedString();
        }
    }
}
