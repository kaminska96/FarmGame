using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmGame
{
    public partial class Form1 : Form
    {
        private int counter, moveTickCount, curIndex, prevIndex;
        private Farm animalFarm = new Farm();
        public List<PictureBox> animalImages = new List<PictureBox>();

        public Form1()
        {

            InitializeComponent();
            prevIndex = curIndex = -1;
            moveTickCount = counter = 0;
            timer1.Start();
            moveAnimal.Start();
            label8.Text = animalFarm.GetCashRef().cashUpdate();

            this.day_count_label.Parent = pictureBox1;
        }
        private void buyButtonClick(object sender, EventArgs e)
        {
            int price = 0;
            try
            {
                price = Int32.Parse(cost_label.Text);
                if (price > 0 && animalFarm.GetCashRef().getMoney() - price >= 0)
                {
                    if (chicken_radio_button.Checked == true)
                    {
                        animalFarm.GetCashRef() -= price;
                        animalFarm.chickenCount += Int32.Parse(amount_label.Text);
                        ch_amount_label.Text = animalFarm.chickenCount.ToString();
                        int begin = animalFarm.farmSize;
                        animalFarm.AddAnimalToList(Int32.Parse(amount_label.Text), 2);

                        displayAnimals(begin, animalFarm.farmSize);

                        label8.Text = animalFarm.GetCashRef().cashUpdate();
                    }
                    else if (sheep_radio_button.Checked == true)
                    {
                        animalFarm.GetCashRef() -= price;
                        animalFarm.sheepCount += Int32.Parse(amount_label.Text);
                        sh_amount_label.Text = animalFarm.sheepCount.ToString();
                        int begin = animalFarm.farmSize;
                        animalFarm.AddAnimalToList(Int32.Parse(amount_label.Text), 1);

                        displayAnimals(begin, animalFarm.farmSize);

                        label8.Text = animalFarm.GetCashRef().cashUpdate();
                    }
                    else if (cow_radio_button.Checked == true)
                    {
                        animalFarm.GetCashRef() -= price;
                        animalFarm.cowCount += Int32.Parse(amount_label.Text);
                        c_amount_label.Text = animalFarm.cowCount.ToString();
                        int begin = animalFarm.farmSize;
                        animalFarm.AddAnimalToList(Int32.Parse(amount_label.Text), 0);

                        displayAnimals(begin, animalFarm.farmSize);

                        label8.Text = animalFarm.GetCashRef().cashUpdate();
                    }
                }
            }
            catch
            {

            }
        }
        private void visualMouseDown(object sender, MouseEventArgs e)
        {
            PictureBox visual = new PictureBox();
            visual = (PictureBox)sender;
            curIndex = -1;
            for (int i = 0; i < animalFarm.farmSize; i++)
            {
                if (animalFarm.Animals[i].isInside(visual.Location.X + e.X, visual.Location.Y + e.Y))
                {
                    string s = e.Button.ToString();
                    if (s == "Left")
                    {
                        animalFarm.Animals[i].displayAnimalStats(id_label, type_label, age_label, hunger_bar, health_bar);
                        prevIndex = curIndex = i;
                        animalFarm.Animals[i].setSpeed(0);
                        break;
                    }
                }
            }
        }
        private void visualMouseMove(object sender, MouseEventArgs e)
        {
            PictureBox visual = new PictureBox();
            visual = (PictureBox)sender;
            if (curIndex >= 0)
            {
                animalFarm.Animals[curIndex].SetX(visual.Location.X + e.X - 30);
                animalFarm.Animals[curIndex].SetY(visual.Location.Y + e.Y - 30);
            }
        }

        private void visualMouseUp(object sender, MouseEventArgs e)
        {
            if (curIndex >= 0)
                animalFarm.Animals[curIndex].gainSpeed();
            curIndex = -1;
        }
        private void displayAnimals(int begin, int end)
        {
            for (int i = begin; i < end; i++)
            {
                animalImages.Add(new PictureBox());
                ((System.ComponentModel.ISupportInitialize)(animalImages[i])).BeginInit();
                animalFarm.Animals[i].displayAnimal(animalImages[i]);
                animalImages[i].Name = "visual" + i.ToString();
                animalImages[i].MouseDown += new MouseEventHandler(this.visualMouseDown);
                animalImages[i].MouseMove += new MouseEventHandler(this.visualMouseMove);
                animalImages[i].MouseUp += new MouseEventHandler(this.visualMouseUp);
                this.Controls.Add(animalImages[i]);
                ((System.ComponentModel.ISupportInitialize)(animalImages[i])).EndInit();
                animalImages[i].Parent = this.pictureBox1;
            }
        }
        private void comboBox1SelectedVal(object sender, EventArgs e)
        {
            amount_label.Text = choose_amount.SelectedIndex.ToString();
            int x = 0, price = 0;
            if (cow_radio_button.Checked == true)
            {
                price = Cow.buyCow;
            }
            else if (sheep_radio_button.Checked == true)
            {
                price = Sheep.buySheep;
            }
            else if (chicken_radio_button.Checked == true)
            {
                price = Chicken.buyChicken;
            }
            try
            {
                x = Int32.Parse(amount_label.Text) * price;
                cost_label.Text = x.ToString();
            }
            catch
            {
                cost_label.Text = x.ToString();
            }
        }
        private void comboBox1Text(object sender, EventArgs e)
        {
            int y = 0;
            try
            {
                y = Int32.Parse(choose_amount.Text);
                if (y > 99)
                    y = 99;
                if (y < 0)
                    y = 0;
                amount_label.Text = y.ToString();
            }
            catch
            {
                amount_label.Text = y.ToString();
            }
            int x = 0, price = 0;
            if (cow_radio_button.Checked == true)
            {
                price = Cow.buyCow;
            }
            else if (sheep_radio_button.Checked == true)
            {
                price = Sheep.buySheep;
            }
            else if (chicken_radio_button.Checked == true)
            {
                price = Chicken.buyChicken;
            }
            try
            {
                x = Int32.Parse(amount_label.Text) * price;
                cost_label.Text = x.ToString();
            }
            catch
            {
                cost_label.Text = x.ToString();
            }
        }
        private void cow_radio_button_check(object sender, EventArgs e)
        {
            sell_button.Image = FarmGame.Properties.Resources.cow;
            int x = 0;
            try
            {
                x = Int32.Parse(amount_label.Text) * Cow.buyCow;
                cost_label.Text = x.ToString();
            }
            catch
            {
                cost_label.Text = x.ToString();
            }
        }
        private void sheep_radio_button_check(object sender, EventArgs e)
        {
            sell_button.Image = FarmGame.Properties.Resources.sheep;
            int x = 0;
            try
            {
                x = Int32.Parse(amount_label.Text) * Sheep.buySheep;
                cost_label.Text = x.ToString();
            }
            catch
            {
                cost_label.Text = x.ToString();
            }
        }
        private void chicken_radio_button_check(object sender, EventArgs e)
        {
            sell_button.Image = FarmGame.Properties.Resources.chicken;
            int x = 0;
            try
            {
                x = Int32.Parse(amount_label.Text) * Chicken.buyChicken;
                cost_label.Text = x.ToString();
            }
            catch
            {
                cost_label.Text = x.ToString();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = animalFarm.GetCashRef().cashUpdate();

            animalFarm.GetTimeRef().increaseDays(day_count_label);
            for (int i = 0; i < animalFarm.farmSize; i++)
            {
                if (animalFarm.Animals[i].isAlive == false)
                {
                    switch (animalFarm.Animals[i].type)
                    {
                        case 0:
                            animalFarm.cowCount--;
                            c_amount_label.Text = animalFarm.cowCount.ToString();
                            break;
                        case 1:
                            animalFarm.sheepCount--;
                            sh_amount_label.Text = animalFarm.sheepCount.ToString();
                            break;
                        case 2:
                            animalFarm.chickenCount--;
                            ch_amount_label.Text = animalFarm.chickenCount.ToString();
                            break;
                        default:
                            break;
                    }
                    this.Controls.Remove(animalImages[i]);
                    animalImages[i].Dispose();
                    animalFarm.Animals.Remove(animalFarm.Animals[i]);
                    animalImages.Remove(animalImages[i]);
                    prevIndex = -1;
                    clearStats();
                    animalFarm.farmSize--;
                    continue;
                }
                animalFarm.Animals[i].age += 1;
                animalFarm.Animals[i].updateStats();
            }
        }
        private void moveAnimalTick(object sender, EventArgs e)
        {
            moveTickCount++;
            if (prevIndex >= 0)
                animalFarm.Animals[prevIndex].displayAnimalStats(id_label, type_label, age_label,
                    hunger_bar, health_bar);
            int i;
            if (moveTickCount == 20)
            {
                moveTickCount = 0;
                for (i = 0; i < animalFarm.farmSize; i++)
                {
                    animalFarm.Animals[i].updateLocation(true);
                    animalImages[i].Location = new Point((int)animalFarm.Animals[i].getX(), (int)animalFarm.Animals[i].getY());
                }
            }
            else
            {
                for (i = 0; i < animalFarm.farmSize; i++)
                {
                    animalFarm.Animals[i].updateLocation(false);
                    animalImages[i].Location = new Point((int)animalFarm.Animals[i].getX(), (int)animalFarm.Animals[i].getY());
                }
            }
        }
        private void health_button_Click(object sender, EventArgs e)
        {
            if (prevIndex >= 0)
            {
                animalFarm.GetCashRef() -= 10;
                label8.Text = animalFarm.GetCashRef().cashUpdate();
                animalFarm.Animals[prevIndex].healAnimal();
            }
        }
        private void feed_button_Click(object sender, EventArgs e)
        {
            if (prevIndex >= 0)
            {
                animalFarm.GetCashRef() -= 10;
                label8.Text = animalFarm.GetCashRef().cashUpdate();
                animalFarm.Animals[prevIndex].feedAnimal();
            }
        }
        private void meat_button_Click(object sender, EventArgs e)
        {
            if (prevIndex >= 0)
            {
                switch (animalFarm.Animals[prevIndex].getType())
                {
                    case 0:
                        animalFarm.cowCount--; c_amount_label.Text = animalFarm.cowCount.ToString();
                        animalFarm.GetCashRef() += Cow.sellCow;
                        label8.Text = animalFarm.GetCashRef().cashUpdate();
                        break;
                    case 1:
                        animalFarm.sheepCount--; sh_amount_label.Text = animalFarm.sheepCount.ToString();
                        animalFarm.GetCashRef() += Sheep.sellSheep;
                        label8.Text = animalFarm.GetCashRef().cashUpdate();
                        break;
                    case 2:
                        animalFarm.chickenCount--; ch_amount_label.Text = animalFarm.chickenCount.ToString();
                        animalFarm.GetCashRef() += Chicken.sellChicken;
                        label8.Text = animalFarm.GetCashRef().cashUpdate();
                        break;
                    default: break;
                }
                this.Controls.Remove(animalImages[prevIndex]);
                animalImages[prevIndex].Dispose();
                animalFarm.Animals.Remove(animalFarm.Animals[prevIndex]);
                animalImages.Remove(animalImages[prevIndex]);
                prevIndex = -1;
                animalFarm.farmSize--;
                clearStats();
            }
        }
        private void milk_button_Click(object sender, EventArgs e)
        {
            if (prevIndex >= 0)
            {
                if (animalFarm.Animals[prevIndex].doesLactate())
                {
                    animalFarm.GetCashRef() += 40;
                    label8.Text = animalFarm.GetCashRef().cashUpdate();
                    Cow c = (Cow)animalFarm.Animals[prevIndex];
                    c.updateLactate(false);
                }
                //else
                //noise.Play();
            }
        }

        private void wool_button_Click(object sender, EventArgs e)
        {
            if (prevIndex >= 0)
            {
                if (animalFarm.Animals[prevIndex].doesWool())
                {
                    animalFarm.GetCashRef() += 10;
                    label8.Text = animalFarm.GetCashRef().cashUpdate();
                    Sheep s = (Sheep)animalFarm.Animals[prevIndex];
                    s.updateWool(false);
                }
                //else
                //    noise.Play();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void egg_button_Click(object sender, EventArgs e)
        {
            if (prevIndex >= 0)
            {
                if (animalFarm.Animals[prevIndex].doesEgg())
                {
                    animalFarm.GetCashRef() += 10;
                    label8.Text = animalFarm.GetCashRef().cashUpdate();
                    Chicken c = (Chicken)animalFarm.Animals[prevIndex];
                    c.updateEgg(false);
                }
                //else
                //    noise.Play();
            }
        }
        private void clearStats()
        {
            id_label.Text = "-";
            type_label.Text = "-";
            age_label.Text = "-";
            hunger_bar.Value = 0;
            health_bar.Value = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
