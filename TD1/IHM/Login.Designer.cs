
namespace TD1.IHM
{
    partial class Login_frm
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
            this.Connect_btn = new System.Windows.Forms.Button();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.NewAccount_llbl = new System.Windows.Forms.LinkLabel();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Quit_llbl = new System.Windows.Forms.LinkLabel();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Connect_btn
            // 
            this.Connect_btn.Location = new System.Drawing.Point(115, 242);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Size = new System.Drawing.Size(75, 23);
            this.Connect_btn.TabIndex = 0;
            this.Connect_btn.Text = "Connect";
            this.Connect_btn.UseVisualStyleBackColor = true;
            this.Connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Location = new System.Drawing.Point(44, 46);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(32, 13);
            this.Email_lbl.TabIndex = 1;
            this.Email_lbl.Text = "Email";
            // 
            // NewAccount_llbl
            // 
            this.NewAccount_llbl.AutoSize = true;
            this.NewAccount_llbl.Location = new System.Drawing.Point(216, 292);
            this.NewAccount_llbl.Name = "NewAccount_llbl";
            this.NewAccount_llbl.Size = new System.Drawing.Size(71, 13);
            this.NewAccount_llbl.TabIndex = 2;
            this.NewAccount_llbl.TabStop = true;
            this.NewAccount_llbl.Text = "New account";
            this.NewAccount_llbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewAccount_llbl_LinkClicked);
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(47, 78);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(205, 20);
            this.Email_txt.TabIndex = 3;
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(47, 173);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(205, 20);
            this.Name_txt.TabIndex = 4;
            // 
            // Quit_llbl
            // 
            this.Quit_llbl.AutoSize = true;
            this.Quit_llbl.Location = new System.Drawing.Point(12, 292);
            this.Quit_llbl.Name = "Quit_llbl";
            this.Quit_llbl.Size = new System.Drawing.Size(26, 13);
            this.Quit_llbl.TabIndex = 5;
            this.Quit_llbl.TabStop = true;
            this.Quit_llbl.Text = "Quit";
            this.Quit_llbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Quit_llbl_LinkClicked);
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Location = new System.Drawing.Point(44, 136);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(35, 13);
            this.Name_lbl.TabIndex = 6;
            this.Name_lbl.Text = "Name";
            // 
            // Login_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 314);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.Quit_llbl);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.NewAccount_llbl);
            this.Controls.Add(this.Email_lbl);
            this.Controls.Add(this.Connect_btn);
            this.Name = "Login_frm";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_frm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect_btn;
        private System.Windows.Forms.Label Email_lbl;
        private System.Windows.Forms.LinkLabel NewAccount_llbl;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.LinkLabel Quit_llbl;
        private System.Windows.Forms.Label Name_lbl;
    }
}