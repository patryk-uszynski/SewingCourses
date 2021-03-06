﻿namespace SewingCourses
{
    partial class MainForm
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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stwórzNowyKursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.UpcomingClassesTabPage = new System.Windows.Forms.TabPage();
            this.UpcomingClassesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.UpcomingCoursesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpcomingClassesDataGridView = new System.Windows.Forms.DataGridView();
            this.ClassesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreeSpots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoursesTabPage = new System.Windows.Forms.TabPage();
            this.CoursesDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CoursesDataGridMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.InfoLabel1 = new System.Windows.Forms.Label();
            this.ClientsTabPage = new System.Windows.Forms.TabPage();
            this.StudentsDataGridView = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainMenuStrip.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.UpcomingClassesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpcomingClassesSplitContainer)).BeginInit();
            this.UpcomingClassesSplitContainer.Panel1.SuspendLayout();
            this.UpcomingClassesSplitContainer.Panel2.SuspendLayout();
            this.UpcomingClassesSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpcomingClassesDataGridView)).BeginInit();
            this.CoursesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesDataGridView)).BeginInit();
            this.CoursesDataGridMenuStrip.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.ClientsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.kursToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(884, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.FileToolStripMenuItem.Text = "Plik";
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.CloseToolStripMenuItem.Text = "Zakończ";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // kursToolStripMenuItem
            // 
            this.kursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stwórzNowyKursToolStripMenuItem});
            this.kursToolStripMenuItem.Name = "kursToolStripMenuItem";
            this.kursToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.kursToolStripMenuItem.Text = "Kurs";
            // 
            // stwórzNowyKursToolStripMenuItem
            // 
            this.stwórzNowyKursToolStripMenuItem.Name = "stwórzNowyKursToolStripMenuItem";
            this.stwórzNowyKursToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.stwórzNowyKursToolStripMenuItem.Text = "Stwórz nowy kurs";
            this.stwórzNowyKursToolStripMenuItem.Click += new System.EventHandler(this.stwórzNowyKursToolStripMenuItem_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.UpcomingClassesTabPage);
            this.MainTabControl.Controls.Add(this.CoursesTabPage);
            this.MainTabControl.Controls.Add(this.ClientsTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 24);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.Padding = new System.Drawing.Point(20, 8);
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(884, 538);
            this.MainTabControl.TabIndex = 1;
            // 
            // UpcomingClassesTabPage
            // 
            this.UpcomingClassesTabPage.Controls.Add(this.UpcomingClassesSplitContainer);
            this.UpcomingClassesTabPage.Location = new System.Drawing.Point(4, 32);
            this.UpcomingClassesTabPage.Name = "UpcomingClassesTabPage";
            this.UpcomingClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.UpcomingClassesTabPage.Size = new System.Drawing.Size(876, 502);
            this.UpcomingClassesTabPage.TabIndex = 0;
            this.UpcomingClassesTabPage.Text = "Nadchodzące zajęcia";
            this.UpcomingClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // UpcomingClassesSplitContainer
            // 
            this.UpcomingClassesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpcomingClassesSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.UpcomingClassesSplitContainer.Name = "UpcomingClassesSplitContainer";
            // 
            // UpcomingClassesSplitContainer.Panel1
            // 
            this.UpcomingClassesSplitContainer.Panel1.Controls.Add(this.UpcomingCoursesListBox);
            this.UpcomingClassesSplitContainer.Panel1.Controls.Add(this.label1);
            // 
            // UpcomingClassesSplitContainer.Panel2
            // 
            this.UpcomingClassesSplitContainer.Panel2.Controls.Add(this.UpcomingClassesDataGridView);
            this.UpcomingClassesSplitContainer.Size = new System.Drawing.Size(870, 496);
            this.UpcomingClassesSplitContainer.SplitterDistance = 289;
            this.UpcomingClassesSplitContainer.TabIndex = 0;
            // 
            // UpcomingCoursesListBox
            // 
            this.UpcomingCoursesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpcomingCoursesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpcomingCoursesListBox.FormattingEnabled = true;
            this.UpcomingCoursesListBox.IntegralHeight = false;
            this.UpcomingCoursesListBox.ItemHeight = 16;
            this.UpcomingCoursesListBox.Location = new System.Drawing.Point(0, 28);
            this.UpcomingCoursesListBox.Name = "UpcomingCoursesListBox";
            this.UpcomingCoursesListBox.Size = new System.Drawing.Size(289, 468);
            this.UpcomingCoursesListBox.TabIndex = 0;
            this.UpcomingCoursesListBox.SelectedIndexChanged += new System.EventHandler(this.UpcomingCoursesListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dla kursu:";
            // 
            // UpcomingClassesDataGridView
            // 
            this.UpcomingClassesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UpcomingClassesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpcomingClassesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassesId,
            this.Course,
            this.StartDateTime,
            this.EndDateTime,
            this.FreeSpots,
            this.CourseId,
            this.TeacherName});
            this.UpcomingClassesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpcomingClassesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.UpcomingClassesDataGridView.Name = "UpcomingClassesDataGridView";
            this.UpcomingClassesDataGridView.Size = new System.Drawing.Size(577, 496);
            this.UpcomingClassesDataGridView.TabIndex = 0;
            // 
            // ClassesId
            // 
            this.ClassesId.DataPropertyName = "ClassesId";
            this.ClassesId.HeaderText = "ID";
            this.ClassesId.Name = "ClassesId";
            this.ClassesId.ReadOnly = true;
            this.ClassesId.Visible = false;
            // 
            // Course
            // 
            this.Course.DataPropertyName = "Course";
            this.Course.HeaderText = "Kurs";
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
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
            // FreeSpots
            // 
            this.FreeSpots.DataPropertyName = "FreeSpots";
            this.FreeSpots.HeaderText = "Wolne miejsca";
            this.FreeSpots.Name = "FreeSpots";
            this.FreeSpots.ReadOnly = true;
            // 
            // CourseId
            // 
            this.CourseId.DataPropertyName = "CourseId";
            this.CourseId.HeaderText = "ID kursu";
            this.CourseId.Name = "CourseId";
            this.CourseId.ReadOnly = true;
            this.CourseId.Visible = false;
            // 
            // TeacherName
            // 
            this.TeacherName.DataPropertyName = "TeacherName";
            this.TeacherName.HeaderText = "Prowadzący";
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            // 
            // CoursesTabPage
            // 
            this.CoursesTabPage.Controls.Add(this.CoursesDataGridView);
            this.CoursesTabPage.Controls.Add(this.flowLayoutPanel1);
            this.CoursesTabPage.Location = new System.Drawing.Point(4, 32);
            this.CoursesTabPage.Name = "CoursesTabPage";
            this.CoursesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CoursesTabPage.Size = new System.Drawing.Size(876, 502);
            this.CoursesTabPage.TabIndex = 1;
            this.CoursesTabPage.Text = "Kursy";
            this.CoursesTabPage.UseVisualStyleBackColor = true;
            // 
            // CoursesDataGridView
            // 
            this.CoursesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CoursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CourseNameColumn,
            this.Type,
            this.Actions});
            this.CoursesDataGridView.ContextMenuStrip = this.CoursesDataGridMenuStrip;
            this.CoursesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoursesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.CoursesDataGridView.Name = "CoursesDataGridView";
            this.CoursesDataGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.CoursesDataGridView.RowTemplate.Height = 30;
            this.CoursesDataGridView.Size = new System.Drawing.Size(870, 396);
            this.CoursesDataGridView.TabIndex = 1;
            this.CoursesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CoursesDataGridView_CellContentClick);
            this.CoursesDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CoursesDataGridView_CellEndEdit);
            this.CoursesDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CoursesDataGridView_MouseDown);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "CourseId";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // CourseNameColumn
            // 
            this.CourseNameColumn.DataPropertyName = "Name";
            this.CourseNameColumn.HeaderText = "Nazwa";
            this.CourseNameColumn.Name = "CourseNameColumn";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Typ";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Actions
            // 
            this.Actions.DataPropertyName = "Dodaj zajęcia";
            this.Actions.HeaderText = "";
            this.Actions.Name = "Actions";
            this.Actions.Text = "Dodaj zajęcia";
            this.Actions.UseColumnTextForButtonValue = true;
            // 
            // CoursesDataGridMenuStrip
            // 
            this.CoursesDataGridMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.CoursesDataGridMenuStrip.Name = "contextMenuStrip1";
            this.CoursesDataGridMenuStrip.Size = new System.Drawing.Size(102, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.toolStripMenuItem1.Text = "Usuń";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.AddCourseButton);
            this.flowLayoutPanel1.Controls.Add(this.InfoLabel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 399);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 25, 10, 0);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(870, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(695, 28);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(162, 49);
            this.AddCourseButton.TabIndex = 0;
            this.AddCourseButton.Text = "Stwórz nowy kurs";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // InfoLabel1
            // 
            this.InfoLabel1.AutoSize = true;
            this.InfoLabel1.Location = new System.Drawing.Point(268, 25);
            this.InfoLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.InfoLabel1.Name = "InfoLabel1";
            this.InfoLabel1.Padding = new System.Windows.Forms.Padding(0, 20, 50, 0);
            this.InfoLabel1.Size = new System.Drawing.Size(421, 33);
            this.InfoLabel1.TabIndex = 1;
            this.InfoLabel1.Text = "Usuwanie kursów jest możliwe po kliknięciu na nie prawym przyciskiem myszy";
            // 
            // ClientsTabPage
            // 
            this.ClientsTabPage.Controls.Add(this.StudentsDataGridView);
            this.ClientsTabPage.Location = new System.Drawing.Point(4, 32);
            this.ClientsTabPage.Name = "ClientsTabPage";
            this.ClientsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClientsTabPage.Size = new System.Drawing.Size(876, 502);
            this.ClientsTabPage.TabIndex = 2;
            this.ClientsTabPage.Text = "Klienci";
            this.ClientsTabPage.UseVisualStyleBackColor = true;
            // 
            // StudentsDataGridView
            // 
            this.StudentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.BirthDate});
            this.StudentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.StudentsDataGridView.Name = "StudentsDataGridView";
            this.StudentsDataGridView.Size = new System.Drawing.Size(870, 496);
            this.StudentsDataGridView.TabIndex = 0;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Imię";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Nazwisko";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "Data urodzenia";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.MainMenuStrip);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kursy Szycia";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.UpcomingClassesTabPage.ResumeLayout(false);
            this.UpcomingClassesSplitContainer.Panel1.ResumeLayout(false);
            this.UpcomingClassesSplitContainer.Panel1.PerformLayout();
            this.UpcomingClassesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UpcomingClassesSplitContainer)).EndInit();
            this.UpcomingClassesSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UpcomingClassesDataGridView)).EndInit();
            this.CoursesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CoursesDataGridView)).EndInit();
            this.CoursesDataGridMenuStrip.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ClientsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage UpcomingClassesTabPage;
        private System.Windows.Forms.TabPage CoursesTabPage;
        private System.Windows.Forms.SplitContainer UpcomingClassesSplitContainer;
        private System.Windows.Forms.ListBox UpcomingCoursesListBox;
        private System.Windows.Forms.DataGridView UpcomingClassesDataGridView;
        private System.Windows.Forms.DataGridView CoursesDataGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage ClientsTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.ToolStripMenuItem kursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stwórzNowyKursToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CoursesDataGridMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreeSpots;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridView StudentsDataGridView;
        private System.Windows.Forms.Label InfoLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewButtonColumn Actions;
    }
}

