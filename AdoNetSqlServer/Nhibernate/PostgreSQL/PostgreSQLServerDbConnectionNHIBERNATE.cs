using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetSqlServer.Nhibernate.PostgreSQL
{
    public class PostgreSQLServerDbConnectionNHIBERNATE
    {
        string ConnectionString;

        public PostgreSQLServerDbConnectionNHIBERNATE(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public ISessionFactory SetNHibernateOracleServerConnection<T>()
        {
            var sefact = Fluently.Configure().Database(PostgreSQLConfiguration.PostgreSQL82.ConnectionString(this.ConnectionString)).Mappings(m => m.FluentMappings.AddFromAssemblyOf<T>())
                .CurrentSessionContext("web")
                .BuildSessionFactory();
            return sefact;
        }
    }
}
