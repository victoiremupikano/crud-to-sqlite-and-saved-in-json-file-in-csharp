using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqliteDbToJsonFile.Apps
{
    class Schema
    {
        public Dictionary<string, string> table = new Dictionary<string, string> {
            { "tb_individus", "individus" }
        };

        /// <summary>
        /// les champs des differentes tables
        /// </summary>
        public Dictionary<string, string> tb_individus = new Dictionary<string, string> {
            { "id", "matricule" },
            { "nom", "nom" },
            { "postnom", "postnom" },
            { "dteNais", "datenais" },
            { "lieuNais", "lieunais" },
            { "genre", "genre" },
            { "adresse", "adresse" },
            { "numCarte", "numcarte" },
            { "origine", "origine" }
        };
    }
}
