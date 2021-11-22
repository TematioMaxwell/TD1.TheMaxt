
namespace TD1.IHM
{
    partial class Edit_frm
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
            this.Save_btn = new System.Windows.Forms.Button();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.UserList_lvw = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.ProductList_lvw = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserList_lbl = new System.Windows.Forms.Label();
            this.ProductList_lbl = new System.Windows.Forms.Label();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.Search_lvw = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email_lbl = new System.Windows.Forms.Label();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.AddUser_btn = new System.Windows.Forms.Button();
            this.AddProd_btn = new System.Windows.Forms.Button();
            this.DeleteProd_btn = new System.Windows.Forms.Button();
            this.DeleteUser_btn = new System.Windows.Forms.Button();
            this.EditProd_btn = new System.Windows.Forms.Button();
            this.EditUser_btn = new System.Windows.Forms.Button();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Total_lbl = new System.Windows.Forms.Label();
            this.Total_txt = new System.Windows.Forms.TextBox();
            this.SaveFile_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(51, 249);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 0;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(14, 54);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(149, 20);
            this.Name_txt.TabIndex = 1;
            // 
            // UserList_lvw
            // 
            this.UserList_lvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.UserList_lvw.GridLines = true;
            this.UserList_lvw.HideSelection = false;
            this.UserList_lvw.Location = new System.Drawing.Point(243, 76);
            this.UserList_lvw.MultiSelect = false;
            this.UserList_lvw.Name = "UserList_lvw";
            this.UserList_lvw.Size = new System.Drawing.Size(346, 156);
            this.UserList_lvw.TabIndex = 2;
            this.UserList_lvw.UseCompatibleStateImageBehavior = false;
            this.UserList_lvw.View = System.Windows.Forms.View.Details;
            this.UserList_lvw.SelectedIndexChanged += new System.EventHandler(this.UserList_lvw_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 224;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // ProductList_lvw
            // 
            this.ProductList_lvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader8});
            this.ProductList_lvw.GridLines = true;
            this.ProductList_lvw.HideSelection = false;
            this.ProductList_lvw.Location = new System.Drawing.Point(243, 268);
            this.ProductList_lvw.Name = "ProductList_lvw";
            this.ProductList_lvw.Size = new System.Drawing.Size(346, 156);
            this.ProductList_lvw.TabIndex = 4;
            this.ProductList_lvw.UseCompatibleStateImageBehavior = false;
            this.ProductList_lvw.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Reference";
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 105;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Quantity";
            this.columnHeader8.Width = 51;
            // 
            // UserList_lbl
            // 
            this.UserList_lbl.AutoSize = true;
            this.UserList_lbl.Location = new System.Drawing.Point(392, 60);
            this.UserList_lbl.Name = "UserList_lbl";
            this.UserList_lbl.Size = new System.Drawing.Size(49, 13);
            this.UserList_lbl.TabIndex = 5;
            this.UserList_lbl.Text = "Users list";
            // 
            // ProductList_lbl
            // 
            this.ProductList_lbl.AutoSize = true;
            this.ProductList_lbl.Location = new System.Drawing.Point(384, 252);
            this.ProductList_lbl.Name = "ProductList_lbl";
            this.ProductList_lbl.Size = new System.Drawing.Size(64, 13);
            this.ProductList_lbl.TabIndex = 6;
            this.ProductList_lbl.Text = "Products list";
            // 
            // Search_txt
            // 
            this.Search_txt.Location = new System.Drawing.Point(183, 6);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(466, 20);
            this.Search_txt.TabIndex = 8;
            this.Search_txt.TextChanged += new System.EventHandler(this.Search_txt_TextChanged);
            // 
            // Search_lvw
            // 
            this.Search_lvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.Search_lvw.GridLines = true;
            this.Search_lvw.HideSelection = false;
            this.Search_lvw.Location = new System.Drawing.Point(183, 23);
            this.Search_lvw.MultiSelect = false;
            this.Search_lvw.Name = "Search_lvw";
            this.Search_lvw.Size = new System.Drawing.Size(466, 156);
            this.Search_lvw.TabIndex = 9;
            this.Search_lvw.UseCompatibleStateImageBehavior = false;
            this.Search_lvw.View = System.Windows.Forms.View.Details;
            this.Search_lvw.SelectedIndexChanged += new System.EventHandler(this.Search_lvw_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Name";
            this.columnHeader6.Width = 159;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email";
            this.columnHeader7.Width = 301;
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Location = new System.Drawing.Point(11, 97);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(32, 13);
            this.Email_lbl.TabIndex = 10;
            this.Email_lbl.Text = "Email";
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(14, 124);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(149, 20);
            this.Email_txt.TabIndex = 11;
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Location = new System.Drawing.Point(11, 173);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(53, 13);
            this.Password_lbl.TabIndex = 12;
            this.Password_lbl.Text = "Password";
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(14, 204);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(149, 20);
            this.Password_txt.TabIndex = 13;
            this.Password_txt.UseSystemPasswordChar = true;
            // 
            // AddUser_btn
            // 
            this.AddUser_btn.Location = new System.Drawing.Point(16, 322);
            this.AddUser_btn.Name = "AddUser_btn";
            this.AddUser_btn.Size = new System.Drawing.Size(75, 23);
            this.AddUser_btn.TabIndex = 14;
            this.AddUser_btn.Text = "Add user";
            this.AddUser_btn.UseVisualStyleBackColor = true;
            this.AddUser_btn.Click += new System.EventHandler(this.AddUser_btn_Click);
            // 
            // AddProd_btn
            // 
            this.AddProd_btn.Location = new System.Drawing.Point(151, 322);
            this.AddProd_btn.Name = "AddProd_btn";
            this.AddProd_btn.Size = new System.Drawing.Size(75, 23);
            this.AddProd_btn.TabIndex = 15;
            this.AddProd_btn.Text = "Add product";
            this.AddProd_btn.UseVisualStyleBackColor = true;
            this.AddProd_btn.Click += new System.EventHandler(this.AddProd_btn_Click);
            // 
            // DeleteProd_btn
            // 
            this.DeleteProd_btn.Location = new System.Drawing.Point(151, 380);
            this.DeleteProd_btn.Name = "DeleteProd_btn";
            this.DeleteProd_btn.Size = new System.Drawing.Size(75, 23);
            this.DeleteProd_btn.TabIndex = 16;
            this.DeleteProd_btn.Text = "Del product";
            this.DeleteProd_btn.UseVisualStyleBackColor = true;
            this.DeleteProd_btn.Click += new System.EventHandler(this.DeleteProd_btn_Click);
            // 
            // DeleteUser_btn
            // 
            this.DeleteUser_btn.Location = new System.Drawing.Point(16, 380);
            this.DeleteUser_btn.Name = "DeleteUser_btn";
            this.DeleteUser_btn.Size = new System.Drawing.Size(75, 23);
            this.DeleteUser_btn.TabIndex = 17;
            this.DeleteUser_btn.Text = "Delete user";
            this.DeleteUser_btn.UseVisualStyleBackColor = true;
            this.DeleteUser_btn.Click += new System.EventHandler(this.DeleteUser_btn_Click);
            // 
            // EditProd_btn
            // 
            this.EditProd_btn.Location = new System.Drawing.Point(151, 351);
            this.EditProd_btn.Name = "EditProd_btn";
            this.EditProd_btn.Size = new System.Drawing.Size(75, 23);
            this.EditProd_btn.TabIndex = 18;
            this.EditProd_btn.Text = "Edit product";
            this.EditProd_btn.UseVisualStyleBackColor = true;
            this.EditProd_btn.Click += new System.EventHandler(this.EditProd_btn_Click);
            // 
            // EditUser_btn
            // 
            this.EditUser_btn.Location = new System.Drawing.Point(16, 351);
            this.EditUser_btn.Name = "EditUser_btn";
            this.EditUser_btn.Size = new System.Drawing.Size(75, 23);
            this.EditUser_btn.TabIndex = 19;
            this.EditUser_btn.Text = "Edit user";
            this.EditUser_btn.UseVisualStyleBackColor = true;
            this.EditUser_btn.Click += new System.EventHandler(this.EditUser_btn_Click);
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Location = new System.Drawing.Point(16, 409);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.Refresh_btn.TabIndex = 20;
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.UseVisualStyleBackColor = true;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(102, 12);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 23);
            this.Search_btn.TabIndex = 21;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Total_lbl
            // 
            this.Total_lbl.AutoSize = true;
            this.Total_lbl.Location = new System.Drawing.Point(305, 430);
            this.Total_lbl.Name = "Total_lbl";
            this.Total_lbl.Size = new System.Drawing.Size(31, 13);
            this.Total_lbl.TabIndex = 22;
            this.Total_lbl.Text = "Total";
            // 
            // Total_txt
            // 
            this.Total_txt.Location = new System.Drawing.Point(342, 427);
            this.Total_txt.Name = "Total_txt";
            this.Total_txt.Size = new System.Drawing.Size(175, 20);
            this.Total_txt.TabIndex = 23;
            // 
            // SaveFile_btn
            // 
            this.SaveFile_btn.Location = new System.Drawing.Point(151, 409);
            this.SaveFile_btn.Name = "SaveFile_btn";
            this.SaveFile_btn.Size = new System.Drawing.Size(75, 23);
            this.SaveFile_btn.TabIndex = 24;
            this.SaveFile_btn.Text = "Save file";
            this.SaveFile_btn.UseVisualStyleBackColor = true;
            this.SaveFile_btn.Click += new System.EventHandler(this.SaveFile_btn_Click);
            // 
            // Edit_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 460);
            this.Controls.Add(this.SaveFile_btn);
            this.Controls.Add(this.Total_txt);
            this.Controls.Add(this.Total_lbl);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.EditUser_btn);
            this.Controls.Add(this.EditProd_btn);
            this.Controls.Add(this.DeleteUser_btn);
            this.Controls.Add(this.DeleteProd_btn);
            this.Controls.Add(this.AddProd_btn);
            this.Controls.Add(this.AddUser_btn);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.Email_lbl);
            this.Controls.Add(this.Search_lvw);
            this.Controls.Add(this.Search_txt);
            this.Controls.Add(this.ProductList_lbl);
            this.Controls.Add(this.UserList_lbl);
            this.Controls.Add(this.ProductList_lvw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserList_lvw);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.Save_btn);
            this.Name = "Edit_frm";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.ListView UserList_lvw;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ProductList_lvw;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label UserList_lbl;
        private System.Windows.Forms.Label ProductList_lbl;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.ListView Search_lvw;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label Email_lbl;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Button AddUser_btn;
        private System.Windows.Forms.Button AddProd_btn;
        private System.Windows.Forms.Button DeleteProd_btn;
        private System.Windows.Forms.Button DeleteUser_btn;
        private System.Windows.Forms.Button EditProd_btn;
        private System.Windows.Forms.Button EditUser_btn;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Label Total_lbl;
        private System.Windows.Forms.TextBox Total_txt;
        private System.Windows.Forms.Button SaveFile_btn;
    }
}