using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool
{
    public class BaseValidator
    {
        public  Parser parser = new Parser();
        public bool CheckIfOperationChooseIsValid(string userInput,int numberOfOperations)
        {
            try
            {
                int userInputNumeric= parser.ParseNumber(userInput);
                if (userInputNumeric > numberOfOperations || userInputNumeric <= 0) return false;
            }
            catch(Exception)
            {
                return false;
            }

            return true;
        }
    }
}
