using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omen_management.Apps
{
    class Schema
    {
        public Dictionary<string, string> table = new Dictionary<string, string> {
            { "tb_entreprise", "entreprise" },
            { "tb_services", "services" },
            { "tb_job", "job" },
            { "tb_leave", "leaveS" },
            { "tb_rate", "rate" },
            { "tb_hourly", "hourly" },
            { "tb_member", "member" },
            { "tb_operation", "operation" },
            { "tb_hourly_partial_classment", "hourly_partial_classment" },
            { "tb_bck_users", "bck_users" },
            { "tb_bck_att", "bck_att" },
            { "tb_user", "user" },
            { "tb_autorized", "autorized" },
            { "tb_holiday", "holiday" }
        };

        /// <summary>
        /// les champs des differentes tables
        /// </summary>
        public Dictionary<string, string> tb_entreprise = new Dictionary<string, string> {
            { "id", "id_entreprise" },
            { "country", "country_entreprise" },
            { "ministry", "ministry_entreprise" },
            { "names", "names_entreprise" },
            { "addr_bp", "addr_bp_entreprise" },
            { "zs", "zs_entreprise" },
            { "as", "as_entreprise" },
            { "mail", "mail_entreprise" },
            { "tel", "tel_entreprise" },
            { "logo", "logo_entreprise" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };

        public Dictionary<string, string> tb_user = new Dictionary<string, string> {
            { "id", "id_user" },
            { "names", "names" },
            { "user", "username" },
            { "pwd", "password" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };

        public Dictionary<string, string> tb_services = new Dictionary<string, string> {
            { "id", "id_services" },
            { "names", "names_services" },
            { "fk_user", "fk_user" },
            { "fk_profile", "fk_entreprise" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };

        public Dictionary<string, string> tb_job = new Dictionary<string, string> {
            { "id", "id_job" },
            { "names", "names_job" },
            { "fk_serv", "fk_services" },
            { "fk_user", "fk_user" },
            { "fk_profile", "fk_entreprise" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };

        public Dictionary<string, string> tb_autorized = new Dictionary<string, string> {
            { "id", "id_autorized" },
            { "dte", "dte_autorized" },
            { "pattern", "pattern_autorized" },
            { "fk", "fk_oper" },
            { "fk_user", "fk_user" },
            { "fk_profile", "fk_entreprise" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };

        public Dictionary<string, string> tb_holiday = new Dictionary<string, string> {
            { "id", "id_holiday" },
            { "dte", "dte_holiday" },
            { "pattern", "pattern_holiday" },
            { "fk_user", "fk_user" },
            { "fk_profile", "fk_entreprise" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };

        public Dictionary<string, string> tb_leave = new Dictionary<string, string> {
            { "id", "id_leave" },
            { "dteStart", "dte_start_leave" },
            { "dteEnd", "dte_end_leave" },
            { "pattern", "pattern_leave" },
            { "status", "status" },
            { "fk_member", "fk_member" },
            { "fk_user", "fk_user" },
            { "fk_profile", "fk_entreprise" }, 
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };

        public Dictionary<string, string> tb_rate = new Dictionary<string, string> {
            { "id", "id_rate" },
            { "dte", "dte_rate" },
            { "value", "value_rate" },
            { "working_hour", "working_hour" },
            { "status", "status" },
            { "fk_user", "fk_user" },
            { "fk_profile", "fk_entreprise" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };

        public Dictionary<string, string> tb_hourly = new Dictionary<string, string> {
            { "id", "id_hourly" },
            { "day", "day_hourly" },
            { "pattern", "pattern_hourly" },
            { "time", "time_hourly" },
            { "number", "omen_number" },
            { "isNormal", "isNormal" },
            { "day_idx", "day_idx_hourly" },
            { "fk_job", "fk_job" },
            { "status", "status" },
            { "fk_user", "fk_user" },
            { "fk_profile", "fk_entreprise" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };

        public Dictionary<string, string> tb_hourly_partial_classment = new Dictionary<string, string> {
            { "id", "id_hourly_partial_classment" },
            { "dte", "dte_hourly_partial_classment" },
            { "day", "day_hourly_partial_classment" },
            { "omen_number", "omen_number" },
            { "status", "status" },
            { "about", "about_isNormal" },
            { "fk_job", "fk_job" },
            { "fk_member", "fk_member" },
            { "fk_user", "fk_user" },
            { "fk_profile", "fk_entreprise" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };

        public Dictionary<string, string> tb_member = new Dictionary<string, string> {
            { "id", "id_member" },
            { "names", "names_member" },
            { "birthday", "birthday_member" },
            { "kind", "kind_member" },
            { "tel1", "telephone1_member" },
            { "tel2", "telephone2_member" },
            { "mail", "mail_member" },
            { "adress", "adress_member" },
            { "photo", "photo_member" },
            { "footprint", "footprint" },
            { "base64", "base64" },
            { "fk_job", "fk_job" },
            { "fk_user", "fk_user" },
            { "fk_profile", "fk_entreprise" },
            { "status_job", "status_job" },
            { "special_acredited", "special_acredited" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };

        public Dictionary<string, string> tb_operation = new Dictionary<string, string> {
            { "id", "id_operation" },
            { "dayinletter", "dayinletter" },
            { "date", "date" },
            { "time", "time" },
            { "interface", "interface"},
            { "fk_member", "fk_member" },
            { "fk_hourly", "fk_hourly" },
            { "fk_rate", "fk_rate" },
            { "type", "type" },
            { "status", "status" },
            { "fk_user", "fk_user" },
            { "fk_profile", "fk_entreprise" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };

        public Dictionary<string, string> tb_bck_users = new Dictionary<string, string> {
            { "id", "id_bck_users" },
            { "user_id", "user_id" },
            { "eneable", "eneable" },
            { "Names", "Names" },
            { "cardNo", "cardNo"},
            { "password", "password" },
            { "fingerIndex", "fingerIndex" },
            { "flag", "flag" },
            { "fp", "fp" },
            { "privilege", "privilege"},
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };

        public Dictionary<string, string> tb_bck_att = new Dictionary<string, string> {
            { "id", "id_bck_att" },
            { "user_id", "user_id" },
            { "date", "date_verify" },
            { "type", "type_verify" },
            { "status", "status_verify" },
            { "code", "code_verify" },
            { "row_added","row_add" },
            { "row_updated","row_update"}
        };
    }
}
