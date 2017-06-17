using SewingCourses.Models;
using SewingCourses.Persistence;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using SewingCourses.Events;

namespace SewingCourses
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            UpcomingCoursesListBox.ValueMember = "Name";
            UpcomingClassesDataGridView.AutoGenerateColumns = false;
            CoursesDataGridView.AutoGenerateColumns = false;

            ReloadData();

            DataEvents.DataChanged += (s, e) => ReloadData();
        }

        public void ReloadData()
        {
            SewingCoursesDbContext context = new SewingCoursesDbContext();
            UpcomingCoursesListBox.DataSource = context.Courses.Include(c => c.Classes).ToList();
            try
            {

                UpcomingClassesDataGridView.DataSource = ((Course)UpcomingCoursesListBox.SelectedItem).Classes.ToList();
            }
            catch (NullReferenceException)
            {
                // MessageBox.Show("Brak nadchodzących zajęć dla tego kursu");
            }
            CoursesDataGridView.DataSource = context.Courses.ToList();
            context.Dispose();
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
    }
}
