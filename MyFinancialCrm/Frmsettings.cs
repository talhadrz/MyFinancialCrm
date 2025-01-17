using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MyFinancialCrm
{
    public partial class Frmsettings : Form
    {
        public Frmsettings()
        {
            InitializeComponent();
        }
        public Form form;
        private Color colorFore;
        private Color colorBack;
        private Font font;
        private FormBorderStyle formstyle;
        string[] size = new string[2];
        private void Frmsettings_Load(object sender, EventArgs e)
        {
            // Renkleri combobox'lara ekle
            cmbBackColor.Items.AddRange(Enum.GetNames(typeof(KnownColor)));
            cmbForeColor.Items.AddRange(Enum.GetNames(typeof(KnownColor)));
            cmbForm.Items.AddRange(Enum.GetNames(typeof(FormBorderStyle)));

            // Varsayılan renkleri ayarla
            cmbBackColor.Text = properties.backcolor.ToKnownColor().ToString();
            cmbForeColor.Text = properties.forecolor.ToKnownColor().ToString();
            cmbForm.Text = properties.formBorderStyle.ToString();
            // Boyutları ayarla
            mskSize.Text = $"{properties.size.Width}-{properties.size.Height}";

            // Fontları combobox'a ekle
            cmbFontName.Items.AddRange(new InstalledFontCollection().Families.Select(f => f.Name).ToArray());

            // Varsayılan font bilgilerini ayarla
            cmbFontName.Text = properties.font.Name;
            txtFontSize.Text = properties.font.Size.ToString();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }
        private bool kontrol()
        {
            size = mskSize.Text.Split('-');
            colorFore = Color.FromName(cmbForeColor.Text);
            colorBack = Color.FromName(cmbBackColor.Text);
            formstyle = (FormBorderStyle)Enum.Parse(typeof(FormBorderStyle), cmbForm.Text);
            try
            {
                font = new Font(cmbFontName.Text, float.Parse(txtFontSize.Text));
                if (!(size.Length == 2 & colorFore.IsKnownColor & colorFore.IsNamedColor & colorBack.IsKnownColor & colorBack.IsNamedColor))
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        private void btnYes2_Click(object sender, EventArgs e)
        {
            if (kontrol())
            {
                properties.forecolor = colorFore;
                properties.backcolor = colorBack;
                properties.size = new Size(int.Parse(size[0]), int.Parse(size[1]));
                properties.font = font;
                properties.formBorderStyle = formstyle;
                MessageBox.Show("Kayıt Başarılı");
                Edit.edit(form);
                form.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hata");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            if (kontrol())
            {
                this.ForeColor = colorFore;
                this.BackColor = colorBack;
                this.Size = new Size(int.Parse(size[0]), int.Parse(size[1]));
                this.Font = font;
                this.FormBorderStyle = formstyle;
            }
            else
                MessageBox.Show("Hata");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            this.BackColor = Color.FromName("ActiveCaption");
            this.ForeColor = Color.FromName("ControlText");
            this.Size = new Size(700, 720);
            this.Font = new Font("Calibri", 8);
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
