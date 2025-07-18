
namespace MyFirstApp
{
    partial class Main_Menu
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
            this.Menu_Title = new System.Windows.Forms.Label();
            this.B1_btn = new System.Windows.Forms.Button();
            this.B1_desc = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Exit_desc = new System.Windows.Forms.Label();
            this.testing_form = new System.Windows.Forms.Button();
            this.B2_btn = new System.Windows.Forms.Button();
            this.B2_desc = new System.Windows.Forms.Label();
            this.B3_btn = new System.Windows.Forms.Button();
            this.B3_desc = new System.Windows.Forms.Label();
            this.Num_btn = new System.Windows.Forms.Button();
            this.Num_desc = new System.Windows.Forms.Label();
            this.UC1_btn = new System.Windows.Forms.Button();
            this.UC1_desc = new System.Windows.Forms.Label();
            this.UC2_btn = new System.Windows.Forms.Button();
            this.UC2_desc = new System.Windows.Forms.Label();
            this.UC3_btn = new System.Windows.Forms.Button();
            this.UC3_desc = new System.Windows.Forms.Label();
            this.ALL_btn = new System.Windows.Forms.Button();
            this.ALL_desc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Menu_Title
            // 
            this.Menu_Title.AutoSize = true;
            this.Menu_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Title.Location = new System.Drawing.Point(296, 23);
            this.Menu_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Menu_Title.Name = "Menu_Title";
            this.Menu_Title.Size = new System.Drawing.Size(300, 29);
            this.Menu_Title.TabIndex = 1;
            this.Menu_Title.Text = "The typing lesson program\r\n";
            // 
            // B1_btn
            // 
            this.B1_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1_btn.Location = new System.Drawing.Point(89, 69);
            this.B1_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.B1_btn.Name = "B1_btn";
            this.B1_btn.Size = new System.Drawing.Size(110, 28);
            this.B1_btn.TabIndex = 2;
            this.B1_btn.Text = "Basic 1";
            this.B1_btn.UseVisualStyleBackColor = true;
            this.B1_btn.Click += new System.EventHandler(this.Basic_1_Click);
            // 
            // B1_desc
            // 
            this.B1_desc.AutoSize = true;
            this.B1_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1_desc.Location = new System.Drawing.Point(225, 72);
            this.B1_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.B1_desc.Name = "B1_desc";
            this.B1_desc.Size = new System.Drawing.Size(420, 20);
            this.B1_desc.TabIndex = 3;
            this.B1_desc.Text = "Practice typing basic homerows \'asdf\'(Left) and \'jkl;\'(Right).";
            // 
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Exit_btn.Location = new System.Drawing.Point(89, 448);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(110, 28);
            this.Exit_btn.TabIndex = 4;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Exit_desc
            // 
            this.Exit_desc.AutoSize = true;
            this.Exit_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_desc.Location = new System.Drawing.Point(224, 451);
            this.Exit_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exit_desc.Name = "Exit_desc";
            this.Exit_desc.Size = new System.Drawing.Size(129, 20);
            this.Exit_desc.TabIndex = 5;
            this.Exit_desc.Text = "Exit the program.";
            // 
            // testing_form
            // 
            this.testing_form.Location = new System.Drawing.Point(832, 456);
            this.testing_form.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.testing_form.Name = "testing_form";
            this.testing_form.Size = new System.Drawing.Size(88, 21);
            this.testing_form.TabIndex = 6;
            this.testing_form.Text = "Test keys";
            this.testing_form.UseVisualStyleBackColor = true;
            this.testing_form.Click += new System.EventHandler(this.testing_form_Click);
            // 
            // B2_btn
            // 
            this.B2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2_btn.Location = new System.Drawing.Point(89, 115);
            this.B2_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.B2_btn.Name = "B2_btn";
            this.B2_btn.Size = new System.Drawing.Size(110, 28);
            this.B2_btn.TabIndex = 7;
            this.B2_btn.Text = "Basic 2";
            this.B2_btn.UseVisualStyleBackColor = true;
            this.B2_btn.Click += new System.EventHandler(this.B2_btn_Click);
            // 
            // B2_desc
            // 
            this.B2_desc.AutoSize = true;
            this.B2_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2_desc.Location = new System.Drawing.Point(225, 118);
            this.B2_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.B2_desc.Name = "B2_desc";
            this.B2_desc.Size = new System.Drawing.Size(417, 20);
            this.B2_desc.TabIndex = 8;
            this.B2_desc.Text = "Practice typing different rows \'qwer\'(Left) and \'uiop\'(Right).";
            // 
            // B3_btn
            // 
            this.B3_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3_btn.Location = new System.Drawing.Point(89, 162);
            this.B3_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.B3_btn.Name = "B3_btn";
            this.B3_btn.Size = new System.Drawing.Size(110, 28);
            this.B3_btn.TabIndex = 9;
            this.B3_btn.Text = "Basic 3";
            this.B3_btn.UseVisualStyleBackColor = true;
            this.B3_btn.Click += new System.EventHandler(this.B3_btn_Click);
            // 
            // B3_desc
            // 
            this.B3_desc.AutoSize = true;
            this.B3_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3_desc.Location = new System.Drawing.Point(224, 165);
            this.B3_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.B3_desc.Name = "B3_desc";
            this.B3_desc.Size = new System.Drawing.Size(413, 20);
            this.B3_desc.TabIndex = 10;
            this.B3_desc.Text = "Practice typing different rows \'zxcv\'(Left) and \'nm,.\'(Right).";
            // 
            // Num_btn
            // 
            this.Num_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_btn.Location = new System.Drawing.Point(89, 210);
            this.Num_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Num_btn.Name = "Num_btn";
            this.Num_btn.Size = new System.Drawing.Size(110, 28);
            this.Num_btn.TabIndex = 11;
            this.Num_btn.Text = "Num keys";
            this.Num_btn.UseVisualStyleBackColor = true;
            this.Num_btn.Click += new System.EventHandler(this.Num_btn_Click);
            // 
            // Num_desc
            // 
            this.Num_desc.AutoSize = true;
            this.Num_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_desc.Location = new System.Drawing.Point(225, 213);
            this.Num_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Num_desc.Name = "Num_desc";
            this.Num_desc.Size = new System.Drawing.Size(482, 20);
            this.Num_desc.TabIndex = 12;
            this.Num_desc.Text = "Practice typing number keys. Both upper layer and right layer works.";
            // 
            // UC1_btn
            // 
            this.UC1_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC1_btn.Location = new System.Drawing.Point(89, 257);
            this.UC1_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UC1_btn.Name = "UC1_btn";
            this.UC1_btn.Size = new System.Drawing.Size(110, 28);
            this.UC1_btn.TabIndex = 13;
            this.UC1_btn.Text = "Uppercase 1";
            this.UC1_btn.UseVisualStyleBackColor = true;
            this.UC1_btn.Click += new System.EventHandler(this.UC1_btn_Click);
            // 
            // UC1_desc
            // 
            this.UC1_desc.AutoSize = true;
            this.UC1_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC1_desc.Location = new System.Drawing.Point(225, 260);
            this.UC1_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UC1_desc.Name = "UC1_desc";
            this.UC1_desc.Size = new System.Drawing.Size(412, 20);
            this.UC1_desc.TabIndex = 14;
            this.UC1_desc.Text = "Practice typing basic homerows with upper case mixed up";
            // 
            // UC2_btn
            // 
            this.UC2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC2_btn.Location = new System.Drawing.Point(89, 305);
            this.UC2_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UC2_btn.Name = "UC2_btn";
            this.UC2_btn.Size = new System.Drawing.Size(110, 28);
            this.UC2_btn.TabIndex = 15;
            this.UC2_btn.Text = "Uppercase 2";
            this.UC2_btn.UseVisualStyleBackColor = true;
            this.UC2_btn.Click += new System.EventHandler(this.UC2_btn_Click);
            // 
            // UC2_desc
            // 
            this.UC2_desc.AutoSize = true;
            this.UC2_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC2_desc.Location = new System.Drawing.Point(224, 308);
            this.UC2_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UC2_desc.Name = "UC2_desc";
            this.UC2_desc.Size = new System.Drawing.Size(480, 20);
            this.UC2_desc.TabIndex = 16;
            this.UC2_desc.Text = "Practice typing different rows (qwer, uiop) with upper case mixed up";
            // 
            // UC3_btn
            // 
            this.UC3_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC3_btn.Location = new System.Drawing.Point(89, 354);
            this.UC3_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UC3_btn.Name = "UC3_btn";
            this.UC3_btn.Size = new System.Drawing.Size(110, 28);
            this.UC3_btn.TabIndex = 17;
            this.UC3_btn.Text = "Uppercase 3";
            this.UC3_btn.UseVisualStyleBackColor = true;
            // 
            // UC3_desc
            // 
            this.UC3_desc.AutoSize = true;
            this.UC3_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC3_desc.Location = new System.Drawing.Point(224, 357);
            this.UC3_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UC3_desc.Name = "UC3_desc";
            this.UC3_desc.Size = new System.Drawing.Size(476, 20);
            this.UC3_desc.TabIndex = 18;
            this.UC3_desc.Text = "Practice typing different rows (zxcv, nm,.) with upper case mixed up";
            // 
            // ALL_btn
            // 
            this.ALL_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALL_btn.Location = new System.Drawing.Point(89, 400);
            this.ALL_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ALL_btn.Name = "ALL_btn";
            this.ALL_btn.Size = new System.Drawing.Size(110, 28);
            this.ALL_btn.TabIndex = 19;
            this.ALL_btn.Text = "All keys";
            this.ALL_btn.UseVisualStyleBackColor = true;
            // 
            // ALL_desc
            // 
            this.ALL_desc.AutoSize = true;
            this.ALL_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALL_desc.Location = new System.Drawing.Point(224, 403);
            this.ALL_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ALL_desc.Name = "ALL_desc";
            this.ALL_desc.Size = new System.Drawing.Size(321, 20);
            this.ALL_desc.TabIndex = 20;
            this.ALL_desc.Text = "Practice typing every keys including numbers";
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 488);
            this.Controls.Add(this.ALL_desc);
            this.Controls.Add(this.ALL_btn);
            this.Controls.Add(this.UC3_desc);
            this.Controls.Add(this.UC3_btn);
            this.Controls.Add(this.UC2_desc);
            this.Controls.Add(this.UC2_btn);
            this.Controls.Add(this.UC1_desc);
            this.Controls.Add(this.UC1_btn);
            this.Controls.Add(this.Num_desc);
            this.Controls.Add(this.Num_btn);
            this.Controls.Add(this.B3_desc);
            this.Controls.Add(this.B3_btn);
            this.Controls.Add(this.B2_desc);
            this.Controls.Add(this.B2_btn);
            this.Controls.Add(this.testing_form);
            this.Controls.Add(this.Exit_desc);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.B1_desc);
            this.Controls.Add(this.B1_btn);
            this.Controls.Add(this.Menu_Title);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main_Menu";
            this.Text = "Typing lessons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Menu_Title;
        private System.Windows.Forms.Button B1_btn;
        private System.Windows.Forms.Label B1_desc;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Label Exit_desc;
        private System.Windows.Forms.Button testing_form;
        private System.Windows.Forms.Button B2_btn;
        private System.Windows.Forms.Label B2_desc;
        private System.Windows.Forms.Button B3_btn;
        private System.Windows.Forms.Label B3_desc;
        private System.Windows.Forms.Button Num_btn;
        private System.Windows.Forms.Label Num_desc;
        private System.Windows.Forms.Button UC1_btn;
        private System.Windows.Forms.Label UC1_desc;
        private System.Windows.Forms.Button UC2_btn;
        private System.Windows.Forms.Label UC2_desc;
        private System.Windows.Forms.Button UC3_btn;
        private System.Windows.Forms.Label UC3_desc;
        private System.Windows.Forms.Button ALL_btn;
        private System.Windows.Forms.Label ALL_desc;
    }
}

