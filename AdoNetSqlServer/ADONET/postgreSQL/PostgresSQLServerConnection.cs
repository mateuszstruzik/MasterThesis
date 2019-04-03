using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetSqlServer.ADONET.postgreSQL
{
    public class PostgresSQLServerConnection
    {
        private NpgsqlConnection NpsqlConnection = null;

        public PostgresSQLServerConnection(string ConnectionString)
        {
            NpsqlConnection = new NpgsqlConnection(ConnectionString);
        }

        public NpgsqlDataReader ExecuteSqlQuery(string query)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();

                command.Connection = NpsqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = query;

                NpsqlConnection.Open();

                return command.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Reading from Data Base failed :" + ex);
                return null;
            }
        }
        public void ExecuteSqlUpdate(string query, string updateValue, int columnNumber)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                //SqlTransaction transaction;
                //transaction = sqlConnection.BeginTransaction("UpdateTransaction");
                command.Connection = NpsqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Parameters.Add(new NpgsqlParameter("UpdValue", NpgsqlTypes.NpgsqlDbType.Varchar));
                command.Parameters.Add(new NpgsqlParameter("ColumnNumber", NpgsqlTypes.NpgsqlDbType.Integer));
                command.Parameters[0].Value = updateValue;
                command.Parameters[1].Value = columnNumber;
                //command.Parameters.Add("Update", updateValue);
                //command.Parameters.Add("@ColumnNumber", columnNumber);
                command.CommandTimeout = 6000;
                //command.Transaction = transaction;
                NpsqlConnection.Open();

                command.ExecuteReader();
                //transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("update for Data Base failed :" + ex);

            }
        }
        public void ExecuteSqlDelete(string query, int columnNumber)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                //SqlTransaction transaction;
                //transaction = sqlConnection.BeginTransaction("UpdateTransaction");
                command.Connection = NpsqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Parameters.Add(new NpgsqlParameter("ColumnNumber", columnNumber));
                command.CommandTimeout = 6000;
                //command.Transaction = transaction;
                NpsqlConnection.Open();

                command.ExecuteReader();
                //transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("update for Data Base failed :" + ex);

            }
        }

        public void ExecuteSqlInsert(string[] query)
        {
            try
            {
                using (NpgsqlCommand cmd = NpsqlConnection.CreateCommand())
                {
                    cmd.Connection = NpsqlConnection;
                    NpsqlConnection.Open();
                    foreach (string line in query)
                    {
                        if (line.Length > 0)
                        {
                            cmd.CommandText = line;
                            cmd.CommandType = CommandType.Text;

                            cmd.ExecuteNonQuery();

                        }
                    }
                    CloseConnection();
                }

                //SqlCommand command = new SqlCommand();


                //command.Connection = sqlConnection;
                //command.CommandType = CommandType.Text;
                //command.CommandText = query;
                //command.CommandTimeout = 6000;

                //command.ExecuteReader();
                //transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("update for Data Base failed :" + ex);

            }
        }
        public void CloseConnection()
        {
            NpsqlConnection.Close();
        }
    }
}
