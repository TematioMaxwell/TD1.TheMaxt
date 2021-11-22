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
    public partial class AddProduct_frm : Form
    {
        private User user;

        public int Option = 0;

        public DirectoryInfo dir = Directory.CreateDirectory("Datas");
        public string PATH;
        int indexProduct;
        public AddProduct_frm(BO.User user, int option, int indexProd = default)
        {
            InitializeComponent();
            this.user = user;
            this.Option = option;
            this.PATH = Path.Combine(dir.FullName, "data.txt");
            this.indexProduct = indexProd;
        }

        private void Finish_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Again_btn_Click(object sender, EventArgs e)
        {
            if (Again_btn.Text == "Add")
            {
                if (Reference_txt.Text == "" || Name_txt.Text == "" || Price_txt.Text == "")
                {
                    MessageBox.Show("un des champs est vide veuillez le remplir");
                }
                else
                {
                    try
                    {
                        Product product = new Product(Reference_txt.Text, Name_txt.Text, Convert.ToDouble(Price_txt.Text), int.Parse(Quantity_txt.Text));
                        UserRepository repository = new UserRepository(Mode.Binary, this.PATH);
                        User oldUser = this.user;
                        repository.AddProduct(this.user, product);
                        repository.Set(oldUser, user);
                        MessageBox.Show("produit ajoute avec succes");
                        Reference_txt.Text = "";
                        Name_txt.Text = "";
                        Quantity_txt.Clear();
                        Price_txt.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (Again_btn.Text == "Set")
            {
                try
                {
                    Product product = new Product(Reference_txt.Text, Name_txt.Text, Convert.ToDouble(Price_txt.Text), int.Parse(Quantity_txt.Text));
                    UserRepository repository = new UserRepository(Mode.Binary, this.PATH);
                    User oldUser = this.user;
                    repository.SetProduct(this.user, this.user.Products[indexProduct], product);
                    repository.Set(oldUser, user);
                    MessageBox.Show("modification reussie");
                    Reference_txt.Clear();
                    Price_txt.Clear();
                    Name_txt.Clear();
                    Quantity_txt.Clear();
                    Again_btn.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    Product product = new Product(Reference_txt.Text, Name_txt.Text, Convert.ToDouble(Price_txt.Text), int.Parse(Quantity_txt.Text));
                    UserRepository repository = new UserRepository(Mode.Binary, this.PATH);
                    User oldUser = this.user;
                    repository.DeleteProduct(this.user, product);
                    repository.Set(oldUser, user);
                    MessageBox.Show("suppression reussie");
                    Reference_txt.Clear();
                    Price_txt.Clear();
                    Name_txt.Clear();
                    Quantity_txt.Clear();
                    Again_btn.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddProduct_frm_Load(object sender, EventArgs e)
        {
            if (this.Option == 0)
                Again_btn.Text = "Add";
            else if (this.Option == 1)
            {
                Again_btn.Text = "Set";
                Reference_txt.Enabled = false;
                UserRepository repository = new UserRepository(Mode.Binary, this.PATH);
                Reference_txt.Text = this.user.Products[this.indexProduct].Id;
                Name_txt.Text = this.user.Products[this.indexProduct].Name;
                Price_txt.Text = this.user.Products[this.indexProduct].Price.ToString();
                Quantity_txt.Text = this.user.Products[this.indexProduct].Quantity.ToString();
            }
            else
            {
                Again_btn.Text = "Delete";
                Price_txt.Enabled = false;
                Name_txt.Enabled = false;
                Reference_txt.Enabled = false;
                Quantity_txt.Enabled = false;
                Reference_txt.Text = this.user.Products[this.indexProduct].Id;
                Name_txt.Text = this.user.Products[this.indexProduct].Name;
                Price_txt.Text = this.user.Products[this.indexProduct].Price.ToString();
                Quantity_txt.Text = this.user.Products[this.indexProduct].Quantity.ToString();
            }
        }
    }
}