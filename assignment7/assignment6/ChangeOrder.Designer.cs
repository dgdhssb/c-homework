namespace assignment6
{
    partial class ChangeOrder
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
            this.OldIDTextBox = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ChangeIDLabel = new System.Windows.Forms.Label();
            this.ToChangeLabel = new System.Windows.Forms.Label();
            this.NewIDTextBox = new System.Windows.Forms.TextBox();
            this.NewNameLabel = new System.Windows.Forms.Label();
            this.NewNameTextBox = new System.Windows.Forms.TextBox();
            this.GoodsListBox = new System.Windows.Forms.ListBox();
            this.LookLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OldIDTextBox
            // 
            this.OldIDTextBox.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OldIDTextBox.Location = new System.Drawing.Point(686, 29);
            this.OldIDTextBox.Name = "OldIDTextBox";
            this.OldIDTextBox.Size = new System.Drawing.Size(309, 58);
            this.OldIDTextBox.TabIndex = 4;
            this.OldIDTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(549, 811);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(221, 70);
            this.ChangeButton.TabIndex = 5;
            this.ChangeButton.Text = "点击修改";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ChangeIDLabel
            // 
            this.ChangeIDLabel.AutoSize = true;
            this.ChangeIDLabel.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChangeIDLabel.Location = new System.Drawing.Point(253, 29);
            this.ChangeIDLabel.Name = "ChangeIDLabel";
            this.ChangeIDLabel.Size = new System.Drawing.Size(334, 52);
            this.ChangeIDLabel.TabIndex = 6;
            this.ChangeIDLabel.Text = "待修改订单ID";
            // 
            // ToChangeLabel
            // 
            this.ToChangeLabel.AutoSize = true;
            this.ToChangeLabel.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToChangeLabel.Location = new System.Drawing.Point(290, 128);
            this.ToChangeLabel.Name = "ToChangeLabel";
            this.ToChangeLabel.Size = new System.Drawing.Size(230, 52);
            this.ToChangeLabel.TabIndex = 7;
            this.ToChangeLabel.Text = "新订单ID";
            // 
            // NewIDTextBox
            // 
            this.NewIDTextBox.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewIDTextBox.Location = new System.Drawing.Point(686, 128);
            this.NewIDTextBox.Name = "NewIDTextBox";
            this.NewIDTextBox.Size = new System.Drawing.Size(309, 58);
            this.NewIDTextBox.TabIndex = 8;
            this.NewIDTextBox.TextChanged += new System.EventHandler(this.NewIDTextBox_TextChanged);
            // 
            // NewNameLabel
            // 
            this.NewNameLabel.AutoSize = true;
            this.NewNameLabel.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewNameLabel.Location = new System.Drawing.Point(253, 240);
            this.NewNameLabel.Name = "NewNameLabel";
            this.NewNameLabel.Size = new System.Drawing.Size(334, 52);
            this.NewNameLabel.TabIndex = 9;
            this.NewNameLabel.Text = "新订单人姓名";
            // 
            // NewNameTextBox
            // 
            this.NewNameTextBox.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewNameTextBox.Location = new System.Drawing.Point(686, 234);
            this.NewNameTextBox.Name = "NewNameTextBox";
            this.NewNameTextBox.Size = new System.Drawing.Size(309, 58);
            this.NewNameTextBox.TabIndex = 10;
            this.NewNameTextBox.TextChanged += new System.EventHandler(this.NewNameTextBox_TextChanged);
            // 
            // GoodsListBox
            // 
            this.GoodsListBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GoodsListBox.FormattingEnabled = true;
            this.GoodsListBox.ItemHeight = 21;
            this.GoodsListBox.Location = new System.Drawing.Point(359, 378);
            this.GoodsListBox.Name = "GoodsListBox";
            this.GoodsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.GoodsListBox.Size = new System.Drawing.Size(572, 319);
            this.GoodsListBox.TabIndex = 12;
            this.GoodsListBox.SelectedIndexChanged += new System.EventHandler(this.GoodsListBox_SelectedIndexChanged);
            // 
            // LookLabel
            // 
            this.LookLabel.AutoSize = true;
            this.LookLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LookLabel.Location = new System.Drawing.Point(519, 333);
            this.LookLabel.Name = "LookLabel";
            this.LookLabel.Size = new System.Drawing.Size(202, 24);
            this.LookLabel.TabIndex = 11;
            this.LookLabel.Text = "点我查看全部商品";
            this.LookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LookLabel.Click += new System.EventHandler(this.LookLabel_Click);
            // 
            // ChangeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 968);
            this.Controls.Add(this.GoodsListBox);
            this.Controls.Add(this.LookLabel);
            this.Controls.Add(this.NewNameTextBox);
            this.Controls.Add(this.NewNameLabel);
            this.Controls.Add(this.NewIDTextBox);
            this.Controls.Add(this.ToChangeLabel);
            this.Controls.Add(this.ChangeIDLabel);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.OldIDTextBox);
            this.Name = "ChangeOrder";
            this.Text = "ChangeOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OldIDTextBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label ChangeIDLabel;
        private System.Windows.Forms.Label ToChangeLabel;
        private System.Windows.Forms.TextBox NewIDTextBox;
        private System.Windows.Forms.Label NewNameLabel;
        private System.Windows.Forms.TextBox NewNameTextBox;
        private System.Windows.Forms.ListBox GoodsListBox;
        private System.Windows.Forms.Label LookLabel;
    }
}