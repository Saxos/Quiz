namespace Quiz
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.nextQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.questionTextField = new System.Windows.Forms.TextBox();
            this.q1RadioButton = new System.Windows.Forms.RadioButton();
            this.q2RadioButton = new System.Windows.Forms.RadioButton();
            this.q3RadioButton = new System.Windows.Forms.RadioButton();
            this.q4RadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pktTextBox = new System.Windows.Forms.TextBox();
            this.savePktButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(780, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            // 
            // nextQuestion
            // 
            this.nextQuestion.Location = new System.Drawing.Point(12, 41);
            this.nextQuestion.Name = "nextQuestion";
            this.nextQuestion.Size = new System.Drawing.Size(136, 23);
            this.nextQuestion.TabIndex = 1;
            this.nextQuestion.Text = "Nächste Frage";
            this.nextQuestion.UseVisualStyleBackColor = true;
            this.nextQuestion.Click += new System.EventHandler(this.nextQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frage";
            // 
            // questionTextField
            // 
            this.questionTextField.Location = new System.Drawing.Point(52, 85);
            this.questionTextField.Name = "questionTextField";
            this.questionTextField.Size = new System.Drawing.Size(740, 20);
            this.questionTextField.TabIndex = 3;
            // 
            // q1RadioButton
            // 
            this.q1RadioButton.AutoSize = true;
            this.q1RadioButton.Location = new System.Drawing.Point(12, 132);
            this.q1RadioButton.Name = "q1RadioButton";
            this.q1RadioButton.Size = new System.Drawing.Size(61, 17);
            this.q1RadioButton.TabIndex = 4;
            this.q1RadioButton.TabStop = true;
            this.q1RadioButton.Text = "Frage 1";
            this.q1RadioButton.UseVisualStyleBackColor = true;
            // 
            // q2RadioButton
            // 
            this.q2RadioButton.AutoSize = true;
            this.q2RadioButton.Location = new System.Drawing.Point(12, 155);
            this.q2RadioButton.Name = "q2RadioButton";
            this.q2RadioButton.Size = new System.Drawing.Size(61, 17);
            this.q2RadioButton.TabIndex = 5;
            this.q2RadioButton.TabStop = true;
            this.q2RadioButton.Text = "Frage 2";
            this.q2RadioButton.UseVisualStyleBackColor = true;
            // 
            // q3RadioButton
            // 
            this.q3RadioButton.AutoSize = true;
            this.q3RadioButton.Location = new System.Drawing.Point(12, 178);
            this.q3RadioButton.Name = "q3RadioButton";
            this.q3RadioButton.Size = new System.Drawing.Size(61, 17);
            this.q3RadioButton.TabIndex = 6;
            this.q3RadioButton.TabStop = true;
            this.q3RadioButton.Text = "Frage 3";
            this.q3RadioButton.UseVisualStyleBackColor = true;
            // 
            // q4RadioButton
            // 
            this.q4RadioButton.AutoSize = true;
            this.q4RadioButton.Location = new System.Drawing.Point(12, 201);
            this.q4RadioButton.Name = "q4RadioButton";
            this.q4RadioButton.Size = new System.Drawing.Size(61, 17);
            this.q4RadioButton.TabIndex = 7;
            this.q4RadioButton.TabStop = true;
            this.q4RadioButton.Text = "Frage 4";
            this.q4RadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(530, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Punktestand";
            // 
            // pktTextBox
            // 
            this.pktTextBox.Location = new System.Drawing.Point(646, 127);
            this.pktTextBox.Name = "pktTextBox";
            this.pktTextBox.Size = new System.Drawing.Size(146, 20);
            this.pktTextBox.TabIndex = 10;
            // 
            // savePktButton
            // 
            this.savePktButton.Location = new System.Drawing.Point(534, 172);
            this.savePktButton.Name = "savePktButton";
            this.savePktButton.Size = new System.Drawing.Size(258, 23);
            this.savePktButton.TabIndex = 11;
            this.savePktButton.Text = "Punktestand speichern";
            this.savePktButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 328);
            this.Controls.Add(this.savePktButton);
            this.Controls.Add(this.pktTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.q4RadioButton);
            this.Controls.Add(this.q3RadioButton);
            this.Controls.Add(this.q2RadioButton);
            this.Controls.Add(this.q1RadioButton);
            this.Controls.Add(this.questionTextField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextQuestion);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button nextQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox questionTextField;
        private System.Windows.Forms.RadioButton q1RadioButton;
        private System.Windows.Forms.RadioButton q2RadioButton;
        private System.Windows.Forms.RadioButton q3RadioButton;
        private System.Windows.Forms.RadioButton q4RadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pktTextBox;
        private System.Windows.Forms.Button savePktButton;
    }
}

