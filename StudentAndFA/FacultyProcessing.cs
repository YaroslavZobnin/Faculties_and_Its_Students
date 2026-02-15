namespace StudentAndFaculty
{
    internal static class FacultyProcessing
    {
        public static string[] TakingStringAboutFacultyFromFile(string fileName)
        {
            try
            {
                string[] lines = File.ReadAllLines(fileName);
                return lines;
            }
            catch (FileNotFoundException ex)
            {
                throw new Exception("Не найден файл, который хранит в себе информацию о факультетах.", ex);
            }
        }
        public static void DividingFacultyInformationIntoFields(string[] parts, out string[] dean, out string[] nameOfFaculty, out string[] phoneNumber)
        {
            dean = new string[parts.Length];
            nameOfFaculty = new string[parts.Length];
            phoneNumber = new string[parts.Length];
            for(int i = 0; i < parts.Length; i++)
            {
                string part = parts[i];
                string[] partsOfPart = part.Split(';');
                if (partsOfPart.Length != 3)
                    throw new ArgumentOutOfRangeException($"Количество элементов в файле не соответствует количеству полей (в строке {i + 1}).");
                dean[i] = partsOfPart[0];
                nameOfFaculty[i] = partsOfPart[1];
                phoneNumber[i] = partsOfPart[2];
            }
        }
        public static Faculty[] CreatingFaculties(string[] deans, string[] nameOfFaculties, string[] phoneNumbers, ClassCollection<Student> students)
        {
            var teampArray = new Faculty[deans.Length];
            for (int i = 0; i < deans.Length; i++)
            {
                var faculty = new Faculty(deans[i], nameOfFaculties[i], phoneNumbers[i], students);
                teampArray[i] = faculty;
            }
            return teampArray;
        }

    }
}
