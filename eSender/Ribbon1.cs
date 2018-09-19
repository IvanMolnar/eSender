using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Outlook;
using OutlookApp = Microsoft.Office.Interop.Outlook.Application;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using System.Windows.Forms;

namespace eSender
{
    public partial class Ribbon1
    {
        private eSender.Settings settingsWindow;
        private Info infoWindow;

        private string emailTemplatePath = "";
        private string csvPath = "";

        private string folderPath;
        private string filePath;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\eSender";
            filePath = folderPath + @"\log.txt";
            settingsWindow = new eSender.Settings(folderPath);
            settingsWindow.readSettings();
            emailTemplatePath = settingsWindow.templateLabel.Text;
            csvPath = settingsWindow.csvLabel.Text;
        }

        private void Settings_Click(object sender, RibbonControlEventArgs e)
        {
            settingsWindow.ShowDialog();
            emailTemplatePath = settingsWindow.templateLabel.Text;
            csvPath = settingsWindow.csvLabel.Text;
        }

        private void Send_Click(object sender, RibbonControlEventArgs e)
        {
            infoWindow = new Info();

            List<string> errorString = new List<string>();

            if (!File.Exists(emailTemplatePath))
            {
                errorString.Add("Template");
            }

            if (!File.Exists(csvPath))
            {
                errorString.Add("CSV");
            }

            if (errorString.Count() > 0)
            {
                foreach (string item in errorString)
                {
                    writeToLog(item + " path is not valid!", true);
                }
            }
            else
            {
                processCSV(csvPath);
            }
        }

        private void processCSV(string csvPath)
        {
            int lineCount = 0;

            try
            {
                lineCount = File.ReadLines(csvPath).Count();
            }
            catch (System.Exception e)
            {
                writeToLog("Exception: " + e.Message, true);
                return;
            }

            List<string> errorList = new List<string>();

            Info infoWindow = new Info();
            infoWindow.progressBar.Maximum = lineCount;
            infoWindow.Show();

            using (TextFieldParser parser = new TextFieldParser(csvPath, Encoding.Default, true))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                OutlookApp outlookApp = new OutlookApp();

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    if (fields.Count() > 6)
                    {
                        string name = fields[3].Trim();
                        string email = fields[6].Replace(" ", "");

                        if ((name.Count() > 0) && (email.Count() > 3))
                        {
                            try
                            {
                                sendEmail(name, email, ref outlookApp);
                            }
                            catch (System.Exception ex)
                            {
                                string errorMessage = "An exception is occurred in the code of add-in. Message: " + ex.Message;
                                writeToLog(errorMessage);
                                errorList.Add(errorMessage);
                            }

                            ++infoWindow.progressBar.Value;
                        }
                        else
                        {
                            string errorMessage = "Could not send email: name is " + name + " email is " + email;
                            writeToLog(errorMessage);
                            errorList.Add(errorMessage);
                        }

                    }
                    else
                    {
                        string errorMessage = "Could not send email: Csv bad format. There should be at least 7 fields in a row. Fields data: " + fields;
                        writeToLog(errorMessage);
                        errorList.Add(errorMessage);
                    }

                }
            }

            infoWindow.Close();

            if (errorList.Count() > 0)
            {
                Report reportWindow = new Report();
                reportWindow.listBox.Items.Clear();

                foreach (string item in errorList)
                {
                    reportWindow.listBox.Items.Add(item);
                }

                reportWindow.ShowDialog();
            }

        }

        private void sendEmail(string name, string email, ref OutlookApp outlookApp)
        {
            MailItem mailItem = outlookApp.CreateItemFromTemplate(emailTemplatePath);

            mailItem.HTMLBody = mailItem.HTMLBody.Replace("%name%", name);
            mailItem.To = email;

            mailItem.Send();
        }

        private void writeToLog(string data, bool error = false)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt") + " " + data);
            }

            if (error)
            {
                MessageBox.Show(data, "Error");
            }

        }



    }
}
