using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmGame
{
    public class Sheep : Animal
    {
        private static Random rand = new Random();
        public const int buySheep = 200;
        public const int sellSheep = 175;
        private int woolCounter;
        private bool isWool;
        public Sheep() : base()
        {
            isWool = false;
            woolCounter = 0;
            type = 1;
        }
        public Sheep(int _id) : base()
        {
            id = _id;
            isWool = false;
            woolCounter = 0;
            type = 1;
        }
        public override void gainSpeed() { speed = 3; }
        public void updateWool(bool val) { isWool = val; }
        public override bool doesWool() { return isWool; }
        public override void updateLocation(bool changeDirection)
        {
            if (changeDirection)
                createDirection();
            if (coordinates.X + direction.X <= 130 || coordinates.X + direction.X >= 760 ||
                coordinates.Y + direction.Y <= 0 || coordinates.Y + direction.Y >= 480)
            {
                if (coordinates.X + direction.X <= 130 && coordinates.X + direction.X > 0 &&
                    coordinates.Y + direction.Y > 30 && coordinates.Y + direction.Y < 450)
                {
                    coordinates += direction;
                    return;
                }
                direction = -direction;
            }
            coordinates += direction;
        }
        public override bool isInside(int X, int Y)
        {
            return Math.Abs(X - coordinates.X) <= 64 && Math.Abs(Y - coordinates.Y) <= 64;
        }
        public override void createDirection()
        {
            direction.X = rand.Next(0, 200) - 100;
            direction.Y = rand.Next(0, 200) - 100;
            direction.Normalize();
            direction *= speed;
        }
        public override void updateStats()
        {
            if (hunger - 3 <= 0 || health - 1 <= 0)
                isAlive = false;
            else
            {
                woolCounter++;
                hunger -= 3;
                health -= 1;
                if (woolCounter == 30)
                {
                    updateWool(true);
                    woolCounter = 0;
                }
            }
        }
        public override void displayAnimal(PictureBox p)
        {
            p.BackColor = System.Drawing.Color.Transparent;
            p.Cursor = System.Windows.Forms.Cursors.Hand;
            p.Image = global::FarmGame.Properties.Resources.sheep;
            p.InitialImage = global::FarmGame.Properties.Resources.sheep;
            p.Location = new System.Drawing.Point((int)getX(), (int)getY());
            p.Size = new System.Drawing.Size(65, 65);
            p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            p.TabIndex = 13;
            p.TabStop = false;
        }
    }
}
