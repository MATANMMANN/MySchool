using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student s = new Student("g", "d", 13, new DateTime(), FamilyStatus.bachelor);
            Console.WriteLine(s.firstName);
        }
    }
}
