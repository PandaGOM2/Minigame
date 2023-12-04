namespace Minigame
{
    partial class GameSelect
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RockPaperScissor = new System.Windows.Forms.PictureBox();
            this.ODD_OR_EVEN = new System.Windows.Forms.PictureBox();
            this.GUGUDAN = new System.Windows.Forms.PictureBox();
            this.KIA_Tigers = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RockPaperScissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODD_OR_EVEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GUGUDAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KIA_Tigers)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼모음T", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(300, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "가위바위보";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("휴먼모음T", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(113, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "홀짝게임";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼모음T", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(300, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "구구단게임";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼모음T", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(113, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "야구게임";
            // 
            // RockPaperScissor
            // 
            this.RockPaperScissor.Image = global::Minigame.Properties.Resources.Rock_Paper_Scissors;
            this.RockPaperScissor.Location = new System.Drawing.Point(267, 189);
            this.RockPaperScissor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RockPaperScissor.Name = "RockPaperScissor";
            this.RockPaperScissor.Size = new System.Drawing.Size(170, 102);
            this.RockPaperScissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RockPaperScissor.TabIndex = 15;
            this.RockPaperScissor.TabStop = false;
            this.RockPaperScissor.Click += new System.EventHandler(this.RockPaperScissor_Click);
            // 
            // ODD_OR_EVEN
            // 
            this.ODD_OR_EVEN.Image = global::Minigame.Properties.Resources.odd_or_even_game;
            this.ODD_OR_EVEN.Location = new System.Drawing.Point(63, 189);
            this.ODD_OR_EVEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ODD_OR_EVEN.Name = "ODD_OR_EVEN";
            this.ODD_OR_EVEN.Size = new System.Drawing.Size(170, 102);
            this.ODD_OR_EVEN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ODD_OR_EVEN.TabIndex = 14;
            this.ODD_OR_EVEN.TabStop = false;
            this.ODD_OR_EVEN.Click += new System.EventHandler(this.ODD_OR_EVEN_Click);
            // 
            // GUGUDAN
            // 
            this.GUGUDAN.Image = global::Minigame.Properties.Resources._99;
            this.GUGUDAN.Location = new System.Drawing.Point(267, 56);
            this.GUGUDAN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GUGUDAN.Name = "GUGUDAN";
            this.GUGUDAN.Size = new System.Drawing.Size(170, 102);
            this.GUGUDAN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GUGUDAN.TabIndex = 13;
            this.GUGUDAN.TabStop = false;
            this.GUGUDAN.Click += new System.EventHandler(this.GUGUDAN_Click);
            // 
            // KIA_Tigers
            // 
            this.KIA_Tigers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.KIA_Tigers.ErrorImage = global::Minigame.Properties.Resources.kiatigers;
            this.KIA_Tigers.Image = global::Minigame.Properties.Resources.kiatigers;
            this.KIA_Tigers.InitialImage = global::Minigame.Properties.Resources.kiatigers;
            this.KIA_Tigers.Location = new System.Drawing.Point(63, 56);
            this.KIA_Tigers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KIA_Tigers.Name = "KIA_Tigers";
            this.KIA_Tigers.Size = new System.Drawing.Size(170, 102);
            this.KIA_Tigers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KIA_Tigers.TabIndex = 12;
            this.KIA_Tigers.TabStop = false;
            this.KIA_Tigers.Click += new System.EventHandler(this.KIA_Tigers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "게임";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 357);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "종료";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 415);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RockPaperScissor);
            this.Controls.Add(this.ODD_OR_EVEN);
            this.Controls.Add(this.GUGUDAN);
            this.Controls.Add(this.KIA_Tigers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "GameSelect";
            this.Text = "GameSelect";
            ((System.ComponentModel.ISupportInitialize)(this.RockPaperScissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODD_OR_EVEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GUGUDAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KIA_Tigers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox RockPaperScissor;
        private System.Windows.Forms.PictureBox ODD_OR_EVEN;
        private System.Windows.Forms.PictureBox GUGUDAN;
        private System.Windows.Forms.PictureBox KIA_Tigers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}