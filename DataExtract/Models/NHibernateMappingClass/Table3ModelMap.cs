using DataExtract.Models.TableModels;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.NHibernateMappingClass
{
    public class Table3ModelMap : ClassMap<Table_3>
    {
        public Table3ModelMap()
        {
            Id(x => x.Column_1_TAB3);
            Map(x => x.Column_2_TAB3);
            Map(x => x.Column_3_TAB3);
            Map(x => x.Column_4_TAB3);
            Map(x => x.Column_5_TAB3);
            Map(x => x.Column_6_TAB3);
            Map(x => x.Column_7_TAB3);
            Map(x => x.Column_8_TAB3);
            Map(x => x.Column_9_TAB3);
            Map(x => x.Column_10_TAB3);
            Map(x => x.Column_11_TAB3);
            Map(x => x.Column_12_TAB3);
            Map(x => x.Column_13_TAB3);
            Map(x => x.Column_14_TAB3);
            Map(x => x.Column_15_TAB3);
            Map(x => x.Column_16_TAB3);
            Map(x => x.Column_17_TAB3);
            Map(x => x.Column_18_TAB3);
            Map(x => x.Column_19_TAB3);
            Map(x => x.Column_20_TAB3);
            Table("Table_3");
        }

    }
}
