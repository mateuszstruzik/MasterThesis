using DataExtract.Repository.OracleDbServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.OracleDbServeTests.NHibernate.OracleHelperForTest
{
    public class OracleUpdateTestHelperNHIBERNATE
    {
        private int numberOfRecords = 10;

        public void UpdateTable<T>(string connectionstring) where T : class, new()
        {
            OracleDbServerRepositoryNHibernate sqlServerRpositoryNh = new OracleDbServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryNh.UpdateTable<T>(i, "UPDATENHIBERNATE");
        }
    }
}
