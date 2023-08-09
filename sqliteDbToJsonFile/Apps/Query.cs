using omen_management.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omen_management.Apps
{
    class Query
    {
        /// <summary>
        /// conexion a la db
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="sqlParams"></param>
        /// <returns></returns>
        // var portant la connexion
        public static SQLiteConnection conn;

        //les variables de connexion pour le test de connection avant validation
        public static string ip_ { set; get; }

        //creation du constructeur avec les parametres de connection à la base de données
        public static void connection()
        {
            string ip = Settings.Default.ip;

            string connection_string = @"Data Source=" + ip + "";

            conn = new SQLiteConnection(connection_string);
        }
        public static void try_connexion()
        {
            try
            {
                SQLiteConnection conn_ = new SQLiteConnection();

                string connection_string = @"Data Source=" + ip_ + "";

                conn_ = new SQLiteConnection(connection_string);

                if (conn_.State == ConnectionState.Closed)
                {
                    conn_.Open();
                    Services.MsgFRM msg = new Services.MsgFRM();
                    msg.getInfo("Connexion établie");
                }
                else
                {
                    conn_.Close();
                    Services.MsgFRM msg = new Services.MsgFRM();
                    msg.getError("Connexion échouer");
                }
            }
            catch (Exception)
            {
                Services.MsgFRM msg = new Services.MsgFRM();
                msg.getError("Connexion échouer");
            }
        }
        public static async Task<bool> Open()
        {
            connection();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            var openAsync = conn?.OpenAsync();
            if (openAsync == null) return false;
            await openAsync;
            return true;
        }
        public static async Task<bool> Close()
        {
            //var closeAsync = conn?.CloseAsync();
            //if (closeAsync == null) return false;
            //await closeAsync;
            return true;
        }

        /// <summary>
        /// Insertion, modification, ... dans la db
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="sqlParams"></param>
        /// <returns></returns>
        public async static Task<bool> insertPrepared(string tableName, params SQLiteParameter[] sqlParams)
        {
            //produce comma delimited list of param names with leading @ stripped eg. Param1, Param2, Param3
            string columnNameStr = string.Join(", ", sqlParams.Select(sqlParam => sqlParam.ParameterName.Substring(1)));

            //produce comma delimited list of param eg. @Param1, @Param2, @Param3
            string valueParamStr = string.Join(", ", sqlParams.Select(sqlParam => sqlParam.ParameterName));

            string insertSql = string.Format(
                "INSERT INTO {0} ({1}) VALUES ({2})",
                tableName,
                columnNameStr,
                valueParamStr
            );
            bool result = false;
            using (var command = new SQLiteCommand(insertSql, conn))
            {
                command.Parameters.AddRange(sqlParams);
                await command.ExecuteScalarAsync();
                result = true;
            }
            return result;
        }
        public static async Task<bool> updatePrepared(string tableName, SQLiteParameter keyParam, params SQLiteParameter[] sqlParams)
        {
            //Param1 = @Param1, Param2 = @Param2, @Param3 = @Param3, etc.
            string updateParamStr = string.Join(
                ", ",
                sqlParams.Select(sqlParam => string.Format("{0} = {1}", sqlParam.ParameterName.Substring(1), sqlParam.ParameterName))
                );

            //param = @param
            string keyMatchStr = string.Format("{0} = {1}",
                keyParam.ParameterName.Substring(1),
                keyParam.ParameterName);
            //sql query

            string updateSql = string.Format("UPDATE {0} SET {1} WHERE {2}",
                tableName,
                updateParamStr,
                keyMatchStr);
            bool result = false;
            using (var command = new SQLiteCommand(updateSql, conn))
            {
                command.Parameters.Add(keyParam);
                command.Parameters.AddRange(sqlParams);
                await command.ExecuteScalarAsync();
                result = true;
            }
            return result;
        }
        public static async Task<bool> deletePrepared(string tableName, params SQLiteParameter[] sqlParams)
        {
            //produce comma delimited list of param names with leading @ stripped eg. Param1, Param2, Param3
            string columnNameStr = string.Join(", ", sqlParams.Select(sqlParam => sqlParam.ParameterName.Substring(1)));

            //produce comma delimited list of param eg. @Param1, @Param2, @Param3
            string valueParamStr = string.Join(", ", sqlParams.Select(sqlParam => sqlParam.ParameterName));

            string deleteSql = string.Format(
                "DELETE FROM {0} WHERE {1} = {2}",
                tableName,
                columnNameStr,
                valueParamStr
            );
            bool result = false;
            using (var command = new SQLiteCommand(deleteSql, conn))
            {
                command.Parameters.AddRange(sqlParams);
                await command.ExecuteScalarAsync();
                result = true;
            }
            return result;
        }

        public static async Task<Dictionary<string, object>> FetchArrayDict(string query)
        {
            var dictionary = new Dictionary<string, object>();
            using (var command = new SQLiteCommand(query, conn))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        for (var i = 0; i < reader.FieldCount; i++)
                        {
                            var key = reader.GetName(i);
                            var value = reader[i];
                            dictionary.Add(key, value);
                        }
                    }
                }
            }
            return dictionary;
        }
        public static async Task<List<object>> FetchArrayList(string query)
        {
            var list = new List<object>();
            using (var command = new SQLiteCommand(query, conn))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        for (var i = 0; i < reader.FieldCount; i++)
                        {
                            var value = reader[i];
                            list.Add(value);
                        }
                    }
                }
            }
            return list;
        }
        public static async Task<int> FetchOnValue(string query)
        {
            int id = 0;
            using (var command = new SQLiteCommand(query, conn))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.Read())
                    {
                        id = int.Parse(reader[0].ToString());
                    }
                }
            }
            return id;
        }

        public static SQLiteDataReader DR;
        public static void getData(string query)
        {
            var command = new SQLiteCommand(query, conn);
            DR = command.ExecuteReader();
        }

        public static void getExecute(string query)
        {
            var command = new SQLiteCommand(query, conn);
            command.ExecuteNonQuery();
        }
        public static DataTable DT;
        public static void getDataTable(string query)
        {
            DT = new DataTable();
            DT.Clear();
            SQLiteDataAdapter sda = new SQLiteDataAdapter(query, conn);
            sda.Fill(DT);
        }
    }
}
