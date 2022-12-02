using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncyBallGame
{
    public partial class BouncyBallGame : Form
    {
        // Properties
        int initBrickX = 200, initBrickY = 100;
        Paddle paddle;

        List<Brick> bricks = new List<Brick>();
        // Declare the ball object. 
        HashSet<Ball> balls = new HashSet<Ball>();
        //Ball ball;
        private MciPlayer pop = new MciPlayer("sounds/pop.mp3", "1");
        public BouncyBallGame()
        {
            InitializeComponent();
        }

        private void BouncyBallGame_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Width = 1200;
            this.Height = 800;
            
            //Creating the paddle here
            paddle = new Paddle(this.DisplayRectangle);
            //ball = new Ball(this.DisplayRectangle);
            balls.Add(new Ball(this.DisplayRectangle));

            //Create brick
            for (int i = 0; i < 30; i++)
            {
                if (i % 10 == 0)
                {
                    initBrickY += 35;
                    initBrickX = 200;
                }
                bricks.Add(new Brick(initBrickX, initBrickY));
                initBrickX += 85;
                
            }


        }

        private void BouncyBallGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            //Paddle paddle = new Paddle(this.DisplayRectangle);
            paddle.Draw(graphics);
            foreach (var brick in bricks)
            {
                brick.Draw(graphics);
            }
            
            //ball.Draw(graphics);
            foreach (var ball in balls)
            {
                ball.Draw(graphics);
            }
            // Display number of balls created
            DisplayNumberOfBalls(graphics);
        }

        private void DisplayNumberOfBalls(Graphics graphics)
        {
            string message = $"Bricks Remaining: {bricks.Count}";
            Font font = new Font(FontFamily.GenericSansSerif, 25);
            graphics.DrawString(message, font,Brushes.Blue, 20, 20);

        }

        private void BouncyBallGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    paddle.Move(Paddle.Direction.Left);
                   
                    break;
                case Keys.Right:
                    paddle.Move(Paddle.Direction.Right);
                    
                    break;
                case Keys.Space:
                    this.animationTimer.Start(); // to start the timer and perform the ball move
                    
                    break;
                case Keys.Escape:
                    this.Hide();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                    break;

            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            //Removing any balls that have slipped off the main form
            balls.RemoveWhere(BallMissesPaddle);
            foreach (var ball in balls)
            {
                ball.Move();
            }
            if (balls.RemoveWhere(BallMissesPaddle) > 0)
            {
                pop.PlayFromStart();
            }


            //ball.Move();
            //Check for any collison using this mwthod
            foreach (var ball in balls)
            {
                CheckForCollision(ball);

            }

            if (balls.Count == 0)
            {
                MainMenu mainMenu = new MainMenu("Game Over. You Lost!");
                mainMenu.Show();
                this.Close();
            }

            if (bricks.Count == 0)
            {
                MainMenu mainMenu = new MainMenu("You won!");
                mainMenu.Show();
                this.Close();
            }

            Invalidate(); // Refresh the form

        }
        /// <summary>
        /// The delgate which decide if any ball is to be removed
        /// </summary>
        /// <param name="ball"></param>
        /// <returns></returns>
        private bool BallMissesPaddle(Ball ball)
        {
            return (ball.currentY >= DisplayRectangle.Bottom);
        }

        /// <summary>
        /// The Collision Detection Method
        /// </summary>

        private void CheckForCollision(Ball ball)
        {
            // Check the Top side collision Detection 
            if (ball.currentY <= this.DisplayRectangle.Top)
            {
                ball.FlipY();
            }
            // Check the paddle collision Detection 
            else if (paddle.DisplayRect.IntersectsWith(ball.DisplayArea))
            {
                ball.FlipY();
            }
            //To decrease the value of number of balls on the top of the main form of our game
            //else if (ball.currentY >= DisplayRectangle.Bottom)
            //{
            //    balls.Remove(ball);
            //}

            // Check the Left side collision Detection
            if (ball.currentX <= this.DisplayRectangle.Left)
            {
                ball.FlipX();
            }
            // Check the right collision Detection
            else if (ball.currentX >= (this.DisplayRectangle.Right-ball.Size))
            {
                ball.FlipX();
            }

            foreach (var brick in bricks.ToList())
            {
                if (brick.DisplayRect.IntersectsWith(ball.DisplayArea))
                {
                    ball.FlipY();
                    bricks.Remove(brick);
                }
            }
            
        }
    }
}
