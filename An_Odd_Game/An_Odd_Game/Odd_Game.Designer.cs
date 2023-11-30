namespace An_Odd_Game
{
    partial class Odd_Game
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Exit_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Odd_number = new System.Windows.Forms.Button();
            this.Even_number = new System.Windows.Forms.Button();
            this.Game_Start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exit_Button.Font = new System.Drawing.Font("한컴 고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Exit_Button.Location = new System.Drawing.Point(696, 517);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(92, 37);
            this.Exit_Button.TabIndex = 0;
            this.Exit_Button.Text = "나가기";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(614, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(25, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "홀짝게임";
            // 
            // Odd_number
            // 
            this.Odd_number.Font = new System.Drawing.Font("한컴 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Odd_number.Location = new System.Drawing.Point(121, 342);
            this.Odd_number.Name = "Odd_number";
            this.Odd_number.Size = new System.Drawing.Size(123, 81);
            this.Odd_number.TabIndex = 3;
            this.Odd_number.Text = "홀";
            this.Odd_number.UseVisualStyleBackColor = true;
            this.Odd_number.Click += new System.EventHandler(this.Odd_number_Click);
            // 
            // Even_number
            // 
            this.Even_number.Font = new System.Drawing.Font("한컴 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Even_number.Location = new System.Drawing.Point(559, 342);
            this.Even_number.Name = "Even_number";
            this.Even_number.Size = new System.Drawing.Size(123, 81);
            this.Even_number.TabIndex = 4;
            this.Even_number.Text = "짝";
            this.Even_number.UseVisualStyleBackColor = true;
            this.Even_number.Click += new System.EventHandler(this.Even_number_Click);
            // 
            // Game_Start
            // 
            this.Game_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Game_Start.Font = new System.Drawing.Font("한컴 고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Game_Start.Location = new System.Drawing.Point(12, 517);
            this.Game_Start.Name = "Game_Start";
            this.Game_Start.Size = new System.Drawing.Size(92, 37);
            this.Game_Start.TabIndex = 7;
            this.Game_Start.Text = "게임 시작";
            this.Game_Start.UseVisualStyleBackColor = true;
            this.Game_Start.Click += new System.EventHandler(this.Game_Start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(691, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::An_Odd_Game.Properties.Resources.Trump2;
            this.pictureBox2.Location = new System.Drawing.Point(450, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::An_Odd_Game.Properties.Resources.Trump1;
            this.pictureBox1.Location = new System.Drawing.Point(235, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Odd_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Game_Start);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Even_number);
            this.Controls.Add(this.Odd_number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit_Button);
            this.Name = "Odd_Game";
            this.Text = "An_Odd_Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Odd_number;
        private System.Windows.Forms.Button Even_number;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Game_Start;
        private System.Windows.Forms.Label label3;
    }
}

