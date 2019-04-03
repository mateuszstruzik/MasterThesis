using AdoNetSqlServer.SQLServer;
using DataExtract.Models.TableModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace DataExtract.Repository.SQLServer
{
    public class SqlServerRpositoryAdo
    {
        private SqlServerConnection SqlServerConnection;
        string connection;

        public SqlServerRpositoryAdo(string connection)
        {
            SqlServerConnection = new SqlServerConnection(connection);
        }

        #region GetAllFromTable
        public List<T> GetDataFromDb<T>(string query) where T : class, IModels
        {
            SqlDataReader reader = SqlServerConnection.ExecuteSqlQuery(query);
            int columncount = reader.FieldCount;
            Type mytype = typeof(T);
            PropertyInfo[] propertiesInfo = typeof(T).GetProperties();

            if (mytype.GetProperties().Count() != columncount)
            {
                ArgumentException argumentException = new ArgumentException("Wrong database model, field not equals to table columns");
                Console.WriteLine("SqlServerRpository error : " + argumentException);
                throw argumentException;
            }

            List<T> dataCollection = new List<T>();

            try
            {
                while (reader.Read())
                {
                    IModels model = Activator.CreateInstance(typeof(T)) as T;
                    int id = reader.GetInt32(0);
                    List<string> otherProperty = new List<string>();

                    for (int i = 1; i < columncount; i++)
                    {
                        otherProperty.Add(reader.GetString(i));
                    }
                    model.SetModel(id, otherProperty);
                    dataCollection.Add((T)model);
                }

                return dataCollection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during full single table reading : " + ex);
                return null;
            }
            finally
            {
                SqlServerConnection.CloseConnection();
            }
        }
        #endregion

        #region Update table 
        public void UpdateTable(string query, string updateValue, int columnNumber)
        {
            try
            {
                SqlServerConnection.ExecuteSqlUpdate(query, updateValue, columnNumber.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during update table : " + ex);

            }
            finally
            {
                SqlServerConnection.CloseConnection();
            }
        }
        #endregion

        #region delete from table
        public void DeleteFromTable(string query, int columnNumber)
        {
            try
            {
                SqlServerConnection.ExecuteSqlDelete(query, columnNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during update table : " + ex);

            }
            finally
            {
                SqlServerConnection.CloseConnection();
            }
        }
        #endregion

        #region insert
        public void InsertToTable(string[] query)
        {
            try
            {
                SqlServerConnection.ExecuteSqlInsert(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during update table : " + ex);

            }
            finally
            {
                SqlServerConnection.CloseConnection();
            }
        }
        #endregion
        public void ConnectionDispose()
        {
            SqlServerConnection.DisposeConnection();
        }
    }
}
