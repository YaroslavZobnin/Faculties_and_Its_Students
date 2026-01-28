using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndFA
{
    internal class Faculty
    {
        private string? dean, nameOfFaculty, phoneNumber;
        public string? Dean
        {
            get { return dean; }
            set { dean = value; }
        }
        public string? NameOfFaculty
        {
            get { return nameOfFaculty; }
            set { nameOfFaculty = value; }
        }
        public string? PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public Faculty()
        {
            dean = "Неизвестно";
            nameOfFaculty = "Неизвестно";
            phoneNumber = "Неизвестно";
        }
        public Faculty(string dean, string nameOfFaculty, string phoneNumber)
        {
            Dean = dean ?? "Неизвестно";
            NameOfFaculty = nameOfFaculty ?? "Неизвестно";
            PhoneNumber = phoneNumber ?? "Неизвестно";
        }
        public int Bonuses(int grant)
        {
            if (grant < 0)
                throw new ArgumentOutOfRangeException("Попытка присвоивить нулевую стипендию");
            else return grant;
        }
    }
}
