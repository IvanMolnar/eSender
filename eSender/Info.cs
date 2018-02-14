using Microsoft.Office.Interop.Outlook;
using Microsoft.VisualBasic.FileIO;
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
using OutlookApp = Microsoft.Office.Interop.Outlook.Application;

namespace eSender
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();

            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = 0;
        }

        
    }
}
