using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 팀프로젝트_구구단
{
    public partial class GuGuDan : Form
    {
        private int num_X;
        private int num_Y;
        private int ans_Z;
        private int remaintime = 3;
        public int score = 0;

        Random r = new Random();

        public GuGuDan()
        {
            InitializeComponent();
        }

        // 즐겁다
        private void HappyPicture() 
        {
            Bitmap image1 = Properties.Resources.happy;
            pictureBox1.Image = image1;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // 안즐겁다
        private void UnhappyPicture()
        {
            Bitmap image2 = Properties.Resources.unhappy;
            pictureBox1.Image = image2;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Multiplication()
        {
            r.Next();
            num_X = r.Next(2, 9);
            r.Next();
            num_Y = r.Next(1, 9);
            ans_Z = num_X * num_Y;

            question_label.Text = " " + num_X + " X " + num_Y + " = ?";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Multiplication();
            textBox1.Focus();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(count_down);
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void count_down(object sender, EventArgs e)
        {
            if (remaintime == 0)
            {
                timer1.Stop();
                UnhappyPicture();
                remaintime = 3;

                if (MessageBox.Show("시간 초과! 다시 시도할까요? (예: 다시시도, 아니오: 메인으로) \r\r점수: " + score,"시간초과",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    question_label.Text = "□ X □ = ?";
                    HappyPicture();
                    remaintime = 3;
                }
                else // 메인 폼으로 이동
                {
                    question_label.Text = "□ X □ = ?";
                    HappyPicture();
                    remaintime = 3;
                }
                score = 0;
                score_label.Text = score.ToString();
                textBox1.Text = "";

            }
            else if (remaintime > 0)
            {
                remaintime--;
                remain_time.Text = remaintime.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) == ans_Z)
            {
                timer1.Stop();
                MessageBox.Show("정답입니다!","정답");
                score += 100;
                score_label.Text = score.ToString();
                Multiplication();
                textBox1.Text = "";
                remaintime = 3;
                timer1 = new System.Windows.Forms.Timer();
                timer1.Tick += new EventHandler(count_down);
                timer1.Interval = 1000;
                timer1.Start();
            }
            else
            {
                UnhappyPicture();
                timer1.Stop();
                if (MessageBox.Show("오답입니다! 다시 시도할까요? (예: 다시시도, 아니오: 메인으로) \r\r점수: " + score, "오답", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    question_label.Text = "□ X □ = ?";
                    HappyPicture();
                    remaintime = 3;
                }
                else // 메인 폼으로 이동
                {
                    question_label.Text = "□ X □ = ?";
                    HappyPicture();
                    remaintime = 3;
                }
                score = 0;
                score_label.Text = score.ToString();
                textBox1.Text = "";
            }
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(textBox1.Text) == ans_Z)
                {
                    timer1.Stop();
                    MessageBox.Show("정답입니다!","정답");
                    score += 100;
                    score_label.Text = score.ToString();
                    Multiplication();
                    textBox1.Text = "";
                    remaintime = 3;
                    timer1 = new System.Windows.Forms.Timer();
                    timer1.Tick += new EventHandler(count_down);
                    timer1.Interval = 1000;
                    timer1.Start();
                }
                else
                {
                    UnhappyPicture();
                    timer1.Stop();
                    if (MessageBox.Show("오답입니다! 다시 시도할까요? (예: 다시시도, 아니오: 메인으로) \r\r점수: " + score, "오답", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        question_label.Text = "□ X □ = ?";
                        HappyPicture();
                        remaintime = 3;
                    }
                    else // 메인 폼으로 이동
                    {
                        question_label.Text = "□ X □ = ?";
                        HappyPicture();
                        remaintime = 3;
                    }
                    score = 0;
                    score_label.Text = score.ToString();
                    textBox1.Text = "";
                }
            }
        }

        // 메인 폼으로 가는 이벤트
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
