using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusCurs.View.CLass
{
    public class CheckWindow : Form
    {
        private Label label1;

        public CheckWindow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Неправильно введены данные";
            // 
            // CheckWindow
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(368, 276);
            this.Controls.Add(this.label1);
            this.Name = "CheckWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
