// Form2.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace Lr2
{
    public partial class Form2 : Form
    {
        private List<Quiz> questions = new List<Quiz>();
        private int currentIndex = 0;
        private readonly Dictionary<int, string> userAnswers = new Dictionary<int, string>();

        public Form2()
        {
            InitializeComponent();
            LoadQuestions();
            DisplayQuestion();

            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
            radioButton3.CheckedChanged += RadioButton_CheckedChanged;
            radioButton4.CheckedChanged += RadioButton_CheckedChanged;
        }

        private void LoadQuestions()
        {
            string filePath = "D:\\коледж\\ОКР\\ЛР2\\Project\\Lr2\\questions.json";

            if (File.Exists(filePath))
            {
                try
                {
                    string jsonContent = File.ReadAllText(filePath);
                    questions = JsonSerializer.Deserialize<List<Quiz>>(jsonContent) ?? new List<Quiz>();

                    if (questions.Count == 0)
                        MessageBox.Show("JSON file is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("questions.json not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DisplayQuestion()
        {
            foreach (RadioButton rb in groupBox1.Controls.OfType<RadioButton>())
                rb.Checked = false;

            if (questions.Count == 0) return;

            var q = questions[currentIndex];
            textBox1.Text = $"{currentIndex + 1}. {q.Question}";

            radioButton1.Text = q.Options[0];
            radioButton2.Text = q.Options[1];
            radioButton3.Text = q.Options[2];
            radioButton4.Text = q.Options[3];

            if (userAnswers.TryGetValue(currentIndex, out string saved))
            {
                var rb = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Text == saved);
                if (rb != null) rb.Checked = true;
            }

            button3.Enabled = currentIndex > 0;
            UpdateNextButton();
        }

        private void UpdateNextButton()
        {
            bool hasAnswer = groupBox1.Controls.OfType<RadioButton>().Any(r => r.Checked);
            button2.Enabled = currentIndex < questions.Count - 1 || hasAnswer;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb == null || !rb.Checked) return;

            userAnswers[currentIndex] = rb.Text;
            UpdateNextButton();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer();

            if (currentIndex < questions.Count - 1)
            {
                currentIndex++;
                DisplayQuestion();
            }
            else
            {
                FinishQuiz();
            }
        }

        private void SaveCurrentAnswer()
        {
            var checkedRb = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedRb != null)
                userAnswers[currentIndex] = checkedRb.Text;
        }

        private void FinishQuiz()
        {
            int correct = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                if (userAnswers.TryGetValue(i, out string ans) && ans == questions[i].CorrectAnswer)
                    correct++;
            }

            var result = new QuizResult
            {
                Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                CorrectAnswers = correct,
                TotalQuestions = questions.Count
            };

            string filePath = Path.Combine(Application.StartupPath, "results.json");
            var allResults = new List<QuizResult>();

            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    allResults = JsonSerializer.Deserialize<List<QuizResult>>(json) ?? new List<QuizResult>();
                }
                catch { }
            }

            allResults.Add(result);
            File.WriteAllText(filePath, JsonSerializer.Serialize(allResults, new JsonSerializerOptions { WriteIndented = true }));

            Form3 form3 = new Form3(allResults);
            this.Hide();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayQuestion();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var results = LoadResults();
            Form3 form3 = new Form3(results);
            this.Hide();
            form3.Show();
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