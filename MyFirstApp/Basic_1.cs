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
    public partial class Basic_1 : Form
    {
        private char[] keySets; //set of keys
        private char[] targetInputs; //set of inputs for lesson
        private int inputAmount;
        private int rand; //hold randomly generate number to grab elements from 'KeySets'
        private Random rng;//RNG used to generate number used for index of 'rand'
        private int current_index;

        private int errors; //count number of errors user made
        private int entries; //count total number of types that user made
        private bool checkStart; //check if user has started typing. Used to start stopwatch.
        private bool finished; //check if user has completed the lesson. Used to stop the stopwatch.
        private Stopwatch tracker; //used to track the time it takes for user to complete the lesson.

        //Timer (1000 milliseconds = 1 second)
        //https://docs.microsoft.com/en-us/dotnet/api/system.timers.timer?view=net-6.0
        //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.timer?view=windowsdesktop-6.0
        //https://www.youtube.com/watch?v=98c200lL-OY


        //DO NOT USE TIMER. TIMER COUNTS HOW MANY TIMES ARE LEFT.
        //Stopwatch. This one is used for tracking how long it will take.
        //https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch?view=net-6.0
        //https://www.youtube.com/watch?v=O0kkq9-FWn4


        //Formula for calculating WPM(words per minute)
        //https://www.speedtypingonline.com/typing-equations#:~:text=Simply%20count%20all%20typed%20entries,)%20%2F%200.5%20%3D%2080%20WPM.



        public Basic_1(int inputAmount)
        {
            InitializeComponent();

            this.inputAmount = inputAmount;
        }

        private void Basic_1_Load(object sender, EventArgs e)
        {
            // initiate variables that will be used for generating set of key
            // inputs for lesson.
            keySets = new char[8];
            targetInputs = new char[inputAmount];
            rng = new Random();


            // Set values to variables that will be used for tracking records
            errors = 0;
            entries = 0;
            checkStart = false;
            finished = false;
            tracker = new Stopwatch();


            // Create set of keys that will be used to 
            // generate set of inputs for users to work with
            keySets[0] = 'a';
            keySets[1] = 's';
            keySets[2] = 'd';
            keySets[3] = 'f';
            keySets[4] = 'j';
            keySets[5] = 'k';
            keySets[6] = 'l';
            keySets[7] = ';';

            // Create set of inputs for user to work with on lesson.
            // Set changes everytime when user starts lesson.
            for (int i = 0; i < targetInputs.Count(); i++)
            {
                rand = rng.Next(8);

                targetInputs[i] = keySets[rand];
            }


            // keyboard input messages in the form
            //http://csharp.net-informations.com/gui/key-press-cs.htm#:~:text=Windows%20Forms%20processes%20keyboard%20input,by%20handling%20the%20keyboard%20events.&text=You%20can%20detect%20most%20physical,the%20KeyDown%20or%20KeyUp%20events.

            current_index = 0;

            current_target.Text = targetInputs[current_index].ToString();
            next_1.Text = targetInputs[current_index + 1].ToString();
            next_2.Text = targetInputs[current_index + 2].ToString();

            finish_msg.Text = "";
            try_again.Text = "";
            Error_Count.Text = errors.ToString();
        }

        private void Basic_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // While the lesson is not completed, keep detecting inputs
            // Once it's finished. Do nothing.
            if (current_index < targetInputs.Count())
            {
                // If user typed correct key
                if (e.KeyChar == targetInputs[current_index])
                {
                    // check if error message appeared before or not.
                    // if yes, get rid of it
                    if (try_again.Text != "")
                    {
                        try_again.Text = "";
                    }

                    // increment index of targetInputs array so that next key
                    // can be brought up for the user to type
                    current_index++;


                    // increment 'entries' to count the number of types
                    // that user entered.
                    entries++;


                    // this if statement is used to check if the last target key
                    // that user typed is the last one. If it is last one,
                    // go to else statement to print the message saying
                    // that the lesson is finished.
                    if (current_index < targetInputs.Count())
                    {
                        // Display next key to type
                        current_target.Text = targetInputs[current_index].ToString();


                        // Display next key No. 1
                        // if current key is last one to type,
                        // simply display empty
                        if ((current_index + 1) < targetInputs.Count())
                        {
                            next_1.Text = targetInputs[current_index + 1].ToString();
                        }

                        else if ((current_index + 1) >= targetInputs.Count())
                        {
                            next_1.Text = "";
                        }


                        // Display next key No. 2
                        // if next key is last one to type,
                        // simply display empty
                        if ((current_index + 2) < targetInputs.Count())
                        {
                            next_2.Text = targetInputs[current_index + 2].ToString();
                        }

                        else if ((current_index + 2) >= targetInputs.Count())
                        {
                            next_2.Text = "";
                        }
                    }

                    // Once the user entered last key, Print message to let them
                    // know that the lesson has finished.
                    // Then, set finished to true so that the stopwatch
                    // can be stopped.
                    else
                    {
                        tracker.Stop();
                        checkStart = false;
                        finished = true;
                        finish_msg.Text = "Lesson Finished.";


                        /*
                        targetInputs.Count()
                        entries
                        errors
                        (calculate accuracy in separate formula)
                        Time_Track.Text
                        (calculate wpm in separate formula)
                        */


                        //https://stackoverflow.com/questions/50731479/c-sharp-percentage-calculation-explanation
                        double entries_d = Convert.ToDouble(entries);
                        double errors_d = Convert.ToDouble(errors);
                        double calculate_accuracy = (entries_d - errors_d) / entries_d;
                        double accuracy = Math.Round(100 * calculate_accuracy, 2);


                        //https://stackoverflow.com/questions/4177332/convert-stopwatch-to-int
                        //https://docs.microsoft.com/en-us/dotnet/api/system.math.round?view=net-6.0
                        double wpm = Math.Round((entries / 5) / tracker.Elapsed.TotalMinutes, 2);


                        var result = new Lesson_result("Basic_1", targetInputs.Count(), entries, errors, accuracy, Time_Track.Text, wpm);
                        result.Show();
                    }
                }

                // If wrong key input is detected,
                // increment both 'errors' and 'entries'
                // varies to count the number of errors that user
                // made and the number of types user entered.
                // Then tell them to try again.
                else
                {
                    errors++;
                    entries++;
                    try_again.Text = "Wrong key. Try again!";
                }

                // While lesson is going on, keep the stopwatch going.
                if (checkStart != true && finished != true)
                {
                    checkStart = true;
                }
            }

            Error_Count.Text = errors.ToString();

            // Once the user starts typing(whether getting right or wrong for first time),
            // The stopwatch will start to track how long will it take for user
            // to finish the lesson.
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
