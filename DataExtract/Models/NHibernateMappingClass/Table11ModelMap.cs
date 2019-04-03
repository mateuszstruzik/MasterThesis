using DataExtract.Models.TableModels;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.NHibernateMappingClass
{
    class Table11ModelMap : ClassMap<Table_11>
    {
        public Table11ModelMap()
        {
            Id(x => x.Column_1_TAB1);
            Map(x => x.Column_2_TAB1);
            Map(x => x.Column_3_TAB1);
            Map(x => x.Column_4_TAB1);
            Map(x => x.Column_5_TAB1);
            Map(x => x.Column_6_TAB1);
            Map(x => x.Column_7_TAB1);
            Map(x => x.Column_8_TAB1);
            Map(x => x.Column_9_TAB1);
            Map(x => x.Column_10_TAB1);
            Table("Table_11");
        }
    }
}
