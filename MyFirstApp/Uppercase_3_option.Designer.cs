namespace MyFirstApp
{
    partial class Uppercase_3_option
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
            this.Back_button = new System.Windows.Forms.Button();
            this.Start_button = new System.Windows.Forms.Button();
            this.askAmount = new System.Windows.Forms.Label();
            this.typeAmount = new System.Windows.Forms.TextBox();
            this.amountNote = new System.Windows.Forms.Label();
            this.errorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(92, 301);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(103, 57);
            this.Back_button.TabIndex = 0;
            this.Back_button.Text = "Back to Menu";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(254, 301);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(103, 57);
            this.Start_button.TabIndex = 1;
            this.Start_button.Text = "Start";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // askAmount
            // 
            this.askAmount.AutoSize = true;
            this.askAmount.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.askAmount.Location = new System.Drawing.Point(67, 39);
            this.askAmount.Name = "askAmount";
            this.askAmount.Size = new System.Drawing.Size(356, 24);
            this.askAmount.TabIndex = 2;
            this.askAmount.Text = "How much do you want to type?";
            // 
            // typeAmount
            // 
            this.typeAmount.Font = new System.Drawing.Font("Gulim", 18F);
            this.typeAmount.Location = new System.Drawing.Point(179, 168);
            this.typeAmount.Name = "typeAmount";
            this.typeAmount.Size = new System.Drawing.Size(92, 35);
            this.typeAmount.TabIndex = 3;
            this.typeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // amountNote
            // 
            this.amountNote.AutoSize = true;
            this.amountNote.Font = new System.Drawing.Font("Gulim", 12F);
            this.amountNote.Location = new System.Drawing.Point(107, 100);
            this.amountNote.Name = "amountNote";
            this.amountNote.Size = new System.Drawing.Size(239, 16);
            this.amountNote.TabIndex = 4;
            this.amountNote.Text = "minimum of 50, maximum of 200";
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.errorMsg.Location = new System.Drawing.Point(141, 231);
            this.errorMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(0, 20);
            this.errorMsg.TabIndex = 5;
            this.errorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Basic_3_option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 409);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.amountNote);
            this.Controls.Add(this.typeAmount);
            this.Controls.Add(this.askAmount);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.Back_button);
            this.Name = "Basic_3_option";
            this.Text = "Basic_3_option";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Label askAmount;
        private System.Windows.Forms.TextBox typeAmount;
        private System.Windows.Forms.Label amountNote;
        private System.Windows.Forms.Label errorMsg;
    }
}