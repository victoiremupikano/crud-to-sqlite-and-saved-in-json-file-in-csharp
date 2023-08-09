using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqliteDbToJsonFile.Services
{
    internal class Os
    {
        public string GetOSLanguage()
        {
            return System.Globalization.CultureInfo.InstalledUICulture.NativeName;
        }
    }
}
