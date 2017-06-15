namespace SewingCourses
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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.UpcomingClassesTabPage = new System.Windows.Forms.TabPage();
            this.CoursesTabPage = new System.Windows.Forms.TabPage();
            this.UpcomingClassesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.UpcomingCoursesListBox = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ClientsTabPage = new System.Windows.Forms.TabPage();
            this.MainMenuStrip.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.UpcomingClassesTabPage.SuspendLayout();
            this.CoursesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpcomingClassesSplitContainer)).BeginInit();
            this.UpcomingClassesSplitContainer.Panel1.SuspendLayout();
            this.UpcomingClassesSplitContainer.Panel2.SuspendLayout();
            this.UpcomingClassesSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(838, 24);
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
            this.MainTabControl.Size = new System.Drawing.Size(838, 532);
            this.MainTabControl.TabIndex = 1;
            // 
            // UpcomingClassesTabPage
            // 
            this.UpcomingClassesTabPage.Controls.Add(this.UpcomingClassesSplitContainer);
            this.UpcomingClassesTabPage.Location = new System.Drawing.Point(4, 32);
            this.UpcomingClassesTabPage.Name = "UpcomingClassesTabPage";
            this.UpcomingClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.UpcomingClassesTabPage.Size = new System.Drawing.Size(830, 496);
            this.UpcomingClassesTabPage.TabIndex = 0;
            this.UpcomingClassesTabPage.Text = "Nadchodzące zajęcia";
            this.UpcomingClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // CoursesTabPage
            // 
            this.CoursesTabPage.Controls.Add(this.dataGridView2);
            this.CoursesTabPage.Controls.Add(this.flowLayoutPanel1);
            this.CoursesTabPage.Location = new System.Drawing.Point(4, 32);
            this.CoursesTabPage.Name = "CoursesTabPage";
            this.CoursesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CoursesTabPage.Size = new System.Drawing.Size(830, 496);
            this.CoursesTabPage.TabIndex = 1;
            this.CoursesTabPage.Text = "Kursy";
            this.CoursesTabPage.UseVisualStyleBackColor = true;
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
            // 
            // UpcomingClassesSplitContainer.Panel2
            // 
            this.UpcomingClassesSplitContainer.Panel2.Controls.Add(this.dataGridView1);
            this.UpcomingClassesSplitContainer.Size = new System.Drawing.Size(824, 490);
            this.UpcomingClassesSplitContainer.SplitterDistance = 274;
            this.UpcomingClassesSplitContainer.TabIndex = 0;
            // 
            // UpcomingCoursesListBox
            // 
            this.UpcomingCoursesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpcomingCoursesListBox.FormattingEnabled = true;
            this.UpcomingCoursesListBox.IntegralHeight = false;
            this.UpcomingCoursesListBox.Location = new System.Drawing.Point(0, 0);
            this.UpcomingCoursesListBox.Name = "UpcomingCoursesListBox";
            this.UpcomingCoursesListBox.Size = new System.Drawing.Size(274, 490);
            this.UpcomingCoursesListBox.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 490);
            this.dataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 393);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(824, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(824, 390);
            this.dataGridView2.TabIndex = 1;
            // 
            // ClientsTabPage
            // 
            this.ClientsTabPage.Location = new System.Drawing.Point(4, 32);
            this.ClientsTabPage.Name = "ClientsTabPage";
            this.ClientsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClientsTabPage.Size = new System.Drawing.Size(830, 496);
            this.ClientsTabPage.TabIndex = 2;
            this.ClientsTabPage.Text = "Klienci";
            this.ClientsTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 556);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kursy Szycia";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.UpcomingClassesTabPage.ResumeLayout(false);
            this.CoursesTabPage.ResumeLayout(false);
            this.UpcomingClassesSplitContainer.Panel1.ResumeLayout(false);
            this.UpcomingClassesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UpcomingClassesSplitContainer)).EndInit();
            this.UpcomingClassesSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage ClientsTabPage;
    }
}

