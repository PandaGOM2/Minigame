using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using An_Odd_Game;
using 팀프로젝트_구구단;
using 팀프로젝트숫자야구;
using System.Diagnostics;
using 가바보;


namespace WINDOWPROJECT
{
    public partial class Form1 : Form
    {
        Boolean open = false;
        public Form1()
        {
            InitializeComponent();
           
        }


        private void KIA_Tigers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Baseball baseball = new Baseball();
            baseball.Show();
        }

        private void GUGUDAN_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuGuDan gugu = new GuGuDan();
            gugu.Show();
            
        }

        private void ODD_OR_EVEN_Click(object sender, EventArgs e)
        {
            this.Hide();
           Odd_Game odd_Game = new Odd_Game();
            odd_Game.Show();
        }

        private void RockPaperScissor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rockpapersecssior rock = new Rockpapersecssior();
            rock.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (open)
            {
                this.Close();
            }
        }

    }
}
