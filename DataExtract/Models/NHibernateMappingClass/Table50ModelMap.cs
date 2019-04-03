using DataExtract.Models.TableModels.SingleTablesModels;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.NHibernateMappingClass
{
    public class Table50ModelMap : ClassMap<Table_50>
    {
        public Table50ModelMap()
        {
            Id(x => x.Column_1_TAB10);
            Map(x => x.Column_2_TAB10);
            Map(x => x.Column_3_TAB10);
            Map(x => x.Column_4_TAB10);
            Map(x => x.Column_5_TAB10);
            Map(x => x.Column_6_TAB10);
            Map(x => x.Column_7_TAB10);
            Map(x => x.Column_8_TAB10);
            Map(x => x.Column_9_TAB10);
            Map(x => x.Column_10_TAB10);
            Map(x => x.Column_11_TAB10);
            Map(x => x.Column_12_TAB10);
            Map(x => x.Column_13_TAB10);
            Map(x => x.Column_14_TAB10);
            Map(x => x.Column_15_TAB10);
            Table("Table_50");
        }
    }
}
