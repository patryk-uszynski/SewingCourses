namespace SewingCourses.Forms
{
    partial class CourseAddingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseAddingForm));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NormalCourseRadioButton = new System.Windows.Forms.RadioButton();
            this.ProffesionalCourseRadioButton = new System.Windows.Forms.RadioButton();
            this.SemesterCourseRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CancelAddCourseButton = new System.Windows.Forms.Button();
            this.CreateCourseButton = new System.Windows.Forms.Button();
            this.CreateCourseAndClassesButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.QualificationLabel = new System.Windows.Forms.Label();
            this.QualificationTextBox = new System.Windows.Forms.TextBox();
            this.SemesterStartDateLabel = new System.Windows.Forms.Label();
            this.SemesterStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SemesterEndLabel = new System.Windows.Forms.Label();
            this.SemesterEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.CoursePriceLabel = new System.Windows.Forms.Label();
            this.CoursePriceTextBox = new System.Windows.Forms.TextBox();
            this.CourseNameLabel = new System.Windows.Forms.Label();
            this.CourseNameTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.GhostWhite;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.CreateCourseButton);
            this.flowLayoutPanel2.Controls.Add(this.CreateCourseAndClassesButton);
            this.flowLayoutPanel2.Controls.Add(this.CancelAddCourseButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 414);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 25, 10, 0);
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(636, 100);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(636, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SemesterCourseRadioButton);
            this.groupBox1.Controls.Add(this.ProffesionalCourseRadioButton);
            this.groupBox1.Controls.Add(this.NormalCourseRadioButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Typ kursu";
            // 
            // NormalCourseRadioButton
            // 
            this.NormalCourseRadioButton.AutoSize = true;
            this.NormalCourseRadioButton.Checked = true;
            this.NormalCourseRadioButton.Location = new System.Drawing.Point(9, 19);
            this.NormalCourseRadioButton.Name = "NormalCourseRadioButton";
            this.NormalCourseRadioButton.Size = new System.Drawing.Size(60, 17);
            this.NormalCourseRadioButton.TabIndex = 0;
            this.NormalCourseRadioButton.TabStop = true;
            this.NormalCourseRadioButton.Text = "Zwykły";
            this.NormalCourseRadioButton.UseVisualStyleBackColor = true;
            // 
            // ProffesionalCourseRadioButton
            // 
            this.ProffesionalCourseRadioButton.AutoSize = true;
            this.ProffesionalCourseRadioButton.Location = new System.Drawing.Point(9, 42);
            this.ProffesionalCourseRadioButton.Name = "ProffesionalCourseRadioButton";
            this.ProffesionalCourseRadioButton.Size = new System.Drawing.Size(77, 17);
            this.ProffesionalCourseRadioButton.TabIndex = 1;
            this.ProffesionalCourseRadioButton.Text = "Zawodowy";
            this.ProffesionalCourseRadioButton.UseVisualStyleBackColor = true;
            this.ProffesionalCourseRadioButton.CheckedChanged += new System.EventHandler(this.ProffesionalCourseRadioButton_CheckedChanged);
            // 
            // SemesterCourseRadioButton
            // 
            this.SemesterCourseRadioButton.AutoSize = true;
            this.SemesterCourseRadioButton.Location = new System.Drawing.Point(10, 66);
            this.SemesterCourseRadioButton.Name = "SemesterCourseRadioButton";
            this.SemesterCourseRadioButton.Size = new System.Drawing.Size(82, 17);
            this.SemesterCourseRadioButton.TabIndex = 2;
            this.SemesterCourseRadioButton.Text = "Semestralny";
            this.SemesterCourseRadioButton.UseVisualStyleBackColor = true;
            this.SemesterCourseRadioButton.CheckedChanged += new System.EventHandler(this.SemesterCourseRadioButton_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.31446F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.68554F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 97);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.87622F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.12378F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 317);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // CancelAddCourseButton
            // 
            this.CancelAddCourseButton.Location = new System.Drawing.Point(189, 28);
            this.CancelAddCourseButton.Name = "CancelAddCourseButton";
            this.CancelAddCourseButton.Size = new System.Drawing.Size(116, 41);
            this.CancelAddCourseButton.TabIndex = 3;
            this.CancelAddCourseButton.Text = "Anuluj";
            this.CancelAddCourseButton.UseVisualStyleBackColor = true;
            this.CancelAddCourseButton.Click += new System.EventHandler(this.CancelAddCourseButton_Click);
            // 
            // CreateCourseButton
            // 
            this.CreateCourseButton.Location = new System.Drawing.Point(508, 28);
            this.CreateCourseButton.Name = "CreateCourseButton";
            this.CreateCourseButton.Size = new System.Drawing.Size(113, 41);
            this.CreateCourseButton.TabIndex = 4;
            this.CreateCourseButton.Text = "Dodaj kurs";
            this.CreateCourseButton.UseVisualStyleBackColor = true;
            this.CreateCourseButton.Click += new System.EventHandler(this.CreateCourseButton_Click);
            // 
            // CreateCourseAndClassesButton
            // 
            this.CreateCourseAndClassesButton.Location = new System.Drawing.Point(311, 28);
            this.CreateCourseAndClassesButton.Name = "CreateCourseAndClassesButton";
            this.CreateCourseAndClassesButton.Size = new System.Drawing.Size(191, 41);
            this.CreateCourseAndClassesButton.TabIndex = 5;
            this.CreateCourseAndClassesButton.Text = "Dodaj kurs i stwórz zajęcia";
            this.CreateCourseAndClassesButton.UseVisualStyleBackColor = true;
            this.CreateCourseAndClassesButton.Click += new System.EventHandler(this.CreateCourseAndClassesButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.QualificationLabel);
            this.flowLayoutPanel1.Controls.Add(this.QualificationTextBox);
            this.flowLayoutPanel1.Controls.Add(this.SemesterStartDateLabel);
            this.flowLayoutPanel1.Controls.Add(this.SemesterStartDateTimePicker);
            this.flowLayoutPanel1.Controls.Add(this.SemesterEndLabel);
            this.flowLayoutPanel1.Controls.Add(this.SemesterEndDateTimePicker);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(322, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(311, 97);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // QualificationLabel
            // 
            this.QualificationLabel.AutoSize = true;
            this.QualificationLabel.Location = new System.Drawing.Point(3, 0);
            this.QualificationLabel.Name = "QualificationLabel";
            this.QualificationLabel.Size = new System.Drawing.Size(166, 13);
            this.QualificationLabel.TabIndex = 0;
            this.QualificationLabel.Text = "Kwalifikacje po osiągnięciu kursu:";
            this.QualificationLabel.Visible = false;
            // 
            // QualificationTextBox
            // 
            this.QualificationTextBox.Location = new System.Drawing.Point(3, 16);
            this.QualificationTextBox.Name = "QualificationTextBox";
            this.QualificationTextBox.Size = new System.Drawing.Size(230, 20);
            this.QualificationTextBox.TabIndex = 1;
            this.QualificationTextBox.Visible = false;
            // 
            // SemesterStartDateLabel
            // 
            this.SemesterStartDateLabel.AutoSize = true;
            this.SemesterStartDateLabel.Location = new System.Drawing.Point(3, 39);
            this.SemesterStartDateLabel.Name = "SemesterStartDateLabel";
            this.SemesterStartDateLabel.Size = new System.Drawing.Size(135, 13);
            this.SemesterStartDateLabel.TabIndex = 2;
            this.SemesterStartDateLabel.Text = "Data rozpoczęcia semestru";
            this.SemesterStartDateLabel.Visible = false;
            // 
            // SemesterStartDateTimePicker
            // 
            this.SemesterStartDateTimePicker.Location = new System.Drawing.Point(3, 55);
            this.SemesterStartDateTimePicker.Name = "SemesterStartDateTimePicker";
            this.SemesterStartDateTimePicker.Size = new System.Drawing.Size(230, 20);
            this.SemesterStartDateTimePicker.TabIndex = 3;
            this.SemesterStartDateTimePicker.Visible = false;
            // 
            // SemesterEndLabel
            // 
            this.SemesterEndLabel.AutoSize = true;
            this.SemesterEndLabel.Location = new System.Drawing.Point(3, 78);
            this.SemesterEndLabel.Name = "SemesterEndLabel";
            this.SemesterEndLabel.Size = new System.Drawing.Size(132, 13);
            this.SemesterEndLabel.TabIndex = 4;
            this.SemesterEndLabel.Text = "Data zkończenia semestru";
            this.SemesterEndLabel.Visible = false;
            // 
            // SemesterEndDateTimePicker
            // 
            this.SemesterEndDateTimePicker.Location = new System.Drawing.Point(239, 3);
            this.SemesterEndDateTimePicker.Name = "SemesterEndDateTimePicker";
            this.SemesterEndDateTimePicker.Size = new System.Drawing.Size(230, 20);
            this.SemesterEndDateTimePicker.TabIndex = 5;
            this.SemesterEndDateTimePicker.Visible = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.CoursePriceLabel);
            this.flowLayoutPanel3.Controls.Add(this.CoursePriceTextBox);
            this.flowLayoutPanel3.Controls.Add(this.CourseNameLabel);
            this.flowLayoutPanel3.Controls.Add(this.CourseNameTextBox);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 116);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(313, 198);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // CoursePriceLabel
            // 
            this.CoursePriceLabel.AutoSize = true;
            this.CoursePriceLabel.Location = new System.Drawing.Point(3, 0);
            this.CoursePriceLabel.Name = "CoursePriceLabel";
            this.CoursePriceLabel.Size = new System.Drawing.Size(33, 13);
            this.CoursePriceLabel.TabIndex = 0;
            this.CoursePriceLabel.Text = "Koszt";
            // 
            // CoursePriceTextBox
            // 
            this.CoursePriceTextBox.Location = new System.Drawing.Point(3, 16);
            this.CoursePriceTextBox.Name = "CoursePriceTextBox";
            this.CoursePriceTextBox.Size = new System.Drawing.Size(186, 20);
            this.CoursePriceTextBox.TabIndex = 1;
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.AutoSize = true;
            this.CourseNameLabel.Location = new System.Drawing.Point(3, 39);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(40, 13);
            this.CourseNameLabel.TabIndex = 2;
            this.CourseNameLabel.Text = "Nazwa";
            // 
            // CourseNameTextBox
            // 
            this.CourseNameTextBox.Location = new System.Drawing.Point(3, 55);
            this.CourseNameTextBox.Name = "CourseNameTextBox";
            this.CourseNameTextBox.Size = new System.Drawing.Size(186, 20);
            this.CourseNameTextBox.TabIndex = 3;
            // 
            // CourseAddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 514);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "CourseAddingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie nowego kursu";
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SemesterCourseRadioButton;
        private System.Windows.Forms.RadioButton ProffesionalCourseRadioButton;
        private System.Windows.Forms.RadioButton NormalCourseRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button CreateCourseButton;
        private System.Windows.Forms.Button CreateCourseAndClassesButton;
        private System.Windows.Forms.Button CancelAddCourseButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label QualificationLabel;
        private System.Windows.Forms.TextBox QualificationTextBox;
        private System.Windows.Forms.Label SemesterStartDateLabel;
        private System.Windows.Forms.DateTimePicker SemesterStartDateTimePicker;
        private System.Windows.Forms.Label SemesterEndLabel;
        private System.Windows.Forms.DateTimePicker SemesterEndDateTimePicker;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label CoursePriceLabel;
        private System.Windows.Forms.TextBox CoursePriceTextBox;
        private System.Windows.Forms.Label CourseNameLabel;
        private System.Windows.Forms.TextBox CourseNameTextBox;
    }
}