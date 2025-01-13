using MyFinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MyFinancialCrm
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }
        MyFinancialCrm.Models.FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string Title = txtBillTitle.Text;
            decimal Amount = decimal.Parse(txtBillAmount.Text);
            string Period = txtBillPeriod.Text;

            Bills bills = new Bills();
            bills.BillTitle = Title;
            bills.BillAmount = Amount;
            bills.BillPeriod = Period;
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sisteme Eklendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var RemoveValue = db.Bills.Find(id);
            db.Bills.Remove(RemoveValue);

            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sistemden Silindi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string Title = txtBillTitle.Text;
            decimal Amount = decimal.Parse(txtBillAmount.Text);
            string Period = txtBillPeriod.Text;
            int id = int.Parse(txtBillId.Text);

            var values = db.Bills.Find(id);
            
            values.BillTitle = Title;
            values.BillAmount = Amount;
            values.BillPeriod = Period;
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sistemde Güncellendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.Bills.ToList();
            dataGridView1.DataSource = values2;
        }

        private void btnBaksForm_Click(object sender, EventArgs e)
        {
            FrmBanks Frm = new FrmBanks();
            Frm.Show();
            this.Hide();
        }

      
    }
}
