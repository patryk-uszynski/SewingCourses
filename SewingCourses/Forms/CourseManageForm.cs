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
    public partial class CourseManageForm : Form
    {
        private SewingCoursesDbContext context;
        private Course course;

        public CourseManageForm(SewingCoursesDbContext context, Course course)
        {
            InitializeComponent();
            this.context = context;
            this.course = course;
            CourseNameLabel.Text = course.Name;
            CourseClassesdataGridView.AutoGenerateColumns = false;
            RefreshData();
        }

        public void RefreshData()
        {
            CourseClassesdataGridView.DataSource = context.Classes.Where(c => c.CourseId == course.CourseId).ToList();
        }

        private void AddClassesButton_Click(object sender, EventArgs e)
        {
            var form = new ClassesAddingForm(context, course, this);
            form.Show();
        }
    }
}
