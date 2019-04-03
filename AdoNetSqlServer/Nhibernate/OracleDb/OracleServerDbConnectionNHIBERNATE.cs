using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetSqlServer.Nhibernate.OracleDb
{
    public class OracleServerDbConnectionNHIBERNATE
    {
        string ConnectionString;

        public OracleServerDbConnectionNHIBERNATE(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public ISessionFactory SetNHibernateOracleServerConnection<T>()
        {
            //var cfg = new Fluently.Configure();

            //cfg.DataBaseIntegration(x => { x.ConnectionString = this.ConnectionString; x.Driver<SqlClientDriver>(); x.Dialect<MsSql2012Dialect>(); });

            var sefact = Fluently.Configure().Database(OracleClientConfiguration.Oracle10.ConnectionString(this.ConnectionString)).Mappings(m => m.FluentMappings.AddFromAssemblyOf<T>())
                .CurrentSessionContext("web")
                .ExposeConfiguration(c =>
                     c.SetProperty("command_timeout", "6000")
                )
                .BuildSessionFactory();
            return sefact;
        }
    }
}
