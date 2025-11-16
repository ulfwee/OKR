using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LR2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) // Exit
        {
            Application.Exit();
        }
        private void pictureBox2_Click(object sender, EventArgs e) // View Results
        {
            //var results = LoadResults();
           // Form3 form3 = new Form3(results);
            this.Hide();
            //form3.Show();
        }
    }
}
