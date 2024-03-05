namespace Work1_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("隶书", 26F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button1.ForeColor = Color.FromArgb(0, 64, 0);
            button1.Location = new Point(382, 463);
            button1.Name = "button1";
            button1.Size = new Size(381, 170);
            button1.TabIndex = 0;
            button1.Text = "点击运算";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(916, 245);
            label1.Name = "label1";
            label1.Size = new Size(180, 69);
            label1.TabIndex = 1;
            label1.Text = "..........";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 134);
            textBox1.Location = new Point(88, 246);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 74);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 134);
            textBox2.Location = new Point(650, 242);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 74);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.AppWorkspace;
            comboBox1.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 134);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1.Location = new Point(356, 246);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 72);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 799);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "计算器应用";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
    }
}
