using DataExtract.Models.ModelsForTests;
using DataExtract.Models.TableModels;
using DataExtract.Queries;
using DataExtract.Repository.PostgreSQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.PostgreSQL.AdoTests._10TableDB
{
    public class PostgreSQLServerGetDataFromTable10TableDbADO
    {
        public PostgreSqlServerRpositoryAdo PostgreSqlServerRpositoryAdo;

        public PostgreSQLServerGetDataFromTable10TableDbADO()
        {
            PostgreSqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings["PostgreSQLServer10Table"].ConnectionString);
        }

        public ModelFor10TablesDBSQLServer GetDataTableByTable()
        {
            ModelFor10TablesDBSQLServer GetFor10TablesDBSQLServer = new ModelFor10TablesDBSQLServer();

            GetFor10TablesDBSQLServer.table1 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_1>(SqQueries.SelectFromTable1);
            GetFor10TablesDBSQLServer.table2 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_2>(SqQueries.SelectFromTable2);
            GetFor10TablesDBSQLServer.table3 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_3>(SqQueries.SelectFromTable3);
            GetFor10TablesDBSQLServer.table4 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_4>(SqQueries.SelectFromTable4);
            GetFor10TablesDBSQLServer.table5 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_5>(SqQueries.SelectFromTable5);
            GetFor10TablesDBSQLServer.table6 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_6>(SqQueries.SelectFromTable6);
            GetFor10TablesDBSQLServer.table7 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_7>(SqQueries.SelectFromTable7);
            GetFor10TablesDBSQLServer.table8 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_8>(SqQueries.SelectFromTable8);
            GetFor10TablesDBSQLServer.table9 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_9>(SqQueries.SelectFromTable9);
            GetFor10TablesDBSQLServer.table10 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_10>(SqQueries.SelectFromTable10);

            return GetFor10TablesDBSQLServer;
        }
    }
}
