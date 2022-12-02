using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace BouncyBallGame
{
    public partial class MainMenu : Form
    {
        public MainMenu(string message = null)
        {
            InitializeComponent();
            txt_help.Hide();
            
            if (message != null)
            {
                txt_results.Text = message;
            } else
            {
                txt_results.Hide();
            }
          
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            BouncyBallGame game = new BouncyBallGame();
            this.Hide();
            game.Show();

        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            if (txt_help.Visible)
            {
                txt_help.Hide();
            } else
            {
                txt_help.Show();
            }
        }
    }
}
