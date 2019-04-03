using DataExtract.Models.EntityContext;
using DataExtract.Models.ModelsForTests;
using DataExtract.Models.TableModels;
using DataExtract.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.PostgreSQL.EntityTest._10TableDb
{
    public class PostgreSQLGetDataFromTable10TableDBENTI
    {

        public ModelFor10TablesDBSQLServer GetDataTableByTable()
        {

            var newobj = new ModelFor10TablesDBSQLServer();

            using (var context = new PostgreSQLContextFor10TableDB())
            {
                newobj.table1 = context.Database.SqlQuery<Table_1>(SqQueries.SelectFromTable1).ToList();
                newobj.table2 = context.Database.SqlQuery<Table_2>(SqQueries.SelectFromTable2).ToList();
                newobj.table3 = context.Database.SqlQuery<Table_3>(SqQueries.SelectFromTable3).ToList();
                newobj.table4 = context.Database.SqlQuery<Table_4>(SqQueries.SelectFromTable4).ToList();
                newobj.table5 = context.Database.SqlQuery<Table_5>(SqQueries.SelectFromTable5).ToList();
                newobj.table6 = context.Database.SqlQuery<Table_6>(SqQueries.SelectFromTable6).ToList();
                newobj.table7 = context.Database.SqlQuery<Table_7>(SqQueries.SelectFromTable7).ToList();
                newobj.table8 = context.Database.SqlQuery<Table_8>(SqQueries.SelectFromTable8).ToList();
                newobj.table9 = context.Database.SqlQuery<Table_9>(SqQueries.SelectFromTable9).ToList();
                newobj.table10 = context.Database.SqlQuery<Table_10>(SqQueries.SelectFromTable10).ToList();
            }

            return newobj;
        }
    }
}
