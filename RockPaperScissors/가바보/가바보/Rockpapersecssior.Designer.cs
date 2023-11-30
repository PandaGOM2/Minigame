namespace 가바보
{
    partial class Rockpapersecssior
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.radioButtonScissors = new System.Windows.Forms.RadioButton();
            this.radioButtonRock = new System.Windows.Forms.RadioButton();
            this.radioButtonPaper = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(91, 118);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "선택";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // radioButtonScissors
            // 
            this.radioButtonScissors.AutoSize = true;
            this.radioButtonScissors.Location = new System.Drawing.Point(12, 27);
            this.radioButtonScissors.Name = "radioButtonScissors";
            this.radioButtonScissors.Size = new System.Drawing.Size(58, 19);
            this.radioButtonScissors.TabIndex = 4;
            this.radioButtonScissors.TabStop = true;
            this.radioButtonScissors.Text = "가위";
            this.radioButtonScissors.UseVisualStyleBackColor = true;
            // 
            // radioButtonRock
            // 
            this.radioButtonRock.AutoSize = true;
            this.radioButtonRock.Location = new System.Drawing.Point(108, 27);
            this.radioButtonRock.Name = "radioButtonRock";
            this.radioButtonRock.Size = new System.Drawing.Size(58, 19);
            this.radioButtonRock.TabIndex = 5;
            this.radioButtonRock.TabStop = true;
            this.radioButtonRock.Text = "바위";
            this.radioButtonRock.UseVisualStyleBackColor = true;
            // 
            // radioButtonPaper
            // 
            this.radioButtonPaper.AutoSize = true;
            this.radioButtonPaper.Location = new System.Drawing.Point(201, 27);
            this.radioButtonPaper.Name = "radioButtonPaper";
            this.radioButtonPaper.Size = new System.Drawing.Size(43, 19);
            this.radioButtonPaper.TabIndex = 6;
            this.radioButtonPaper.TabStop = true;
            this.radioButtonPaper.Text = "보";
            this.radioButtonPaper.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 153);
            this.Controls.Add(this.radioButtonPaper);
            this.Controls.Add(this.radioButtonRock);
            this.Controls.Add(this.radioButtonScissors);
            this.Controls.Add(this.btnPlay);
            this.Name = "Form1";
            this.Text = "가위바위보";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RadioButton radioButtonScissors;
        private System.Windows.Forms.RadioButton radioButtonRock;
        private System.Windows.Forms.RadioButton radioButtonPaper;
    }
}

