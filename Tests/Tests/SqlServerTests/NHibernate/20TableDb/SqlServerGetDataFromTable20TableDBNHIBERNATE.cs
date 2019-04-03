using DataExtract.Models.ModelsForTests;
using DataExtract.Models.TableModels;
using DataExtract.Repository.SQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.SqlServerTests.NHibernate._20TableDb
{
    public class SqlServerGetDataFromTable20TableDBNHIBERNATE
    {
        private SqlServerRepositoryNHibernate SqlServerRepository;

        public SqlServerGetDataFromTable20TableDBNHIBERNATE()
        {
            SqlServerRepository = new SqlServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings["SqlServer20Table"].ConnectionString);
        }

        public ModelFor20TablesDB GetDataTableByTable()
        {
            var newObj = new ModelFor20TablesDB();
            SqlServerRepository.InitSessionFactory<ModelFor20TablesDB>();

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
            newObj.table11 = SqlServerRepository.GetAllDataFromTable<Table_11>();
            newObj.table12 = SqlServerRepository.GetAllDataFromTable<Table_12>();
            newObj.table13 = SqlServerRepository.GetAllDataFromTable<Table_13>();
            newObj.table14 = SqlServerRepository.GetAllDataFromTable<Table_14>();
            newObj.table15 = SqlServerRepository.GetAllDataFromTable<Table_15>();
            newObj.table16 = SqlServerRepository.GetAllDataFromTable<Table_16>();
            newObj.table17 = SqlServerRepository.GetAllDataFromTable<Table_17>();
            newObj.table18 = SqlServerRepository.GetAllDataFromTable<Table_18>();
            newObj.table19 = SqlServerRepository.GetAllDataFromTable<Table_19>();
            newObj.table20 = SqlServerRepository.GetAllDataFromTable<Table_20>();

            SqlServerRepository.SessionClose();

            return newObj;
        }
    }
}
