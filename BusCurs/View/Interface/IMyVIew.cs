using BusCurs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BusCurs.View.Interface
{
    public interface IMyVIew
    {
        MyChart inputControlChart { set; }
        Button inputControlButton { set; }
        TextBox[][] getTextBox { get; set; }
        RadioButton[] getRadioButton{ get; set; }
        RadioButton[] getDistribution { get; set; }
    }
}
