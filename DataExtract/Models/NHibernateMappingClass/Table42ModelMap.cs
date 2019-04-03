using DataExtract.Models.TableModels.SingleTablesModels;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.NHibernateMappingClass
{
    public class Table42ModelMap : ClassMap<Table_42>
    {
        public Table42ModelMap()
        {
            Id(x => x.Column_1_TAB2);
            Map(x => x.Column_2_TAB2);
            Map(x => x.Column_3_TAB2);
            Map(x => x.Column_4_TAB2);
            Map(x => x.Column_5_TAB2);
            Map(x => x.Column_6_TAB2);
            Map(x => x.Column_7_TAB2);
            Map(x => x.Column_8_TAB2);
            Map(x => x.Column_9_TAB2);
            Map(x => x.Column_10_TAB2);
            Map(x => x.Column_11_TAB2);
            Map(x => x.Column_12_TAB2);
            Map(x => x.Column_13_TAB2);
            Map(x => x.Column_14_TAB2);
            Map(x => x.Column_15_TAB2);
            Table("Table_42");
        }
    }
}
