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

            firstName = getParm("first name", validator.CheckName);
            lastName = getParm("last name", validator.CheckName);
            id = getParm("id", validator.CheckId);
            year = getParm("year of birth", validator.CheckYear);
            month = getParm("month of birth", validator.CheckMonth);
            day = getParm("day of birth", validator.CheckDay);
            familyStatus = getParm("family status(bachelor,divorcee,married,widower)",validator.CheckFamilyStatus);
            return null;
        }

        private string getParm(string paramName,Func<string,bool> validator)
        {
            string parameter=null;
            do
            {
                InputOutput.PrintToScreen(String.Format("Please enter your {0}:",paramName));
                parameter = InputOutput.GetParmeter();

            } while (!validator(parameter));

            return parameter;
        }
    }
}
