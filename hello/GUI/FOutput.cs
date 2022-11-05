using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello.GUI
{
    public partial class FOutput : Form
    {


        public float soA, soB;
        public string pheptoan;
        public float ketqua;

        private void FOutput_Load(object sender, EventArgs e)
        {
            txtKq.Text = soA.ToString() + pheptoan + soB.ToString() + " = " + ketqua.ToString();
        }

        public FOutput()
        {
            InitializeComponent();
        }

        
    }
}
