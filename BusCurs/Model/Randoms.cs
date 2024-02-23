using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCurs.Model
{
    public static class Randoms
    {
        public static float Parametre_exp(float min, float max)//экспоненциальное распределение
        {
            NormalDistribution r = new NormalDistribution();
            Random r_ = new Random();
            float result = ((float)(-Math.Log(r_.NextDouble())) / 2.0f);
            return (float)(min + result * (max - min));
        }

        public static float Parametre_ravn(float min, float max)//равномерное распределение
        {
            NormalDistribution r = new NormalDistribution();
            Random r_ = new Random();
            return (float)(min + r_.NextDouble() * (max - min));
        }
    }
}
