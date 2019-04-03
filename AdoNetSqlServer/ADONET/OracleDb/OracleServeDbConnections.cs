using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetSqlServer.ADONET.OracleDb
{
    public class OracleServeDbConnections
    {
        private OracleConnection oracleConnection; 
        private string connectionstring;
        public OracleServeDbConnections(string connectionString)
        {
            oracleConnection = new OracleConnection(connectionString);
            connectionstring = connectionString; 
        }

        public OracleDataReader ExecuteSqlQuery(string query)
        {
            try
            {
                //oracleConnection = new OracleConnection(connectionstring);
                OracleCommand command = new OracleCommand();

                command.Connection = oracleConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = query;

                oracleConnection.Open();

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
                OracleCommand command = new OracleCommand();
                //SqlTransaction transaction;
                //transaction = sqlConnection.BeginTransaction("UpdateTransaction");
                command.Connection = oracleConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("UpdValue", updateValue));
                command.Parameters.Add(new OracleParameter("ColumnNumber", columnNumber));
                command.CommandTimeout = 6000;
                //command.Transaction = transaction;
                oracleConnection.Open();

                command.ExecuteNonQuery();
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
                OracleCommand command = new OracleCommand();
                //SqlTransaction transaction;
                //transaction = sqlConnection.BeginTransaction("UpdateTransaction");
                command.Connection = oracleConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Parameters.Add(new OracleParameter("ColumnNumber", columnNumber));
                command.CommandTimeout = 6000;
                //command.Transaction = transaction;
                oracleConnection.Open();

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
                using (OracleCommand cmd = oracleConnection.CreateCommand())
                {
                    OracleTransaction transaction;
                    
                    cmd.Connection = oracleConnection;
                    oracleConnection.Open();
                    foreach (string line in query)
                    {

                        if (count < lineStoppped)
                        {
                            transaction = oracleConnection.BeginTransaction();
                            cmd.Transaction = transaction;
                            cmd.CommandText = line;
                            cmd.CommandType = CommandType.Text;

                            cmd.ExecuteNonQuery();
                            transaction.Commit();
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
            oracleConnection.Close();
            //oracleConnection.Dispose();
        }

        public void DisposeConnection()
        {
            oracleConnection.Dispose();
        }
    }
}
