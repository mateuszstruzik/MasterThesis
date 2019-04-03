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

namespace Tests.Tests.OracleDbServeTests.NHibernate._20TableDb
{
    public class OracleGetDataFromTable20TableDBNHIBERNATE
    {
        OracleDbServerRepositoryNHibernate oracleDbServerRepositoryNHibernate;

        public OracleGetDataFromTable20TableDBNHIBERNATE()
        {
            oracleDbServerRepositoryNHibernate = new OracleDbServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings["OracleDbServer20TableNHIBERNATE"].ConnectionString);
        }

        public ModelFor20TablesDB GetDataTableByTable()
        {
            var newObj = new ModelFor20TablesDB();
            oracleDbServerRepositoryNHibernate.InitSessionFactory<ModelFor20TablesDB>();

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


            oracleDbServerRepositoryNHibernate.SessionClose();

            return newObj;
        }
    }
}
