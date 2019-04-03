using DataExtract.Models.TableModels;
using DataExtract.Repository.SQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.SqlServerTests.NHibernate.HelperForTests
{
    public class UpdateTestHelperNHIBERNATE
    {
        private int numberOfRecords = 5; 

        public void UpdateTable<T>(string connectionstring) where T: class, new()
        {
            SqlServerRepositoryNHibernate sqlServerRpositoryNh = new SqlServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
            for (int i = 1; i < numberOfRecords + 1; i++)
                sqlServerRpositoryNh.UpdateTable<T>(i, "UPDATENHIBERNATE");
        }
    }
}
