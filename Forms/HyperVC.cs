using HyperApplication.Forms;

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
            panel_background.Controls.Clear();    
            form.TopLevel = false;      
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; 
            form.Dock = System.Windows.Forms.DockStyle.Fill;                  
            panel_background.Controls.Add(form);        
            form.Show();                   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form_home form_home = new Form_home();
            Control_Add(form_home);
        }

        private void btn_server_Click(object sender, EventArgs e)
        {
            Form_server form_Server = new Form_server();
            Control_Add(form_Server);
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            Form_setting form_Setting = new Form_setting();
            Control_Add(form_Setting);
        }

        private void btn_data_Click(object sender, EventArgs e)
        {
            Form_data form_Data = new Form_data();
            Control_Add(form_Data);
        }
    }
}