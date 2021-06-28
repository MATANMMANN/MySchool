using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool
{
    public class Student
    {
        private string _firstName { get; set; }
        private string _lastName;
        private long _id;
        private DateTime _birth;
        private FamilyStatus _familyStatus;

        public Student(string firstName,string lastName,long id,DateTime birth,FamilyStatus familyStatus)
        {
            _firstName = firstName;
            _lastName = lastName;
            _id = id;
            _birth = birth;
            _familyStatus = familyStatus;
        }
    }
}
