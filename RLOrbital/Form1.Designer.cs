namespace Orbital_V1._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button9 = new Button();
            label9 = new Label();
            listBox_BotPid = new ListBox();
            comboBox_ToggleKeys = new ComboBox();
            button_StopBot = new Button();
            button7 = new Button();
            textBox2 = new TextBox();
            button6 = new Button();
            richTextBox1 = new RichTextBox();
            button5 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            checkBox1_BakkesMod = new CheckBox();
            checkBox_SpeedFlip = new CheckBox();
            checkBox_Debugger = new CheckBox();
            checkBox_BotMonitor = new CheckBox();
            checkBox_DebugKeys = new CheckBox();
            checkBox_BotMiniMap = new CheckBox();
            checkBox_Clock = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            LabelInjected = new Label();
            label3 = new Label();
            comboBotSelection = new ComboBox();
            label1 = new Label();
            listBox_Processes = new ListBox();
            tabPage3 = new TabPage();
            richTextBox3 = new RichTextBox();
            button12 = new Button();
            button11 = new Button();
            listBox_Usernames = new ListBox();
            button10 = new Button();
            richTextBox2 = new RichTextBox();
            label7 = new Label();
            button8 = new Button();
            textBox3 = new TextBox();
            tabPage2 = new TabPage();
            linkLabel4 = new LinkLabel();
            label10 = new Label();
            linkLabel3 = new LinkLabel();
            label8 = new Label();
            label6 = new Label();
            linkLabel2 = new LinkLabel();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            button3 = new Button();
            TimerCheckInjected = new System.Windows.Forms.Timer(components);
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-1, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(385, 530);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button9);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(listBox_BotPid);
            tabPage1.Controls.Add(comboBox_ToggleKeys);
            tabPage1.Controls.Add(button_StopBot);
            tabPage1.Controls.Add(button7);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(LabelInjected);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(comboBotSelection);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(listBox_Processes);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(377, 502);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(144, 280);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 27;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click_2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(211, 12);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 26;
            label9.Text = "Toggle Key";
            // 
            // listBox_BotPid
            // 
            listBox_BotPid.FormattingEnabled = true;
            listBox_BotPid.ItemHeight = 15;
            listBox_BotPid.Items.AddRange(new object[] { "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1" });
            listBox_BotPid.Location = new Point(329, 406);
            listBox_BotPid.Name = "listBox_BotPid";
            listBox_BotPid.Size = new Size(98, 79);
            listBox_BotPid.TabIndex = 24;
            // 
            // comboBox_ToggleKeys
            // 
            comboBox_ToggleKeys.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_ToggleKeys.DropDownWidth = 150;
            comboBox_ToggleKeys.FormattingEnabled = true;
            comboBox_ToggleKeys.Items.AddRange(new object[] { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Escape", "SpaceBar", "PageUp", "PageDown", "End", "Home", "Insert", "Delete", "LeftShift", "RightShift", "LeftControl", "RightControl", "LeftAlt", "RightAlt", "LeftCommand", "RightCommand", "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "LeftMouseButton", "RightMouseButton", "MiddleMouseButton", "ThumbMouseButton", "ThumbMouseButton2" });
            comboBox_ToggleKeys.Location = new Point(178, 30);
            comboBox_ToggleKeys.Name = "comboBox_ToggleKeys";
            comboBox_ToggleKeys.Size = new Size(131, 23);
            comboBox_ToggleKeys.TabIndex = 25;
            comboBox_ToggleKeys.SelectedIndexChanged += comboBox_ToggleKeys_SelectedIndexChanged;
            // 
            // button_StopBot
            // 
            button_StopBot.Location = new Point(178, 347);
            button_StopBot.Name = "button_StopBot";
            button_StopBot.Size = new Size(131, 23);
            button_StopBot.TabIndex = 23;
            button_StopBot.Text = "Stop Bot";
            button_StopBot.UseVisualStyleBackColor = true;
            button_StopBot.Click += button_StopBot_Click;
            // 
            // button7
            // 
            button7.Location = new Point(51, 406);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 22;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 422);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 21;
            // 
            // button6
            // 
            button6.Location = new Point(306, 406);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 20;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(292, 445);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(147, 37);
            richTextBox1.TabIndex = 19;
            richTextBox1.Text = "";
            // 
            // button5
            // 
            button5.Location = new Point(290, 472);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 18;
            button5.Text = "Inject Bakkes Mod";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(203, 473);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 17;
            button4.Text = "Kill";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 473);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 23);
            textBox1.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox1_BakkesMod);
            panel1.Controls.Add(checkBox_SpeedFlip);
            panel1.Controls.Add(checkBox_Debugger);
            panel1.Controls.Add(checkBox_BotMonitor);
            panel1.Controls.Add(checkBox_DebugKeys);
            panel1.Controls.Add(checkBox_BotMiniMap);
            panel1.Controls.Add(checkBox_Clock);
            panel1.Location = new Point(16, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 128);
            panel1.TabIndex = 14;
            // 
            // checkBox1_BakkesMod
            // 
            checkBox1_BakkesMod.AutoSize = true;
            checkBox1_BakkesMod.Location = new Point(3, 106);
            checkBox1_BakkesMod.Name = "checkBox1_BakkesMod";
            checkBox1_BakkesMod.Size = new Size(87, 19);
            checkBox1_BakkesMod.TabIndex = 14;
            checkBox1_BakkesMod.Text = "BakkesMod";
            checkBox1_BakkesMod.UseVisualStyleBackColor = true;
            // 
            // checkBox_SpeedFlip
            // 
            checkBox_SpeedFlip.AutoSize = true;
            checkBox_SpeedFlip.Location = new Point(3, 3);
            checkBox_SpeedFlip.Name = "checkBox_SpeedFlip";
            checkBox_SpeedFlip.Size = new Size(117, 19);
            checkBox_SpeedFlip.TabIndex = 4;
            checkBox_SpeedFlip.Text = "SpeedFlip Kickoff";
            checkBox_SpeedFlip.UseVisualStyleBackColor = true;
            // 
            // checkBox_Debugger
            // 
            checkBox_Debugger.AutoSize = true;
            checkBox_Debugger.Location = new Point(190, 73);
            checkBox_Debugger.Name = "checkBox_Debugger";
            checkBox_Debugger.Size = new Size(78, 19);
            checkBox_Debugger.TabIndex = 13;
            checkBox_Debugger.Text = "Debugger";
            checkBox_Debugger.UseVisualStyleBackColor = true;
            // 
            // checkBox_BotMonitor
            // 
            checkBox_BotMonitor.AutoSize = true;
            checkBox_BotMonitor.Location = new Point(3, 38);
            checkBox_BotMonitor.Name = "checkBox_BotMonitor";
            checkBox_BotMonitor.Size = new Size(107, 19);
            checkBox_BotMonitor.TabIndex = 7;
            checkBox_BotMonitor.Text = "Bot Monitoring";
            checkBox_BotMonitor.UseVisualStyleBackColor = true;
            // 
            // checkBox_DebugKeys
            // 
            checkBox_DebugKeys.AutoSize = true;
            checkBox_DebugKeys.Location = new Point(190, 38);
            checkBox_DebugKeys.Name = "checkBox_DebugKeys";
            checkBox_DebugKeys.Size = new Size(88, 19);
            checkBox_DebugKeys.TabIndex = 12;
            checkBox_DebugKeys.Text = "Debug Keys";
            checkBox_DebugKeys.UseVisualStyleBackColor = true;
            // 
            // checkBox_BotMiniMap
            // 
            checkBox_BotMiniMap.AutoSize = true;
            checkBox_BotMiniMap.Location = new Point(3, 73);
            checkBox_BotMiniMap.Name = "checkBox_BotMiniMap";
            checkBox_BotMiniMap.Size = new Size(179, 19);
            checkBox_BotMiniMap.TabIndex = 8;
            checkBox_BotMiniMap.Text = "Bot MiniMap (CPU Intensive)";
            checkBox_BotMiniMap.UseVisualStyleBackColor = true;
            // 
            // checkBox_Clock
            // 
            checkBox_Clock.AutoSize = true;
            checkBox_Clock.Location = new Point(190, 3);
            checkBox_Clock.Name = "checkBox_Clock";
            checkBox_Clock.Size = new Size(56, 19);
            checkBox_Clock.TabIndex = 11;
            checkBox_Clock.Text = "Clock";
            checkBox_Clock.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(94, 201);
            button1.Name = "button1";
            button1.Size = new Size(131, 24);
            button1.TabIndex = 2;
            button1.Text = "Find Processes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(19, 347);
            button2.Name = "button2";
            button2.Size = new Size(131, 23);
            button2.TabIndex = 9;
            button2.Text = "Start Bot";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 377);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 10;
            label4.Text = "Status: ";
            // 
            // LabelInjected
            // 
            LabelInjected.AutoSize = true;
            LabelInjected.ForeColor = Color.Red;
            LabelInjected.Location = new Point(232, 377);
            LabelInjected.Name = "LabelInjected";
            LabelInjected.Size = new Size(75, 15);
            LabelInjected.TabIndex = 3;
            LabelInjected.Text = "Not Running";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 12);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 6;
            label3.Text = "Select Bot";
            // 
            // comboBotSelection
            // 
            comboBotSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBotSelection.FormattingEnabled = true;
            comboBotSelection.Items.AddRange(new object[] { "Nexto", "NextMortal", "Necto", "Element", "Seer V4" });
            comboBotSelection.Location = new Point(19, 30);
            comboBotSelection.Name = "comboBotSelection";
            comboBotSelection.Size = new Size(131, 23);
            comboBotSelection.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 228);
            label1.Name = "label1";
            label1.Size = new Size(223, 15);
            label1.TabIndex = 1;
            label1.Text = "Current Rocket League Processes Active: ";
            // 
            // listBox_Processes
            // 
            listBox_Processes.FormattingEnabled = true;
            listBox_Processes.ItemHeight = 15;
            listBox_Processes.Location = new Point(19, 246);
            listBox_Processes.Name = "listBox_Processes";
            listBox_Processes.Size = new Size(290, 94);
            listBox_Processes.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(richTextBox3);
            tabPage3.Controls.Add(button12);
            tabPage3.Controls.Add(button11);
            tabPage3.Controls.Add(listBox_Usernames);
            tabPage3.Controls.Add(button10);
            tabPage3.Controls.Add(richTextBox2);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(377, 502);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Launcher";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(-4, 416);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(326, 80);
            richTextBox3.TabIndex = 9;
            richTextBox3.Text = "";
            // 
            // button12
            // 
            button12.Location = new Point(107, 335);
            button12.Name = "button12";
            button12.Size = new Size(123, 23);
            button12.TabIndex = 8;
            button12.Text = "Launch";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.Location = new Point(107, 364);
            button11.Name = "button11";
            button11.Size = new Size(123, 23);
            button11.TabIndex = 7;
            button11.Text = "Delete Account";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // listBox_Usernames
            // 
            listBox_Usernames.FormattingEnabled = true;
            listBox_Usernames.ItemHeight = 15;
            listBox_Usernames.Location = new Point(0, 50);
            listBox_Usernames.Name = "listBox_Usernames";
            listBox_Usernames.Size = new Size(330, 244);
            listBox_Usernames.TabIndex = 6;
            // 
            // button10
            // 
            button10.Location = new Point(107, 306);
            button10.Name = "button10";
            button10.Size = new Size(123, 23);
            button10.TabIndex = 5;
            button10.Text = "Add Account";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(-4, 398);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(332, 101);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 3);
            label7.Name = "label7";
            label7.Size = new Size(135, 15);
            label7.TabIndex = 2;
            label7.Text = "Rocket League Directory";
            // 
            // button8
            // 
            button8.Location = new Point(294, 21);
            button8.Name = "button8";
            button8.Size = new Size(37, 23);
            button8.TabIndex = 1;
            button8.Text = "...";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(0, 21);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(288, 23);
            textBox3.TabIndex = 0;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(linkLabel4);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(linkLabel3);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(linkLabel2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(linkLabel1);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(377, 502);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Credits";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new Point(124, 90);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(45, 15);
            linkLabel4.TabIndex = 9;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "GitHub";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 90);
            label10.Name = "label10";
            label10.Size = new Size(119, 15);
            label10.TabIndex = 8;
            label10.Text = "Xen for NextMortal - ";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(182, 65);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(43, 15);
            linkLabel3.TabIndex = 7;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Github";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 65);
            label8.Name = "label8";
            label8.Size = new Size(175, 15);
            label8.TabIndex = 6;
            label8.Text = "Derrod for Legenday Launcher -";
            label8.Click += label8_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 39);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 4;
            label6.Text = "My Github -";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(78, 39);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(43, 15);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Github";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 13);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 2;
            label5.Text = "Marlbot 1.6.0";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(169, 13);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(43, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Github";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 13);
            label2.Name = "label2";
            label2.Size = new Size(159, 15);
            label2.TabIndex = 0;
            label2.Text = "Marlburrow for RL Marlbot: -";
            // 
            // button3
            // 
            button3.Location = new Point(408, 398);
            button3.Name = "button3";
            button3.Size = new Size(130, 23);
            button3.TabIndex = 15;
            button3.Text = "Stop Bot";
            button3.UseVisualStyleBackColor = true;
            // 
            // TimerCheckInjected
            // 
            TimerCheckInjected.Interval = 10000;
            TimerCheckInjected.Tick += TimerCheckInjected_Tick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 419);
            Controls.Add(tabControl1);
            Controls.Add(button3);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Orbital V1.0.8";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListBox listBox_Processes;
        private TabPage tabPage2;
        private Label LabelInjected;
        private Button button1;
        private Label label1;
        private Label label3;
        private ComboBox comboBotSelection;
        private CheckBox checkBox_SpeedFlip;
        private CheckBox checkBox_BotMiniMap;
        private CheckBox checkBox_BotMonitor;
        private Label label4;
        private LinkLabel linkLabel1;
        private Label label2;
        private System.Windows.Forms.Timer TimerCheckInjected;
        private Label label5;
        private Panel panel1;
        private CheckBox checkBox_Debugger;
        private CheckBox checkBox_DebugKeys;
        private CheckBox checkBox_Clock;
        private Label label6;
        private LinkLabel linkLabel2;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
        private Button button5;
        private CheckBox checkBox1_BakkesMod;
        private Button button7;
        private TextBox textBox2;
        private Button button6;
        private RichTextBox richTextBox1;
        private Button button_StopBot;
        private ListBox listBox_BotPid;
        private TabPage tabPage3;
        private Button button8;
        private TextBox textBox3;
        private OpenFileDialog openFileDialog1;
        private Label label7;
        private RichTextBox richTextBox2;
        private Button button10;
        private Button button12;
        private Button button11;
        private ListBox listBox_Usernames;
        private RichTextBox richTextBox3;
        private Label label8;
        private LinkLabel linkLabel3;
        private Label label9;
        private ComboBox comboBox_ToggleKeys;
        private LinkLabel linkLabel4;
        private Label label10;
        private Button button9;
    }
}
