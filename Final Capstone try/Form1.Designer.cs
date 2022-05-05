
namespace Final_Capstone_try
{
    partial class Form1
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
            this.close_Button = new System.Windows.Forms.Button();
            this.addNew_button = new System.Windows.Forms.Button();
            this.lastname_label = new System.Windows.Forms.Label();
            this.firstname_label = new System.Windows.Forms.Label();
            this.ein_label = new System.Windows.Forms.Label();
            this.lastnamenew_textbox = new System.Windows.Forms.TextBox();
            this.firstnamenew_textbox = new System.Windows.Forms.TextBox();
            this.EINnew_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // close_Button
            // 
            this.close_Button.Location = new System.Drawing.Point(248, 72);
            this.close_Button.Margin = new System.Windows.Forms.Padding(2);
            this.close_Button.Name = "close_Button";
            this.close_Button.Size = new System.Drawing.Size(100, 19);
            this.close_Button.TabIndex = 48;
            this.close_Button.Text = "Close";
            this.close_Button.UseVisualStyleBackColor = true;
            // 
            // addNew_button
            // 
            this.addNew_button.Location = new System.Drawing.Point(248, 49);
            this.addNew_button.Margin = new System.Windows.Forms.Padding(2);
            this.addNew_button.Name = "addNew_button";
            this.addNew_button.Size = new System.Drawing.Size(100, 22);
            this.addNew_button.TabIndex = 47;
            this.addNew_button.Text = "Add New";
            this.addNew_button.UseVisualStyleBackColor = true;
            // 
            // lastname_label
            // 
            this.lastname_label.AutoSize = true;
            this.lastname_label.Location = new System.Drawing.Point(32, 106);
            this.lastname_label.Name = "lastname_label";
            this.lastname_label.Size = new System.Drawing.Size(61, 13);
            this.lastname_label.TabIndex = 46;
            this.lastname_label.Text = "Last Name:";
            // 
            // firstname_label
            // 
            this.firstname_label.AutoSize = true;
            this.firstname_label.Location = new System.Drawing.Point(33, 80);
            this.firstname_label.Name = "firstname_label";
            this.firstname_label.Size = new System.Drawing.Size(60, 13);
            this.firstname_label.TabIndex = 45;
            this.firstname_label.Text = "First Name:";
            // 
            // ein_label
            // 
            this.ein_label.AutoSize = true;
            this.ein_label.Location = new System.Drawing.Point(65, 54);
            this.ein_label.Name = "ein_label";
            this.ein_label.Size = new System.Drawing.Size(28, 13);
            this.ein_label.TabIndex = 44;
            this.ein_label.Text = "EIN:";
            // 
            // lastnamenew_textbox
            // 
            this.lastnamenew_textbox.Location = new System.Drawing.Point(99, 103);
            this.lastnamenew_textbox.Name = "lastnamenew_textbox";
            this.lastnamenew_textbox.Size = new System.Drawing.Size(100, 20);
            this.lastnamenew_textbox.TabIndex = 43;
            // 
            // firstnamenew_textbox
            // 
            this.firstnamenew_textbox.Location = new System.Drawing.Point(99, 77);
            this.firstnamenew_textbox.Name = "firstnamenew_textbox";
            this.firstnamenew_textbox.Size = new System.Drawing.Size(100, 20);
            this.firstnamenew_textbox.TabIndex = 42;
            // 
            // EINnew_textbox
            // 
            this.EINnew_textbox.Location = new System.Drawing.Point(99, 51);
            this.EINnew_textbox.Name = "EINnew_textbox";
            this.EINnew_textbox.Size = new System.Drawing.Size(100, 20);
            this.EINnew_textbox.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 203);
            this.Controls.Add(this.close_Button);
            this.Controls.Add(this.addNew_button);
            this.Controls.Add(this.lastname_label);
            this.Controls.Add(this.firstname_label);
            this.Controls.Add(this.ein_label);
            this.Controls.Add(this.lastnamenew_textbox);
            this.Controls.Add(this.firstnamenew_textbox);
            this.Controls.Add(this.EINnew_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_Button;
        private System.Windows.Forms.Button addNew_button;
        private System.Windows.Forms.Label lastname_label;
        private System.Windows.Forms.Label firstname_label;
        private System.Windows.Forms.Label ein_label;
        public System.Windows.Forms.TextBox lastnamenew_textbox;
        public System.Windows.Forms.TextBox firstnamenew_textbox;
        public System.Windows.Forms.TextBox EINnew_textbox;
    }
}