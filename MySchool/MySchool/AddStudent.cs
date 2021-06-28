using MySchool.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool
{
    public class AddStudent : IOperation
    {
        StudentValidator validator = new StudentValidator();
        InputOutput InputOutput = new InputOutput();
        public string nameOfOperation { get; }
        public AddStudent()
        {
            nameOfOperation = "Add Student";
        }
        public void DoOperation()
        {
            var student = CreateStudent();
        }

        private Student CreateStudent()
        {
            string firstName;
            string lastName;
            string id;
            string year;
            string month;
            string day;
            string familyStatus;
            do
            {
                InputOutput.PrintToScreen("Please enter your first name: ");
                firstName = InputOutput.GetParmeter();

            } while (!validator.CheckName(firstName));
            return null;
}
    }
}
