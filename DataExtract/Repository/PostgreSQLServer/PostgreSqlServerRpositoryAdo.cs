using AdoNetSqlServer.ADONET.postgreSQL;
using DataExtract.Models.TableModels;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Repository.PostgreSQLServer
{
    public class PostgreSqlServerRpositoryAdo
    {
        private PostgresSQLServerConnection SqlServerConnection;

        public PostgreSqlServerRpositoryAdo(string connection)
        {
            SqlServerConnection = new PostgresSQLServerConnection(connection);
        }


        #region GetAllFromTable
        public List<T> GetDataFromDb<T>(string query) where T : class, IModels
        {
            NpgsqlDataReader reader = SqlServerConnection.ExecuteSqlQuery(query);
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

        public void UpdateTable(string query, string updateValue, int columnNumber)
        {
            try
            {
                SqlServerConnection.ExecuteSqlUpdate(query, updateValue, columnNumber);
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
        #endregion
    }
}
