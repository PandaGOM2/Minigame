namespace Minigame
{
    partial class Odd_even_game
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
            this.label3 = new System.Windows.Forms.Label();
            this.Game_Start = new System.Windows.Forms.Button();
            this.Even_number = new System.Windows.Forms.Button();
            this.Odd_number = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(696, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = " ";
            // 
            // Game_Start
            // 
            this.Game_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Game_Start.Font = new System.Drawing.Font("한컴 고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Game_Start.Location = new System.Drawing.Point(17, 474);
            this.Game_Start.Name = "Game_Start";
            this.Game_Start.Size = new System.Drawing.Size(92, 37);
            this.Game_Start.TabIndex = 16;
            this.Game_Start.Text = "게임 시작";
            this.Game_Start.UseVisualStyleBackColor = true;
            this.Game_Start.Click += new System.EventHandler(this.Game_Start_Click);
            // 
            // Even_number
            // 
            this.Even_number.Font = new System.Drawing.Font("한컴 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Even_number.Location = new System.Drawing.Point(564, 299);
            this.Even_number.Name = "Even_number";
            this.Even_number.Size = new System.Drawing.Size(123, 81);
            this.Even_number.TabIndex = 13;
            this.Even_number.Text = "짝";
            this.Even_number.UseVisualStyleBackColor = true;
            this.Even_number.Click += new System.EventHandler(this.Even_number_Click);
            // 
            // Odd_number
            // 
            this.Odd_number.Font = new System.Drawing.Font("한컴 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Odd_number.Location = new System.Drawing.Point(126, 299);
            this.Odd_number.Name = "Odd_number";
            this.Odd_number.Size = new System.Drawing.Size(123, 81);
            this.Odd_number.TabIndex = 12;
            this.Odd_number.Text = "홀";
            this.Odd_number.UseVisualStyleBackColor = true;
            this.Odd_number.Click += new System.EventHandler(this.Odd_number_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(30, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "홀짝게임";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(619, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Score :";
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exit_Button.Font = new System.Drawing.Font("한컴 고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Exit_Button.Location = new System.Drawing.Point(701, 474);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(92, 37);
            this.Exit_Button.TabIndex = 9;
            this.Exit_Button.Text = "나가기";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Minigame.Properties.Resources.Trump1;
            this.pictureBox1.Location = new System.Drawing.Point(203, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Minigame.Properties.Resources.Trump2;
            this.pictureBox2.Location = new System.Drawing.Point(478, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 179);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // Odd_even_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(803, 519);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Game_Start);
            this.Controls.Add(this.Even_number);
            this.Controls.Add(this.Odd_number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit_Button);
            this.Name = "Odd_even_game";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Game_Start;
        private System.Windows.Forms.Button Even_number;
        private System.Windows.Forms.Button Odd_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}