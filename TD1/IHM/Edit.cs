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
    public partial class Edit_frm : Form
    {
        public DirectoryInfo dir = Directory.CreateDirectory("Datas");
        public string PATH;
        public Edit_frm()
        {
            InitializeComponent();
            this.PATH = Path.Combine(dir.FullName, "data.txt");
        }

        private void AddUser_btn_Click(object sender, EventArgs e)
        {
            if (Name_txt.Text == "" || Email_txt.Text == "" || Password_txt.Text == "")
            {
                MessageBox.Show("un des champs est vide veuillez le remplir");
            }
            else
            {
                User user = new User(Email_txt.Text, Name_txt.Text, Password_txt.Text);
                UserRepository repository = new UserRepository(Mode.Binary, PATH);
                repository.Add(user);
                MessageBox.Show("ajout reussie");
                Name_txt.Text = "";
                Email_txt.Text = "";
                Password_txt.Text = "";
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (Name_txt.Text == "" || Email_txt.Text == "" || Password_txt.Text == "")
            {
                MessageBox.Show("un des champs est vide veuillez le remplir");
            }
            else
            {
                User user = new User(Email_txt.Text, Name_txt.Text, Password_txt.Text);
                UserRepository repository = new UserRepository(Mode.Binary, PATH);
                repository.Set(repository.FindById(Email_txt.Text), user);
                MessageBox.Show("modification reussie");
                Name_txt.Text = "";
                Email_txt.Text = "";
                Password_txt.Text = "";
                Email_txt.Enabled = true;
                Password_txt.Enabled = true;
                Save_btn.Visible = false;
            }
        }

        private void EditUser_btn_Click(object sender, EventArgs e)
        {
            if (UserList_lvw.SelectedItems.Count < 1)
            {
                MessageBox.Show("veuillez selectionner un utilisateur");
            }
            else
            {
                Save_btn.Visible = true;
                Email_txt.Enabled = false;
                var id = UserList_lvw.SelectedItems[0].SubItems[1].Text;
                User user = new UserRepository(Mode.Binary, PATH).FindById(id);
                Email_txt.Text = user.Id;
                Name_txt.Text = user.Name;
                Password_txt.Text = user.Password;
            }
        }

        private void DeleteUser_btn_Click(object sender, EventArgs e)
        {
            if (UserList_lvw.SelectedItems.Count < 1)
            {
                MessageBox.Show("veuillez selectionner un utilisateur");
            }
            else
            {
                UserRepository repository = new UserRepository(Mode.Binary, PATH);
                string id = UserList_lvw.SelectedItems[0].SubItems[1].Text;
                repository.Delete(repository.FindById(id));
                MessageBox.Show("suppression reussie");
                Name_txt.Text = "";
                Email_txt.Text = "";
                Password_txt.Text = "";
            }
        }

        private void AddProd_btn_Click(object sender, EventArgs e)
        {
            if (UserList_lvw.SelectedItems.Count < 1)
            {
                MessageBox.Show("veuillez selectionner un utilisateur");
            }
            else
            {
                ListViewItem viewItem = UserList_lvw.SelectedItems[0];
                string id = viewItem.SubItems[1].Text;
                UserRepository repository = new UserRepository(Mode.Binary, PATH);
                AddProduct_frm addProduct = new AddProduct_frm(repository.FindById(id), 0);
                addProduct.ShowDialog();
            }
        }

        private void EditProd_btn_Click(object sender, EventArgs e)
        {
            if (ProductList_lvw.SelectedItems.Count < 1)
            {
                MessageBox.Show("veuillez selectionner un produit");
            }
            else
            {
                ListViewItem viewItem = UserList_lvw.SelectedItems[0];
                string id = viewItem.SubItems[1].Text;
                UserRepository repository = new UserRepository(Mode.Binary, PATH);
                AddProduct_frm addProduct = new AddProduct_frm(repository.FindById(id), 1, repository.IndexOfProduct(repository.FindById(id), ProductList_lvw.SelectedItems[0].SubItems[0].Text));
                addProduct.ShowDialog();
            }
        }

        private void DeleteProd_btn_Click(object sender, EventArgs e)
        {
            if (ProductList_lvw.SelectedItems.Count < 1)
            {
                MessageBox.Show("veuillez selectionner un produit");
            }
            else
            {
                ListViewItem viewItem = UserList_lvw.SelectedItems[0];
                string id = viewItem.SubItems[1].Text;
                UserRepository repository = new UserRepository(Mode.Binary, PATH);
                AddProduct_frm addProduct = new AddProduct_frm(repository.FindById(id), 2, repository.IndexOfProduct(repository.FindById(id), ProductList_lvw.SelectedItems[0].SubItems[0].Text));
                addProduct.ShowDialog();
            }
        }

        private void Edit_frm_Load(object sender, EventArgs e)
        {
            Search_lvw.Visible = false;
            Save_btn.Visible = false;
            Refreshh();
        }

        private void Refreshh()
        {
            List<User> users = new UserRepository(Mode.Binary, PATH).GetAll();
            foreach (var item in users)
            {
                var lv = UserList_lvw.Items.Add(item.Name);
                lv.SubItems.Add(item.Id);
            }
        }

        private void Search_txt_TextChanged(object sender, EventArgs e)
        {
            if (Search_txt.Text == "")
            {
                Search_lvw.Visible = false;
            }
            else
            {
                Search_lvw.Visible = true;
                List<User> users = new UserRepository(Mode.Binary, PATH).FindByname(Search_txt.Text);
                foreach (var item in users)
                {
                    ListViewItem viewItem = Search_lvw.Items.Add(item.Name);
                    viewItem.SubItems.Add(item.Id);
                }
            }
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            if (Search_txt.Text == "")
            {
                MessageBox.Show("veuillez entrer le texte a rechercher");
            }
            else
            {
                List<User> users = new UserRepository(Mode.Binary, PATH).FindByname(Search_txt.Text);
                int i = 0;
                foreach (var item in users)
                {
                    ListViewItem viewItem = Search_lvw.Items.Add(item.Name);
                    viewItem.SubItems.Add(item.Id);
                    i++;
                }
                if (i < 1)
                    MessageBox.Show("aucun element ne correspond a votre recherche");
            }
        }

        private void Search_lvw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Search_lvw.SelectedItems.Count > 0)
            {
                string id = Search_lvw.SelectedItems[0].SubItems[1].Text;
                User user = new UserRepository(Mode.Binary, PATH).FindById(id);
                Search_lvw.Items.Clear();
                Search_lvw.Visible = false;
                UserList_lvw.Items.Clear();
                UserList_lvw.Items.Add(user.Name);
                UserList_lvw.Items[0].SubItems.Add(user.Id);
                Search_txt.Clear();
            }
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            ProductList_lvw.Items.Clear();
            UserList_lvw.Items.Clear();
            Total_txt.Clear();
            Refreshh();
        }

        private void UserList_lvw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserList_lvw.SelectedItems.Count > 0)
            {
                ProductList_lvw.Items.Clear();
                Total_txt.Clear();
                string id = UserList_lvw.SelectedItems[0].SubItems[1].Text;
                User user = new UserRepository(Mode.Binary, PATH).FindById(id);
                foreach (var item in user.Products)
                {
                    var lv = ProductList_lvw.Items.Add(item.Id);
                    lv.SubItems.Add(item.Name);
                    lv.SubItems.Add(item.Price.ToString());
                    lv.SubItems.Add(item.Quantity.ToString());
                }
                Total_txt.Text = user.GetTotal().ToString();
            }
        }

        private void SaveFile_btn_Click(object sender, EventArgs e)
        {
            if (UserList_lvw.SelectedItems.Count < 1)
                MessageBox.Show("veuillez selectionner un utilisateur");
            else
            {
                string id = UserList_lvw.SelectedItems[0].SubItems[1].Text;
                new IHM.Preview_frm(id).ShowDialog();
            }
        }
    }
}
