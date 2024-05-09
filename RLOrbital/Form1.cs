using RLOrbital;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Orbital_V1._0
{
    public partial class Form1 : Form
    {


        //  private static Dictionary<string, MyProcess> _processes;
        public Form1()
        {
            InitializeComponent();
        }

        //Process testProcess;

        private bool CheckIfInjected() //Check if bot is running and return false or true
        {

            var processes = Process.GetProcessesByName("Bot");
            foreach (var p in processes)
            {
                return true; //Bot is open and running
            }
            return false;

        }

        private void GetCurrentBotPID()
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

        private void InjectBakkesMod()
        {
            //bakkes mod folder is static so this should work universally for anyone with the added benefit of bakkes mod auto updating anyway

            string userName = Environment.UserName; //need to get username to find bakkes mod folder
            string bakkesModDLLPath = string.Format(@"C:\Users\{0}\AppData\Roaming\bakkesmod\bakkesmod\dll\bakkesmod.dll", userName);
            string pid = listBox_Processes.SelectedItem.ToString();
            uint processID = Convert.ToUInt32(pid);
            DLLInjector D1 = new DLLInjector();
            try
            {
                D1.injectDLL(processID, bakkesModDLLPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Inject BakkesMod on RL Process: " + pid);
            }
        }

        static void Inject(string bot, string kickoff, string pid, string minimap, string monitoring, string debugger, string debugKeys, string clock)
        {

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = @"Bot.exe";
                string args = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}", bot, kickoff, pid, minimap, monitoring, debugger, debugKeys, clock); //order of args dont matter
                //startInfo.Arguments = @"--kickoff --minimap --monitoring -b nexto -p 18732";
                startInfo.Arguments = args;
                Process.Start(startInfo);


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

            if (checkBox1_BakkesMod.Checked)
            {
                InjectBakkesMod();
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



            //if Process from listbox not selected, then return, else Start Bot
            int pid = listBox_Processes.SelectedIndex;
            if (pid == -1)
            {
                MessageBox.Show("Select a process.");
                return;
            }
            else
            {
                string processID = " -p " + listBox_Processes.SelectedItem.ToString();
                processID = processID.ToLower(); // no idea what causes this to be uppercase.
                Inject(botSelection, kickoff, minimap, monitoring, clock, debugger, debug_keys, processID);
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

        }

        private void TimerCheckInjected_Tick(object sender, EventArgs e) //Check if Injected every 10 seconds...
        {


            if (CheckIfInjected() == true)
            {
                LabelInjected.ForeColor = Color.Blue;
                LabelInjected.Text = "Bot Running";
            }
            else
            {
                LabelInjected.ForeColor = Color.Red;
                LabelInjected.Text = "Not Running";
            }

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




        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
