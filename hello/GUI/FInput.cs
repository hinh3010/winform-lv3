using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hello.GUI
{
    public partial class FInput : Form
    {
        public FInput()
        {
            InitializeComponent();
        }

        private void lblCong_Click(object sender , EventArgs e)
        {
            FOutput frm = new FOutput();
            frm.pheptoan = "+";
            frm.soA = float.Parse(adu1.Text);
            frm.soB = float.Parse(adu2.Text);
            // frm.ketqua = float.Parse(txtA.Text) + float.Parse(txtB.Text);
            frm.ShowDialog();
        }
    }
}
