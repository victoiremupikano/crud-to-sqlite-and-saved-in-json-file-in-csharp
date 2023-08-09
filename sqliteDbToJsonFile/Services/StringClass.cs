using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqliteDbToJsonFile.Services
{
    internal class StringClass
    {
        public bool IsContainsChar(string ch, string txt)
        {
            bool result = false;
            if (txt.Contains(ch))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
