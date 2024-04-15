namespace ClinicApp
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            lblclinicName = new Label();
            lblclinicAddr = new Label();
            lblclinicContact = new Label();
            lblclinicRating = new Label();
            lblDocExp = new Label();
            lblSpecialities = new Label();
            lblDocname = new Label();
            label5 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(82, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 30);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 35);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 1;
            label1.Text = "Select Clinic : ";
            // 
            // lblclinicName
            // 
            lblclinicName.AutoSize = true;
            lblclinicName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblclinicName.Location = new Point(82, 182);
            lblclinicName.Name = "lblclinicName";
            lblclinicName.Size = new Size(115, 23);
            lblclinicName.TabIndex = 2;
            lblclinicName.Text = "Select Clinic : ";
            // 
            // lblclinicAddr
            // 
            lblclinicAddr.AutoSize = true;
            lblclinicAddr.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblclinicAddr.Location = new Point(82, 241);
            lblclinicAddr.Name = "lblclinicAddr";
            lblclinicAddr.Size = new Size(115, 23);
            lblclinicAddr.TabIndex = 3;
            lblclinicAddr.Text = "Select Clinic : ";
            // 
            // lblclinicContact
            // 
            lblclinicContact.AutoSize = true;
            lblclinicContact.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblclinicContact.Location = new Point(82, 301);
            lblclinicContact.Name = "lblclinicContact";
            lblclinicContact.Size = new Size(115, 23);
            lblclinicContact.TabIndex = 4;
            lblclinicContact.Text = "Select Clinic : ";
            // 
            // lblclinicRating
            // 
            lblclinicRating.AutoSize = true;
            lblclinicRating.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblclinicRating.Location = new Point(82, 360);
            lblclinicRating.Name = "lblclinicRating";
            lblclinicRating.Size = new Size(115, 23);
            lblclinicRating.TabIndex = 5;
            lblclinicRating.Text = "Select Clinic : ";
            // 
            // lblDocExp
            // 
            lblDocExp.AutoSize = true;
            lblDocExp.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocExp.Location = new Point(654, 301);
            lblDocExp.Name = "lblDocExp";
            lblDocExp.Size = new Size(115, 23);
            lblDocExp.TabIndex = 10;
            lblDocExp.Text = "Select Clinic : ";
            // 
            // lblSpecialities
            // 
            lblSpecialities.AutoSize = true;
            lblSpecialities.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpecialities.Location = new Point(654, 241);
            lblSpecialities.Name = "lblSpecialities";
            lblSpecialities.Size = new Size(115, 23);
            lblSpecialities.TabIndex = 9;
            lblSpecialities.Text = "Select Clinic : ";
            // 
            // lblDocname
            // 
            lblDocname.AutoSize = true;
            lblDocname.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocname.Location = new Point(654, 182);
            lblDocname.Name = "lblDocname";
            lblDocname.Size = new Size(115, 23);
            lblDocname.TabIndex = 8;
            lblDocname.Text = "Select Clinic : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(654, 35);
            label5.Name = "label5";
            label5.Size = new Size(126, 23);
            label5.TabIndex = 7;
            label5.Text = "Select Doctor : ";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(654, 68);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(239, 30);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 540);
            Controls.Add(lblDocExp);
            Controls.Add(lblSpecialities);
            Controls.Add(lblDocname);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(lblclinicRating);
            Controls.Add(lblclinicContact);
            Controls.Add(lblclinicAddr);
            Controls.Add(lblclinicName);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label lblclinicName;
        private Label lblclinicAddr;
        private Label lblclinicContact;
        private Label lblclinicRating;
        private Label lblDocExp;
        private Label lblSpecialities;
        private Label lblDocname;
        private Label label5;
        private ComboBox comboBox2;
    }
}
