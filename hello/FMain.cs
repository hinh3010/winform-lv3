namespace hello
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            GUI.FInput frm = new GUI.FInput();
            frm.ShowDialog();
        }
    }
}