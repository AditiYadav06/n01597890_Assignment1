using n01597890_Assignment1.Business;
using n01597890_Assignment1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static n01597890_Assignment1.Business.Student;

namespace n01597890_Assignment1
{
    public partial class Form1 : Form
    {

        StudentList dataBaseClass = new StudentList();
        public Form1()
        {
            InitializeComponent();
        }



        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //Adding Student
        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string studentID = tbStudentID.Text;
                string name = tbStudentName.Text;
              



                // Validate and convert input to numeric types
                if (double.TryParse(tbAssignmentScore.Text, out double totalAssignmentScore) &&
                    double.TryParse(tbAssignmentMaxScore.Text, out double totalMaxScore))
                {
                    Student newStudent = new Student(studentID, name, totalAssignmentScore, totalMaxScore);
                    dataBaseClass.AddStudent(newStudent);
                    MessageBox.Show("Student added successfully.");
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric values for assignment scores.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the student: " + ex.Message);
            }

        }


        //Adding Assignment
        private void btAddAssignment_Click(object sender, EventArgs e)
        {

            try
            {
                string studentID = tbStudentID.Text;
                string assignmentID = tbAssigmentID.Text;

                // Validate and convert input to numeric types
                if (double.TryParse(tbAssignmentScore.Text, out double totalAssignmentScore) &&
                    double.TryParse(tbAssignmentMaxScore.Text, out double totalMaxScore))
                {
                    Student student = dataBaseClass.FindStudentByID(studentID);

                    if (student != null)
                    {
                        Assignment newAssignment = new Assignment(assignmentID, totalAssignmentScore, totalMaxScore);
                        student.Assignments.Add(newAssignment);
                        MessageBox.Show("Assignment added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Student not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric values for assignment scores.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the assignment, Try Again !!: " + ex.Message);
            }



        }


        //Display Students
        private void bt_Display_Click(object sender, EventArgs e)
        {
            try
            {
                // Get all students
                Student[] studentArray = dataBaseClass.GetAllStudent();

                if (studentArray != null)
                {
                    // Bind the array of students to the DataGridView for display
                    gvStudent.DataSource = studentArray;
                    gvStudent.Refresh();
                }
                else
                {
                    MessageBox.Show("No students found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying students: " + ex.Message);
            }
        }


        //remove student
        private void btRemove_Click(object sender, EventArgs e)
        {
            string studentID = tbStudentID.Text;

            Student studentToRemove = dataBaseClass.FindStudentByID(studentID);
            if (studentToRemove != null)
            {
                dataBaseClass.RemoveStudent(studentToRemove);
                MessageBox.Show("Student removed successfully.");
            }
            else
            {
                MessageBox.Show("Student not found.");
            }
        }


        //remove Asigmnent
        private void btRemoveAssignment_Click(object sender, EventArgs e)
        {
            string studentID = tbStudentID.Text;
            string assignmentID = tbAssigmentID.Text;

            Student student = dataBaseClass.FindStudentByID(studentID);
            if (student != null)
            {
                Assignment assignmentToRemove = student.Assignments.FirstOrDefault(a => a.AssignmentID == assignmentID);
                if (assignmentToRemove != null)
                {
                    student.Assignments.Remove(assignmentToRemove);
                    MessageBox.Show("Assignment removed successfully.");
                }
                else
                {
                    MessageBox.Show("Assignment not found. May be already Deleated");
                }
            }
            else
            {
                MessageBox.Show("Student not found. Check Again");
            }
        }


        //update
        private void btUpdateScore_Click(object sender, EventArgs e)
        {
          
                if (string.IsNullOrEmpty(tbStudentID.Text))
                {
                    MessageBox.Show("Please insert student id");
                    tbStudentID.Focus();
                    return;
                }

                string studentID = tbStudentID.Text;
                Student studentToUpdate = dataBaseClass.FindStudentByID(studentID);

                if (studentToUpdate == null)
                {
                    MessageBox.Show("Student not found. Check Again");
                    return;
                }

                string assignmentID = tbAssigmentID.Text;

                // Validate and convert input to numeric types
                if (double.TryParse(tbAssignmentScore.Text, out double assignmentScore) &&
                    double.TryParse(tbAssignmentMaxScore.Text, out double assignmentMaxScore))
                {
                    Assignment assignmentToUpdate = studentToUpdate.Assignments.FirstOrDefault(a => a.AssignmentID == assignmentID);

                    if (assignmentToUpdate != null)
                    {
                        assignmentToUpdate.TotalAssignmentScore = assignmentScore;
                        assignmentToUpdate.TotalMaxScore = assignmentMaxScore;

                        MessageBox.Show("Assignment scores updated successfully.");

                        // Refresh the grid view
                        gvStudent.DataSource = new[] { studentToUpdate };
                        gvStudent.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Assignment not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric values for assignment scores.");
                }
            }

        private void bt_Find_Click(object sender, EventArgs e)
        {
            try
            {
                string studentID = tbStudentID.Text;

                // Find the student
                Student student = dataBaseClass.FindStudentByID(studentID);

                if (student != null)
                {
                    // Display student details
                    tbStudentName.Text = student.Name;
                    MessageBox.Show("Student found.");
                }
                else
                {
                    MessageBox.Show("Student not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while finding the student: " + ex.Message);
            }
        }

        private void tbStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btDisplayAssignment_Click(object sender, EventArgs e)
        {

            try
            {
                // Call the modified DisplayAllAssignments method to get the assignment details
                List<AssignmentDisplayModel> assignmentDisplayList = dataBaseClass.DisplayAllAssignments();

                if (assignmentDisplayList != null && assignmentDisplayList.Count > 0)
                {
                    // Bind the list of assignments to the DataGridView for display
                    gvStudent.DataSource = assignmentDisplayList;
                    gvStudent.Refresh();
                }
                else
                {
                    MessageBox.Show("No assignments found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying assignments: " + ex.Message);
            }
        }

   


    }
    }
