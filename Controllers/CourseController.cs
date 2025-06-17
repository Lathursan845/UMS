using C__project_1.Data;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__project_1.Controllers
{
    internal class CourseController
    {
        public void AddCourse(Course course) 
        {
            using (SQLiteConnection conn = DbCon.GetConnection())
            {                
                string query = "INSERT INTO Courses (CourseName, CourseDuration, CourseDescription) VALUES (@CourseName, @Duration, @CourseDescription)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
                    cmd.Parameters.AddWithValue("@Duration", course.CourseDuration);
                    cmd.Parameters.AddWithValue("@CourseDescription", course.CourseDescription);

                    cmd.ExecuteNonQuery();
                    
                }
            }
        }
    }
}
