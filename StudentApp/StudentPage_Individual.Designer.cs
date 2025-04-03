namespace StudentApp
{
    partial class StudentPage_Individual
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGuardian;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblYear;

        private void InitializeComponent()
        {
            lblStudentId = new Label();
            lblFullName = new Label();
            lblAddress = new Label();
            lblBirthdate = new Label();
            lblAge = new Label();
            lblContact = new Label();
            lblEmail = new Label();
            lblGuardian = new Label();
            lblHobbies = new Label();
            lblNickname = new Label();
            lblCourse = new Label();
            lblYear = new Label();
            SuspendLayout();
            // 
            // lblStudentId
            // 
            lblStudentId.Location = new Point(0, 0);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(100, 23);
            lblStudentId.TabIndex = 0;
            // 
            // lblFullName
            // 
            lblFullName.Location = new Point(0, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 23);
            lblFullName.TabIndex = 0;
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(0, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 23);
            lblAddress.TabIndex = 0;
            // 
            // lblBirthdate
            // 
            lblBirthdate.Location = new Point(0, 0);
            lblBirthdate.Name = "lblBirthdate";
            lblBirthdate.Size = new Size(100, 23);
            lblBirthdate.TabIndex = 0;
            // 
            // lblAge
            // 
            lblAge.Location = new Point(0, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(100, 23);
            lblAge.TabIndex = 0;
            // 
            // lblContact
            // 
            lblContact.Location = new Point(0, 0);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(100, 23);
            lblContact.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(0, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 0;
            // 
            // lblGuardian
            // 
            lblGuardian.Location = new Point(0, 0);
            lblGuardian.Name = "lblGuardian";
            lblGuardian.Size = new Size(100, 23);
            lblGuardian.TabIndex = 0;
            // 
            // lblHobbies
            // 
            lblHobbies.Location = new Point(0, 0);
            lblHobbies.Name = "lblHobbies";
            lblHobbies.Size = new Size(100, 23);
            lblHobbies.TabIndex = 0;
            // 
            // lblNickname
            // 
            lblNickname.Location = new Point(0, 0);
            lblNickname.Name = "lblNickname";
            lblNickname.Size = new Size(100, 23);
            lblNickname.TabIndex = 0;
            // 
            // lblCourse
            // 
            lblCourse.Location = new Point(0, 0);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(100, 23);
            lblCourse.TabIndex = 0;
            // 
            // lblYear
            // 
            lblYear.Location = new Point(0, 0);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(100, 23);
            lblYear.TabIndex = 0;
            // 
            // StudentPage_Individual
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(682, 452);
            Enabled = false;
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "StudentPage_Individual";
            Text = "Student Details";
            TransparencyKey = Color.FromArgb(255, 192, 192);
            Load += StudentPage_Individual_Load;
            ResumeLayout(false);
        }

        public void SetupLabels()
        {
            int yOffset = 20;
            int xOffset = 20;
            int spacing = 30;
            int width = 400;

            System.Windows.Forms.Label[] labels = {
                lblStudentId, lblFullName, lblAddress, lblBirthdate, lblAge,
                lblContact, lblEmail, lblGuardian, lblHobbies, lblNickname,
                lblCourse, lblYear
            };

            foreach (var label in labels)
            {
                label.AutoSize = true;
                label.Location = new System.Drawing.Point(xOffset, yOffset);
                label.Size = new System.Drawing.Size(width, 20);
                this.Controls.Add(label);
                yOffset += spacing;
            }
        }
    }
}
