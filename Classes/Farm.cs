using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmGame
{
    public class Farm
    {
        public List<Animal> Animals;
        private Cash Money;
        private Time myTime;
        public int farmSize;
        public int cowCount { get; set; }
        public int sheepCount { get; set; }
        public int chickenCount { get; set; }

        // protected Animal[] animals;
        public Farm()
        {
            Money = new Cash();
            myTime = new Time();
            Animals = new List<Animal>();
            farmSize = cowCount = sheepCount = chickenCount = 0;
        }
        public ref Cash GetCashRef()
        {
            return ref this.Money;
        }
        public ref Time GetTimeRef()
        {
            return ref this.myTime;
        }
        public void AddAnimalToList(int amount, int type)
        {
            int i;
            for (i = 0; i < amount; i++, farmSize++)
            {
                switch (type)
                {
                    case 0:
                        Animals.Add(new Cow(farmSize));
                        break;
                    case 1:
                        Animals.Add(new Sheep(farmSize));
                        break;
                    case 2:
                        Animals.Add(new Chicken(farmSize));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
