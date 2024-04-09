namespace assignment6
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.UserName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LogOnName = new System.Windows.Forms.Label();
            this.UserPassword = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.UserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UserName.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserName.Location = new System.Drawing.Point(332, 259);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(181, 52);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "用户名";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(600, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 67);
            this.textBox1.TabIndex = 1;
            // 
            // LogOnName
            // 
            this.LogOnName.AutoSize = true;
            this.LogOnName.Font = new System.Drawing.Font("幼圆", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LogOnName.Location = new System.Drawing.Point(410, 59);
            this.LogOnName.Name = "LogOnName";
            this.LogOnName.Size = new System.Drawing.Size(539, 84);
            this.LogOnName.TabIndex = 2;
            this.LogOnName.Text = "订单管理登录";
            // 
            // UserPassword
            // 
            this.UserPassword.AutoSize = true;
            this.UserPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UserPassword.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserPassword.Location = new System.Drawing.Point(358, 391);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(128, 52);
            this.UserPassword.TabIndex = 4;
            this.UserPassword.Text = "密码";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(600, 376);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(309, 67);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // UserButton
            // 
            this.UserButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UserButton.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserButton.ForeColor = System.Drawing.Color.MediumOrchid;
            this.UserButton.Location = new System.Drawing.Point(521, 585);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(294, 101);
            this.UserButton.TabIndex = 6;
            this.UserButton.Text = "准备好了";
            this.UserButton.UseVisualStyleBackColor = false;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 927);
            this.Controls.Add(this.UserButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.LogOnName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UserName);
            this.Name = "Form1";
            this.Text = "订单管理登录系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LogOnName;
        private System.Windows.Forms.Label UserPassword;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button UserButton;
    }
}

