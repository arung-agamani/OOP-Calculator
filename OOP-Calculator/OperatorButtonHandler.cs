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
        protected double answer;
        private void AnsButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (answer == 0.0f)
                {
                    throw new Exception("No evaluation yet");
                }
                inputHandler.concat("Ans");
                this.DisplayField.Text = inputHandler.getFormattedString();
            } catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
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
            memory.Record(answer);
        }

        private void MCButtonClick(object sender, RoutedEventArgs e)
        {
            inputHandler.setNumeric(memory.Copy());
            DisplayField.Text = inputHandler.getFormattedString();
        }

        private void EvaluateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double ans = inputHandler.evaluate();
                answer = ans;
                memory.Record(ans);
                DisplayField.Text = ans.ToString();
                inputHandler.flush();
                inputHandler.setNumeric(ans);
            } catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            
        }
    }
}
