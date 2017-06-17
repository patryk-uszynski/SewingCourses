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
        private SewingCoursesDbContext context;

        public CourseAddingForm(SewingCoursesDbContext context)
        {
            this.context = context;
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

        private Course CreateCourse()
        {
            int CourseId;

            if (CoursePriceTextBox.Text.Equals(""))
            {
                MessageBox.Show("Pole Cena nie może być puste");
                return null;
            }
            
            if (ProffesionalCourseRadioButton.Checked)
            {
                ProfessionalCourse course = new ProfessionalCourse();
                course.Qualifications = QualificationTextBox.Text;
                course.Name = CourseNameTextBox.Text;
                course.Price = float.Parse(CoursePriceTextBox.Text);
                context.Courses.Add(course);
                context.SaveChanges();

                CourseId = course.CourseId;
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

                CourseId = course.CourseId;
            }
            else
            {
                NormalCourse course = new NormalCourse();
                course.Name = CourseNameTextBox.Text;
                course.Price = float.Parse(CoursePriceTextBox.Text);
                context.Courses.Add(course);
                context.SaveChanges();

                CourseId = course.CourseId;
            }
            

            DataEvents.RaiseDataChanged();
            Close();

            return context.Courses.Find(CourseId);
        }

        private void CreateCourseButton_Click(object sender, EventArgs e)
        {
            CreateCourse();
        }

        private void CreateCourseAndClassesButton_Click(object sender, EventArgs e)
        {
            var course = CreateCourse();

            if (course == null) return;

            var form = new Forms.CourseManageForm(context, course);
            form.Show();
        }
    }
}
