using RLOrbital;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Orbital_V1._0
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private bool ToggleKeySetLoad()
        {
            int index = -1;
            string currentToggleKey = GetToggleKey();
            foreach (var item in comboBox_ToggleKeys.Items)
            {
                index += 1;
                string _item = item.ToString();
                if (_item == currentToggleKey)
                {
                    comboBox_ToggleKeys.SelectedIndex = index;
                    return true;
                }
            }
            return false;

        }
        private string GetToggleKey()
        {
            string JsonConfig = System.IO.File.ReadAllText("config.json");

            Regex key = new Regex("\"bot_toggle_key\": \"(.*)\",");
            var match = key.Match(JsonConfig);
            if (match.Success)
            {
                string ToggleKey = match.Groups[1].Value;
                // MessageBox.Show(ToggleKey);
                return ToggleKey;
            }
            return "";


        }

        private void OpenBrowser(string link)
        {
            Process myProcess = new Process();
            try
            {
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = link;
                myProcess.Start();
            }
            catch (Exception z)
            {
                MessageBox.Show(Convert.ToString(z));
            }
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
            //BakkesMod Folder is static so this will work universally for any user.
            //Find bakkesMod Folder so we can Inject the DLL.
            string userName = Environment.UserName;
            string bakkesModDLLPath = string.Format(@"C:\Users\{0}\AppData\Roaming\bakkesmod\bakkesmod\dll\bakkesmod.dll", userName);
            string pid = listBox_Processes.SelectedItem.ToString();
            uint processID = Convert.ToUInt32(pid);
            DLLInjector D1 = new DLLInjector();

            //If BakkesMod Not installed or not found
            if (System.IO.File.Exists(bakkesModDLLPath))
            {

            }
            else
            {
                MessageBox.Show("Failed to find BakkesMod Folder... Make sure BakkesMod is installed");
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
            //Start the exe of Marlbot with given arguments. The order of arguments does not matter.
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = @"Bot.exe";
                string args = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}", bot, kickoff, pid, minimap, monitoring, debugger, debugKeys, clock);
                startInfo.Arguments = args;
                Process.Start(startInfo);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed To Load Bot. Check if Bot.exe is in directory.");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Argument selection
            string botSelection = "";
            string kickoff = "";
            string minimap = "";
            string monitoring = "";
            string clock = "";
            string debug_keys = "";
            string debugger = "";
            int SelectedIndex = listBox_Processes.SelectedIndex;

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

            //If Rocket League Process is not selected
            if (SelectedIndex == -1)
            {
                MessageBox.Show("No process was selected.");
                return;
            }


            //Check if bot is already running for the Rocket League process selected
            string CurrentBotPid = listBox_BotPid.Items[SelectedIndex].ToString();
            if (CurrentBotPid.Length > 2)
            {
                if (CheckIfPIDIsRunning(CurrentBotPid, "bot") == true)
                {
                    MessageBox.Show("Bot already running on Rocket League Process....");
                    return;
                }
                else
                {
                    listBox_BotPid.Items.RemoveAt(SelectedIndex);
                    listBox_BotPid.Items.Insert(SelectedIndex, "1");
                }
            }


            //Bot Selection Args//
            if (comboBotSelection.SelectedIndex == 0)
            {
                botSelection = " -b nexto";
            }
            else if (comboBotSelection.SelectedIndex == 1)
            {
                botSelection = " -b nextmortal";
            }
            else if (comboBotSelection.SelectedIndex == 2)
            {
                botSelection = " -b necto";
            }
            else if (comboBotSelection.SelectedIndex == 3)
            {
                botSelection = " -b element";
            }
            else if (comboBotSelection.SelectedIndex == 4)
            {
                botSelection = " -b seer";
            }



            //Inject BakkesMod
            if (checkBox1_BakkesMod.Checked)
            {

                if (InjectBakkesMod() == true)
                {

                }
                else
                {
                    MessageBox.Show("Failed to Inject DLL On process + " + listBox_Processes.SelectedItem.ToString());
                }

            }

            string processID = " -p " + listBox_Processes.SelectedItem.ToString();
            processID = processID.ToLower(); // no idea what causes this to be uppercase.
            Inject(botSelection, kickoff, minimap, monitoring, clock, debugger, debug_keys, processID);


            //if your reading this you're a cool dude for real.
            //I'm not a professional programmer -- If you want to improve the code do so. I make applications for myself, and if other people find benefit then thats all that matters.
            //Using a listbox instead of public <list>  It's Silly, but I kept running into a errors, for now this works fine, and is perfectly functional. If its not broken don't fix it!



            //This associates the Current running Bot process ID with the current Selected Rocket League instance. 
            //Because Marlbot spawns childrens processes this is neccessary. We need the "master" process ID so we can kill the children processes. 
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
                    listBox_BotPid.Items.RemoveAt(SelectedIndex);
                    listBox_BotPid.Items.Insert(SelectedIndex, BotPid);

                }
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenBrowser("https://github.com/MarlBurroW");


        }

        private void TimerCheckInjected_Tick(object sender, EventArgs e)
        {
            //Checks if any bots are running every 10 seconds

            if (CheckIfInjected() == true) //Check if any bot is running
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
            OpenBrowser("https://github.com/SkiffyMan");

        }

        private bool KillCurrentBot(string pid)
        {

            //kill Master process and children.
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
            int SelectedIndex = listBox_Processes.SelectedIndex;

            //If no process selected 
            if (SelectedIndex == -1)
            {
                MessageBox.Show("No Process selected...");
                return;
            }

            string CurrentBotPid = listBox_BotPid.Items[SelectedIndex].ToString();
            //Check if Bot that was running for selected rocket league instance is still running, if it is, then kill it.
            if (CurrentBotPid.Length > 2)
            {

                if (CheckIfPIDIsRunning(CurrentBotPid, "bot") == true)
                {
                    KillCurrentBot(CurrentBotPid);
                }
                else
                {
                    MessageBox.Show("No bot is currently running on this Rocket League Instance: PID = " + listBox_Processes.SelectedItem.ToString());
                    listBox_BotPid.Items.RemoveAt(SelectedIndex);
                    listBox_BotPid.Items.Insert(SelectedIndex, "1");
                    return;
                }

            }
            else
            {
                MessageBox.Show("No bot is currently running on this Rocket League Instance: PID = " + listBox_Processes.SelectedItem.ToString());
            }

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
        }

        private string Legendary(string args)
        {
            string line;
            string FullErrorLine = "";
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true; //You should set RedirectStandardOutput to true and read output before calling WaitForExit, 
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.FileName = "Legendary.exe";
            p.StartInfo.Arguments = args;
            p.Start();
            StreamReader myStreamReader = p.StandardError;

            while ((line = myStreamReader.ReadLine()) != null)
            {
                FullErrorLine = FullErrorLine + line;
            }
            p.WaitForExit();
            return FullErrorLine;
        }
        private string GetUserAccount()
        {
            try
            {
                string userName = Environment.UserName;
                string LegendaryUserDirectory = string.Format("C:\\Users\\{0}\\.config\\legendary\\user.json", userName);
                string text = System.IO.File.ReadAllText(LegendaryUserDirectory);
                Regex pattern = new Regex("\"displayName\": \"(.*)\"");
                var match = pattern.Match(text);
                if (match.Success)
                {
                    string _username = match.Groups[1].Value.ToString();
                    return _username;
                }
                return "";
            }
            catch (Exception z)
            {
                //MessageBox.Show(Convert.ToString(z));
                return "";
            }
            return "";

        }
        private void button9_Click(object sender, EventArgs e)
        {

            string outputSTD = Legendary("list");
            if (outputSTD.Contains("No saved credentials"))
            {
                MessageBox.Show("No Authenthicated accounts!");
            }

        }

        private void DeleteAccount()
        {
            string outputSTD = Legendary("auth --delete");

            if (outputSTD.Contains("User data deleted"))
            {
               // listBox_Usernames.Items.Clear();
               // MessageBox.Show("User deleted succesfully...");
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            //listBox_Usernames.Items.Clear();
            DeleteAccount();


            string _path = Directory.GetCurrentDirectory();
            string path = _path + "/Accounts/";
            int AmountOfAccounts = Directory.GetFiles(path).Length;
            
            string userName = Environment.UserName;
            string LegendaryUserDirectory = string.Format("C:\\Users\\{0}\\.config\\legendary\\user.json", userName);


            string outputSTD = Legendary("auth");

            if (outputSTD.Contains("Max retries exceeded with url"))
            {
                MessageBox.Show("API Rate Limited... Try again later");
                return;
            }
            if (outputSTD.Contains("switch to a different account"))
            {
                string _username = GetUserAccount();
                listBox_Usernames.Items.Add(_username);
                MessageBox.Show(string.Format("{0} Account is Authed. Ready To Launch.", _username));
            }
            listBox_Usernames.Items.Add(GetUserAccount());
            AmountOfAccounts = AmountOfAccounts += 1;
            string _temp = AmountOfAccounts.ToString();
            string path1 = path + string.Format(@"Account{0}.json", _temp);
            System.IO.File.Copy(LegendaryUserDirectory, path1);

            //we just assume it went well


            // string username = GetUserAccount();
            // listBox_Usernames.Items.Add(username);
            //MessageBox.Show(string.Format("{0} Account is Authed. Ready To Launch.", username));

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int SelectedIndex = listBox_Usernames.SelectedIndex;

            string _path = Directory.GetCurrentDirectory();
            string path = _path + "/Accounts/";
            string User = GetUserAccount();

            string userName = Environment.UserName;
            string LegendaryUserDirectory = string.Format("C:\\Users\\{0}\\.config\\legendary\\user.json", userName);

            //If No Account Was Selected 
            if (SelectedIndex == -1)
            {
                MessageBox.Show("Error. No Account Was Selected");
                return;
            }

            else //Switch json config For Legendary
            {
                SelectedIndex = SelectedIndex += 1;
                string SelectedIndexSTR = SelectedIndex.ToString();
                string path1 = string.Format("{0}Account{1}.json", path, SelectedIndexSTR);


                string Config = System.IO.File.ReadAllText(path1);
                //  System.IO.File.Copy(path1, LegendaryUserDirectory); //we cant copy because it already exists and file.replace makes a backup
                System.IO.File.WriteAllText(LegendaryUserDirectory, String.Empty);
                System.IO.File.WriteAllText(LegendaryUserDirectory, Config);

            }
            
            string outputSTD = Legendary("launch sugar --skip-version-check");

            if (outputSTD.Contains("No saved credentials"))
            {
                MessageBox.Show("No accounts are added. Please add an account");
            }
            else
            {
                MessageBox.Show(string.Format("Launching Rocket League for account: {0}", GetUserAccount()) + "\n" + "If you'd like to start another instance with another account. Press Delete Account, and then Add Account, and then launch.");
            }
        }

        private bool ImportGame()
        {
            string directory = System.IO.File.ReadAllText("rl.txt");
            string outputSTD = Legendary(string.Format("import Sugar {0}", directory));


            if (outputSTD.Contains("Game is already installed"))
            {
                MessageBox.Show("Game Ready...");
            }
            else
            {
                MessageBox.Show("Succesfully Imported Rocket League...");
            }
            return true;

        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("rl.txt") && new FileInfo("rl.txt").Length != 0)
            {
                DialogResult response = MessageBox.Show("Would you like to use previously found Rocket League Directory",
                                      "Directory Already Found", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    string directory = System.IO.File.ReadAllText("rl.txt");
                    textBox3.Text = directory;
                    ImportGame();
                    return;
                }
            }

            string folderPath = "";
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;


            // Always default to Folder Selection.
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                textBox3.Text = folderPath;
            }
            if (System.IO.File.Exists("rl.txt"))
            {
                System.IO.File.WriteAllText(@"rl.txt", "");
                System.IO.File.WriteAllText("rl.txt", folderPath);
            }
            else
            {
                System.IO.File.WriteAllText("rl.txt", folderPath);
            }
            ImportGame();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int SelectedIndex = listBox_Usernames.SelectedIndex;


            string _path = Directory.GetCurrentDirectory();
            string path = _path + "/Accounts/";
            int AmountOfAccounts = Directory.GetFiles(path).Length;

            if (SelectedIndex == -1)
            {
                MessageBox.Show("No account was selected.");
                return;

            }
            SelectedIndex = SelectedIndex += 1;
            string Account = path + string.Format("Account{0}.json", SelectedIndex.ToString());
            System.IO.File.Delete(Account);

            listBox_Usernames.Items.RemoveAt(listBox_Usernames.SelectedIndex);


            /*
            string outputSTD = Legendary("auth --delete");

            if (outputSTD.Contains("User data deleted"))
            {
                listBox_Usernames.Items.Clear();
                MessageBox.Show("User deleted succesfully...");
            }
            */

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenBrowser("https://github.com/derrod");
        }


        private void SetToggleKey(string newKey)
        {
            string oldKey = GetToggleKey();
            string text = System.IO.File.ReadAllText("config.json");
            text = text.Replace(oldKey, newKey);
            System.IO.File.WriteAllText("config.json", text);

        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            //ToggleKey();
        }

        private void comboBox_ToggleKeys_SelectedIndexChanged(object sender, EventArgs e)

        {
            int index = comboBox_ToggleKeys.SelectedIndex;
            string _Key = comboBox_ToggleKeys.Items[index].ToString();
            if (GetToggleKey() == _Key) //Keybind is already set to selected Key
            {
                //MessageBox.Show("This is already set keybind!");
                //pass this function 
            }
            else
            {
                SetToggleKey(_Key);
            }

        }

        private bool CheckForAccounts()
        {
            return true;
            /*
            string _username = GetUserAccount();
            if (_username.Length > 2)
            {
                listBox_Usernames.Items.Add(_username);
            }
            return true;
            */
        }
        private string ExtractUserInfo(string file)
        {
             string text = System.IO.File.ReadAllText(file);
            Regex pattern = new Regex("\"displayName\": \"(.*)\"");
            var match = pattern.Match(text);
            if (match.Success)
            {
                string _username = match.Groups[1].Value.ToString();
                return _username;
            }
            return "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ToggleKeySetLoad();




            //GET ALL USER ACCOUNTS
            int loop = 0;

            string _path = Directory.GetCurrentDirectory();
            string path = _path + "/Accounts/";
            //string User = GetUserAccount();

            string userName = Environment.UserName;
            string LegendaryUserDirectory = string.Format("C:\\Users\\{0}\\.config\\legendary\\user.json", userName);

            int AmountOfAccounts = Directory.GetFiles(path).Length;

            if(AmountOfAccounts > 0)
            {
                while(loop != AmountOfAccounts)
                {
                    loop += 1;
                    string _loop = loop.ToString();
                    string path1 = string.Format("{0}/Account{1}.json", path, _loop);
                    listBox_Usernames.Items.Add(ExtractUserInfo(path1));
                }    
            }


            //MessageBox.Show(AmountOfAccounts.ToString());

            /*
            if (User.Length > 2)
            {
                if(AccountsDirCheck() == true)
                {

                    DialogResult response = MessageBox.Show(string.Format("{0} Account was found. Would you like to add?",User),
                                            "Account Present", MessageBoxButtons.YesNo);
                    if (response == DialogResult.Yes)
                    {

                        path = path + "Account1.json";
                        System.IO.File.Copy(LegendaryUserDirectory, path);
                    }
                    else
                    {
                        return;
                    }

                 }
            else
                {
                    while(loop != AmountOfAccounts)
                    {
                        loop += 1;
                        MessageBox.Show("executing function");
                        string _loop = loop.ToString();
                        string path1 = string.Format("{0}/Account{1}.json", path, _loop);
                        listBox_Usernames.Items.Add(ExtractUserInfo(path1));
                    }
                }
            */
            
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenBrowser("https://github.com/xenmods");
        }

        private void button9_Click_2(object sender, EventArgs e)
        {

        }
    }
}
