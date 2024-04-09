namespace assignment6
{
    partial class OrderSystem
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
            this.OrderInName = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.GoodsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderInName
            // 
            this.OrderInName.AutoSize = true;
            this.OrderInName.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderInName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.OrderInName.Location = new System.Drawing.Point(365, 105);
            this.OrderInName.Name = "OrderInName";
            this.OrderInName.Size = new System.Drawing.Size(614, 72);
            this.OrderInName.TabIndex = 0;
            this.OrderInName.Text = "欢迎来到订单系统";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddButton.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddButton.ForeColor = System.Drawing.Color.Indigo;
            this.AddButton.Location = new System.Drawing.Point(308, 439);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(243, 129);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "新建订单";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FindButton.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FindButton.ForeColor = System.Drawing.Color.Indigo;
            this.FindButton.Location = new System.Drawing.Point(825, 439);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(243, 129);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "查询订单";
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteButton.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteButton.ForeColor = System.Drawing.Color.Indigo;
            this.DeleteButton.Location = new System.Drawing.Point(308, 680);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(243, 129);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "删除订单";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChangeButton.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChangeButton.ForeColor = System.Drawing.Color.Indigo;
            this.ChangeButton.Location = new System.Drawing.Point(825, 680);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(243, 129);
            this.ChangeButton.TabIndex = 4;
            this.ChangeButton.Text = "修改订单";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // GoodsButton
            // 
            this.GoodsButton.BackColor = System.Drawing.Color.Aqua;
            this.GoodsButton.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GoodsButton.Location = new System.Drawing.Point(573, 289);
            this.GoodsButton.Name = "GoodsButton";
            this.GoodsButton.Size = new System.Drawing.Size(225, 92);
            this.GoodsButton.TabIndex = 5;
            this.GoodsButton.Text = "写入商品";
            this.GoodsButton.UseVisualStyleBackColor = false;
            this.GoodsButton.Click += new System.EventHandler(this.GoodsButton_Click);
            // 
            // OrderSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 1003);
            this.Controls.Add(this.GoodsButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.OrderInName);
            this.Name = "OrderSystem";
            this.Text = "订单管理系统";
            this.Load += new System.EventHandler(this.OrderSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderInName;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button GoodsButton;
    }
}