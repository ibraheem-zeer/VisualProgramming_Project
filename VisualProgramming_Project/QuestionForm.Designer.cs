namespace VisualProgramming_Project
{
    partial class QuestionForm
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
            ExamDetails = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox6 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)ExamDetails).BeginInit();
            SuspendLayout();
            // 
            // ExamDetails
            // 
            ExamDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExamDetails.Location = new Point(12, 32);
            ExamDetails.Name = "ExamDetails";
            ExamDetails.RowHeadersWidth = 62;
            ExamDetails.Size = new Size(1187, 225);
            ExamDetails.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 304);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 378);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(378, 31);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(167, 446);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(378, 31);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(167, 513);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(378, 31);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(167, 589);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(378, 31);
            textBox5.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 350);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 6;
            label1.Text = "السؤال الاول";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 418);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.Location = new Point(167, 693);
            button1.Name = "button1";
            button1.Size = new Size(378, 34);
            button1.TabIndex = 8;
            button1.Text = "Add Question";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(167, 645);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(378, 31);
            textBox6.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(798, 304);
            button2.Name = "button2";
            button2.Size = new Size(378, 34);
            button2.TabIndex = 11;
            button2.Text = "Remove Question";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(798, 375);
            button3.Name = "button3";
            button3.Size = new Size(378, 34);
            button3.TabIndex = 12;
            button3.Text = "Update Question";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // QuestionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 775);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(ExamDetails);
            Name = "QuestionForm";
            Text = "ExamForm";
            Load += QuestionForm_Load;
            ((System.ComponentModel.ISupportInitialize)ExamDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ExamDetails;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox6;
        private Button button2;
        private Button button3;
    }
}