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
    /// <summary>
    ///     Application main form
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        ///     Databes context
        /// </summary>
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

        /// <summary>
        ///     Default controls config
        /// </summary>
        private void ConfigureControls()
        {
            UpcomingCoursesListBox.ValueMember = "Name";
            UpcomingClassesDataGridView.AutoGenerateColumns = false;
            CoursesDataGridView.AutoGenerateColumns = false;
            StudentsDataGridView.AutoGenerateColumns = false;
        }

        /// <summary>
        ///     Reload data in application MainFrom
        /// </summary>
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

        /// <summary>
        ///     Close app nn main menu close item click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        ///     Reload upcoming classes gridview on selected course change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpcomingCoursesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpcomingClassesDataGridView.DataSource = ((Course)UpcomingCoursesListBox.SelectedItem).Classes.ToList();
        }

        /// <summary>
        ///     On add course button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            CourseAddingForm form = new CourseAddingForm(context);
            form.Show();
        }


        /// <summary>
        ///     Create new course - event from toolstrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stwórzNowyKursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseAddingForm form = new CourseAddingForm(context);
            form.Show();
        }


        /// <summary>
        ///     Edit Course row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        }


        /// <summary>
        ///     Delete item from CoursesDataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var course = CoursesDataGridView.SelectedRows[0].DataBoundItem as Course;

            if(course.Classes != null)
            {
                MessageBox.Show("Nie można usunąć kursu zawierającego zajęcia!");
                return;
            }

            context.Courses.Remove(course);
            context.SaveChanges();
            DataEvents.RaiseDataChanged();
        }


        /// <summary>
        ///     Add classes to course 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        ///     Select course row on right click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
