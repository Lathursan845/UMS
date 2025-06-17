using C__project_1.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__project_1.Views.DashboardFls
{
    public partial class AddCourseAction : UserControl
    {
        public AddCourseAction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.CourseName = coursename.Text;
            course.CourseDuration = cDuration.Text;
            course.CourseDescription = cDescription.Text;

            CourseController courseController = new CourseController(); 
            courseController.AddCourse(course);

            MessageBox.Show("Course Added Successfully!");

            coursename.Text = "";
            cDuration.Text = "";
            cDescription.Text = "";

        }

        private void coursename_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
