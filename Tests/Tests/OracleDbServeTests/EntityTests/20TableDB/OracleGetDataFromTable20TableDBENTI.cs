using DataExtract.Models.EntityContext._20TableDB;
using DataExtract.Models.ModelsForTests;
using DataExtract.Models.TableModels;
using DataExtract.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.OracleDbServeTests.EntityTests._20TableDB
{
    public class OracleGetDataFromTable20TableDBENTI
    {
        public ModelFor20TablesDB GetDataTableByTable()
        {

            var newobj = new ModelFor20TablesDB();

            using (var context = new OracleContextFor20TableDB())
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
                newobj.table11 = context.Database.SqlQuery<Table_11>(SqQueries.SelectFromTable11).ToList();
                newobj.table12 = context.Database.SqlQuery<Table_12>(SqQueries.SelectFromTable12).ToList();
                newobj.table13 = context.Database.SqlQuery<Table_13>(SqQueries.SelectFromTable13).ToList();
                newobj.table14 = context.Database.SqlQuery<Table_14>(SqQueries.SelectFromTable14).ToList();
                newobj.table15 = context.Database.SqlQuery<Table_15>(SqQueries.SelectFromTable15).ToList();
                newobj.table16 = context.Database.SqlQuery<Table_16>(SqQueries.SelectFromTable16).ToList();
                newobj.table17 = context.Database.SqlQuery<Table_17>(SqQueries.SelectFromTable17).ToList();
                newobj.table18 = context.Database.SqlQuery<Table_18>(SqQueries.SelectFromTable18).ToList();
                newobj.table19 = context.Database.SqlQuery<Table_19>(SqQueries.SelectFromTable19).ToList();
                newobj.table20 = context.Database.SqlQuery<Table_20>(SqQueries.SelectFromTable20).ToList();
            }

            return newobj;
        }
    }
}
