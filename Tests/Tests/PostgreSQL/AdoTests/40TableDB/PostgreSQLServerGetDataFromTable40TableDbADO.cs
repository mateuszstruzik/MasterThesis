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

namespace Tests.Tests.PostgreSQL.AdoTests._40TableDB
{
    public class PostgreSQLServerGetDataFromTable40TableDbADO
    {
        public PostgreSqlServerRpositoryAdo PostgreSqlServerRpositoryAdo;

        public PostgreSQLServerGetDataFromTable40TableDbADO()
        {
            PostgreSqlServerRpositoryAdo = new PostgreSqlServerRpositoryAdo(ConfigurationManager.ConnectionStrings["PostgreSQLServer40Table"].ConnectionString);
        }

        public ModelFor40TablesDB GetDataTableByTable()
        {
            ModelFor40TablesDB GetFor10TablesDBSQLServer = new ModelFor40TablesDB();

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
            GetFor10TablesDBSQLServer.table21 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_21>(SqQueries.SelectFromTable21);
            GetFor10TablesDBSQLServer.table22 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_22>(SqQueries.SelectFromTable22);
            GetFor10TablesDBSQLServer.table23 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_23>(SqQueries.SelectFromTable23);
            GetFor10TablesDBSQLServer.table24 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_24>(SqQueries.SelectFromTable24);
            GetFor10TablesDBSQLServer.table25 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_25>(SqQueries.SelectFromTable25);
            GetFor10TablesDBSQLServer.table26 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_26>(SqQueries.SelectFromTable26);
            GetFor10TablesDBSQLServer.table27 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_27>(SqQueries.SelectFromTable27);
            GetFor10TablesDBSQLServer.table28 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_28>(SqQueries.SelectFromTable28);
            GetFor10TablesDBSQLServer.table29 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_29>(SqQueries.SelectFromTable29);
            GetFor10TablesDBSQLServer.table30 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_30>(SqQueries.SelectFromTable30);
            GetFor10TablesDBSQLServer.table31 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_31>(SqQueries.SelectFromTable31);
            GetFor10TablesDBSQLServer.table32 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_32>(SqQueries.SelectFromTable32);
            GetFor10TablesDBSQLServer.table33 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_33>(SqQueries.SelectFromTable33);
            GetFor10TablesDBSQLServer.table34 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_34>(SqQueries.SelectFromTable34);
            GetFor10TablesDBSQLServer.table35 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_35>(SqQueries.SelectFromTable35);
            GetFor10TablesDBSQLServer.table36 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_36>(SqQueries.SelectFromTable36);
            GetFor10TablesDBSQLServer.table37 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_37>(SqQueries.SelectFromTable37);
            GetFor10TablesDBSQLServer.table38 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_38>(SqQueries.SelectFromTable38);
            GetFor10TablesDBSQLServer.table39 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_39>(SqQueries.SelectFromTable39);
            GetFor10TablesDBSQLServer.table40 = PostgreSqlServerRpositoryAdo.GetDataFromDb<Table_40>(SqQueries.SelectFromTable40);

            return GetFor10TablesDBSQLServer;
        }
    }
}
