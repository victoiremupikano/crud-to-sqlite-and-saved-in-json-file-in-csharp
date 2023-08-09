using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqliteDbToJsonFile.Models
{
    class MIndividus
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
                            schema.table["tb_individus"],
                                new SQLiteParameter($"@{schema.tb_individus["id"]}", args["id"]),
                                new SQLiteParameter($"@{schema.tb_individus["nom"]}", args["nom"]),
                                new SQLiteParameter($"@{schema.tb_individus["postnom"]}", args["postnom"]),
                                new SQLiteParameter($"@{schema.tb_individus["dteNais"]}", args["dteNais"]),
                                new SQLiteParameter($"@{schema.tb_individus["lieuNais"]}", args["lieuNais"]),
                                new SQLiteParameter($"@{schema.tb_individus["genre"]}", args["genre"]),
                                new SQLiteParameter($"@{schema.tb_individus["adresse"]}", args["adresse"]),
                                new SQLiteParameter($"@{schema.tb_individus["numCarte"]}", args["numCarte"]),
                                new SQLiteParameter($"@{schema.tb_individus["origine"]}", args["origine"])
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
        public async void update(Dictionary<string, string> args)
        {
            try
            {
                if (await Apps.Query.Open())
                {
                    Apps.Schema schema = new Apps.Schema();

                    if (await Apps.Query.updatePrepared(
                            schema.table["tb_individus"],
                                new SQLiteParameter($"@{schema.tb_individus["id"]}", args["id"]),
                                new SQLiteParameter($"@{schema.tb_individus["nom"]}", args["nom"]),
                                new SQLiteParameter($"@{schema.tb_individus["postnom"]}", args["postnom"]),
                                new SQLiteParameter($"@{schema.tb_individus["dteNais"]}", args["dteNais"]),
                                new SQLiteParameter($"@{schema.tb_individus["lieuNais"]}", args["lieuNais"]),
                                new SQLiteParameter($"@{schema.tb_individus["genre"]}", args["genre"]),
                                new SQLiteParameter($"@{schema.tb_individus["adresse"]}", args["adresse"]),
                                new SQLiteParameter($"@{schema.tb_individus["numCarte"]}", args["numCarte"]),
                                new SQLiteParameter($"@{schema.tb_individus["origine"]}", args["origine"])
                            ))
                    {
                        callback = new Dictionary<string, string> {
                            { "type", "success" }, { "message", "Information modifier" }
                        };
                    }
                    else
                    {
                        callback = new Dictionary<string, string> {
                            { "type", "failure" }, { "message", "Modification echouer" }
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
                        { "type", "failure" }, { "message", "Modification echouer " + ex.Message}
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
                            schema.table["tb_individus"],
                                new SQLiteParameter($"@{schema.tb_individus["id"]}", args["id"])
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
        public async void get()
        {
            try
            {
                if (await Apps.Query.Open())
                {
                    Apps.Schema schema = new Apps.Schema();
                    Apps.Query.getData($"select * from {schema.table["tb_individus"]} order by {schema.tb_individus["id"]} DESC;");
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
                        { "type", "failure" }, { "message", "Chargement echouer " + ex.ToString()}
                    };
            }
        }
    }
}
