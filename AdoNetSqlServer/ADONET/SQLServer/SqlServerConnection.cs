using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetSqlServer.SQLServer
{
    public class SqlServerConnection
    {
        private SqlConnection sqlConnection = null;

        public SqlServerConnection(string ConnectionString)
        {
            sqlConnection = new SqlConnection(ConnectionString);
        }

        public SqlDataReader ExecuteSqlQuery(string query)
        {
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.CommandTimeout = 6000;
                sqlConnection.Open();

                return command.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Reading from Data Base failed :" + ex);
                return null;
            }
        }

        public void ExecuteSqlUpdate(string query, string updateValue, string columnNumber)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                //SqlTransaction transaction;
                //transaction = sqlConnection.BeginTransaction("UpdateTransaction");
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Parameters.Add(new SqlParameter("@Update", updateValue));
                command.Parameters.Add(new SqlParameter("@ColumnNumber", columnNumber));
                command.CommandTimeout = 6000;
                //command.Transaction = transaction;
                sqlConnection.Open();

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
                SqlCommand command = new SqlCommand();
                //SqlTransaction transaction;
                //transaction = sqlConnection.BeginTransaction("UpdateTransaction");
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Parameters.Add(new SqlParameter("@ColumnNumber", columnNumber));
                command.CommandTimeout = 6000;
                //command.Transaction = transaction;
                sqlConnection.Open();

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
            int lineStoppped = 100;
            int count = 0;
            try
            {
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    foreach (string line in query)
                    {
                        if (count < lineStoppped)
                        {
                            cmd.CommandText = line;
                            cmd.CommandType = CommandType.Text;

                            cmd.ExecuteNonQuery();
                            count++;
                        }
                        else
                        {
                            break;
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
            sqlConnection.Close();
        }

        public void DisposeConnection()
        {
            sqlConnection.Dispose();
        }

    }
}
