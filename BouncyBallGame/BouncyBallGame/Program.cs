using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncyBallGame
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Comments for requirement 6.
            //Left and right arrow move the paddle, space bar to start the ball moving.
            //Game ends when all bricks are broken or the bal leaves the screen.
            //Esc will end the game.
            //GDI+ is an API that allows applications to dispaly graphics on a display. The application in this case doesnt need direct access to the hardware, instead GDI+ does it for us.
            //Double buffering smoothes out movements and animations by showing us one from and then having the next frame prepared in a buffer to be delivered immediately after.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
