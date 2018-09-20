using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eSender
{
    public partial class Settings : Form
    {
        private string _folderPath;
        private string _filePath;

        public Settings(string folderPath)
        {
            InitializeComponent();

            csvLabel.Text = "";
            templateLabel.Text = "";
            _folderPath = folderPath;
            _filePath = folderPath + @"\eSender.settings";
        }

        private void selectCSV_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV File|*.csv";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                csvLabel.Text = openFileDialog1.FileName;
            }
        }

        private void selectTemplate_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Template|*.oft";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                templateLabel.Text = openFileDialog1.FileName;
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            writeSettings();
            Close();
        }

        public void readSettings()
        {
            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }

            if (File.Exists(_filePath))
            {
                var lines = File.ReadLines(_filePath);

                if ((lines.Count() > 0) && (File.Exists(lines.ElementAt(0))))
                {
                    templateLabel.Text = lines.ElementAt(0);
                }
                else
                {
                    templateLabel.Text = "";
                }

                if ((lines.Count() > 1) && (File.Exists(lines.ElementAt(1))))
                {
                    csvLabel.Text = lines.ElementAt(1);
                }
                else
                {
                    csvLabel.Text = "";
                }

                if (lines.Count() > 2)
                {
                    string batchSize = lines.ElementAt(2);

                    int result = 0;
                    bool canConvert = int.TryParse(batchSize, out result);

                    if (canConvert)
                    {
                        numBatchSize.Value = result;
                    }
                    else
                    {
                        numBatchSize.Value = 0;
                    }
                }

                if (lines.Count() > 3)
                {
                    string batchSize = lines.ElementAt(3);

                    int result = 0;
                    bool canConvert = int.TryParse(batchSize, out result);

                    if (canConvert)
                    {
                        numDelay.Value = result;
                    }
                    else
                    {
                        numDelay.Value = 0;
                    }
                }

            }
            else
            {
                csvLabel.Text = "";
                templateLabel.Text = "";
                numBatchSize.Value = 0;
                numDelay.Value = 0;
            }
  
        }

        private void writeSettings()
        {
            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }

            string settingsString = templateLabel.Text + Environment.NewLine + csvLabel.Text + Environment.NewLine + numBatchSize.Value + Environment.NewLine + numDelay.Value;

            File.WriteAllText(_filePath, settingsString);
        }

    }
}
