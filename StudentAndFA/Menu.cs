using StudentAndFA;

namespace StudentAndFaculty
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
                var person2 = new Student(surnames[1], nameOfFaculty[1], grant[1], marks[1]);
                //Console.WriteLine(person1);
                parts = FacultyProcessing.TakingStringAboutFacultyFromFile("D:\\works\\2course_3semestr\\c#\\FirstLabFourthSemesterDelegateAndEvent\\YaroslavZobnin\\Laba1CSharpFourthSemesterSecondCourse\\StudentAndFA\\Faculty.txt");
                FacultyProcessing.DividingFacultyInformationIntoFields(parts, out string[] dean, out string[] facultyName, out string[] phoneNumber);
                var faculty1 = new Faculty(dean[0], facultyName[0], phoneNumber[0]);
                //Console.WriteLine(faculty1);
                var studentsCollection = new ClassCollection<Student>();
                studentsCollection.AddNewElementsInClassCollection(person1, person2);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
