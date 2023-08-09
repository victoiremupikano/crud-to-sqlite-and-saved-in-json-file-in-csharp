using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omen_management.Services
{
    internal class Os
    {
        public string GetOSLanguage()
        {
            return System.Globalization.CultureInfo.InstalledUICulture.NativeName;
        }
    }
}
