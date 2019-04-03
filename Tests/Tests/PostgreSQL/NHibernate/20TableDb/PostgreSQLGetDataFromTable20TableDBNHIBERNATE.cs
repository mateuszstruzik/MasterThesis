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

namespace Tests.Tests.PostgreSQL.NHibernate._20TableDb
{
    public class PostgreSQLGetDataFromTable20TableDBNHIBERNATE
    {
        public PostgreSQLServerRepositoryNHibernate PostgreSQLServerRepositoryNHibernate;

        public PostgreSQLGetDataFromTable20TableDBNHIBERNATE()
        {
            PostgreSQLServerRepositoryNHibernate = new PostgreSQLServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings["PostgreSQLServer20Table"].ConnectionString);
        }
        public ModelFor20TablesDB GetDataTableByTable()
        {
            var newObj = new ModelFor20TablesDB();
            PostgreSQLServerRepositoryNHibernate.InitSessionFactory<ModelFor20TablesDB>();

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


            PostgreSQLServerRepositoryNHibernate.SessionClose();

            return newObj;
        }
    }
}
