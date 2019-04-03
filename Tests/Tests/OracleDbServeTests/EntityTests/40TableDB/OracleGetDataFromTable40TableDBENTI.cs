using DataExtract.Models.EntityContext._40TableDB;
using DataExtract.Models.ModelsForTests;
using DataExtract.Models.TableModels;
using DataExtract.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.OracleDbServeTests.EntityTests._40TableDB
{
    public class OracleGetDataFromTable40TableDBENTI
    {
        public ModelFor40TablesDB GetDataTableByTable()
        {

            var newobj = new ModelFor40TablesDB();

            using (var context = new OracleContextFor40TableDB())
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
                newobj.table21 = context.Database.SqlQuery<Table_21>(SqQueries.SelectFromTable21).ToList();
                newobj.table22 = context.Database.SqlQuery<Table_22>(SqQueries.SelectFromTable22).ToList();
                newobj.table23 = context.Database.SqlQuery<Table_23>(SqQueries.SelectFromTable23).ToList();
                newobj.table24 = context.Database.SqlQuery<Table_24>(SqQueries.SelectFromTable24).ToList();
                newobj.table25 = context.Database.SqlQuery<Table_25>(SqQueries.SelectFromTable25).ToList();
                newobj.table26 = context.Database.SqlQuery<Table_26>(SqQueries.SelectFromTable26).ToList();
                newobj.table27 = context.Database.SqlQuery<Table_27>(SqQueries.SelectFromTable27).ToList();
                newobj.table28 = context.Database.SqlQuery<Table_28>(SqQueries.SelectFromTable28).ToList();
                newobj.table29 = context.Database.SqlQuery<Table_29>(SqQueries.SelectFromTable29).ToList();
                newobj.table30 = context.Database.SqlQuery<Table_30>(SqQueries.SelectFromTable30).ToList();
                newobj.table31 = context.Database.SqlQuery<Table_31>(SqQueries.SelectFromTable31).ToList();
                newobj.table32 = context.Database.SqlQuery<Table_32>(SqQueries.SelectFromTable32).ToList();
                newobj.table33 = context.Database.SqlQuery<Table_33>(SqQueries.SelectFromTable33).ToList();
                newobj.table34 = context.Database.SqlQuery<Table_34>(SqQueries.SelectFromTable34).ToList();
                newobj.table35 = context.Database.SqlQuery<Table_35>(SqQueries.SelectFromTable35).ToList();
                newobj.table36 = context.Database.SqlQuery<Table_36>(SqQueries.SelectFromTable36).ToList();
                newobj.table37 = context.Database.SqlQuery<Table_37>(SqQueries.SelectFromTable37).ToList();
                newobj.table38 = context.Database.SqlQuery<Table_38>(SqQueries.SelectFromTable38).ToList();
                newobj.table39 = context.Database.SqlQuery<Table_39>(SqQueries.SelectFromTable39).ToList();
                newobj.table40 = context.Database.SqlQuery<Table_40>(SqQueries.SelectFromTable40).ToList();
            }

            return newobj;
        }
    }
}
