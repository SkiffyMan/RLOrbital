using RLOrbital;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;
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

        private string GetCurrentBotPID() 
        {
            var processes = Process.GetProcessesByName("Bot");
            foreach (var p in processes)
            {
                string BotPid = p.Id.ToString();
                return BotPid;
            }
            return "";

        }
        private bool CheckIfPIDIsRunning(string pid, string AppName)
        {
            //listBox_Processes.Items.Clear();
            var processes = Process.GetProcessesByName(AppName);
            foreach (var p in processes)
            {
                string process = p.Id.ToString();
                if (process == pid)
                {
                    //MessageBox.Show(process);
                    return true;
                }
            }
            return false;
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

        private bool InjectBakkesMod()
        {
            //bakkes mod folder is static so this should work universally for anyone with the added benefit of bakkes mod auto updating anyway
            //need to get username to find bakkes mod folder

            string userName = Environment.UserName;
            string bakkesModDLLPath = string.Format(@"C:\Users\{0}\AppData\Roaming\bakkesmod\bakkesmod\dll\bakkesmod.dll", userName);
            string pid = listBox_Processes.SelectedItem.ToString();
            uint processID = Convert.ToUInt32(pid);
            DLLInjector D1 = new DLLInjector();


            if (File.Exists(bakkesModDLLPath))
            {

            }
            else
            {
                MessageBox.Show("Failed to find BakkesMod Folder...");
                return false;
            }


            if (D1.injectDLL(processID, bakkesModDLLPath) == true)
            {
                return true;
            }
            else
            {
                return false;
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


            ///Check if Bot is already running on Rocket League Instance
            int tempSelectedIndex = listBox_Processes.SelectedIndex;
            if (tempSelectedIndex != -1)
            { 
                string CurrentBotPid = listBox_BotPid.Items[tempSelectedIndex].ToString();
                if (CurrentBotPid.Length > 2)
                {
                    if (CheckIfPIDIsRunning(CurrentBotPid, "bot") == true)
                    {
                        MessageBox.Show("Bot already running on Rocket League Process....");
                        return;
                    }
                    else
                    {
                        listBox_BotPid.Items.RemoveAt(tempSelectedIndex);
                        listBox_BotPid.Items.Insert(tempSelectedIndex, "1");
                    }
                }
            }



            if (checkBox1_BakkesMod.Checked && listBox_Processes.SelectedIndex != -1) //If process is selected
            {

                if (InjectBakkesMod() == true)
                {

                }
                else
                {
                    MessageBox.Show("Failed to Inject DLL On process + " + listBox_Processes.SelectedItem.ToString());
                }

            }


            //Bot Selection Args | its important to have spaces so args pass through to the bot correctly
            //The && statements here are useless as we already check this//
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


                //if your reading this you're a cool dude for real.
                //I'm not a professional programmer -- If you want to improve the code do so. I make applications for myself, and if other people find benefit then thats all that matters.
                //Using a listbox instead of public <list>  It's Silly, but I kept running into a errors, for now this works fine, and is perfectly functional. If its not broken don't fix it!
                //This associates the Current running Bot process ID with the current Rocket League instance. 
                //Because Marlbot spawns childrens processes this is neccessary. We need the "master" process ID. This is why the stop Bot feature was challenging to make.
                int SelectedIndex = listBox_Processes.SelectedIndex;
                SelectedIndex = SelectedIndex + 1;
                var processes = Process.GetProcessesByName("Bot");
                foreach (var p in processes)
                {
                    string BotPid = p.Id.ToString();
                    bool IsInList = listBox_BotPid.Items.Cast<string>().Any(x => x == BotPid);

                    if (IsInList == true)
                    {

                    }
                    else
                    {
                        listBox_BotPid.Items.RemoveAt(pid);
                        listBox_BotPid.Items.Insert(pid, BotPid);

                    }
                }
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
                int BotCount = 0;
                foreach (var listBoxItem in listBox_BotPid.Items)
                {
                    string listBoxItem_ = listBoxItem.ToString();
                    if (listBoxItem_.Length > 2)
                    {
                        BotCount = BotCount + 1;
                    }
                }

                if (BotCount > 1)
                {
                    string BotCountStr = BotCount.ToString();
                    LabelInjected.ForeColor = Color.Blue;
                    LabelInjected.Text = string.Format("{0} Bots Running", BotCountStr);
                }

                else
                {
                    string BotCountStr = BotCount.ToString();
                    LabelInjected.ForeColor = Color.Blue;
                    LabelInjected.Text = string.Format("{0} Bot Running", BotCountStr);
                }
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

        private bool KillCurrentBot(string pid)
        {
            if (CheckIfInjected() == true)
            {

            }
            else
            {
                return false;
            }

            int SelectedIndex = listBox_Processes.SelectedIndex;
            string arg = string.Format("/f /t /pid {0}", pid); //force //kill children process //process id
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo("taskkill", arg)
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    WorkingDirectory = System.AppDomain.CurrentDomain.BaseDirectory,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };
                Process.Start(processStartInfo);
            }
            catch
            {

            }
            listBox_BotPid.Items.RemoveAt(SelectedIndex);
            listBox_BotPid.Items.Insert(SelectedIndex, "1");
            return true;

        }


        private void button_StopBot_Click(object sender, EventArgs e)
        {

            //Complicated way of doing this but it works so I don't care for now.
            if (CheckIfInjected() == true)
            {

            }
            else
            {
                MessageBox.Show("No bot running...");
                return;
            }

            int SelectedIndex = listBox_Processes.SelectedIndex;
            string CurrentBotPid = listBox_BotPid.Items[SelectedIndex].ToString();
            if (CurrentBotPid.Length > 2)
            {
                KillCurrentBot(CurrentBotPid);
            }
            else
            {
                MessageBox.Show("No bot is running on Rocket League Instance + " + listBox_Processes.SelectedItem.ToString());
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void LabelInjected_Click(object sender, EventArgs e)
        {

        }
    }
}
