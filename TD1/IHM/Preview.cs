using MaLibrairie.Serialisation;
using Microsoft.Reporting.WinForms;
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
    public partial class Preview_frm : Form
    {
        string id;
        public DirectoryInfo dir = Directory.CreateDirectory("Datas");
        public string PATH;
        public Preview_frm(string id)
        {
            InitializeComponent();
            this.PATH = Path.Combine(dir.FullName, "data.txt");
            this.id = id;
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            User user = new UserRepository(Mode.Binary, this.PATH).FindById(this.id);
            List<RptUserList> rptUsers = new List<RptUserList>();
            ReportParameter[] para = new ReportParameter[]
            {
                new ReportParameter("total", user.GetTotal().ToString()),
                new ReportParameter("name", user.Name)
            };
            foreach (var item in user.Products)
            {
                rptUsers.Add(new RptUserList(item.Id, item.Name, item.Price, item.Quantity));
            }
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", rptUsers));
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 150;
            this.reportViewer1.RefreshReport();
        }
    }
}
