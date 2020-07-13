namespace CRUDStudent_2
{
    partial class frmStudentInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label firstNameLabel;
            this.chkGender = new System.Windows.Forms.CheckBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFirstName2 = new System.Windows.Forms.RichTextBox();
            this.txtLastName2 = new System.Windows.Forms.RichTextBox();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            lastNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(15, 74);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(31, 114);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 7;
            genderLabel.Text = "Gender:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(32, 151);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(48, 13);
            birthdayLabel.TabIndex = 9;
            birthdayLabel.Text = "Birthday:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(15, 197);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 11;
            addressLabel.Text = "Address:";
            // 
            // chkGender
            // 
            this.chkGender.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.studentsBindingSource, "Gender", true));
            this.chkGender.Location = new System.Drawing.Point(98, 109);
            this.chkGender.Name = "chkGender";
            this.chkGender.Size = new System.Drawing.Size(88, 24);
            this.chkGender.TabIndex = 2;
            this.chkGender.Text = "???";
            this.chkGender.UseVisualStyleBackColor = true;
            this.chkGender.CheckedChanged += new System.EventHandler(this.chkGender_CheckedChanged);
            // 
            // txtBirthday
            // 
            this.txtBirthday.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Birthday", true));
            this.txtBirthday.Location = new System.Drawing.Point(98, 148);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(88, 20);
            this.txtBirthday.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Address", true));
            this.txtAddress.Location = new System.Drawing.Point(97, 184);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(288, 49);
            this.txtAddress.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(311, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // txtFirstName2
            // 
            this.txtFirstName2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "FirstName", true));
            this.txtFirstName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName2.Location = new System.Drawing.Point(97, 22);
            this.txtFirstName2.Name = "txtFirstName2";
            this.txtFirstName2.Size = new System.Drawing.Size(289, 28);
            this.txtFirstName2.TabIndex = 0;
            this.txtFirstName2.Text = "";
            // 
            // txtLastName2
            // 
            this.txtLastName2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "LastName", true));
            this.txtLastName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName2.Location = new System.Drawing.Point(97, 69);
            this.txtLastName2.Name = "txtLastName2";
            this.txtLastName2.Size = new System.Drawing.Size(289, 28);
            this.txtLastName2.TabIndex = 1;
            this.txtLastName2.Text = "";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataSource = typeof(CRUDStudent_2.Students);
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(12, 34);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(76, 16);
            firstNameLabel.TabIndex = 12;
            firstNameLabel.Text = "First Name:";
            // 
            // frmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 330);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.txtLastName2);
            this.Controls.Add(this.txtFirstName2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.chkGender);
            this.Controls.Add(lastNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmStudentInfo";
            this.Text = "Add/Edit Student";
            this.Load += new System.EventHandler(this.frmStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource studentsBindingSource;
        //private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.CheckBox chkGender;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox txtFirstName2;
        private System.Windows.Forms.RichTextBox txtLastName2;
    }
}