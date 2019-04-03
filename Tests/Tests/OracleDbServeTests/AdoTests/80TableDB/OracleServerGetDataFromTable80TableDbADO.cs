using DataExtract.Models.ModelsForTests;
using DataExtract.Models.TableModels;
using DataExtract.Models.TableModels.SingleTablesModels;
using DataExtract.Queries;
using DataExtract.Repository.OracleDbServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.OracleDbServeTests.AdoTests._80TableDB
{
    public class OracleServerGetDataFromTable80TableDbADO
    {
        public OracleDbServerRpositoryAdo oracleDbServerRpositoryAdo;

        public OracleServerGetDataFromTable80TableDbADO()
        {
            oracleDbServerRpositoryAdo = new OracleDbServerRpositoryAdo(ConfigurationManager.ConnectionStrings["OracleDbServer80Table"].ConnectionString);
        }

        public ModelFor80TablesDB GetDataTableByTable()
        {
            ModelFor80TablesDB GetFor40TablesDBSQLServer = new ModelFor80TablesDB();

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
            GetFor40TablesDBSQLServer.table41 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_41>(SqQueries.SelectFromTable41);
            GetFor40TablesDBSQLServer.table42 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_42>(SqQueries.SelectFromTable42);
            GetFor40TablesDBSQLServer.table43 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_43>(SqQueries.SelectFromTable43);
            GetFor40TablesDBSQLServer.table44 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_44>(SqQueries.SelectFromTable44);
            GetFor40TablesDBSQLServer.table45 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_45>(SqQueries.SelectFromTable45);
            GetFor40TablesDBSQLServer.table46 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_46>(SqQueries.SelectFromTable46);
            GetFor40TablesDBSQLServer.table47 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_47>(SqQueries.SelectFromTable47);
            GetFor40TablesDBSQLServer.table48 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_48>(SqQueries.SelectFromTable48);
            GetFor40TablesDBSQLServer.table49 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_49>(SqQueries.SelectFromTable49);
            GetFor40TablesDBSQLServer.table50 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_50>(SqQueries.SelectFromTable50);
            GetFor40TablesDBSQLServer.table51 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_51>(SqQueries.SelectFromTable51);
            GetFor40TablesDBSQLServer.table52 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_52>(SqQueries.SelectFromTable52);
            GetFor40TablesDBSQLServer.table53 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_53>(SqQueries.SelectFromTable53);
            GetFor40TablesDBSQLServer.table54 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_54>(SqQueries.SelectFromTable54);
            GetFor40TablesDBSQLServer.table55 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_55>(SqQueries.SelectFromTable55);
            GetFor40TablesDBSQLServer.table56 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_56>(SqQueries.SelectFromTable56);
            GetFor40TablesDBSQLServer.table57 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_57>(SqQueries.SelectFromTable57);
            GetFor40TablesDBSQLServer.table58 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_58>(SqQueries.SelectFromTable58);
            GetFor40TablesDBSQLServer.table59 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_59>(SqQueries.SelectFromTable59);
            GetFor40TablesDBSQLServer.table60 = oracleDbServerRpositoryAdo.GetWholeDataFromTable<Table_60>(SqQueries.SelectFromTable60);


            return GetFor40TablesDBSQLServer;
        }
    }
}
