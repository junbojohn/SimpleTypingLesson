using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class All_keys_option : Form
    {
        public All_keys_option()
        {
            InitializeComponent();
        }

        
        // Button that takes user back to main menu screen
        private void Back_Button_Click(object sender, EventArgs e)
        {
            var menu = new Main_Menu();
            menu.Show();

            this.Hide();
        }

        // Button that starts 'All_keys' lesson with setting given
        private void Start_Button_Click(object sender, EventArgs e)
        {
            // check if the given setting input('typeAmount' variable) is valid to start lesson with
            //https://stackoverflow.com/questions/11634079/how-can-i-get-the-data-type-of-a-variable-in-c

            // if the given setting input('typeAmount') is invalid(either it's empty, not integer,
            // less than 50, or more than 200, print error message.
            //https://stackoverflow.com/questions/894263/identify-if-a-string-is-a-number
            if (!int.TryParse(typeAmount.Text, out int result) || typeAmount.Text == null || Int32.Parse(typeAmount.Text) < 50 || Int32.Parse(typeAmount.Text) > 200)
            {
                errorMsg.Text = "Please input a valid amount";
            }

            else if (Int32.Parse(typeAmount.Text) >= 50 && Int32.Parse(typeAmount.Text) <= 200)
            {
                var all = new All_keys(Int32.Parse(typeAmount.Text));
                all.Show();

                this.Hide();
            }
        }
        
    }
}
