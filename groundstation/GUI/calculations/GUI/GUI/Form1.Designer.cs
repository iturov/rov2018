namespace GUI
{
    partial class Form1
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
            this.windSpeedPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel29 = new MetroFramework.Controls.MetroLabel();
            this.btnIntegrate = new System.Windows.Forms.Button();
            this.txtEquation = new MetroFramework.Controls.MetroTextBox();
            this.lblaircraftAngle = new MetroFramework.Controls.MetroLabel();
            this.lblaircraftDistance = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtairspeedAs = new MetroFramework.Controls.MetroTextBox();
            this.txtwindangle = new MetroFramework.Controls.MetroTextBox();
            this.txtairspeedDes = new MetroFramework.Controls.MetroTextBox();
            this.txtdescent = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtfailure = new MetroFramework.Controls.MetroTextBox();
            this.txttakeof = new MetroFramework.Controls.MetroTextBox();
            this.txtascent = new MetroFramework.Controls.MetroTextBox();
            this.lblwindSpeedPanel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel28 = new MetroFramework.Controls.MetroLabel();
            this.tidalTurbinePanel = new MetroFramework.Controls.MetroPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPower = new MetroFramework.Controls.MetroLabel();
            this.btntask3 = new MetroFramework.Controls.MetroButton();
            this.txtCp = new MetroFramework.Controls.MetroTextBox();
            this.txtV = new MetroFramework.Controls.MetroTextBox();
            this.txtA = new MetroFramework.Controls.MetroTextBox();
            this.txtRo = new MetroFramework.Controls.MetroTextBox();
            this.txtN = new MetroFramework.Controls.MetroTextBox();
            this.windSpeedPanel.SuspendLayout();
            this.tidalTurbinePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // windSpeedPanel
            // 
            this.windSpeedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.windSpeedPanel.Controls.Add(this.metroLabel29);
            this.windSpeedPanel.Controls.Add(this.btnIntegrate);
            this.windSpeedPanel.Controls.Add(this.txtEquation);
            this.windSpeedPanel.Controls.Add(this.lblaircraftAngle);
            this.windSpeedPanel.Controls.Add(this.lblaircraftDistance);
            this.windSpeedPanel.Controls.Add(this.metroLabel6);
            this.windSpeedPanel.Controls.Add(this.metroLabel4);
            this.windSpeedPanel.Controls.Add(this.metroLabel2);
            this.windSpeedPanel.Controls.Add(this.txtairspeedAs);
            this.windSpeedPanel.Controls.Add(this.txtwindangle);
            this.windSpeedPanel.Controls.Add(this.txtairspeedDes);
            this.windSpeedPanel.Controls.Add(this.txtdescent);
            this.windSpeedPanel.Controls.Add(this.metroLabel5);
            this.windSpeedPanel.Controls.Add(this.metroLabel3);
            this.windSpeedPanel.Controls.Add(this.metroLabel1);
            this.windSpeedPanel.Controls.Add(this.txtfailure);
            this.windSpeedPanel.Controls.Add(this.txttakeof);
            this.windSpeedPanel.Controls.Add(this.txtascent);
            this.windSpeedPanel.HorizontalScrollbarBarColor = true;
            this.windSpeedPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.windSpeedPanel.HorizontalScrollbarSize = 10;
            this.windSpeedPanel.Location = new System.Drawing.Point(23, 42);
            this.windSpeedPanel.Name = "windSpeedPanel";
            this.windSpeedPanel.Size = new System.Drawing.Size(235, 294);
            this.windSpeedPanel.Style = MetroFramework.MetroColorStyle.Blue;
            this.windSpeedPanel.TabIndex = 1;
            this.windSpeedPanel.VerticalScrollbarBarColor = true;
            this.windSpeedPanel.VerticalScrollbarHighlightOnWheel = false;
            this.windSpeedPanel.VerticalScrollbarSize = 10;
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.Location = new System.Drawing.Point(16, 39);
            this.metroLabel29.Name = "metroLabel29";
            this.metroLabel29.Size = new System.Drawing.Size(106, 19);
            this.metroLabel29.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel29.TabIndex = 8;
            this.metroLabel29.Text = "Airspeed Ascent:";
            // 
            // btnIntegrate
            // 
            this.btnIntegrate.Location = new System.Drawing.Point(24, 213);
            this.btnIntegrate.Name = "btnIntegrate";
            this.btnIntegrate.Size = new System.Drawing.Size(94, 23);
            this.btnIntegrate.TabIndex = 8;
            this.btnIntegrate.Text = "Calculate";
            this.btnIntegrate.UseVisualStyleBackColor = true;
            this.btnIntegrate.Click += new System.EventHandler(this.btnIntegrate_Click);
            // 
            // txtEquation
            // 
            // 
            // 
            // 
            this.txtEquation.CustomButton.Image = null;
            this.txtEquation.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.txtEquation.CustomButton.Name = "";
            this.txtEquation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEquation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEquation.CustomButton.TabIndex = 1;
            this.txtEquation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEquation.CustomButton.UseSelectable = true;
            this.txtEquation.CustomButton.Visible = false;
            this.txtEquation.Lines = new string[] {
        "0,0,0,0"};
            this.txtEquation.Location = new System.Drawing.Point(128, 213);
            this.txtEquation.MaxLength = 32767;
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.PasswordChar = '\0';
            this.txtEquation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEquation.SelectedText = "";
            this.txtEquation.SelectionLength = 0;
            this.txtEquation.SelectionStart = 0;
            this.txtEquation.ShortcutsEnabled = true;
            this.txtEquation.Size = new System.Drawing.Size(80, 23);
            this.txtEquation.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEquation.TabIndex = 7;
            this.txtEquation.Text = "0,0,0,0";
            this.txtEquation.UseSelectable = true;
            this.txtEquation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEquation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblaircraftAngle
            // 
            this.lblaircraftAngle.AutoSize = true;
            this.lblaircraftAngle.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblaircraftAngle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblaircraftAngle.Location = new System.Drawing.Point(128, 253);
            this.lblaircraftAngle.Name = "lblaircraftAngle";
            this.lblaircraftAngle.Size = new System.Drawing.Size(42, 15);
            this.lblaircraftAngle.TabIndex = 6;
            this.lblaircraftAngle.Text = "Angle:";
            // 
            // lblaircraftDistance
            // 
            this.lblaircraftDistance.AutoSize = true;
            this.lblaircraftDistance.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblaircraftDistance.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblaircraftDistance.Location = new System.Drawing.Point(24, 253);
            this.lblaircraftDistance.Name = "lblaircraftDistance";
            this.lblaircraftDistance.Size = new System.Drawing.Size(58, 15);
            this.lblaircraftDistance.TabIndex = 6;
            this.lblaircraftDistance.Text = "Distance:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(41, 186);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(81, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "Wind Angle:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(8, 128);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(113, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Airspeed Descent:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(35, 157);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Descent Rate:";
            // 
            // txtairspeedAs
            // 
            // 
            // 
            // 
            this.txtairspeedAs.CustomButton.Image = null;
            this.txtairspeedAs.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.txtairspeedAs.CustomButton.Name = "";
            this.txtairspeedAs.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtairspeedAs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtairspeedAs.CustomButton.TabIndex = 1;
            this.txtairspeedAs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtairspeedAs.CustomButton.UseSelectable = true;
            this.txtairspeedAs.CustomButton.Visible = false;
            this.txtairspeedAs.Lines = new string[] {
        "0"};
            this.txtairspeedAs.Location = new System.Drawing.Point(128, 37);
            this.txtairspeedAs.MaxLength = 32767;
            this.txtairspeedAs.Name = "txtairspeedAs";
            this.txtairspeedAs.PasswordChar = '\0';
            this.txtairspeedAs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtairspeedAs.SelectedText = "";
            this.txtairspeedAs.SelectionLength = 0;
            this.txtairspeedAs.SelectionStart = 0;
            this.txtairspeedAs.ShortcutsEnabled = true;
            this.txtairspeedAs.Size = new System.Drawing.Size(80, 23);
            this.txtairspeedAs.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtairspeedAs.TabIndex = 1;
            this.txtairspeedAs.Text = "0";
            this.txtairspeedAs.UseSelectable = true;
            this.txtairspeedAs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtairspeedAs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtwindangle
            // 
            // 
            // 
            // 
            this.txtwindangle.CustomButton.Image = null;
            this.txtwindangle.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.txtwindangle.CustomButton.Name = "";
            this.txtwindangle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtwindangle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtwindangle.CustomButton.TabIndex = 1;
            this.txtwindangle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtwindangle.CustomButton.UseSelectable = true;
            this.txtwindangle.CustomButton.Visible = false;
            this.txtwindangle.Lines = new string[] {
        "0"};
            this.txtwindangle.Location = new System.Drawing.Point(128, 184);
            this.txtwindangle.MaxLength = 32767;
            this.txtwindangle.Name = "txtwindangle";
            this.txtwindangle.PasswordChar = '\0';
            this.txtwindangle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtwindangle.SelectedText = "";
            this.txtwindangle.SelectionLength = 0;
            this.txtwindangle.SelectionStart = 0;
            this.txtwindangle.ShortcutsEnabled = true;
            this.txtwindangle.Size = new System.Drawing.Size(80, 23);
            this.txtwindangle.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtwindangle.TabIndex = 6;
            this.txtwindangle.Text = "0";
            this.txtwindangle.UseSelectable = true;
            this.txtwindangle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtwindangle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtairspeedDes
            // 
            // 
            // 
            // 
            this.txtairspeedDes.CustomButton.Image = null;
            this.txtairspeedDes.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.txtairspeedDes.CustomButton.Name = "";
            this.txtairspeedDes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtairspeedDes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtairspeedDes.CustomButton.TabIndex = 1;
            this.txtairspeedDes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtairspeedDes.CustomButton.UseSelectable = true;
            this.txtairspeedDes.CustomButton.Visible = false;
            this.txtairspeedDes.Lines = new string[] {
        "0"};
            this.txtairspeedDes.Location = new System.Drawing.Point(128, 126);
            this.txtairspeedDes.MaxLength = 32767;
            this.txtairspeedDes.Name = "txtairspeedDes";
            this.txtairspeedDes.PasswordChar = '\0';
            this.txtairspeedDes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtairspeedDes.SelectedText = "";
            this.txtairspeedDes.SelectionLength = 0;
            this.txtairspeedDes.SelectionStart = 0;
            this.txtairspeedDes.ShortcutsEnabled = true;
            this.txtairspeedDes.Size = new System.Drawing.Size(80, 23);
            this.txtairspeedDes.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtairspeedDes.TabIndex = 4;
            this.txtairspeedDes.Text = "0";
            this.txtairspeedDes.UseSelectable = true;
            this.txtairspeedDes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtairspeedDes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtdescent
            // 
            // 
            // 
            // 
            this.txtdescent.CustomButton.Image = null;
            this.txtdescent.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.txtdescent.CustomButton.Name = "";
            this.txtdescent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtdescent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtdescent.CustomButton.TabIndex = 1;
            this.txtdescent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtdescent.CustomButton.UseSelectable = true;
            this.txtdescent.CustomButton.Visible = false;
            this.txtdescent.Lines = new string[] {
        "0"};
            this.txtdescent.Location = new System.Drawing.Point(128, 155);
            this.txtdescent.MaxLength = 32767;
            this.txtdescent.Name = "txtdescent";
            this.txtdescent.PasswordChar = '\0';
            this.txtdescent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtdescent.SelectedText = "";
            this.txtdescent.SelectionLength = 0;
            this.txtdescent.SelectionStart = 0;
            this.txtdescent.ShortcutsEnabled = true;
            this.txtdescent.Size = new System.Drawing.Size(80, 23);
            this.txtdescent.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtdescent.TabIndex = 5;
            this.txtdescent.Text = "0";
            this.txtdescent.UseSelectable = true;
            this.txtdescent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtdescent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(39, 97);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(83, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Failure Time:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(16, 10);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(106, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Takeoff Heading:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(42, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Ascent Rate:";
            // 
            // txtfailure
            // 
            // 
            // 
            // 
            this.txtfailure.CustomButton.Image = null;
            this.txtfailure.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.txtfailure.CustomButton.Name = "";
            this.txtfailure.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtfailure.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtfailure.CustomButton.TabIndex = 1;
            this.txtfailure.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtfailure.CustomButton.UseSelectable = true;
            this.txtfailure.CustomButton.Visible = false;
            this.txtfailure.Lines = new string[] {
        "0"};
            this.txtfailure.Location = new System.Drawing.Point(128, 95);
            this.txtfailure.MaxLength = 32767;
            this.txtfailure.Name = "txtfailure";
            this.txtfailure.PasswordChar = '\0';
            this.txtfailure.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtfailure.SelectedText = "";
            this.txtfailure.SelectionLength = 0;
            this.txtfailure.SelectionStart = 0;
            this.txtfailure.ShortcutsEnabled = true;
            this.txtfailure.Size = new System.Drawing.Size(80, 23);
            this.txtfailure.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtfailure.TabIndex = 3;
            this.txtfailure.Text = "0";
            this.txtfailure.UseSelectable = true;
            this.txtfailure.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtfailure.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txttakeof
            // 
            // 
            // 
            // 
            this.txttakeof.CustomButton.Image = null;
            this.txttakeof.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.txttakeof.CustomButton.Name = "";
            this.txttakeof.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txttakeof.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttakeof.CustomButton.TabIndex = 1;
            this.txttakeof.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txttakeof.CustomButton.UseSelectable = true;
            this.txttakeof.CustomButton.Visible = false;
            this.txttakeof.Lines = new string[] {
        "0"};
            this.txttakeof.Location = new System.Drawing.Point(128, 8);
            this.txttakeof.MaxLength = 32767;
            this.txttakeof.Name = "txttakeof";
            this.txttakeof.PasswordChar = '\0';
            this.txttakeof.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttakeof.SelectedText = "";
            this.txttakeof.SelectionLength = 0;
            this.txttakeof.SelectionStart = 0;
            this.txttakeof.ShortcutsEnabled = true;
            this.txttakeof.Size = new System.Drawing.Size(80, 23);
            this.txttakeof.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttakeof.TabIndex = 0;
            this.txttakeof.Text = "0";
            this.txttakeof.UseSelectable = true;
            this.txttakeof.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txttakeof.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtascent
            // 
            // 
            // 
            // 
            this.txtascent.CustomButton.Image = null;
            this.txtascent.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.txtascent.CustomButton.Name = "";
            this.txtascent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtascent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtascent.CustomButton.TabIndex = 1;
            this.txtascent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtascent.CustomButton.UseSelectable = true;
            this.txtascent.CustomButton.Visible = false;
            this.txtascent.Lines = new string[] {
        "0"};
            this.txtascent.Location = new System.Drawing.Point(128, 66);
            this.txtascent.MaxLength = 32767;
            this.txtascent.Name = "txtascent";
            this.txtascent.PasswordChar = '\0';
            this.txtascent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtascent.SelectedText = "";
            this.txtascent.SelectionLength = 0;
            this.txtascent.SelectionStart = 0;
            this.txtascent.ShortcutsEnabled = true;
            this.txtascent.Size = new System.Drawing.Size(80, 23);
            this.txtascent.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtascent.TabIndex = 2;
            this.txtascent.Text = "0";
            this.txtascent.UseSelectable = true;
            this.txtascent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtascent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblwindSpeedPanel
            // 
            this.lblwindSpeedPanel.AutoSize = true;
            this.lblwindSpeedPanel.Location = new System.Drawing.Point(23, 20);
            this.lblwindSpeedPanel.Name = "lblwindSpeedPanel";
            this.lblwindSpeedPanel.Size = new System.Drawing.Size(146, 19);
            this.lblwindSpeedPanel.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblwindSpeedPanel.TabIndex = 2;
            this.lblwindSpeedPanel.Text = "Wreckage Search Area:";
            this.lblwindSpeedPanel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel28
            // 
            this.metroLabel28.AutoSize = true;
            this.metroLabel28.Location = new System.Drawing.Point(264, 20);
            this.metroLabel28.Name = "metroLabel28";
            this.metroLabel28.Size = new System.Drawing.Size(139, 19);
            this.metroLabel28.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel28.TabIndex = 2;
            this.metroLabel28.Text = "Tidal Turbine Location:";
            this.metroLabel28.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tidalTurbinePanel
            // 
            this.tidalTurbinePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tidalTurbinePanel.Controls.Add(this.label5);
            this.tidalTurbinePanel.Controls.Add(this.label4);
            this.tidalTurbinePanel.Controls.Add(this.label3);
            this.tidalTurbinePanel.Controls.Add(this.label2);
            this.tidalTurbinePanel.Controls.Add(this.label1);
            this.tidalTurbinePanel.Controls.Add(this.lblPower);
            this.tidalTurbinePanel.Controls.Add(this.btntask3);
            this.tidalTurbinePanel.Controls.Add(this.txtCp);
            this.tidalTurbinePanel.Controls.Add(this.txtV);
            this.tidalTurbinePanel.Controls.Add(this.txtA);
            this.tidalTurbinePanel.Controls.Add(this.txtRo);
            this.tidalTurbinePanel.Controls.Add(this.txtN);
            this.tidalTurbinePanel.HorizontalScrollbarBarColor = true;
            this.tidalTurbinePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.tidalTurbinePanel.HorizontalScrollbarSize = 10;
            this.tidalTurbinePanel.Location = new System.Drawing.Point(264, 42);
            this.tidalTurbinePanel.Name = "tidalTurbinePanel";
            this.tidalTurbinePanel.Size = new System.Drawing.Size(473, 110);
            this.tidalTurbinePanel.TabIndex = 11;
            this.tidalTurbinePanel.VerticalScrollbarBarColor = true;
            this.tidalTurbinePanel.VerticalScrollbarHighlightOnWheel = false;
            this.tidalTurbinePanel.VerticalScrollbarSize = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "V:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "R:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ρ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "N:";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(149, 68);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(53, 19);
            this.lblPower.TabIndex = 8;
            this.lblPower.Text = "Power: ";
            // 
            // btntask3
            // 
            this.btntask3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btntask3.ForeColor = System.Drawing.Color.Coral;
            this.btntask3.Location = new System.Drawing.Point(15, 66);
            this.btntask3.Name = "btntask3";
            this.btntask3.Size = new System.Drawing.Size(100, 35);
            this.btntask3.TabIndex = 14;
            this.btntask3.Text = "Calculate";
            this.btntask3.UseSelectable = true;
            this.btntask3.Click += new System.EventHandler(this.btntask3_Click);
            // 
            // txtCp
            // 
            // 
            // 
            // 
            this.txtCp.CustomButton.Image = null;
            this.txtCp.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.txtCp.CustomButton.Name = "";
            this.txtCp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCp.CustomButton.TabIndex = 1;
            this.txtCp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCp.CustomButton.UseSelectable = true;
            this.txtCp.CustomButton.Visible = false;
            this.txtCp.Lines = new string[0];
            this.txtCp.Location = new System.Drawing.Point(382, 15);
            this.txtCp.MaxLength = 32767;
            this.txtCp.Name = "txtCp";
            this.txtCp.PasswordChar = '\0';
            this.txtCp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCp.SelectedText = "";
            this.txtCp.SelectionLength = 0;
            this.txtCp.SelectionStart = 0;
            this.txtCp.ShortcutsEnabled = true;
            this.txtCp.Size = new System.Drawing.Size(40, 23);
            this.txtCp.TabIndex = 13;
            this.txtCp.UseSelectable = true;
            this.txtCp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtV
            // 
            // 
            // 
            // 
            this.txtV.CustomButton.Image = null;
            this.txtV.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.txtV.CustomButton.Name = "";
            this.txtV.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtV.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtV.CustomButton.TabIndex = 1;
            this.txtV.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtV.CustomButton.UseSelectable = true;
            this.txtV.CustomButton.Visible = false;
            this.txtV.Lines = new string[0];
            this.txtV.Location = new System.Drawing.Point(299, 14);
            this.txtV.MaxLength = 32767;
            this.txtV.Name = "txtV";
            this.txtV.PasswordChar = '\0';
            this.txtV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtV.SelectedText = "";
            this.txtV.SelectionLength = 0;
            this.txtV.SelectionStart = 0;
            this.txtV.ShortcutsEnabled = true;
            this.txtV.Size = new System.Drawing.Size(40, 23);
            this.txtV.TabIndex = 12;
            this.txtV.UseSelectable = true;
            this.txtV.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtV.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtA
            // 
            // 
            // 
            // 
            this.txtA.CustomButton.Image = null;
            this.txtA.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.txtA.CustomButton.Name = "";
            this.txtA.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtA.CustomButton.TabIndex = 1;
            this.txtA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtA.CustomButton.UseSelectable = true;
            this.txtA.CustomButton.Visible = false;
            this.txtA.Lines = new string[0];
            this.txtA.Location = new System.Drawing.Point(224, 14);
            this.txtA.MaxLength = 32767;
            this.txtA.Name = "txtA";
            this.txtA.PasswordChar = '\0';
            this.txtA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtA.SelectedText = "";
            this.txtA.SelectionLength = 0;
            this.txtA.SelectionStart = 0;
            this.txtA.ShortcutsEnabled = true;
            this.txtA.Size = new System.Drawing.Size(40, 23);
            this.txtA.TabIndex = 11;
            this.txtA.UseSelectable = true;
            this.txtA.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtA.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRo
            // 
            // 
            // 
            // 
            this.txtRo.CustomButton.Image = null;
            this.txtRo.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.txtRo.CustomButton.Name = "";
            this.txtRo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRo.CustomButton.TabIndex = 1;
            this.txtRo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRo.CustomButton.UseSelectable = true;
            this.txtRo.CustomButton.Visible = false;
            this.txtRo.Lines = new string[0];
            this.txtRo.Location = new System.Drawing.Point(149, 14);
            this.txtRo.MaxLength = 32767;
            this.txtRo.Name = "txtRo";
            this.txtRo.PasswordChar = '\0';
            this.txtRo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRo.SelectedText = "";
            this.txtRo.SelectionLength = 0;
            this.txtRo.SelectionStart = 0;
            this.txtRo.ShortcutsEnabled = true;
            this.txtRo.Size = new System.Drawing.Size(40, 23);
            this.txtRo.TabIndex = 10;
            this.txtRo.UseSelectable = true;
            this.txtRo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtN
            // 
            // 
            // 
            // 
            this.txtN.CustomButton.Image = null;
            this.txtN.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.txtN.CustomButton.Name = "";
            this.txtN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtN.CustomButton.TabIndex = 1;
            this.txtN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtN.CustomButton.UseSelectable = true;
            this.txtN.CustomButton.Visible = false;
            this.txtN.Lines = new string[0];
            this.txtN.Location = new System.Drawing.Point(75, 14);
            this.txtN.MaxLength = 32767;
            this.txtN.Name = "txtN";
            this.txtN.PasswordChar = '\0';
            this.txtN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtN.SelectedText = "";
            this.txtN.SelectionLength = 0;
            this.txtN.SelectionStart = 0;
            this.txtN.ShortcutsEnabled = true;
            this.txtN.Size = new System.Drawing.Size(40, 23);
            this.txtN.TabIndex = 9;
            this.txtN.UseSelectable = true;
            this.txtN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 357);
            this.Controls.Add(this.tidalTurbinePanel);
            this.Controls.Add(this.windSpeedPanel);
            this.Controls.Add(this.metroLabel28);
            this.Controls.Add(this.lblwindSpeedPanel);
            this.DisplayHeader = false;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(10, 10);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.Text = "ITU ROV Team GUI";
            this.windSpeedPanel.ResumeLayout(false);
            this.windSpeedPanel.PerformLayout();
            this.tidalTurbinePanel.ResumeLayout(false);
            this.tidalTurbinePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel windSpeedPanel;
        private MetroFramework.Controls.MetroLabel lblwindSpeedPanel;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtwindangle;
        private MetroFramework.Controls.MetroTextBox txtairspeedDes;
        private MetroFramework.Controls.MetroTextBox txtdescent;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtfailure;
        private MetroFramework.Controls.MetroTextBox txttakeof;
        private MetroFramework.Controls.MetroTextBox txtascent;
        private MetroFramework.Controls.MetroLabel lblaircraftDistance;
        private MetroFramework.Controls.MetroLabel lblaircraftAngle;
        private MetroFramework.Controls.MetroLabel metroLabel28;
        private MetroFramework.Controls.MetroPanel tidalTurbinePanel;
        private System.Windows.Forms.Button btnIntegrate;
        private MetroFramework.Controls.MetroTextBox txtEquation;
        private MetroFramework.Controls.MetroLabel lblPower;
        private MetroFramework.Controls.MetroButton btntask3;
        private MetroFramework.Controls.MetroTextBox txtCp;
        private MetroFramework.Controls.MetroTextBox txtV;
        private MetroFramework.Controls.MetroTextBox txtA;
        private MetroFramework.Controls.MetroTextBox txtRo;
        private MetroFramework.Controls.MetroTextBox txtN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel29;
        private MetroFramework.Controls.MetroTextBox txtairspeedAs;
    }
}

