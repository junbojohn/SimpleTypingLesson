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
    public partial class Basic_3 : Form
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

        public Basic_3(int inputAmount)
        {
            InitializeComponent();

            this.inputAmount = inputAmount;
        }

        private void Basic_3_Load(object sender, EventArgs e)
        {
            keySets = new char[8];
            targetInputs = new char[inputAmount];
            rng = new Random();

            errors = 0;
            entries = 0;
            checkStart = false;
            finished = false;
            tracker = new Stopwatch();

            keySets[0] = 'z';
            keySets[1] = 'x';
            keySets[2] = 'c';
            keySets[3] = 'v';
            keySets[4] = 'n';
            keySets[5] = 'm';
            keySets[6] = ',';
            keySets[7] = '.';

            for (int i = 0; i < targetInputs.Count(); i++)
            {
                rand = rng.Next(8);

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

        private void Basic_3_KeyPress(object sender, KeyPressEventArgs e)
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

                        var result = new Lesson_result("Basic_3", targetInputs.Count(), entries, errors, accuracy, Time_Track.Text, wpm);
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
