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
    }
}
