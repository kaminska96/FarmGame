using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace FarmGame
{
    public class Cow : Animal
    {
        private static Random rand = new Random();
        public const int buyCow = 250;
        public const int sellCow = 220;
        private int lactatingCounter;
        private bool isLactating;
        public Cow() : base()
        {
            isLactating = false;
            speed = 2;
            lactatingCounter = 0;
            type = 0;
        }
        public Cow(int _id) : base()
        {
            id = _id;
            isLactating = false;
            speed = 2;
            lactatingCounter = 0;
            type = 0;
        }
        public override void gainSpeed() { speed = 2; }
        public void updateLactate(bool val) { isLactating = val; }
        public override bool doesLactate() { return isLactating; }
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
            return Math.Abs(X - coordinates.X) <= 60 && Math.Abs(Y - coordinates.Y) <= 60;
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
                lactatingCounter++;
                hunger -= 3;
                health -= 1;
                if (lactatingCounter == 20)
                {
                    updateLactate(true);
                    lactatingCounter = 0;
                }
            }
        }
        public override void displayAnimal(PictureBox p)
        {
            p.BackColor = System.Drawing.Color.Transparent;
            p.Cursor = System.Windows.Forms.Cursors.Hand;
            p.Image = global::FarmGame.Properties.Resources.cow;
            p.InitialImage = global::FarmGame.Properties.Resources.cow;
            p.Location = new System.Drawing.Point((int)getX(), (int)getY());
            p.Size = new System.Drawing.Size(61, 58);
            p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            p.TabIndex = 13;
            p.TabStop = false;
        }
    }
}
