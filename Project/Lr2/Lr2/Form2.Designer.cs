namespace Lr2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            progressBar1 = new ProgressBar();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            radioButton4 = new RadioButton();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.Tomato;
            progressBar1.Location = new Point(-2, 303);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(591, 25);
            progressBar1.TabIndex = 0;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButton1.Location = new Point(6, 14);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(120, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButton2.Location = new Point(6, 54);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(122, 24);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButton3.Location = new Point(6, 95);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(122, 24);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.PeachPuff;
            button1.Font = new Font("Comic Sans MS", 9F);
            button1.Location = new Point(183, 249);
            button1.Name = "button1";
            button1.Size = new Size(207, 37);
            button1.TabIndex = 7;
            button1.Text = "Вийти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PeachPuff;
            button2.Font = new Font("Comic Sans MS", 9F);
            button2.Location = new Point(424, 243);
            button2.Name = "button2";
            button2.Size = new Size(109, 49);
            button2.TabIndex = 8;
            button2.Text = "ᐅ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.klipartz_com;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(533, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 41);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PeachPuff;
            button3.Font = new Font("Comic Sans MS", 9F);
            button3.Location = new Point(46, 243);
            button3.Name = "button3";
            button3.Size = new Size(109, 49);
            button3.TabIndex = 10;
            button3.Text = "ᐊ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButton4.Location = new Point(6, 135);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(122, 24);
            radioButton4.TabIndex = 11;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Location = new Point(24, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 165);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(12, 7);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(499, 55);
            textBox1.TabIndex = 13;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(588, 328);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Name = "Form2";
            Text = "Питання";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
        private Button button3;
        private RadioButton radioButton4;
        private GroupBox groupBox1;
        private TextBox textBox1;
    }
}