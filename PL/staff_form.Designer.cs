namespace Clinic_Management_System.PL
{
    partial class staff_form
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
            this.staff_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.staff_status = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.staff_contact_no = new System.Windows.Forms.TextBox();
            this.staff_address = new System.Windows.Forms.TextBox();
            this.staff_name = new System.Windows.Forms.TextBox();
            this.comboBox_staff_position = new System.Windows.Forms.ComboBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.birth_day = new System.Windows.Forms.DateTimePicker();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // staff_id
            // 
            this.staff_id.Location = new System.Drawing.Point(38, 23);
            this.staff_id.Name = "staff_id";
            this.staff_id.ReadOnly = true;
            this.staff_id.Size = new System.Drawing.Size(229, 33);
            this.staff_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الموظف";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_female);
            this.groupBox1.Controls.Add(this.radioButton_male);
            this.groupBox1.Controls.Add(this.birth_day);
            this.groupBox1.Controls.Add(this.staff_status);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.staff_contact_no);
            this.groupBox1.Controls.Add(this.staff_address);
            this.groupBox1.Controls.Add(this.staff_name);
            this.groupBox1.Controls.Add(this.staff_id);
            this.groupBox1.Controls.Add(this.comboBox_staff_position);
            this.groupBox1.Controls.Add(this.button_cancel);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Traditional Arabic", 12.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 527);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الموظفيـــن";
            // 
            // staff_status
            // 
            this.staff_status.Location = new System.Drawing.Point(38, 310);
            this.staff_status.Multiline = true;
            this.staff_status.Name = "staff_status";
            this.staff_status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.staff_status.Size = new System.Drawing.Size(229, 136);
            this.staff_status.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(279, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 26);
            this.label10.TabIndex = 22;
            this.label10.Text = "نبذة قصيرة";
            // 
            // staff_contact_no
            // 
            this.staff_contact_no.Location = new System.Drawing.Point(38, 213);
            this.staff_contact_no.Name = "staff_contact_no";
            this.staff_contact_no.Size = new System.Drawing.Size(229, 33);
            this.staff_contact_no.TabIndex = 7;
            // 
            // staff_address
            // 
            this.staff_address.Location = new System.Drawing.Point(38, 174);
            this.staff_address.Name = "staff_address";
            this.staff_address.Size = new System.Drawing.Size(229, 33);
            this.staff_address.TabIndex = 6;
            // 
            // staff_name
            // 
            this.staff_name.Location = new System.Drawing.Point(38, 62);
            this.staff_name.Name = "staff_name";
            this.staff_name.Size = new System.Drawing.Size(229, 33);
            this.staff_name.TabIndex = 2;
            // 
            // comboBox_staff_position
            // 
            this.comboBox_staff_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_staff_position.FormattingEnabled = true;
            this.comboBox_staff_position.Location = new System.Drawing.Point(38, 262);
            this.comboBox_staff_position.Name = "comboBox_staff_position";
            this.comboBox_staff_position.Size = new System.Drawing.Size(229, 32);
            this.comboBox_staff_position.TabIndex = 8;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(48, 472);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 31);
            this.button_cancel.TabIndex = 11;
            this.button_cancel.Text = "إلغاء";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(183, 472);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(84, 32);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "أضافة";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "الوظيــــفة";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "النــوع";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "رقم الموبايل";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "العنـــــــــــوان";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "تاريخ الميلاد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "إسم الموظف";
            // 
            // birth_day
            // 
            this.birth_day.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.birth_day.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birth_day.Location = new System.Drawing.Point(38, 137);
            this.birth_day.Name = "birth_day";
            this.birth_day.ShowCheckBox = true;
            this.birth_day.ShowUpDown = true;
            this.birth_day.Size = new System.Drawing.Size(229, 33);
            this.birth_day.TabIndex = 5;
            this.birth_day.Value = new System.DateTime(2017, 7, 14, 0, 0, 0, 0);
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Location = new System.Drawing.Point(205, 104);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(48, 30);
            this.radioButton_male.TabIndex = 3;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "ذكر";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(48, 100);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(47, 30);
            this.radioButton_female.TabIndex = 4;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "أنثي";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // staff_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 527);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Traditional Arabic", 12.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "staff_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الموظفيـــــــــن";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox staff_id;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox staff_status;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox staff_contact_no;
        public System.Windows.Forms.TextBox staff_address;
        public System.Windows.Forms.TextBox staff_name;
        public System.Windows.Forms.ComboBox comboBox_staff_position;
        public System.Windows.Forms.Button button_cancel;
        public System.Windows.Forms.Button button_add;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.DateTimePicker birth_day;
    }
}