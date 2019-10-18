using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppPractice2
{
    public partial class CalculatorUi : Form
    {
        public CalculatorUi()
        {
            InitializeComponent();
        }
        Calculator _calculator = new Calculator();
        
        

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            _calculator.firstnumber =Convert.ToDouble( firstNumberTextBox.Text);
            _calculator.secondnumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = _calculator.add().ToString();
            firstNumberTextBox.Clear();
            secondNumberTextBox.Clear();
           

        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            _calculator.firstnumber = Convert.ToDouble(firstNumberTextBox.Text);
            _calculator.secondnumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = _calculator.subtract().ToString();
            firstNumberTextBox.Clear();
            secondNumberTextBox.Clear();
           

        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            _calculator.firstnumber = Convert.ToDouble(firstNumberTextBox.Text);
            _calculator.secondnumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = _calculator.multiply().ToString();
            firstNumberTextBox.Clear();
            secondNumberTextBox.Clear();
            

        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            _calculator.firstnumber = Convert.ToDouble(firstNumberTextBox.Text);
            _calculator.secondnumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = _calculator.division().ToString();
            firstNumberTextBox.Clear();
            secondNumberTextBox.Clear();
           

        }
    }
}
