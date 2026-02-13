namespace StudentAndFaculty
{
    internal static class ConsoleOutputInformation
    {
        private static void HeadOfTable()
        {
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("|  №  |\t       Фамилия    \t| Средний балл \t|\tСтипендия  |");
            Console.WriteLine("|------------------------------------------------------------------|");
        }
        private static void OutputInfoAboutFaculty(Faculty faculty)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(faculty.ToString());
            Console.ResetColor();
        }
        public static void OutputInfoAboutStudent(Student student, int hisNumber) => Console.WriteLine($"| {hisNumber, 3} | {student.Surname, 23} | {student.AverageMark, 13} | {student.Grant,16} |");

        public static void MainTable(ClassCollection<Student> student, ClassCollection<Faculty> faculty)
        {
            OutputInfoAboutFaculty(faculty[0]);
            HeadOfTable();
            OutputInfoAboutStudent(student[0], 10);
        }
    }
}
