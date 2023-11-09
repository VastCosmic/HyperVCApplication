using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HyperApplication.Forms
{
    public partial class Form_server : Form
    {
        public Form_server()
        {
            InitializeComponent();
            Load_Json();
        }

        public JObject Load_Json()
        {
            try
            {
                // 读取 json 文件
                string json = File.ReadAllText("H:\\SRDP\\A_Final\\HyperApplication\\AppConfig\\app.json");
                JObject appJson = JObject.Parse(json);
                try
                {
                    // 如果配置文件中不为空，加载配置文件中的配置
                    if (appJson["server_local_url"].ToString() != "")
                    {
                        server_btn_config_local.Text = appJson["server_local_url"].ToString();
                    }
                    if (appJson["server_cloud_url"].ToString() != "")
                    {
                        server_btn_config_cloud.Text = appJson["server_cloud_url"].ToString();
                    }
                    return appJson;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
                return appJson;
            }
            catch
            {
                MessageBox.Show("读取配置文件失败，请检查应用完整性！");
                Application.Exit();
            }
            return null;
        }

        private void server_btn_config_local_Click(object sender, EventArgs e)
        {
            // 打开文件对话框，选择服务器py启动脚本文件app.py
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Python|*.py";
            ofd.Title = "选择服务器启动脚本文件";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                server_btn_config_local.Text = ofd.FileName;
            }
            // 更新配置文件
            try
            {
                // 读取 json 文件
                string json = File.ReadAllText("H:\\SRDP\\A_Final\\HyperApplication\\AppConfig\\app.json");
                JObject appJson = JObject.Parse(json);
                try
                {
                    // 更新配置文件
                    appJson["server_local_url"] = ofd.FileName;
                    // 写入 json 文件
                    File.WriteAllText("H:\\SRDP\\A_Final\\HyperApplication\\AppConfig\\app.json", appJson.ToString());
                    //MessageBox.Show("本地服务器地址配置成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Restart();
                }
            }
            catch
            {
                MessageBox.Show("读取配置文件失败，请检查应用完整性！");
                Application.Restart();
            }
        }

        private void server_btn_github_Click(object sender, EventArgs e)
        {
            try
            {
                // 调用系统默认浏览器打开GitHub仓库
                Process.Start(new ProcessStartInfo("https://github.com/VastCosmic/HyperVC_ServerAPI") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Restart();
            }
        }

        private void server_btn_config_cloud_Click(object sender, EventArgs e)
        {
            // 打开对话框,输入服务器云端地址
            Form_server_cloud form_Server_Cloud = new Form_server_cloud();
            form_Server_Cloud.StartPosition = FormStartPosition.CenterScreen;
            form_Server_Cloud.ShowDialog();
            // 重新加载配置文件
            Load_Json();
        }

        private void server_btn_config_run_local_Click(object sender, EventArgs e)
        {
            // 启动本地服务器
            try
            {
                JObject appJson = Load_Json();
                if (appJson != null) { 
                    // 新建一个线程，启动本地服务器
                    Process p = new Process();
                    p.StartInfo.FileName = "python.exe";
                    p.StartInfo.Arguments = appJson["server_local_url"].ToString();
                    //p.StartInfo.UseShellExecute = true;
                    p.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Restart();
            }
        }

        private void server_btn_config_run_cloud_Click(object sender, EventArgs e)
        {
            
        }
    }
}
