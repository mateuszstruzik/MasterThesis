using DataExtract.Models.ModelsForTests;
using DataExtract.Models.TableModels;
using DataExtract.Repository.SQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.SqlServerTests.NHibernate._40TableDb
{
    public class SqlServerGetDataFromTable40TableDBNHIBERNATE
    {
        private SqlServerRepositoryNHibernate SqlServerRepository;

        public SqlServerGetDataFromTable40TableDBNHIBERNATE()
        {
            SqlServerRepository = new SqlServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings["SqlServer40Table"].ConnectionString);
        }

        public ModelFor40TablesDB GetDataTableByTable()
        {
            var newObj = new ModelFor40TablesDB();
            SqlServerRepository.InitSessionFactory<ModelFor40TablesDB>();

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
            newObj.table21 = SqlServerRepository.GetAllDataFromTable<Table_21>();
            newObj.table22 = SqlServerRepository.GetAllDataFromTable<Table_22>();
            newObj.table23 = SqlServerRepository.GetAllDataFromTable<Table_23>();
            newObj.table24 = SqlServerRepository.GetAllDataFromTable<Table_24>();
            newObj.table25 = SqlServerRepository.GetAllDataFromTable<Table_25>();
            newObj.table26 = SqlServerRepository.GetAllDataFromTable<Table_26>();
            newObj.table27 = SqlServerRepository.GetAllDataFromTable<Table_27>();
            newObj.table28 = SqlServerRepository.GetAllDataFromTable<Table_28>();
            newObj.table29 = SqlServerRepository.GetAllDataFromTable<Table_29>();
            newObj.table30 = SqlServerRepository.GetAllDataFromTable<Table_30>();
            newObj.table31 = SqlServerRepository.GetAllDataFromTable<Table_31>();
            newObj.table32 = SqlServerRepository.GetAllDataFromTable<Table_32>();
            newObj.table33 = SqlServerRepository.GetAllDataFromTable<Table_33>();
            newObj.table34 = SqlServerRepository.GetAllDataFromTable<Table_34>();
            newObj.table35 = SqlServerRepository.GetAllDataFromTable<Table_35>();
            newObj.table36 = SqlServerRepository.GetAllDataFromTable<Table_36>();
            newObj.table37 = SqlServerRepository.GetAllDataFromTable<Table_37>();
            newObj.table38 = SqlServerRepository.GetAllDataFromTable<Table_38>();
            newObj.table39 = SqlServerRepository.GetAllDataFromTable<Table_39>();
            newObj.table40 = SqlServerRepository.GetAllDataFromTable<Table_40>();

            SqlServerRepository.SessionClose();

            return newObj;
        }
    }
}
