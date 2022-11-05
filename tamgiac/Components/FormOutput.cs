using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamgiac.Components
{
    public partial class FormOutput : Form
    {
        public FormOutput()
        {
            InitializeComponent();
        }

        public float a,b,c;

        private void FormOutput_Load(object sender, EventArgs e)
        {
            if (a < b + c && b < a + c && c < a + b)
            {
                if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
                    lblResult.Text = ("Đây là tam giác vuông");
                else if (a == b && b == c)
                    lblResult.Text = ("Đây là tam giác đều");
                else if (a == b || a == c || b == c)
                    lblResult.Text = ("Đây là tam giác cân");
                else if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > a * a + b * b)
                    lblResult.Text = ("Đây là tam giác tù");
                else
                    lblResult.Text = ("Đây là tam giác nhọn");
            }
            else
                lblResult.Text = $"Ba cạnh {a}, {b}, {c} không phải là ba cạnh của một tam giác";
        }
    }
}
