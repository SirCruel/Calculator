using System.Data;
using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string previousExpression = "";
        private bool resultDisplayed = false;
        private double memoryValue = 0.0;
        public Form1()
        {
            InitializeComponent();
            textBoxAusgabe.TextChanged += TextBoxAusgabe_TextChanged;
        }
        private void TextBoxAusgabe_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAusgabe.Text.Contains("."))
            {
                textBoxAusgabe.Text = textBoxAusgabe.Text.Replace(".", ",");
            }
        }
        private void ZahlButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultDisplayed)
            {
              ClearBox();
              resultDisplayed = false; 
            }
            textBoxAusgabe.Text += button.Text;
            
        }


        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultDisplayed)
            {
                previousExpression = textBoxAusgabe.Text;
                resultDisplayed = false;
            }
            textBoxAusgabe.Text += " " + button.Text + " ";
        }

        private void GleichButton_Click(object sender, EventArgs e)
        {
            string ausdruck = textBoxAusgabe.Text.Replace(",", ".");
            try
            {
                previousExpression = ausdruck;
                var result = new DataTable().Compute(ausdruck, null);
                textBoxAusgabe.Text = result.ToString();
                textBox2.Text = previousExpression;
                textBoxAusgabe.Text = result.ToString();
                resultDisplayed = true;
                if (textBox2.Text.Contains("."))
                {
                    textBox2.Text = textBox2.Text.Replace(".", ",");
                }
            }
            catch (Exception)
            {
                textBoxAusgabe.Text = "Ungültiger Ausdruck";
            }
        }

        private void LöschenButton_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.Text = "";
            textBox2.Text = ""; 
        }

        private void WertLöschenButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxAusgabe.Text))
            {
                int length = textBoxAusgabe.Text.Length;
                textBoxAusgabe.Text = textBoxAusgabe.Text.Substring(0, length - length);
            }
        }

        private void ProzentButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAusgabe.Text))
            {
                try
                {
                    double eingabe = Convert.ToDouble(textBoxAusgabe.Text);
                    double prozentwert = eingabe / 100;
                    textBoxAusgabe.Text = prozentwert.ToString();
                }
                catch (Exception)
                {
                    textBoxAusgabe.Text = "Fehler";
                }
            }
        }
        private void einsTeilenButton_Click(object sender, EventArgs e)
        {
            double eingabe = Convert.ToDouble(textBoxAusgabe.Text);
            double einsTeilen = 1 / eingabe;
            textBoxAusgabe.Text = einsTeilen.ToString();
        }

        private void SqrButton_Click(object sender, EventArgs e)
        {
            double eingabe = Convert.ToDouble(textBoxAusgabe.Text);
            double sqr = eingabe * eingabe;
            textBoxAusgabe.Text = sqr.ToString();
        }
        private void WurzelButton_Click(object sender, EventArgs e)
        {
            double eingabe = Convert.ToDouble(textBoxAusgabe.Text);
            double wurzel = Math.Sqrt(eingabe);
            textBoxAusgabe.Text = wurzel.ToString();
        }
        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxAusgabe.Text))
            {
                textBoxAusgabe.Text = textBoxAusgabe.Text.Remove(textBoxAusgabe.Text.Length - 1);
            }
        }
        private void MCButton_Click(object sender, EventArgs e)
        {
            memoryValue = 0.0;
        }
        private void MRButton_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.Text = memoryValue.ToString();
        }
        private void MminusButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAusgabe.Text))
            {
                try
                {
                    double valueToSubtract = Convert.ToDouble(textBoxAusgabe.Text);
                    memoryValue -= valueToSubtract;
                }
                catch (Exception)
                {
                    textBoxAusgabe.Text = "Fehler";
                }
            }
        }
        private void MplusButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAusgabe.Text))
            {
                try
                {
                    double valueToAdd = Convert.ToDouble(textBoxAusgabe.Text);
                    memoryValue += valueToAdd;
                }
                catch (Exception)
                {
                    textBoxAusgabe.Text = "Fehler";
                }
            }
        }
        private void MSButton_Click(object sender, EventArgs e)
        {

        }
        private void ClearBox()
        {
            textBox2.Text = "";
            textBoxAusgabe.Text = "";
        }
        
    }
}
