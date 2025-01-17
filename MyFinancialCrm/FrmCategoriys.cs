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
    public partial class FrmCategoriys : Form
    {
        public FrmCategoriys()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmCategoriys_Load(object sender, EventArgs e)
        {
            btnCategoriyList_Click(sender, e);
            Edit.edit(this);
        }

        private void btnCategoriyList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Categorys.ToList();
        }

        private void btnCreateCategoriy_Click(object sender, EventArgs e)
        {
            Categorys categorys = new Categorys();
            categorys.CategoryName = txtCategoriyName.Text;
            db.Categorys.Add(categorys);
            db.SaveChanges();
            MessageBox.Show("Eklendi!");
        }

        private void btnRemoveCategoriy_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoriyId.Text);
            var value = db.Categorys.Where(x => x.CategoryId == id).FirstOrDefault();
            db.Categorys.Remove(value);
            db.SaveChanges();
            MessageBox.Show("Silindi!");
        }

        private void btnUpdateCategoriy_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoriyId.Text);
            string deger = txtCategoriyName.Text;
            var value = db.Categorys.Find(id);
            value.CategoryName = deger;
            db.SaveChanges();
            MessageBox.Show("Güncellendi!");
        }

        private void btnBaksForm_Click(object sender, EventArgs e)
        {
            form.OpenForm(this, form.FormType.Banks);
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            form.OpenForm(this, form.FormType.Billing);
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            form.OpenForm(this, form.FormType.Dashboard);
        }

        private void btnBankProcesses_Click(object sender, EventArgs e)
        {
            form.OpenForm(this, form.FormType.BankProcesses);
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            form.OpenForm(this, form.FormType.Spendings);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            form.OpenForm(this, form.FormType.settings);
        }
    }
}