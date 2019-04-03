using DataExtract.Models.ModelsForTests;
using DataExtract.Models.TableModels;
using DataExtract.Queries;
using DataExtract.Repository.OracleDbServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.OracleDbServeTests.AdoTests._20TableDB
{
    public class OracleServerGetDataFromTable20TableDbADO
    {
        public OracleDbServerRpositoryAdo oracleDbServerRpositoryAdo;

        public OracleServerGetDataFromTable20TableDbADO()
        {
            oracleDbServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings["OracleDbServer20Table"].ConnectionString);
        }

        public ModelFor20TablesDB GetDataTableByTable()
        {
            ModelFor20TablesDB GetFor10TablesDBSQLServer = new ModelFor20TablesDB();

            GetFor10TablesDBSQLServer.table1 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_1>(SqQueries.SelectFromTable1);
            GetFor10TablesDBSQLServer.table2 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_2>(SqQueries.SelectFromTable2);
            GetFor10TablesDBSQLServer.table3 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_3>(SqQueries.SelectFromTable3);
            GetFor10TablesDBSQLServer.table4 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_4>(SqQueries.SelectFromTable4);
            GetFor10TablesDBSQLServer.table5 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_5>(SqQueries.SelectFromTable5);
            GetFor10TablesDBSQLServer.table6 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_6>(SqQueries.SelectFromTable6);
            GetFor10TablesDBSQLServer.table7 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_7>(SqQueries.SelectFromTable7);
            GetFor10TablesDBSQLServer.table8 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_8>(SqQueries.SelectFromTable8);
            GetFor10TablesDBSQLServer.table9 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_9>(SqQueries.SelectFromTable9);
            GetFor10TablesDBSQLServer.table10 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_10>(SqQueries.SelectFromTable10);
            GetFor10TablesDBSQLServer.table11 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_11>(SqQueries.SelectFromTable11);
            GetFor10TablesDBSQLServer.table12 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_12>(SqQueries.SelectFromTable12);
            GetFor10TablesDBSQLServer.table13 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_13>(SqQueries.SelectFromTable13);
            GetFor10TablesDBSQLServer.table14 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_14>(SqQueries.SelectFromTable14);
            GetFor10TablesDBSQLServer.table15 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_15>(SqQueries.SelectFromTable15);
            GetFor10TablesDBSQLServer.table16 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_16>(SqQueries.SelectFromTable16);
            GetFor10TablesDBSQLServer.table17 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_17>(SqQueries.SelectFromTable17);
            GetFor10TablesDBSQLServer.table18 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_18>(SqQueries.SelectFromTable18);
            GetFor10TablesDBSQLServer.table19 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_19>(SqQueries.SelectFromTable19);
            GetFor10TablesDBSQLServer.table20 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_20>(SqQueries.SelectFromTable20);

            return GetFor10TablesDBSQLServer;
        }
    }
}
