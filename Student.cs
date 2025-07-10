// Write a class: “Student” with private data members: StudentId ( int), StudentFname (string), StudentLname (string ),
// StudentGrade ( char ) and public properties for each data member. Instantiate the class and assign data to properties.
// Display the data back on console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._4._2
{
    public class Student
    {
        //create a class called Student
        // with private fields (e.g., private string _studentFirstName)
        //create public properties for each field
        // StudentID (int), StudentFirstName (str), StudentLastName (str), StudentGrade (char)

        private int _studentID;
        public int StudentID
        {
            get
            {
                return _studentID;
            }

            set
            {
                _studentID = value;
            }
        }

        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public char StudentGrade { get; set; }

        public void DisplayStudentInfo(Student student)
        {
            Console.WriteLine("Student ID: ".PadLeft(12) + student.StudentID);
            Console.WriteLine("First name: ".PadLeft(12) + student.StudentFirstName);
            Console.WriteLine("Last name: ".PadLeft(12) + student.StudentLastName);
            Console.WriteLine("Grade: ".PadLeft(12) + student.StudentGrade);
            Console.WriteLine(); //extra line to separate multiple students
        }
    }
}
