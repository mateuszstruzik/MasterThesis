using DataExtract.Models.ModelsForTests;
using DataExtract.Models.TableModels;
using DataExtract.Queries;
using DataExtract.Repository.SQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.SqlServerTests.ADOTESTS._10TableDB
{
    public class SqlServerGetDataFromTable10TableDbADO
    {
        public SqlServerRpositoryAdo sqlServerRpositoryAdo;

        public SqlServerGetDataFromTable10TableDbADO()
        {
            sqlServerRpositoryAdo = new SqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings["SqlServer10Table"].ConnectionString);
        }
        public ModelFor10TablesDBSQLServer GetDataTableByTable()
        {
            ModelFor10TablesDBSQLServer GetFor10TablesDBSQLServer = new ModelFor10TablesDBSQLServer();

            GetFor10TablesDBSQLServer.table1 = sqlServerRpositoryAdo.GetDataFromDb<Table_1>(SqQueries.SelectFromTable1);
            GetFor10TablesDBSQLServer.table2 = sqlServerRpositoryAdo.GetDataFromDb<Table_2>(SqQueries.SelectFromTable2);
            GetFor10TablesDBSQLServer.table3 = sqlServerRpositoryAdo.GetDataFromDb<Table_3>(SqQueries.SelectFromTable3);
            GetFor10TablesDBSQLServer.table4 = sqlServerRpositoryAdo.GetDataFromDb<Table_4>(SqQueries.SelectFromTable4);
            GetFor10TablesDBSQLServer.table5 = sqlServerRpositoryAdo.GetDataFromDb<Table_5>(SqQueries.SelectFromTable5);
            GetFor10TablesDBSQLServer.table6 = sqlServerRpositoryAdo.GetDataFromDb<Table_6>(SqQueries.SelectFromTable6);
            GetFor10TablesDBSQLServer.table7 = sqlServerRpositoryAdo.GetDataFromDb<Table_7>(SqQueries.SelectFromTable7);
            GetFor10TablesDBSQLServer.table8 = sqlServerRpositoryAdo.GetDataFromDb<Table_8>(SqQueries.SelectFromTable8);
            GetFor10TablesDBSQLServer.table9 = sqlServerRpositoryAdo.GetDataFromDb<Table_9>(SqQueries.SelectFromTable9);
            GetFor10TablesDBSQLServer.table10 = sqlServerRpositoryAdo.GetDataFromDb<Table_10>(SqQueries.SelectFromTable10);

            sqlServerRpositoryAdo.ConnectionDispose();

            return GetFor10TablesDBSQLServer;
        }
    }
}
