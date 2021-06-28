using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool
{
    public class InputOutput
    {
        public void PrintToScreen(string text)
        {
            Console.WriteLine(text);
        }

        public void LineDown()
        {
            Console.WriteLine();
        }

        public string GetParmeter()
        {
            return Console.ReadLine();
        }
    }
}
