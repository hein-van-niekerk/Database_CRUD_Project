using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG252_Assignment2_Milestone1
{
    internal class Student
    {
        public Student() { }

        int studentNumber;
        string studentName;
        string studentSurname;
        Image studentPicture;
        DateTime DoB;
        string studentGender;
        string phoneNumber;
        string address;

        public Student(int studentNumber, string studentName, Image studentPicture, DateTime doB1, string studentGender, string phoneNumber, string address)
        {
            this.studentNumber = studentNumber;
            this.studentName = studentName;
            this.studentPicture = studentPicture;
            DoB1 = doB1;
            this.studentGender = studentGender;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string StudentSurname { get => studentSurname; set => studentSurname = value; }
        public Image StudentPicture { get => studentPicture; set => studentPicture = value; }
        public DateTime DoB1 { get => DoB; set => DoB = value; }
        public string StudentGender { get => studentGender; set => studentGender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }





    }
}
