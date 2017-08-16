namespace SewingCourses.Forms
{
    partial class ClassesAddingForm
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
            this.ClassesAddingNavFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddClassesButton = new System.Windows.Forms.Button();
            this.CancelAddingButton = new System.Windows.Forms.Button();
            this.MainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.TeacherLabel = new System.Windows.Forms.Label();
            this.TeacherComboBox = new System.Windows.Forms.ComboBox();
            this.ClassesAddingNavFlowLayoutPanel.SuspendLayout();
            this.MainFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassesAddingNavFlowLayoutPanel
            // 
            this.ClassesAddingNavFlowLayoutPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.ClassesAddingNavFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClassesAddingNavFlowLayoutPanel.Controls.Add(this.AddClassesButton);
            this.ClassesAddingNavFlowLayoutPanel.Controls.Add(this.CancelAddingButton);
            this.ClassesAddingNavFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ClassesAddingNavFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ClassesAddingNavFlowLayoutPanel.Location = new System.Drawing.Point(0, 362);
            this.ClassesAddingNavFlowLayoutPanel.Name = "ClassesAddingNavFlowLayoutPanel";
            this.ClassesAddingNavFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 25, 15, 0);
            this.ClassesAddingNavFlowLayoutPanel.Size = new System.Drawing.Size(484, 100);
            this.ClassesAddingNavFlowLayoutPanel.TabIndex = 0;
            // 
            // AddClassesButton
            // 
            this.AddClassesButton.Location = new System.Drawing.Point(307, 28);
            this.AddClassesButton.Name = "AddClassesButton";
            this.AddClassesButton.Size = new System.Drawing.Size(157, 42);
            this.AddClassesButton.TabIndex = 0;
            this.AddClassesButton.Text = "Dodaj";
            this.AddClassesButton.UseVisualStyleBackColor = true;
            this.AddClassesButton.Click += new System.EventHandler(this.AddClassesButton_Click);
            // 
            // CancelAddingButton
            // 
            this.CancelAddingButton.Location = new System.Drawing.Point(152, 28);
            this.CancelAddingButton.Name = "CancelAddingButton";
            this.CancelAddingButton.Size = new System.Drawing.Size(149, 42);
            this.CancelAddingButton.TabIndex = 1;
            this.CancelAddingButton.Text = "Anuluj";
            this.CancelAddingButton.UseVisualStyleBackColor = true;
            this.CancelAddingButton.Click += new System.EventHandler(this.CancelAddingButton_Click);
            // 
            // MainFlowLayoutPanel
            // 
            this.MainFlowLayoutPanel.Controls.Add(this.StartDateLabel);
            this.MainFlowLayoutPanel.Controls.Add(this.StartDateTimePicker);
            this.MainFlowLayoutPanel.Controls.Add(this.EndDateLabel);
            this.MainFlowLayoutPanel.Controls.Add(this.EndDateTimePicker);
            this.MainFlowLayoutPanel.Controls.Add(this.LocationLabel);
            this.MainFlowLayoutPanel.Controls.Add(this.LocationComboBox);
            this.MainFlowLayoutPanel.Controls.Add(this.TeacherLabel);
            this.MainFlowLayoutPanel.Controls.Add(this.TeacherComboBox);
            this.MainFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MainFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainFlowLayoutPanel.Name = "MainFlowLayoutPanel";
            this.MainFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(50);
            this.MainFlowLayoutPanel.Size = new System.Drawing.Size(484, 362);
            this.MainFlowLayoutPanel.TabIndex = 1;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(53, 50);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(90, 13);
            this.StartDateLabel.TabIndex = 0;
            this.StartDateLabel.Text = "Data rozpoczęcia";
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Location = new System.Drawing.Point(53, 66);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.StartDateTimePicker.TabIndex = 1;
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(53, 89);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.EndDateLabel.Size = new System.Drawing.Size(93, 23);
            this.EndDateLabel.TabIndex = 2;
            this.EndDateLabel.Text = "Data zakończenia";
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Location = new System.Drawing.Point(53, 115);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.EndDateTimePicker.TabIndex = 3;
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(53, 138);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.LocationLabel.Size = new System.Drawing.Size(60, 23);
            this.LocationLabel.TabIndex = 4;
            this.LocationLabel.Text = "Lokalizacja";
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.DisplayMember = "Name";
            this.LocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocationComboBox.Location = new System.Drawing.Point(53, 164);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(200, 21);
            this.LocationComboBox.TabIndex = 5;
            // 
            // TeacherLabel
            // 
            this.TeacherLabel.AutoSize = true;
            this.TeacherLabel.Location = new System.Drawing.Point(53, 188);
            this.TeacherLabel.Name = "TeacherLabel";
            this.TeacherLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.TeacherLabel.Size = new System.Drawing.Size(119, 23);
            this.TeacherLabel.TabIndex = 6;
            this.TeacherLabel.Text = "Nauczyciel prowadzący";
            // 
            // TeacherComboBox
            // 
            this.TeacherComboBox.DisplayMember = "FullName";
            this.TeacherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeacherComboBox.FormattingEnabled = true;
            this.TeacherComboBox.Location = new System.Drawing.Point(53, 214);
            this.TeacherComboBox.Name = "TeacherComboBox";
            this.TeacherComboBox.Size = new System.Drawing.Size(200, 21);
            this.TeacherComboBox.TabIndex = 7;
            // 
            // ClassesAddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.MainFlowLayoutPanel);
            this.Controls.Add(this.ClassesAddingNavFlowLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "ClassesAddingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj nowe zajęcia";
            this.ClassesAddingNavFlowLayoutPanel.ResumeLayout(false);
            this.MainFlowLayoutPanel.ResumeLayout(false);
            this.MainFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ClassesAddingNavFlowLayoutPanel;
        private System.Windows.Forms.Button AddClassesButton;
        private System.Windows.Forms.Button CancelAddingButton;
        private System.Windows.Forms.FlowLayoutPanel MainFlowLayoutPanel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.Label TeacherLabel;
        private System.Windows.Forms.ComboBox TeacherComboBox;
    }
}