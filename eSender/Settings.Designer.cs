namespace eSender
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectCSV = new System.Windows.Forms.Button();
            this.selectTemplate = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Ok = new System.Windows.Forms.Button();
            this.csvLabel = new System.Windows.Forms.Label();
            this.templateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectCSV
            // 
            this.selectCSV.Location = new System.Drawing.Point(12, 48);
            this.selectCSV.Name = "selectCSV";
            this.selectCSV.Size = new System.Drawing.Size(81, 31);
            this.selectCSV.TabIndex = 0;
            this.selectCSV.Text = "CSV";
            this.selectCSV.UseVisualStyleBackColor = true;
            this.selectCSV.Click += new System.EventHandler(this.selectCSV_Click);
            // 
            // selectTemplate
            // 
            this.selectTemplate.Location = new System.Drawing.Point(12, 134);
            this.selectTemplate.Name = "selectTemplate";
            this.selectTemplate.Size = new System.Drawing.Size(81, 31);
            this.selectTemplate.TabIndex = 1;
            this.selectTemplate.Text = "Template";
            this.selectTemplate.UseVisualStyleBackColor = true;
            this.selectTemplate.Click += new System.EventHandler(this.selectTemplate_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(197, 257);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 2;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // csvLabel
            // 
            this.csvLabel.AutoSize = true;
            this.csvLabel.Location = new System.Drawing.Point(12, 32);
            this.csvLabel.Name = "csvLabel";
            this.csvLabel.Size = new System.Drawing.Size(35, 13);
            this.csvLabel.TabIndex = 3;
            this.csvLabel.Text = "label1";
            // 
            // templateLabel
            // 
            this.templateLabel.AutoSize = true;
            this.templateLabel.Location = new System.Drawing.Point(12, 118);
            this.templateLabel.Name = "templateLabel";
            this.templateLabel.Size = new System.Drawing.Size(35, 13);
            this.templateLabel.TabIndex = 4;
            this.templateLabel.Text = "label1";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 292);
            this.ControlBox = false;
            this.Controls.Add(this.templateLabel);
            this.Controls.Add(this.csvLabel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.selectTemplate);
            this.Controls.Add(this.selectCSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectCSV;
        private System.Windows.Forms.Button selectTemplate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Ok;
        public System.Windows.Forms.Label csvLabel;
        public System.Windows.Forms.Label templateLabel;
    }
}