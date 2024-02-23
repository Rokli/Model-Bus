using BusCurs.Model;
using BusCurs.Model.Interface;
using BusCurs.View.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms.VisualStyles;
using BusCurs.View.CLass;

namespace BusCurs.Presenter
{
    public class MyPresenter
    {
        public IMyVIew _view { get; set; }
        public MyChart chart = new MyChart();
        public string _filePath = "C:\\Users\\satal\\source\\repos\\BusCurs\\BusCurs\\Save\\textbox.json";
        SaveLoad saveLoad { get; set; } = new SaveLoad();
        public int timeDay {  get; set; }
        public TextBox[][] GetTextBox {  get; set; }
        public MyPresenter(IMyVIew view) 
        {
            _view = view;
            InitializeComponent();
        }    
        private void InitializeComponent()
        {
            _view.InputControlChart = chart;
            Button butt = new Button
            {
                Size = new Size(100, 50),
                Text = "Старт",
                Location = new Point(420,360)
            };
            butt.Click += new EventHandler(Start);
            _view.InputControlButton = butt;
            timeDay = PickDay();
        }

        private void Start(object args, EventArgs e)
        {
            GetTextBox = _view.GetTextBox;
            if (!Check())
            {
                CheckWindow window = new CheckWindow();
                window.ShowDialog();
            }
            else
            {
                StartPath();
            }
        }
        private void StartPath()
        {
            chart.Series.Clear();
            IRoadBus[] buses = Route();
            chart.Series.Clear();
            for (int i = 0; i < Convert.ToInt32(GetTextBox[0][0].Text); i++)
            {
                double speed = (double)Randoms.Parametre_ravn(float.Parse(GetTextBox[3][0].Text), float.Parse(GetTextBox[3][0].Text)) * 16.67f;
                int member = Convert.ToInt32(GetTextBox[5][0].Text);
                Bus bus = new Bus(speed, member);

                for (int j = 0; j < buses.Length; j++)
                    bus = buses[j].InputBus(bus);
                for (int j = buses.Length - 1; j >= 0; j--)
                    bus = buses[j].InputBus(bus);

                chart.Series.Add($"{i}");
                chart.Series[$"{i}"].ChartType = SeriesChartType.Column;
                chart.Series[$"{i}"].Points.AddXY(i, bus._time);
            }
            saveLoad.Save(_filePath, GetTextBox);
        }
        private IRoadBus[] Route()
        {
            int numberStation = Convert.ToInt32(GetTextBox[1][0].Text) + Convert.ToInt32(GetTextBox[1][0].Text);
            IRoadBus[] roadBuses = new IRoadBus[numberStation];
            for(int i = 0; i < numberStation; i++)
            {
                if (i % 2 == 0) roadBuses[i] = new Road(Convert.ToInt32(GetTextBox[4][0].Text), Convert.ToInt32(GetTextBox[4][1].Text), PickDay());
                else roadBuses[i] = new BusStation(CreatePeople(),i);
            }
            return roadBuses;
        }

        private Queue<Human> CreatePeople()
        {
            Random rand = new Random();
            Queue<Human> people = new Queue<Human>();
            double randPeople = Randoms.Parametre_ravn(Convert.ToInt32(GetTextBox[2][0].Text), Convert.ToInt32(GetTextBox[2][1].Text)); 
            for(int i = 0; i < randPeople; i++)
            {
                people.Enqueue(new Human(rand.Next(1, Convert.ToInt32(GetTextBox[1][0].Text))));
            }
            return people;
        }
        private int PickDay()
        {
            if (_view.GetRadioButton[0].Checked)
                return 0;
            else if(_view.GetRadioButton[1].Checked) 
                return 1;
            else return 2;
        }
        private bool Check()
        {
            int[] tmp = ForCheck();
            if (tmp[0] < 1 || tmp[0] > 60)
                return false;
            if (tmp[1] < 1 || tmp[1] > 20)
                return false;
            if (tmp[2] <  1 || tmp[3] > 50)
                return false;
            if (tmp[4] < 20 || tmp[5] > 120)
                return false;
            if (tmp[6] < 1 || tmp[7] > 30)
                return false;
            if (tmp[8] < 20 || tmp[8] > 80)
                return false;
            return true;
        }
        private int[] ForCheck()
        {
            int[] tmp = new int[10];
            int i = 0;
            foreach(TextBox[] text in GetTextBox)
            {
                foreach(TextBox t in text)
                {
                    tmp[i] = Convert.ToInt32(t.Text);
                    i++;
                }
            }
            return tmp;
        }
    }
}
