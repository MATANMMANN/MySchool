using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MySchool.Validator
{
    public class StudentValidator : BaseValidator
    {
        Parser parser = new Parser();

        public bool CheckName(string name)
        {

            var regexForSpecialChar = new Regex($"[^\\w\\*]");
            if (name == "") return false;
            if (name.Any(char.IsDigit)) return false;
            if (regexForSpecialChar.IsMatch(name)) return false;
            return true;

        }
        public bool CheckId(string id)
        {
            if (!IsDigitsOnly(id))
            {
                return false;
            }
            else if (id.Length != 9)
            {
                return false;
            }
            return true;
        }

        public bool CheckYear(string year)
        {
            if (!IsDigitsOnly(year))
            {
                return false;
            }
            int yearNum = parser.ParseNumber(year);
            if (yearNum > DateTime.Now.Year) return false;
            if (yearNum < 1900) return false;
            return true;

        }
        public bool CheckMonth(string month)
        {
            if (!IsDigitsOnly(month))
            {
                return false;
            }
            int monthNum = parser.ParseNumber(month);
            if (monthNum <= 0 || monthNum > 12) return false;
            return true;
        }
        public bool CheckDay(string day)
        {
            if (!IsDigitsOnly(day))
            {
                return false;
            }
            int dayNum = parser.ParseNumber(day);
            if (dayNum <= 0 || dayNum > 31) return false;
            return true;
        }
        public bool CheckFamilyStatus(string familyStatus)
        {
            familyStatus = familyStatus.ToLower();
            return Enum.IsDefined(typeof(FamilyStatus), familyStatus);
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
