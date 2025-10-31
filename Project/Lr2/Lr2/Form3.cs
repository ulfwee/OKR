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

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Back button
            Button btnBack = new Button
            {
                Text = "Back to Menu",
                Dock = DockStyle.Bottom,
                Height = 40
            };
            btnBack.Click += (s, e) =>
            {
                new Form1().Show();
                this.Hide();
            };

            this.Controls.Add(btnBack);
            dataGridView1.Dock = DockStyle.Fill;
            this.Controls.SetChildIndex(dataGridView1, 0);
        }
    }
}