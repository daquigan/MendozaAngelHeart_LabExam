
namespace StudentApp
{
    partial class Student_Page
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.DataGridViewButtonColumn ViewBtn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            studentGridView = new DataGridView();
            ViewBtn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)studentGridView).BeginInit();
            SuspendLayout();
            // 
            // studentGridView
            // 
            studentGridView.BackgroundColor = SystemColors.ActiveCaption;
            studentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGridView.Columns.AddRange(new DataGridViewColumn[] { ViewBtn });
            studentGridView.Location = new Point(12, 6);
            studentGridView.Margin = new Padding(4, 5, 4, 5);
            studentGridView.Name = "studentGridView";
            studentGridView.RowHeadersWidth = 51;
            studentGridView.Size = new Size(430, 236);
            studentGridView.TabIndex = 0;
            studentGridView.CellContentClick += studentGridView_CellContentClick;
            // 
            // ViewBtn
            // 
            ViewBtn.HeaderText = "Action";
            ViewBtn.MinimumWidth = 4;
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Text = "VIEW";
            ViewBtn.UseColumnTextForButtonValue = true;
            ViewBtn.Width = 80;
            // 
            // Student_Page
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 256);
            Controls.Add(studentGridView);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Student_Page";
            Text = "Student Page";
            Load += Student_Page_Load;
            ((System.ComponentModel.ISupportInitialize)studentGridView).EndInit();
            ResumeLayout(false);
        }
    }
}
