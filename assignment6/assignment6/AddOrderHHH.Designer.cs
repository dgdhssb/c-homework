namespace assignment6
{
    partial class AddOrderHHH
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NameIDButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GoodsListBox = new System.Windows.Forms.ListBox();
            this.EverythingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameLabel.Location = new System.Drawing.Point(128, 439);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(282, 52);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "订单人姓名";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameTextBox.Location = new System.Drawing.Point(499, 424);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(246, 67);
            this.NameTextBox.TabIndex = 1;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDLabel.Location = new System.Drawing.Point(139, 527);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(230, 52);
            this.IDLabel.TabIndex = 2;
            this.IDLabel.Text = "订单ID号";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDTextBox.Location = new System.Drawing.Point(499, 527);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(246, 67);
            this.IDTextBox.TabIndex = 3;
            // 
            // NameIDButton
            // 
            this.NameIDButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NameIDButton.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameIDButton.Location = new System.Drawing.Point(499, 676);
            this.NameIDButton.Name = "NameIDButton";
            this.NameIDButton.Size = new System.Drawing.Size(246, 101);
            this.NameIDButton.TabIndex = 5;
            this.NameIDButton.Text = "确认无误";
            this.NameIDButton.UseVisualStyleBackColor = false;
            this.NameIDButton.Click += new System.EventHandler(this.NameIDButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(454, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "点我查看全部商品";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // GoodsListBox
            // 
            this.GoodsListBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GoodsListBox.FormattingEnabled = true;
            this.GoodsListBox.ItemHeight = 21;
            this.GoodsListBox.Location = new System.Drawing.Point(319, 73);
            this.GoodsListBox.Name = "GoodsListBox";
            this.GoodsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.GoodsListBox.Size = new System.Drawing.Size(572, 319);
            this.GoodsListBox.TabIndex = 7;
            this.GoodsListBox.SelectedIndexChanged += new System.EventHandler(this.GoodsListBox_SelectedIndexChanged);
            // 
            // EverythingLabel
            // 
            this.EverythingLabel.AutoSize = true;
            this.EverythingLabel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EverythingLabel.ForeColor = System.Drawing.Color.Navy;
            this.EverythingLabel.Location = new System.Drawing.Point(77, 146);
            this.EverythingLabel.Name = "EverythingLabel";
            this.EverythingLabel.Size = new System.Drawing.Size(193, 60);
            this.EverythingLabel.TabIndex = 8;
            this.EverythingLabel.Text = " *选择右侧*\r\n多选框中商品";
            // 
            // AddOrderHHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 865);
            this.Controls.Add(this.EverythingLabel);
            this.Controls.Add(this.GoodsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameIDButton);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "AddOrderHHH";
            this.Text = "添加订单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button NameIDButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox GoodsListBox;
        private System.Windows.Forms.Label EverythingLabel;
    }
}