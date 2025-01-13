using MyFinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;
namespace MyFinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            // Banka Bakiyeleri
            var ZiraatBankasıBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var VakifbankBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).FirstOrDefault();
            var İsBankasiBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();

            lblZiraatBankBalance.Text = ZiraatBankasıBalance.ToString() + " ₺";
            lblVakifbankBalance.Text = VakifbankBalance.ToString() + " ₺";
            lblİsBankasiBalance.Text = İsBankasiBalance.ToString() + " ₺";
            // Banka Hareketleri
            var BankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = BankProcess1.Desciription + " " + BankProcess1.Amount + " " + BankProcess1.ProcessDate;   
            
            var BankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = BankProcess2.Desciription + " " + BankProcess2.Amount + " " + BankProcess2.ProcessDate; 
            
            var BankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = BankProcess3.Desciription + " " + BankProcess3.Amount + " " + BankProcess3.ProcessDate; 
            
            var BankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = BankProcess4.Desciription + " " + BankProcess4.Amount + " " + BankProcess4.ProcessDate; 
            
            var BankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = BankProcess5.Desciription + " " + BankProcess5.Amount + " " + BankProcess5.ProcessDate;
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Close();
        }
    }
}
