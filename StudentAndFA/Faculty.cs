namespace StudentAndFaculty
{
    internal class Faculty
    {
        private string? dean, nameOfFaculty, phoneNumber;
        private const string uk = "Неизвестно";
        private Student[] students = Array.Empty<Student>();
        public string? Dean
        {
            get { return dean; }
            set { dean = value ?? uk; }
        }
        public string? NameOfFaculty
        {
            get { return nameOfFaculty; }
            set
            {
                if(nameOfFaculty != value)
                {
                    nameOfFaculty = value ?? uk;
                    ChangeFacultyName?.Invoke(this,EventArgs.Empty);
                }
            }
        }
        public string? PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value ?? uk; }
        }
        public Student[] Students => students; 
        public Faculty()
        {
            dean = uk;
            nameOfFaculty = uk;
            phoneNumber = uk;
            students = Array.Empty<Student>();
        }
        public Faculty(string dean, string nameOfFaculty, string phoneNumber, ClassCollection<Student> students)
        {
            Dean = dean ?? uk;
            NameOfFaculty = nameOfFaculty ?? uk;
            PhoneNumber = phoneNumber ?? uk;
            if (students != null)
            {
                int count = 0;
                foreach (var student in students)
                {
                    if (student.NameFaculty == nameOfFaculty)
                        count++;
                }
                this.students = new Student[count];
            }
        }
        public event EventHandler? ChangeFacultyName;
        public event BonusEventHandler? Bonus;
        public void Bonuses(double bonusAmount) => Bonus?.Invoke(bonusAmount);
        public override string ToString() => Dean + " " + NameOfFaculty + " " + PhoneNumber;
        
        public void RegisterStudent(Student student, ref int hisIndex)
        {
            if (student.NameFaculty == NameOfFaculty)
            {
                students[hisIndex++] = student;
                if (student.IsExcellentPupil)
                    Bonus += student.AddingGrant;
                ChangeFacultyName += student.ChangingTheNameOfFaculty;
            }
            else
                throw new ArgumentException("Нельзя присвоить студента на чужой факультет!");
        }
    }
}
