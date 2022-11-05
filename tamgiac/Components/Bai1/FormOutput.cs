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
    public partial class FormOutput : Form
    {
        public FormOutput()
        {
            InitializeComponent();
        }

        public float a, b,kq;
        public string phepToan;
        private void FormOutput_Load(object sender, EventArgs e)
        {
            lblResult.Text = $" {a} {phepToan} {b} = {kq} ";
        }
    }
}
