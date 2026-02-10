using StudentAndFA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal static class Menu
    {
        public static void MainMenu()
        {
            try
            {
                string[] parts = StudentProcessing.TakingStringAboutStudentsFromFile("Student.txt");
                StudentProcessing.SplittingStudentInformationIntoFields(parts, out string[] surnames, out string[] nameOfFaculty, out double[] grant, out uint[][] marks);
                var person1 = new Student(surnames[0], nameOfFaculty[0], grant[0], marks[0]);
                Console.WriteLine(person1);
                parts = FacultyProcessing.TakingStringAboutFacultyFromFile("D:\\works\\2course_3semestr\\c#\\FirstLabFourthSemesterDelegateAndEvent\\YaroslavZobnin\\Laba1CSharpFourthSemesterSecondCourse\\StudentAndFA\\Faculty.txt");
                FacultyProcessing.DividingFacultyInformationIntoFields(parts, out string[] dean, out string[] facultyName, out string[] phoneNumber);
                var faculty1 = new Faculty(dean[0], facultyName[0], phoneNumber[0]);
                Console.WriteLine(faculty1);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
