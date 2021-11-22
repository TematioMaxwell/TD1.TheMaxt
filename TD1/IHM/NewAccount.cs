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
    public partial class NewAccount_frm : Form
    {
        private bool isToClose = true;
        public User user;
        public DirectoryInfo dir = Directory.CreateDirectory("Datas");
        public string PATH;
        public NewAccount_frm()
        {
            InitializeComponent();
            this.PATH = Path.Combine(dir.FullName, "data.txt");
        }

        private void Quit_llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void NewAccount_frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isToClose)
                Application.Exit();
        }

        private void Back_llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_frm login = new Login_frm();
            login.Show();
            isToClose = false;
            this.Close();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if (Email_txt.Text == "" || Name_txt.Text == "" || Password_txt.Text == "" || ConfirmPassword_txt.Text == "")
            {
                MessageBox.Show("un champ est vide veuillez le remplir");
            }
            else if (!Password_txt.Text.Equals(ConfirmPassword_txt.Text))
            {
                MessageBox.Show("erreur de correspondance entre les mots de passe veuillez reessayer");
                Password_txt.Text = "";
                ConfirmPassword_txt.Text = "";
            }
            else
            {
                try
                {
                    user = new User(Email_txt.Text, Name_txt.Text, Password_txt.Text);
                    UserRepository repository = new UserRepository(Mode.Binary, PATH);
                    if (!repository.IsExists(user))
                        repository.Add(user);
                    MessageBox.Show("utilisateur ajoute avec succes");
                    Email_txt.Text = "";
                    Name_txt.Text = "";
                    Password_txt.Text = "";
                    Menu_frm menu = new Menu_frm(user.Id);
                    menu.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void NewAccount_frm_Load(object sender, EventArgs e)
        {
            Password_txt.UseSystemPasswordChar = true;
            ConfirmPassword_txt.UseSystemPasswordChar = true;
        }

        private void AddProd_llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Email_txt.Text == "" || Name_txt.Text == "" || Password_txt.Text == "" || ConfirmPassword_txt.Text == "")
            {
                MessageBox.Show("un champ est vide veuillez le remplir");
            }
            else if (!Password_txt.Text.Equals(ConfirmPassword_txt.Text))
            {
                MessageBox.Show("erreur de correspondance entre les mots de passe veuillez reessayer");
                Password_txt.Text = "";
                ConfirmPassword_txt.Text = "";
            }
            else
            {
                try
                {
                    user = new User(Email_txt.Text, Name_txt.Text, Password_txt.Text);
                    UserRepository repository = new UserRepository(Mode.Binary, PATH);
                    if (!repository.IsExists(user))
                    {
                        repository.Add(user);
                        AddProduct_frm addProduct = new AddProduct_frm(user, 0);
                        addProduct.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}