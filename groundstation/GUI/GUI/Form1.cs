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
using MersinSocketAsync;

namespace GUI
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        MersinSocketServer mServer;

        public Form1()
        {
            InitializeComponent();
            mServer = new MersinSocketServer();
        }

        public void log(string str)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Public\ROV\logs.txt", true))
            {
                file.WriteLine(str);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bismillah
            log("Application Started");
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Public\ROV\recv.txt", true))
            {
                //file.WriteLine("0000");
            }
            logTimer.Interval = 300;
            logTimer.Start();
            webBrowser1.Navigate("http://192.168.2.30:8080"); 
            webBrowser2.Navigate("http://192.168.2.120");
            Process qGround = Process.Start("C://Program Files (x86)//QGroundControl//QGroundControl.exe");
            recvTimer.Interval = 100;
            recvTimer.Start();
            timerModel.Interval = 200;
            timerModel.Start();
            mServer.StartListeningForIncomingConnection();
        }

        private void logTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                String lastLine = File.ReadLines(@"C:\Users\Public\ROV\logs.txt").Last();
                logLabel.Text = lastLine;
            }
            catch (Exception ekl)
            {
                logLabel.Text = ekl.ToString();
            }
        }

        public void progressLoad(byte a)
        {
            progressBar.Value = 0;
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(a);
                progressBar.Value++;
            }
        }

        private void btnLiftbagRelease_Click(object sender, EventArgs e)
        {
            log("Liftbag Released");
            releaseLiftbag();
            progressLoad(30);
        }

        public void releaseLiftbag()
        {
            try
            {
                mServer.SendTo("LiftbagiSalKanka");
            }
            catch (Exception ekl)
            {
                logLabel.Text = ekl.ToString();
            }
        }

        public void closeLiftbag()
        {
            try
            {
                mServer.SendTo("LiftbagiKapaKanka");
            }
            catch (Exception ekl)
            {
                logLabel.Text = ekl.ToString();
            }
        }

        private void btnOBSStart_Click(object sender, EventArgs e)
        {
            try
            {
                mServer.SendTo("OBSeBaglanKanka");
            }
            catch (Exception ekl)
            {
                logLabel.Text = ekl.ToString();
            }
        }

        private void btnDistance_Click(object sender, EventArgs e)
        {
            try
            {
                Process bengu = Process.Start("C://Users//Public//ROV//Distance//bengu.py");
                progressLoad(100);
                String lastLine = File.ReadLines(@"C:\Users\Public\ROV\Distance\result.txt").Last();
                log("Distance: " + lastLine);
                lblmeasuredDistance.Text = lastLine;
            }
            catch (Exception ekl)
            {
                logLabel.Text = ekl.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mServer.SendTo("Kill");
            mServer.StopServer();
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
                if(strings[i].Contains("/"))
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
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.H)
            {
                TabControlIPCams.SelectTab(0);
            }
            else if (e.KeyCode == Keys.J)
            {
                TabControlIPCams.SelectTab(1);
            }
        }

        private void btnLiftbagOFF_Click(object sender, EventArgs e)
        {
            closeLiftbag();
            log("Liftbag Closed");
            progressLoad(30);
        }

        private void recvTimer_Tick(object sender, EventArgs e)
        {
            String lastLine = File.ReadLines(@"C:\Users\Public\ROV\recv.txt").Last();
            if(lastLine != "0000")
            {
                log(lastLine);
            }

            if (lastLine.Contains("OBS"))
            {
                lblHTMLData.Text = lastLine;
                if (lastLine.Contains("DATA:"))
                {
                    try
                    {
                        string[] strs = lastLine.Split(',');
                        lblGyroValues.Text = strs[0].Split(':')[1].TrimEnd('D', 'A', 'T');
                        strs[0] = strs[0].Split(':')[2];
                        int[] nums = new int[16];
                        for (int i = 0; i < 16; i++)
                        {
                            nums[i] = Int32.Parse(strs[i]);
                        }
                        var series = new Series("Seismograph");
                        series.ChartType = SeriesChartType.Spline;
                        series.Points.DataBindXY(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, new[] { nums[0], nums[1], nums[2], nums[3], nums[4], nums[5], nums[6], nums[7], nums[8], nums[9], nums[10], nums[11], nums[12], nums[13], nums[14], nums[15] });
                        series.BorderWidth = 3;
                        OBSgraph.Series.Clear();
                        OBSgraph.Series.Add(series);

                        Label[] labels = new Label[] { data1, data2, data3, data4, data5, data6, data7, data8, data9, data10, data11, data12, data13, data14, data15, data16 };
                        for (int i = 0; i < labels.Length; i++)
                        {
                            labels[i].Text = nums[i].ToString();
                        }
                    }
                    catch (Exception ekl)
                    {
                        log(ekl.ToString());
                    }
                }
                else
                {
                    lblGyroValues.Text = lastLine.Split(':')[1];
                }
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

                A = Math.Pow(A / 2, 2) * Math.PI;
                double power = N * (0.5) * (Ro * A * (Math.Pow(V, 3)) * Cp);
                lblPower.Text = "Power: " + power.ToString("F2") + " Watt";
            }
            catch (Exception ekl)
            {
                logLabel.Text = ekl.ToString();
            }
        }

        private void timerModel_Tick(object sender, EventArgs e)
        {
            try
            {
                String lastLine = File.ReadLines(@"C:\Users\Public\ROV\OCR\model.txt").Last();
                //log("Aircraft Model: " + lastLine);
                lblAirCraftModel.Text = lastLine;
            }
            catch (Exception ekl)
            {
                logLabel.Text = ekl.ToString();
            }
        }

        public void sendTurnCommand(string direction, string turn) //Example: "Turner'Clock'0.5"
        {
            try
            {
                double value = Convert.ToDouble(lblDefaultPosition.Text);
                if (direction == "Clock")
                {
                    value = value + Convert.ToDouble(turn);
                    lblDefaultPosition.Text = value.ToString();
                    mServer.SendTo("Turner'" + direction + "'" + turn);
                }
                else if (direction == "Counter")
                {
                    value = value + 1 - Convert.ToDouble(turn);
                    lblDefaultPosition.Text = value.ToString();
                    mServer.SendTo("Turner'" + direction + "'" + turn);
                }
                else
                {
                    value = value - Convert.ToInt32(value);
                    mServer.SendTo("Turner'" + "Counter" + "'" + value.ToString());
                    value = 0.00;
                    lblDefaultPosition.Text = value.ToString();
                }
            }
            catch (Exception)
            {
                // who cares
            }
        }

        private void btnValve1CCW_Click(object sender, EventArgs e)
        {
            sendTurnCommand("Counter", "1");
        }

        private void btnValve1CW_Click(object sender, EventArgs e)
        {
            sendTurnCommand("Clock", "1");
        }

        private void btnValve05CCW_Click(object sender, EventArgs e)
        {
            sendTurnCommand("Counter", "0.5");
        }

        private void btnValve05CW_Click(object sender, EventArgs e)
        {
            sendTurnCommand("Clock", "0.5");
        }

        private void btnTurnLeft_Click(object sender, EventArgs e)
        {
            sendTurnCommand("Counter", txtTurnValue.Text);
        }

        private void btnTurnRight_Click(object sender, EventArgs e)
        {
            sendTurnCommand("Clock", txtTurnValue.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Default Position
            sendTurnCommand("None", "None");
        }

        private void valve3_CheckedChanged(object sender, EventArgs e)
        {
            valve3.Style = MetroFramework.MetroColorStyle.Green;
            valve3.CheckState = CheckState.Checked;
        }

        private void valve4_CheckedChanged(object sender, EventArgs e)
        {
            valve4.Style = MetroFramework.MetroColorStyle.Green;
            valve4.CheckState = CheckState.Checked;
        }

        private void valve2_CheckedChanged(object sender, EventArgs e)
        {
            valve2.Style = MetroFramework.MetroColorStyle.Green;
            valve2.CheckState = CheckState.Checked;
        }

        private void valve1_CheckedChanged(object sender, EventArgs e)
        {
            valve1.Style = MetroFramework.MetroColorStyle.Green;
            valve1.CheckState = CheckState.Checked;
        }
    }
}
