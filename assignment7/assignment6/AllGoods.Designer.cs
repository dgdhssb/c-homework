namespace assignment6
{
    partial class AllGoods
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
            this.AllButton = new System.Windows.Forms.Button();
            this.OrderPriceTextBox = new System.Windows.Forms.TextBox();
            this.OrderPriceLabel = new System.Windows.Forms.Label();
            this.OrderNameTextBox = new System.Windows.Forms.TextBox();
            this.OrderNameLabel = new System.Windows.Forms.Label();
            this.OneOrderButton = new System.Windows.Forms.Button();
            this.AllOrderLabel = new System.Windows.Forms.Label();
            this.DeleteGoodsButton = new System.Windows.Forms.Button();
            this.SomethingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AllButton
            // 
            this.AllButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AllButton.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AllButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AllButton.Location = new System.Drawing.Point(398, 523);
            this.AllButton.Name = "AllButton";
            this.AllButton.Size = new System.Drawing.Size(256, 81);
            this.AllButton.TabIndex = 18;
            this.AllButton.Text = "全部完成";
            this.AllButton.UseVisualStyleBackColor = false;
            this.AllButton.Click += new System.EventHandler(this.AllButton_Click);
            // 
            // OrderPriceTextBox
            // 
            this.OrderPriceTextBox.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderPriceTextBox.Location = new System.Drawing.Point(418, 357);
            this.OrderPriceTextBox.Name = "OrderPriceTextBox";
            this.OrderPriceTextBox.Size = new System.Drawing.Size(246, 67);
            this.OrderPriceTextBox.TabIndex = 17;
            // 
            // OrderPriceLabel
            // 
            this.OrderPriceLabel.AutoSize = true;
            this.OrderPriceLabel.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderPriceLabel.Location = new System.Drawing.Point(58, 372);
            this.OrderPriceLabel.Name = "OrderPriceLabel";
            this.OrderPriceLabel.Size = new System.Drawing.Size(230, 52);
            this.OrderPriceLabel.TabIndex = 16;
            this.OrderPriceLabel.Text = "商品价格";
            // 
            // OrderNameTextBox
            // 
            this.OrderNameTextBox.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderNameTextBox.Location = new System.Drawing.Point(418, 209);
            this.OrderNameTextBox.Name = "OrderNameTextBox";
            this.OrderNameTextBox.Size = new System.Drawing.Size(246, 67);
            this.OrderNameTextBox.TabIndex = 15;
            // 
            // OrderNameLabel
            // 
            this.OrderNameLabel.AutoSize = true;
            this.OrderNameLabel.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderNameLabel.Location = new System.Drawing.Point(58, 224);
            this.OrderNameLabel.Name = "OrderNameLabel";
            this.OrderNameLabel.Size = new System.Drawing.Size(230, 52);
            this.OrderNameLabel.TabIndex = 14;
            this.OrderNameLabel.Text = "商品名称";
            // 
            // OneOrderButton
            // 
            this.OneOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.OneOrderButton.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OneOrderButton.Location = new System.Drawing.Point(808, 283);
            this.OneOrderButton.Name = "OneOrderButton";
            this.OneOrderButton.Size = new System.Drawing.Size(170, 68);
            this.OneOrderButton.TabIndex = 13;
            this.OneOrderButton.Text = "还加商品";
            this.OneOrderButton.UseVisualStyleBackColor = false;
            this.OneOrderButton.Click += new System.EventHandler(this.OneOrderButton_Click);
            // 
            // AllOrderLabel
            // 
            this.AllOrderLabel.AutoSize = true;
            this.AllOrderLabel.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AllOrderLabel.Location = new System.Drawing.Point(342, 71);
            this.AllOrderLabel.Name = "AllOrderLabel";
            this.AllOrderLabel.Size = new System.Drawing.Size(334, 52);
            this.AllOrderLabel.TabIndex = 12;
            this.AllOrderLabel.Text = "商品明细收集";
            // 
            // DeleteGoodsButton
            // 
            this.DeleteGoodsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DeleteGoodsButton.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteGoodsButton.Location = new System.Drawing.Point(87, 73);
            this.DeleteGoodsButton.Name = "DeleteGoodsButton";
            this.DeleteGoodsButton.Size = new System.Drawing.Size(158, 50);
            this.DeleteGoodsButton.TabIndex = 19;
            this.DeleteGoodsButton.Text = "清空商品";
            this.DeleteGoodsButton.UseVisualStyleBackColor = false;
            this.DeleteGoodsButton.Click += new System.EventHandler(this.DeleteGoodsButton_Click);
            // 
            // SomethingLabel
            // 
            this.SomethingLabel.AutoSize = true;
            this.SomethingLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SomethingLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SomethingLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SomethingLabel.Location = new System.Drawing.Point(794, 44);
            this.SomethingLabel.Name = "SomethingLabel";
            this.SomethingLabel.Size = new System.Drawing.Size(199, 63);
            this.SomethingLabel.TabIndex = 20;
            this.SomethingLabel.Text = "温馨提示：\r\n锁定或增加商品需要\r\n点击还加商品";
            this.SomethingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 720);
            this.Controls.Add(this.SomethingLabel);
            this.Controls.Add(this.DeleteGoodsButton);
            this.Controls.Add(this.AllButton);
            this.Controls.Add(this.OrderPriceTextBox);
            this.Controls.Add(this.OrderPriceLabel);
            this.Controls.Add(this.OrderNameTextBox);
            this.Controls.Add(this.OrderNameLabel);
            this.Controls.Add(this.OneOrderButton);
            this.Controls.Add(this.AllOrderLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AllGoods";
            this.Text = "AllGoods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AllButton;
        private System.Windows.Forms.TextBox OrderPriceTextBox;
        private System.Windows.Forms.Label OrderPriceLabel;
        private System.Windows.Forms.TextBox OrderNameTextBox;
        private System.Windows.Forms.Label OrderNameLabel;
        private System.Windows.Forms.Button OneOrderButton;
        private System.Windows.Forms.Label AllOrderLabel;
        private System.Windows.Forms.Button DeleteGoodsButton;
        private System.Windows.Forms.Label SomethingLabel;
    }
}