using System.Windows.Forms;
using tamgiac.Components;

namespace tamgiac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            FormInput adu = new FormInput();
            adu.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            FormInput form = new FormInput();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Components.Bai1.FormInput form = new Components.Bai1.FormInput();
            form.ShowDialog();
        }
    }
}