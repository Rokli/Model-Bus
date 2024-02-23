using BusCurs.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BusCurs.Model
{
    public class BusStation : IRoadBus
    {
        public int _numberStation {  get; set; }
        public Queue<Human> _humans { get; set; }
        public Bus bus { get; set; }
        public BusStation(Queue<Human> humans, int numberStation)
        {
            _humans = humans;
            _numberStation = numberStation; 
        }
        public Bus InputBus(Bus bus)
        {
            _humans = bus.InputBus(_humans);
            bus.OutputBus(_numberStation);
            return bus;
        }


    }
}
