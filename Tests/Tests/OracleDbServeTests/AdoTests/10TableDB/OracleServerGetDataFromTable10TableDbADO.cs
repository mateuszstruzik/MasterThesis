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

namespace Tests.Tests.OracleDbServeTests.AdoTests._10TableDB
{
    public class OracleServerGetDataFromTable10TableDbADO
    {
        public OracleDbServerRpositoryAdo oracleDbServerRpositoryAdo;

        public OracleServerGetDataFromTable10TableDbADO()
        {
            oracleDbServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings["OracleDbServer10Table"].ConnectionString);
        }
        public ModelFor10TablesDBSQLServer GetDataTableByTable()
        {
            ModelFor10TablesDBSQLServer GetFor10TablesDBSQLServer = new ModelFor10TablesDBSQLServer();

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

            return GetFor10TablesDBSQLServer;
        }
    }
}
