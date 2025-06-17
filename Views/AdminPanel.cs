using C__project_1.Views.DashboardFls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__project_1.Views
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selected = e.Node.Text;
            panelRight.Controls.Clear();

            if (selected =="Add Student")
            {
                AddStudentAction addStudentAction = new AddStudentAction();
                addStudentAction.Dock = DockStyle.Fill;
                panelRight.Controls.Add(addStudentAction);
            }
            else if (selected == "View/Edit/Delete Student")
            {
                StudentActions StudentActions = new StudentActions();
                StudentActions.Dock = DockStyle.Fill;
                panelRight.Controls.Add(StudentActions);
            }


            else if (selected == "Add User")
            {
                AddUserAction adduserAction = new AddUserAction();
                adduserAction.Dock = DockStyle.Fill;
                panelRight.Controls.Add(adduserAction);
            }
            else if (selected == "View/Edit/Delete User")
            {
                UserActions UserActions = new UserActions();
                UserActions.Dock = DockStyle.Fill;
                panelRight.Controls.Add(UserActions);
            }


            else if (selected == "Add Course")
            {
                AddCourseAction addcourseAction = new AddCourseAction();
                addcourseAction.Dock = DockStyle.Fill;
                panelRight.Controls.Add(addcourseAction);
            }
            else if (selected == "View/Edit/Delete Course")
            {
                CourseActions CourseActions = new CourseActions();
                CourseActions.Dock = DockStyle.Fill;
                panelRight.Controls.Add(CourseActions);
            }


            else if (selected == "Add Subject")
            {
                AddSubjectAction addsubjectAction = new AddSubjectAction();
                addsubjectAction.Dock = DockStyle.Fill;
                panelRight.Controls.Add(addsubjectAction);
            }
            else if (selected == "View/Edit/Delete Subject")
            {
                SubjectActions SubjectActions = new SubjectActions();
                SubjectActions.Dock = DockStyle.Fill;
                panelRight.Controls.Add(SubjectActions);
            }


            else if (selected == "Add Exam")
            {
                AddExamAction addexamAction = new AddExamAction();
                addexamAction.Dock = DockStyle.Fill;
                panelRight.Controls.Add(addexamAction);
            }
            else if (selected == "View Exam")
            {
                ExamActions ExamActions = new ExamActions();
                ExamActions.Dock = DockStyle.Fill;
                panelRight.Controls.Add(ExamActions);
            }


            else if (selected == "Add Marks")
            {
                AddMarksActions addmarkActions = new AddMarksActions();
                addmarkActions.Dock = DockStyle.Fill;
                panelRight.Controls.Add(addmarkActions);
            }
            else if (selected == "View Mark")
            {
                MarkActions MarkActions = new MarkActions();
                MarkActions.Dock = DockStyle.Fill;
                panelRight.Controls.Add(MarkActions);
            }


            else if (selected == "Add Timetable")
            {
                AddTimetableAction addtimetableActions = new AddTimetableAction();
                addtimetableActions.Dock = DockStyle.Fill;
                panelRight.Controls.Add(addtimetableActions);
            }
            else if (selected == "View Timetable")
            {
                TimetableActions TimetableActions = new TimetableActions();
                TimetableActions.Dock = DockStyle.Fill;
                panelRight.Controls.Add(TimetableActions);
            }


            else if (selected == "Add Room")
            {
                AddRoomAction addroomActions = new AddRoomAction();
                addroomActions.Dock = DockStyle.Fill;
                panelRight.Controls.Add(addroomActions);
            }
            else if (selected == "View Timetable")
            {
                RoomActions RoomActions = new RoomActions();
                RoomActions.Dock = DockStyle.Fill;
                panelRight.Controls.Add(RoomActions);
            }
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            //Student
            TreeNode studentNode = treeAdmin.Nodes.Add("Student management");
            studentNode.Nodes.Add("Add Student");
            studentNode.Nodes.Add("View/Edit/Delete Student");

            //User
            TreeNode userNode = treeAdmin.Nodes.Add("User management");
            userNode.Nodes.Add("Add User");
            userNode.Nodes.Add("View/Edit/Delete User");

            //Course
            TreeNode courseNode = treeAdmin.Nodes.Add("Course management");
            courseNode.Nodes.Add("Add Course");
            courseNode.Nodes.Add("View/Edit/Delete Course");

            //Subject
            TreeNode SubjectNode = treeAdmin.Nodes.Add("Subject management");
            SubjectNode.Nodes.Add("Add Subject");
            SubjectNode.Nodes.Add("View/Edit/Delete Subject");


            //Exam
            TreeNode examNode = treeAdmin.Nodes.Add("User management");
            examNode.Nodes.Add("Add Student");
            examNode.Nodes.Add("View/Edit/Delete Student");


            TreeNode marksNode = treeAdmin.Nodes.Add("Marks management");
            marksNode.Nodes.Add("Add Marks");
            marksNode.Nodes.Add("View/Edit/Delete Marks");


            TreeNode timetableNode = treeAdmin.Nodes.Add("Timetable management");
            timetableNode.Nodes.Add("Add Timetable");
            timetableNode.Nodes.Add("View/Edit/Delete Timetable");


            TreeNode roomNode = treeAdmin.Nodes.Add("Room management");
            roomNode.Nodes.Add("Add Room");
            roomNode.Nodes.Add("View/Edit/Delete Room");

        }
    }
}
