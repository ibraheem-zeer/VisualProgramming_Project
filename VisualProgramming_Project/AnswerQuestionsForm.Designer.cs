namespace VisualProgramming_Project
{
    partial class AnswerQuestionsForm
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
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            SubmitBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 0;
            label1.Text = "Question";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(103, 133);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 29);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(103, 189);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(141, 29);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(103, 244);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(141, 29);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(103, 301);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(141, 29);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(115, 353);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(112, 34);
            SubmitBtn.TabIndex = 5;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // AnswerQuestionsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 450);
            Controls.Add(SubmitBtn);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Name = "AnswerQuestionsForm";
            Text = "AnswerQuestions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button SubmitBtn;
    }
}