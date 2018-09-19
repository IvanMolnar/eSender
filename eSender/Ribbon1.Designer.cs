namespace eSender
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.MainGroup = this.Factory.CreateRibbonGroup();
            this.Settings = this.Factory.CreateRibbonButton();
            this.Send = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.MainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.MainGroup);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // MainGroup
            // 
            this.MainGroup.Items.Add(this.Settings);
            this.MainGroup.Items.Add(this.Send);
            this.MainGroup.Label = "eSender Beta3T";
            this.MainGroup.Name = "MainGroup";
            // 
            // Settings
            // 
            this.Settings.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Settings.Image = global::eSender.Properties.Resources.settings;
            this.Settings.Label = "Settings";
            this.Settings.Name = "Settings";
            this.Settings.ShowImage = true;
            this.Settings.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Settings_Click);
            // 
            // Send
            // 
            this.Send.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Send.Image = global::eSender.Properties.Resources.sendEmail;
            this.Send.Label = "Send";
            this.Send.Name = "Send";
            this.Send.ShowImage = true;
            this.Send.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Send_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup MainGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Settings;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Send;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
