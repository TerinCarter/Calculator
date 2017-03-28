using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MyForm : Form
    {
        CalculatorComponent calculator;

        private void Idle(object sender, EventArgs e)
        {
            btnAdd.Enabled = btnSubstract.Enabled = btnMultiply.Enabled = btnDivide.Enabled = tbxOperand1.Text != "" && tbxOperand2.Text != "";
        }

        public MyForm()
        {
            InitializeComponent();
            Application.Idle += Idle;
            calculator = new CalculatorComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int a, b;
            if (Int32.TryParse(tbxOperand1.Text, out a) && Int32.TryParse(tbxOperand2.Text, out b))
                tbxResult.Text = calculator.Add(a, b).ToString();
            else
                MessageBox.Show("Операнды имеют неверный формат!");
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            int a, b;
            if (Int32.TryParse(tbxOperand1.Text, out a) && Int32.TryParse(tbxOperand2.Text, out b))
                tbxResult.Text = calculator.Substract(a, b).ToString();
            else
                MessageBox.Show("Операнды имеют неверный формат!");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int a, b;
            if (Int32.TryParse(tbxOperand1.Text, out a) && Int32.TryParse(tbxOperand2.Text, out b))
                tbxResult.Text = calculator.Multiply(a, b).ToString();
            else
                MessageBox.Show("Операнды имеют неверный формат!");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int a, b;
            if (Int32.TryParse(tbxOperand1.Text, out a) && Int32.TryParse(tbxOperand2.Text, out b))
                try
                {
                    tbxResult.Text = calculator.Divide(a, b).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            else
                MessageBox.Show("Операнды имеют неверный формат!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxOperand1.Clear();
            tbxOperand2.Clear();
            tbxResult.Clear();
        }
    }
}
