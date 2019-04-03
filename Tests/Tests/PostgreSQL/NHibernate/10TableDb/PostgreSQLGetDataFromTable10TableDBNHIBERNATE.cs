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

namespace Tests.Tests.PostgreSQL.NHibernate._10TableDb
{
    public class PostgreSQLGetDataFromTable10TableDBNHIBERNATE
    {
        public PostgreSQLServerRepositoryNHibernate PostgreSQLServerRepositoryNHibernate;

        public PostgreSQLGetDataFromTable10TableDBNHIBERNATE()
        {
            PostgreSQLServerRepositoryNHibernate = new PostgreSQLServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings["PostgreSQLServer10Table"].ConnectionString);
        }
        public ModelFor10TablesDBSQLServer GetDataTableByTable()
        {
            var newObj = new ModelFor10TablesDBSQLServer();
            PostgreSQLServerRepositoryNHibernate.InitSessionFactory<ModelFor10TablesDBSQLServer>();

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

            PostgreSQLServerRepositoryNHibernate.SessionClose();

            return newObj;
        }

    }
}
