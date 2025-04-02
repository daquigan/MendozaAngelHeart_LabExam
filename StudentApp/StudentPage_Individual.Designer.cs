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
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGuardian = new System.Windows.Forms.Label();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.lblNickname = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // Labels
            // 
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


            // 
            // StudentPage_Individual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Name = "StudentPage_Individual";
            this.Text = "Student Details";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
