using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBI_Body
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mbi = (Convert.ToInt32(tbGhad.Text) - 100) - ((Convert.ToInt32(tbGhad.Text) - 150) / 4);
            if (mbi > Convert.ToInt32(tbWeight.Text))
                MessageBox.Show(" کاهش وزن هستید "+" kg " +" شما دارای " + (mbi - Convert.ToDouble(tbWeight.Text)) , "وزن" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            else if (mbi < Convert.ToInt32(tbWeight.Text))
                MessageBox.Show(" اضافه وزن هستید "+ " kg " + " شما دارای " + (Convert.ToDouble(tbWeight.Text) - mbi) , "وزن", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("شما دارای وزن مناسب هستید", "وزن", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
