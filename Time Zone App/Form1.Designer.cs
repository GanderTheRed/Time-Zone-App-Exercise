namespace Time_Zone_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.promptLabel = new System.Windows.Forms.Label();
            this.lstCity = new System.Windows.Forms.ListBox();
            this.lblOutputDesc = new System.Windows.Forms.Label();
            this.lblTimeZoneOut = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(225, 24);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(277, 15);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Select a city, and I will display to you the time zone.";
            // 
            // lstCity
            // 
            this.lstCity.FormattingEnabled = true;
            this.lstCity.ItemHeight = 15;
            this.lstCity.Items.AddRange(new object[] {
            "Denver",
            "Honolulu",
            "Minneapolis",
            "New York",
            "San Francisco"});
            this.lstCity.Location = new System.Drawing.Point(225, 42);
            this.lstCity.Name = "lstCity";
            this.lstCity.Size = new System.Drawing.Size(297, 169);
            this.lstCity.TabIndex = 1;
            // 
            // lblOutputDesc
            // 
            this.lblOutputDesc.AutoSize = true;
            this.lblOutputDesc.Location = new System.Drawing.Point(225, 218);
            this.lblOutputDesc.Name = "lblOutputDesc";
            this.lblOutputDesc.Size = new System.Drawing.Size(66, 15);
            this.lblOutputDesc.TabIndex = 2;
            this.lblOutputDesc.Text = "Time Zone:";
            // 
            // lblTimeZoneOut
            // 
            this.lblTimeZoneOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeZoneOut.Location = new System.Drawing.Point(297, 214);
            this.lblTimeZoneOut.Name = "lblTimeZoneOut";
            this.lblTimeZoneOut.Size = new System.Drawing.Size(225, 23);
            this.lblTimeZoneOut.TabIndex = 3;
            this.lblTimeZoneOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(269, 265);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(392, 265);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTimeZoneOut);
            this.Controls.Add(this.lblOutputDesc);
            this.Controls.Add(this.lstCity);
            this.Controls.Add(this.promptLabel);
            this.Name = "Form1";
            this.Text = "Time Zone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label promptLabel;
        private ListBox lstCity;
        private Label lblOutputDesc;
        private Label lblTimeZoneOut;
        private Button btnOK;
        private Button btnExit;
    }
}