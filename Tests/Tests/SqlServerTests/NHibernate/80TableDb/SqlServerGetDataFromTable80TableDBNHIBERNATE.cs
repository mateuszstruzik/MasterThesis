using DataExtract.Models.ModelsForTests;
using DataExtract.Models.TableModels;
using DataExtract.Models.TableModels.SingleTablesModels;
using DataExtract.Repository.SQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.SqlServerTests.NHibernate._80TableDb
{
    public class SqlServerGetDataFromTable80TableDBNHIBERNATE
    {
        private SqlServerRepositoryNHibernate SqlServerRepository;

        public SqlServerGetDataFromTable80TableDBNHIBERNATE()
        {
            SqlServerRepository = new SqlServerRepositoryNHibernate(ConfigurationManager.ConnectionStrings["SqlServer80Table"].ConnectionString);
        }

        public ModelFor80TablesDB GetDataTableByTable()
        {
            var newObj = new ModelFor80TablesDB();
            SqlServerRepository.InitSessionFactory<ModelFor80TablesDB>();

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
            newObj.table41 = SqlServerRepository.GetAllDataFromTable<Table_41>();
            newObj.table42 = SqlServerRepository.GetAllDataFromTable<Table_42>();
            newObj.table43 = SqlServerRepository.GetAllDataFromTable<Table_43>();
            newObj.table44 = SqlServerRepository.GetAllDataFromTable<Table_44>();
            newObj.table45 = SqlServerRepository.GetAllDataFromTable<Table_45>();
            newObj.table46 = SqlServerRepository.GetAllDataFromTable<Table_46>();
            newObj.table47 = SqlServerRepository.GetAllDataFromTable<Table_47>();
            newObj.table48 = SqlServerRepository.GetAllDataFromTable<Table_48>();
            newObj.table49 = SqlServerRepository.GetAllDataFromTable<Table_49>();
            newObj.table50 = SqlServerRepository.GetAllDataFromTable<Table_50>();
            newObj.table51 = SqlServerRepository.GetAllDataFromTable<Table_51>();
            newObj.table52 = SqlServerRepository.GetAllDataFromTable<Table_52>();
            newObj.table53 = SqlServerRepository.GetAllDataFromTable<Table_53>();
            newObj.table54 = SqlServerRepository.GetAllDataFromTable<Table_54>();
            newObj.table55 = SqlServerRepository.GetAllDataFromTable<Table_55>();
            newObj.table56 = SqlServerRepository.GetAllDataFromTable<Table_56>();
            newObj.table57 = SqlServerRepository.GetAllDataFromTable<Table_57>();
            newObj.table58 = SqlServerRepository.GetAllDataFromTable<Table_58>();
            newObj.table59 = SqlServerRepository.GetAllDataFromTable<Table_59>();
            newObj.table60 = SqlServerRepository.GetAllDataFromTable<Table_60>();


            SqlServerRepository.SessionClose();

            return newObj;
        }
    }
}
