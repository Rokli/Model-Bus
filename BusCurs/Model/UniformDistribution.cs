using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCurs.Model
{
    public class UniformDistribution
    {
        public Random g_ = new Random();
        public float Randoms(float min, float max)//равномерное распределение
        {
            return (float)(min + g_.NextDouble() * (max - min));
        }
    }
}
