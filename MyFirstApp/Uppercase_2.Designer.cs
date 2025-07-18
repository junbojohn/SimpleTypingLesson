
namespace MyFirstApp
{
    partial class Uppercase_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Uppercase_2_objective = new System.Windows.Forms.Label();
            this.current_target = new System.Windows.Forms.Label();
            this.next_1 = new System.Windows.Forms.Label();
            this.next_2 = new System.Windows.Forms.Label();
            this.try_again = new System.Windows.Forms.Label();
            this.Error_Display = new System.Windows.Forms.Label();
            this.Error_Count = new System.Windows.Forms.Label();
            this.Time_Display = new System.Windows.Forms.Label();
            this.Time_Track = new System.Windows.Forms.Label();
            this.finish_msg = new System.Windows.Forms.Label();
            this.Return_Menu = new System.Windows.Forms.Label();
            this.Update_Stopwatch = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Uppercase_2_objective
            // 
            this.Uppercase_2_objective.AutoSize = true;
            this.Uppercase_2_objective.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uppercase_2_objective.Location = new System.Drawing.Point(238, 21);
            this.Uppercase_2_objective.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Uppercase_2_objective.Name = "Uppercase_2_objective";
            this.Uppercase_2_objective.Size = new System.Drawing.Size(473, 50);
            this.Uppercase_2_objective.TabIndex = 0;
            this.Uppercase_2_objective.Text = "Current Lesson: qwer(Left) and uiopRight).\r\n*BOTH UPPER AND LOWERCASE WILL APPEAR" +
    "*";
            this.Uppercase_2_objective.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // current_target
            // 
            this.current_target.AutoSize = true;
            this.current_target.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_target.Location = new System.Drawing.Point(419, 120);
            this.current_target.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.current_target.Name = "current_target";
            this.current_target.Size = new System.Drawing.Size(47, 46);
            this.current_target.TabIndex = 1;
            this.current_target.Text = "A";
            this.current_target.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // next_1
            // 
            this.next_1.AutoSize = true;
            this.next_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_1.Location = new System.Drawing.Point(524, 136);
            this.next_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.next_1.Name = "next_1";
            this.next_1.Size = new System.Drawing.Size(34, 25);
            this.next_1.TabIndex = 2;
            this.next_1.Text = "n1";
            this.next_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // next_2
            // 
            this.next_2.AutoSize = true;
            this.next_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_2.Location = new System.Drawing.Point(624, 136);
            this.next_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.next_2.Name = "next_2";
            this.next_2.Size = new System.Drawing.Size(34, 25);
            this.next_2.TabIndex = 3;
            this.next_2.Text = "n2";
            this.next_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // try_again
            // 
            this.try_again.AutoSize = true;
            this.try_again.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.try_again.Location = new System.Drawing.Point(324, 184);
            this.try_again.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.try_again.Name = "try_again";
            this.try_again.Size = new System.Drawing.Size(205, 25);
            this.try_again.TabIndex = 4;
            this.try_again.Text = "Wrong key. Try again!";
            this.try_again.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Error_Display
            // 
            this.Error_Display.AutoSize = true;
            this.Error_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Display.Location = new System.Drawing.Point(355, 229);
            this.Error_Display.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Error_Display.Name = "Error_Display";
            this.Error_Display.Size = new System.Drawing.Size(102, 20);
            this.Error_Display.TabIndex = 5;
            this.Error_Display.Text = "No. of Errors:";
            this.Error_Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Error_Count
            // 
            this.Error_Count.AutoSize = true;
            this.Error_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Count.Location = new System.Drawing.Point(470, 229);
            this.Error_Count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Error_Count.Name = "Error_Count";
            this.Error_Count.Size = new System.Drawing.Size(20, 20);
            this.Error_Count.TabIndex = 6;
            this.Error_Count.Text = "N";
            this.Error_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Time_Display
            // 
            this.Time_Display.AutoSize = true;
            this.Time_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Display.Location = new System.Drawing.Point(355, 260);
            this.Time_Display.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Time_Display.Name = "Time_Display";
            this.Time_Display.Size = new System.Drawing.Size(109, 20);
            this.Time_Display.TabIndex = 7;
            this.Time_Display.Text = "Time Elapsed:";
            this.Time_Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Time_Track
            // 
            this.Time_Track.AutoSize = true;
            this.Time_Track.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Track.Location = new System.Drawing.Point(478, 260);
            this.Time_Track.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Time_Track.Name = "Time_Track";
            this.Time_Track.Size = new System.Drawing.Size(20, 20);
            this.Time_Track.TabIndex = 8;
            this.Time_Track.Text = "N";
            this.Time_Track.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finish_msg
            // 
            this.finish_msg.AutoSize = true;
            this.finish_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish_msg.Location = new System.Drawing.Point(374, 378);
            this.finish_msg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.finish_msg.Name = "finish_msg";
            this.finish_msg.Size = new System.Drawing.Size(140, 22);
            this.finish_msg.TabIndex = 9;
            this.finish_msg.Text = "Lesson finished.";
            // 
            // Return_Menu
            // 
            this.Return_Menu.AutoSize = true;
            this.Return_Menu.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Return_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_Menu.Location = new System.Drawing.Point(771, 370);
            this.Return_Menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Return_Menu.Name = "Return_Menu";
            this.Return_Menu.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.Return_Menu.Size = new System.Drawing.Size(131, 38);
            this.Return_Menu.TabIndex = 10;
            this.Return_Menu.Text = "Back to Menu";
            this.Return_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Return_Menu.Click += new System.EventHandler(this.Return_Menu_Click);
            // 
            // Update_Stopwatch
            // 
            this.Update_Stopwatch.Enabled = true;
            this.Update_Stopwatch.Interval = 10;
            this.Update_Stopwatch.Tick += new System.EventHandler(this.Update_Stopwatch_Tick);
            // 
            // Uppercase_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 415);
            this.Controls.Add(this.Return_Menu);
            this.Controls.Add(this.finish_msg);
            this.Controls.Add(this.Time_Track);
            this.Controls.Add(this.Time_Display);
            this.Controls.Add(this.Error_Count);
            this.Controls.Add(this.Error_Display);
            this.Controls.Add(this.try_again);
            this.Controls.Add(this.next_2);
            this.Controls.Add(this.next_1);
            this.Controls.Add(this.current_target);
            this.Controls.Add(this.Uppercase_2_objective);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Uppercase_2";
            this.RightToLeftLayout = true;
            this.Text = "Uppercase_2";
            this.Load += new System.EventHandler(this.Num_keys_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num_keys_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Uppercase_2_objective;
        private System.Windows.Forms.Label current_target;
        private System.Windows.Forms.Label next_1;
        private System.Windows.Forms.Label next_2;
        private System.Windows.Forms.Label try_again;
        private System.Windows.Forms.Label Error_Display;
        private System.Windows.Forms.Label Error_Count;
        private System.Windows.Forms.Label Time_Display;
        private System.Windows.Forms.Label Time_Track;
        private System.Windows.Forms.Label finish_msg;
        private System.Windows.Forms.Label Return_Menu;
        private System.Windows.Forms.Timer Update_Stopwatch;
    }
}