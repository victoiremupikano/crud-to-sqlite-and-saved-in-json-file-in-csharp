using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omen_management.Controllers
{
    class CHoliday
    {
        Dictionary<string, string> fields { get; set; }
        public Dictionary<string, string> message;
        public CHoliday(Dictionary<string, string> fields)
        {
            this.fields = fields;
        }
        public void add(CHoliday args)
        {
            Models.MHoliday obj = new Models.MHoliday();
            obj.insert(args.fields);
            message = obj.callback;
        }
        public void update(CHoliday args)
        {
            Models.MHoliday obj = new Models.MHoliday();
            obj.update(args.fields);
            message = obj.callback;
        }
        public void delete(CHoliday args)
        {
            Models.MHoliday obj = new Models.MHoliday();
            obj.delete(args.fields);
            message = obj.callback;
        }
    }
}
