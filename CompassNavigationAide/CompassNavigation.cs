using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompassNavigationAide
{
    public partial class CompassNavigation : Form
    {
        int waypoint=1;
        double totalDistance;

        public CompassNavigation()
        {
            InitializeComponent();

            txtMagDev.Text = "0";
            txtStepLength.Text = "2.5";
            cmbUnits.SelectedIndex = 0;
            totalDistance = 0.0;
        }

        // Clear the waypoints
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLatLong1.Text = String.Empty;
            txtLatLong2.Text = String.Empty;
            txtOutput.Text = String.Empty;
            txtComment.Text = String.Empty;
            waypoint = 1;
            totalDistance = 0.0;
        }

        // Calculate and Add a waypoint
        private void bntWayPoint_Click(object sender, EventArgs e)
        {
            double lat1; 
            double lat2; 
            double long1;
            double long2;
            double magDev;
            double paces;

            try
            {
                string[] latlong1 = txtLatLong1.Text.Split(',');
                string[] latlong2 = txtLatLong2.Text.Split(',');

                lat1 = Convert.ToDouble(latlong1[0]);
                lat2 = Convert.ToDouble(latlong2[0]);
                long1 = Convert.ToDouble(latlong1[1]);
                long2 = Convert.ToDouble(latlong2[1]);
                magDev = Convert.ToDouble(txtMagDev.Text);
                paces = Convert.ToDouble(txtStepLength.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Latitude and Longitude entries!");
                return;
            }

            double distance = CalculateDistance(lat1, long1, lat2, long2);
            totalDistance += distance;
            double bearing = CalculateBearing(lat1, long1, lat2, long2);

            txtOutput.AppendText("\r\n\r\n\r\n" + String.Format("******* Way Point {0} *******", waypoint));
            txtOutput.AppendText("\r\n" + txtLatLong1.Text + "  To  " + txtLatLong2.Text);

            txtOutput.AppendText("\r\n\r\nComments: " + txtComment.Text);

            if (cmbUnits.SelectedIndex == 0)
            {
                txtOutput.AppendText(String.Format("\r\nDistance: {0:0.0} Feet", distance * 3.28084));
                txtOutput.AppendText(String.Format(" / {0:0.000} Miles", distance * 3.28084 / 5280.0));
                txtOutput.AppendText(String.Format(" / {0:0} Paces", distance * 3.28084 / paces));
            }
            else
            {
                txtOutput.AppendText(String.Format("\r\n\r\nDistance: {0:0.0} Meters", distance));
                txtOutput.AppendText(String.Format(" / {0:0.000} Kilometers", distance / 1000.0));
                txtOutput.AppendText(String.Format(" / {0:0} Paces", distance / paces));
            }

            txtOutput.AppendText(String.Format("\r\nBearing:  True {0:0.0} Degrees / ", bearing ));
            txtOutput.AppendText(String.Format("Magnetic {0:0.0} Degrees", bearing + magDev));

            if (cmbUnits.SelectedIndex == 0)
            {
                txtOutput.AppendText(String.Format("\r\nAccumulated Distance: {0:0.0} Feet", totalDistance * 3.28084));
                txtOutput.AppendText(String.Format(" / {0:0.000} Miles", totalDistance * 3.28084 / 5280.0));
                txtOutput.AppendText(String.Format(" / {0:0} Paces", totalDistance * 3.28084 / paces));
            }
            else
            {
                txtOutput.AppendText(String.Format("\r\nAccumulated Distance: {0:0.0} Meters", totalDistance));
                txtOutput.AppendText(String.Format(" / {0:0.000} Kilometers", totalDistance / 1000.0));
                txtOutput.AppendText(String.Format(" / {0:0} Paces", totalDistance / paces));
            }

            txtLatLong1.Text = txtLatLong2.Text;
            txtLatLong2.Text = String.Empty;

            waypoint++;
            txtComment.Text = String.Empty;
        }

        // Print our stuff
        private void PrintDocumentOnPrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.txtOutput.Text, this.txtOutput.Font, Brushes.Black, 10, 25);
        }

        // Calculate the heading
        private double CalculateDistance (double latitude1, double longitude1, double latitude2, double longitude2)
        {
            double R = 6371e3;
            double lat1 = DegreeToRadian(latitude1);
            double lat2 = DegreeToRadian(latitude2);
            double deltaLat = DegreeToRadian(latitude2 - latitude1);
            double deltaLong = DegreeToRadian(longitude2 - longitude1);

            double a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Sin(deltaLong / 2) * Math.Sin(deltaLong / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double d = R * c;

            return d;
        }

        // Calculate bearing
        private double CalculateBearing(double latitude1, double longitude1, double latitude2, double longitude2)
        {
            double lat1 = DegreeToRadian(latitude1);
            double lat2 = DegreeToRadian(latitude2);
            double long1 = DegreeToRadian(longitude1);
            double long2 = DegreeToRadian(longitude2);

            double y = Math.Sin(long2 - long1) * Math.Cos(lat2);
            double x = Math.Cos(lat1) * Math.Sin(lat2) - Math.Sin(lat1) * Math.Cos(lat2) * Math.Cos(long2 - long1);

            double bearing = RadianToDegree(Math.Atan2(y, x));

            // Correct "wrap around" in necessary
            if (bearing < 0) bearing = 360.0 + bearing;
            if (bearing > 360.0) bearing = bearing - 360.0;

            return bearing;
        }

        // Convert Degrees to Radians
        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        // Convert Radians to Degrees
        private double RadianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }

        // Send waypoints to the printer
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocumentOnPrintPage;
            printDocument.Print();
        }
    }
}
