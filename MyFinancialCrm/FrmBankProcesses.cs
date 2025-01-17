using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrm.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
namespace MyFinancialCrm
{
    public partial class FrmBankProcesses : Form
    {
        public FrmBankProcesses()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            Listele();
            cmbBankProcessesBankId.DisplayMember = "BankTitle";
            cmbBankProcessesBankId.ValueMember = "BankId";
            cmbBankProcessesBankId.DataSource = db.Banks.ToList();
            Edit.edit(this);
        }
        // Ekleme Silme Güncelleme ve Listeleme Buton Kodları
        private void Listele()
        {
            var values = db.BankProcesses.Select(x => new
            {
                bankprocessıd = x.BankProcessId,
                desciription = x.Desciription,
                processdate = x.ProcessDate,
                processtype = x.ProcessType,
                amount = x.Amount,
                Bank = x.Banks.BankTitle
            });
            dataGridView1.DataSource = values.ToList();
        }

        private void btnBankProcessesList_Click(object sender, EventArgs e)
        {
           Listele();
        }

        private void btnCreateBankProcesses_Click(object sender, EventArgs e)
        {
            BankProcesses values = new BankProcesses();
            values.Desciription = txtBankProcessesDesciription.Text;
            values.ProcessDate = DateTime.Parse(mskBankProcessesDate.Text);
            values.ProcessType = txtBankProcessesProcessType.Text;
            values.Amount = decimal.Parse(txtBankProcessesAmount.Text);
            values.BankId = int.Parse(cmbBankProcessesBankId.SelectedValue.ToString());
            db.BankProcesses.Add(values);
            db.SaveChangesAsync();
            MessageBox.Show("Ekleme işlemi başarıı!");
            Listele();
        }

        private void btnRemoveBankProcesses_Click(object sender, EventArgs e)
        {
            db.BankProcesses.Remove(db.BankProcesses.Find(int.Parse(txtBankProcessesId.Text)));
            db.SaveChangesAsync();
            MessageBox.Show("Silme işlemi başarılı!");
            Listele();
        }

        private void btnUpdateBankProcesses_Click(object sender, EventArgs e)
        {
            BankProcesses value = db.BankProcesses.Find(int.Parse(txtBankProcessesId.Text));
            value.Desciription = txtBankProcessesDesciription.Text;
            value.ProcessDate = DateTime.Parse(mskBankProcessesDate.Text);
            value.ProcessType = txtBankProcessesProcessType.Text;
            value.Amount = decimal.Parse(txtBankProcessesAmount.Text);
            value.BankId = int.Parse(cmbBankProcessesBankId.SelectedValue.ToString());
            db.SaveChangesAsync();
            MessageBox.Show("Güncelleme işlemi başarılı!");
            Listele();
        }
        // Formlar Arasından Geçiş Yapma Bölümü
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

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            form.OpenForm(this, form.FormType.Dashboard);
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