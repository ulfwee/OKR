<<<<<<< HEAD
// Form1.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

=======
>>>>>>> 6b47de9 (Changes)
namespace Lr2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var results = LoadResults();
            Form3 form3 = new Form3(results);
            form3.Show();
            this.Hide();
        }

        private List<QuizResult> LoadResults()
        {
            string filePath = Path.Combine(Application.StartupPath, "results.json");
            if (!File.Exists(filePath)) return new List<QuizResult>();

            try
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<QuizResult>>(json) ?? new List<QuizResult>();
            }
            catch
            {
                return new List<QuizResult>();
            }
        }
    }
}
=======
    }
}
>>>>>>> 6b47de9 (Changes)
