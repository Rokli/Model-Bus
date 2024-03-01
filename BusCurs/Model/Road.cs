using BusCurs.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BusCurs.Model
{
    public class Road : IRoadBus
    {
        public double length { get; set; }
        public int _timeDay { get; set; }
        public Randoms _rand { get; set; }
        public Road(float numberLengthOne, float numberLengthTwo,int timeDay,Randoms rand) 
        {
            _rand = rand;
            _timeDay = timeDay;
            length = _rand.Random(numberLengthOne, numberLengthTwo) * 1000;
        }
        public Bus InputBus(Bus bus)
        {
            Random random = new Random();
            double chance = random.NextDouble();
            if (chance > 0 && chance < 0.005) bus._time += _rand.Random(10, 30);
            if (chance > 0 && chance < 0.005) bus._time += PickDay();
            bus._time += length / bus._speed;
            return bus;
        }
        private float PickDay()
        {
            switch (_timeDay)
            {
                case 0:
                    return _rand.Random(10, 30);
                case 1:
                    return _rand.Random(1,10);
                case 2:
                    return _rand.Random(20, 25);
                default:
                    return 0;
            }
        }
    }
}
