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

namespace Tests.Tests.SqlServerTests.ADOTESTS._40TableDB
{
    public class SqlServerGetDataFromTable40TableDbADO
    {
        public SqlServerRpositoryAdo sqlServerRpositoryAdo;

        public SqlServerGetDataFromTable40TableDbADO()
        {
            sqlServerRpositoryAdo = new SqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings["SqlServer40Table"].ConnectionString);
        }

        public ModelFor40TablesDB GetDataTableByTable()
        {
            ModelFor40TablesDB GetFor40TablesDBSQLServer = new ModelFor40TablesDB();

            GetFor40TablesDBSQLServer.table1 = sqlServerRpositoryAdo.GetDataFromDb<Table_1>(SqQueries.SelectFromTable1);
            GetFor40TablesDBSQLServer.table2 = sqlServerRpositoryAdo.GetDataFromDb<Table_2>(SqQueries.SelectFromTable2);
            GetFor40TablesDBSQLServer.table3 = sqlServerRpositoryAdo.GetDataFromDb<Table_3>(SqQueries.SelectFromTable3);
            GetFor40TablesDBSQLServer.table4 = sqlServerRpositoryAdo.GetDataFromDb<Table_4>(SqQueries.SelectFromTable4);
            GetFor40TablesDBSQLServer.table5 = sqlServerRpositoryAdo.GetDataFromDb<Table_5>(SqQueries.SelectFromTable5);
            GetFor40TablesDBSQLServer.table6 = sqlServerRpositoryAdo.GetDataFromDb<Table_6>(SqQueries.SelectFromTable6);
            GetFor40TablesDBSQLServer.table7 = sqlServerRpositoryAdo.GetDataFromDb<Table_7>(SqQueries.SelectFromTable7);
            GetFor40TablesDBSQLServer.table8 = sqlServerRpositoryAdo.GetDataFromDb<Table_8>(SqQueries.SelectFromTable8);
            GetFor40TablesDBSQLServer.table9 = sqlServerRpositoryAdo.GetDataFromDb<Table_9>(SqQueries.SelectFromTable9);
            GetFor40TablesDBSQLServer.table10 = sqlServerRpositoryAdo.GetDataFromDb<Table_10>(SqQueries.SelectFromTable10);
            GetFor40TablesDBSQLServer.table11 = sqlServerRpositoryAdo.GetDataFromDb<Table_11>(SqQueries.SelectFromTable11);
            GetFor40TablesDBSQLServer.table12 = sqlServerRpositoryAdo.GetDataFromDb<Table_12>(SqQueries.SelectFromTable12);
            GetFor40TablesDBSQLServer.table13 = sqlServerRpositoryAdo.GetDataFromDb<Table_13>(SqQueries.SelectFromTable13);
            GetFor40TablesDBSQLServer.table14 = sqlServerRpositoryAdo.GetDataFromDb<Table_14>(SqQueries.SelectFromTable14);
            GetFor40TablesDBSQLServer.table15 = sqlServerRpositoryAdo.GetDataFromDb<Table_15>(SqQueries.SelectFromTable15);
            GetFor40TablesDBSQLServer.table16 = sqlServerRpositoryAdo.GetDataFromDb<Table_16>(SqQueries.SelectFromTable16);
            GetFor40TablesDBSQLServer.table17 = sqlServerRpositoryAdo.GetDataFromDb<Table_17>(SqQueries.SelectFromTable17);
            GetFor40TablesDBSQLServer.table18 = sqlServerRpositoryAdo.GetDataFromDb<Table_18>(SqQueries.SelectFromTable18);
            GetFor40TablesDBSQLServer.table19 = sqlServerRpositoryAdo.GetDataFromDb<Table_19>(SqQueries.SelectFromTable19);
            GetFor40TablesDBSQLServer.table20 = sqlServerRpositoryAdo.GetDataFromDb<Table_20>(SqQueries.SelectFromTable20);
            GetFor40TablesDBSQLServer.table21 = sqlServerRpositoryAdo.GetDataFromDb<Table_21>(SqQueries.SelectFromTable21);
            GetFor40TablesDBSQLServer.table22 = sqlServerRpositoryAdo.GetDataFromDb<Table_22>(SqQueries.SelectFromTable22);
            GetFor40TablesDBSQLServer.table23 = sqlServerRpositoryAdo.GetDataFromDb<Table_23>(SqQueries.SelectFromTable23);
            GetFor40TablesDBSQLServer.table24 = sqlServerRpositoryAdo.GetDataFromDb<Table_24>(SqQueries.SelectFromTable24);
            GetFor40TablesDBSQLServer.table25 = sqlServerRpositoryAdo.GetDataFromDb<Table_25>(SqQueries.SelectFromTable25);
            GetFor40TablesDBSQLServer.table26 = sqlServerRpositoryAdo.GetDataFromDb<Table_26>(SqQueries.SelectFromTable26);
            GetFor40TablesDBSQLServer.table27 = sqlServerRpositoryAdo.GetDataFromDb<Table_27>(SqQueries.SelectFromTable27);
            GetFor40TablesDBSQLServer.table28 = sqlServerRpositoryAdo.GetDataFromDb<Table_28>(SqQueries.SelectFromTable28);
            GetFor40TablesDBSQLServer.table29 = sqlServerRpositoryAdo.GetDataFromDb<Table_29>(SqQueries.SelectFromTable29);
            GetFor40TablesDBSQLServer.table30 = sqlServerRpositoryAdo.GetDataFromDb<Table_30>(SqQueries.SelectFromTable30);
            GetFor40TablesDBSQLServer.table31 = sqlServerRpositoryAdo.GetDataFromDb<Table_31>(SqQueries.SelectFromTable31);
            GetFor40TablesDBSQLServer.table32 = sqlServerRpositoryAdo.GetDataFromDb<Table_32>(SqQueries.SelectFromTable32);
            GetFor40TablesDBSQLServer.table33 = sqlServerRpositoryAdo.GetDataFromDb<Table_33>(SqQueries.SelectFromTable33);
            GetFor40TablesDBSQLServer.table34 = sqlServerRpositoryAdo.GetDataFromDb<Table_34>(SqQueries.SelectFromTable34);
            GetFor40TablesDBSQLServer.table35 = sqlServerRpositoryAdo.GetDataFromDb<Table_35>(SqQueries.SelectFromTable35);
            GetFor40TablesDBSQLServer.table36 = sqlServerRpositoryAdo.GetDataFromDb<Table_36>(SqQueries.SelectFromTable36);
            GetFor40TablesDBSQLServer.table37 = sqlServerRpositoryAdo.GetDataFromDb<Table_37>(SqQueries.SelectFromTable37);
            GetFor40TablesDBSQLServer.table38 = sqlServerRpositoryAdo.GetDataFromDb<Table_38>(SqQueries.SelectFromTable38);
            GetFor40TablesDBSQLServer.table39 = sqlServerRpositoryAdo.GetDataFromDb<Table_39>(SqQueries.SelectFromTable39);
            GetFor40TablesDBSQLServer.table40 = sqlServerRpositoryAdo.GetDataFromDb<Table_40>(SqQueries.SelectFromTable40);


            sqlServerRpositoryAdo.ConnectionDispose();

            return GetFor40TablesDBSQLServer;
        }
    }
}
