using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace BusCurs.Model
{
    public class SaveLoad
    {
        public string[][] NumberTime { get; set; }
        public void Save(string filepath, TextBox[][] textBoxes)
        {
            NumberTime = [[textBoxes[0][0].Text],
                [textBoxes[1][0].Text],
                [textBoxes[2][0].Text, textBoxes[2][1].Text],
                [textBoxes[3][0].Text, textBoxes[3][1].Text],
                [textBoxes[4][0].Text, textBoxes[4][1].Text],
                [textBoxes[5][0].Text]];
            StreamWriter writer = new StreamWriter(filepath, false);
            string json = JsonConvert.SerializeObject(this);
            writer.WriteAsync(json);
            writer.Dispose();
        }
        public TextBox[][] Load(string filepath, TextBox[][] textBoxes)
        {
            StreamReader reader = new StreamReader(filepath);
            string json = reader.ReadToEnd();
            reader.Dispose();
            SaveLoad tmp = JsonConvert.DeserializeObject<SaveLoad>(json);
            if (tmp  != null)
            {
                NumberTime = JsonConvert.DeserializeObject<SaveLoad>(json).NumberTime;
                textBoxes = LoadTextBox(textBoxes);
            }
            return textBoxes;
        }
        private TextBox[][] LoadTextBox(TextBox[][] textBoxes)
        {
            textBoxes[0][0].Text = NumberTime[0][0];
            textBoxes[1][0].Text = NumberTime[1][0];
            textBoxes[2][0].Text = NumberTime[2][0];
            textBoxes[2][1].Text = NumberTime[2][1];
            textBoxes[3][0].Text = NumberTime[3][0];
            textBoxes[3][1].Text = NumberTime[3][1];
            textBoxes[4][0].Text = NumberTime[4][0];
            textBoxes[4][1].Text = NumberTime[4][1];
            textBoxes[5][0].Text = NumberTime[5][0];
            return textBoxes;
        }
    }
}
