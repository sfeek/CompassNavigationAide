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
            this.btnWayPoint = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtMagDev = new System.Windows.Forms.TextBox();
            this.lblMagDev = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtLatDeg1 = new System.Windows.Forms.TextBox();
            this.txtLatMin1 = new System.Windows.Forms.TextBox();
            this.txtLatSec1 = new System.Windows.Forms.TextBox();
            this.txtLongSec1 = new System.Windows.Forms.TextBox();
            this.txtLongMin1 = new System.Windows.Forms.TextBox();
            this.txtLongDeg1 = new System.Windows.Forms.TextBox();
            this.lblLat1 = new System.Windows.Forms.Label();
            this.lblLong1 = new System.Windows.Forms.Label();
            this.lblLong2 = new System.Windows.Forms.Label();
            this.lblLat2 = new System.Windows.Forms.Label();
            this.txtLongSec2 = new System.Windows.Forms.TextBox();
            this.txtLongMin2 = new System.Windows.Forms.TextBox();
            this.txtLongDeg2 = new System.Windows.Forms.TextBox();
            this.txtLatSec2 = new System.Windows.Forms.TextBox();
            this.txtLatMin2 = new System.Windows.Forms.TextBox();
            this.txtLatDeg2 = new System.Windows.Forms.TextBox();
            this.lblDegMinSec = new System.Windows.Forms.Label();
            this.lblOR = new System.Windows.Forms.Label();
            this.lblOr2 = new System.Windows.Forms.Label();
            this.txtBearing = new System.Windows.Forms.TextBox();
            this.lblTrueBearing = new System.Windows.Forms.Label();
            this.txtPaces = new System.Windows.Forms.TextBox();
            this.lblPaces = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblAnd = new System.Windows.Forms.Label();
            this.gpbStart = new System.Windows.Forms.GroupBox();
            this.gpbDestination = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbStart.SuspendLayout();
            this.gpbDestination.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLatLong1
            // 
            this.txtLatLong1.Location = new System.Drawing.Point(474, 31);
            this.txtLatLong1.Name = "txtLatLong1";
            this.txtLatLong1.Size = new System.Drawing.Size(131, 20);
            this.txtLatLong1.TabIndex = 0;
            // 
            // lblLatLong1
            // 
            this.lblLatLong1.AutoSize = true;
            this.lblLatLong1.Location = new System.Drawing.Point(410, 34);
            this.lblLatLong1.Name = "lblLatLong1";
            this.lblLatLong1.Size = new System.Drawing.Size(58, 13);
            this.lblLatLong1.TabIndex = 1;
            this.lblLatLong1.Text = "Lat,Long 1";
            // 
            // txtLatLong2
            // 
            this.txtLatLong2.Location = new System.Drawing.Point(470, 37);
            this.txtLatLong2.Name = "txtLatLong2";
            this.txtLatLong2.Size = new System.Drawing.Size(131, 20);
            this.txtLatLong2.TabIndex = 0;
            // 
            // lblLatLong2
            // 
            this.lblLatLong2.AutoSize = true;
            this.lblLatLong2.Location = new System.Drawing.Point(406, 40);
            this.lblLatLong2.Name = "lblLatLong2";
            this.lblLatLong2.Size = new System.Drawing.Size(58, 13);
            this.lblLatLong2.TabIndex = 3;
            this.lblLatLong2.Text = "Lat,Long 2";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(16, 363);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(612, 203);
            this.txtOutput.TabIndex = 7;
            this.txtOutput.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(455, 327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtStepLength
            // 
            this.txtStepLength.Location = new System.Drawing.Point(92, 255);
            this.txtStepLength.Name = "txtStepLength";
            this.txtStepLength.Size = new System.Drawing.Size(61, 20);
            this.txtStepLength.TabIndex = 0;
            this.txtStepLength.TabStop = false;
            // 
            // lblStepLength
            // 
            this.lblStepLength.AutoSize = true;
            this.lblStepLength.Location = new System.Drawing.Point(13, 258);
            this.lblStepLength.Name = "lblStepLength";
            this.lblStepLength.Size = new System.Drawing.Size(68, 13);
            this.lblStepLength.TabIndex = 12;
            this.lblStepLength.Text = "Pace Length";
            // 
            // cmbUnits
            // 
            this.cmbUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnits.FormattingEnabled = true;
            this.cmbUnits.Items.AddRange(new object[] {
            "Feet",
            "Meters"});
            this.cmbUnits.Location = new System.Drawing.Point(463, 255);
            this.cmbUnits.Name = "cmbUnits";
            this.cmbUnits.Size = new System.Drawing.Size(86, 21);
            this.cmbUnits.TabIndex = 3;
            this.cmbUnits.TabStop = false;
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Location = new System.Drawing.Point(426, 258);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(31, 13);
            this.lblUnits.TabIndex = 11;
            this.lblUnits.Text = "Units";
            // 
            // btnWayPoint
            // 
            this.btnWayPoint.Location = new System.Drawing.Point(76, 327);
            this.btnWayPoint.Name = "btnWayPoint";
            this.btnWayPoint.Size = new System.Drawing.Size(222, 23);
            this.btnWayPoint.TabIndex = 1;
            this.btnWayPoint.Text = "Add Waypoint";
            this.btnWayPoint.UseVisualStyleBackColor = true;
            this.btnWayPoint.Click += new System.EventHandler(this.btnWayPoint_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(274, 572);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 23);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.TabStop = false;
            this.btnPrint.Text = "Print Waypoints";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtMagDev
            // 
            this.txtMagDev.Location = new System.Drawing.Point(304, 255);
            this.txtMagDev.Name = "txtMagDev";
            this.txtMagDev.Size = new System.Drawing.Size(54, 20);
            this.txtMagDev.TabIndex = 1;
            this.txtMagDev.TabStop = false;
            // 
            // lblMagDev
            // 
            this.lblMagDev.AutoSize = true;
            this.lblMagDev.Location = new System.Drawing.Point(211, 258);
            this.lblMagDev.Name = "lblMagDev";
            this.lblMagDev.Size = new System.Drawing.Size(87, 13);
            this.lblMagDev.TabIndex = 14;
            this.lblMagDev.Text = "Mag. Declination";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(92, 291);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(266, 20);
            this.txtComment.TabIndex = 0;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(13, 294);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(56, 13);
            this.lblComment.TabIndex = 10;
            this.lblComment.Text = "Comments";
            // 
            // txtLatDeg1
            // 
            this.txtLatDeg1.Location = new System.Drawing.Point(57, 31);
            this.txtLatDeg1.Name = "txtLatDeg1";
            this.txtLatDeg1.Size = new System.Drawing.Size(40, 20);
            this.txtLatDeg1.TabIndex = 1;
            // 
            // txtLatMin1
            // 
            this.txtLatMin1.Location = new System.Drawing.Point(103, 31);
            this.txtLatMin1.Name = "txtLatMin1";
            this.txtLatMin1.Size = new System.Drawing.Size(40, 20);
            this.txtLatMin1.TabIndex = 2;
            // 
            // txtLatSec1
            // 
            this.txtLatSec1.Location = new System.Drawing.Point(149, 31);
            this.txtLatSec1.Name = "txtLatSec1";
            this.txtLatSec1.Size = new System.Drawing.Size(40, 20);
            this.txtLatSec1.TabIndex = 3;
            // 
            // txtLongSec1
            // 
            this.txtLongSec1.Location = new System.Drawing.Point(329, 31);
            this.txtLongSec1.Name = "txtLongSec1";
            this.txtLongSec1.Size = new System.Drawing.Size(40, 20);
            this.txtLongSec1.TabIndex = 6;
            // 
            // txtLongMin1
            // 
            this.txtLongMin1.Location = new System.Drawing.Point(283, 31);
            this.txtLongMin1.Name = "txtLongMin1";
            this.txtLongMin1.Size = new System.Drawing.Size(40, 20);
            this.txtLongMin1.TabIndex = 5;
            // 
            // txtLongDeg1
            // 
            this.txtLongDeg1.Location = new System.Drawing.Point(237, 31);
            this.txtLongDeg1.Name = "txtLongDeg1";
            this.txtLongDeg1.Size = new System.Drawing.Size(40, 20);
            this.txtLongDeg1.TabIndex = 4;
            // 
            // lblLat1
            // 
            this.lblLat1.AutoSize = true;
            this.lblLat1.Location = new System.Drawing.Point(24, 34);
            this.lblLat1.Name = "lblLat1";
            this.lblLat1.Size = new System.Drawing.Size(31, 13);
            this.lblLat1.TabIndex = 21;
            this.lblLat1.Text = "Lat 1";
            // 
            // lblLong1
            // 
            this.lblLong1.AutoSize = true;
            this.lblLong1.Location = new System.Drawing.Point(196, 34);
            this.lblLong1.Name = "lblLong1";
            this.lblLong1.Size = new System.Drawing.Size(40, 13);
            this.lblLong1.TabIndex = 22;
            this.lblLong1.Text = "Long 1";
            // 
            // lblLong2
            // 
            this.lblLong2.AutoSize = true;
            this.lblLong2.Location = new System.Drawing.Point(192, 40);
            this.lblLong2.Name = "lblLong2";
            this.lblLong2.Size = new System.Drawing.Size(40, 13);
            this.lblLong2.TabIndex = 30;
            this.lblLong2.Text = "Long 2";
            // 
            // lblLat2
            // 
            this.lblLat2.AutoSize = true;
            this.lblLat2.Location = new System.Drawing.Point(20, 40);
            this.lblLat2.Name = "lblLat2";
            this.lblLat2.Size = new System.Drawing.Size(31, 13);
            this.lblLat2.TabIndex = 29;
            this.lblLat2.Text = "Lat 2";
            // 
            // txtLongSec2
            // 
            this.txtLongSec2.Location = new System.Drawing.Point(325, 37);
            this.txtLongSec2.Name = "txtLongSec2";
            this.txtLongSec2.Size = new System.Drawing.Size(40, 20);
            this.txtLongSec2.TabIndex = 6;
            // 
            // txtLongMin2
            // 
            this.txtLongMin2.Location = new System.Drawing.Point(279, 37);
            this.txtLongMin2.Name = "txtLongMin2";
            this.txtLongMin2.Size = new System.Drawing.Size(40, 20);
            this.txtLongMin2.TabIndex = 5;
            // 
            // txtLongDeg2
            // 
            this.txtLongDeg2.Location = new System.Drawing.Point(233, 37);
            this.txtLongDeg2.Name = "txtLongDeg2";
            this.txtLongDeg2.Size = new System.Drawing.Size(40, 20);
            this.txtLongDeg2.TabIndex = 4;
            // 
            // txtLatSec2
            // 
            this.txtLatSec2.Location = new System.Drawing.Point(145, 37);
            this.txtLatSec2.Name = "txtLatSec2";
            this.txtLatSec2.Size = new System.Drawing.Size(40, 20);
            this.txtLatSec2.TabIndex = 3;
            // 
            // txtLatMin2
            // 
            this.txtLatMin2.Location = new System.Drawing.Point(99, 37);
            this.txtLatMin2.Name = "txtLatMin2";
            this.txtLatMin2.Size = new System.Drawing.Size(40, 20);
            this.txtLatMin2.TabIndex = 2;
            // 
            // txtLatDeg2
            // 
            this.txtLatDeg2.Location = new System.Drawing.Point(53, 37);
            this.txtLatDeg2.Name = "txtLatDeg2";
            this.txtLatDeg2.Size = new System.Drawing.Size(40, 20);
            this.txtLatDeg2.TabIndex = 1;
            // 
            // lblDegMinSec
            // 
            this.lblDegMinSec.AutoSize = true;
            this.lblDegMinSec.Location = new System.Drawing.Point(54, 15);
            this.lblDegMinSec.Name = "lblDegMinSec";
            this.lblDegMinSec.Size = new System.Drawing.Size(302, 13);
            this.lblDegMinSec.TabIndex = 31;
            this.lblDegMinSec.Text = "Deg          Min          Sec                      Deg         Min          Sec";
            // 
            // lblOR
            // 
            this.lblOR.AutoSize = true;
            this.lblOR.Location = new System.Drawing.Point(374, 34);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(23, 13);
            this.lblOR.TabIndex = 32;
            this.lblOR.Text = "OR";
            // 
            // lblOr2
            // 
            this.lblOr2.AutoSize = true;
            this.lblOr2.Location = new System.Drawing.Point(192, 65);
            this.lblOr2.Name = "lblOr2";
            this.lblOr2.Size = new System.Drawing.Size(23, 13);
            this.lblOr2.TabIndex = 33;
            this.lblOr2.Text = "OR";
            // 
            // txtBearing
            // 
            this.txtBearing.Location = new System.Drawing.Point(99, 83);
            this.txtBearing.Name = "txtBearing";
            this.txtBearing.Size = new System.Drawing.Size(40, 20);
            this.txtBearing.TabIndex = 7;
            // 
            // lblTrueBearing
            // 
            this.lblTrueBearing.AutoSize = true;
            this.lblTrueBearing.Location = new System.Drawing.Point(25, 86);
            this.lblTrueBearing.Name = "lblTrueBearing";
            this.lblTrueBearing.Size = new System.Drawing.Size(68, 13);
            this.lblTrueBearing.TabIndex = 35;
            this.lblTrueBearing.Text = "True Bearing";
            // 
            // txtPaces
            // 
            this.txtPaces.Location = new System.Drawing.Point(233, 83);
            this.txtPaces.Name = "txtPaces";
            this.txtPaces.Size = new System.Drawing.Size(57, 20);
            this.txtPaces.TabIndex = 8;
            // 
            // lblPaces
            // 
            this.lblPaces.AutoSize = true;
            this.lblPaces.Location = new System.Drawing.Point(190, 86);
            this.lblPaces.Name = "lblPaces";
            this.lblPaces.Size = new System.Drawing.Size(37, 13);
            this.lblPaces.TabIndex = 37;
            this.lblPaces.Text = "Paces";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "OR";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(374, 83);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(61, 20);
            this.txtDistance.TabIndex = 9;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(319, 86);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(49, 13);
            this.lblDistance.TabIndex = 40;
            this.lblDistance.Text = "Distance";
            // 
            // lblAnd
            // 
            this.lblAnd.AutoSize = true;
            this.lblAnd.Location = new System.Drawing.Point(155, 86);
            this.lblAnd.Name = "lblAnd";
            this.lblAnd.Size = new System.Drawing.Size(30, 13);
            this.lblAnd.TabIndex = 41;
            this.lblAnd.Text = "AND";
            // 
            // gpbStart
            // 
            this.gpbStart.Controls.Add(this.txtLatLong1);
            this.gpbStart.Controls.Add(this.lblLatLong1);
            this.gpbStart.Controls.Add(this.lblOR);
            this.gpbStart.Controls.Add(this.txtLatDeg1);
            this.gpbStart.Controls.Add(this.txtLatMin1);
            this.gpbStart.Controls.Add(this.txtLatSec1);
            this.gpbStart.Controls.Add(this.txtLongDeg1);
            this.gpbStart.Controls.Add(this.txtLongMin1);
            this.gpbStart.Controls.Add(this.txtLongSec1);
            this.gpbStart.Controls.Add(this.lblLat1);
            this.gpbStart.Controls.Add(this.lblLong1);
            this.gpbStart.Controls.Add(this.lblDegMinSec);
            this.gpbStart.Location = new System.Drawing.Point(12, 13);
            this.gpbStart.Name = "gpbStart";
            this.gpbStart.Size = new System.Drawing.Size(616, 78);
            this.gpbStart.TabIndex = 0;
            this.gpbStart.TabStop = false;
            this.gpbStart.Text = "Starting Point";
            // 
            // gpbDestination
            // 
            this.gpbDestination.Controls.Add(this.label3);
            this.gpbDestination.Controls.Add(this.label2);
            this.gpbDestination.Controls.Add(this.txtPaces);
            this.gpbDestination.Controls.Add(this.txtLatLong2);
            this.gpbDestination.Controls.Add(this.lblAnd);
            this.gpbDestination.Controls.Add(this.lblLatLong2);
            this.gpbDestination.Controls.Add(this.lblDistance);
            this.gpbDestination.Controls.Add(this.txtLatDeg2);
            this.gpbDestination.Controls.Add(this.txtDistance);
            this.gpbDestination.Controls.Add(this.txtLatMin2);
            this.gpbDestination.Controls.Add(this.label1);
            this.gpbDestination.Controls.Add(this.txtLatSec2);
            this.gpbDestination.Controls.Add(this.lblPaces);
            this.gpbDestination.Controls.Add(this.txtLongDeg2);
            this.gpbDestination.Controls.Add(this.txtLongMin2);
            this.gpbDestination.Controls.Add(this.lblTrueBearing);
            this.gpbDestination.Controls.Add(this.txtLongSec2);
            this.gpbDestination.Controls.Add(this.txtBearing);
            this.gpbDestination.Controls.Add(this.lblLat2);
            this.gpbDestination.Controls.Add(this.lblOr2);
            this.gpbDestination.Controls.Add(this.lblLong2);
            this.gpbDestination.Location = new System.Drawing.Point(16, 101);
            this.gpbDestination.Name = "gpbDestination";
            this.gpbDestination.Size = new System.Drawing.Size(612, 132);
            this.gpbDestination.TabIndex = 1;
            this.gpbDestination.TabStop = false;
            this.gpbDestination.Text = "Ending Point";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "OR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Deg          Min          Sec                      Deg         Min          Sec";
            // 
            // CompassNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 610);
            this.Controls.Add(this.gpbDestination);
            this.Controls.Add(this.gpbStart);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblMagDev);
            this.Controls.Add(this.txtMagDev);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnWayPoint);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.cmbUnits);
            this.Controls.Add(this.lblStepLength);
            this.Controls.Add(this.txtStepLength);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CompassNavigation";
            this.Text = "Compass Navigation Aide v1.51";
            this.gpbStart.ResumeLayout(false);
            this.gpbStart.PerformLayout();
            this.gpbDestination.ResumeLayout(false);
            this.gpbDestination.PerformLayout();
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
        private System.Windows.Forms.Button btnWayPoint;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtMagDev;
        private System.Windows.Forms.Label lblMagDev;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtLatDeg1;
        private System.Windows.Forms.TextBox txtLatMin1;
        private System.Windows.Forms.TextBox txtLatSec1;
        private System.Windows.Forms.TextBox txtLongSec1;
        private System.Windows.Forms.TextBox txtLongMin1;
        private System.Windows.Forms.TextBox txtLongDeg1;
        private System.Windows.Forms.Label lblLat1;
        private System.Windows.Forms.Label lblLong1;
        private System.Windows.Forms.Label lblLong2;
        private System.Windows.Forms.Label lblLat2;
        private System.Windows.Forms.TextBox txtLongSec2;
        private System.Windows.Forms.TextBox txtLongMin2;
        private System.Windows.Forms.TextBox txtLongDeg2;
        private System.Windows.Forms.TextBox txtLatSec2;
        private System.Windows.Forms.TextBox txtLatMin2;
        private System.Windows.Forms.TextBox txtLatDeg2;
        private System.Windows.Forms.Label lblDegMinSec;
        private System.Windows.Forms.Label lblOR;
        private System.Windows.Forms.Label lblOr2;
        private System.Windows.Forms.TextBox txtBearing;
        private System.Windows.Forms.Label lblTrueBearing;
        private System.Windows.Forms.TextBox txtPaces;
        private System.Windows.Forms.Label lblPaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblAnd;
        private System.Windows.Forms.GroupBox gpbStart;
        private System.Windows.Forms.GroupBox gpbDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

