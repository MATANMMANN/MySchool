using Microsoft.Data.Sqlite;
using MySchool.Validator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool
{
    public class AddStudent : IOperation
    {
        StudentValidator validator = new StudentValidator();
        InputOutput InputOutput = new InputOutput();
        Parser parser = new Parser();
        public string nameOfOperation { get; }
        public AddStudent()
        {
            nameOfOperation = "Add Student";
        }
        public void DoOperation()
        {
            var student = CreateStudent();
            EnterStudentIntoDB(student);

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
            familyStatus = getParm("family status(bachelor,divorcee,married,widower)", validator.CheckFamilyStatus);

            return new Student(
                firstName,
                lastName,
                parser.ParseNumber(id),
                new DateTime(parser.ParseNumber(year), parser.ParseNumber(month), parser.ParseNumber(day)),
                (FamilyStatus)Enum.Parse(typeof(FamilyStatus), familyStatus, true));
        }

        private string getParm(string paramName, Func<string, bool> validator)
        {
            string parameter = null;
            do
            {
                InputOutput.PrintToScreen(String.Format("Please enter your {0}:", paramName));
                parameter = InputOutput.GetParmeter();

            } while (!validator(parameter));

            return parameter;
        }

        private void EnterStudentIntoDB(Student student)
        {
            using (var con = new SQLiteConnection(@"URI=file: C:\Code\MySchool\MySchool\MySchool\Students.db"))
            {
                string query = String.Format("INSERT INTO School_Students (FirstName, LastName, Id, BirthDate, FamilyStatus)VALUES('{0}', '{1}', '{2}', '{3}-{4}-{5}', '{6}');",student.firstName,student.lastName,student.id,student.birth.Day,student.birth.Month,student.birth.Year,student.familyStatus);
                
                using (var cmd = new SQLiteCommand(query, con)) 
                {
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
