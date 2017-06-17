using SewingCourses.Events;
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
    public partial class CourseAddingForm : Form
    {
        public CourseAddingForm()
        {
            InitializeComponent();
        }

        private void ProffesionalCourseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(ProffesionalCourseRadioButton.Checked)
            {
                QualificationLabel.Visible = true;
                QualificationTextBox.Visible = true;
            } else
            {
                QualificationLabel.Visible = false;
                QualificationTextBox.Visible = false;
            }
        }

        private void SemesterCourseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SemesterCourseRadioButton.Checked)
            {
                SemesterStartDateLabel.Visible = true;
                SemesterStartDateTimePicker.Visible = true;
                SemesterEndLabel.Visible = true;
                SemesterEndDateTimePicker.Visible = true;
            } else
            {
                SemesterStartDateLabel.Visible = false;
                SemesterStartDateTimePicker.Visible = false;
                SemesterEndLabel.Visible = false;
                SemesterEndDateTimePicker.Visible = false;
            }
        }

        private void CancelAddCourseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateCourseButton_Click(object sender, EventArgs e)
        {
            using (var context = new SewingCoursesDbContext())
            {
                if (ProffesionalCourseRadioButton.Checked)
                {
                    ProfessionalCourse course = new ProfessionalCourse();
                    course.Qualifications = QualificationTextBox.Text;
                    course.Name = CourseNameTextBox.Text;
                    course.Price = float.Parse(CoursePriceTextBox.Text);
                    context.Courses.Add(course);
                    context.SaveChanges();
                }
                else if (SemesterCourseRadioButton.Checked)
                {
                    SemesterCourse course = new SemesterCourse();
                    course.StartDate = SemesterStartDateTimePicker.Value;
                    course.EndDate = SemesterEndDateTimePicker.Value;
                    course.Name = CourseNameTextBox.Text;
                    course.Price = float.Parse(CoursePriceTextBox.Text);
                    context.Courses.Add(course);
                    context.SaveChanges();
                }
                else
                {
                    NormalCourse course = new NormalCourse();
                    course.Name = CourseNameTextBox.Text;
                    course.Price = float.Parse(CoursePriceTextBox.Text);
                    context.Courses.Add(course);
                    context.SaveChanges();
                }
            }

            DataEvents.RaiseDataChanged();
            Close();
        }

        private void CreateCourseAndClassesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
