using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Orbital_V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool CheckIfInjected() //Check if bot is running and return false or true
        {

            var processes = Process.GetProcessesByName("Bot");
            foreach (var p in processes)
            {
                return true; //Bot is open and running
            }
            return false;


        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimerCheckInjected.Start();

            //Find Process ID of Rocket League instances for Injection Arguments
            listBox_Processes.Items.Clear();
            var processes = Process.GetProcessesByName("RocketLeague");
            foreach (var p in processes)
            {
                listBox_Processes.Items.Add(p.Id);
            }
            if (listBox_Processes.Items.Count == 0)
            {
                MessageBox.Show("Failed To Find Any Processes...");
            }
        }

        static void Inject(string bot, string kickoff, string pid, string minimap, string monitoring, string debugger, string debugKeys, string clock)
        {

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = @"Bot.exe";
                string args = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}", bot, kickoff, pid, minimap, monitoring, debugger, debugKeys, clock); //order of args dont matter
                // startInfo.Arguments = @"--kickoff --minimap --monitoring -b nexto -p 18732";
                startInfo.Arguments = args;
                Process.Start(startInfo);


                // MessageBox.Show(bot);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed To Load Bot.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //this way if arg not selected, string is nothing and it will still pass through, easier than booleans and converting to string.
            string botSelection = "";
            string kickoff = "";
            string minimap = "";
            string monitoring = "";
            string clock = "";
            string debug_keys = "";
            string debugger = "";

            // Create Args //
            if (checkBox_SpeedFlip.Checked)
            {
                kickoff = " --kickoff";
            }
            if (checkBox_BotMiniMap.Checked)
            {
                minimap = " --minimap";

            }
            if (checkBox_BotMonitor.Checked)
            {
                monitoring = " --monitoring";
            }
            if (checkBox_Clock.Checked)
            {
                clock = " --clock";
            }
            if (checkBox_Debugger.Checked)
            {
                debugger = " --debug";
            }
            if (checkBox_DebugKeys.Checked)
            {
                debug_keys = " --debug-keys";
            }


            //If Bot Not Selected
            if (comboBotSelection.SelectedIndex == -1)
            {

                MessageBox.Show("Please select a Bot");
                return;

            }
            //If No Processes were Found
            if (listBox_Processes.Items.Count == 0)
            {
                MessageBox.Show("No Processes to Inject to. Please check if Rocket League is open.");
                return;
            }



            //Bot Selection Args | its important to have spaces so args pass through to the bot correctly
            if (comboBotSelection.SelectedIndex == 0 && listBox_Processes.Items.Count > 0)
            {
                botSelection = " -b nexto";


            }
            if (comboBotSelection.SelectedIndex == 1 && listBox_Processes.Items.Count > 0)
            {
                botSelection = " -b necto";

            }
            if (comboBotSelection.SelectedIndex == 2 && listBox_Processes.Items.Count > 0)
            {
                botSelection = " -b element";

            }
            if (comboBotSelection.SelectedIndex == 3 && listBox_Processes.Items.Count > 0)
            {
                botSelection = " -b seer";

            }


            //if 1 or more processes are found then loop inject
            if (listBox_Processes.Items.Count > 1) //count starts at 0

            {
                foreach (var pid in listBox_Processes.Items)
                {
                    Inject(botSelection, kickoff, minimap, monitoring, clock, debugger, debug_keys, " -p " + pid.ToString());
                }
            }

            //else just inject once
            else
            {

                string pid = " -p " + listBox_Processes.Items[0].ToString(); //index 0 is first in list
                Inject(botSelection, kickoff, minimap, monitoring, clock, debugger, debug_keys, pid);

            }


        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //Opens Links to credit Creator

            Process myProcess = new Process();
            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "Https://github.com/MarlBurroW";
                myProcess.Start();
            }
            catch (Exception z)
            {
                MessageBox.Show(Convert.ToString(z));
            }



            //  string target = "Https://github.com/MarlBurroW";
            // System.Diagnostics.Process.Start("https://github.com/MarlBurroW"); // this doesnt work for some reason? 
        }

        private void TimerCheckInjected_Tick(object sender, EventArgs e) //Check if Injected every 10 seconds...
        {
            if (CheckIfInjected() == true)
            {
                LabelInjected.ForeColor = Color.Blue;
                LabelInjected.Text = "Injected";
            }
            else
            {
                LabelInjected.ForeColor = Color.Red;
                LabelInjected.Text = "Not Injected";
            }
        }

        private void checkBox_BotMiniMap_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Process myProcess = new Process();
            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "https://github.com/SkiffyMan";
                myProcess.Start();
            }
            catch (Exception z)
            {
                MessageBox.Show(Convert.ToString(z));
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
