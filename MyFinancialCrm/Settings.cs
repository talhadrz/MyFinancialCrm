using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public class properties
    {
        public static Size size { get; set; } = new Size(1200, 750);
        public static Color backcolor { get; set; } = Color.FromKnownColor(KnownColor.ActiveCaption);
        public static Color forecolor { get; set; } = Color.FromKnownColor(KnownColor.ActiveCaptionText);
        public static Font font { get; set; } = new Font("Calibri", 8f);
        public static FormBorderStyle formBorderStyle { get; set; } = FormBorderStyle.None;
    }
    public class Edit
    {
        public static void edit(Form form)
        {
            form.BackColor = properties.backcolor;
            form.ForeColor = properties.forecolor;
            form.Size = new Size(properties.size.Width, properties.size.Height);
            form.Font = properties.font;
            form.FormBorderStyle = properties.formBorderStyle;
        }
    }
}
