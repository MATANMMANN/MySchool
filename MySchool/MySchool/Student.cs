using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public long id { get; set; }
        public DateTime birth { get; set; }
        public FamilyStatus familyStatus { get; set; }

        public Student(string firstName, string lastName, long id, DateTime birth, FamilyStatus familyStatus)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.birth = birth;
            this.familyStatus = familyStatus;
        }

        public Student(Student student)
        {
            firstName = student.firstName;
            lastName = student.lastName;
            id = student.id;
            birth = student.birth;
            familyStatus = student.familyStatus;
        }
    }
}
