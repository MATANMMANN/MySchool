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
        BaseValidator validator = new BaseValidator();
        List<IOperation> operations;
        public void Start()
        {
            operations = CreateListOfOperations();
            ChooseOperation(1); // need to be in config.json of project
            operations[0].DoOperation(); //need to get down after finish
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

        private List<IOperation> CreateListOfOperations()
        {
            List<IOperation> operations = new List<IOperation>();
            operations.Add(new AddStudent());

            return operations;
        }




    }
}
