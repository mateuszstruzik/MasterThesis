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

namespace Tests.Tests.OracleDbServeTests.AdoTests._40TableDB
{
    public class OracleServerGetDataFromTable40TableDbADO
    {
        public OracleDbServerRpositoryAdo oracleDbServerRpositoryAdo;

        public OracleServerGetDataFromTable40TableDbADO()
        {
            oracleDbServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings["OracleDbServer40Table"].ConnectionString);
        }

        public ModelFor40TablesDB GetDataTableByTable()
        {
            ModelFor40TablesDB GetFor40TablesDBSQLServer = new ModelFor40TablesDB();

            GetFor40TablesDBSQLServer.table1 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_1>(SqQueries.SelectFromTable1);
            GetFor40TablesDBSQLServer.table2 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_2>(SqQueries.SelectFromTable2);
            GetFor40TablesDBSQLServer.table3 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_3>(SqQueries.SelectFromTable3);
            GetFor40TablesDBSQLServer.table4 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_4>(SqQueries.SelectFromTable4);
            GetFor40TablesDBSQLServer.table5 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_5>(SqQueries.SelectFromTable5);
            GetFor40TablesDBSQLServer.table6 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_6>(SqQueries.SelectFromTable6);
            GetFor40TablesDBSQLServer.table7 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_7>(SqQueries.SelectFromTable7);
            GetFor40TablesDBSQLServer.table8 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_8>(SqQueries.SelectFromTable8);
            GetFor40TablesDBSQLServer.table9 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_9>(SqQueries.SelectFromTable9);
            GetFor40TablesDBSQLServer.table10 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_10>(SqQueries.SelectFromTable10);
            GetFor40TablesDBSQLServer.table11 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_11>(SqQueries.SelectFromTable11);
            GetFor40TablesDBSQLServer.table12 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_12>(SqQueries.SelectFromTable12);
            GetFor40TablesDBSQLServer.table13 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_13>(SqQueries.SelectFromTable13);
            GetFor40TablesDBSQLServer.table14 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_14>(SqQueries.SelectFromTable14);
            GetFor40TablesDBSQLServer.table15 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_15>(SqQueries.SelectFromTable15);
            GetFor40TablesDBSQLServer.table16 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_16>(SqQueries.SelectFromTable16);
            GetFor40TablesDBSQLServer.table17 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_17>(SqQueries.SelectFromTable17);
            GetFor40TablesDBSQLServer.table18 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_18>(SqQueries.SelectFromTable18);
            GetFor40TablesDBSQLServer.table19 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_19>(SqQueries.SelectFromTable19);
            GetFor40TablesDBSQLServer.table20 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_20>(SqQueries.SelectFromTable20);
            GetFor40TablesDBSQLServer.table21 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_21>(SqQueries.SelectFromTable21);
            GetFor40TablesDBSQLServer.table22 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_22>(SqQueries.SelectFromTable22);
            GetFor40TablesDBSQLServer.table23 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_23>(SqQueries.SelectFromTable23);
            GetFor40TablesDBSQLServer.table24 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_24>(SqQueries.SelectFromTable24);
            GetFor40TablesDBSQLServer.table25 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_25>(SqQueries.SelectFromTable25);
            GetFor40TablesDBSQLServer.table26 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_26>(SqQueries.SelectFromTable26);
            GetFor40TablesDBSQLServer.table27 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_27>(SqQueries.SelectFromTable27);
            GetFor40TablesDBSQLServer.table28 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_28>(SqQueries.SelectFromTable28);
            GetFor40TablesDBSQLServer.table29 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_29>(SqQueries.SelectFromTable29);
            GetFor40TablesDBSQLServer.table30 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_30>(SqQueries.SelectFromTable30);
            GetFor40TablesDBSQLServer.table31 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_31>(SqQueries.SelectFromTable31);
            GetFor40TablesDBSQLServer.table32 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_32>(SqQueries.SelectFromTable32);
            GetFor40TablesDBSQLServer.table33 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_33>(SqQueries.SelectFromTable33);
            GetFor40TablesDBSQLServer.table34 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_34>(SqQueries.SelectFromTable34);
            GetFor40TablesDBSQLServer.table35 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_35>(SqQueries.SelectFromTable35);
            GetFor40TablesDBSQLServer.table36 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_36>(SqQueries.SelectFromTable36);
            GetFor40TablesDBSQLServer.table37 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_37>(SqQueries.SelectFromTable37);
            GetFor40TablesDBSQLServer.table38 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_38>(SqQueries.SelectFromTable38);
            GetFor40TablesDBSQLServer.table39 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_39>(SqQueries.SelectFromTable39);
            GetFor40TablesDBSQLServer.table40 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_40>(SqQueries.SelectFromTable40);

            return GetFor40TablesDBSQLServer;
        }
    }
}
