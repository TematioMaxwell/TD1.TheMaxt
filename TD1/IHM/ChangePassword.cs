using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TD1.IHM
{
    public partial class ChangePassword_frm : Form
    {
        public ChangePassword_frm()
        {
            InitializeComponent();
        }

        private void ChangePassword_frm_Load(object sender, EventArgs e)
        {
            NewPass_txt.UseSystemPasswordChar = true;
            ConfirmPass_txt.UseSystemPasswordChar = true;
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if (OldPass_txt.Text == "" || NewPass_txt.Text == "" || ConfirmPass_txt.Text == "")
            {
                MessageBox.Show("un des champs est vide veuillez le remplir");
            }
            else if (NewPass_txt.Text != ConfirmPass_txt.Text)
            {
                MessageBox.Show("erreur de correspondance entre les mots de passe veuillez reessayer");
                OldPass_txt.Text = "";
                NewPass_txt.Text = "";
                ConfirmPass_txt.Text = "";
            }
            else
            {
                this.Close();
            }
        }
    }
}
