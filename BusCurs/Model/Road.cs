using BusCurs.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusCurs.Model
{
    public class Road : IRoadBus
    {
        public double length { get; set; }
        public int _timeDay { get; set; }
        public Road(float numberLengthOne, float numberLengthTwo,int timeDay) 
        {
            _timeDay = timeDay;
            length = Randoms.Parametre_ravn(numberLengthOne, numberLengthTwo) * 1000;
        }
        public Bus InputBus(Bus bus)
        {
            Random random = new Random();
            double chance = random.NextDouble();
            if (chance > 0 && chance < 0.005) bus._time += Randoms.Parametre_ravn(10, 30);
            if (chance > 0 && chance < 0.005) bus._time += PickDay();
            bus._time += length / bus._speed;
            return bus;
        }
        private float PickDay()
        {
            switch (_timeDay)
            {
                case 0:
                    return Randoms.Parametre_ravn(10, 30);
                case 1:
                    return Randoms.Parametre_ravn(1,10);
                case 2:
                    return Randoms.Parametre_ravn(20, 25);
                default:
                    return 0;
            }
        }
    }
}
