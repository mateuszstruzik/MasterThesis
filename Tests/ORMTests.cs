using DataExtract.Models.TableModels;
using DataExtract.Queries;
using DataExtract.Repository.SQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tests
{
    public class ORMTests
    {
        private SqlServerRpositoryAdo sql = new SqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings["SqlServer10Table"].ConnectionString);

        public void Test()
        {
            //sql.GetWholeDataFromTable<Table10ColumnsModel>(SqlServerQueries.SelectFromTable1);
            sql.GetDataFromDb<Table_2>(SqQueries.SelectFromTable2);
        }
    }
}
