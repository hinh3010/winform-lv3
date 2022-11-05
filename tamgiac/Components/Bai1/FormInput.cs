using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamgiac.Components.Bai1
{
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }

        float? StringToFloat(string input)
        {
            float tempVal;
            if (float.TryParse(input, out tempVal) )
                return tempVal  ;
            return null;
        }

        float canhA, canhB;
        FormOutput form = new FormOutput();

        private void btnResult_Click(object sender, EventArgs e)
        {
            canhA = float.Parse(txtA.Text);
            canhB = float.Parse(txtB.Text);

            form.a = canhA;
            form.b = canhB;
            form.kq = canhA + canhB;
            form.phepToan = "+";
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            canhA = float.Parse(txtA.Text);
            canhB = float.Parse(txtB.Text);

            form.a = canhA;
            form.b = canhB;
            form.kq = canhA * canhB;
            form.phepToan = "*";
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            canhA = float.Parse(txtA.Text);
            canhB = float.Parse(txtB.Text);

            form.a = canhA;
            form.b = canhB;
            form.kq = canhA / canhB;
            form.phepToan = "/";
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            canhA = float.Parse(txtA.Text);
            canhB = float.Parse(txtB.Text);

            form.a = canhA;
            form.b = canhB;
            form.kq = canhA - canhB;
            form.phepToan = "-";
            form.ShowDialog();
        }
    }
}
