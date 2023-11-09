namespace HyperApplication.Forms
{
    partial class Form_server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            server_p_info = new Panel();
            server_btn_github = new Button();
            server_p_cloud = new Panel();
            server_btn_config_cloud = new Button();
            server_lbl_cloud_txt = new Button();
            panel2 = new Panel();
            server_btn_config_run_cloud = new Button();
            server_btn_config_run_local = new Button();
            server_p_config = new Panel();
            server_btn_config_local = new Button();
            server_p_config_txt = new Panel();
            server_lbl_local_txt = new Button();
            server_p_status = new Panel();
            server_lbl_status_en = new Label();
            server_lbl_status_cn = new Label();
            server_lbl_status_txt = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            server_p_info.SuspendLayout();
            server_p_cloud.SuspendLayout();
            panel2.SuspendLayout();
            server_p_config.SuspendLayout();
            server_p_config_txt.SuspendLayout();
            server_p_status.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(server_p_info);
            panel1.Controls.Add(server_p_cloud);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(server_p_config);
            panel1.Controls.Add(server_p_status);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 670);
            panel1.TabIndex = 0;
            // 
            // server_p_info
            // 
            server_p_info.Controls.Add(server_btn_github);
            server_p_info.Dock = DockStyle.Fill;
            server_p_info.Location = new Point(0, 375);
            server_p_info.Name = "server_p_info";
            server_p_info.Size = new Size(1030, 170);
            server_p_info.TabIndex = 5;
            // 
            // server_btn_github
            // 
            server_btn_github.Dock = DockStyle.Fill;
            server_btn_github.FlatAppearance.BorderSize = 0;
            server_btn_github.FlatStyle = FlatStyle.Flat;
            server_btn_github.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            server_btn_github.Location = new Point(0, 0);
            server_btn_github.Name = "server_btn_github";
            server_btn_github.Size = new Size(1030, 170);
            server_btn_github.TabIndex = 0;
            server_btn_github.Text = "注意：本地服务器请选择HyperVC_Server的app.py脚本，云端服务器请输入地址，包括监听端口！单击以访问HyperVC_Server的详情信息。\r\n";
            server_btn_github.TextAlign = ContentAlignment.MiddleLeft;
            server_btn_github.UseVisualStyleBackColor = true;
            server_btn_github.Click += server_btn_github_Click;
            // 
            // server_p_cloud
            // 
            server_p_cloud.Controls.Add(server_btn_config_cloud);
            server_p_cloud.Controls.Add(server_lbl_cloud_txt);
            server_p_cloud.Dock = DockStyle.Top;
            server_p_cloud.Location = new Point(0, 250);
            server_p_cloud.Name = "server_p_cloud";
            server_p_cloud.Size = new Size(1030, 125);
            server_p_cloud.TabIndex = 4;
            // 
            // server_btn_config_cloud
            // 
            server_btn_config_cloud.BackColor = Color.FromArgb(116, 166, 168);
            server_btn_config_cloud.Dock = DockStyle.Fill;
            server_btn_config_cloud.FlatAppearance.BorderSize = 0;
            server_btn_config_cloud.FlatStyle = FlatStyle.Flat;
            server_btn_config_cloud.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            server_btn_config_cloud.Location = new Point(250, 0);
            server_btn_config_cloud.Name = "server_btn_config_cloud";
            server_btn_config_cloud.Size = new Size(780, 125);
            server_btn_config_cloud.TabIndex = 2;
            server_btn_config_cloud.Text = "（单击以更新服务器地址）";
            server_btn_config_cloud.TextAlign = ContentAlignment.MiddleLeft;
            server_btn_config_cloud.UseVisualStyleBackColor = false;
            server_btn_config_cloud.Click += server_btn_config_cloud_Click;
            // 
            // server_lbl_cloud_txt
            // 
            server_lbl_cloud_txt.BackColor = Color.FromArgb(172, 164, 225);
            server_lbl_cloud_txt.Dock = DockStyle.Left;
            server_lbl_cloud_txt.FlatAppearance.BorderSize = 0;
            server_lbl_cloud_txt.FlatStyle = FlatStyle.Flat;
            server_lbl_cloud_txt.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            server_lbl_cloud_txt.ForeColor = Color.Black;
            server_lbl_cloud_txt.Location = new Point(0, 0);
            server_lbl_cloud_txt.Name = "server_lbl_cloud_txt";
            server_lbl_cloud_txt.Size = new Size(250, 125);
            server_lbl_cloud_txt.TabIndex = 1;
            server_lbl_cloud_txt.Text = "云端服务器：";
            server_lbl_cloud_txt.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(server_btn_config_run_cloud);
            panel2.Controls.Add(server_btn_config_run_local);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 545);
            panel2.Name = "panel2";
            panel2.Size = new Size(1030, 125);
            panel2.TabIndex = 3;
            // 
            // server_btn_config_run_cloud
            // 
            server_btn_config_run_cloud.BackColor = Color.FromArgb(126, 178, 248);
            server_btn_config_run_cloud.Dock = DockStyle.Right;
            server_btn_config_run_cloud.FlatAppearance.BorderSize = 0;
            server_btn_config_run_cloud.FlatStyle = FlatStyle.Flat;
            server_btn_config_run_cloud.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            server_btn_config_run_cloud.Location = new Point(515, 0);
            server_btn_config_run_cloud.Name = "server_btn_config_run_cloud";
            server_btn_config_run_cloud.Size = new Size(515, 125);
            server_btn_config_run_cloud.TabIndex = 3;
            server_btn_config_run_cloud.Text = "启动（云端）";
            server_btn_config_run_cloud.UseVisualStyleBackColor = false;
            server_btn_config_run_cloud.Click += server_btn_config_run_cloud_Click;
            // 
            // server_btn_config_run_local
            // 
            server_btn_config_run_local.BackColor = Color.FromArgb(126, 178, 248);
            server_btn_config_run_local.Dock = DockStyle.Left;
            server_btn_config_run_local.FlatAppearance.BorderSize = 0;
            server_btn_config_run_local.FlatStyle = FlatStyle.Flat;
            server_btn_config_run_local.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            server_btn_config_run_local.Location = new Point(0, 0);
            server_btn_config_run_local.Name = "server_btn_config_run_local";
            server_btn_config_run_local.Size = new Size(515, 125);
            server_btn_config_run_local.TabIndex = 2;
            server_btn_config_run_local.Text = "启动（本地）";
            server_btn_config_run_local.UseVisualStyleBackColor = false;
            server_btn_config_run_local.Click += server_btn_config_run_local_Click;
            // 
            // server_p_config
            // 
            server_p_config.Controls.Add(server_btn_config_local);
            server_p_config.Controls.Add(server_p_config_txt);
            server_p_config.Dock = DockStyle.Top;
            server_p_config.Location = new Point(0, 125);
            server_p_config.Name = "server_p_config";
            server_p_config.Size = new Size(1030, 125);
            server_p_config.TabIndex = 2;
            // 
            // server_btn_config_local
            // 
            server_btn_config_local.BackColor = Color.FromArgb(116, 166, 168);
            server_btn_config_local.Dock = DockStyle.Fill;
            server_btn_config_local.FlatAppearance.BorderSize = 0;
            server_btn_config_local.FlatStyle = FlatStyle.Flat;
            server_btn_config_local.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            server_btn_config_local.Location = new Point(250, 0);
            server_btn_config_local.Name = "server_btn_config_local";
            server_btn_config_local.Size = new Size(780, 125);
            server_btn_config_local.TabIndex = 1;
            server_btn_config_local.Text = "（单击以选择服务器脚本）";
            server_btn_config_local.TextAlign = ContentAlignment.MiddleLeft;
            server_btn_config_local.UseVisualStyleBackColor = false;
            server_btn_config_local.Click += server_btn_config_local_Click;
            // 
            // server_p_config_txt
            // 
            server_p_config_txt.BackColor = Color.FromArgb(172, 164, 225);
            server_p_config_txt.Controls.Add(server_lbl_local_txt);
            server_p_config_txt.Dock = DockStyle.Left;
            server_p_config_txt.Location = new Point(0, 0);
            server_p_config_txt.Name = "server_p_config_txt";
            server_p_config_txt.Size = new Size(250, 125);
            server_p_config_txt.TabIndex = 0;
            // 
            // server_lbl_local_txt
            // 
            server_lbl_local_txt.Dock = DockStyle.Fill;
            server_lbl_local_txt.FlatAppearance.BorderSize = 0;
            server_lbl_local_txt.FlatStyle = FlatStyle.Flat;
            server_lbl_local_txt.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            server_lbl_local_txt.ForeColor = Color.Black;
            server_lbl_local_txt.Location = new Point(0, 0);
            server_lbl_local_txt.Name = "server_lbl_local_txt";
            server_lbl_local_txt.Size = new Size(250, 125);
            server_lbl_local_txt.TabIndex = 0;
            server_lbl_local_txt.Text = "本地服务器：";
            server_lbl_local_txt.UseVisualStyleBackColor = true;
            // 
            // server_p_status
            // 
            server_p_status.Controls.Add(server_lbl_status_en);
            server_p_status.Controls.Add(server_lbl_status_cn);
            server_p_status.Controls.Add(server_lbl_status_txt);
            server_p_status.Dock = DockStyle.Top;
            server_p_status.Location = new Point(0, 0);
            server_p_status.Name = "server_p_status";
            server_p_status.Size = new Size(1030, 125);
            server_p_status.TabIndex = 1;
            // 
            // server_lbl_status_en
            // 
            server_lbl_status_en.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            server_lbl_status_en.ForeColor = Color.DarkRed;
            server_lbl_status_en.Location = new Point(250, 68);
            server_lbl_status_en.Name = "server_lbl_status_en";
            server_lbl_status_en.Size = new Size(780, 57);
            server_lbl_status_en.TabIndex = 2;
            server_lbl_status_en.Text = "Server Status error!";
            // 
            // server_lbl_status_cn
            // 
            server_lbl_status_cn.BackColor = Color.FromArgb(244, 194, 227);
            server_lbl_status_cn.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            server_lbl_status_cn.ForeColor = Color.DarkRed;
            server_lbl_status_cn.Location = new Point(250, 0);
            server_lbl_status_cn.Name = "server_lbl_status_cn";
            server_lbl_status_cn.Size = new Size(780, 67);
            server_lbl_status_cn.TabIndex = 1;
            server_lbl_status_cn.Text = "未启动或连接至服务器!";
            server_lbl_status_cn.TextAlign = ContentAlignment.BottomLeft;
            // 
            // server_lbl_status_txt
            // 
            server_lbl_status_txt.BackColor = Color.FromArgb(172, 164, 225);
            server_lbl_status_txt.Dock = DockStyle.Left;
            server_lbl_status_txt.FlatAppearance.BorderSize = 0;
            server_lbl_status_txt.FlatStyle = FlatStyle.Flat;
            server_lbl_status_txt.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            server_lbl_status_txt.ForeColor = Color.Black;
            server_lbl_status_txt.Location = new Point(0, 0);
            server_lbl_status_txt.Name = "server_lbl_status_txt";
            server_lbl_status_txt.Size = new Size(250, 125);
            server_lbl_status_txt.TabIndex = 2;
            server_lbl_status_txt.Text = "服务器状态：";
            server_lbl_status_txt.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form_server
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 194, 227);
            ClientSize = new Size(1030, 670);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_server";
            Text = "Form_server";
            panel1.ResumeLayout(false);
            server_p_info.ResumeLayout(false);
            server_p_cloud.ResumeLayout(false);
            panel2.ResumeLayout(false);
            server_p_config.ResumeLayout(false);
            server_p_config_txt.ResumeLayout(false);
            server_p_status.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private Panel server_p_status;
        private Label server_lbl_status_cn;
        private Label server_lbl_status_en;
        private Panel server_p_config;
        private Panel server_p_config_txt;
        private Button server_lbl_local_txt;
        private Button server_lbl_status_txt;
        private Button server_btn_config_run_local;
        private Button server_btn_config_local;
        private Panel panel2;
        private Panel server_p_cloud;
        private Button server_lbl_cloud_txt;
        private Button server_btn_config_run_cloud;
        private Panel server_p_info;
        private Button server_btn_github;
        private Button server_btn_config_cloud;
    }
}