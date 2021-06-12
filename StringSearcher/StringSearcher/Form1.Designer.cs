namespace StringSearcher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Text = new System.Windows.Forms.RichTextBox();
            this.button_LoadText = new System.Windows.Forms.Button();
            this.checkBox_Simulation = new System.Windows.Forms.CheckBox();
            this.button_SimulationStart = new System.Windows.Forms.Button();
            this.button_SimulationNextStep = new System.Windows.Forms.Button();
            this.button_SimulationRestart = new System.Windows.Forms.Button();
            this.textBox_Pattern = new System.Windows.Forms.RichTextBox();
            this.label_Message = new System.Windows.Forms.Label();
            this.panel_RobinKarpSimulation = new System.Windows.Forms.Panel();
            this.textBox_TextHash = new System.Windows.Forms.TextBox();
            this.richTextBox_TextHash = new System.Windows.Forms.RichTextBox();
            this.richTextBox_PatternHash = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_PatternHash = new System.Windows.Forms.TextBox();
            this.panel_steps = new System.Windows.Forms.Panel();
            this.pictureBox_time = new System.Windows.Forms.PictureBox();
            this.button_stop = new System.Windows.Forms.Button();
            this.comboBox_select_time = new System.Windows.Forms.ComboBox();
            this.button_play = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_RobinKarpSimulatoMessage = new System.Windows.Forms.Label();
            this.button_SetBlackText = new System.Windows.Forms.Button();
            this.button_example1 = new System.Windows.Forms.Button();
            this.button_example2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_RobinKarpSimulation.SuspendLayout();
            this.panel_steps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_time)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.Transparent;
            this.button_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Search.BackgroundImage")));
            this.button_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Location = new System.Drawing.Point(500, 6);
            this.button_Search.Margin = new System.Windows.Forms.Padding(2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(28, 27);
            this.button_Search.TabIndex = 3;
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_Text
            // 
            this.textBox_Text.BackColor = System.Drawing.Color.White;
            this.textBox_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Text.Location = new System.Drawing.Point(15, 56);
            this.textBox_Text.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Text.Name = "textBox_Text";
            this.textBox_Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textBox_Text.Size = new System.Drawing.Size(731, 232);
            this.textBox_Text.TabIndex = 2;
            this.textBox_Text.Text = "";
            // 
            // button_LoadText
            // 
            this.button_LoadText.Location = new System.Drawing.Point(741, 626);
            this.button_LoadText.Margin = new System.Windows.Forms.Padding(2);
            this.button_LoadText.Name = "button_LoadText";
            this.button_LoadText.Size = new System.Drawing.Size(105, 22);
            this.button_LoadText.TabIndex = 11;
            this.button_LoadText.Text = "Load Text";
            this.button_LoadText.UseVisualStyleBackColor = true;
            this.button_LoadText.Click += new System.EventHandler(this.button_LoadText_Click);
            // 
            // checkBox_Simulation
            // 
            this.checkBox_Simulation.AutoSize = true;
            this.checkBox_Simulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Simulation.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.checkBox_Simulation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(85)))));
            this.checkBox_Simulation.Location = new System.Drawing.Point(18, 369);
            this.checkBox_Simulation.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_Simulation.Name = "checkBox_Simulation";
            this.checkBox_Simulation.Size = new System.Drawing.Size(104, 27);
            this.checkBox_Simulation.TabIndex = 7;
            this.checkBox_Simulation.Text = "По шагам";
            this.checkBox_Simulation.UseVisualStyleBackColor = true;
            this.checkBox_Simulation.CheckedChanged += new System.EventHandler(this.checkBox_Simulation_CheckedChanged);
            // 
            // button_SimulationStart
            // 
            this.button_SimulationStart.Location = new System.Drawing.Point(2, 29);
            this.button_SimulationStart.Margin = new System.Windows.Forms.Padding(2);
            this.button_SimulationStart.Name = "button_SimulationStart";
            this.button_SimulationStart.Size = new System.Drawing.Size(63, 28);
            this.button_SimulationStart.TabIndex = 8;
            this.button_SimulationStart.Text = "Начать";
            this.button_SimulationStart.UseVisualStyleBackColor = true;
            this.button_SimulationStart.Click += new System.EventHandler(this.button_SimulationStart_Click);
            // 
            // button_SimulationNextStep
            // 
            this.button_SimulationNextStep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_SimulationNextStep.BackgroundImage")));
            this.button_SimulationNextStep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_SimulationNextStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SimulationNextStep.Location = new System.Drawing.Point(2, 61);
            this.button_SimulationNextStep.Margin = new System.Windows.Forms.Padding(2);
            this.button_SimulationNextStep.Name = "button_SimulationNextStep";
            this.button_SimulationNextStep.Size = new System.Drawing.Size(29, 22);
            this.button_SimulationNextStep.TabIndex = 9;
            this.button_SimulationNextStep.UseVisualStyleBackColor = true;
            this.button_SimulationNextStep.Click += new System.EventHandler(this.button_SimulationNextStep_Click);
            // 
            // button_SimulationRestart
            // 
            this.button_SimulationRestart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_SimulationRestart.BackgroundImage")));
            this.button_SimulationRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_SimulationRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SimulationRestart.Location = new System.Drawing.Point(35, 61);
            this.button_SimulationRestart.Margin = new System.Windows.Forms.Padding(2);
            this.button_SimulationRestart.Name = "button_SimulationRestart";
            this.button_SimulationRestart.Size = new System.Drawing.Size(27, 22);
            this.button_SimulationRestart.TabIndex = 10;
            this.button_SimulationRestart.UseVisualStyleBackColor = true;
            this.button_SimulationRestart.Click += new System.EventHandler(this.button_SimulationRestart_Click);
            // 
            // textBox_Pattern
            // 
            this.textBox_Pattern.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Pattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Pattern.Location = new System.Drawing.Point(30, 9);
            this.textBox_Pattern.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Pattern.Multiline = false;
            this.textBox_Pattern.Name = "textBox_Pattern";
            this.textBox_Pattern.Size = new System.Drawing.Size(455, 24);
            this.textBox_Pattern.TabIndex = 1;
            this.textBox_Pattern.Text = "";
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Location = new System.Drawing.Point(9, 630);
            this.label_Message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(0, 13);
            this.label_Message.TabIndex = 24;
            this.label_Message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_RobinKarpSimulation
            // 
            this.panel_RobinKarpSimulation.Controls.Add(this.textBox_TextHash);
            this.panel_RobinKarpSimulation.Controls.Add(this.richTextBox_TextHash);
            this.panel_RobinKarpSimulation.Controls.Add(this.richTextBox_PatternHash);
            this.panel_RobinKarpSimulation.Controls.Add(this.label4);
            this.panel_RobinKarpSimulation.Controls.Add(this.label3);
            this.panel_RobinKarpSimulation.Location = new System.Drawing.Point(364, 340);
            this.panel_RobinKarpSimulation.Margin = new System.Windows.Forms.Padding(2);
            this.panel_RobinKarpSimulation.Name = "panel_RobinKarpSimulation";
            this.panel_RobinKarpSimulation.Size = new System.Drawing.Size(339, 154);
            this.panel_RobinKarpSimulation.TabIndex = 28;
            // 
            // textBox_TextHash
            // 
            this.textBox_TextHash.Location = new System.Drawing.Point(94, 61);
            this.textBox_TextHash.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TextHash.Name = "textBox_TextHash";
            this.textBox_TextHash.ReadOnly = true;
            this.textBox_TextHash.Size = new System.Drawing.Size(76, 20);
            this.textBox_TextHash.TabIndex = 15;
            // 
            // richTextBox_TextHash
            // 
            this.richTextBox_TextHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox_TextHash.Location = new System.Drawing.Point(0, 93);
            this.richTextBox_TextHash.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_TextHash.Name = "richTextBox_TextHash";
            this.richTextBox_TextHash.ReadOnly = true;
            this.richTextBox_TextHash.Size = new System.Drawing.Size(337, 47);
            this.richTextBox_TextHash.TabIndex = 16;
            this.richTextBox_TextHash.Text = "";
            // 
            // richTextBox_PatternHash
            // 
            this.richTextBox_PatternHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox_PatternHash.Location = new System.Drawing.Point(2, 16);
            this.richTextBox_PatternHash.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_PatternHash.Name = "richTextBox_PatternHash";
            this.richTextBox_PatternHash.ReadOnly = true;
            this.richTextBox_PatternHash.Size = new System.Drawing.Size(336, 46);
            this.richTextBox_PatternHash.TabIndex = 14;
            this.richTextBox_PatternHash.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Хеш подстроки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Хеш шаблона:";
            // 
            // textBox_PatternHash
            // 
            this.textBox_PatternHash.Location = new System.Drawing.Point(458, 333);
            this.textBox_PatternHash.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_PatternHash.Name = "textBox_PatternHash";
            this.textBox_PatternHash.ReadOnly = true;
            this.textBox_PatternHash.Size = new System.Drawing.Size(76, 20);
            this.textBox_PatternHash.TabIndex = 13;
            // 
            // panel_steps
            // 
            this.panel_steps.Controls.Add(this.pictureBox_time);
            this.panel_steps.Controls.Add(this.button_stop);
            this.panel_steps.Controls.Add(this.comboBox_select_time);
            this.panel_steps.Controls.Add(this.button_play);
            this.panel_steps.Controls.Add(this.button_SimulationStart);
            this.panel_steps.Controls.Add(this.button_SimulationNextStep);
            this.panel_steps.Controls.Add(this.button_SimulationRestart);
            this.panel_steps.Location = new System.Drawing.Point(15, 399);
            this.panel_steps.Margin = new System.Windows.Forms.Padding(2);
            this.panel_steps.Name = "panel_steps";
            this.panel_steps.Size = new System.Drawing.Size(320, 96);
            this.panel_steps.TabIndex = 17;
            // 
            // pictureBox_time
            // 
            this.pictureBox_time.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_time.BackgroundImage")));
            this.pictureBox_time.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_time.ErrorImage = null;
            this.pictureBox_time.InitialImage = null;
            this.pictureBox_time.Location = new System.Drawing.Point(256, 4);
            this.pictureBox_time.Name = "pictureBox_time";
            this.pictureBox_time.Size = new System.Drawing.Size(23, 21);
            this.pictureBox_time.TabIndex = 31;
            this.pictureBox_time.TabStop = false;
            // 
            // button_stop
            // 
            this.button_stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_stop.BackgroundImage")));
            this.button_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stop.Location = new System.Drawing.Point(226, 35);
            this.button_stop.Margin = new System.Windows.Forms.Padding(2);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(27, 22);
            this.button_stop.TabIndex = 30;
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // comboBox_select_time
            // 
            this.comboBox_select_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_select_time.FormattingEnabled = true;
            this.comboBox_select_time.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x3"});
            this.comboBox_select_time.Location = new System.Drawing.Point(191, 4);
            this.comboBox_select_time.Name = "comboBox_select_time";
            this.comboBox_select_time.Size = new System.Drawing.Size(59, 21);
            this.comboBox_select_time.TabIndex = 29;
            this.comboBox_select_time.SelectedIndexChanged += new System.EventHandler(this.comboBox_select_time_SelectedIndexChanged);
            // 
            // button_play
            // 
            this.button_play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_play.BackgroundImage")));
            this.button_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_play.Location = new System.Drawing.Point(194, 34);
            this.button_play.Margin = new System.Windows.Forms.Padding(2);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(27, 22);
            this.button_play.TabIndex = 12;
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_Pattern);
            this.panel2.Controls.Add(this.button_Search);
            this.panel2.Location = new System.Drawing.Point(206, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 41);
            this.panel2.TabIndex = 18;
            // 
            // label_RobinKarpSimulatoMessage
            // 
            this.label_RobinKarpSimulatoMessage.AutoSize = true;
            this.label_RobinKarpSimulatoMessage.Location = new System.Drawing.Point(367, 307);
            this.label_RobinKarpSimulatoMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_RobinKarpSimulatoMessage.Name = "label_RobinKarpSimulatoMessage";
            this.label_RobinKarpSimulatoMessage.Size = new System.Drawing.Size(0, 13);
            this.label_RobinKarpSimulatoMessage.TabIndex = 27;
            // 
            // button_SetBlackText
            // 
            this.button_SetBlackText.Location = new System.Drawing.Point(632, 626);
            this.button_SetBlackText.Margin = new System.Windows.Forms.Padding(2);
            this.button_SetBlackText.Name = "button_SetBlackText";
            this.button_SetBlackText.Size = new System.Drawing.Size(105, 22);
            this.button_SetBlackText.TabIndex = 12;
            this.button_SetBlackText.Text = "Black Text";
            this.button_SetBlackText.UseVisualStyleBackColor = true;
            this.button_SetBlackText.Click += new System.EventHandler(this.button_SetBlackText_Click);
            // 
            // button_example1
            // 
            this.button_example1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(140)))), ((int)(((byte)(242)))));
            this.button_example1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_example1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_example1.ForeColor = System.Drawing.Color.White;
            this.button_example1.Location = new System.Drawing.Point(15, 340);
            this.button_example1.Name = "button_example1";
            this.button_example1.Size = new System.Drawing.Size(80, 23);
            this.button_example1.TabIndex = 30;
            this.button_example1.Text = "Пример 1";
            this.button_example1.UseVisualStyleBackColor = false;
            this.button_example1.Click += new System.EventHandler(this.button_example1_Click);
            // 
            // button_example2
            // 
            this.button_example2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(140)))), ((int)(((byte)(242)))));
            this.button_example2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_example2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_example2.ForeColor = System.Drawing.Color.White;
            this.button_example2.Location = new System.Drawing.Point(101, 340);
            this.button_example2.Name = "button_example2";
            this.button_example2.Size = new System.Drawing.Size(80, 23);
            this.button_example2.TabIndex = 31;
            this.button_example2.Text = "пример 2";
            this.button_example2.UseVisualStyleBackColor = false;
            this.button_example2.Click += new System.EventHandler(this.button_example2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(140)))), ((int)(((byte)(242)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(188, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 23);
            this.button4.TabIndex = 32;
            this.button4.Text = "пример 3";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(789, 506);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox_PatternHash);
            this.Controls.Add(this.button_example2);
            this.Controls.Add(this.button_example1);
            this.Controls.Add(this.button_SetBlackText);
            this.Controls.Add(this.checkBox_Simulation);
            this.Controls.Add(this.label_RobinKarpSimulatoMessage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_steps);
            this.Controls.Add(this.panel_RobinKarpSimulation);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.button_LoadText);
            this.Controls.Add(this.textBox_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(869, 698);
            this.Name = "MainForm";
            this.Text = "StringSearcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_RobinKarpSimulation.ResumeLayout(false);
            this.panel_RobinKarpSimulation.PerformLayout();
            this.panel_steps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_time)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.RichTextBox textBox_Text;
        private System.Windows.Forms.Button button_LoadText;
        private System.Windows.Forms.Button button_SimulationStart;
        private System.Windows.Forms.Button button_SimulationNextStep;
        private System.Windows.Forms.Button button_SimulationRestart;
        private System.Windows.Forms.RichTextBox textBox_Pattern;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Panel panel_RobinKarpSimulation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox_TextHash;
        private System.Windows.Forms.RichTextBox richTextBox_PatternHash;
        private System.Windows.Forms.TextBox textBox_TextHash;
        private System.Windows.Forms.TextBox textBox_PatternHash;
        private System.Windows.Forms.Panel panel_steps;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_RobinKarpSimulatoMessage;
        private System.Windows.Forms.Button button_SetBlackText;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.ComboBox comboBox_select_time;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.CheckBox checkBox_Simulation;
        private System.Windows.Forms.PictureBox pictureBox_time;
        private System.Windows.Forms.Button button_example1;
        private System.Windows.Forms.Button button_example2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
    }
}

