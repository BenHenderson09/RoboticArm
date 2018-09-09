using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboticArmGUI
{
    public partial class GUI : Form
    {
        Communication com = new Communication();

        public GUI()
        {
            InitializeComponent();
        }

        // Set port number
        private void portSelection_ValueChanged(object sender, EventArgs e)
        {
            int port = (int)portSelection.Value;
            com.setPort(port);
        }

        // Define commands
        private Dictionary<string, string> commands = new Dictionary<string, string>
        {
            // Base commands
            {"baseUp"    ,"bu"},
            {"baseDown"  ,"bd"},
            {"baseLeft"  ,"bl"},
            {"baseRight" ,"br"},

            // Top commands
            {"topUp"    ,"tu"},
            {"topDown"  ,"td"},

            // Claw commands
            {"clawLeft"  ,"cl"},
            {"clawRight" ,"cr"},
            {"clawOpen"  ,"co"},
            {"clawClose" ,"cc"},

            // Stop movement
            {"stop" ,"s"}
        };

        // Handle click events

        // Settings click events
        private void btnOff_Click(object sender, EventArgs e)
        {
            turnOff();
        }

        // Base mouse events
        private void baseUp_MouseDown(object sender, MouseEventArgs e)  { command(commands["baseUp"]); }
        private void baseUp_MouseUp(object sender, MouseEventArgs e)    { command(commands["stop"]); }

        private void baseDown_MouseDown(object sender, EventArgs e)     { command(commands["baseDown"]); }
        private void baseDown_MouseUp(object sender, MouseEventArgs e)  { command(commands["stop"]); }

        private void baseRight_MouseDown(object sender, EventArgs e)    { command(commands["baseRight"]); }
        private void baseRight_MouseUp(object sender, MouseEventArgs e) { command(commands["stop"]); }

        private void baseLeft_MouseDown(object sender, EventArgs e)     { command(commands["baseLeft"]); }
        private void baseLeft_MouseUp(object sender, MouseEventArgs e)  { command(commands["stop"]); }

        // Top mouse events
        private void topUp_MouseDown(object sender, EventArgs e)        { command(commands["topUp"]); }
        private void topUp_MouseUp(object sender, MouseEventArgs e)     { command(commands["stop"]); }

        private void topDown_MouseDown(object sender, EventArgs e)      { command(commands["topDown"]); }
        private void topDown_MouseUp(object sender, MouseEventArgs e)   { command(commands["stop"]); }

        // Claw mouse events
        private void clawClose_MouseDown(object sender, EventArgs e)    { command(commands["clawClose"]); }
        private void clawClose_MouseUp(object sender, MouseEventArgs e) { command(commands["stop"]); }

        private void clawOpen_MouseDown(object sender, EventArgs e)     { command(commands["clawOpen"]); }
        private void clawOpen_MouseUp(object sender, MouseEventArgs e)  { command(commands["stop"]); }

        private void clawLeft_MouseDown(object sender, EventArgs e)     { command(commands["clawLeft"]); }
        private void clawLeft_MouseUp(object sender, MouseEventArgs e)  { command(commands["stop"]); }

        private void clawRight_MouseDown(object sender, EventArgs e)    { command(commands["clawRight"]); }
        private void clawRight_MouseUp(object sender, MouseEventArgs e) { command(commands["stop"]); }

        private void command(String command) {
            if (com.send(command) == false)
            {
                MessageBox.Show("There is a connection error, check the port and circuit.");
            }
        }

        private void turnOff() {
            command(commands["stop"]);
        }
    }
}
