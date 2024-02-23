using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCurs.Model
{
    public class Bus
    {
        public Queue<Human> _humans { get; set; }
        int _memberHumans { get; set; }
        public double _speed {  get; set; }
        public double _time {  get; set; } = 0 ;

        public Bus(double speed, int memberHumans) 
        {
            _memberHumans = memberHumans;
            _humans = new Queue<Human>(memberHumans);
            _speed = speed;
        }
        public Queue<Human> InputBus(Queue<Human> human)
        {   
            while (_humans.Count != _memberHumans)
            {
                if (!human.Any())
                    return human;
                _humans.Enqueue(human.Dequeue());
                _time += Randoms.Parametre_ravn(0.2f,1.6f);
            }
            return human;
        }

        public void OutputBus(int numberStation)
        {
            Queue<Human> tmp = new Queue<Human> (_memberHumans);
            while(_humans.Count != 0)
            {
                if(_humans.Peek().numberStation != numberStation) 
                    tmp.Enqueue(_humans.Dequeue());
                else
                    _humans.Dequeue();
            }
            _humans = tmp;
        }

    }
}
