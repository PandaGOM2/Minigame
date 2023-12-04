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
    public partial class Rockpeperscissor : Form
    {
        private int countdown = 3; // Countdown timer value
        private Timer timer = new Timer();

        public Rockpeperscissor()
        {
            InitializeComponent();
        }
        private void InitializeTimer()
        {
            timer.Interval = 1000; // 1 second

        }

        private void Rockpeperscissor_Load(object sender, EventArgs e)
        {
            MessageBox.Show("가위바위보 게임을 시작합니다. (가위, 바위, 보 중 선택)");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string userChoice = GetUserChoice();

            if (userChoice != null)
            {
                string computerChoice = GetComputerChoice();

                DisplayChoices(userChoice, computerChoice);

                string result = DetermineWinner(userChoice, computerChoice);
                MessageBox.Show(result);

                DialogResult playAgain = MessageBox.Show("게임을 다시 하시겠습니까?", "재시작", MessageBoxButtons.YesNo);
                if (playAgain == DialogResult.No)
                {
                    Close(); // Close the form if the user chooses not to play again
                    GameSelect game = new GameSelect();
                    game.Show();
                }
            }
        }


        private string GetUserChoice()
        {
            string userChoice = null;

            if (radioButtonScissors.Checked)
            {
                userChoice = "가위";
            }
            else if (radioButtonRock.Checked)
            {
                userChoice = "바위";
            }
            else if (radioButtonPaper.Checked)
            {
                userChoice = "보";
            }
            else
            {
                MessageBox.Show("가위, 바위, 보 중에서 선택하세요.");
            }

            return userChoice;
        }



        private string GetComputerChoice()
        {
            Random random = new Random();
            int computerChoice = random.Next(1, 4);
            switch (computerChoice)
            {
                case 1:
                    return "가위";
                case 2:
                    return "바위";
                case 3:
                    return "보";
                default:
                    throw new ArgumentOutOfRangeException(nameof(computerChoice), "잘못된 선택입니다.");
            }
        }

        private void DisplayChoices(string userChoice, string computerChoice)
        {
            MessageBox.Show($"당신의 선택: {userChoice}\n컴퓨터의 선택: {computerChoice}");
        }

        private string DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
            {
                return "비겼습니다!";
            }
            else if ((userChoice == "가위" && computerChoice == "보") ||
                     (userChoice == "바위" && computerChoice == "가위") ||
                     (userChoice == "보" && computerChoice == "바위"))
            {
                return "이겼습니다!";
            }
            else
            {
                return "졌습니다!";
            }
        }
    }
}
