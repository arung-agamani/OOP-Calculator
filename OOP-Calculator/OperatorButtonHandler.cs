using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OOP_Calculator
{
    public partial class MainWindow
    {
        private void AnsButtonClick(object sender, RoutedEventArgs e)
        {
            inputHandler.concat("Ans");
            this.DisplayField.Text = inputHandler.getFormattedString();
        }

        private void PlusButtonClick(object sender, RoutedEventArgs e)
        {
            inputHandler.concat(new Operator("+"));
            this.DisplayField.Text = inputHandler.getFormattedString();
        }
        
        private void MinusButtonClick(object sender, RoutedEventArgs e)
        {
            inputHandler.concat(new Operator("-"));
            this.DisplayField.Text = inputHandler.getFormattedString();
        }

        private void MultiplyButtonClick(object sender, RoutedEventArgs e)
        {
            inputHandler.concat(new Operator("*"));
            this.DisplayField.Text = inputHandler.getFormattedString();
        }

        private void DivideButtonClick(object sender, RoutedEventArgs e)
        {
            inputHandler.concat(new Operator("/"));
            this.DisplayField.Text = inputHandler.getFormattedString();
        }

        private void RootButtonClick(object sender, RoutedEventArgs e)
        {
            inputHandler.concat(new Operator("r"));
            this.DisplayField.Text = inputHandler.getFormattedString();
        }

        private void MRButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void MCButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void EvaluateButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
