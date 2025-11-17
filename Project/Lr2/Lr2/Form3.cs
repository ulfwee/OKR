// Form3.cs
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Lr2
{
    public partial class Form3 : Form
    {
        public Form3(List<QuizResult> results)
        {
            InitializeComponent();
            LoadResults(results);
        }

        private void LoadResults(List<QuizResult> results)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Date & Time", typeof(string));
            dt.Columns.Add("Correct", typeof(int));
            dt.Columns.Add("Total", typeof(int));

            foreach (var r in results)
            {
                dt.Rows.Add(r.Date, r.CorrectAnswers, r.TotalQuestions);
            }

            dataGridView1.DataSource = dt;

            dataGridView1.ReadOnly = true;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
                this.Hide();
        }
    }
}