namespace Minigame
{
    partial class Rockpeperscissor
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
            this.radioButtonPaper = new System.Windows.Forms.RadioButton();
            this.radioButtonRock = new System.Windows.Forms.RadioButton();
            this.radioButtonScissors = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonPaper
            // 
            this.radioButtonPaper.AutoSize = true;
            this.radioButtonPaper.Location = new System.Drawing.Point(189, 16);
            this.radioButtonPaper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPaper.Name = "radioButtonPaper";
            this.radioButtonPaper.Size = new System.Drawing.Size(35, 16);
            this.radioButtonPaper.TabIndex = 10;
            this.radioButtonPaper.TabStop = true;
            this.radioButtonPaper.Text = "보";
            this.radioButtonPaper.UseVisualStyleBackColor = true;
            // 
            // radioButtonRock
            // 
            this.radioButtonRock.AutoSize = true;
            this.radioButtonRock.Location = new System.Drawing.Point(107, 16);
            this.radioButtonRock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonRock.Name = "radioButtonRock";
            this.radioButtonRock.Size = new System.Drawing.Size(47, 16);
            this.radioButtonRock.TabIndex = 9;
            this.radioButtonRock.TabStop = true;
            this.radioButtonRock.Text = "바위";
            this.radioButtonRock.UseVisualStyleBackColor = true;
            // 
            // radioButtonScissors
            // 
            this.radioButtonScissors.AutoSize = true;
            this.radioButtonScissors.Location = new System.Drawing.Point(23, 16);
            this.radioButtonScissors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonScissors.Name = "radioButtonScissors";
            this.radioButtonScissors.Size = new System.Drawing.Size(47, 16);
            this.radioButtonScissors.TabIndex = 8;
            this.radioButtonScissors.TabStop = true;
            this.radioButtonScissors.Text = "가위";
            this.radioButtonScissors.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(93, 88);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(66, 18);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "선택";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Rockpeperscissor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 122);
            this.Controls.Add(this.radioButtonPaper);
            this.Controls.Add(this.radioButtonRock);
            this.Controls.Add(this.radioButtonScissors);
            this.Controls.Add(this.btnPlay);
            this.Name = "Rockpeperscissor";
            this.Text = "Rockpeperscissor";
            this.Load += new System.EventHandler(this.Rockpeperscissor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonPaper;
        private System.Windows.Forms.RadioButton radioButtonRock;
        private System.Windows.Forms.RadioButton radioButtonScissors;
        private System.Windows.Forms.Button btnPlay;
    }
}