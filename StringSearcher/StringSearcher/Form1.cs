using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringSearcher
{
    public partial class MainForm : Form
    {
        RabinKarpSearcher rabin_karp_searcher;
        RabinKarpSearcherSimulator rabin_karp_simulator;
        bool bySteps = false;
        List<int> start_indexes;

        public MainForm()
        {
            //komponente
            InitializeComponent();

            comboBox_select_time.SelectedIndex = 0;

            button_SimulationStart.Visible = false;
            button_SimulationNextStep.Visible = false;
            button_SimulationRestart.Visible = false;
            panel_RobinKarpSimulation.Visible = false;
            button_play.Visible = false;
            button_stop.Visible = false;
            pictureBox_time.Visible = false;
            comboBox_select_time.Visible = false;

            button_Search.TabStop = false;
            button_Search.FlatStyle = FlatStyle.Flat;
            button_Search.FlatAppearance.BorderSize = 0;

            button_SimulationNextStep.TabStop = false;
            button_SimulationNextStep.FlatStyle = FlatStyle.Flat;
            button_SimulationNextStep.FlatAppearance.BorderSize = 0;

            button_SimulationRestart.TabStop = false;
            button_SimulationRestart.FlatStyle = FlatStyle.Flat;
            button_SimulationRestart.FlatAppearance.BorderSize = 0;


            rabin_karp_searcher = new RabinKarpSearcher();

            rabin_karp_simulator = new RabinKarpSearcherSimulator(textBox_Pattern, textBox_Text, richTextBox_PatternHash, richTextBox_TextHash, textBox_PatternHash, textBox_TextHash, label_RobinKarpSimulatoMessage);
     
           start_indexes = new List<int>();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (textBox_Pattern.Text.Length > textBox_Text.Text.Length)
            {
                MessageBox.Show("Шаблон должен быть короче текста", "Ошибка");
                return;
            }
            if (textBox_Pattern.Text.Length == 0 || textBox_Text.Text.Length == 0)
            {
                MessageBox.Show("Пожалуйста, заполните поля", "Ошибка");
                return;
            }

            start_indexes = rabin_karp_searcher.Search(textBox_Pattern.Text, textBox_Text.Text);
            textBox_Text.Select(0, textBox_Text.Text.Length);
            textBox_Text.SelectionColor = Color.Black;

            foreach (int index in start_indexes)
            {
                textBox_Text.Select(index, textBox_Pattern.Text.Length);
                textBox_Text.SelectionColor = Color.Red;
            }

            label_Message.Text = "Найдено: " + start_indexes.Count.ToString() + " подходит";

            rabin_karp_searcher.ClearIndexes();
            start_indexes.Clear();
        }

        /// <summary>
        ///     Otvara se file dialog u kome moze da se selektuje tekstualni dokument
        ///     tekstualni dokument se ucitava i sluzi kao tekst u kome se trazi pojavljivanje pattern-a
        /// </summary>
        private void button_LoadText_Click(object sender, EventArgs e)
        {
            OpenFileDialog file_dialog = new OpenFileDialog();
            file_dialog.Filter = "text files| *.txt";

            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                textBox_Text.Text = System.IO.File.ReadAllText(file_dialog.FileName);
            }

            textBox_Text.Select(0, textBox_Text.Text.Length);
            textBox_Text.SelectionColor = Color.Black;
        }


        private void button_SimulationStart_Click(object sender, EventArgs e)
        {

            bySteps = true;
            if (textBox_Pattern.Text.Length > textBox_Text.Text.Length)
            {
                MessageBox.Show("Шаблон должен быть короче текста","Ошибка");
                return;
            }
            if (textBox_Pattern.Text.Length == 0 || textBox_Text.Text.Length==0)
            {
                MessageBox.Show("Пожалуйста, заполните поля", "Ошибка");
                return;
            }
        
            checkBox_Simulation.Enabled = false;

            button_SimulationStart.Visible = false;
            button_SimulationNextStep.Visible = true;
            button_SimulationRestart.Visible = true;

            button_SetBlackText.Visible = false;

            textBox_Pattern.ReadOnly = true;
            textBox_Text.ReadOnly = true;

            label_Message.Text = "Симулятор запущен.";

            rabin_karp_simulator.SetPatternAndText();
            rabin_karp_simulator.Prepare();
        }

        private void button_SimulationRestart_Click(object sender, EventArgs e)
        {

            bySteps = false;
            checkBox_Simulation.Enabled = true;

            button_SimulationStart.Visible = true;
            button_SimulationNextStep.Visible = false;
            button_SimulationRestart.Visible = false;

            button_SetBlackText.Visible = true;

            textBox_Pattern.ReadOnly = false;
            textBox_Text.ReadOnly = false;

            label_Message.Text = "Симулятор остановлен.";

            rabin_karp_simulator.Reset();
        }

        private void button_SimulationNextStep_Click(object sender, EventArgs e)
        {
            rabin_karp_simulator.NextStep();
        }

        private void checkBox_Simulation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Simulation.Checked)
            {
                textBox_Text.Select(0, textBox_Text.Text.Length);
                textBox_Text.SelectionColor = Color.Black;
                panel_RobinKarpSimulation.Visible = true;
                button_Search.Visible = false;
                button_SimulationStart.Visible = true;
                button_SimulationNextStep.Visible = true;
                button_SimulationRestart.Visible = true;
                button_play.Visible = true;
                button_stop.Visible = true;
                pictureBox_time.Visible = true;
                comboBox_select_time.Visible = true;
                label_Message.Text = "Please enter pattern and text before starting the simulation. To start simulation press Start button.";
            }
            else
            {
                button_SimulationNextStep.Visible = false;
                bySteps = false;
                button_SimulationRestart.Visible = false;
                button_play.Visible = false;
                button_stop.Visible = false;
                pictureBox_time.Visible = false;
                comboBox_select_time.Visible = false;
                panel_RobinKarpSimulation.Visible = false;
                button_Search.Visible = true;
                button_SimulationStart.Visible = false;
                label_Message.Text = "";
            }
        }

        private void button_SetBlackText_Click(object sender, EventArgs e)
        {
            textBox_Text.Select(0, textBox_Text.Text.Length);
            textBox_Text.SelectionColor = Color.Black;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button_example1_Click(object sender, EventArgs e)
        {
            textBox_Pattern.Text = Examples.pattern1;
            textBox_Text.Text = Examples.text1;
        }

        private void button_example2_Click(object sender, EventArgs e)
        {
            textBox_Pattern.Text = Examples.pattern2;
            textBox_Text.Text = Examples.text2;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {   
                rabin_karp_simulator.NextStep();
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            if (bySteps) { 
            timer1.Enabled = true;
        }
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void comboBox_select_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox_select_time.SelectedIndex;
            switch (index)
            {
                case 0:
                    timer1.Interval = 500;
                    break;
                case 1:
                    timer1.Interval = 100;
                    break;
                case 2:
                    timer1.Interval = 50;
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_Pattern.Text = Examples.pattern3;
            textBox_Text.Text = Examples.text3;
        }
    }
}
