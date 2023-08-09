using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omen_management.Models
{
    class MClassment
    {
        public Dictionary<string, string> callback;

        public async void insert(Dictionary<string, string> args)
        {
            try
            {
                if (await Apps.Query.Open())
                {
                    Apps.Schema schema = new Apps.Schema();
                    if (await Apps.Query.insertPrepared(
                            schema.table["tb_hourly_partial_classment"],
                                new SQLiteParameter($"@{schema.tb_hourly_partial_classment["dte"]}", args["dte"]),
                                new SQLiteParameter($"@{schema.tb_hourly_partial_classment["day"]}", args["day"]),
                                new SQLiteParameter($"@{schema.tb_hourly_partial_classment["omen_number"]}", args["omen_number"]),
                                new SQLiteParameter($"@{schema.tb_hourly_partial_classment["status"]}", args["status"]),
                                new SQLiteParameter($"@{schema.tb_hourly_partial_classment["about"]}", args["about"]),
                                new SQLiteParameter($"@{schema.tb_hourly_partial_classment["fk_job"]}", args["fk_job"]),
                                new SQLiteParameter($"@{schema.tb_hourly_partial_classment["fk_member"]}", args["fk_member"]),
                                new SQLiteParameter($"@{schema.tb_hourly_partial_classment["fk_user"]}", args["fk_user"]),
                                new SQLiteParameter($"@{schema.tb_hourly_partial_classment["fk_profile"]}", args["fk_profile"])
                            ))
                    {
                        callback = new Dictionary<string, string> {
                            { "type", "success" }, { "message", "Information enregistrer" }
                        };
                    }
                    else
                    {
                        callback = new Dictionary<string, string> {
                            { "type", "failure" }, { "message", "Enregistrement echouer" }
                        };
                    }
                }
                else
                {
                    callback = new Dictionary<string, string> {
                        { "type", "connection" }, { "message", "Impossible d'acceder à la base de données; vérifier votre connexion" }
                    };
                }
            }
            catch (Exception ex)
            {
                callback = new Dictionary<string, string> {
                        { "type", "failure" }, { "message", "Enregistrement echouer " + ex.Message}
                    };
            }
        }
        public async void delete(Dictionary<string, string> args)
        {
            try
            {
                if (await Apps.Query.Open())
                {
                    Apps.Schema schema = new Apps.Schema();

                    if (await Apps.Query.deletePrepared(
                            schema.table["tb_hourly_partial_classment"],
                                new SQLiteParameter($"@{schema.tb_hourly_partial_classment["id"]}", args["id"])
                           ))
                    {
                        callback = new Dictionary<string, string> {
                            { "type", "success" }, { "message", "Information supprimer" }
                        };
                    }
                    else
                    {
                        callback = new Dictionary<string, string> {
                            { "type", "failure" }, { "message", "Suppression echouer" }
                        };
                    }
                }
                else
                {
                    callback = new Dictionary<string, string> {
                        { "type", "connection" }, { "message", "Impossible d'acceder à la base de données; vérifier votre connexion" }
                    };
                }
            }
            catch (Exception ex)
            {
                callback = new Dictionary<string, string> {
                        { "type", "failure" }, { "message", "Suppression echouer " + ex.Message}
                    };
            }

        }
        public async void getId(string param)
        {
            try
            {
                if (await Apps.Query.Open())
                {
                    Apps.Schema schema = new Apps.Schema();
                    Apps.Query.getData($"select * from { schema.table["tb_hourly_partial_classment"]} where {schema.tb_hourly_partial_classment["pattern"]} = '{param}'");
                    callback = new Dictionary<string, string> {
                        { "type", "success" }, { "message", "Collecte des données sans soucies" }
                    };
                }
                else
                {
                    callback = new Dictionary<string, string> {
                        { "type", "connection" }, { "message", "Impossible d'acceder à la base de données; vérifier votre connexion" }
                    };
                }
            }
            catch (Exception ex)
            {
                callback = new Dictionary<string, string> {
                        { "type", "failure" }, { "message", "Chargement echouer " + ex.Message}
                    };
            }
        }
        public async void get()
        {
            try
            {
                if (await Apps.Query.Open())
                {
                    Apps.Schema schema = new Apps.Schema();
                    Apps.Query.getData($"select hourly_partial_classment.id_hourly_partial_classment, hourly_partial_classment.dte_hourly_partial_classment, hourly_partial_classment.day_hourly_partial_classment, services.names_services, job.names_job, member.names_member, job.id_job, member.id_member, hourly_partial_classment.omen_number, hourly_partial_classment.status, hourly_partial_classment.about_isNormal from hourly_partial_classment inner join job on job.id_job = hourly_partial_classment.fk_job inner join services on services.id_services = job.fk_services inner join member on member.id_member = hourly_partial_classment.fk_member order by hourly_partial_classment.id_hourly_partial_classment DESC;");
                    callback = new Dictionary<string, string> {
                        { "type", "success" }, { "message", "Collecte des données sans soucies" }
                    };
                }
                else
                {
                    callback = new Dictionary<string, string> {
                        { "type", "connection" }, { "message", "Impossible d'acceder à la base de données; vérifier votre connexion" }
                    };
                }
            }
            catch (Exception ex)
            {
                callback = new Dictionary<string, string> {
                        { "type", "failure" }, { "message", "Chargement echouer " + ex.Message}
                    };
            }
        }
        public async void getcurrentByhourlyPartialused(string dte, string fk_job, string fk_member, string status)
        {
            try
            {
                if (await Apps.Query.Open())
                {
                    Apps.Schema schema = new Apps.Schema();
                    Apps.Query.getData($"select ifnull(count(*), 0) as nbrExistsInPartial from hourly_partial_classment where date(hourly_partial_classment.dte_hourly_partial_classment) = '{dte}' and hourly_partial_classment.fk_job = '{fk_job}' and hourly_partial_classment.fk_member = '{fk_member}' and hourly_partial_classment.about_isNormal = '{status}';");
                    callback = new Dictionary<string, string> {
                        { "type", "success" }, { "message", "Collecte des données sans soucies" }
                    };
                }
                else
                {
                    callback = new Dictionary<string, string> {
                        { "type", "connection" }, { "message", "Impossible d'acceder à la base de données; vérifier votre connexion" }
                    };
                }
            }
            catch (Exception ex)
            {
                callback = new Dictionary<string, string> {
                        { "type", "failure" }, { "message", "Chargement echouer " + ex.Message}
                    };
            }
        }
        public async void get_omen_numberByhourlyPartialused(string dte, string fk_job, string fk_member, string status)
        {
            try
            {
                if (await Apps.Query.Open())
                {
                    Apps.Schema schema = new Apps.Schema();
                    Apps.Query.getData($"select hourly_partial_classment.omen_number from hourly_partial_classment where date(hourly_partial_classment.dte_hourly_partial_classment) = '{dte}' and hourly_partial_classment.fk_job = '{fk_job}' and hourly_partial_classment.fk_member = '{fk_member}' and hourly_partial_classment.about_isNormal = '{status}';");
                    callback = new Dictionary<string, string> {
                        { "type", "success" }, { "message", "Collecte des données sans soucies" }
                    };
                }
                else
                {
                    callback = new Dictionary<string, string> {
                        { "type", "connection" }, { "message", "Impossible d'acceder à la base de données; vérifier votre connexion" }
                    };
                }
            }
            catch (Exception ex)
            {
                callback = new Dictionary<string, string> {
                        { "type", "failure" }, { "message", "Chargement echouer " + ex.Message}
                    };
            }
        }
    }
}
