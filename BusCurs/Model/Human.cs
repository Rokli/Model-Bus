using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCurs.Model
{
    public class Human
    {
        public int numberStation {  get; set; }
        public Human(int number)
        {
            numberStation = number;
        }
    }
}
