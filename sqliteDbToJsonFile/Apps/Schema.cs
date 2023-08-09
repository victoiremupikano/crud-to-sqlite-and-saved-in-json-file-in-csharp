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
        public Dictionary<string, string> tb_entreprise = new Dictionary<string, string> {
            { "id", "id" },
            { "nom", "nom" },
            { "postnom", "postnom" },
            { "dteNais", "dteNais" },
            { "lieuNais", "lieuNais" },
            { "genre", "genre" },
            { "adresse", "adresse" },
            { "numCarte", "numCarte" },
            { "origine", "origine" }
        };
    }
}
