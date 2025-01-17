using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrm.Models;
namespace MyFinancialCrm
{
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (db.Users.Where(x => x.UserName == txtName.Text).FirstOrDefault() == null)
                MessageBox.Show($"{txtName.Text} İsmi Bulunmamaktadır!");
            else if (db.Users.Where(x => x.UserName == txtName.Text).Select(y => y.Password).FirstOrDefault() != txtPassword.Text)
                MessageBox.Show($"{txtName.Text} İsminin Şifresi Yanlıştır!");
            else
                form.OpenForm(this, form.FormType.Dashboard);
        }
    }
}
