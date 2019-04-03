using AdoNetSqlServer.Nhibernate.PostgreSQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Repository.PostgreSQLServer
{
    public class PostgreSQLServerRepositoryNHibernate
    {
        PostgreSQLServerDbConnectionNHIBERNATE PostgreSQLServerDbConnectionNHIBERNATE;
        public NHibernate.ISession session;

        public PostgreSQLServerRepositoryNHibernate(string connectionString)
        {
            PostgreSQLServerDbConnectionNHIBERNATE = new PostgreSQLServerDbConnectionNHIBERNATE(connectionString);
        }

        public void InitSessionFactory<T>() where T : class
        {
            var sessionFactory = PostgreSQLServerDbConnectionNHIBERNATE.SetNHibernateOracleServerConnection<T>();
            session = sessionFactory.OpenSession();
        }

        public void SessionClose()
        {
            session.Clear();
            session.Close();
            session.Dispose();
        }

        public List<T> GetAllDataFromTable<T>(string query) where T : class
        {
            List<T> results = new List<T>();

            using (var tx = session.BeginTransaction())
            {
                results = session.CreateSQLQuery(query).AddEntity(typeof(T)).List<T>().ToList();

                tx.Commit();

            }

            return results;
        }

        public List<T> GetJoinFromTableDB<T>(string query) where T : class
        {
            List<T> results = new List<T>();
            InitSessionFactory<T>();
            using (var tx = session.BeginTransaction())
            {
                results = session.CreateSQLQuery(query).AddEntity(typeof(T)).List<T>().ToList();

                tx.Commit();
            }
            return results;
        }

        public void UpdateTable<T>(int recordNumber, string updateValue) where T : class, new()
        {
            PropertyInfo[] propertyInfos;
            InitSessionFactory<T>();
            using (var tx = session.BeginTransaction())
            {

                var table = session.Get<T>(recordNumber);
                Type myType = table.GetType();
                IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());
                for (int i = 1; i < 10; i++)
                {
                    props[i].SetValue(table, updateValue);
                }

                session.Update(table);
                tx.Commit();
            }
            SessionClose();
        }

        public void DeleteFromtable<T>(string query, int columnNumber) where T : class, new()
        {
            InitSessionFactory<T>();
            using (var tx = session.BeginTransaction())
            {
                var update = session.CreateQuery(query).SetParameter("ColumnNumber", columnNumber);

                update.ExecuteUpdate();

                tx.Commit();
            }
            //SessionClose();
        }

        public void ExecuteSqlInsert<T>(string[] query) where T : class, new()
        {
            InitSessionFactory<T>();
            IDbCommand command = session.Connection.CreateCommand();
            try
            {
                //using (var tx = session.BeginTransaction())
                //{

                foreach (string line in query)
                {
                    //var update = session.CreateQuery(line);

                    command.CommandText = line;
                    command.ExecuteNonQuery();

                    //tx.Commit();

                }
                //SessionClose();
                //}

            }
            catch (Exception ex)
            {
                Console.WriteLine("update for Data Base failed :" + ex);

            }
        }

    }
}
