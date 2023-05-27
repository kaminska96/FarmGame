using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace FarmGame
{
    public class Animal
    {
        private static Random rand = new Random();
        public Time age;
        public int id;
        public int type;

        protected int hunger;
        protected int health;
        protected Vector coordinates, direction;
        protected double speed = 3;
        public bool isAlive;

        public Animal()
        {
            isAlive = true;
            coordinates.X = rand.Next(140, 700);
            coordinates.Y = rand.Next(100, 465);
            age = new Time(0);
            hunger = health = 200;
            createDirection();
        }
        public virtual bool doesLactate() { return false; }
        public virtual bool doesEgg() { return false; }
        public virtual bool doesWool() { return false; }
        public virtual bool isInside(int X, int Y) { return true; }
        public void feedAnimal()
        {
            if (hunger + 40 <= 200)
                hunger += 40;
            else
                hunger = 200;
        }
        public void healAnimal()
        {
            if (health + 80 <= 200)
                health += 80;
            else
                health = 200;
        }
        public void displayAnimalStats(Label l1, Label l2, Label l3, ProgressBar b1, ProgressBar b2)
        {
            l1.Text = id.ToString();
            b1.Value = hunger;
            b2.Value = health;
            l3.Text = age.daysUpdate() + " days";
            switch (type)
            {
                case 0: l2.Text = "Cow"; break;
                case 1: l2.Text = "Sheep"; break;
                case 2: l2.Text = "Chicken"; break;
                default: break;
            }
        }
        public int getType() { return type; }
        public double getSpeed() { return speed; }
        public void setSpeed(int val) { speed = val; }
        public virtual void gainSpeed() { }
        public double getX() { return coordinates.X; }
        public double getY() { return coordinates.Y; }
        public void SetX(int val) { coordinates.X = (double)val; }
        public void SetY(int val) { coordinates.Y = (double)val; }
        public virtual void updateLocation(bool changeDirection) { }
        public virtual void createDirection() { }
        public virtual void displayAnimal(PictureBox p) { }
        public virtual void updateStats() { }
    }
}
