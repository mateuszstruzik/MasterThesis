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

namespace Tests.Tests.PostgreSQL.AdoTests._20TableDB
{
    public class PostgreSQLServerGetDataFromTable20TableDbADO
    {
        public PostgreSqlServerRpositoryAdo PostgreSqlServerRpositoryAdo;

        public PostgreSQLServerGetDataFromTable20TableDbADO()
        {
            PostgreSqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings["PostgreSQLServer20Table"].ConnectionString);
        }

        public ModelFor20TablesDB GetDataTableByTable()
        {
            ModelFor20TablesDB GetFor10TablesDBSQLServer = new ModelFor20TablesDB();

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
            GetFor10TablesDBSQLServer.table11 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_11>(SqQueries.SelectFromTable11);
            GetFor10TablesDBSQLServer.table12 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_12>(SqQueries.SelectFromTable12);
            GetFor10TablesDBSQLServer.table13 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_13>(SqQueries.SelectFromTable13);
            GetFor10TablesDBSQLServer.table14 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_14>(SqQueries.SelectFromTable14);
            GetFor10TablesDBSQLServer.table15 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_15>(SqQueries.SelectFromTable15);
            GetFor10TablesDBSQLServer.table16 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_16>(SqQueries.SelectFromTable16);
            GetFor10TablesDBSQLServer.table17 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_17>(SqQueries.SelectFromTable17);
            GetFor10TablesDBSQLServer.table18 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_18>(SqQueries.SelectFromTable18);
            GetFor10TablesDBSQLServer.table19 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_19>(SqQueries.SelectFromTable19);
            GetFor10TablesDBSQLServer.table20 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_20>(SqQueries.SelectFromTable20);

            return GetFor10TablesDBSQLServer;
        }
    }
}
