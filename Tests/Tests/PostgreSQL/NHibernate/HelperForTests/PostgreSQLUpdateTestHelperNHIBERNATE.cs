using DataExtract.Repository.PostgreSQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.PostgreSQL.NHibernate.HelperForTests
{
    public class PostgreSQLUpdateTestHelperNHIBERNATE
    {
        private int numberOfRecords = 5;

        public void UpdateTable<T>(string connectionstring) where T : class, new()
        {
            PostgreSQLServerRepositoryNHibernate sqlServerRpositoryNh = new PostgreSQLServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryNh.UpdateTable<T>(i, "UPDATENHIBERNATE");
        }
    }
}
