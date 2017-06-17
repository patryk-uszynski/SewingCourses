using SewingCourses.Models;
using SewingCourses.Persistence;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using SewingCourses.Events;
using System.Data.Entity.Validation;
using SewingCourses.Forms;

namespace SewingCourses
{
    public partial class MainForm : Form
    {
        private SewingCoursesDbContext context;

        public MainForm()
        {
            InitializeComponent();
            ConfigureControls();

            context = new SewingCoursesDbContext();
            ReloadData();            

            // Subskrypcja eventu zmiany danych
            DataEvents.DataChanged += (s, e) => ReloadData();
        }

        private void ConfigureControls()
        {
            UpcomingCoursesListBox.ValueMember = "Name";
            UpcomingClassesDataGridView.AutoGenerateColumns = false;
            CoursesDataGridView.AutoGenerateColumns = false;
            StudentsDataGridView.AutoGenerateColumns = false;
        }

        public void ReloadData()
        {
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
            StudentsDataGridView.DataSource = context.Persons.OfType<Student>().ToList();
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
            CourseAddingForm form = new CourseAddingForm(context);
            form.Show();
        }

        private void stwórzNowyKursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseAddingForm form = new CourseAddingForm(context);
            form.Show();
        }

        private void CoursesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var selectedCourse = CoursesDataGridView.Rows[e.RowIndex].DataBoundItem as Course;

            if (selectedCourse == null) return;

            
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
                
           

            DataEvents.RaiseDataChanged();
            //CoursesDataGridView[e.ColumnIndex, e.RowIndex].Value;

        }

        // Delete item from CoursesDataGridView
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var course = CoursesDataGridView.SelectedRows[0].DataBoundItem as Course;

            if(course.Classes.Count() > 0)
            {
                MessageBox.Show("Nie można usunąć kursu zawierającego zajęcia!");
                return;
            }

            context.Courses.Remove(course);
            context.SaveChanges();
            DataEvents.RaiseDataChanged();
        }

        private void CoursesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var selectedCourse = CoursesDataGridView.Rows[e.RowIndex].DataBoundItem as Course;
                var form = new Forms.CourseManageForm(context, selectedCourse);
                form.Show();
            }
        }

        private void CoursesDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CoursesDataGridMenuStrip.Items[0].Enabled = true;

                var hitTest = CoursesDataGridView.HitTest(e.X, e.Y);
                CoursesDataGridView.ClearSelection();
                if (hitTest.RowIndex >= 0)
                {
                    CoursesDataGridView.Rows[hitTest.RowIndex].Selected = true;
                }
                else
                {
                    CoursesDataGridMenuStrip.Items[0].Enabled = false;
                }
            }
        }
    }
}
