using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Average.Weekly.Cases ;

namespace weekly_average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static int counter = 0;
        double sum = 0;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                counter++;
                if (counter > 7)
                {
                    btnEnter.Enabled = false;
                    txtInput.ReadOnly = true;
                    txtInput.Clear();
                    lblResult.Text = "Average: " + (sum / 7).ToString("F2");
                }
                else
                {
                    int value = int.Parse(txtInput.Text);
                    if (value < 0 || value > int.MaxValue)
                        throw new ArgumentOutOfRangeException("Enter valid number of cases...");
                    sum += value;
                    txtCases.AppendText(value + "\r\n");
                    lblDays.Text = "Day " + counter;
                    txtInput.Clear();
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnEnter.Enabled = true;
            txtInput.ReadOnly = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

