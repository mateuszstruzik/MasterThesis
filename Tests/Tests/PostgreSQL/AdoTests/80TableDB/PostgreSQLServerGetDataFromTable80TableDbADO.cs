using DataExtract.Models.ModelsForTests;
using DataExtract.Models.TableModels;
using DataExtract.Models.TableModels.SingleTablesModels;
using DataExtract.Queries;
using DataExtract.Repository.PostgreSQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.PostgreSQL.AdoTests._80TableDB
{
    public class PostgreSQLServerGetDataFromTable80TableDbADO
    {
        public PostgreSqlServerRpositoryAdo PostgreSqlServerRpositoryAdo;

        public PostgreSQLServerGetDataFromTable80TableDbADO()
        {
            PostgreSqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings["PostgreSQLServer80Table"].ConnectionString);
        }

        public ModelFor80TablesDB GetDataTableByTable()
        {
            ModelFor80TablesDB GetFor80TablesDBSQLServer = new ModelFor80TablesDB();

            GetFor80TablesDBSQLServer.table1 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_1>(SqQueries.SelectFromTable1);
            GetFor80TablesDBSQLServer.table2 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_2>(SqQueries.SelectFromTable2);
            GetFor80TablesDBSQLServer.table3 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_3>(SqQueries.SelectFromTable3);
            GetFor80TablesDBSQLServer.table4 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_4>(SqQueries.SelectFromTable4);
            GetFor80TablesDBSQLServer.table5 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_5>(SqQueries.SelectFromTable5);
            GetFor80TablesDBSQLServer.table6 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_6>(SqQueries.SelectFromTable6);
            GetFor80TablesDBSQLServer.table7 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_7>(SqQueries.SelectFromTable7);
            GetFor80TablesDBSQLServer.table8 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_8>(SqQueries.SelectFromTable8);
            GetFor80TablesDBSQLServer.table9 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_9>(SqQueries.SelectFromTable9);
            GetFor80TablesDBSQLServer.table10 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_10>(SqQueries.SelectFromTable10);
            GetFor80TablesDBSQLServer.table11 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_11>(SqQueries.SelectFromTable11);
            GetFor80TablesDBSQLServer.table12 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_12>(SqQueries.SelectFromTable12);
            GetFor80TablesDBSQLServer.table13 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_13>(SqQueries.SelectFromTable13);
            GetFor80TablesDBSQLServer.table14 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_14>(SqQueries.SelectFromTable14);
            GetFor80TablesDBSQLServer.table15 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_15>(SqQueries.SelectFromTable15);
            GetFor80TablesDBSQLServer.table16 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_16>(SqQueries.SelectFromTable16);
            GetFor80TablesDBSQLServer.table17 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_17>(SqQueries.SelectFromTable17);
            GetFor80TablesDBSQLServer.table18 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_18>(SqQueries.SelectFromTable18);
            GetFor80TablesDBSQLServer.table19 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_19>(SqQueries.SelectFromTable19);
            GetFor80TablesDBSQLServer.table20 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_20>(SqQueries.SelectFromTable20);
            GetFor80TablesDBSQLServer.table21 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_21>(SqQueries.SelectFromTable21);
            GetFor80TablesDBSQLServer.table22 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_22>(SqQueries.SelectFromTable22);
            GetFor80TablesDBSQLServer.table23 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_23>(SqQueries.SelectFromTable23);
            GetFor80TablesDBSQLServer.table24 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_24>(SqQueries.SelectFromTable24);
            GetFor80TablesDBSQLServer.table25 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_25>(SqQueries.SelectFromTable25);
            GetFor80TablesDBSQLServer.table26 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_26>(SqQueries.SelectFromTable26);
            GetFor80TablesDBSQLServer.table27 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_27>(SqQueries.SelectFromTable27);
            GetFor80TablesDBSQLServer.table28 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_28>(SqQueries.SelectFromTable28);
            GetFor80TablesDBSQLServer.table29 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_29>(SqQueries.SelectFromTable29);
            GetFor80TablesDBSQLServer.table30 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_30>(SqQueries.SelectFromTable30);
            GetFor80TablesDBSQLServer.table31 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_31>(SqQueries.SelectFromTable31);
            GetFor80TablesDBSQLServer.table32 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_32>(SqQueries.SelectFromTable32);
            GetFor80TablesDBSQLServer.table33 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_33>(SqQueries.SelectFromTable33);
            GetFor80TablesDBSQLServer.table34 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_34>(SqQueries.SelectFromTable34);
            GetFor80TablesDBSQLServer.table35 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_35>(SqQueries.SelectFromTable35);
            GetFor80TablesDBSQLServer.table36 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_36>(SqQueries.SelectFromTable36);
            GetFor80TablesDBSQLServer.table37 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_37>(SqQueries.SelectFromTable37);
            GetFor80TablesDBSQLServer.table38 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_38>(SqQueries.SelectFromTable38);
            GetFor80TablesDBSQLServer.table39 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_39>(SqQueries.SelectFromTable39);
            GetFor80TablesDBSQLServer.table40 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_40>(SqQueries.SelectFromTable40);
            GetFor80TablesDBSQLServer.table41 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_41>(SqQueries.SelectFromTable41);
            GetFor80TablesDBSQLServer.table42 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_42>(SqQueries.SelectFromTable42);
            GetFor80TablesDBSQLServer.table43 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_43>(SqQueries.SelectFromTable43);
            GetFor80TablesDBSQLServer.table44 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_44>(SqQueries.SelectFromTable44);
            GetFor80TablesDBSQLServer.table45 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_45>(SqQueries.SelectFromTable45);
            GetFor80TablesDBSQLServer.table46 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_46>(SqQueries.SelectFromTable46);
            GetFor80TablesDBSQLServer.table47 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_47>(SqQueries.SelectFromTable47);
            GetFor80TablesDBSQLServer.table48 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_48>(SqQueries.SelectFromTable48);
            GetFor80TablesDBSQLServer.table49 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_49>(SqQueries.SelectFromTable49);
            GetFor80TablesDBSQLServer.table50 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_50>(SqQueries.SelectFromTable50);
            GetFor80TablesDBSQLServer.table51 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_51>(SqQueries.SelectFromTable51);
            GetFor80TablesDBSQLServer.table52 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_52>(SqQueries.SelectFromTable52);
            GetFor80TablesDBSQLServer.table53 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_53>(SqQueries.SelectFromTable53);
            GetFor80TablesDBSQLServer.table54 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_54>(SqQueries.SelectFromTable54);
            GetFor80TablesDBSQLServer.table55 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_55>(SqQueries.SelectFromTable55);
            GetFor80TablesDBSQLServer.table56 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_56>(SqQueries.SelectFromTable56);
            GetFor80TablesDBSQLServer.table57 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_57>(SqQueries.SelectFromTable57);
            GetFor80TablesDBSQLServer.table58 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_58>(SqQueries.SelectFromTable58);
            GetFor80TablesDBSQLServer.table59 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_59>(SqQueries.SelectFromTable59);
            GetFor80TablesDBSQLServer.table60 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_60>(SqQueries.SelectFromTable60);

            return GetFor80TablesDBSQLServer;
        }
    }
}
