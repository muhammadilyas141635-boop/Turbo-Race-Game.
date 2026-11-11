using System;
using System.Windows.Forms;

namespace TurboRaceGame3
{
    public partial class Form1 : Form
    {
        Vehicle vehicle;           //  ALL vehicle reference
        double distance = 0;
        const double Target = 100; // km
        bool racing = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbVehicle.Items.AddRange(new object[]
                { "Sports Car", "Motorbike", "Monster Truck", "Electric Car" });
            cmbVehicle.SelectedIndex = 0;   // triggers SelectedIndexChanged
        }

        // Runtime polymorphism 
        private void cmbVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbVehicle.SelectedItem.ToString())
            {
                case "Sports Car": vehicle = new SportsCar(); break;
                case "Motorbike": vehicle = new Motorbike(); break;
                case "Monster Truck": vehicle = new MonsterTruck(); break;
                case "Electric Car": vehicle = new ElectricCar(); break;
            }
            string player = string.IsNullOrWhiteSpace(txtPlayer.Text) ? "Player" : txtPlayer.Text;
            Log($"{player} selected {vehicle.Name}.");
            UpdateUI();
            SetRaceButtons(false);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlayer.Text))
            {
                MessageBox.Show("Please enter your name first.");
                return;
            }
            distance = 0;
            vehicle.Start();
            racing = true;
            timer1.Start();
            cmbVehicle.Enabled = false;
            txtPlayer.Enabled = false;
            SetRaceButtons(true);
            Log($"{vehicle.Name} started at {vehicle.CurrentSpeed} km/h.");
            UpdateUI();
        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            Log(vehicle.Drive());      //  Drive
            UpdateUI();
        }

        private void btnUsePower_Click(object sender, EventArgs e)
        {
            Log(vehicle.UsePower());   //  UsePower
            UpdateUI();
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {
            Log(vehicle.Brake());
            UpdateUI();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!racing) return;
            distance += vehicle.CurrentSpeed / 20.0;   // speed decides progress

            if (distance >= Target)
            {
                distance = Target;
                racing = false;
                timer1.Stop();
                SetRaceButtons(false);
                UpdateUI();
                Log($"🏁 {txtPlayer.Text} finished the race with {vehicle.Name}!");
                MessageBox.Show($"Congratulations Muhammad {txtPlayer.Text}! You finished the race.");
                return;
            }
            UpdateUI();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            racing = false;
            distance = 0;
            vehicle.Start();
            // reset speed display to 0 until race starts
            typeof(Vehicle).GetProperty("CurrentSpeed").SetValue(vehicle, 0);
            cmbVehicle.Enabled = true;
            txtPlayer.Enabled = true;
            lstLog.Items.Clear();
            SetRaceButtons(false);
            UpdateUI();
        }

        // ---------- helpers ----------
        private void UpdateUI()
        {
            lblVehicle.Text = vehicle.Name;
            lblInitial.Text = vehicle.InitialSpeed + " km/h";
            lblCurrent.Text = racing ? vehicle.CurrentSpeed + " km/h" : "0 km/h";
            lblMax.Text = vehicle.MaxSpeed + " km/h";
            lblPower.Text = $"{vehicle.PowerName} (+{vehicle.PowerIncrease} km/h)";

            lblDistance.Text = $"Distance Covered: {distance:0} / {Target} km";
            prgRace.Value = (int)Math.Min(distance, Target);

            // move car along the track
            double ratio = distance / Target;
            lblCar.Left = (int)((pnlTrack.Width - lblCar.Width) * ratio);
        }

        private void SetRaceButtons(bool enabled)
        {
            btnAccelerate.Enabled = enabled;
            btnUsePower.Enabled = enabled;
            btnBrake.Enabled = enabled;
            btnStart.Enabled = !enabled;
        }

        private void Log(string message)
        {
            lstLog.Items.Add(message);
            lstLog.TopIndex = lstLog.Items.Count - 1;
        }
    }
}