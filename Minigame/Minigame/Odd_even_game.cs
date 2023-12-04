using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minigame
{
    public partial class Odd_even_game : Form
    {
        private Random random = new Random();
        bool continueGame;
        int score;

        public Odd_even_game()
        {
            InitializeComponent();
        }

        private void Game_Start_Click(object sender, EventArgs e)
        {
            MessageBox.Show("홀,짝중에 선택을 먼저 해주세요");
            continueGame = true;
        }

        private Image GetCardImage(int cardNumber)
        {
            // 리소스 파일에서 이미지 가져오기
            string resourceName = $"Trump{cardNumber}";
            Image image = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);

            if (image != null)
            {
                return image; // 이미지가 존재하면 반환
            }
            else
            {
                MessageBox.Show($"이미지를 찾을 수 없습니다: {resourceName}");
                return null; // 이미지가 없을 경우 null 반환 혹은 기본 이미지 등으로 대체할 수 있음
            }
        }

        private void Even_number_Click(object sender, EventArgs e)
        {
            continueGame = true;
            while (continueGame)
            {
                // 각 PictureBox에 무작위로 카드 이미지 할당 (1에서 4까지)
                int card1 = random.Next(1, 5);
                int card2 = random.Next(1, 5);

                pictureBox1.Image = GetCardImage(card1);
                pictureBox2.Image = GetCardImage(card2);

                // 두 카드의 합 계산
                int total = card1 + card2;

                // 홀짝 여부 판단
                string result;
                switch (total % 2)
                {
                    case 0: // 짝수
                        result = "짝수";
                        break;
                    case 1: // 홀수
                        result = "홀수";
                        break;
                    default: // 기타 경우
                        result = "오류";
                        break;
                }

                // 결과 표시
                MessageBox.Show($"카드 합계: {total}\n결과: {result}");
                //게임 종료
                continueGame = false;
                //점수의 값을 지정
                if (result == "짝수")
                {
                    score += 100;
                }
                else
                    score -= 100;
                //점수 상승 or 감점
                label3.Text = $"{score}";
            }
        }

        private void Odd_number_Click(object sender, EventArgs e)
        {
            continueGame = true;
            while (continueGame)
            {
                // 각 PictureBox에 무작위로 카드 이미지 할당 (1에서 4까지)
                int card1 = random.Next(1, 5);
                int card2 = random.Next(1, 5);

                pictureBox1.Image = GetCardImage(card1);
                pictureBox2.Image = GetCardImage(card2);

                // 두 카드의 합 계산
                int total = card1 + card2;

                // 홀짝 여부 판단
                string result;
                switch (total % 2)
                {
                    case 0: // 짝수
                        result = "짝수";
                        break;
                    case 1: // 홀수
                        result = "홀수";
                        break;
                    default: // 기타 경우
                        result = "오류";
                        break;
                }

                // 결과 표시
                MessageBox.Show($"카드 합계: {total}\n결과: {result}");
                //게임 종료
                continueGame = false;
                //점수의 값을 지정
                if (result == "홀수")
                {
                    score += 100;
                }
                else
                    score -= 100;
                //점수 상승 or 감점
                label3.Text = $"{score}";
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GameSelect gameSelect = new GameSelect();
            gameSelect.Show();
        }
    }
}
