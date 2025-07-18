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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        //private void btnClickThis_Click(object sender, EventArgs e)
        //{
        //    lblHelloWorld.Text = "Hello World.";
        //}


        // How to remove functions when accidentally clicked them on design UI
        //https://stackoverflow.com/questions/12160770/removing-click-method-from-windows-form-application


        // Guide articles about tools from toolboxes
        //http://csharp.net-informations.com/gui/cs_forms.htm


        // Button for 'Basic 1' lesson
        private void Basic_1_Click(object sender, EventArgs e)
        {
            // To call another form and hide main menu form
            //https://stackoverflow.com/questions/15041382/opening-a-window-form-from-another-form-programmatically


            // To create new form:
            // Simply right click on 'MyFirstApp' project, Add new item,
            // Windows Forms, then add 'Form (Windows Forms)'

            //var b1 = new Basic_1();
            //b1.Show();

            var b1 = new Basic_1_option();
            b1.Show();

            this.Hide();
        }

        // Exit button
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            // Closing application
            //https://www.c-sharpcorner.com/UploadFile/c713c3/how-to-exit-in-C-Sharp/

            //System.Windows.Forms.Application.Exit();
            //Application.ExitThread(); //not certain about this one
            Application.Exit();
        }

        private void testing_form_Click(object sender, EventArgs e)
        {
            var test = new Testing_form();
            test.Show();

            this.Hide();
        }

        private void B2_btn_Click(object sender, EventArgs e)
        {
            //var b2 = new Basic_2();
            //b2.Show();

            var b2 = new Basic_2_option();
            b2.Show();

            this.Hide();
        }

        private void B3_btn_Click(object sender, EventArgs e)
        {
            var b3 = new Basic_3_option();
            b3.Show();

            this.Hide();
        }

        private void Num_btn_Click(object sender, EventArgs e)
        {
            var num = new Num_keys_option();
            num.Show();

            this.Hide();
        }
    }
}
