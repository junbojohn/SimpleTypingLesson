using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class Uppercase_2 : Form
    {
        private char[] keySets;
        private char[] targetInputs;
        private int inputAmount;
        private int rand;
        private Random rng;
        private int current_index;

        private int errors;
        private int entries;
        private bool checkStart;
        private bool finished;
        private Stopwatch tracker;

        public Uppercase_2(int inputAmount)
        {
            InitializeComponent();

            this.inputAmount = inputAmount;
        }

        private void Uppercase_2_Load(object sender, EventArgs e)
        {
            keySets = new char[16];
            targetInputs = new char[inputAmount];
            rng = new Random();

            errors = 0;
            entries = 0;
            checkStart = false;
            finished = false;
            tracker = new Stopwatch();

            keySets[0] = 'q';
            keySets[1] = 'w';
            keySets[2] = 'e';
            keySets[3] = 'r';
            keySets[4] = 'u';
            keySets[5] = 'i';
            keySets[6] = 'o';
            keySets[7] = 'p';

            keySets[8] = 'Q';
            keySets[9] = 'W';
            keySets[10] = 'E';
            keySets[11] = 'R';
            keySets[12] = 'U';
            keySets[13] = 'I';
            keySets[14] = 'O';
            keySets[15] = 'P';

            for (int i = 0; i < targetInputs.Count(); i++)
            {
                rand = rng.Next(16);

                targetInputs[i] = keySets[rand];
            }

            current_index = 0;

            current_target.Text = targetInputs[current_index].ToString();
            next_1.Text = targetInputs[current_index + 1].ToString();
            next_2.Text = targetInputs[current_index + 2].ToString();

            finish_msg.Text = "";
            try_again.Text = "";
            Error_Count.Text = errors.ToString();
        }

        private void Uppercase_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (current_index < targetInputs.Count())
            {
                if (e.KeyChar == targetInputs[current_index])
                {
                    if (try_again.Text != "")
                    {
                        try_again.Text = "";
                    }

                    current_index++;
                    entries++;

                    if (current_index < targetInputs.Count())
                    {
                        current_target.Text = targetInputs[current_index].ToString();


                        if ((current_index + 1) < targetInputs.Count())
                        {
                            next_1.Text = targetInputs[current_index + 1].ToString();
                        }

                        else if ((current_index + 1) >= targetInputs.Count())
                        {
                            next_1.Text = "";
                        }


                        if ((current_index + 2) < targetInputs.Count())
                        {
                            next_2.Text = targetInputs[current_index + 2].ToString();
                        }

                        else if ((current_index + 2) >= targetInputs.Count())
                        {
                            next_2.Text = "";
                        }
                    }

                    else
                    {
                        tracker.Stop();
                        checkStart = false;
                        finished = true;
                        finish_msg.Text = "Lesson Finished.";

                        double entries_d = Convert.ToDouble(entries);
                        double errors_d = Convert.ToDouble(errors);
                        double calculate_accuracy = (entries_d - errors_d) / entries_d;
                        double accuracy = Math.Round(100 * calculate_accuracy, 2);

                        double wpm = Math.Round((entries / 5) / tracker.Elapsed.TotalMinutes, 2);

                        var result = new Lesson_result("Num_keys", targetInputs.Count(), entries, errors, accuracy, Time_Track.Text, wpm);
                        result.Show();
                    }
                }

                else
                {
                    errors++;
                    entries++;
                    try_again.Text = "Wrong key. Try again!";
                }

                if (checkStart != true && finished != true)
                {
                    checkStart = true;
                }
            }

            Error_Count.Text = errors.ToString();


            if (checkStart == true)
            {
                tracker.Start();
            }
        }

        private void Return_Menu_Click(object sender, EventArgs e)
        {
            var menu = new Main_Menu();
            menu.Show();

            this.Close();
        }

        private void Update_Stopwatch_Tick(object sender, EventArgs e)
        {
            Time_Track.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", tracker.Elapsed);
        }
    }
}
