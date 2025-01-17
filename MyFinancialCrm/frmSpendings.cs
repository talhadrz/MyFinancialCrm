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
    public partial class frmSpendings : Form
    {
        public frmSpendings()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void frmSpendings_Load(object sender, EventArgs e)
        {
            listele();
            var value = db.Categorys;
            cmbCategoriyId.DisplayMember = "CategoryName";
            cmbCategoriyId.ValueMember = "CategoryId";
            cmbCategoriyId.DataSource = db.Categorys.ToList();
            Edit.edit(this);
        }
        // Ekleme Silme Güncelleme Listeleme kodları
        private void listele()
        {
            var values = db.Spendings.Select(x => new
            {
                SpendingId= x.SpendingId,
                SpendingTitle = x.SpendingTitle,
                SpendingAmount = x.SpendingAmount,
                SpendingDate = x.SpendingDate,
                Category = x.Categorys.CategoryName
            });
            dataGridView1.DataSource = values.ToList();
        }

        private void btnSpendingsList_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnCreateSpendings_Click(object sender, EventArgs e)
        {
            Spendings spendings = new Spendings();
            spendings.SpendingTitle = txtSpendingTitle.Text;
            spendings.SpendingAmount = decimal.Parse(txtSpendingAmount.Text);
            spendings.SpendingDate = DateTime.Parse(mskSpendingDate.Text);
            spendings.CategoryId = int.Parse(cmbCategoriyId.SelectedValue.ToString());
            db.Spendings.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Ekleme işllemi başarılı!");
            listele();
        }

        private void btnRemoveSpendings_Click(object sender, EventArgs e)
        {
            db.Spendings.Remove(db.Spendings.Find(int.Parse(txtSpendingId.Text)));
            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı!");
            listele();
        }

        private void btnUpdateSpendings_Click(object sender, EventArgs e)
        {
            Spendings spendings = db.Spendings.Find(int.Parse(txtSpendingId.Text));
            spendings.SpendingTitle = txtSpendingTitle.Text;
            spendings.SpendingAmount = decimal.Parse(txtSpendingAmount.Text);
            spendings.SpendingDate = DateTime.Parse(mskSpendingDate.Text);
            spendings.CategoryId = int.Parse(cmbCategoriyId.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi Başarılı!");
            listele();
        }
        
        // Formlar Arasında Geçiş Yapma
        private void btnCatagoriys_Click(object sender, EventArgs e)
        {
            form.OpenForm(this, form.FormType.Categories);
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            form.OpenForm(this, form.FormType.Banks);
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            form.OpenForm(this, form.FormType.Billing);
        }

        private void btnBankProcesses_Click(object sender, EventArgs e) 
        {
            form.OpenForm(this, form.FormType.BankProcesses);
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            form.OpenForm(this, form.FormType.Dashboard);
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
