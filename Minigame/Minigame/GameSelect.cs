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
    public partial class GameSelect : Form
    {
        
        public GameSelect()
        {
            InitializeComponent();
        }

        private void KIA_Tigers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Numberbaseball baseball = new Numberbaseball();
            baseball.Show();
        }

        private void GUGUDAN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gugudan gugu = new Gugudan();
            gugu.Show();
        }

        private void ODD_OR_EVEN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Odd_even_game odd_Game = new Odd_even_game();
            odd_Game.Show();
        }

        private void RockPaperScissor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rockpeperscissor rock = new Rockpeperscissor();
            rock.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
           
            
        }
    }
}
