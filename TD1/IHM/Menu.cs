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
    public partial class Menu_frm : Form
    {
        public string id;
        public Menu_frm(string id)
        {
            InitializeComponent();
            this.changePasswordToolStripMenuItem.ShortcutKeys = ((Keys)((Keys.Control | Keys.P)));
            this.enregistrerToolStripMenuItem.ShortcutKeys = ((Keys)((Keys.Control | Keys.S)));
            this.id = id;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Edit_frm edit = new Edit_frm();
            edit.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword_frm change = new ChangePassword_frm();
            change.ShowDialog();
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new IHM.Preview_frm(this.id).ShowDialog();
        }
    }
}
