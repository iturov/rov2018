using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double Integration(double t1, double t2, double a = 0, double b = 0, double c = 0, double d = 0)
        {
            double sum = 0;
            while (t1 <= t2)
            {
                double value = a * Math.Pow(t1, 3) + b * Math.Pow(t1, 2) + c * t1 + d;
                double small_area = 0.001 * value;
                sum += small_area;
                t1 += 0.001;
            }
            return sum;
        }
        private void btnIntegrate_Click(object sender, EventArgs e)
        {
            try
            {
                double heading_angle = double.Parse(txttakeof.Text);
                double airspeed_when_up = double.Parse(txtairspeedAs.Text);
                double z_up = double.Parse(txtascent.Text);
                double working_time = double.Parse(txtfailure.Text);
                double airspeed_down = double.Parse(txtairspeedDes.Text);
                double z_down = double.Parse(txtdescent.Text);
                double wind_angle = double.Parse(txtwindangle.Text);
                string equation = txtEquation.Text;
                string[] strings = equation.Split(',');
                double[] constants = new double[4];
                for (int i = 0; i < strings.Length; i++)
                {
                    if (strings[i].Contains("/"))
                    {
                        string[] nums = strings[i].Split('/');
                        constants[i] = Int32.Parse(nums[0]) / Int32.Parse(nums[1]);
                    }
                    else
                    {
                        constants[i] = double.Parse(strings[i]);
                    }
                }

                wind_angle += 180;
                wind_angle = wind_angle % 360;
                double altitude = working_time * z_up;
                double tfall = altitude / z_down;
                double t_sum_of_flight = tfall + working_time;

                double wind_displacement = Integration(working_time, t_sum_of_flight, constants[0], constants[1], constants[2], constants[3]);
                double wind_x = Math.Cos(wind_angle * 2 * Math.PI / 360) * wind_displacement;
                double wind_y = Math.Sin(wind_angle * 2 * Math.PI / 360) * wind_displacement;
                double ascentpositionx = Math.Cos(heading_angle * 2 * Math.PI / 360) * airspeed_when_up * working_time;
                double ascentpositiony = Math.Sin(heading_angle * 2 * Math.PI / 360) * airspeed_when_up * working_time;
                double descent_position_x = Math.Cos(heading_angle * 2 * Math.PI / 360) * airspeed_down * tfall;
                double descent_position_y = Math.Sin(heading_angle * 2 * Math.PI / 360) * airspeed_down * tfall;
                double radian = Math.Atan2(ascentpositiony + descent_position_y + wind_y, ascentpositionx + descent_position_x + wind_x);
                double angle = radian * (180 / Math.PI);

                double square = Math.Pow(ascentpositionx + descent_position_x + wind_x, 2) + Math.Pow(ascentpositiony + descent_position_y + wind_y, 2);
                double output = Math.Pow(square, 0.5);
                lblaircraftDistance.Text = "Distance: " + output.ToString("F2");
                lblaircraftAngle.Text = "Angle: " + angle.ToString("F2");
            }
            catch
            {
                // who cares
            }
            
        }
        
        private void btntask3_Click(object sender, EventArgs e)
        {
            try
            {
                double N = double.Parse(txtN.Text);
                double Ro = double.Parse(txtRo.Text);
                double A = double.Parse(txtA.Text);
                double V = double.Parse(txtV.Text);
                double Cp = double.Parse(txtCp.Text);

                double power = N * (0.5) * (Ro * A * (Math.Pow(V, 3)) * Cp);
                lblPower.Text = "Power: " + power.ToString("F2") + " Watt";
            }
            catch
            {
                // who cares
            }
        }
    }
}
