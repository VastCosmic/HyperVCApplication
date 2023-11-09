using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyperApplication.Forms
{
    public partial class Form_server_cloud : Form
    {
        public Form_server_cloud()
        {
            InitializeComponent();
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (txt_cluod_url.Text == "")
            {
                MessageBox.Show("请输入云服务器地址！");
                return;
            }
            else
            {
                // 读取 json 文件
                string json = File.ReadAllText("H:\\SRDP\\A_Final\\HyperApplication\\AppConfig\\app.json");
                JObject appJson = JObject.Parse(json);
                try
                {
                    // 更新配置文件
                    appJson["server_cloud_url"] = txt_cluod_url.Text;
                    // 写入 json 文件
                    File.WriteAllText("H:\\SRDP\\A_Final\\HyperApplication\\AppConfig\\app.json", appJson.ToString());
                    //MessageBox.Show("云服务器地址配置成功！");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.Close();
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_cluod_url_TextChanged(object sender, EventArgs e)
        {
        }

        private void p_title_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
