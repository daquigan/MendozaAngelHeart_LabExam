
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
            studentGridView.Location = new Point(13, 6);
            studentGridView.Margin = new Padding(4, 5, 4, 5);
            studentGridView.Name = "studentGridView";
            studentGridView.RowHeadersWidth = 51;
            studentGridView.Size = new Size(519, 224);
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
            ViewBtn.Width = 71;
            // 
            // Student_Page
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 233);
            Controls.Add(studentGridView);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Student_Page";
            Text = "Student List";
            Load += Student_Page_Load;
            ((System.ComponentModel.ISupportInitialize)studentGridView).EndInit();
            ResumeLayout(false);
        }
    }
}
