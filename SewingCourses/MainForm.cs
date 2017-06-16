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
using System.Data.Entity;

namespace SewingCourses
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SewingCoursesDbContext context = new SewingCoursesDbContext();
            UpcomingCoursesListBox.ValueMember = "Name";
            UpcomingCoursesListBox.DataSource = context.Courses.Include(c => c.Classes).ToList();
            UpcomingClassesDataGridView.AutoGenerateColumns = false;

            try
            {
                UpcomingClassesDataGridView.AutoGenerateColumns = false;
                UpcomingClassesDataGridView.DataSource = ((Course)UpcomingCoursesListBox.SelectedItem).Classes.ToList();
            }
            catch (NullReferenceException)
            {
                // MessageBox.Show("Brak nadchodzących zajęć dla tego kursu");
            }
            

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
    }
}
