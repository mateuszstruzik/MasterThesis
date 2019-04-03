using DataExtract.Models.EntityContext._40TableDB;
using DataExtract.Models.ModelsForTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.SqlServerTests.EntityTest._40TableDB
{
    public class SqlServerGetDataFromTable40TableDBENTI
    {
        public ModelFor40TablesDB GetDataTableByTable()
        {
            var newobj = new ModelFor40TablesDB();

            using (var context = new SqlServerContextFor40TableDB())
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
                newobj.table21 = context.Table_21.Select(x => x).ToList();
                newobj.table22 = context.Table_22.Select(x => x).ToList();
                newobj.table23 = context.Table_23.Select(x => x).ToList();
                newobj.table24 = context.Table_24.Select(x => x).ToList();
                newobj.table25 = context.Table_25.Select(x => x).ToList();
                newobj.table26 = context.Table_26.Select(x => x).ToList();
                newobj.table27 = context.Table_27.Select(x => x).ToList();
                newobj.table28 = context.Table_28.Select(x => x).ToList();
                newobj.table29 = context.Table_29.Select(x => x).ToList();
                newobj.table30 = context.Table_30.Select(x => x).ToList();
                newobj.table31 = context.Table_31.Select(x => x).ToList();
                newobj.table32 = context.Table_32.Select(x => x).ToList();
                newobj.table33 = context.Table_33.Select(x => x).ToList();
                newobj.table34 = context.Table_34.Select(x => x).ToList();
                newobj.table35 = context.Table_35.Select(x => x).ToList();
                newobj.table36 = context.Table_36.Select(x => x).ToList();
                newobj.table37 = context.Table_37.Select(x => x).ToList();
                newobj.table38 = context.Table_38.Select(x => x).ToList();
                newobj.table39 = context.Table_39.Select(x => x).ToList();
                newobj.table40 = context.Table_40.Select(x => x).ToList();
            }

            return newobj;
        }
    }
}
