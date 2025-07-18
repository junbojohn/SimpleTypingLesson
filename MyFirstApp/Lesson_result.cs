using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class Lesson_result : Form
    {
        /*
        Length of the lesson: 120 types
        Your total types:
        No. of errors you made:
        Accuracy: 
        Total time: 
        WPM(Words Per Minute):

        targetInputs.Count()
        entries
        errors
        (calculate accuracy in separate formula)
        Time_Track.Text
        (calculate wpm in separate formula)
        */
        string lesson_type;
        int lesson_length;
        int total_types;
        int errors_made;
        double accuracy;
        string total_time;
        double wpm;

        //pass these in
        //int lesson_length, int total_types, int errors_made, double accuracy, string total_time, double wpm
        public Lesson_result(string lesson_type, int lesson_length, int total_types, int errors_made, double accuracy, string total_time, double wpm)
        {
            InitializeComponent();

            this.lesson_type = lesson_type;
            this.lesson_length = lesson_length;
            this.total_types = total_types;
            this.errors_made = errors_made;
            this.accuracy = accuracy;
            this.total_time = total_time;
            this.wpm = wpm;
        }

        private void Basic_1_result_Load(object sender, EventArgs e)
        {
            Length_value.Text = lesson_length.ToString();
            Total_types_value.Text = total_types.ToString();
            Errors_value.Text = errors_made.ToString();
            Accuracy_value.Text = accuracy.ToString() + "%";
            WPM_value.Text = wpm.ToString();

            Time_value.Text = total_time;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_record_Click(object sender, EventArgs e)
        {
            // Create directory to save files
            //https://docs.microsoft.com/en-us/dotnet/api/system.io.directory.createdirectory?view=net-6.0


            // Create main directory that will store records of different lessons
            string records_directory = @"C:\Typing_lesson_records";

            if (!Directory.Exists(records_directory))
            {
                DirectoryInfo di1 = Directory.CreateDirectory(records_directory);
            }

            // Create specific directory based on lesson type to store its record 
            string lesson_records_directory = @"C:\Typing_lesson_records\" + lesson_type;

            if (!Directory.Exists(lesson_records_directory))
            {
                DirectoryInfo di2 = Directory.CreateDirectory(lesson_records_directory);
            }


            // Date and time
            //https://docs.microsoft.com/en-us/dotnet/api/system.datetime.now?view=net-6.0
            //https://stackoverflow.com/questions/13178752/current-date-without-time

            DateTime lesson_date = DateTime.Now;
            string[] paths = { lesson_records_directory, string.Format("{0:yyyy\\-MM\\-dd\\-hh\\-mm\\-ss}", lesson_date) + ".txt" };


            // Stream Writer
            //https://docs.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/read-write-text-file

            // Create new text file with StreamWriter on specific directory that program newly created
            //https://docs.microsoft.com/en-us/dotnet/api/system.io.path.combine?redirectedfrom=MSDN&view=net-6.0#System_IO_Path_Combine_System_String_System_String_
            //https://stackoverflow.com/questions/7348768/the-given-paths-format-is-not-supported


            StreamWriter record = new StreamWriter(Path.Combine(paths));

            record.WriteLine("Date and time of lesson taken: " + lesson_date.ToString());
            record.WriteLine("Lesson: " + lesson_type);
            record.WriteLine("Lenght of the lesson: " + lesson_length);
            record.WriteLine("Your total types: " + total_types);
            record.WriteLine("No. of errors you made: " + errors_made);
            record.WriteLine("Total time: " + total_time);
            //record.WriteLine();

            record.Close();

            save_notify.Text = "Record is saved in: C:\\Typing_lesson_records\\" + lesson_type;
        }
    }
}
