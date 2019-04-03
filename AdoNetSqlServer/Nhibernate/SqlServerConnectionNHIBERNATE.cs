using NHibernate.Cfg;
using NHibernate.Driver;
using NHibernate.Dialect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace AdoNetSqlServer.Nhibernate
{
    public class SqlServerConnectionNHIBERNATE
    {
        string ConnectionString;

        public SqlServerConnectionNHIBERNATE(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public ISessionFactory SetNHibernateSqlServerConnection<T>()
        {
            //var cfg = new Fluently.Configure();

            //cfg.DataBaseIntegration(x => { x.ConnectionString = this.ConnectionString; x.Driver<SqlClientDriver>(); x.Dialect<MsSql2012Dialect>(); });

            var sefact = Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString(this.ConnectionString)).Mappings(m => m.FluentMappings.AddFromAssemblyOf<T>())
                .CurrentSessionContext("web")
               .ExposeConfiguration(c =>
             c.SetProperty("command_timeout", "6000")
                )
                .BuildSessionFactory();
            return sefact;
        }

        public ISessionFactory SetNHibernateSqlServerConnection2()
        {
            //var cfg = new Fluently.Configure();

            //cfg.DataBaseIntegration(x => { x.ConnectionString = this.ConnectionString; x.Driver<SqlClientDriver>(); x.Dialect<MsSql2012Dialect>(); });

            var sefact = Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString(this.ConnectionString))
                .CurrentSessionContext("web")
               .ExposeConfiguration(c =>
             c.SetProperty("command_timeout", "6000")
                )
                .BuildSessionFactory();
            return sefact;
        }
    }
}
