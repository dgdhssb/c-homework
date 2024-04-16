namespace assignment6
{
    partial class FindOrders
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
            this.FindIDButton = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.OrderNameButton = new System.Windows.Forms.Button();
            this.CustomNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomNameButton = new System.Windows.Forms.Button();
            this.PriceButton = new System.Windows.Forms.Button();
            this.NumberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FindIDButton
            // 
            this.FindIDButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FindIDButton.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FindIDButton.Location = new System.Drawing.Point(647, 21);
            this.FindIDButton.Name = "FindIDButton";
            this.FindIDButton.Size = new System.Drawing.Size(233, 60);
            this.FindIDButton.TabIndex = 0;
            this.FindIDButton.Text = "订单号查询";
            this.FindIDButton.UseVisualStyleBackColor = false;
            this.FindIDButton.Click += new System.EventHandler(this.FindIDButton_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDTextBox.Location = new System.Drawing.Point(293, 42);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(202, 39);
            this.IDTextBox.TabIndex = 1;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResultLabel.Location = new System.Drawing.Point(469, 330);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(154, 24);
            this.ResultLabel.TabIndex = 2;
            this.ResultLabel.Text = "查询结果显示";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameTextBox.Location = new System.Drawing.Point(293, 154);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(202, 39);
            this.NameTextBox.TabIndex = 3;
            // 
            // OrderNameButton
            // 
            this.OrderNameButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderNameButton.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderNameButton.Location = new System.Drawing.Point(647, 129);
            this.OrderNameButton.Name = "OrderNameButton";
            this.OrderNameButton.Size = new System.Drawing.Size(233, 64);
            this.OrderNameButton.TabIndex = 4;
            this.OrderNameButton.Text = "商品名称查询";
            this.OrderNameButton.UseVisualStyleBackColor = false;
            this.OrderNameButton.Click += new System.EventHandler(this.OrderNameButton_Click);
            // 
            // CustomNameTextBox
            // 
            this.CustomNameTextBox.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CustomNameTextBox.Location = new System.Drawing.Point(293, 254);
            this.CustomNameTextBox.Name = "CustomNameTextBox";
            this.CustomNameTextBox.Size = new System.Drawing.Size(202, 39);
            this.CustomNameTextBox.TabIndex = 5;
            // 
            // CustomNameButton
            // 
            this.CustomNameButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CustomNameButton.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CustomNameButton.Location = new System.Drawing.Point(650, 241);
            this.CustomNameButton.Name = "CustomNameButton";
            this.CustomNameButton.Size = new System.Drawing.Size(230, 60);
            this.CustomNameButton.TabIndex = 6;
            this.CustomNameButton.Text = "客户姓名查询";
            this.CustomNameButton.UseVisualStyleBackColor = false;
            this.CustomNameButton.Click += new System.EventHandler(this.CustomNameButton_Click);
            // 
            // PriceButton
            // 
            this.PriceButton.BackColor = System.Drawing.Color.Gray;
            this.PriceButton.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PriceButton.Location = new System.Drawing.Point(1004, 52);
            this.PriceButton.Name = "PriceButton";
            this.PriceButton.Size = new System.Drawing.Size(198, 60);
            this.PriceButton.TabIndex = 7;
            this.PriceButton.Text = "总价格查询";
            this.PriceButton.UseVisualStyleBackColor = false;
            this.PriceButton.Click += new System.EventHandler(this.PriceButton_Click);
            // 
            // NumberButton
            // 
            this.NumberButton.BackColor = System.Drawing.Color.Gray;
            this.NumberButton.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NumberButton.Location = new System.Drawing.Point(1004, 170);
            this.NumberButton.Name = "NumberButton";
            this.NumberButton.Size = new System.Drawing.Size(199, 60);
            this.NumberButton.TabIndex = 8;
            this.NumberButton.Text = "总ID查询";
            this.NumberButton.UseVisualStyleBackColor = false;
            this.NumberButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // FindOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 910);
            this.Controls.Add(this.NumberButton);
            this.Controls.Add(this.PriceButton);
            this.Controls.Add(this.CustomNameButton);
            this.Controls.Add(this.CustomNameTextBox);
            this.Controls.Add(this.OrderNameButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.FindIDButton);
            this.Name = "FindOrders";
            this.Text = "FindOrders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindIDButton;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button OrderNameButton;
        private System.Windows.Forms.TextBox CustomNameTextBox;
        private System.Windows.Forms.Button CustomNameButton;
        private System.Windows.Forms.Button PriceButton;
        private System.Windows.Forms.Button NumberButton;
    }
}