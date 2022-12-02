using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncyBallGame
{
    public class Brick
    {
        //Properties
        private readonly int width = 80;
        private readonly int height = 30;
        public Rectangle DisplayRect;

        public Brick(int x, int y)
        {
            int paddleX = x;
            int paddleY = y;
            DisplayRect = new Rectangle(paddleX, paddleY, width, height); 
        }
        internal void Draw(Graphics graphics)
        {
            //Rectangle rec = new Rectangle(50, 200, width, height);
            //graphics.DrawRectangle(new Pen(Brushes.White), rec);
            graphics.FillRectangle(Brushes.Green, DisplayRect);


        }
        
    }
}
