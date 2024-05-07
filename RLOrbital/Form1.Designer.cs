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
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            checkBox_SpeedFlip = new CheckBox();
            checkBox_Debugger = new CheckBox();
            checkBox_BotMonitor = new CheckBox();
            checkBox_DebugKeys = new CheckBox();
            checkBox_BotMiniMap = new CheckBox();
            checkBox_Clock = new CheckBox();
            label4 = new Label();
            button2 = new Button();
            label3 = new Label();
            comboBotSelection = new ComboBox();
            LabelInjected = new Label();
            button1 = new Button();
            label1 = new Label();
            listBox_Processes = new ListBox();
            tabPage2 = new TabPage();
            label6 = new Label();
            linkLabel2 = new LinkLabel();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            TimerCheckInjected = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-1, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(313, 415);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(comboBotSelection);
            tabPage1.Controls.Add(LabelInjected);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(listBox_Processes);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(305, 387);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main";
            tabPage1.UseVisualStyleBackColor = true;

            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(237, 343);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(100, 96);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox_SpeedFlip);
            panel1.Controls.Add(checkBox_Debugger);
            panel1.Controls.Add(checkBox_BotMonitor);
            panel1.Controls.Add(checkBox_DebugKeys);
            panel1.Controls.Add(checkBox_BotMiniMap);
            panel1.Controls.Add(checkBox_Clock);
            panel1.Location = new Point(9, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 98);
            panel1.TabIndex = 14;
            // 
            // checkBox_SpeedFlip
            // 
            checkBox_SpeedFlip.AutoSize = true;
            checkBox_SpeedFlip.Location = new Point(3, 3);
            checkBox_SpeedFlip.Name = "checkBox_SpeedFlip";
            checkBox_SpeedFlip.Size = new Size(125, 19);
            checkBox_SpeedFlip.TabIndex = 4;
            checkBox_SpeedFlip.Text = "Speed Flip Kick Off";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 310);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 10;
            label4.Text = "Status: ";
            // 
            // button2
            // 
            button2.Location = new Point(190, 169);
            button2.Name = "button2";
            button2.Size = new Size(106, 23);
            button2.TabIndex = 9;
            button2.Text = "Start Bot";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 9);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 6;
            label3.Text = "Select Bot";
            // 
            // comboBotSelection
            // 
            comboBotSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBotSelection.FormattingEnabled = true;
            comboBotSelection.Items.AddRange(new object[] { "Nexto", "Necto", "Element", "Seer V4" });
            comboBotSelection.Location = new Point(86, 27);
            comboBotSelection.Name = "comboBotSelection";
            comboBotSelection.Size = new Size(121, 23);
            comboBotSelection.TabIndex = 5;
            // 
            // LabelInjected
            // 
            LabelInjected.AutoSize = true;
            LabelInjected.ForeColor = Color.Red;
            LabelInjected.Location = new Point(219, 310);
            LabelInjected.Name = "LabelInjected";
            LabelInjected.Size = new Size(75, 15);
            LabelInjected.TabIndex = 3;
            LabelInjected.Text = "Not Running";
            // 
            // button1
            // 
            button1.Location = new Point(6, 167);
            button1.Name = "button1";
            button1.Size = new Size(106, 25);
            button1.TabIndex = 2;
            button1.Text = "Find Processes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 195);
            label1.Name = "label1";
            label1.Size = new Size(223, 15);
            label1.TabIndex = 1;
            label1.Text = "Current Rocket League Processes Active: ";
            // 
            // listBox_Processes
            // 
            listBox_Processes.FormattingEnabled = true;
            listBox_Processes.ItemHeight = 15;
            listBox_Processes.Location = new Point(6, 213);
            listBox_Processes.Name = "listBox_Processes";
            listBox_Processes.Size = new Size(290, 94);
            listBox_Processes.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(linkLabel2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(linkLabel1);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(305, 387);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Credits";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 54);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 4;
            label6.Text = "My Github -";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(107, 54);
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
            label5.Location = new Point(89, 30);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 2;
            label5.Text = "Marlbot 1.6.0";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(198, 15);
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
            label2.Location = new Point(38, 15);
            label2.Name = "label2";
            label2.Size = new Size(154, 15);
            label2.TabIndex = 0;
            label2.Text = "Marlburrow for RL Marlbot: ";
            // 
            // TimerCheckInjected
            // 
            TimerCheckInjected.Interval = 10000;
            TimerCheckInjected.Tick += TimerCheckInjected_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 353);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Orbital V1.0.2";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button button2;
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
        private RichTextBox richTextBox1;
    }
}
