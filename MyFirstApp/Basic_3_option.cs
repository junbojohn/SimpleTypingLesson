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
    public partial class Basic_3_option : Form
    {
        public Basic_3_option()
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

        // Button that starts Basic_1 lesson with setting given
        private void Start_Button_Click(object sender, EventArgs e)
        {
            // check if the given setting input('typeAmount' variable) is valid to start lesson with
            //https://stackoverflow.com/questions/11634079/how-can-i-get-the-data-type-of-a-variable-in-c

            // if the given setting input('typeAmount') is invalid(either it's empty, not integer,
            // less than 50, or more than 200, print error message.
            if (Int32.Parse(typeAmount.Text).GetType() != typeof(int) || typeAmount.Text == null || Int32.Parse(typeAmount.Text) < 50 || Int32.Parse(typeAmount.Text) > 200)
            {
                errorMsg.Text = "Please input a valid amount";
            }

            else if (Int32.Parse(typeAmount.Text) >= 50 && Int32.Parse(typeAmount.Text) <= 200)
            {
                var b3 = new Basic_3(Int32.Parse(typeAmount.Text));
                b3.Show();

                this.Hide();
            }
        }
        
    }
}
