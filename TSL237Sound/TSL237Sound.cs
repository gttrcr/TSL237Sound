using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace A5000
{
    public partial class LTS237Sound : Form
    {
        List<Note> note = new List<Note>();
        
        //private static readonly double l = 0.5;
        //private static readonly double h = 0.3;
        //private static readonly double d = 5;
        //private static readonly double DELTA = 2.3 * 1000; //7.74; //2.3 * 1000;
        //private static readonly double OMEGA = 4 * Math.Asin(l * h / (Math.Sqrt((Math.Pow(l, 2) + 4 * Math.Pow(d, 2)) * (Math.Pow(h, 2) + 4 * Math.Pow(d, 2)))));
        //private static readonly double CONST = Math.Pow(10, 10) / (683 * OMEGA * DELTA);
        
        int noteSuonate = 0;

        public LTS237Sound()
        {
            InitializeComponent();
            DoubleClick += Form1_DoubleClick;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            BackColor = DefaultBackColor;
            FormBorderStyle = FormBorderStyle.Sizable;
            richTextBox_sheet.Visible = true;
            comboBox_time.Visible = true;
            textBox_bpm.Visible = true;
            button_play.Visible = true;
            button_test.Visible = true;
            timer_bpm.Stop();
            noteSuonate = 0;
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            string notaNonTrovata = string.Empty;
            try
            {
                double bpm = 0;
                double.TryParse(textBox_bpm.Text, out bpm);
                timer_bpm.Interval = (int)Math.Round(60000 / bpm);
                string[] musicSheet = richTextBox_sheet.Text.ToUpper().Split('\n');
                note.Clear();
                noteSuonate = 0;
                foreach (string musicSheetString in musicSheet)
                {
                    notaNonTrovata = musicSheetString.Split(' ')[1];
                    Note nota = new Note();
                    nota.Durata = double.Parse(musicSheetString.Split(' ')[0].Split('/')[0]) / double.Parse(musicSheetString.Split(' ')[0].Split('/')[1]);
                    nota.Nome = notaNonTrovata;
                    note.Add(nota);
                }
                richTextBox_sheet.Visible = false;
                comboBox_time.Visible = false;
                textBox_bpm.Visible = false;
                button_play.Visible = false;
                button_test.Visible = false;
                FormBorderStyle = FormBorderStyle.None;
                timer_bpm.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(notaNonTrovata + ": " + ex.Message);
            }
        }

        private double Yreal(string nota)
        {
            double frequenza = 0;
            string notaTagliata = nota.Substring(0, nota.Length - 1);
            switch (notaTagliata)
                {
                case "DO":
                    frequenza = 261.6;
                    break;
                case "DO#":
                case "REb":
                    frequenza = 277.2;
                    break;
                case "RE":
                    frequenza = 293.7;
                    break;
                case "RE#":
                case "MIb":
                    frequenza = 331.1;
                    break;
                case "MI":
                    frequenza = 329.6;
                    break;
                case "FA":
                    frequenza = 349.2;
                    break;
                case "FA#":
                case "SOLb":
                    frequenza = 370.0;
                    break;
                case "SOL":
                    frequenza = 392.0;
                    break;
                case "SOL#":
                case "LAb":
                    frequenza = 415.3;
                    break;
                case "LA":
                    frequenza = 440;
                    break;
                case "LA#":
                case "SIb":
                    frequenza = 466.2;
                    break;
                case "SI":
                    frequenza = 493.9;
                    break;
            }
            int ottava = int.Parse(nota.Substring(nota.Length - 1, 1));
            frequenza = frequenza * Math.Pow(2, ottava - 4);
            return frequenza;
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            string test = "1/4 DO2\n1/4 RE2\n1/4 MI2\n1/4 DO2\n1/4 DO2\n1/4 RE2\n1/4 MI2\n1/4 DO2\n1/4 MI2\n1/4 FA2\n1/4 SOL2\n1/4 SOL2\n1/4 MI2\n1/4 FA2\n1/4 SOL2\n1/4 SOL2";
            richTextBox_sheet.Text = test;
            textBox_bpm.Text = "60";
            comboBox_time.SelectedItem = "4/4";
        }

        private void bpm_Tick(object sender, EventArgs e)
        {
            try
            {
                /*double Y = 0;
                double Yreale = Yreal(note[noteSuonate].Nome);
                double r = 0;
                double g = 0;
                double b = 0;

                for (r = 0; r < 255; r++)
                {
                    for (g = 0; g < 255; g++)
                    {
                        for (b = 0; b < 255; b++)
                        {
                            Y = 0.2126 * r + 0.7152 * g + 0.0722 * b;
                            if (Math.Abs(Y - Yreale) < 100000000) goto To;
                        }
                    }
                }*/

                //To:
                Random rnd = new Random();
                //int R = rnd.Next(255);
                //int G = rnd.Next(255);
                //int B = rnd.Next(255);
                //this.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                //this.BackColor = Color.FromArgb((int)r, (int)g, (int)b);

                if (noteSuonate == note.Count())
                {
                    BackColor = Color.FromArgb(234, 123, 70);
                    FormBorderStyle = FormBorderStyle.Sizable;
                    richTextBox_sheet.Visible = true;
                    comboBox_time.Visible = true;
                    textBox_bpm.Visible = true;
                    button_play.Visible = true;
                    button_test.Visible = true;
                    timer_bpm.Stop();
                    noteSuonate = 0;
                }

                BackColor = Color.FromArgb((int)Yreal(note[noteSuonate].Nome), (int)Yreal(note[noteSuonate].Nome), (int)Yreal(note[noteSuonate].Nome));
                
                noteSuonate++;
            }
            catch (Exception) { }
        }
    }
}