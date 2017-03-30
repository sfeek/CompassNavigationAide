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

            txtLatDeg1.Text = String.Empty;
            txtLatMin1.Text = String.Empty;
            txtLatSec1.Text = String.Empty;

            txtLongDeg1.Text = String.Empty;
            txtLongMin1.Text = String.Empty;
            txtLongSec1.Text = String.Empty;

            txtLatDeg2.Text = String.Empty;
            txtLatMin2.Text = String.Empty;
            txtLatSec2.Text = String.Empty;

            txtLongDeg2.Text = String.Empty;
            txtLongMin2.Text = String.Empty;
            txtLongSec2.Text = String.Empty;

            txtBearing.Text = String.Empty;
            txtDistance.Text = String.Empty;
            txtPaces.Text = String.Empty;
        }

        // Calculate and Add a waypoint
        private void btnWayPoint_Click(object sender, EventArgs e)
        {
            double lat1; 
            double lat2; 
            double long1;
            double long2;
            double magDev;
            double stepLength;
            double dmeters = 0, paces = 0;

            ConvertLatLong();


            try
            {
                string[] latlong1 = txtLatLong1.Text.Split(',');

                lat1 = Convert.ToDouble(latlong1[0]);
                long1 = Convert.ToDouble(latlong1[1]);

                if (txtBearing.Text != String.Empty)
                {
                    double bearing2 = DegreeToRadian(Convert.ToDouble(txtBearing.Text));

                    if (txtPaces.Text != String.Empty)
                    {
                        paces = Convert.ToDouble(txtPaces.Text);

                        txtDistance.Text = String.Format("{0:0.0}", paces * Convert.ToDouble(txtStepLength.Text));
                    }

                    if (cmbUnits.SelectedIndex == 0)
                    {
                        dmeters = Convert.ToDouble(txtDistance.Text) * 0.3048;
                    }
                    else
                    {
                        dmeters = Convert.ToDouble(txtDistance.Text);
                    }

                    lat2 = CalculateLatitude(lat1, long1, bearing2, dmeters);
                    long2 = CalculateLongitude(lat1, long1, lat2, bearing2, dmeters);

                    txtLatLong2.Text = String.Format("{0:0.000000},{1:0.000000}", lat2, long2);
                }
 
                string[] latlong2 = txtLatLong2.Text.Split(',');
                lat2 = Convert.ToDouble(latlong2[0]);
                long2 = Convert.ToDouble(latlong2[1]);

                magDev = Convert.ToDouble(txtMagDev.Text);
                stepLength = Convert.ToDouble(txtStepLength.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Latitude and Longitude entries!");
                return;
            }

            double distance = CalculateDistance(lat1, long1, lat2, long2);
            totalDistance += distance;
            double bearing = CalculateBearing(lat1, long1, lat2, long2);

            if (waypoint == 1)
            {
                txtOutput.AppendText(String.Format("\r\n Pace Length: {0:0.0} {1}",stepLength, cmbUnits.Text));
                txtOutput.AppendText(String.Format("\r\n Magnetic Deviation: {0:0.0} degrees", magDev));
            }

            txtOutput.AppendText("\r\n\r\n\r\n" + String.Format("******* Way Point {0} *******", waypoint));
            txtOutput.AppendText("\r\n" + txtLatLong1.Text + "  To  " + txtLatLong2.Text);

            txtOutput.AppendText("\r\n\r\nComments: " + txtComment.Text);

            if (cmbUnits.SelectedIndex == 0)
            {
                txtOutput.AppendText(String.Format("\r\nDistance: {0:0.0} Feet", distance * 3.28084));
                txtOutput.AppendText(String.Format(" / {0:0.000} Miles", distance * 3.28084 / 5280.0));
                txtOutput.AppendText(String.Format(" / {0:0} Paces", distance * 3.28084 / stepLength));
            }
            else
            {
                txtOutput.AppendText(String.Format("\r\n\r\nDistance: {0:0.0} Meters", distance));
                txtOutput.AppendText(String.Format(" / {0:0.000} Kilometers", distance / 1000.0));
                txtOutput.AppendText(String.Format(" / {0:0} Paces", distance / stepLength));
            }

            double magneticBearing = bearing + magDev;

            if (magneticBearing < 0) magneticBearing = 360.0 + magneticBearing;
            if (magneticBearing >= 360.0) magneticBearing = magneticBearing - 360.0;

            double reverseBearing = bearing + 180.0;

            if (reverseBearing < 0) reverseBearing = 360.0 + reverseBearing;
            if (reverseBearing >= 360.0) reverseBearing = reverseBearing - 360.0;

            double reverseBearingMagnetic = bearing + 180.0 + magDev;

            if (reverseBearingMagnetic < 0) reverseBearingMagnetic = 360.0 + reverseBearingMagnetic;
            if (reverseBearingMagnetic >= 360.0) reverseBearingMagnetic = reverseBearingMagnetic - 360.0;

            txtOutput.AppendText(String.Format("\r\nBearing:  True {0:0.0} Degrees / ", bearing ));
            txtOutput.AppendText(String.Format("Magnetic {0:0.0} Degrees", magneticBearing));

            txtOutput.AppendText(String.Format("\r\nReverse Bearing:  True {0:0.0} Degrees / ", reverseBearing));
            txtOutput.AppendText(String.Format("Magnetic {0:0.0} Degrees", reverseBearingMagnetic));

            if (cmbUnits.SelectedIndex == 0)
            {
                txtOutput.AppendText(String.Format("\r\nAccumulated Distance: {0:0.0} Feet", totalDistance * 3.28084));
                txtOutput.AppendText(String.Format(" / {0:0.000} Miles", totalDistance * 3.28084 / 5280.0));
                txtOutput.AppendText(String.Format(" / {0:0} Paces", totalDistance * 3.28084 / stepLength));
            }
            else
            {
                txtOutput.AppendText(String.Format("\r\nAccumulated Distance: {0:0.0} Meters", totalDistance));
                txtOutput.AppendText(String.Format(" / {0:0.000} Kilometers", totalDistance / 1000.0));
                txtOutput.AppendText(String.Format(" / {0:0} Paces", totalDistance / stepLength));
            }

            txtLatLong1.Text = txtLatLong2.Text;
            txtLatLong2.Text = String.Empty;

            txtLatDeg1.Text = txtLatDeg2.Text;
            txtLatMin1.Text = txtLatMin2.Text;
            txtLatSec1.Text = txtLatSec2.Text;

            txtLongDeg1.Text = txtLongDeg2.Text;
            txtLongMin1.Text = txtLongMin2.Text;
            txtLongSec1.Text = txtLongSec2.Text;


            txtLatDeg2.Text = String.Empty;
            txtLatMin2.Text = String.Empty;
            txtLatSec2.Text = String.Empty;

            txtLongDeg2.Text = String.Empty;
            txtLongMin2.Text = String.Empty;
            txtLongSec2.Text = String.Empty;

            txtBearing.Text = String.Empty;
            txtDistance.Text = String.Empty;
            txtPaces.Text = String.Empty;


            waypoint++;
            txtComment.Text = String.Empty;
        }

        // Print our stuff
        private void PrintDocumentOnPrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.txtOutput.Text, this.txtOutput.Font, Brushes.Black, 10, 25);
        }

        // Convert a DMS to Decimal Degrees
        private void ConvertLatLong()
        {
            double LatDeg1 = 0, LatMin1 = 0, LatSec1 = 0, LongDeg1 = 0, LongMin1 = 0, LongSec1 = 0;
            double LatDeg2 = 0, LatMin2 = 0, LatSec2 = 0, LongDeg2 = 0, LongMin2 = 0, LongSec2 = 0;
            double DecimalDegLat1 = 0, DecimalDegLong1 = 0, DecimalDegLat2 = 0, DecimalDegLong2 = 0;

            try
            {
                if (txtLatDeg1.Text != String.Empty)
                {
                    LatDeg1 = Convert.ToDouble(txtLatDeg1.Text);
                }
                if (txtLatMin1.Text != String.Empty)
                {
                    LatMin1 = Convert.ToDouble(txtLatMin1.Text);
                }
                if (txtLatSec1.Text != String.Empty)
                {
                    LatSec1 = Convert.ToDouble(txtLatSec1.Text);
                }
                if (txtLongDeg1.Text != String.Empty)
                {
                    LongDeg1 = Convert.ToDouble(txtLongDeg1.Text);
                }
                if (txtLongMin1.Text != String.Empty)
                {
                    LongMin1 = Convert.ToDouble(txtLongMin1.Text);
                }
                if (txtLongSec1.Text != String.Empty)
                {
                    LongSec1 = Convert.ToDouble(txtLongSec1.Text);
                }
                
                if (txtLatDeg2.Text != String.Empty)
                {
                    LatDeg2 = Convert.ToDouble(txtLatDeg2.Text);
                }
                if (txtLatMin2.Text != String.Empty)
                {
                    LatMin2 = Convert.ToDouble(txtLatMin2.Text);
                }
                if (txtLatSec2.Text != String.Empty)
                {
                    LatSec2 = Convert.ToDouble(txtLatSec2.Text);
                }
                if (txtLongDeg2.Text != String.Empty)
                {
                    LongDeg2 = Convert.ToDouble(txtLongDeg2.Text);
                }
                if (txtLongMin2.Text != String.Empty)
                {
                    LongMin2 = Convert.ToDouble(txtLongMin2.Text);
                }
                if (txtLongSec2.Text != String.Empty)
                {
                    LongSec2 = Convert.ToDouble(txtLongSec2.Text);
                }

                
                DecimalDegLat1 = Math.Abs(LatDeg1) + LatMin1 / 60.0 + LatSec1 / 3600.0;
                DecimalDegLat2 = Math.Abs(LatDeg2) + LatMin2 / 60.0 + LatSec2 / 3600.0;

                DecimalDegLong1 = Math.Abs(LongDeg1) + LongMin1 / 60.0 + LongSec1 / 3600.0;
                DecimalDegLong2 = Math.Abs(LongDeg2) + LongMin2 / 60.0 + LongSec2 / 3600.0;

                if (LatDeg1 < 0.0) DecimalDegLat1 = -DecimalDegLat1;
                if (LatDeg2 < 0.0) DecimalDegLat2 = -DecimalDegLat2;
                if (LongDeg1 < 0.0) DecimalDegLong1 = -DecimalDegLong1;
                if (LongDeg2 < 0.0) DecimalDegLong2 = -DecimalDegLong2;

                if (txtLatLong1.Text == String.Empty)
                {
                    txtLatLong1.Text = String.Format("{0:0.000000},{1:0.000000}", DecimalDegLat1, DecimalDegLong1);
                }

                if (txtLatLong2.Text == String.Empty)
                {
                    txtLatLong2.Text = String.Format("{0:0.000000},{1:0.000000}", DecimalDegLat2, DecimalDegLong2);
                }
            }
            catch { }
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

            // Correct "wrap around" as necessary
            if (bearing < 0) bearing = 360.0 + bearing;
            if (bearing > 360.0) bearing = bearing - 360.0;

            return bearing;
        }

        // Calculate Latitude
        private double CalculateLatitude(double latitude1, double longitude1, double bearing, double distance)
        {
            double R = 6371e3;
            double lat1 = DegreeToRadian(latitude1);
            double long1 = DegreeToRadian(longitude1);
            double lat2;

            lat2 = RadianToDegree(Math.Asin(Math.Sin(lat1) * Math.Cos(distance / R) + Math.Cos(lat1) * Math.Sin(distance / R) * Math.Cos(bearing)));

            return lat2;
        }

        // Calculate Longitude
        private double CalculateLongitude(double latitude1, double longitude1, double latitude2, double bearing, double distance)
        {
            double R = 6371e3;
            double lat1 = DegreeToRadian(latitude1);
            double lat2 = DegreeToRadian(latitude2);
            double long1 = DegreeToRadian(longitude1);
            double long2;

            long2 = long1 + Math.Atan2(Math.Sin(bearing) * Math.Sin(distance / R) * Math.Cos(lat1), Math.Cos(distance / R) - Math.Sin(lat1) * Math.Sin(lat2));

            long2 = (long2 + 540) % 360 - 180;

            long2 = RadianToDegree(long2);

            return long2;
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
            try
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += PrintDocumentOnPrintPage;
                printDocument.Print();
            }
            catch
            {
                MessageBox.Show("Error Printing or Printer not available!");
            }
        }
    }
}
