using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using RRRControl.Data;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;
using System.Threading;
using System.Drawing;

namespace RRRControl
{
    delegate void SetTextCallback(string controlName,string text);
    delegate void SetVisibilityCallback(string controlName, bool value);
    delegate void SetColorCallback(string controlName, Color colour);
    public partial class Form1 : Form
    {

       //used for setting data also out of principal threading
        private void setText(string controlName, string text)
        {
            Control control = this.Controls.Find(controlName, true).FirstOrDefault();

            try
            {
                if (control.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(setText);
                    this.Invoke(d, new object[] { controlName, text });
                }
                else
                {
                    control.Text = text;
                }
            }
            catch {
                //probably you've close the form before this thread finish.
            }
           
        }

        //used for setting visibility also out of principal threading
        private void setVisibility(string controlName, bool value)
        {
            Control control = this.Controls.Find(controlName, true).FirstOrDefault();

            try
            {
                if (control.InvokeRequired)
                {
                    SetVisibilityCallback d = new SetVisibilityCallback(setVisibility);
                    this.Invoke(d, new object[] { controlName, value });
                }
                else
                {
                    control.Visible = value;
                }
            }
            catch
            {
                //probably you've close the form before this thread finish.
            }

        }

        //used for setting visibility also out of principal threading
        private void setColor(string controlName, Color color)
        {
            Control control = this.Controls.Find(controlName, true).FirstOrDefault();

            try
            {
                if (control.InvokeRequired)
                {
                    SetColorCallback d = new SetColorCallback(setColor);
                    this.Invoke(d, new object[] { controlName, color });
                }
                else
                {
                    control.ForeColor = color;
                }
            }
            catch
            {
                //probably you've close the form before this thread finish.
            }

        }


        //FORM PART
        public Form1()
        {
            InitializeComponent();
        }
  
        private void Form1_Shown(object sender, EventArgs e)
        {
            Console.WriteLine("Starting Reading");
            StartApp();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopApp();
        }



        //APP PART
        private bool Mapped
        {
            get { return (_file != null && _view != null); }
        }

        private MemoryMappedFile _file;
        private MemoryMappedViewAccessor _view;
        private readonly TimeSpan _timeInterval = TimeSpan.FromMilliseconds(100);


        public void StartApp()
        {
            Console.WriteLine("Starting App");
            ReadMemory.RunWorkerAsync();
        }

        public void StopApp()
        {
            Console.WriteLine("Stop App");
            ReadMemory.CancelAsync();
        }

        private bool Map()
        {
            try
            {
                _file = MemoryMappedFile.OpenExisting(Constant.SharedMemoryName);
                _view = _file.CreateViewAccessor(0, Marshal.SizeOf(typeof(Shared)));
                return true;
            }
            catch (FileNotFoundException)
            {
                return false;
            }
        }

        public void Print() {
            Shared data;
            _view.Read(0, out data);

            Console.WriteLine("Orientation: Pitch {0} - Yaw {1} - Roll {2} ", Utilities.RadToGrad(data.CarOrientation.Pitch), Utilities.RadToGrad(data.CarOrientation.Yaw), Utilities.RadToGrad(data.CarOrientation.Roll));
            Console.WriteLine("Accelerazione: X: {0} Y: {1} Z: {2}", data.LocalAcceleration.X, data.LocalAcceleration.Y, data.LocalAcceleration.Z);
            Console.WriteLine(data.DrsAvailable.ToString()  + "  "  + data.DrsEngaged.ToString());

        }

        public void ReportToLabel()
        {
            Shared data;
            _view.Read(0, out data);

            //GEAR
            setText("lblGear",Utilities.MapGear(data.Gear).ToString());

            //Speed
            setText("lblSpeed", Utilities.MpsToKph(data.CarSpeed).ToString("###"));

            //USERINPUT [obsolete]
            //setText("lblUserInput", data.UserInput.ToString());

            //RPM 
            setText("lblRpm", Utilities.RpsToRpm(data.EngineRps).ToString("#####"));

            //RPM Max
            setText("lblRpmMax", Utilities.RpsToRpm(data.MaxEngineRps).ToString("#####"));

            //FuelPressure
            setText("lblFuelPressure", data.FuelPressure.ToString("#####"));

            //FuelLiters
            setText("lblFuel", data.FuelLeft.ToString("#####"));

            //FuelLitersMax
            setText("lblFuelMax", data.FuelCapacity.ToString("#####"));


            //EngineWaterTemperature
            setText("lblEngineWaterTemp", data.EngineWaterTemp.ToString("#####"));

            //EngineOilTemperature
            setText("lblEngineOilTemp", data.EngineOilTemp.ToString("#####"));

            //EngineOilPressure
            setText("lblEngineOilPressure", data.EngineOilPressure.ToString("#####"));

            //Per Axe Infos

            //FrontLEft Axe

            //Tire
            setText("lblTireFLLeft", data.TireTemp.FrontLeft_Left.ToString("#####"));
            setText("lblTireFLCenter", data.TireTemp.FrontLeft_Center.ToString("#####"));
            setText("lblTireFLRight", data.TireTemp.FrontLeft_Right.ToString("#####"));
            setText("lblTireFLPressure", data.TirePressure.FrontLeft.ToString("#####"));

            //brake
            setText("lblBrakeFLTemp", data.BrakeTemp.FrontLeft.ToString("#####"));


            //FrontRight Axe

            //Tire
            setText("lblTireFRLeft", data.TireTemp.FrontRight_Left.ToString("#####"));
            setText("lblTireFRCenter", data.TireTemp.FrontRight_Center.ToString("#####"));
            setText("lblTireFRRight", data.TireTemp.FrontRight_Right.ToString("#####"));
            setText("lblTireFRPressure", data.TirePressure.FrontRight.ToString("#####"));

            //brake
            setText("lblBrakeFRTemp", data.BrakeTemp.FrontRight.ToString("#####"));

            //RearRight Axe

            //Tire
            setText("lblTireRRLeft", data.TireTemp.RearRight_Left.ToString("#####"));
            setText("lblTireRRCenter", data.TireTemp.RearRight_Center.ToString("#####"));
            setText("lblTireRRRight", data.TireTemp.RearRight_Right.ToString("#####"));
            setText("lblTireRRPressure", data.TirePressure.RearRight.ToString("#####"));

            //brake
            setText("lblBrakeRRTemp", data.BrakeTemp.RearRight.ToString("#####"));

            //RearLeft Axe

            //Tire
            setText("lblTireRLLeft", data.TireTemp.RearLeft_Left.ToString("#####"));
            setText("lblTireRLCenter", data.TireTemp.RearLeft_Center.ToString("#####"));
            setText("lblTireRLRight", data.TireTemp.RearLeft_Right.ToString("#####"));
            setText("lblTireRLPressure", data.TirePressure.RearLeft.ToString("#####"));

            //brake
            setText("lblBrakeRLTemp", data.BrakeTemp.RearLeft.ToString("#####"));

            //DRS
            if (data.DrsAvailable == 1)
            {
                //avaiable, show label;
                setVisibility("lblDRS", true);
            }
            else {
                setVisibility("lblDRS", false);
                if (data.DrsEngaged == 1) {
                    setColor("lblDRS", Color.Red);
                }
                else
                {
                    setColor("lblDRS", Color.Black);
                }
               
            }

            //Brake distribution

            setText("lblFrontBrakes", Utilities.BrakeBias(data.BrakeBias,'f').ToString("###"));
            setText("lblRearBrakes", Utilities.BrakeBias(data.BrakeBias, 'r').ToString("###"));

            /*

    
            // Total number of laps in the race, or -1 if player is not in race mode (practice, test mode, etc.)
            public Int32 NumberOfLaps;

            // How many laps the player has completed. If this value is 6, the player is on his 7th lap. -1 = n/a
            public Int32 CompletedLaps;

            // Unit: Seconds (-1.0 = none)
            public Single LapTimeBestSelf;

            // Unit: Seconds (-1.0 = none)
            public Single LapTimePreviousSelf;

            // Unit: Seconds (-1.0 = none)
            public Single LapTimeCurrentSelf;

            // Current position (1 = first place)
            public Int32 Position;

            // Number of cars (including the player) in the race
            public Int32 NumCars;


            // Number of penalties pending for the player
            // Note: See the 'Penalties' field
            public Int32 NumPenalties;

            // Physical location of car's center of gravity in world space (X, Y, Z) (Y = up)
            public Vector3<Single> CarCgLocation;

            // Pitch, yaw, roll
            // Unit: Radians (rad)
            public Orientation<Single> CarOrientation;

            // Acceleration in three axes (X, Y, Z) of car body in local-space.
            // From car center, +X=left, +Y=up, +Z=back.
            // Unit: Meter per second squared (m/s^2)
            public Vector3<Single> LocalAcceleration;
      
            // Padding to accomodate for legacy alignment
            [ObsoleteAttribute("Used for padding", true)]
            public Int32 Padding1;

            // High precision data for player's vehicle only
            public PlayerData Player;

            // The current race event index, for championships with multiple events
            // Note: 0-indexed, -1 = N/A
            public Int32 EventIndex;

            // Which session the player is in (practice, qualifying, race, etc.)
            // Note: See the R3E.Constant.Session enum
            public Int32 SessionType;

            // Which phase the current session is in (gridwalk, countdown, green flag, etc.)
            // Note: See the R3E.Constant.SessionPhase enum
            public Int32 SessionPhase;

            // The current iteration of the current type of session (second qualifying session, etc.)
            // Note: 0-indexed, -1 = N/A
            public Int32 SessionIteration;

            // Which controller is currently controlling the player's car (AI, player, remote, etc.)
            // Note: See the R3E.Constant.Control enum
            public Int32 ControlType;

            // How pressed the throttle pedal is
            // Range: 0.0 - 1.0
            public Single ThrottlePedal;

            // How pressed the brake pedal is (-1.0 = N/A)
            // Range: 0.0 - 1.0
            public Single BrakePedal;

            // How pressed the clutch pedal is (-1.0 = N/A)
            // Range: 0.0 - 1.0
            public Single ClutchPedal;

         
            // -1 = no data available
            //  0 = not active
            //  1 = active
            public Int32 TireWearActive;

            // Which type of tires the player's car has (option, prime, etc.)
            // Note: See the R3E.Constant.TireType enum
            public Int32 TireType;

            // -1 = no data
            //  0 = not active
            //  1 = active
            public Int32 FuelUseActive;

            // Amount of time remaining for the current session
            // Note: Only available in time-based sessions, -1.0 = N/A
            // Units: Seconds
            public Single SessionTimeRemaining;

            // The current best lap time for the leader of the session (-1.0 = N/A)
            public Single LapTimeBestLeader;

            // The current best lap time for the leader of the player's class in the current session (-1.0 = N/A)
            public Single LapTimeBestLeaderClass;

            // Reserved for future (proper) implementation
            [ObsoleteAttribute("Improper implementation, use with caution", false)]
            public Single LapTimeDeltaSelf;

            // The time delta between the player's time and the leader of the current session (-1.0 = N/A)
            public Single LapTimeDeltaLeader;

            // The time delta between the player's time and the leader of the player's class in the current session (-1.0 = N/A)
            public Single LapTimeDeltaLeaderClass;

            // Reserved for future (proper) implementation
            [ObsoleteAttribute("Improper implementation, use with caution", false)]
            public Sectors<Single> SectorTimeDeltaSelf;

            // Reserved for future (proper) implementation
            [ObsoleteAttribute("Improper implementation, use with caution", false)]
            public Sectors<Single> SectorTimeDeltaLeader;

            // Reserved for future (proper) implementation
            [ObsoleteAttribute("Improper implementation, use with caution", false)]
            public Sectors<Single> SectorTimeDeltaLeaderClass;

            // Time delta between the player and the car placed in front (-1.0 = N/A)
            // Units: Seconds
            public Single TimeDeltaFront;

            // Time delta between the player and the car placed behind (-1.0 = N/A)
            // Units: Seconds
            public Single TimeDeltaBehind;

            // Current status of the pit stop
            // Note: See the R3E.Constant.PitWindow enum
            public Int32 PitWindowStatus;

            // The minute/lap from which you're obligated to pit (-1 = N/A)
            // Unit: Minutes in time-based sessions, otherwise lap
            public Int32 PitWindowStart;

            // The minute/lap into which you need to have pitted (-1 = N/A)
            // Unit: Minutes in time-based sessions, otherwise lap
            public Int32 PitWindowEnd;

            // Total number of cut track warnings (-1 = N/A)
            public Int32 CutTrackWarnings;

            // The number of penalties the player currently has pending of each type (-1 = N/A)
            public CutTrackPenalties Penalties;

            // The current state of each type of flag
            public Flags Flags;

            // The current state of various parts of the player's car
            public CarDamage CarDamage;
    */



        }

        private void ReadMemory_DoWork(object sender, DoWorkEventArgs e)

        {
            var timeReset = DateTime.UtcNow;
            var timeLast = timeReset;


            Console.WriteLine("Looking for RRRE.exe...");

            while (true)
            {
                var timeNow = DateTime.UtcNow;

                if (timeNow.Subtract(timeLast) < _timeInterval)
                {
                    Thread.Sleep(1);
                    continue;
                }

                timeLast = timeNow;

                if (Utilities.IsRrreRunning() && !Mapped)
                {
                    Console.WriteLine("Found RRRE.exe, mapping shared memory...");

                    if (Map())
                    {
                        Console.WriteLine("Memory mapped successfully");

                    }
                }

                if (Mapped)
                {
              
                    SendData();
                }
            }

        }

        public void SendData() {
            
           //HERE you can decide you ouput;
            
            //Print();
            ReportToLabel();
        }

    }
}
