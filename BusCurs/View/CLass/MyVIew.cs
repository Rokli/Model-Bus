using BusCurs.Model;
using BusCurs.View.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; 

namespace BusCurs.View.CLass
{
    public class MyVIew: Form, IMyVIew
    {
        private Label label1;
        private TextBox NumberStation;
        private Label NumberStation1;
        private TextBox NumberPeopleOne;
        private Label label2;
        private TextBox NumberBusSpeedOne;
        private Label label3;
        private TextBox NumberBusSpeedTwo;
        private Label label4;
        private TextBox NumberPeopleTwo;
        private Label label6;
        private Label label5;
        private TextBox NumberRoadTwo;
        private Label label7;
        private TextBox NumberRoadOne;
        private Label label8;
        private Label label32;
        private TextBox NumberMember;
        private RadioButton NumberTimeEigth;
        private RadioButton NumberTimeDay;
        private RadioButton NumberTimeEvening;
        private TextBox NumberBusOne;

        public MyChart InputControlChart { set => Controls.Add(value); }
        public Button InputControlButton { set => Controls.Add(value); }
        public TextBox[][] GetTextBox { get; set; }
        public RadioButton[] GetRadioButton { get; set; }

        public string path { get; set; } = "C:\\Users\\satal\\source\\repos\\BusCurs\\BusCurs\\Save\\textbox.json";

        public MyVIew(SaveLoad load)
        {
            InitializeComponent();
            GetTextBox = [[NumberBusOne],[NumberStation],[NumberPeopleOne,NumberPeopleTwo],
                         [NumberBusSpeedOne, NumberBusSpeedTwo],[NumberRoadOne,NumberRoadTwo],
                         [NumberMember]];
            GetRadioButton = [NumberTimeEigth, NumberTimeDay, NumberTimeEvening];
            GetTextBox = load.Load(path, GetTextBox);
        }
        private void InitializeComponent()
        {
            this.NumberBusOne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberStation = new System.Windows.Forms.TextBox();
            this.NumberStation1 = new System.Windows.Forms.Label();
            this.NumberPeopleOne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberBusSpeedOne = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberBusSpeedTwo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberPeopleTwo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberRoadTwo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NumberRoadOne = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.NumberMember = new System.Windows.Forms.TextBox();
            this.NumberTimeEigth = new System.Windows.Forms.RadioButton();
            this.NumberTimeDay = new System.Windows.Forms.RadioButton();
            this.NumberTimeEvening = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // NumberBusOne
            // 
            this.NumberBusOne.Location = new System.Drawing.Point(419, 28);
            this.NumberBusOne.Name = "NumberBusOne";
            this.NumberBusOne.Size = new System.Drawing.Size(155, 22);
            this.NumberBusOne.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество автобусов";
            // 
            // NumberStation
            // 
            this.NumberStation.Location = new System.Drawing.Point(421, 72);
            this.NumberStation.Name = "NumberStation";
            this.NumberStation.Size = new System.Drawing.Size(155, 22);
            this.NumberStation.TabIndex = 2;
            // 
            // NumberStation1
            // 
            this.NumberStation1.AutoSize = true;
            this.NumberStation1.Location = new System.Drawing.Point(417, 53);
            this.NumberStation1.Name = "NumberStation1";
            this.NumberStation1.Size = new System.Drawing.Size(157, 16);
            this.NumberStation1.TabIndex = 3;
            this.NumberStation1.Text = "Количество остановок";
            // 
            // NumberPeopleOne
            // 
            this.NumberPeopleOne.Location = new System.Drawing.Point(419, 116);
            this.NumberPeopleOne.Name = "NumberPeopleOne";
            this.NumberPeopleOne.Size = new System.Drawing.Size(103, 22);
            this.NumberPeopleOne.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество на станции людей";
            // 
            // NumberBusSpeedOne
            // 
            this.NumberBusSpeedOne.Location = new System.Drawing.Point(421, 160);
            this.NumberBusSpeedOne.Name = "NumberBusSpeedOne";
            this.NumberBusSpeedOne.Size = new System.Drawing.Size(103, 22);
            this.NumberBusSpeedOne.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Скорость автобуса";
            // 
            // NumberBusSpeedTwo
            // 
            this.NumberBusSpeedTwo.Location = new System.Drawing.Point(575, 160);
            this.NumberBusSpeedTwo.Name = "NumberBusSpeedTwo";
            this.NumberBusSpeedTwo.Size = new System.Drawing.Size(103, 22);
            this.NumberBusSpeedTwo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "--------";
            // 
            // NumberPeopleTwo
            // 
            this.NumberPeopleTwo.Location = new System.Drawing.Point(573, 116);
            this.NumberPeopleTwo.Name = "NumberPeopleTwo";
            this.NumberPeopleTwo.Size = new System.Drawing.Size(103, 22);
            this.NumberPeopleTwo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "--------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "--------";
            // 
            // NumberRoadTwo
            // 
            this.NumberRoadTwo.Location = new System.Drawing.Point(573, 204);
            this.NumberRoadTwo.Name = "NumberRoadTwo";
            this.NumberRoadTwo.Size = new System.Drawing.Size(103, 22);
            this.NumberRoadTwo.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Расстояние между остановками";
            // 
            // NumberRoadOne
            // 
            this.NumberRoadOne.Location = new System.Drawing.Point(419, 204);
            this.NumberRoadOne.Name = "NumberRoadOne";
            this.NumberRoadOne.Size = new System.Drawing.Size(103, 22);
            this.NumberRoadOne.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Время дня";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(418, 279);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(195, 16);
            this.label32.TabIndex = 21;
            this.label32.Text = "Количество мест в автобусе";
            // 
            // NumberMember
            // 
            this.NumberMember.Location = new System.Drawing.Point(421, 298);
            this.NumberMember.Name = "NumberMember";
            this.NumberMember.Size = new System.Drawing.Size(155, 22);
            this.NumberMember.TabIndex = 20;
            // 
            // NumberTimeEigth
            // 
            this.NumberTimeEigth.AutoSize = true;
            this.NumberTimeEigth.Checked = true;
            this.NumberTimeEigth.Location = new System.Drawing.Point(419, 256);
            this.NumberTimeEigth.Name = "NumberTimeEigth";
            this.NumberTimeEigth.Size = new System.Drawing.Size(52, 20);
            this.NumberTimeEigth.TabIndex = 22;
            this.NumberTimeEigth.TabStop = true;
            this.NumberTimeEigth.Text = "8:00";
            this.NumberTimeEigth.UseVisualStyleBackColor = true;
            // 
            // NumberTimeDay
            // 
            this.NumberTimeDay.AutoSize = true;
            this.NumberTimeDay.Location = new System.Drawing.Point(477, 256);
            this.NumberTimeDay.Name = "NumberTimeDay";
            this.NumberTimeDay.Size = new System.Drawing.Size(59, 20);
            this.NumberTimeDay.TabIndex = 23;
            this.NumberTimeDay.TabStop = true;
            this.NumberTimeDay.Text = "13:00";
            this.NumberTimeDay.UseVisualStyleBackColor = true;
            // 
            // NumberTimeEvening
            // 
            this.NumberTimeEvening.AutoSize = true;
            this.NumberTimeEvening.Location = new System.Drawing.Point(542, 256);
            this.NumberTimeEvening.Name = "NumberTimeEvening";
            this.NumberTimeEvening.Size = new System.Drawing.Size(59, 20);
            this.NumberTimeEvening.TabIndex = 24;
            this.NumberTimeEvening.TabStop = true;
            this.NumberTimeEvening.Text = "19:00";
            this.NumberTimeEvening.UseVisualStyleBackColor = true;
            // 
            // MyVIew
            // 
            this.ClientSize = new System.Drawing.Size(722, 538);
            this.Controls.Add(this.NumberTimeEvening);
            this.Controls.Add(this.NumberTimeDay);
            this.Controls.Add(this.NumberTimeEigth);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.NumberMember);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumberRoadTwo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumberRoadOne);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NumberPeopleTwo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumberBusSpeedTwo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumberBusSpeedOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberPeopleOne);
            this.Controls.Add(this.NumberStation1);
            this.Controls.Add(this.NumberStation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberBusOne);
            this.Name = "MyVIew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
