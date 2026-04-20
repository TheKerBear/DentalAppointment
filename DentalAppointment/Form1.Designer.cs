namespace DentalAppointment
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
            label1 = new Label();
            txtFullName = new TextBox();
            label2 = new Label();
            txtPhoneNumber = new TextBox();
            cbxDoctor = new ComboBox();
            label3 = new Label();
            dtpAppointment = new DateTimePicker();
            label4 = new Label();
            cbxOfficeLocation = new ComboBox();
            label5 = new Label();
            btnConfirm = new Button();
            label6 = new Label();
            txtReasonForVisit = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 41);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(152, 33);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "LastName, FirstName";
            txtFullName.Size = new Size(222, 23);
            txtFullName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 102);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 2;
            label2.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(152, 94);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(163, 23);
            txtPhoneNumber.TabIndex = 3;
            // 
            // cbxDoctor
            // 
            cbxDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDoctor.FormattingEnabled = true;
            cbxDoctor.Location = new Point(152, 155);
            cbxDoctor.Name = "cbxDoctor";
            cbxDoctor.Size = new Size(222, 23);
            cbxDoctor.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 163);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "Doctor";
            // 
            // dtpAppointment
            // 
            dtpAppointment.Location = new Point(152, 213);
            dtpAppointment.Name = "dtpAppointment";
            dtpAppointment.Size = new Size(200, 23);
            dtpAppointment.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 219);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 7;
            label4.Text = "Appointment Date";
            // 
            // cbxOfficeLocation
            // 
            cbxOfficeLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOfficeLocation.FormattingEnabled = true;
            cbxOfficeLocation.Location = new Point(152, 272);
            cbxOfficeLocation.Name = "cbxOfficeLocation";
            cbxOfficeLocation.Size = new Size(121, 23);
            cbxOfficeLocation.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 280);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 9;
            label5.Text = "Office Location";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(38, 479);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(336, 85);
            btnConfirm.TabIndex = 10;
            btnConfirm.Text = "Confirm Appointmenr";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 339);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 11;
            label6.Text = "Reason for Visit";
            // 
            // txtReasonForVisit
            // 
            txtReasonForVisit.Location = new Point(152, 339);
            txtReasonForVisit.Multiline = true;
            txtReasonForVisit.Name = "txtReasonForVisit";
            txtReasonForVisit.Size = new Size(222, 101);
            txtReasonForVisit.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 583);
            Controls.Add(txtReasonForVisit);
            Controls.Add(label6);
            Controls.Add(btnConfirm);
            Controls.Add(label5);
            Controls.Add(cbxOfficeLocation);
            Controls.Add(label4);
            Controls.Add(dtpAppointment);
            Controls.Add(label3);
            Controls.Add(cbxDoctor);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label2);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFullName;
        private Label label2;
        private TextBox txtPhoneNumber;
        private ComboBox cbxDoctor;
        private Label label3;
        private DateTimePicker dtpAppointment;
        private Label label4;
        private ComboBox cbxOfficeLocation;
        private Label label5;
        private Button btnConfirm;
        private Label label6;
        private TextBox txtReasonForVisit;
    }
}
