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
                file.WriteLine("0000");
            }
            logTimer.Interval = 300;
            logTimer.Start();
            webBrowser1.Navigate("http://192.168.2.30:8080"); 
            webBrowser2.Navigate("http://192.168.2.120");
            mServer.StartListeningForIncomingConnection();
        }

        private void logTimer_Tick(object sender, EventArgs e)
        {
            String lastLine = File.ReadLines(@"C:\Users\Public\ROV\logs.txt").Last();
            logLabel.Text = lastLine;
            if (lastLine.Contains("OBS"))
            {
                // Split string and catch array and start arraytochartandgraph() method
            }
            if (lastLine.Contains("Values"))
            {
                // Print X and Y values 
            }
            if (lastLine.Contains("Solution"))
            {
                //Print Task1
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
        byte liftbagcount = 0;

        private void btnLiftbagRelease_Click(object sender, EventArgs e)
        {
            progressLoad(3);
            liftbagcount++;
            if(liftbagcount < 2)
            {
                log("Liftbag Released");
                releaseLiftbag();
            }
            else
            {
                btnLiftbagRelease.Enabled = false;
            }
        }

        public void releaseLiftbag()
        {
            mServer.SendTo("LiftbagiSalKanka");
        }

        private void btnOBSStart_Click(object sender, EventArgs e)
        {
            mServer.SendTo("OBSeBaglanKanka");
        }

        private void btnDistance_Click(object sender, EventArgs e)
        {
            Process ocr = new Process();
            ocr.StartInfo.FileName = @"C:\Users\Public\ROV\Distance\bengu.py";
            ocr.Start();
            progressLoad(70);
            String lastLine = File.ReadLines(@"C:\Users\Public\ROV\Distance\result.txt").Last();
            log("Distance: " + lastLine);
            lblmeasuredDistance.Text = lastLine;
        }

        private void btnImageProcessing_Click(object sender, EventArgs e)
        {
            Process ocr = new Process();
            ocr.StartInfo.FileName = @"C:\Users\Public\ROV\OCR\atahan.py";
            ocr.Start();
            progressLoad(50);
            String lastLine = File.ReadLines(@"C:\Users\Public\ROV\OCR\model.txt").Last();
            log("Aircraft Model: " + lastLine);
            lblAirCraftModel.Text = lastLine;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mServer.StopServer();
        }

        private void btnIntegrate_Click(object sender, EventArgs e)
        {
            string[] array = new string[] { txttakeof.Text, txtascent.Text, txtfailure.Text, txtairspeed.Text, txtdescent.Text, txtwindangle.Text, txtEquation.Text };

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Public\ROV\Task1\task1.txt", true))
            {
                for (int i = 0; i < 7; i++)
                {
                    file.Write(array[i]);
                    file.Write(" ");
                }
            }
        }
    }
}
