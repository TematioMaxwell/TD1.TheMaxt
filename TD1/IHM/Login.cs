using MaLibrairie.Serialisation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TD1.BO;
using TD1.DAL;

namespace TD1.IHM
{
    public partial class Login_frm : Form
    {
        private bool isToClose = true;
        public DirectoryInfo dir = Directory.CreateDirectory("Datas");
        public string PATH;
        public Login_frm()
        {
            InitializeComponent();
            this.PATH = Path.Combine(dir.FullName, "data.txt");
        }

        private void Quit_llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
        private void Connect_btn_Click(object sender, EventArgs e)
        {
            if (Name_txt.Text == "" || Email_txt.Text == "")
            {
                MessageBox.Show("un des champs est vide veuilez le remplir");
            }
            else
            {
                if (new UserRepository(Mode.Binary, PATH).IsExists(new User(Email_txt.Text, Name_txt.Text)))
                {
                    Menu_frm menu = new Menu_frm(Email_txt.Text);
                    menu.Show();
                    isToClose = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur cet utilisateur n'a pas ete retrouve");
                }
            }
        }

        private void Login_frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isToClose)
                Application.Exit();
        }

        private void NewAccount_llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAccount_frm newAccount = new NewAccount_frm();
            newAccount.Show();
            isToClose = false;
            this.Close();
        }
    }
}
