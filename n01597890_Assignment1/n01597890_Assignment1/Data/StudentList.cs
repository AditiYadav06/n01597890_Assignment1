using n01597890_Assignment1.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static n01597890_Assignment1.Business.Student;

namespace n01597890_Assignment1.Data
{
    internal class StudentList
    {
        List<Student> students = new List<Student>();
        List<Assignment> Assignments = new List<Assignment>();

        //Add Student
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        //Display Students
        internal Student[] GetAllStudent()
        {
            return students.ToArray<Student>();

        }


        //remove student
         public void RemoveStudent(Student student)
    {
        students.Remove(student);
    }

        //find student

        public Student FindStudentByID(string studentID)
        {
            return students.FirstOrDefault(s => s.StudentID == studentID);
        }

        public List<AssignmentDisplayModel> DisplayAllAssignments()
        {
            try
            {
                List<AssignmentDisplayModel> assignmentDisplayList = new List<AssignmentDisplayModel>();

                foreach (var student in students)
                {
                    foreach (var assignment in student.Assignments)
                    {
                        // Create a new AssignmentDisplayModel instance to hold assignment details
                        AssignmentDisplayModel assignmentDisplay = new AssignmentDisplayModel
                        {
                            StudentID = student.StudentID,
                            StudentName = student.Name,
                            AssignmentID = assignment.AssignmentID,
                            AssignmentName = assignment.AssignmentName,
                            TotalAssignmentScore = assignment.TotalAssignmentScore,
                            TotalMaxScore = assignment.TotalMaxScore
                        };

                        assignmentDisplayList.Add(assignmentDisplay);
                    }
                }

                return assignmentDisplayList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying assignments: " + ex.Message);
                return null; // Return null in case of an error
            }
        }


    }
}
public class AssignmentDisplayModel
{
    public string StudentID { get; set; }
    public string StudentName { get; set; }
    public string AssignmentID { get; set; }
    public string AssignmentName { get; set; }
    public double TotalAssignmentScore { get; set; }
    public double TotalMaxScore { get; set; }
}
