using SewingCourses.Models;
using SewingCourses.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SewingCourses.Forms
{
    public partial class ClassesAddingForm : Form
    {
        private SewingCoursesDbContext context;
        private Course course;
        private CourseManageForm parentForm;

        public ClassesAddingForm(SewingCoursesDbContext context, Course course, CourseManageForm parentForm)
        {
            this.context = context;
            this.course = course;
            this.parentForm = parentForm;

            InitializeComponent();

            LocationComboBox.DataSource = context.Locations.ToList();
            TeacherComboBox.DataSource = context.Persons.OfType<Teacher>().ToList();
        }

        private void CancelAddingButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddClassesButton_Click(object sender, EventArgs e)
        {
            Classes classes = new Classes();
            classes.StartDateTime = StartDateTimePicker.Value;
            classes.EndDateTime = EndDateTimePicker.Value;
            classes.CourseId = course.CourseId;
            classes.LocationId = (LocationComboBox.SelectedItem as Location).LocationId;
            classes.TeacherId = (TeacherComboBox.SelectedItem as Teacher).PersonId;

            context.Classes.Add(classes);
            context.SaveChanges();
            parentForm.RefreshData();
            Close();
        }
    }
}
