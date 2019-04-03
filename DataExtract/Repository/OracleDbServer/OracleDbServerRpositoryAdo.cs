using AdoNetSqlServer.ADONET.OracleDb;
using DataExtract.Models.TableModels;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Repository.OracleDbServer
{
    public class OracleDbServerRpositoryAdo
    {
        private OracleServeDbConnections oracleServeDbConnections;

        public OracleDbServerRpositoryAdo(string connection)
        {
            oracleServeDbConnections = new OracleServeDbConnections(connection);
        }

        public List<T> GetWholeDataFromTable<T>(string query) where T : class, IModels
        {
            OracleDataReader reader = oracleServeDbConnections.ExecuteSqlQuery(query); 
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
                oracleServeDbConnections.CloseConnection();
            }
        }

        public List<T> GetDataFromDb<T>(string query) where T : class, IModels
        {
            OracleDataReader reader = oracleServeDbConnections.ExecuteSqlQuery(query);
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
                oracleServeDbConnections.CloseConnection();
                oracleServeDbConnections.DisposeConnection();
            }
        }

        public void UpdateTable(string query, string updateValue, int columnNumber)
        {
            try
            {
                oracleServeDbConnections.ExecuteSqlUpdate(query, updateValue, columnNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during update table : " + ex);

            }
            finally
            {
                oracleServeDbConnections.CloseConnection();
            }
        }

        public void DeleteFromTable(string query, int columnNumber)
        {
            try
            {
                oracleServeDbConnections.ExecuteSqlDelete(query, columnNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during update table : " + ex);

            }
            finally
            {
                oracleServeDbConnections.CloseConnection();
            }
        }



        public void InsertToTable(string[] query)
        {
            try
            {
                oracleServeDbConnections.ExecuteSqlInsert(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during update table : " + ex);

            }
            finally
            {
                oracleServeDbConnections.CloseConnection();
            }
        }
    }
}
