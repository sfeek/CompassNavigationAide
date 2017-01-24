namespace CompassNavigationAide
{
    partial class CompassNavigation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompassNavigation));
            this.txtLatLong1 = new System.Windows.Forms.TextBox();
            this.lblLatLong1 = new System.Windows.Forms.Label();
            this.txtLatLong2 = new System.Windows.Forms.TextBox();
            this.lblLatLong2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtStepLength = new System.Windows.Forms.TextBox();
            this.lblStepLength = new System.Windows.Forms.Label();
            this.cmbUnits = new System.Windows.Forms.ComboBox();
            this.lblUnits = new System.Windows.Forms.Label();
            this.bntWayPoint = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtMagDev = new System.Windows.Forms.TextBox();
            this.lblMagDev = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLatLong1
            // 
            this.txtLatLong1.Location = new System.Drawing.Point(91, 12);
            this.txtLatLong1.Name = "txtLatLong1";
            this.txtLatLong1.Size = new System.Drawing.Size(266, 20);
            this.txtLatLong1.TabIndex = 0;
            // 
            // lblLatLong1
            // 
            this.lblLatLong1.AutoSize = true;
            this.lblLatLong1.Location = new System.Drawing.Point(12, 15);
            this.lblLatLong1.Name = "lblLatLong1";
            this.lblLatLong1.Size = new System.Drawing.Size(65, 13);
            this.lblLatLong1.TabIndex = 1;
            this.lblLatLong1.Text = "Lat,Long #1";
            // 
            // txtLatLong2
            // 
            this.txtLatLong2.Location = new System.Drawing.Point(91, 38);
            this.txtLatLong2.Name = "txtLatLong2";
            this.txtLatLong2.Size = new System.Drawing.Size(266, 20);
            this.txtLatLong2.TabIndex = 1;
            // 
            // lblLatLong2
            // 
            this.lblLatLong2.AutoSize = true;
            this.lblLatLong2.Location = new System.Drawing.Point(12, 41);
            this.lblLatLong2.Name = "lblLatLong2";
            this.lblLatLong2.Size = new System.Drawing.Size(65, 13);
            this.lblLatLong2.TabIndex = 3;
            this.lblLatLong2.Text = "Lat,Long #2";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(15, 202);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(364, 203);
            this.txtOutput.TabIndex = 9;
            this.txtOutput.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(263, 159);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtStepLength
            // 
            this.txtStepLength.Location = new System.Drawing.Point(91, 64);
            this.txtStepLength.Name = "txtStepLength";
            this.txtStepLength.Size = new System.Drawing.Size(100, 20);
            this.txtStepLength.TabIndex = 2;
            // 
            // lblStepLength
            // 
            this.lblStepLength.AutoSize = true;
            this.lblStepLength.Location = new System.Drawing.Point(12, 67);
            this.lblStepLength.Name = "lblStepLength";
            this.lblStepLength.Size = new System.Drawing.Size(65, 13);
            this.lblStepLength.TabIndex = 12;
            this.lblStepLength.Text = "Step Length";
            // 
            // cmbUnits
            // 
            this.cmbUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnits.FormattingEnabled = true;
            this.cmbUnits.Items.AddRange(new object[] {
            "Feet",
            "Meters"});
            this.cmbUnits.Location = new System.Drawing.Point(91, 90);
            this.cmbUnits.Name = "cmbUnits";
            this.cmbUnits.Size = new System.Drawing.Size(86, 21);
            this.cmbUnits.TabIndex = 4;
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Location = new System.Drawing.Point(12, 93);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(31, 13);
            this.lblUnits.TabIndex = 11;
            this.lblUnits.Text = "Units";
            // 
            // bntWayPoint
            // 
            this.bntWayPoint.Location = new System.Drawing.Point(89, 159);
            this.bntWayPoint.Name = "bntWayPoint";
            this.bntWayPoint.Size = new System.Drawing.Size(102, 23);
            this.bntWayPoint.TabIndex = 6;
            this.bntWayPoint.Text = "Add Waypoint";
            this.bntWayPoint.UseVisualStyleBackColor = true;
            this.bntWayPoint.Click += new System.EventHandler(this.bntWayPoint_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(137, 420);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print Waypoints";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtMagDev
            // 
            this.txtMagDev.Location = new System.Drawing.Point(303, 64);
            this.txtMagDev.Name = "txtMagDev";
            this.txtMagDev.Size = new System.Drawing.Size(54, 20);
            this.txtMagDev.TabIndex = 3;
            // 
            // lblMagDev
            // 
            this.lblMagDev.AutoSize = true;
            this.lblMagDev.Location = new System.Drawing.Point(210, 67);
            this.lblMagDev.Name = "lblMagDev";
            this.lblMagDev.Size = new System.Drawing.Size(87, 13);
            this.lblMagDev.TabIndex = 14;
            this.lblMagDev.Text = "Mag. Declination";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(91, 117);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(266, 20);
            this.txtComment.TabIndex = 5;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(12, 120);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(56, 13);
            this.lblComment.TabIndex = 10;
            this.lblComment.Text = "Comments";
            // 
            // CompassNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 452);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblMagDev);
            this.Controls.Add(this.txtMagDev);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.bntWayPoint);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.cmbUnits);
            this.Controls.Add(this.lblStepLength);
            this.Controls.Add(this.txtStepLength);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblLatLong2);
            this.Controls.Add(this.txtLatLong2);
            this.Controls.Add(this.lblLatLong1);
            this.Controls.Add(this.txtLatLong1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CompassNavigation";
            this.Text = "Compass Navigation Aide v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLatLong1;
        private System.Windows.Forms.Label lblLatLong1;
        private System.Windows.Forms.TextBox txtLatLong2;
        private System.Windows.Forms.Label lblLatLong2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtStepLength;
        private System.Windows.Forms.Label lblStepLength;
        private System.Windows.Forms.ComboBox cmbUnits;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Button bntWayPoint;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtMagDev;
        private System.Windows.Forms.Label lblMagDev;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblComment;
    }
}

