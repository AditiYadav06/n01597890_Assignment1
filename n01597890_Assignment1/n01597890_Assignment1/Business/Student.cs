using n01597890_Assignment1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n01597890_Assignment1.Business
{
    internal class Student : IEquatable<Student>
    {
		//To generate unique ids for student
		private static int idCounter = 1;
		private string studentID;
          

        public string StudentID
		{
			get { return studentID; }
			set { studentID = value; }
		}

		private string name;

		public  string Name
		{
			get { return name; }
			set { name = value; }
		}

		public class Assignment
		{
            private string assignmentName;

            public string AssignmentName
            {
                get { return assignmentName; }
                set { assignmentName = value; }
            }

            private string assignmentID;

            public string AssignmentID
            {
                get { return assignmentID; }
                set { assignmentID = value; }
            }


            private double totalAssignmentScore;

            public double TotalAssignmentScore
            {
                get { return totalAssignmentScore; }
                set { totalAssignmentScore = value; }
            }

            private double totalMaxScore;

            public Assignment(string assignmentID, double totalAssignmentScore, double totalMaxScore)
            {
                this.assignmentID = assignmentID;
                this.totalAssignmentScore = totalAssignmentScore;
                this.totalMaxScore = totalMaxScore;
            }

            public double TotalMaxScore
            {
                get { return totalMaxScore; }
                set { totalMaxScore = value; }
            }

        }
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();


        public Student()
        {
         // Generate a unique student ID
            StudentID = GenerateUniqueStudentId();
        }

        public Student(string studentID, string name, double totalAssignmentScore, double totalMaxScore)
        {
            this.studentID = studentID;
            this.name = name;
           

        }

        // Generate a unique student ID METHOD
        private string GenerateUniqueStudentId()
        {
            return "STU" + idCounter++;
        }

     




		bool IEquatable<Student>.Equals(Student other)
		{
			return (studentID == other.StudentID && name == other.Name );
		}






       


    }
}
