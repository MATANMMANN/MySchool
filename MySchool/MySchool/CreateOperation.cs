using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool
{
    public class CreateOperation
    {
        InputOutput InputOutput = new InputOutput();
        Validator validator = new Validator();
        public void Start()
        {
            ChooseOperation(1);
        }

        private void ChooseOperation(int numberOfOperations)
        {
            string operationChoise;
            do
            {
                InputOutput.PrintToScreen("Which operation you want to do?");
                InputOutput.PrintToScreen("1 - Create new Student");
                operationChoise = InputOutput.GetParmeter();
            } while (!validator.CheckIfOperationChooseIsValid(operationChoise, numberOfOperations));
            


        }

       


    }
}
