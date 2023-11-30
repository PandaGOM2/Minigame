namespace WINDOWPROJECT
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RockPaperScissor = new System.Windows.Forms.PictureBox();
            this.ODD_OR_EVEN = new System.Windows.Forms.PictureBox();
            this.GUGUDAN = new System.Windows.Forms.PictureBox();
            this.KIA_Tigers = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RockPaperScissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODD_OR_EVEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GUGUDAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KIA_Tigers)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 372);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "종료";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "게임";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼모음T", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(93, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "야구게임";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼모음T", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(280, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "구구단게임";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼모음T", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(280, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "가위바위보";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("휴먼모음T", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(93, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "홀짝게임";
            // 
            // RockPaperScissor
            // 
            this.RockPaperScissor.Image = global::WINDOWPROJECT.Properties.Resources.Rock_Paper_Scissors;
            this.RockPaperScissor.Location = new System.Drawing.Point(247, 204);
            this.RockPaperScissor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RockPaperScissor.Name = "RockPaperScissor";
            this.RockPaperScissor.Size = new System.Drawing.Size(170, 102);
            this.RockPaperScissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RockPaperScissor.TabIndex = 5;
            this.RockPaperScissor.TabStop = false;
            this.RockPaperScissor.Click += new System.EventHandler(this.RockPaperScissor_Click);
            // 
            // ODD_OR_EVEN
            // 
            this.ODD_OR_EVEN.Image = global::WINDOWPROJECT.Properties.Resources.odd_or_even_game;
            this.ODD_OR_EVEN.Location = new System.Drawing.Point(43, 204);
            this.ODD_OR_EVEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ODD_OR_EVEN.Name = "ODD_OR_EVEN";
            this.ODD_OR_EVEN.Size = new System.Drawing.Size(170, 102);
            this.ODD_OR_EVEN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ODD_OR_EVEN.TabIndex = 4;
            this.ODD_OR_EVEN.TabStop = false;
            this.ODD_OR_EVEN.Click += new System.EventHandler(this.ODD_OR_EVEN_Click);
            // 
            // GUGUDAN
            // 
            this.GUGUDAN.ErrorImage = global::WINDOWPROJECT.Properties.Resources._99;
            this.GUGUDAN.Image = global::WINDOWPROJECT.Properties.Resources._99;
            this.GUGUDAN.Location = new System.Drawing.Point(247, 71);
            this.GUGUDAN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GUGUDAN.Name = "GUGUDAN";
            this.GUGUDAN.Size = new System.Drawing.Size(170, 102);
            this.GUGUDAN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GUGUDAN.TabIndex = 3;
            this.GUGUDAN.TabStop = false;
            this.GUGUDAN.Click += new System.EventHandler(this.GUGUDAN_Click);
            // 
            // KIA_Tigers
            // 
            this.KIA_Tigers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.KIA_Tigers.Image = global::WINDOWPROJECT.Properties.Resources.kiatigers;
            this.KIA_Tigers.Location = new System.Drawing.Point(43, 71);
            this.KIA_Tigers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KIA_Tigers.Name = "KIA_Tigers";
            this.KIA_Tigers.Size = new System.Drawing.Size(170, 102);
            this.KIA_Tigers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KIA_Tigers.TabIndex = 2;
            this.KIA_Tigers.TabStop = false;
            this.KIA_Tigers.Click += new System.EventHandler(this.KIA_Tigers_Click);
            // 
            // Form1
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "메인메뉴";
            ((System.ComponentModel.ISupportInitialize)(this.RockPaperScissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODD_OR_EVEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GUGUDAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KIA_Tigers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox GUGUDAN;
        private System.Windows.Forms.PictureBox ODD_OR_EVEN;
        private System.Windows.Forms.PictureBox KIA_Tigers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.PictureBox RockPaperScissor;
    }
}

