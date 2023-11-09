namespace HyperApplication.Forms
{
    partial class Form_server_cloud
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
            btn_confirm = new Button();
            btn_cancle = new Button();
            panel1 = new Panel();
            txt_cluod_url = new TextBox();
            p_title = new Panel();
            lbl_title = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            p_title.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_confirm
            // 
            btn_confirm.BackColor = Color.FromArgb(172, 164, 225);
            btn_confirm.Dock = DockStyle.Left;
            btn_confirm.FlatAppearance.BorderSize = 0;
            btn_confirm.FlatStyle = FlatStyle.Flat;
            btn_confirm.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_confirm.Location = new Point(0, 0);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(250, 100);
            btn_confirm.TabIndex = 0;
            btn_confirm.Text = "确定";
            btn_confirm.UseVisualStyleBackColor = false;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // btn_cancle
            // 
            btn_cancle.BackColor = Color.FromArgb(172, 164, 225);
            btn_cancle.Dock = DockStyle.Right;
            btn_cancle.FlatAppearance.BorderSize = 0;
            btn_cancle.FlatStyle = FlatStyle.Flat;
            btn_cancle.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancle.Location = new Point(250, 0);
            btn_cancle.Name = "btn_cancle";
            btn_cancle.Size = new Size(250, 100);
            btn_cancle.TabIndex = 1;
            btn_cancle.Text = "取消";
            btn_cancle.UseVisualStyleBackColor = false;
            btn_cancle.Click += btn_cancle_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_confirm);
            panel1.Controls.Add(btn_cancle);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 209);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 100);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // txt_cluod_url
            // 
            txt_cluod_url.BackColor = Color.FromArgb(126, 178, 248);
            txt_cluod_url.BorderStyle = BorderStyle.None;
            txt_cluod_url.Cursor = Cursors.IBeam;
            txt_cluod_url.Dock = DockStyle.Fill;
            txt_cluod_url.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txt_cluod_url.Location = new Point(0, 0);
            txt_cluod_url.Multiline = true;
            txt_cluod_url.Name = "txt_cluod_url";
            txt_cluod_url.Size = new Size(500, 159);
            txt_cluod_url.TabIndex = 3;
            txt_cluod_url.TextAlign = HorizontalAlignment.Center;
            txt_cluod_url.TextChanged += txt_cluod_url_TextChanged;
            // 
            // p_title
            // 
            p_title.Controls.Add(lbl_title);
            p_title.Dock = DockStyle.Top;
            p_title.Location = new Point(0, 0);
            p_title.Name = "p_title";
            p_title.Size = new Size(500, 50);
            p_title.TabIndex = 4;
            p_title.Paint += p_title_Paint;
            // 
            // lbl_title
            // 
            lbl_title.Dock = DockStyle.Fill;
            lbl_title.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_title.Location = new Point(0, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(500, 50);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "请输入云端服务器地址（包括监听端口）";
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            lbl_title.Click += lbl_title_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_cluod_url);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 159);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // Form_server_cloud
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 194, 227);
            ClientSize = new Size(500, 309);
            Controls.Add(panel2);
            Controls.Add(p_title);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_server_cloud";
            Text = "Form_server_cloud";
            panel1.ResumeLayout(false);
            p_title.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_confirm;
        private Button btn_cancle;
        private Panel panel1;
        private TextBox txt_cluod_url;
        private Panel p_title;
        private Label lbl_title;
        private Panel panel2;
    }
}