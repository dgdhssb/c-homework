namespace assignment6
{
    partial class DeleteOrder
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
            this.AllOrderLabel = new System.Windows.Forms.Label();
            this.AllOrderlistBox = new System.Windows.Forms.ListBox();
            this.ChooseDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllOrderLabel
            // 
            this.AllOrderLabel.AutoSize = true;
            this.AllOrderLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AllOrderLabel.Location = new System.Drawing.Point(636, 33);
            this.AllOrderLabel.Name = "AllOrderLabel";
            this.AllOrderLabel.Size = new System.Drawing.Size(202, 24);
            this.AllOrderLabel.TabIndex = 0;
            this.AllOrderLabel.Text = "点我查看所有订单";
            this.AllOrderLabel.Click += new System.EventHandler(this.AllOrderLabel_Click);
            // 
            // AllOrderlistBox
            // 
            this.AllOrderlistBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AllOrderlistBox.FormattingEnabled = true;
            this.AllOrderlistBox.ItemHeight = 24;
            this.AllOrderlistBox.Location = new System.Drawing.Point(12, 76);
            this.AllOrderlistBox.Name = "AllOrderlistBox";
            this.AllOrderlistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.AllOrderlistBox.Size = new System.Drawing.Size(1500, 748);
            this.AllOrderlistBox.TabIndex = 1;
            this.AllOrderlistBox.SelectedIndexChanged += new System.EventHandler(this.AllOrderlistBox_SelectedIndexChanged);
            // 
            // ChooseDeleteButton
            // 
            this.ChooseDeleteButton.BackColor = System.Drawing.Color.Moccasin;
            this.ChooseDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChooseDeleteButton.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChooseDeleteButton.Location = new System.Drawing.Point(614, 857);
            this.ChooseDeleteButton.Name = "ChooseDeleteButton";
            this.ChooseDeleteButton.Size = new System.Drawing.Size(278, 67);
            this.ChooseDeleteButton.TabIndex = 2;
            this.ChooseDeleteButton.Text = "选择删除确认";
            this.ChooseDeleteButton.UseVisualStyleBackColor = false;
            this.ChooseDeleteButton.Click += new System.EventHandler(this.ChooseDeleteButton_Click);
            // 
            // DeleteOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 1058);
            this.Controls.Add(this.ChooseDeleteButton);
            this.Controls.Add(this.AllOrderlistBox);
            this.Controls.Add(this.AllOrderLabel);
            this.Name = "DeleteOrder";
            this.Text = "DeleteOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AllOrderLabel;
        private System.Windows.Forms.ListBox AllOrderlistBox;
        private System.Windows.Forms.Button ChooseDeleteButton;
    }
}