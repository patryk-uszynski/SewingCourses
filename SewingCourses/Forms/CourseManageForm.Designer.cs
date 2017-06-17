namespace SewingCourses.Forms
{
    partial class CourseManageForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CourseClassesdataGridView = new System.Windows.Forms.DataGridView();
            this.AddClassesButton = new System.Windows.Forms.Button();
            this.CourseNameDescLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CourseNameLabel = new System.Windows.Forms.Label();
            this.StartDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpotsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservationCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseClassesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.78125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.21875F));
            this.tableLayoutPanel1.Controls.Add(this.CourseNameDescLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CourseNameLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.AddClassesButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 326);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(640, 87);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // CourseClassesdataGridView
            // 
            this.CourseClassesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CourseClassesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseClassesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartDateTime,
            this.EndDateTime,
            this.Location,
            this.SpotsCount,
            this.ReservationCount});
            this.CourseClassesdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CourseClassesdataGridView.Location = new System.Drawing.Point(0, 100);
            this.CourseClassesdataGridView.Name = "CourseClassesdataGridView";
            this.CourseClassesdataGridView.Size = new System.Drawing.Size(640, 226);
            this.CourseClassesdataGridView.TabIndex = 2;
            // 
            // AddClassesButton
            // 
            this.AddClassesButton.Location = new System.Drawing.Point(489, 20);
            this.AddClassesButton.Margin = new System.Windows.Forms.Padding(3, 20, 15, 3);
            this.AddClassesButton.Name = "AddClassesButton";
            this.AddClassesButton.Size = new System.Drawing.Size(136, 44);
            this.AddClassesButton.TabIndex = 0;
            this.AddClassesButton.Text = "Dodaj zajęcia";
            this.AddClassesButton.UseVisualStyleBackColor = true;
            // 
            // CourseNameDescLabel
            // 
            this.CourseNameDescLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CourseNameDescLabel.AutoSize = true;
            this.CourseNameDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CourseNameDescLabel.Location = new System.Drawing.Point(114, 20);
            this.CourseNameDescLabel.Margin = new System.Windows.Forms.Padding(3, 0, 10, 10);
            this.CourseNameDescLabel.Name = "CourseNameDescLabel";
            this.CourseNameDescLabel.Size = new System.Drawing.Size(41, 20);
            this.CourseNameDescLabel.TabIndex = 0;
            this.CourseNameDescLabel.Text = "Kurs";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista zajęć:";
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CourseNameLabel.AutoSize = true;
            this.CourseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CourseNameLabel.Location = new System.Drawing.Point(175, 20);
            this.CourseNameLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(111, 20);
            this.CourseNameLabel.TabIndex = 2;
            this.CourseNameLabel.Text = "Nazwa kursu";
            // 
            // StartDateTime
            // 
            this.StartDateTime.DataPropertyName = "StartDateTime";
            this.StartDateTime.HeaderText = "Data rozpoczęcia";
            this.StartDateTime.Name = "StartDateTime";
            this.StartDateTime.ReadOnly = true;
            // 
            // EndDateTime
            // 
            this.EndDateTime.DataPropertyName = "EndDateTime";
            this.EndDateTime.HeaderText = "Data zakończenia";
            this.EndDateTime.Name = "EndDateTime";
            this.EndDateTime.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Lokalizacja";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // SpotsCount
            // 
            this.SpotsCount.HeaderText = "Ilość miejsc";
            this.SpotsCount.Name = "SpotsCount";
            this.SpotsCount.ReadOnly = true;
            // 
            // ReservationCount
            // 
            this.ReservationCount.HeaderText = "Ilość rezerwacji";
            this.ReservationCount.Name = "ReservationCount";
            this.ReservationCount.ReadOnly = true;
            // 
            // CourseManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 413);
            this.Controls.Add(this.CourseClassesdataGridView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CourseManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zarządzanie kursem";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CourseClassesdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView CourseClassesdataGridView;
        private System.Windows.Forms.Label CourseNameDescLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddClassesButton;
        private System.Windows.Forms.Label CourseNameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpotsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationCount;
    }
}