namespace D2LinqCF
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
            lbl_fullName = new Label();
            txt_fullName = new TextBox();
            label1 = new Label();
            lbl_age = new Label();
            txt_age = new TextBox();
            lbl_address = new Label();
            txt_address = new TextBox();
            cmbBox_depts = new ComboBox();
            lbl_dept = new Label();
            lbl_search = new Label();
            textBox4 = new TextBox();
            DG_stds = new DataGridView();
            label2 = new Label();
            button1 = new Button();
            txt_message = new TextBox();
            btn_reset = new Button();
            ((System.ComponentModel.ISupportInitialize)DG_stds).BeginInit();
            SuspendLayout();
            // 
            // lbl_fullName
            // 
            lbl_fullName.AutoSize = true;
            lbl_fullName.BackColor = Color.FromArgb(64, 64, 64);
            lbl_fullName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_fullName.ForeColor = Color.FromArgb(255, 128, 0);
            lbl_fullName.Location = new Point(27, 146);
            lbl_fullName.Name = "lbl_fullName";
            lbl_fullName.Size = new Size(129, 32);
            lbl_fullName.TabIndex = 0;
            lbl_fullName.Text = "Full Name";
            // 
            // txt_fullName
            // 
            txt_fullName.BackColor = Color.White;
            txt_fullName.Font = new Font("Segoe UI", 13F);
            txt_fullName.Location = new Point(246, 146);
            txt_fullName.Multiline = true;
            txt_fullName.Name = "txt_fullName";
            txt_fullName.Size = new Size(281, 41);
            txt_fullName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 245);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // lbl_age
            // 
            lbl_age.AutoSize = true;
            lbl_age.BackColor = Color.FromArgb(64, 64, 64);
            lbl_age.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_age.ForeColor = Color.FromArgb(255, 128, 0);
            lbl_age.Location = new Point(27, 213);
            lbl_age.Name = "lbl_age";
            lbl_age.Size = new Size(59, 32);
            lbl_age.TabIndex = 3;
            lbl_age.Text = "Age";
            lbl_age.Click += label2_Click;
            // 
            // txt_age
            // 
            txt_age.BackColor = Color.White;
            txt_age.Font = new Font("Segoe UI", 13F);
            txt_age.Location = new Point(246, 213);
            txt_age.Multiline = true;
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(281, 43);
            txt_age.TabIndex = 4;
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.BackColor = Color.FromArgb(64, 64, 64);
            lbl_address.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_address.ForeColor = Color.FromArgb(255, 128, 0);
            lbl_address.Location = new Point(27, 290);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(119, 32);
            lbl_address.TabIndex = 5;
            lbl_address.Text = "Addreess";
            // 
            // txt_address
            // 
            txt_address.BackColor = Color.White;
            txt_address.Font = new Font("Segoe UI", 13F);
            txt_address.Location = new Point(246, 290);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(281, 45);
            txt_address.TabIndex = 6;
            // 
            // cmbBox_depts
            // 
            cmbBox_depts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBox_depts.Font = new Font("Segoe UI", 13F);
            cmbBox_depts.FormattingEnabled = true;
            cmbBox_depts.Items.AddRange(new object[] { ".NET", "Cyber security", "Java ", "Flutter", "AI" });
            cmbBox_depts.Location = new Point(246, 370);
            cmbBox_depts.Name = "cmbBox_depts";
            cmbBox_depts.Size = new Size(281, 38);
            cmbBox_depts.TabIndex = 7;
            cmbBox_depts.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lbl_dept
            // 
            lbl_dept.AutoSize = true;
            lbl_dept.BackColor = Color.FromArgb(64, 64, 64);
            lbl_dept.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_dept.ForeColor = Color.FromArgb(255, 128, 0);
            lbl_dept.Location = new Point(27, 372);
            lbl_dept.Name = "lbl_dept";
            lbl_dept.Size = new Size(152, 32);
            lbl_dept.TabIndex = 8;
            lbl_dept.Text = "Department";
            // 
            // lbl_search
            // 
            lbl_search.AutoSize = true;
            lbl_search.BackColor = Color.FromArgb(64, 64, 64);
            lbl_search.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbl_search.ForeColor = Color.FromArgb(255, 128, 0);
            lbl_search.Location = new Point(826, 46);
            lbl_search.Name = "lbl_search";
            lbl_search.Size = new Size(111, 41);
            lbl_search.TabIndex = 9;
            lbl_search.Text = "Search";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.Font = new Font("Segoe UI", 13F);
            textBox4.Location = new Point(754, 144);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(291, 46);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // DG_stds
            // 
            DG_stds.BackgroundColor = Color.White;
            DG_stds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_stds.Location = new Point(631, 215);
            DG_stds.Name = "DG_stds";
            DG_stds.RowHeadersWidth = 51;
            DG_stds.Size = new Size(593, 210);
            DG_stds.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(174, 44);
            label2.Name = "label2";
            label2.Size = new Size(196, 41);
            label2.TabIndex = 12;
            label2.Text = "Add Student";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(27, 484);
            button1.Name = "button1";
            button1.Size = new Size(199, 60);
            button1.TabIndex = 13;
            button1.Text = "FINISH";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txt_message
            // 
            txt_message.BackColor = Color.FromArgb(64, 64, 64);
            txt_message.BorderStyle = BorderStyle.None;
            txt_message.Font = new Font("Segoe UI", 16F);
            txt_message.ForeColor = Color.Red;
            txt_message.Location = new Point(232, 484);
            txt_message.Multiline = true;
            txt_message.Name = "txt_message";
            txt_message.Size = new Size(295, 51);
            txt_message.TabIndex = 14;
            txt_message.TextChanged += txt_message_TextChanged;
            // 
            // btn_reset
            // 
            btn_reset.BackColor = Color.FromArgb(64, 64, 64);
            btn_reset.FlatStyle = FlatStyle.Flat;
            btn_reset.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_reset.ForeColor = Color.FromArgb(255, 128, 0);
            btn_reset.Location = new Point(980, 484);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(208, 60);
            btn_reset.TabIndex = 16;
            btn_reset.Text = "RESET";
            btn_reset.UseVisualStyleBackColor = false;
            btn_reset.Click += btn_reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1249, 588);
            Controls.Add(btn_reset);
            Controls.Add(txt_message);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(DG_stds);
            Controls.Add(textBox4);
            Controls.Add(lbl_search);
            Controls.Add(lbl_dept);
            Controls.Add(cmbBox_depts);
            Controls.Add(txt_address);
            Controls.Add(lbl_address);
            Controls.Add(txt_age);
            Controls.Add(lbl_age);
            Controls.Add(label1);
            Controls.Add(txt_fullName);
            Controls.Add(lbl_fullName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DG_stds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_fullName;
        private TextBox txt_fullName;
        private Label label1;
        private Label lbl_age;
        private TextBox txt_age;
        private Label lbl_address;
        private TextBox txt_address;
        private ComboBox cmbBox_depts;
        private Label lbl_dept;
        private Label lbl_search;
        private TextBox textBox4;
        private DataGridView DG_stds;
        private Label label2;
        private Button button1;
        private TextBox txt_message;
        private Button btn_reset;
    }
}