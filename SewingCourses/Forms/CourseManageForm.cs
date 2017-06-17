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
        public CourseManageForm(Course course)
        {
            InitializeComponent();
            CourseNameLabel.Text = course.Name;
            CourseClassesdataGridView.AutoGenerateColumns = false;
            using (var context = new SewingCoursesDbContext())
            {
                CourseClassesdataGridView.DataSource = context.Classes.Where(c => c.CourseId == course.CourseId).ToList();
            }
            
        }
    }
}
