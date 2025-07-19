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
    public partial class All_keys : Form
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

        public All_keys(int inputAmount)
        {
            InitializeComponent();

            this.inputAmount = inputAmount;
        }

        private void All_keys_Load(object sender, EventArgs e)
        {
            keySets = new char[58];
            targetInputs = new char[inputAmount];
            rng = new Random();

            errors = 0;
            entries = 0;
            checkStart = false;
            finished = false;
            tracker = new Stopwatch();

            //lowercases
            keySets[0] = 'a';
            keySets[1] = 's';
            keySets[2] = 'd';
            keySets[3] = 'f';
            keySets[4] = 'j';
            keySets[5] = 'k';
            keySets[6] = 'l';
            keySets[7] = ';';

            keySets[8] = 'q';
            keySets[9] = 'w';
            keySets[10] = 'e';
            keySets[11] = 'r';
            keySets[12] = 'u';
            keySets[13] = 'i';
            keySets[14] = 'o';
            keySets[15] = 'p';

            keySets[16] = 'z';
            keySets[17] = 'x';
            keySets[18] = 'c';
            keySets[19] = 'v';
            keySets[20] = 'n';
            keySets[21] = 'm';
            keySets[22] = ',';
            keySets[23] = '.';

            keySets[24] = 'g';
            keySets[25] = 'h';
            keySets[26] = 't';
            keySets[27] = 'y';
            keySets[28] = 'b';

            //uppercases
            keySets[29] = 'A';
            keySets[30] = 'S';
            keySets[31] = 'D';
            keySets[32] = 'F';
            keySets[33] = 'J';
            keySets[34] = 'K';
            keySets[35] = 'L';
            keySets[36] = ':';

            keySets[37] = 'Q';
            keySets[38] = 'W';
            keySets[39] = 'E';
            keySets[40] = 'R';
            keySets[41] = 'U';
            keySets[42] = 'I';
            keySets[43] = 'O';
            keySets[44] = 'P';

            keySets[45] = 'Z';
            keySets[46] = 'X';
            keySets[47] = 'C';
            keySets[48] = 'V';
            keySets[49] = 'N';
            keySets[50] = 'M';
            keySets[51] = '<';
            keySets[52] = '>';

            keySets[53] = 'G';
            keySets[54] = 'H';
            keySets[55] = 'T';
            keySets[56] = 'Y';
            keySets[57] = 'B';

            for (int i = 0; i < targetInputs.Count(); i++)
            {
                rand = rng.Next(58);

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

        private void All_keys_KeyPress(object sender, KeyPressEventArgs e)
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
