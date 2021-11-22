
namespace TD1.IHM
{
    partial class NewAccount_frm
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
            this.Submit_btn = new System.Windows.Forms.Button();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Quit_llbl = new System.Windows.Forms.LinkLabel();
            this.Back_llbl = new System.Windows.Forms.LinkLabel();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.ConfirmPassword_lbl = new System.Windows.Forms.Label();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.ConfirmPassword_txt = new System.Windows.Forms.TextBox();
            this.AddProd_llbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(117, 295);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(75, 23);
            this.Submit_btn.TabIndex = 0;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Location = new System.Drawing.Point(44, 24);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(35, 13);
            this.Name_lbl.TabIndex = 1;
            this.Name_lbl.Text = "Name";
            // 
            // Quit_llbl
            // 
            this.Quit_llbl.AutoSize = true;
            this.Quit_llbl.Location = new System.Drawing.Point(12, 330);
            this.Quit_llbl.Name = "Quit_llbl";
            this.Quit_llbl.Size = new System.Drawing.Size(26, 13);
            this.Quit_llbl.TabIndex = 2;
            this.Quit_llbl.TabStop = true;
            this.Quit_llbl.Text = "Quit";
            this.Quit_llbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Quit_llbl_LinkClicked);
            // 
            // Back_llbl
            // 
            this.Back_llbl.AutoSize = true;
            this.Back_llbl.Location = new System.Drawing.Point(271, 330);
            this.Back_llbl.Name = "Back_llbl";
            this.Back_llbl.Size = new System.Drawing.Size(32, 13);
            this.Back_llbl.TabIndex = 3;
            this.Back_llbl.TabStop = true;
            this.Back_llbl.Text = "Back";
            this.Back_llbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Back_llbl_LinkClicked);
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Location = new System.Drawing.Point(44, 94);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(32, 13);
            this.Email_lbl.TabIndex = 4;
            this.Email_lbl.Text = "Email";
            // 
            // ConfirmPassword_lbl
            // 
            this.ConfirmPassword_lbl.AutoSize = true;
            this.ConfirmPassword_lbl.Location = new System.Drawing.Point(44, 227);
            this.ConfirmPassword_lbl.Name = "ConfirmPassword_lbl";
            this.ConfirmPassword_lbl.Size = new System.Drawing.Size(90, 13);
            this.ConfirmPassword_lbl.TabIndex = 5;
            this.ConfirmPassword_lbl.Text = "Confirm password";
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Location = new System.Drawing.Point(44, 162);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(53, 13);
            this.Password_lbl.TabIndex = 6;
            this.Password_lbl.Text = "Password";
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(47, 193);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(217, 20);
            this.Password_txt.TabIndex = 7;
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(47, 120);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(217, 20);
            this.Email_txt.TabIndex = 8;
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(47, 55);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(217, 20);
            this.Name_txt.TabIndex = 9;
            // 
            // ConfirmPassword_txt
            // 
            this.ConfirmPassword_txt.Location = new System.Drawing.Point(47, 256);
            this.ConfirmPassword_txt.Name = "ConfirmPassword_txt";
            this.ConfirmPassword_txt.Size = new System.Drawing.Size(217, 20);
            this.ConfirmPassword_txt.TabIndex = 10;
            // 
            // AddProd_llbl
            // 
            this.AddProd_llbl.AutoSize = true;
            this.AddProd_llbl.Location = new System.Drawing.Point(119, 330);
            this.AddProd_llbl.Name = "AddProd_llbl";
            this.AddProd_llbl.Size = new System.Drawing.Size(70, 13);
            this.AddProd_llbl.TabIndex = 11;
            this.AddProd_llbl.TabStop = true;
            this.AddProd_llbl.Text = "Add products";
            this.AddProd_llbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddProd_llbl_LinkClicked);
            // 
            // NewAccount_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 352);
            this.Controls.Add(this.AddProd_llbl);
            this.Controls.Add(this.ConfirmPassword_txt);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.ConfirmPassword_lbl);
            this.Controls.Add(this.Email_lbl);
            this.Controls.Add(this.Back_llbl);
            this.Controls.Add(this.Quit_llbl);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.Submit_btn);
            this.Name = "NewAccount_frm";
            this.Text = "NewAccount";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewAccount_frm_FormClosed);
            this.Load += new System.EventHandler(this.NewAccount_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.LinkLabel Quit_llbl;
        private System.Windows.Forms.LinkLabel Back_llbl;
        private System.Windows.Forms.Label Email_lbl;
        private System.Windows.Forms.Label ConfirmPassword_lbl;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.TextBox ConfirmPassword_txt;
        private System.Windows.Forms.LinkLabel AddProd_llbl;
    }
}