using DataExtract.Models.EntityContext._20TableDB;
using DataExtract.Models.ModelsForTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.SqlServerTests.EntityTest._20TableDb
{
    public class SqlServerGetDataFromTable20TableDBENTI
    {
        public ModelFor20TablesDB GetDataTableByTable()
        {
            var newobj = new ModelFor20TablesDB();

            using (var context = new SqlServerContextFor20TableDB())
            {
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
                newobj.table11 = context.Table_11.Select(x => x).ToList();
                newobj.table12 = context.Table_12.Select(x => x).ToList();
                newobj.table13 = context.Table_13.Select(x => x).ToList();
                newobj.table14 = context.Table_14.Select(x => x).ToList();
                newobj.table15 = context.Table_15.Select(x => x).ToList();
                newobj.table16 = context.Table_16.Select(x => x).ToList();
                newobj.table17 = context.Table_17.Select(x => x).ToList();
                newobj.table18 = context.Table_18.Select(x => x).ToList();
                newobj.table19 = context.Table_19.Select(x => x).ToList();
                newobj.table20 = context.Table_20.Select(x => x).ToList();
            }

            return newobj;
        }
    }
}
