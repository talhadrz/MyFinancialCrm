using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrm.Models;
namespace MyFinancialCrm
{
    public partial class FrmDashbord : Form
    {

        public FrmDashbord()
        {
            InitializeComponent();
        }
        WebBrowser wb = new WebBrowser();
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        int countBill = 0;
        int countBankProcesses = 0;
        int countBalance = 0;
        List<Banks> banks;
        List<BankProcesses> processes;
        List<Bills> bills;
        private void FrmDashbord_Load(object sender, EventArgs e)
        {
            Edit.edit(this);

            wb.Navigate("https://www.tcmb.gov.tr/wps/wcm/connect/tr/tcmb+tr/main+page+site+area/bugun");
            wb.ScriptErrorsSuppressed = true;

            // Chart 1 Kodları
            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();
            chart1.Series.Clear();
            var Series = chart1.Series.Add("Series1");
            Series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            foreach (var item in bankData)
            {
                Series.Points.AddXY(item.BankTitle, item.BankBalance);
            }

            // chart 2 Kodları
            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();
            chart2.Series.Clear();
            var Series2 = chart2.Series.Add("Faturalar");
            Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            foreach (var item in billData)
            {
                Series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            bills = db.Bills.ToList();
            processes = db.BankProcesses.ToList();
            banks = db.Banks.ToList();
            // Tüm Faturaları Yazdırma
            {
                countBill++;
                var maxcount = bills.Max(x => x.BillId);
                bool dolumu = true;
                do
                {
                    var sayi = bills.Where(x => x.BillId == countBill).FirstOrDefault();
                    if (sayi != null)
                        dolumu = false;
                    else
                    {
                        countBill++;
                        if (countBill > maxcount)
                            countBill = 1;
                        dolumu = true;
                    }
                } while (dolumu);
                lblBillTitle.Text = bills.Where(x => x.BillId == countBill).Select(y => y.BillTitle).FirstOrDefault();
                lblBillAmount.Text = bills.Where(x => x.BillId == countBill).Select(y => y.BillAmount).FirstOrDefault() + "₺";
            }
            // Tüm Gelen Havaleleri Yazdırma
            {
                countBankProcesses++;
                var maxcount = processes.Max(x => x.BankId);
                bool dolumu = true;
                do
                {
                    var sayi = processes.Where(x => x.BankId == countBankProcesses).FirstOrDefault();
                    if (sayi != null)
                        dolumu = false;
                    else
                    {
                        countBankProcesses++;
                        if (countBankProcesses > maxcount)
                            countBankProcesses = 1;
                        dolumu = true;
                    }
                } while (dolumu);
                lblGelenHavale.Text = processes.Where(x => x.BankId == countBankProcesses).Select(y => y.Desciription).FirstOrDefault();
                lblLastBankProcessAmount.Text = processes.Where(x => x.BankId == countBankProcesses).Select(y => y.Amount).FirstOrDefault() + "₺";
            }
            // paraları yazdır
            if (countBalance == 0)
            {
                lblTotalBalance.Text = banks.Sum(x => x.BankBalance).ToString() + "₺";
            }
            else if (countBalance == 1)
            {
                int deger = paraDegeri("ABD DOLARI");
                double totalBalance = (double)(banks.Sum(x => x.BankBalance) ?? 0) / deger;
                lblTotalBalance.Text = $"{(int)totalBalance}.{(int)((totalBalance % 1) * 100):D2}$";
            }
            else
            {
                int deger = paraDegeri("EURO");
                double totalBalance = (double)(banks.Sum(x => x.BankBalance) ?? 0) / deger;
                lblTotalBalance.Text = $"{(int)totalBalance}.{(int)((totalBalance % 1) * 100):D2}€";
                countBalance = -1;
            }
            countBalance++;
        }
        private int paraDegeri(string tur, int deger = 1)
        {
            if (wb.ReadyState == WebBrowserReadyState.Complete)
            {
                foreach (HtmlElement row in wb.Document.GetElementsByTagName("tr"))
                {
                    foreach (HtmlElement cell in row.GetElementsByTagName("td"))
                    {
                        if (cell.GetAttribute("className") == "para" && cell.InnerText == tur)
                        {
                            HtmlElementCollection cellsInRow = row.GetElementsByTagName("td");
                            string dr1 = (cellsInRow[3].InnerText);
                            string dg2 = dr1.Split('.')[0];
                            deger = int.Parse(dg2);
                        }
                    }
                }
            }
            return deger;
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            form.OpenForm(this, form.FormType.Billing);
        }

        private void btnCatagoriys_Click(object sender, EventArgs e)
        {
            form.OpenForm(this, form.FormType.Categories);
        }
        private void btnBankProcesses_Click(object sender, EventArgs e)
        {
          form.OpenForm(this, form.FormType.BankProcesses);
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            form.OpenForm(this, form.FormType.Spendings);
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            form.OpenForm(this, form.FormType.Banks);
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
