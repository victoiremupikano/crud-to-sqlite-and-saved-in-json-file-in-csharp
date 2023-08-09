using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using sqliteDbToJsonFile.Properties;

namespace sqliteDbToJsonFile.Apps
{
    class integratedDB
    {
        public Dictionary<string, string> callback;

        /// <summary>
        /// conexion a la db
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="sqlParams"></param>
        /// <returns></returns>

        //path of data base
        string path = "integreted.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\integreted.db"; //database creat debug folder

        public static SQLiteDataReader dr;

        //create database and table
        public void create_db()
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "CREATE TABLE `individus`(`matricule` TEXT NOT NULL UNIQUE,`nom` TEXT,`postnom` TEXT,`datenais` TEXT,`lieunais` TEXT,`genre` TEXT,`adresse` TEXT,`numcarte` TEXT,`origine` TEXT,PRIMARY KEY(`matricule`));";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
                Settings.Default.ip = path;

                //enregistrement 
                Settings.Default.Save();
                msg.getInfo("Successfull, l'application va rédemarrer");
                Application.Restart();
            }
            else
            {
                msg.getAttention("Database cannot create");
                return;
            }
        }
    }
}
