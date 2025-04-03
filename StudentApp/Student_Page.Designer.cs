
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
            studentGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            studentGridView.BackgroundColor = SystemColors.ControlLightLight;
            studentGridView.BorderStyle = BorderStyle.Fixed3D;
            studentGridView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            studentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGridView.Columns.AddRange(new DataGridViewColumn[] { ViewBtn });
            studentGridView.GridColor = SystemColors.GrayText;
            studentGridView.Location = new Point(13, 7);
            studentGridView.Margin = new Padding(4, 6, 4, 6);
            studentGridView.Name = "studentGridView";
            studentGridView.RowHeadersWidth = 51;
            studentGridView.Size = new Size(410, 271);
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
            ViewBtn.Width = 68;
            // 
            // Student_Page
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 292);
            Controls.Add(studentGridView);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 6, 4, 6);
            Name = "Student_Page";
            Text = "Student Page";
            Load += Student_Page_Load;
            ((System.ComponentModel.ISupportInitialize)studentGridView).EndInit();
            ResumeLayout(false);
        }
    }
}
