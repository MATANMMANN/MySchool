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

        public bool CheckName(string name)
        {

            var regexForSpecialChar = new Regex($"[^\\w\\*]");
            if (name == "") return false;
            if (name.Any(char.IsDigit)) return false;
            if (regexForSpecialChar.IsMatch(name)) return false;
            return true;

        }
    }
}
