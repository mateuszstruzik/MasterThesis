using DataExtract.Models.ModelsForTests;
using DataExtract.Models.TableModels;
using DataExtract.Models.TableModels.SingleTablesModels;
using DataExtract.Queries;
using DataExtract.Repository.SQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.SqlServerTests.ADOTESTS._80TableDB
{
    public class SqlServerGetDataFromTable80TableDbADO
    {
        public SqlServerRpositoryAdo sqlServerRpositoryAdo;

        public SqlServerGetDataFromTable80TableDbADO()
        {
            sqlServerRpositoryAdo = new SqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings["SqlServer80Table"].ConnectionString);
        }

        public ModelFor80TablesDB GetDataTableByTable()
        {
            ModelFor80TablesDB GetFor80TablesDBSQLServer = new ModelFor80TablesDB();

            GetFor80TablesDBSQLServer.table1 = sqlServerRpositoryAdo.GetDataFromDb<Table_1>(SqQueries.SelectFromTable1);
            GetFor80TablesDBSQLServer.table2 = sqlServerRpositoryAdo.GetDataFromDb<Table_2>(SqQueries.SelectFromTable2);
            GetFor80TablesDBSQLServer.table3 = sqlServerRpositoryAdo.GetDataFromDb<Table_3>(SqQueries.SelectFromTable3);
            GetFor80TablesDBSQLServer.table4 = sqlServerRpositoryAdo.GetDataFromDb<Table_4>(SqQueries.SelectFromTable4);
            GetFor80TablesDBSQLServer.table5 = sqlServerRpositoryAdo.GetDataFromDb<Table_5>(SqQueries.SelectFromTable5);
            GetFor80TablesDBSQLServer.table6 = sqlServerRpositoryAdo.GetDataFromDb<Table_6>(SqQueries.SelectFromTable6);
            GetFor80TablesDBSQLServer.table7 = sqlServerRpositoryAdo.GetDataFromDb<Table_7>(SqQueries.SelectFromTable7);
            GetFor80TablesDBSQLServer.table8 = sqlServerRpositoryAdo.GetDataFromDb<Table_8>(SqQueries.SelectFromTable8);
            GetFor80TablesDBSQLServer.table9 = sqlServerRpositoryAdo.GetDataFromDb<Table_9>(SqQueries.SelectFromTable9);
            GetFor80TablesDBSQLServer.table10 = sqlServerRpositoryAdo.GetDataFromDb<Table_10>(SqQueries.SelectFromTable10);
            GetFor80TablesDBSQLServer.table11 = sqlServerRpositoryAdo.GetDataFromDb<Table_11>(SqQueries.SelectFromTable11);
            GetFor80TablesDBSQLServer.table12 = sqlServerRpositoryAdo.GetDataFromDb<Table_12>(SqQueries.SelectFromTable12);
            GetFor80TablesDBSQLServer.table13 = sqlServerRpositoryAdo.GetDataFromDb<Table_13>(SqQueries.SelectFromTable13);
            GetFor80TablesDBSQLServer.table14 = sqlServerRpositoryAdo.GetDataFromDb<Table_14>(SqQueries.SelectFromTable14);
            GetFor80TablesDBSQLServer.table15 = sqlServerRpositoryAdo.GetDataFromDb<Table_15>(SqQueries.SelectFromTable15);
            GetFor80TablesDBSQLServer.table16 = sqlServerRpositoryAdo.GetDataFromDb<Table_16>(SqQueries.SelectFromTable16);
            GetFor80TablesDBSQLServer.table17 = sqlServerRpositoryAdo.GetDataFromDb<Table_17>(SqQueries.SelectFromTable17);
            GetFor80TablesDBSQLServer.table18 = sqlServerRpositoryAdo.GetDataFromDb<Table_18>(SqQueries.SelectFromTable18);
            GetFor80TablesDBSQLServer.table19 = sqlServerRpositoryAdo.GetDataFromDb<Table_19>(SqQueries.SelectFromTable19);
            GetFor80TablesDBSQLServer.table20 = sqlServerRpositoryAdo.GetDataFromDb<Table_20>(SqQueries.SelectFromTable20);
            GetFor80TablesDBSQLServer.table21 = sqlServerRpositoryAdo.GetDataFromDb<Table_21>(SqQueries.SelectFromTable21);
            GetFor80TablesDBSQLServer.table22 = sqlServerRpositoryAdo.GetDataFromDb<Table_22>(SqQueries.SelectFromTable22);
            GetFor80TablesDBSQLServer.table23 = sqlServerRpositoryAdo.GetDataFromDb<Table_23>(SqQueries.SelectFromTable23);
            GetFor80TablesDBSQLServer.table24 = sqlServerRpositoryAdo.GetDataFromDb<Table_24>(SqQueries.SelectFromTable24);
            GetFor80TablesDBSQLServer.table25 = sqlServerRpositoryAdo.GetDataFromDb<Table_25>(SqQueries.SelectFromTable25);
            GetFor80TablesDBSQLServer.table26 = sqlServerRpositoryAdo.GetDataFromDb<Table_26>(SqQueries.SelectFromTable26);
            GetFor80TablesDBSQLServer.table27 = sqlServerRpositoryAdo.GetDataFromDb<Table_27>(SqQueries.SelectFromTable27);
            GetFor80TablesDBSQLServer.table28 = sqlServerRpositoryAdo.GetDataFromDb<Table_28>(SqQueries.SelectFromTable28);
            GetFor80TablesDBSQLServer.table29 = sqlServerRpositoryAdo.GetDataFromDb<Table_29>(SqQueries.SelectFromTable29);
            GetFor80TablesDBSQLServer.table30 = sqlServerRpositoryAdo.GetDataFromDb<Table_30>(SqQueries.SelectFromTable30);
            GetFor80TablesDBSQLServer.table31 = sqlServerRpositoryAdo.GetDataFromDb<Table_31>(SqQueries.SelectFromTable31);
            GetFor80TablesDBSQLServer.table32 = sqlServerRpositoryAdo.GetDataFromDb<Table_32>(SqQueries.SelectFromTable32);
            GetFor80TablesDBSQLServer.table33 = sqlServerRpositoryAdo.GetDataFromDb<Table_33>(SqQueries.SelectFromTable33);
            GetFor80TablesDBSQLServer.table34 = sqlServerRpositoryAdo.GetDataFromDb<Table_34>(SqQueries.SelectFromTable34);
            GetFor80TablesDBSQLServer.table35 = sqlServerRpositoryAdo.GetDataFromDb<Table_35>(SqQueries.SelectFromTable35);
            GetFor80TablesDBSQLServer.table36 = sqlServerRpositoryAdo.GetDataFromDb<Table_36>(SqQueries.SelectFromTable36);
            GetFor80TablesDBSQLServer.table37 = sqlServerRpositoryAdo.GetDataFromDb<Table_37>(SqQueries.SelectFromTable37);
            GetFor80TablesDBSQLServer.table38 = sqlServerRpositoryAdo.GetDataFromDb<Table_38>(SqQueries.SelectFromTable38);
            GetFor80TablesDBSQLServer.table39 = sqlServerRpositoryAdo.GetDataFromDb<Table_39>(SqQueries.SelectFromTable39);
            GetFor80TablesDBSQLServer.table40 = sqlServerRpositoryAdo.GetDataFromDb<Table_40>(SqQueries.SelectFromTable40);
            GetFor80TablesDBSQLServer.table41 = sqlServerRpositoryAdo.GetDataFromDb<Table_41>(SqQueries.SelectFromTable41);
            GetFor80TablesDBSQLServer.table42 = sqlServerRpositoryAdo.GetDataFromDb<Table_42>(SqQueries.SelectFromTable42);
            GetFor80TablesDBSQLServer.table43 = sqlServerRpositoryAdo.GetDataFromDb<Table_43>(SqQueries.SelectFromTable43);
            GetFor80TablesDBSQLServer.table44 = sqlServerRpositoryAdo.GetDataFromDb<Table_44>(SqQueries.SelectFromTable44);
            GetFor80TablesDBSQLServer.table45 = sqlServerRpositoryAdo.GetDataFromDb<Table_45>(SqQueries.SelectFromTable45);
            GetFor80TablesDBSQLServer.table46 = sqlServerRpositoryAdo.GetDataFromDb<Table_46>(SqQueries.SelectFromTable46);
            GetFor80TablesDBSQLServer.table47 = sqlServerRpositoryAdo.GetDataFromDb<Table_47>(SqQueries.SelectFromTable47);
            GetFor80TablesDBSQLServer.table48 = sqlServerRpositoryAdo.GetDataFromDb<Table_48>(SqQueries.SelectFromTable48);
            GetFor80TablesDBSQLServer.table49 = sqlServerRpositoryAdo.GetDataFromDb<Table_49>(SqQueries.SelectFromTable49);
            GetFor80TablesDBSQLServer.table50 = sqlServerRpositoryAdo.GetDataFromDb<Table_50>(SqQueries.SelectFromTable50);
            GetFor80TablesDBSQLServer.table51 = sqlServerRpositoryAdo.GetDataFromDb<Table_51>(SqQueries.SelectFromTable51);
            GetFor80TablesDBSQLServer.table52 = sqlServerRpositoryAdo.GetDataFromDb<Table_52>(SqQueries.SelectFromTable52);
            GetFor80TablesDBSQLServer.table53 = sqlServerRpositoryAdo.GetDataFromDb<Table_53>(SqQueries.SelectFromTable53);
            GetFor80TablesDBSQLServer.table54 = sqlServerRpositoryAdo.GetDataFromDb<Table_54>(SqQueries.SelectFromTable54);
            GetFor80TablesDBSQLServer.table55 = sqlServerRpositoryAdo.GetDataFromDb<Table_55>(SqQueries.SelectFromTable55);
            GetFor80TablesDBSQLServer.table56 = sqlServerRpositoryAdo.GetDataFromDb<Table_56>(SqQueries.SelectFromTable56);
            GetFor80TablesDBSQLServer.table57 = sqlServerRpositoryAdo.GetDataFromDb<Table_57>(SqQueries.SelectFromTable57);
            GetFor80TablesDBSQLServer.table58 = sqlServerRpositoryAdo.GetDataFromDb<Table_58>(SqQueries.SelectFromTable58);
            GetFor80TablesDBSQLServer.table59 = sqlServerRpositoryAdo.GetDataFromDb<Table_59>(SqQueries.SelectFromTable59);
            GetFor80TablesDBSQLServer.table60 = sqlServerRpositoryAdo.GetDataFromDb<Table_60>(SqQueries.SelectFromTable60);

            sqlServerRpositoryAdo.ConnectionDispose();

            return GetFor80TablesDBSQLServer;
        }
    }
}
