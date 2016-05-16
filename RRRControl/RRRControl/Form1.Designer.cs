namespace RRRControl
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ReadMemory = new System.ComponentModel.BackgroundWorker();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRpm = new System.Windows.Forms.Label();
            this.lblRpmMax = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFuelPressure = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFuelMax = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblEngineOilPressure = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblEngineOilTemp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEngineWaterTemp = new System.Windows.Forms.Label();
            this.lblGear = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblBrakeFLTemp = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTireFLPressure = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTireFLRight = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTireFLCenter = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTireFLLeft = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lblBrakeFRTemp = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblTireFRPressure = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblTireFRRight = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblTireFRCenter = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lblTireFRLeft = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lblBrakeRRTemp = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lblTireRRPressure = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.lblTireRRright = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblTireRRCenter = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.lblTireRRLeft = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.lblBrakeRLTemp = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.lblTireRLPressure = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.lblTireRLRight = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.lblTireRLCenter = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.lblTireRLLeft = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.lblDRS = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.lblFrontBrakes = new System.Windows.Forms.Label();
            this.lblRearBrakes = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReadMemory
            // 
            this.ReadMemory.WorkerSupportsCancellation = true;
            this.ReadMemory.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ReadMemory_DoWork);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(213, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblRpm
            // 
            this.lblRpm.AutoSize = true;
            this.lblRpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRpm.Location = new System.Drawing.Point(243, 106);
            this.lblRpm.Name = "lblRpm";
            this.lblRpm.Size = new System.Drawing.Size(72, 25);
            this.lblRpm.TabIndex = 9;
            this.lblRpm.Text = "00000";
            // 
            // lblRpmMax
            // 
            this.lblRpmMax.AutoSize = true;
            this.lblRpmMax.Location = new System.Drawing.Point(362, 115);
            this.lblRpmMax.Name = "lblRpmMax";
            this.lblRpmMax.Size = new System.Drawing.Size(37, 13);
            this.lblRpmMax.TabIndex = 10;
            this.lblRpmMax.Text = "00000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "limit";
            // 
            // lblFuelPressure
            // 
            this.lblFuelPressure.AutoSize = true;
            this.lblFuelPressure.Location = new System.Drawing.Point(92, 21);
            this.lblFuelPressure.Name = "lblFuelPressure";
            this.lblFuelPressure.Size = new System.Drawing.Size(25, 13);
            this.lblFuelPressure.TabIndex = 12;
            this.lblFuelPressure.Text = "000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "KPa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pressure";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFuelMax);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblFuel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblFuelPressure);
            this.groupBox1.Location = new System.Drawing.Point(213, 553);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 67);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuel";
            // 
            // lblFuelMax
            // 
            this.lblFuelMax.AutoSize = true;
            this.lblFuelMax.Location = new System.Drawing.Point(164, 43);
            this.lblFuelMax.Name = "lblFuelMax";
            this.lblFuelMax.Size = new System.Drawing.Size(25, 13);
            this.lblFuelMax.TabIndex = 18;
            this.lblFuelMax.Text = "000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "L on";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Left";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(92, 43);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(25, 13);
            this.lblFuel.TabIndex = 15;
            this.lblFuel.Text = "000";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lblEngineOilPressure);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblEngineOilTemp);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblEngineWaterTemp);
            this.groupBox3.Location = new System.Drawing.Point(213, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 85);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Engine";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(120, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "KPa";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Oil Pressure";
            // 
            // lblEngineOilPressure
            // 
            this.lblEngineOilPressure.AutoSize = true;
            this.lblEngineOilPressure.Location = new System.Drawing.Point(92, 63);
            this.lblEngineOilPressure.Name = "lblEngineOilPressure";
            this.lblEngineOilPressure.Size = new System.Drawing.Size(25, 13);
            this.lblEngineOilPressure.TabIndex = 25;
            this.lblEngineOilPressure.Text = "000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "C";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Oil";
            // 
            // lblEngineOilTemp
            // 
            this.lblEngineOilTemp.AutoSize = true;
            this.lblEngineOilTemp.Location = new System.Drawing.Point(92, 40);
            this.lblEngineOilTemp.Name = "lblEngineOilTemp";
            this.lblEngineOilTemp.Size = new System.Drawing.Size(25, 13);
            this.lblEngineOilTemp.TabIndex = 22;
            this.lblEngineOilTemp.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Temperature";
            // 
            // lblEngineWaterTemp
            // 
            this.lblEngineWaterTemp.AutoSize = true;
            this.lblEngineWaterTemp.Location = new System.Drawing.Point(92, 16);
            this.lblEngineWaterTemp.Name = "lblEngineWaterTemp";
            this.lblEngineWaterTemp.Size = new System.Drawing.Size(25, 13);
            this.lblEngineWaterTemp.TabIndex = 19;
            this.lblEngineWaterTemp.Text = "000";
            // 
            // lblGear
            // 
            this.lblGear.AutoSize = true;
            this.lblGear.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGear.Location = new System.Drawing.Point(279, 5);
            this.lblGear.Name = "lblGear";
            this.lblGear.Size = new System.Drawing.Size(75, 73);
            this.lblGear.TabIndex = 18;
            this.lblGear.Text = "E";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(360, 35);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(25, 13);
            this.lblSpeed.TabIndex = 19;
            this.lblSpeed.Text = "000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Km/h";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.lblBrakeFLTemp);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.lblTireFLPressure);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.lblTireFLRight);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.lblTireFLCenter);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.lblTireFLLeft);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(7, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 106);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Front Left";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(147, 84);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "C";
            // 
            // lblBrakeFLTemp
            // 
            this.lblBrakeFLTemp.AutoSize = true;
            this.lblBrakeFLTemp.Location = new System.Drawing.Point(119, 84);
            this.lblBrakeFLTemp.Name = "lblBrakeFLTemp";
            this.lblBrakeFLTemp.Size = new System.Drawing.Size(31, 13);
            this.lblBrakeFLTemp.TabIndex = 11;
            this.lblBrakeFLTemp.Text = "0000";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(45, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Brake Temp.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(146, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "KPa";
            // 
            // lblTireFLPressure
            // 
            this.lblTireFLPressure.AutoSize = true;
            this.lblTireFLPressure.Location = new System.Drawing.Point(119, 60);
            this.lblTireFLPressure.Name = "lblTireFLPressure";
            this.lblTireFLPressure.Size = new System.Drawing.Size(25, 13);
            this.lblTireFLPressure.TabIndex = 8;
            this.lblTireFLPressure.Text = "000";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(45, 60);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 13);
            this.label21.TabIndex = 7;
            this.label21.Text = "Pressure";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(166, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "C";
            // 
            // lblTireFLRight
            // 
            this.lblTireFLRight.AutoSize = true;
            this.lblTireFLRight.Location = new System.Drawing.Point(143, 37);
            this.lblTireFLRight.Name = "lblTireFLRight";
            this.lblTireFLRight.Size = new System.Drawing.Size(25, 13);
            this.lblTireFLRight.TabIndex = 5;
            this.lblTireFLRight.Text = "000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(104, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "C";
            // 
            // lblTireFLCenter
            // 
            this.lblTireFLCenter.AutoSize = true;
            this.lblTireFLCenter.Location = new System.Drawing.Point(81, 37);
            this.lblTireFLCenter.Name = "lblTireFLCenter";
            this.lblTireFLCenter.Size = new System.Drawing.Size(25, 13);
            this.lblTireFLCenter.TabIndex = 3;
            this.lblTireFLCenter.Text = "000";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "C";
            // 
            // lblTireFLLeft
            // 
            this.lblTireFLLeft.AutoSize = true;
            this.lblTireFLLeft.Location = new System.Drawing.Point(6, 37);
            this.lblTireFLLeft.Name = "lblTireFLLeft";
            this.lblTireFLLeft.Size = new System.Drawing.Size(25, 13);
            this.lblTireFLLeft.TabIndex = 1;
            this.lblTireFLLeft.Text = "000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tire Temps. (Left-Centre-Right)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.lblBrakeFRTemp);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.lblTireFRPressure);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.lblTireFRRight);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.lblTireFRCenter);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.lblTireFRLeft);
            this.groupBox5.Controls.Add(this.label34);
            this.groupBox5.Location = new System.Drawing.Point(419, 243);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 106);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Front Right";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(147, 84);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "C";
            // 
            // lblBrakeFRTemp
            // 
            this.lblBrakeFRTemp.AutoSize = true;
            this.lblBrakeFRTemp.Location = new System.Drawing.Point(119, 84);
            this.lblBrakeFRTemp.Name = "lblBrakeFRTemp";
            this.lblBrakeFRTemp.Size = new System.Drawing.Size(31, 13);
            this.lblBrakeFRTemp.TabIndex = 11;
            this.lblBrakeFRTemp.Text = "0000";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(45, 84);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 13);
            this.label24.TabIndex = 10;
            this.label24.Text = "Brake Temp.";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(146, 60);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(27, 13);
            this.label25.TabIndex = 9;
            this.label25.Text = "KPa";
            // 
            // lblTireFRPressure
            // 
            this.lblTireFRPressure.AutoSize = true;
            this.lblTireFRPressure.Location = new System.Drawing.Point(119, 60);
            this.lblTireFRPressure.Name = "lblTireFRPressure";
            this.lblTireFRPressure.Size = new System.Drawing.Size(25, 13);
            this.lblTireFRPressure.TabIndex = 8;
            this.lblTireFRPressure.Text = "000";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(45, 60);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(48, 13);
            this.label27.TabIndex = 7;
            this.label27.Text = "Pressure";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(166, 37);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(14, 13);
            this.label28.TabIndex = 6;
            this.label28.Text = "C";
            // 
            // lblTireFRRight
            // 
            this.lblTireFRRight.AutoSize = true;
            this.lblTireFRRight.Location = new System.Drawing.Point(143, 37);
            this.lblTireFRRight.Name = "lblTireFRRight";
            this.lblTireFRRight.Size = new System.Drawing.Size(25, 13);
            this.lblTireFRRight.TabIndex = 5;
            this.lblTireFRRight.Text = "000";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(104, 37);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(14, 13);
            this.label30.TabIndex = 4;
            this.label30.Text = "C";
            // 
            // lblTireFRCenter
            // 
            this.lblTireFRCenter.AutoSize = true;
            this.lblTireFRCenter.Location = new System.Drawing.Point(81, 37);
            this.lblTireFRCenter.Name = "lblTireFRCenter";
            this.lblTireFRCenter.Size = new System.Drawing.Size(25, 13);
            this.lblTireFRCenter.TabIndex = 3;
            this.lblTireFRCenter.Text = "000";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(29, 37);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(14, 13);
            this.label32.TabIndex = 2;
            this.label32.Text = "C";
            // 
            // lblTireFRLeft
            // 
            this.lblTireFRLeft.AutoSize = true;
            this.lblTireFRLeft.Location = new System.Drawing.Point(6, 37);
            this.lblTireFRLeft.Name = "lblTireFRLeft";
            this.lblTireFRLeft.Size = new System.Drawing.Size(25, 13);
            this.lblTireFRLeft.TabIndex = 1;
            this.lblTireFRLeft.Text = "000";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 16);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(152, 13);
            this.label34.TabIndex = 0;
            this.label34.Text = "Tire Temps. (Left-Centre-Right)";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.lblBrakeRRTemp);
            this.groupBox6.Controls.Add(this.label29);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.lblTireRRPressure);
            this.groupBox6.Controls.Add(this.label35);
            this.groupBox6.Controls.Add(this.label36);
            this.groupBox6.Controls.Add(this.lblTireRRright);
            this.groupBox6.Controls.Add(this.label38);
            this.groupBox6.Controls.Add(this.lblTireRRCenter);
            this.groupBox6.Controls.Add(this.label40);
            this.groupBox6.Controls.Add(this.lblTireRRLeft);
            this.groupBox6.Controls.Add(this.label42);
            this.groupBox6.Location = new System.Drawing.Point(419, 435);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 106);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Rear Right";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(147, 84);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 13);
            this.label23.TabIndex = 12;
            this.label23.Text = "C";
            // 
            // lblBrakeRRTemp
            // 
            this.lblBrakeRRTemp.AutoSize = true;
            this.lblBrakeRRTemp.Location = new System.Drawing.Point(119, 84);
            this.lblBrakeRRTemp.Name = "lblBrakeRRTemp";
            this.lblBrakeRRTemp.Size = new System.Drawing.Size(31, 13);
            this.lblBrakeRRTemp.TabIndex = 11;
            this.lblBrakeRRTemp.Text = "0000";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(45, 84);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(68, 13);
            this.label29.TabIndex = 10;
            this.label29.Text = "Brake Temp.";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(146, 60);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(27, 13);
            this.label31.TabIndex = 9;
            this.label31.Text = "KPa";
            // 
            // lblTireRRPressure
            // 
            this.lblTireRRPressure.AutoSize = true;
            this.lblTireRRPressure.Location = new System.Drawing.Point(119, 60);
            this.lblTireRRPressure.Name = "lblTireRRPressure";
            this.lblTireRRPressure.Size = new System.Drawing.Size(25, 13);
            this.lblTireRRPressure.TabIndex = 8;
            this.lblTireRRPressure.Text = "000";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(45, 60);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(48, 13);
            this.label35.TabIndex = 7;
            this.label35.Text = "Pressure";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(166, 37);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(14, 13);
            this.label36.TabIndex = 6;
            this.label36.Text = "C";
            // 
            // lblTireRRright
            // 
            this.lblTireRRright.AutoSize = true;
            this.lblTireRRright.Location = new System.Drawing.Point(143, 37);
            this.lblTireRRright.Name = "lblTireRRright";
            this.lblTireRRright.Size = new System.Drawing.Size(25, 13);
            this.lblTireRRright.TabIndex = 5;
            this.lblTireRRright.Text = "000";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(104, 37);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(14, 13);
            this.label38.TabIndex = 4;
            this.label38.Text = "C";
            // 
            // lblTireRRCenter
            // 
            this.lblTireRRCenter.AutoSize = true;
            this.lblTireRRCenter.Location = new System.Drawing.Point(81, 37);
            this.lblTireRRCenter.Name = "lblTireRRCenter";
            this.lblTireRRCenter.Size = new System.Drawing.Size(25, 13);
            this.lblTireRRCenter.TabIndex = 3;
            this.lblTireRRCenter.Text = "000";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(29, 37);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(14, 13);
            this.label40.TabIndex = 2;
            this.label40.Text = "C";
            // 
            // lblTireRRLeft
            // 
            this.lblTireRRLeft.AutoSize = true;
            this.lblTireRRLeft.Location = new System.Drawing.Point(6, 37);
            this.lblTireRRLeft.Name = "lblTireRRLeft";
            this.lblTireRRLeft.Size = new System.Drawing.Size(25, 13);
            this.lblTireRRLeft.TabIndex = 1;
            this.lblTireRRLeft.Text = "000";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 16);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(152, 13);
            this.label42.TabIndex = 0;
            this.label42.Text = "Tire Temps. (Left-Centre-Right)";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.lblBrakeRLTemp);
            this.groupBox7.Controls.Add(this.label37);
            this.groupBox7.Controls.Add(this.label39);
            this.groupBox7.Controls.Add(this.lblTireRLPressure);
            this.groupBox7.Controls.Add(this.label43);
            this.groupBox7.Controls.Add(this.label44);
            this.groupBox7.Controls.Add(this.lblTireRLRight);
            this.groupBox7.Controls.Add(this.label46);
            this.groupBox7.Controls.Add(this.lblTireRLCenter);
            this.groupBox7.Controls.Add(this.label48);
            this.groupBox7.Controls.Add(this.lblTireRLLeft);
            this.groupBox7.Controls.Add(this.label50);
            this.groupBox7.Location = new System.Drawing.Point(7, 435);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 106);
            this.groupBox7.TabIndex = 23;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Rear Right";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(147, 84);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(14, 13);
            this.label26.TabIndex = 12;
            this.label26.Text = "C";
            // 
            // lblBrakeRLTemp
            // 
            this.lblBrakeRLTemp.AutoSize = true;
            this.lblBrakeRLTemp.Location = new System.Drawing.Point(119, 84);
            this.lblBrakeRLTemp.Name = "lblBrakeRLTemp";
            this.lblBrakeRLTemp.Size = new System.Drawing.Size(31, 13);
            this.lblBrakeRLTemp.TabIndex = 11;
            this.lblBrakeRLTemp.Text = "0000";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(45, 84);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(68, 13);
            this.label37.TabIndex = 10;
            this.label37.Text = "Brake Temp.";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(146, 60);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(27, 13);
            this.label39.TabIndex = 9;
            this.label39.Text = "KPa";
            // 
            // lblTireRLPressure
            // 
            this.lblTireRLPressure.AutoSize = true;
            this.lblTireRLPressure.Location = new System.Drawing.Point(119, 60);
            this.lblTireRLPressure.Name = "lblTireRLPressure";
            this.lblTireRLPressure.Size = new System.Drawing.Size(25, 13);
            this.lblTireRLPressure.TabIndex = 8;
            this.lblTireRLPressure.Text = "000";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(45, 60);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(48, 13);
            this.label43.TabIndex = 7;
            this.label43.Text = "Pressure";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(166, 37);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(14, 13);
            this.label44.TabIndex = 6;
            this.label44.Text = "C";
            // 
            // lblTireRLRight
            // 
            this.lblTireRLRight.AutoSize = true;
            this.lblTireRLRight.Location = new System.Drawing.Point(143, 37);
            this.lblTireRLRight.Name = "lblTireRLRight";
            this.lblTireRLRight.Size = new System.Drawing.Size(25, 13);
            this.lblTireRLRight.TabIndex = 5;
            this.lblTireRLRight.Text = "000";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(104, 37);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(14, 13);
            this.label46.TabIndex = 4;
            this.label46.Text = "C";
            // 
            // lblTireRLCenter
            // 
            this.lblTireRLCenter.AutoSize = true;
            this.lblTireRLCenter.Location = new System.Drawing.Point(81, 37);
            this.lblTireRLCenter.Name = "lblTireRLCenter";
            this.lblTireRLCenter.Size = new System.Drawing.Size(25, 13);
            this.lblTireRLCenter.TabIndex = 3;
            this.lblTireRLCenter.Text = "000";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(29, 37);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(14, 13);
            this.label48.TabIndex = 2;
            this.label48.Text = "C";
            // 
            // lblTireRLLeft
            // 
            this.lblTireRLLeft.AutoSize = true;
            this.lblTireRLLeft.Location = new System.Drawing.Point(6, 37);
            this.lblTireRLLeft.Name = "lblTireRLLeft";
            this.lblTireRLLeft.Size = new System.Drawing.Size(25, 13);
            this.lblTireRLLeft.TabIndex = 1;
            this.lblTireRLLeft.Text = "000";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(6, 16);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(152, 13);
            this.label50.TabIndex = 0;
            this.label50.Text = "Tire Temps. (Left-Centre-Right)";
            // 
            // lblDRS
            // 
            this.lblDRS.AutoSize = true;
            this.lblDRS.Location = new System.Drawing.Point(361, 64);
            this.lblDRS.Name = "lblDRS";
            this.lblDRS.Size = new System.Drawing.Size(30, 13);
            this.lblDRS.TabIndex = 24;
            this.lblDRS.Text = "DRS";
            this.lblDRS.Visible = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(425, 159);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(88, 13);
            this.label33.TabIndex = 25;
            this.label33.Text = "Brake distribution";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(448, 183);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(31, 13);
            this.label41.TabIndex = 26;
            this.label41.Text = "Front";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(448, 206);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(30, 13);
            this.label45.TabIndex = 27;
            this.label45.Text = "Rear";
            // 
            // lblFrontBrakes
            // 
            this.lblFrontBrakes.AutoSize = true;
            this.lblFrontBrakes.Location = new System.Drawing.Point(503, 183);
            this.lblFrontBrakes.Name = "lblFrontBrakes";
            this.lblFrontBrakes.Size = new System.Drawing.Size(25, 13);
            this.lblFrontBrakes.TabIndex = 28;
            this.lblFrontBrakes.Text = "000";
            // 
            // lblRearBrakes
            // 
            this.lblRearBrakes.AutoSize = true;
            this.lblRearBrakes.Location = new System.Drawing.Point(503, 206);
            this.lblRearBrakes.Name = "lblRearBrakes";
            this.lblRearBrakes.Size = new System.Drawing.Size(25, 13);
            this.lblRearBrakes.TabIndex = 29;
            this.lblRearBrakes.Text = "000";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(532, 183);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(15, 13);
            this.label51.TabIndex = 30;
            this.label51.Text = "%";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(534, 206);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(15, 13);
            this.label52.TabIndex = 31;
            this.label52.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(845, 624);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.lblRearBrakes);
            this.Controls.Add(this.lblFrontBrakes);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.lblDRS);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblGear);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRpmMax);
            this.Controls.Add(this.lblRpm);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "RRRControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker ReadMemory;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRpm;
        private System.Windows.Forms.Label lblRpmMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFuelPressure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFuelMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblEngineOilTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEngineWaterTemp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblEngineOilPressure;
        private System.Windows.Forms.Label lblGear;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblTireFLRight;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblTireFLCenter;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTireFLLeft;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTireFLPressure;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblBrakeFLTemp;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblBrakeFRTemp;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblTireFRPressure;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblTireFRRight;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblTireFRCenter;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblTireFRLeft;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblBrakeRRTemp;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblTireRRPressure;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label lblTireRRright;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lblTireRRCenter;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label lblTireRRLeft;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblBrakeRLTemp;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label lblTireRLPressure;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label lblTireRLRight;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label lblTireRLCenter;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label lblTireRLLeft;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label lblDRS;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label lblFrontBrakes;
        private System.Windows.Forms.Label lblRearBrakes;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
    }
}

