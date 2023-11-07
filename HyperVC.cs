namespace HyperApplication
{
    public partial class HyperVC : Form
    {
        public HyperVC()
        {
            InitializeComponent();
        }

        private void Control_Add(Form form)
        {
            panel_background.Controls.Clear();    //�Ƴ����пؼ�
            form.TopLevel = false;      //����Ϊ�Ƕ�������
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //���ô���Ϊ�Ǳ߿���ʽ
            form.Dock = System.Windows.Forms.DockStyle.Fill;                  //������ʽ�Ƿ��������panel
            panel_background.Controls.Add(form);        //��Ӵ���
            form.Show();                      //��������
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {

        }

        private void btn_server_Click(object sender, EventArgs e)
        {

        }

        private void btn_setting_Click(object sender, EventArgs e)
        {

        }

        private void btn_data_Click(object sender, EventArgs e)
        {

        }
    }
}