using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusCurs.Model
{
    public class Randoms
    {
        public ExponentialDistribution exp { get; set; } = new ExponentialDistribution();
        public UniformDistribution uniform { get; set; } = new UniformDistribution();
        public int _rand { get; set; }
        public Randoms(RadioButton[] radioButtons)
        {
            CheckRadioButton(radioButtons);
        }
        public Randoms(int rand)
        {
            _rand = rand;
        }

        public void CheckRadioButton(RadioButton[] radioButtons)
        {
            if (radioButtons[0].Checked) _rand = 0;
            else _rand = 1;
        }
        public float Random(float min, float max)
        {
            if (_rand == 0) return exp.Randoms(min, max);
            else return uniform.Randoms(min, max);
        }
    }
    
}
