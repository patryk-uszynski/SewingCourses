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

        public CourseManageForm(SewingCoursesDbContext context, Course course)
        {
            InitializeComponent();
            this.context = context;
            CourseNameLabel.Text = course.Name;
            CourseClassesdataGridView.AutoGenerateColumns = false;
            CourseClassesdataGridView.DataSource = context.Classes.Where(c => c.CourseId == course.CourseId).ToList();
        }
    }
}
