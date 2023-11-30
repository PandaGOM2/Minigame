using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 팀프로젝트숫자야구
{
    public partial class Baseball : Form
    {
        int[] Array;
        int count;
    
        public Baseball()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameStart();
        }

        private void GameStart()
        {
            Random r = new Random();
            Array = new int[3] { 100, 100, 100 };

            for (int i = 0; i < Array.Length; ++i)
            {
                int rNum = r.Next(0, 10);
                int j;
                for (j = 0; j < Array.Length; ++j)
                {
                    if (rNum == Array[j])
                        break;
                }
                if (j < Array.Length)
                {
                    --j;
                    continue;
                }
                Array[i] = rNum;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] arr = new int[Array.Length];
            int strike = 0;
            int ball = 0;

            arr[0] = Convert.ToInt32(textBox1.Text);
            arr[1] = int.Parse(textBox2.Text);
            arr[2] = int.Parse(textBox3.Text);

            if (InputVadlation(arr) == false)
                return;

            for (int i= 0; i<Array.Length; ++i)
            { 
                for(int j= 0; j<Array.Length; ++j)
                {
                    if (arr[i] == Array[j])
                    {
                        if (i == j)
                            ++strike;

                        else
                            ++ball;

                        break;
                    }
                }
            }

            ++count;
            label5.Text = count.ToString();

            if (strike == 0 && ball == 0)

                listBox1.Items.Add(arr[0] + "" + arr[1] + "" + arr[2] + "            " + "OUT입니다.");

            else if (strike == 3)
            {
                listBox1.Items.Add("정답을 맞추셨습니다!");
                listBox1.Items.Add("카운트 : " + count);
            }

            else
                listBox1.Items.Add(arr[0] + "" + arr[1] + "" + arr[2] + "            " + strike + "           " + ball);
                     
        }

        private bool InputVadlation(int[] arr)
        {
            
            for(int i = 0; i< 3; i++)
            {
                if (arr[i] <0 || arr[i] > 9)
                {
                    MessageBox.Show("0~9 숫자만 입력해주세요.");
                    return false;
                }

                for (int j= 0; j < i; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        MessageBox.Show("중복된 숫자는 사용할 수 없습니다.");
                        return false;
                    }
                }
            }

            return true;
                
        }

        private void Form1Clear()
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            count = 0;
            label5.Text = count.ToString();
            GameStart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
