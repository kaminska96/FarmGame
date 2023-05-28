using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmGame
{
    public class Chicken : Animal
    {
        private static Random rand = new Random();
        public const int buyChicken = 45;
        public const int sellChicken = 30;
        private int eggCounter;
        private bool isEgg;
        public Chicken() : base()
        {
            isEgg = false;
            speed = 4;
            eggCounter = 0;
            type = 2;
        }
        public Chicken(int _id) : base()
        {
            id = _id;
            isEgg = false;
            speed = 4;
            eggCounter = 0;
            type = 2;
        }
        public override void gainSpeed() { speed = 4; }
        public void updateEgg(bool val) { isEgg = val; }
        public override bool doesEgg() { return isEgg; }
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
            return Math.Abs(X - coordinates.X) <= 100 && Math.Abs(Y - coordinates.Y) <= 100;
        }
        public override void sound()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.chicken1);
            sound.Play();
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
            if (hunger - 2 <= 0 || health - 1 <= 0)
                isAlive = false;
            else
            {
                if(hunger <= 100 || health <= 100)
                {
                    sound();
                }
                eggCounter++;
                hunger -= 2;
                health -= 1;
                if (eggCounter == 5)
                {
                    updateEgg(true);
                    eggCounter = 0;
                }
            }
        }
        public override void displayAnimal(PictureBox p)
        {
            p.BackColor = System.Drawing.Color.Transparent;
            p.Cursor = System.Windows.Forms.Cursors.Hand;
            p.Image = global::FarmGame.Properties.Resources.chicken;
            p.InitialImage = global::FarmGame.Properties.Resources.chicken;
            p.Location = new System.Drawing.Point((int)getX(), (int)getY());
            p.Size = new System.Drawing.Size(100, 100);
            p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            p.TabIndex = 13;
            p.TabStop = false;
        }
    }
}
