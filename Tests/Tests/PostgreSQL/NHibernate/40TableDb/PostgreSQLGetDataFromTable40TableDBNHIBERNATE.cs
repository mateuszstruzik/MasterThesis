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

namespace Tests.Tests.PostgreSQL.NHibernate._40TableDb
{
    public class PostgreSQLGetDataFromTable40TableDBNHIBERNATE
    {
        public PostgreSQLServerRepositoryNHibernate PostgreSQLServerRepositoryNHibernate;

        public PostgreSQLGetDataFromTable40TableDBNHIBERNATE()
        {
            PostgreSQLServerRepositoryNHibernate = new PostgreSQLServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings["PostgreSQLServer40Table"].ConnectionString);
        }
        public ModelFor40TablesDB GetDataTableByTable()
        {
            var newObj = new ModelFor40TablesDB();
            PostgreSQLServerRepositoryNHibernate.InitSessionFactory<ModelFor40TablesDB>();

            newObj.table1 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_1>(SqQueries.SelectFromTable1);
            newObj.table2 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_2>(SqQueries.SelectFromTable2);
            newObj.table3 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_3>(SqQueries.SelectFromTable3);
            newObj.table4 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_4>(SqQueries.SelectFromTable4);
            newObj.table5 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_5>(SqQueries.SelectFromTable5);
            newObj.table6 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_6>(SqQueries.SelectFromTable6);
            newObj.table7 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_7>(SqQueries.SelectFromTable7);
            newObj.table8 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_8>(SqQueries.SelectFromTable8);
            newObj.table9 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_9>(SqQueries.SelectFromTable9);
            newObj.table10 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_10>(SqQueries.SelectFromTable10);
            newObj.table11 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_11>(SqQueries.SelectFromTable11);
            newObj.table12 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_12>(SqQueries.SelectFromTable12);
            newObj.table13 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_13>(SqQueries.SelectFromTable13);
            newObj.table14 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_14>(SqQueries.SelectFromTable14);
            newObj.table15 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_15>(SqQueries.SelectFromTable15);
            newObj.table16 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_16>(SqQueries.SelectFromTable16);
            newObj.table17 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_17>(SqQueries.SelectFromTable17);
            newObj.table18 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_18>(SqQueries.SelectFromTable18);
            newObj.table19 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_19>(SqQueries.SelectFromTable19);
            newObj.table20 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_20>(SqQueries.SelectFromTable20);
            newObj.table21 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_21>(SqQueries.SelectFromTable21);
            newObj.table22 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_22>(SqQueries.SelectFromTable22);
            newObj.table23 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_23>(SqQueries.SelectFromTable23);
            newObj.table24 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_24>(SqQueries.SelectFromTable24);
            newObj.table25 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_25>(SqQueries.SelectFromTable25);
            newObj.table26 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_26>(SqQueries.SelectFromTable26);
            newObj.table27 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_27>(SqQueries.SelectFromTable27);
            newObj.table28 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_28>(SqQueries.SelectFromTable28);
            newObj.table29 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_29>(SqQueries.SelectFromTable29);
            newObj.table30 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_30>(SqQueries.SelectFromTable30);
            newObj.table31 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_31>(SqQueries.SelectFromTable31);
            newObj.table32 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_32>(SqQueries.SelectFromTable32);
            newObj.table33 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_33>(SqQueries.SelectFromTable33);
            newObj.table34 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_34>(SqQueries.SelectFromTable34);
            newObj.table35 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_35>(SqQueries.SelectFromTable35);
            newObj.table36 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_36>(SqQueries.SelectFromTable36);
            newObj.table37 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_37>(SqQueries.SelectFromTable37);
            newObj.table38 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_38>(SqQueries.SelectFromTable38);
            newObj.table39 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_39>(SqQueries.SelectFromTable39);
            newObj.table40 = PostgreSQLServerRepositoryNHibernate.GetAllDataFromTable<Table_40>(SqQueries.SelectFromTable40);

            PostgreSQLServerRepositoryNHibernate.SessionClose();

            return newObj;
        }
    }
}
