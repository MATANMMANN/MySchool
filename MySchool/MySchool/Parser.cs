using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool
{
    public class Parser
    {
        public int ParseNumber(string number)
        {
            try
            {
                return int.Parse(number);
            }
            catch (Exception)
            {
                return -1;

            }
        }
    }
}
