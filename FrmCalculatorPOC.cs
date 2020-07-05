using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pocCalculator
{
    public partial class FrmCalculatorPOC : Form
    {
        public FrmCalculatorPOC()
        {
            InitializeComponent();
        }

        private void FrmCalculatorPOC_Load(object sender, EventArgs e)
        {
            TxtDisplay.Text = "0";
            TxtMemory.Text = "";
            TxtOperation.Text = "";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text == "0")
            {
                TxtDisplay.Text = "1";
            }
            else
            {
                TxtDisplay.Text += "1";
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text == "0")
            {
                TxtDisplay.Text = "4";
            }
            else
            {
                TxtDisplay.Text += "4";
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text == "0")
            {
                TxtDisplay.Text = "7";
            }
            else
            {
                TxtDisplay.Text += "7";
            }
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (TxtOperation.Text == "")
            {
                TxtMemory.Text = TxtDisplay.Text;
            }
            else
            {
                if (TxtOperation.Text == "X") TxtMemory.Text = Convert.ToString(double.Parse(TxtMemory.Text) * double.Parse(TxtDisplay.Text));
                //if (TxtOperation.Text == "+") TxtMemory.Text = Convert.ToString(double.Parse(TxtMemory.Text) + double.Parse(TxtDisplay.Text));
            }
            TxtOperation.Text = "X";
            TxtDisplay.Text = "0";
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (TxtOperation.Text == "")
            {
                TxtMemory.Text = TxtDisplay.Text;

                TxtOperation.Text = "+";
                TxtDisplay.Text = "0";
            }
            else
            {
                if (TxtOperation.Text == "X") TxtMemory.Text = Convert.ToString(double.Parse(TxtMemory.Text) * double.Parse(TxtDisplay.Text));
                if (TxtOperation.Text == "+") TxtMemory.Text = Convert.ToString(double.Parse(TxtMemory.Text) + double.Parse(TxtDisplay.Text));

                TxtOperation.Text = "+";
                TxtDisplay.Text = "0";
            }
            //TxtOperation.Text = "+";
            //TxtDisplay.Text = "0";
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            if (TxtOperation.Text == "X")
            {
                TxtDisplay.Text = Convert.ToString(double.Parse(TxtMemory.Text) * double.Parse(TxtDisplay.Text));
            }
            if (TxtOperation.Text == "+")
            {
                TxtDisplay.Text = Convert.ToString(double.Parse(TxtMemory.Text) + double.Parse(TxtDisplay.Text));
            }
            TxtMemory.Text = "";
            TxtOperation.Text = "";
        }

    }
}

