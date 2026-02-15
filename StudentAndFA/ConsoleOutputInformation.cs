namespace StudentAndFaculty
{
    internal static class ConsoleOutputInformation
    {
        private static void HeadOfTheTable()
        {
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("|  №  |\t       Фамилия    \t| Средний балл \t|\tСтипендия  |");
            Console.WriteLine("|------------------------------------------------------------------|");
        }
        private static void EndOfTheTable() => Console.WriteLine("|------------------------------------------------------------------|");
        private static void OutputInfoAboutFaculty(Faculty faculty)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(faculty.ToString());
            Console.ResetColor();
        }
        private static void OutputInfoAboutStudent(Student student, int hisNumber) => Console.WriteLine($"| {hisNumber, 3} | {student.Surname, 23} | {student.AverageMark, 13} | {student.Grant,16} |");
        private static void OutputMessageAboutAbsenceOfStudents()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Данный факультет не имеет студентов.");
            Console.ResetColor();
        }
        public static void MainTable(ClassCollection<Student> students, ClassCollection<Faculty> faculties)
        {
            for(int i = 0; i < faculties.CountElements; i++)
            {
                bool haveStudents = false;
                OutputInfoAboutFaculty(faculties[i]);
                foreach(var student in students)
                {
                    if (student.NameFaculty == faculties[i].NameOfFaculty)
                    {
                        haveStudents = true;
                        break;
                    }
                }
                if(!haveStudents)
                {
                    OutputMessageAboutAbsenceOfStudents();
                    Console.WriteLine();
                    continue;
                }
                HeadOfTheTable();
                int studentIndexInFaculty = 1;
                for (int j = 0;  j < students.CountElements; j++)
                {
                    if (faculties[i].NameOfFaculty == students[j].NameFaculty)
                        OutputInfoAboutStudent(students[j], studentIndexInFaculty++);
                }
                EndOfTheTable();
                Console.WriteLine();
            }
        }
    }
}
