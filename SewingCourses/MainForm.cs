using SewingCourses.Models;
using SewingCourses.Persistence;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using SewingCourses.Events;
using System.Data.Entity.Validation;

namespace SewingCourses
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ConfigureControls();
            ReloadData();

            // Subskrypcja eventu zmiany danych
            DataEvents.DataChanged += (s, e) => ReloadData();
        }

        private void ConfigureControls()
        {
            UpcomingCoursesListBox.ValueMember = "Name";
            UpcomingClassesDataGridView.AutoGenerateColumns = false;
            CoursesDataGridView.AutoGenerateColumns = false;
        }

        public void ReloadData()
        {
            SewingCoursesDbContext context = new SewingCoursesDbContext();
            context.Configuration.LazyLoadingEnabled = true;
            context.Configuration.ProxyCreationEnabled = true;

            UpcomingCoursesListBox.DataSource = context.Courses.ToList();
            try
            {
                UpcomingClassesDataGridView.DataSource = ((Course)UpcomingCoursesListBox.SelectedItem).Classes.ToList();
            }
            catch (NullReferenceException)
            {
                // MessageBox.Show("Brak nadchodzących zajęć dla tego kursu");
            }
            CoursesDataGridView.DataSource = context.Courses.ToList();
            //context.Dispose();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpcomingCoursesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpcomingClassesDataGridView.DataSource = ((Course)UpcomingCoursesListBox.SelectedItem).Classes.ToList();
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            Models.Course.CreateCourse();
        }

        private void stwórzNowyKursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Models.Course.CreateCourse();
        }

        private void CoursesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var selectedCourse = CoursesDataGridView.Rows[e.RowIndex].DataBoundItem as Course;

            if (selectedCourse == null) return;

            using (SewingCoursesDbContext context = new SewingCoursesDbContext())
            {
                context.Courses.Attach(selectedCourse);
                var entry = context.Entry(selectedCourse);
                entry.Property(c => c.Name).IsModified = true;

                try
                {
                    context.SaveChanges();
                }
                catch (DbEntityValidationException)
                {
                    string message = "";
                    foreach (var validationResult in context.GetValidationErrors())
                    {
                        foreach (var error in validationResult.ValidationErrors)
                        {
                            message += error.ErrorMessage + "\n";
                        }
                        
                    }
                    MessageBox.Show(message);
                }
                
            }

            DataEvents.RaiseDataChanged();
            //CoursesDataGridView[e.ColumnIndex, e.RowIndex].Value;

        }

        // Delete item from CoursesDataGridView
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
