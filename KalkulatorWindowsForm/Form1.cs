using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorWindowsForm
{
    public partial class Form1 : Form
    {
        Double nilaiHasil = 0;
        String lakukanPenghitungan = "";
        bool apakahLakukanPenghitungan = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBoxHasil.Text == "0")
            {
                textBoxHasil.Clear();
            }

            Button tombol = (Button) sender;
            textBoxHasil.Text = textBoxHasil.Text + tombol.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;
            lakukanPenghitungan = tombol.Text;
            nilaiHasil = Double.Parse(textBoxHasil.Text);
        }

        private void tombolCE_Click(object sender, EventArgs e)
        {
            textBoxHasil.Text = "0";
        }

        private void tombolC_Click(object sender, EventArgs e)
        {
            textBoxHasil.Text = "0";
            nilaiHasil = 0;
        }

        private void tombolSamaDengan_Click(object sender, EventArgs e)
        {
            switch (lakukanPenghitungan){
                case "+":
                textBoxHasil.Text = (nilaiHasil + Double.Parse(textBoxHasil.Text)).ToString() ;
                break;
                case "-": 
                textBoxHasil.Text = (nilaiHasil + Double.Parse(textBoxHasil.Text)).ToString() ;
                break;
                case "/":
                textBoxHasil.Text = (nilaiHasil + Double.Parse(textBoxHasil.Text)).ToString() ;
                break;
                case "*":
                textBoxHasil.Text = (nilaiHasil + Double.Parse(textBoxHasil.Text)).ToString() ;
                break;
                default:
                break;
            }
        }
    }
}
