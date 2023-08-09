using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqliteDbToJsonFile.Models
{
    public class MJIndividus
    {
        public string matricule { set; get; }
        public string nom { set; get; }
        public string postnom { set; get; }
        public string datenais { set; get; }
        public string lieunais { set; get; }
        public string genre { set; get; }
        public string adresse { set; get; }
        public string numcarte { set; get; }
        public string origine { set; get; }
    }
}
