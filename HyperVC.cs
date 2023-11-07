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
            panel_background.Controls.Clear();    //移除所有控件
            form.TopLevel = false;      //设置为非顶级窗体
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //设置窗体为非边框样式
            form.Dock = System.Windows.Forms.DockStyle.Fill;                  //设置样式是否填充整个panel
            panel_background.Controls.Add(form);        //添加窗体
            form.Show();                      //窗体运行
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