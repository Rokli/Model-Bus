using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCurs.Model
{
    public class ExponentialDistribution
    {
        public Random r_ = new Random();
        public float Randoms(float min, float max)
        {
            float result = ((float)(-Math.Log(r_.NextDouble())) / 2.0f);
            return (float)(min + result * (max - min));
        }
    }
}
