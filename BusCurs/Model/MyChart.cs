using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace BusCurs.Model
{
    public class MyChart : Chart
    {
        public MyChart() 
        {
            Location = new System.Drawing.Point(10, 10);
            Size = new System.Drawing.Size(400,400);
            ChartAreas.Add("ChartArea1");
            ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            Series.Add("1");
            Series[0].ChartType = SeriesChartType.Column;
        }
    }
}
