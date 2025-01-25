using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2(String text)
        {
            InitializeComponent();
            label1.Text = text;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            // funkcja start
            this.Close();
        }
    }
}
