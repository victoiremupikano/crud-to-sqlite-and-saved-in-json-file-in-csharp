using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqliteDbToJsonFile.Controllers
{
    class CIndividus
    {
        Dictionary<string, string> fields { get; set; }
        public Dictionary<string, string> message;
        public CIndividus(Dictionary<string, string> fields)
        {
            this.fields = fields;
        }
        public void add(CIndividus args)
        {
            Models.MIndividus obj = new Models.MIndividus();
            obj.insert(args.fields);
            message = obj.callback;
        }
        public void update(CIndividus args)
        {
            Models.MIndividus obj = new Models.MIndividus();
            obj.update(args.fields);
            message = obj.callback;
        }
        public void delete(CIndividus args)
        {
            Models.MIndividus obj = new Models.MIndividus();
            obj.delete(args.fields);
            message = obj.callback;
        }
    }
}
