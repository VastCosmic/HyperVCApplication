namespace HyperApplication
{
    public partial class HyperVC : Form
    {
        public HyperVC()
        {
            InitializeComponent();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}