using DataExtract.Models.EntityContext;
using DataExtract.Models.ModelsForTests;
using DataExtract.Models.TableModels;
using DataExtract.Repository.SQLServer;

using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.SqlServerTests.EntityTest
{
    public class SqlServerGetDataFromTable10TableDBENTI
    {
        //public ContextFor10TableDB context;
        public SqlServerGetDataFromTable10TableDBENTI()
        {
            //context = new ContextFor10TableDB(/*ConfigurationManager.ConnectionStrings["SqlServer10Table"].ConnectionString*/);
        }

        public ModelFor10TablesDBSQLServer GetDataTableByTable()
        {
            //var context = this.context.OpenContextFor0TableDb();

            var newobj = new ModelFor10TablesDBSQLServer();

            using (var context = new ContextFor10TableDB(/*ConfigurationManager.ConnectionStrings["SqlServer10Table"].ConnectionString*/))
            {
                context.Database.Exists();
                newobj.table1 = context.Table_1.Select(x => x).ToList();
                newobj.table2 = context.Table_2.Select(x => x).ToList();
                newobj.table3 = context.Table_3.Select(x => x).ToList();
                newobj.table4 = context.Table_4.Select(x => x).ToList();
                newobj.table5 = context.Table_5.Select(x => x).ToList();
                newobj.table6 = context.Table_6.Select(x => x).ToList();
                newobj.table7 = context.Table_7.Select(x => x).ToList();
                newobj.table8 = context.Table_8.Select(x => x).ToList();
                newobj.table9 = context.Table_9.Select(x => x).ToList();
                newobj.table10 = context.Table_10.Select(x => x).ToList();

            }

            return newobj;
        }
    }
}
