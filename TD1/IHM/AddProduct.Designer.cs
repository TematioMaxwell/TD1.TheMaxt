
namespace TD1.IHM
{
    partial class AddProduct_frm
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
            this.Price_txt = new System.Windows.Forms.TextBox();
            this.Finish_btn = new System.Windows.Forms.Button();
            this.Reference_lbl = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Price_lbl = new System.Windows.Forms.Label();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Reference_txt = new System.Windows.Forms.TextBox();
            this.Again_btn = new System.Windows.Forms.Button();
            this.Quantity_lbl = new System.Windows.Forms.Label();
            this.Quantity_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Price_txt
            // 
            this.Price_txt.Location = new System.Drawing.Point(62, 170);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(256, 20);
            this.Price_txt.TabIndex = 0;
            // 
            // Finish_btn
            // 
            this.Finish_btn.Location = new System.Drawing.Point(243, 273);
            this.Finish_btn.Name = "Finish_btn";
            this.Finish_btn.Size = new System.Drawing.Size(75, 23);
            this.Finish_btn.TabIndex = 1;
            this.Finish_btn.Text = "Finish";
            this.Finish_btn.UseVisualStyleBackColor = true;
            this.Finish_btn.Click += new System.EventHandler(this.Finish_btn_Click);
            // 
            // Reference_lbl
            // 
            this.Reference_lbl.AutoSize = true;
            this.Reference_lbl.Location = new System.Drawing.Point(59, 2);
            this.Reference_lbl.Name = "Reference_lbl";
            this.Reference_lbl.Size = new System.Drawing.Size(57, 13);
            this.Reference_lbl.TabIndex = 2;
            this.Reference_lbl.Text = "Reference";
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Location = new System.Drawing.Point(51, 76);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(35, 13);
            this.Name_lbl.TabIndex = 3;
            this.Name_lbl.Text = "Name";
            // 
            // Price_lbl
            // 
            this.Price_lbl.AutoSize = true;
            this.Price_lbl.Location = new System.Drawing.Point(51, 147);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(31, 13);
            this.Price_lbl.TabIndex = 4;
            this.Price_lbl.Text = "Price";
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(62, 101);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(256, 20);
            this.Name_txt.TabIndex = 5;
            // 
            // Reference_txt
            // 
            this.Reference_txt.Location = new System.Drawing.Point(62, 27);
            this.Reference_txt.Name = "Reference_txt";
            this.Reference_txt.Size = new System.Drawing.Size(256, 20);
            this.Reference_txt.TabIndex = 6;
            // 
            // Again_btn
            // 
            this.Again_btn.Location = new System.Drawing.Point(62, 273);
            this.Again_btn.Name = "Again_btn";
            this.Again_btn.Size = new System.Drawing.Size(75, 23);
            this.Again_btn.TabIndex = 7;
            this.Again_btn.Text = "Again";
            this.Again_btn.UseVisualStyleBackColor = true;
            this.Again_btn.Click += new System.EventHandler(this.Again_btn_Click);
            // 
            // Quantity_lbl
            // 
            this.Quantity_lbl.AutoSize = true;
            this.Quantity_lbl.Location = new System.Drawing.Point(51, 211);
            this.Quantity_lbl.Name = "Quantity_lbl";
            this.Quantity_lbl.Size = new System.Drawing.Size(46, 13);
            this.Quantity_lbl.TabIndex = 9;
            this.Quantity_lbl.Text = "Quantity";
            // 
            // Quantity_txt
            // 
            this.Quantity_txt.Location = new System.Drawing.Point(62, 234);
            this.Quantity_txt.Name = "Quantity_txt";
            this.Quantity_txt.Size = new System.Drawing.Size(256, 20);
            this.Quantity_txt.TabIndex = 8;
            // 
            // AddProduct_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 308);
            this.Controls.Add(this.Quantity_lbl);
            this.Controls.Add(this.Quantity_txt);
            this.Controls.Add(this.Again_btn);
            this.Controls.Add(this.Reference_txt);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.Price_lbl);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.Reference_lbl);
            this.Controls.Add(this.Finish_btn);
            this.Controls.Add(this.Price_txt);
            this.Name = "AddProduct_frm";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.AddProduct_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Price_txt;
        private System.Windows.Forms.Button Finish_btn;
        private System.Windows.Forms.Label Reference_lbl;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label Price_lbl;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.TextBox Reference_txt;
        private System.Windows.Forms.Button Again_btn;
        private System.Windows.Forms.Label Quantity_lbl;
        private System.Windows.Forms.TextBox Quantity_txt;
    }
}