using DataExtract.Models.ModelsForTests;
using DataExtract.Models.TableModels;
using DataExtract.Repository.SQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.SqlServerTests.NHibernate._10TableDb
{
    public class SqlServerGetDataFromTable10TableDBNHIBERNATE
    {
        private SqlServerRepositoryNHibernate SqlServerRepository;

        public SqlServerGetDataFromTable10TableDBNHIBERNATE()
        {
            SqlServerRepository = new SqlServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings["SqlServer10TableENT"].ConnectionString);
        }

        public ModelFor10TablesDBSQLServer GetDataTableByTable()
        {
            var newObj = new ModelFor10TablesDBSQLServer();
            SqlServerRepository.InitSessionFactory<ModelFor10TablesDBSQLServer>();

            newObj.table1 = SqlServerRepository.GetAllDataFromTable<Table_1>();
            newObj.table2 = SqlServerRepository.GetAllDataFromTable<Table_2>();
            newObj.table3 = SqlServerRepository.GetAllDataFromTable<Table_3>();
            newObj.table4 = SqlServerRepository.GetAllDataFromTable<Table_4>();
            newObj.table5 = SqlServerRepository.GetAllDataFromTable<Table_5>();
            newObj.table6 = SqlServerRepository.GetAllDataFromTable<Table_6>();
            newObj.table7 = SqlServerRepository.GetAllDataFromTable<Table_7>();
            newObj.table8 = SqlServerRepository.GetAllDataFromTable<Table_8>();
            newObj.table9 = SqlServerRepository.GetAllDataFromTable<Table_9>();
            newObj.table10 = SqlServerRepository.GetAllDataFromTable<Table_10>();

            SqlServerRepository.SessionClose();

            return newObj;
        }
    }
}
