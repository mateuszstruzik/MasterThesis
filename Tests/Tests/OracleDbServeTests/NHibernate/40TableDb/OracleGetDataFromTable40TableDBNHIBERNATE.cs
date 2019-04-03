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

namespace Tests.Tests.OracleDbServeTests.NHibernate._40TableDb
{
    public class OracleGetDataFromTable40TableDBNHIBERNATE
    {
        OracleDbServerRepositoryNHibernate oracleDbServerRepositoryNHibernate;

        public OracleGetDataFromTable40TableDBNHIBERNATE()
        {
            oracleDbServerRepositoryNHibernate = new OracleDbServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings["OracleDbServer40TableNHIBERNATE"].ConnectionString);
        }

        public ModelFor40TablesDB GetDataTableByTable()
        {
            var newObj = new ModelFor40TablesDB();
            oracleDbServerRepositoryNHibernate.InitSessionFactory<ModelFor40TablesDB>();

            newObj.table1 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_1>(SqQueries.SelectFromTable1);
            newObj.table2 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_2>(SqQueries.SelectFromTable2);
            newObj.table3 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_3>(SqQueries.SelectFromTable3);
            newObj.table4 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_4>(SqQueries.SelectFromTable4);
            newObj.table5 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_5>(SqQueries.SelectFromTable5);
            newObj.table6 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_6>(SqQueries.SelectFromTable6);
            newObj.table7 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_7>(SqQueries.SelectFromTable7);
            newObj.table8 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_8>(SqQueries.SelectFromTable8);
            newObj.table9 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_9>(SqQueries.SelectFromTable9);
            newObj.table10 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_10>(SqQueries.SelectFromTable10);
            newObj.table11 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_11>(SqQueries.SelectFromTable11);
            newObj.table12 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_12>(SqQueries.SelectFromTable12);
            newObj.table13 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_13>(SqQueries.SelectFromTable13);
            newObj.table14 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_14>(SqQueries.SelectFromTable14);
            newObj.table15 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_15>(SqQueries.SelectFromTable15);
            newObj.table16 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_16>(SqQueries.SelectFromTable16);
            newObj.table17 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_17>(SqQueries.SelectFromTable17);
            newObj.table18 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_18>(SqQueries.SelectFromTable18);
            newObj.table19 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_19>(SqQueries.SelectFromTable19);
            newObj.table20 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_20>(SqQueries.SelectFromTable20);
            newObj.table21 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_21>(SqQueries.SelectFromTable21);
            newObj.table22 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_22>(SqQueries.SelectFromTable22);
            newObj.table23 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_23>(SqQueries.SelectFromTable23);
            newObj.table24 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_24>(SqQueries.SelectFromTable24);
            newObj.table25 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_25>(SqQueries.SelectFromTable25);
            newObj.table26 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_26>(SqQueries.SelectFromTable26);
            newObj.table27 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_27>(SqQueries.SelectFromTable27);
            newObj.table28 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_28>(SqQueries.SelectFromTable28);
            newObj.table29 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_29>(SqQueries.SelectFromTable29);
            newObj.table30 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_30>(SqQueries.SelectFromTable30);
            newObj.table31 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_31>(SqQueries.SelectFromTable31);
            newObj.table32 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_32>(SqQueries.SelectFromTable32);
            newObj.table33 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_33>(SqQueries.SelectFromTable33);
            newObj.table34 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_34>(SqQueries.SelectFromTable34);
            newObj.table35 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_35>(SqQueries.SelectFromTable35);
            newObj.table36 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_36>(SqQueries.SelectFromTable36);
            newObj.table37 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_37>(SqQueries.SelectFromTable37);
            newObj.table38 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_38>(SqQueries.SelectFromTable38);
            newObj.table39 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_39>(SqQueries.SelectFromTable39);
            newObj.table40 = oracleDbServerRepositoryNHibernate.GetAllDataFromTable<Table_40>(SqQueries.SelectFromTable40);

            oracleDbServerRepositoryNHibernate.SessionClose();

            return newObj;
        }
    }
}
