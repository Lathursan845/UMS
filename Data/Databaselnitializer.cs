using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__project_1.Data
{
    internal static class Databaselnitializer
    {
        public static void CreateTables()
        {
            using (var conn = DbCon.GetConnection())
            {
                string createUserTableQuery = @"
                CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL
                    );";
                SQLiteCommand cmd = new SQLiteCommand(createUserTableQuery, conn);
                cmd.ExecuteNonQuery();
                
                string createStudentTableQuery= @"
                    CREATE TABLE IF NOT EXISTS Students (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        UT_Number TEXT NOT NULL,
                        Phone_Number TEXT NOT NULL,
                        Email TEXT NOT NULL
                    );";
                cmd = new SQLiteCommand(createStudentTableQuery, conn);
                cmd.ExecuteNonQuery();


                string createCourseTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Courses (
                        CourseId INTEGER PRIMARY KEY AUTOINCREMENT,
                        CourseName TEXT NOT NULL,
                        CourseDuration TEXT NOT NULL,
                        CourseDescription TEXT NOT NULL                        
                    );";
                cmd = new SQLiteCommand(createCourseTableQuery, conn);
                cmd.ExecuteNonQuery();


                string createStaffTable = @"
                 CREATE TABLE IF NOT EXISTS Staff (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Phone_Number TEXT NOT NULL,
                        Email TEXT NOT NULL
                    );";
                cmd = new SQLiteCommand(createStaffTable, conn);
                cmd.ExecuteNonQuery();

                string createAdminTable = @"
                 CREATE TABLE IF NOT EXISTS Admin (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Phone_Number TEXT NOT NULL,
                        Email TEXT NOT NULL
                    );";
                cmd = new SQLiteCommand(createAdminTable, conn);
                cmd.ExecuteNonQuery();

                string createLecturerTable = @"
                 CREATE TABLE IF NOT EXISTS Lecturer (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Phone_Number TEXT NOT NULL,
                        Email TEXT NOT NULL
                    );";
                cmd = new SQLiteCommand(createLecturerTable, conn);
                cmd.ExecuteNonQuery();


                string checkAdminQuery = "SELECT COUNT(*) FROM Users WHERE Role ='Admin'";
                cmd = new SQLiteCommand(checkAdminQuery, conn);
                long adminCount = (long)cmd.ExecuteScalar();


                if (adminCount == 0)
                {
                    string insertAdminQuery = "INSERT INTO Users (Username, Password , Role ) VALUES (@username, @password, @role)";
                    cmd= new SQLiteCommand(insertAdminQuery, conn);
                    cmd.Parameters.AddWithValue("@username", "admin");
                    cmd.Parameters.AddWithValue("@password", "admin123");
                    cmd.Parameters.AddWithValue("@role", "Admin");
                }




                //    CREATE TABLE IF NOT EXISTS Teachers (
                //         Id INTEGER PRIMARY KEY AUTOINCREMENT,
                //         Name TEXT NOT NULL,
                //         Address TEXT NOT NULL,
                //         Telephone TEXT NOT NULL
                //     );

                //";

                //SQLiteCommand command = new SQLiteCommand(tableQueries, conn);
                //command.ExecuteNonQuery();


            }
        }
    }
}

    