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

namespace Tests.Tests.OracleDbServeTests.NHibernate._10TableDb
{
    public class OracleGetDataFromTable10TableDBNHIBERNATE
    {
        OracleDbServerRepositoryNHibernate oracleDbServerRepositoryNHibernate;

        public OracleGetDataFromTable10TableDBNHIBERNATE()
        {
            oracleDbServerRepositoryNHibernate = new OracleDbServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings["OracleDbServer10TableNHIBERNATE"].ConnectionString);
        }

        public ModelFor10TablesDBSQLServer GetDataTableByTable()
        {
            var newObj = new ModelFor10TablesDBSQLServer();
            oracleDbServerRepositoryNHibernate.InitSessionFactory<ModelFor10TablesDBSQLServer>();

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

            oracleDbServerRepositoryNHibernate.SessionClose();

            return newObj;
        }
    }
}
