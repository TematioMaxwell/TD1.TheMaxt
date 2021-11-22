
namespace TD1.IHM
{
    partial class ChangePassword_frm
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
            this.OldPass_lbl = new System.Windows.Forms.Label();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.OldPass_txt = new System.Windows.Forms.TextBox();
            this.NewPass_txt = new System.Windows.Forms.TextBox();
            this.NewPass_lbl = new System.Windows.Forms.Label();
            this.ConfirmPass_txt = new System.Windows.Forms.TextBox();
            this.ConfirmPass_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OldPass_lbl
            // 
            this.OldPass_lbl.AutoSize = true;
            this.OldPass_lbl.Location = new System.Drawing.Point(52, 36);
            this.OldPass_lbl.Name = "OldPass_lbl";
            this.OldPass_lbl.Size = new System.Drawing.Size(71, 13);
            this.OldPass_lbl.TabIndex = 0;
            this.OldPass_lbl.Text = "Old password";
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(105, 287);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(75, 23);
            this.Submit_btn.TabIndex = 1;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // OldPass_txt
            // 
            this.OldPass_txt.Location = new System.Drawing.Point(55, 67);
            this.OldPass_txt.Name = "OldPass_txt";
            this.OldPass_txt.Size = new System.Drawing.Size(179, 20);
            this.OldPass_txt.TabIndex = 2;
            // 
            // NewPass_txt
            // 
            this.NewPass_txt.Location = new System.Drawing.Point(55, 152);
            this.NewPass_txt.Name = "NewPass_txt";
            this.NewPass_txt.Size = new System.Drawing.Size(179, 20);
            this.NewPass_txt.TabIndex = 3;
            // 
            // NewPass_lbl
            // 
            this.NewPass_lbl.AutoSize = true;
            this.NewPass_lbl.Location = new System.Drawing.Point(52, 120);
            this.NewPass_lbl.Name = "NewPass_lbl";
            this.NewPass_lbl.Size = new System.Drawing.Size(77, 13);
            this.NewPass_lbl.TabIndex = 4;
            this.NewPass_lbl.Text = "New password";
            // 
            // ConfirmPass_txt
            // 
            this.ConfirmPass_txt.Location = new System.Drawing.Point(55, 237);
            this.ConfirmPass_txt.Name = "ConfirmPass_txt";
            this.ConfirmPass_txt.Size = new System.Drawing.Size(179, 20);
            this.ConfirmPass_txt.TabIndex = 5;
            // 
            // ConfirmPass_lbl
            // 
            this.ConfirmPass_lbl.AutoSize = true;
            this.ConfirmPass_lbl.Location = new System.Drawing.Point(52, 207);
            this.ConfirmPass_lbl.Name = "ConfirmPass_lbl";
            this.ConfirmPass_lbl.Size = new System.Drawing.Size(90, 13);
            this.ConfirmPass_lbl.TabIndex = 6;
            this.ConfirmPass_lbl.Text = "Confirm password";
            // 
            // ChangePassword_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 337);
            this.Controls.Add(this.ConfirmPass_lbl);
            this.Controls.Add(this.ConfirmPass_txt);
            this.Controls.Add(this.NewPass_lbl);
            this.Controls.Add(this.NewPass_txt);
            this.Controls.Add(this.OldPass_txt);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.OldPass_lbl);
            this.Name = "ChangePassword_frm";
            this.Text = "Change password";
            this.Load += new System.EventHandler(this.ChangePassword_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OldPass_lbl;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.TextBox OldPass_txt;
        private System.Windows.Forms.TextBox NewPass_txt;
        private System.Windows.Forms.Label NewPass_lbl;
        private System.Windows.Forms.TextBox ConfirmPass_txt;
        private System.Windows.Forms.Label ConfirmPass_lbl;
    }
}