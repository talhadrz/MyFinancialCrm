using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public class form
    {
        public enum FormType
        {
            BankProcesses,
            Banks,
            Billing,
            Categories,
            Dashboard,
            Spendings,
            settings
        }

        public static void OpenForm(Form Form, FormType formType)
        {
            Form New = null;
            switch (formType)
            {
                case FormType.BankProcesses:
                    New = new FrmBankProcesses();
                    break;
                case FormType.Banks:
                    New = new FrmBanks();
                    break;
                case FormType.Billing:
                    New = new FrmBilling();
                    break;
                case FormType.Categories:
                    New = new FrmCategoriys();
                    break;
                case FormType.Dashboard:
                    New = new FrmDashbord();
                    break;
                case FormType.Spendings:
                    New = new frmSpendings();
                    break;
                case FormType.settings:
                    Frmsettings frm = new Frmsettings();
                    frm.Show();
                    frm.form = Form;
                    Form.Hide();
                    return;
                default:
                    throw new ArgumentException("Geçersiz form tipi");
            }

            New.Show();
            Form.Hide();
        }
    }
}