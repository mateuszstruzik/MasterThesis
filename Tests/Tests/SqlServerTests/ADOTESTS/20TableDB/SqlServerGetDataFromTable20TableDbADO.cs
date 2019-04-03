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

namespace Tests.Tests.SqlServerTests.ADOTESTS._20TableDB
{
    public class SqlServerGetDataFromTable20TableDbADO
    {
        public SqlServerRpositoryAdo sqlServerRpositoryAdo;

        public SqlServerGetDataFromTable20TableDbADO()
        {
            sqlServerRpositoryAdo = new SqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings["SqlServer20Table"].ConnectionString);
        }

        public ModelFor20TablesDB GetDataTableByTable()
        {
            ModelFor20TablesDB GetFor20TablesDBSQLServer = new ModelFor20TablesDB();

            GetFor20TablesDBSQLServer.table1 = sqlServerRpositoryAdo.GetDataFromDb<Table_1>(SqQueries.SelectFromTable1);
            GetFor20TablesDBSQLServer.table2 = sqlServerRpositoryAdo.GetDataFromDb<Table_2>(SqQueries.SelectFromTable2);
            GetFor20TablesDBSQLServer.table3 = sqlServerRpositoryAdo.GetDataFromDb<Table_3>(SqQueries.SelectFromTable3);
            GetFor20TablesDBSQLServer.table4 = sqlServerRpositoryAdo.GetDataFromDb<Table_4>(SqQueries.SelectFromTable4);
            GetFor20TablesDBSQLServer.table5 = sqlServerRpositoryAdo.GetDataFromDb<Table_5>(SqQueries.SelectFromTable5);
            GetFor20TablesDBSQLServer.table6 = sqlServerRpositoryAdo.GetDataFromDb<Table_6>(SqQueries.SelectFromTable6);
            GetFor20TablesDBSQLServer.table7 = sqlServerRpositoryAdo.GetDataFromDb<Table_7>(SqQueries.SelectFromTable7);
            GetFor20TablesDBSQLServer.table8 = sqlServerRpositoryAdo.GetDataFromDb<Table_8>(SqQueries.SelectFromTable8);
            GetFor20TablesDBSQLServer.table9 = sqlServerRpositoryAdo.GetDataFromDb<Table_9>(SqQueries.SelectFromTable9);
            GetFor20TablesDBSQLServer.table10 = sqlServerRpositoryAdo.GetDataFromDb<Table_10>(SqQueries.SelectFromTable10);
            GetFor20TablesDBSQLServer.table11 = sqlServerRpositoryAdo.GetDataFromDb<Table_11>(SqQueries.SelectFromTable11);
            GetFor20TablesDBSQLServer.table12 = sqlServerRpositoryAdo.GetDataFromDb<Table_12>(SqQueries.SelectFromTable12);
            GetFor20TablesDBSQLServer.table13 = sqlServerRpositoryAdo.GetDataFromDb<Table_13>(SqQueries.SelectFromTable13);
            GetFor20TablesDBSQLServer.table14 = sqlServerRpositoryAdo.GetDataFromDb<Table_14>(SqQueries.SelectFromTable14);
            GetFor20TablesDBSQLServer.table15 = sqlServerRpositoryAdo.GetDataFromDb<Table_15>(SqQueries.SelectFromTable15);
            GetFor20TablesDBSQLServer.table16 = sqlServerRpositoryAdo.GetDataFromDb<Table_16>(SqQueries.SelectFromTable16);
            GetFor20TablesDBSQLServer.table17 = sqlServerRpositoryAdo.GetDataFromDb<Table_17>(SqQueries.SelectFromTable17);
            GetFor20TablesDBSQLServer.table18 = sqlServerRpositoryAdo.GetDataFromDb<Table_18>(SqQueries.SelectFromTable18);
            GetFor20TablesDBSQLServer.table19 = sqlServerRpositoryAdo.GetDataFromDb<Table_19>(SqQueries.SelectFromTable19);
            GetFor20TablesDBSQLServer.table20 = sqlServerRpositoryAdo.GetDataFromDb<Table_20>(SqQueries.SelectFromTable20);

            sqlServerRpositoryAdo.ConnectionDispose();

            return GetFor20TablesDBSQLServer;
        }
    }
}
