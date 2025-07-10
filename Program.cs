// Write a class: “Student” with private data members: StudentId ( int), StudentFname (string), StudentLname (string ),
// StudentGrade ( char ) and public properties for each data member. Instantiate the class and assign data to properties.
// Display the data back on console.

namespace Assignment_1._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            Student student1 = new();

            // Assign data to properties
            student1.StudentID = 1;
            student1.StudentFirstName = "Bobby";
            student1.StudentLastName = "Boucher";
            student1.StudentGrade = 'D';

            // Add a second student
            Student student2 = new();
            student2.StudentID = 2;
            student2.StudentFirstName = "Peter";
            student2.StudentLastName = "Parker";
            student2.StudentGrade = 'A';

            // Display student information
            student1.DisplayStudentInfo(student1);
            student2.DisplayStudentInfo(student2);
        }
    }
}