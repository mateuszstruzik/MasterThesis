using DataExtract.Models.TableModels;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.NHibernateMappingClass
{
    public class Table17ModelMap : ClassMap<Table_17>
    {
        public Table17ModelMap()
        {
            Id(x => x.Column_1_TAB7);
            Map(x => x.Column_2_TAB7);
            Map(x => x.Column_3_TAB7);
            Map(x => x.Column_4_TAB7);
            Map(x => x.Column_5_TAB7);
            Map(x => x.Column_6_TAB7);
            Map(x => x.Column_7_TAB7);
            Map(x => x.Column_8_TAB7);
            Map(x => x.Column_9_TAB7);
            Map(x => x.Column_10_TAB7);
            Map(x => x.Column_11_TAB7);
            Map(x => x.Column_12_TAB7);
            Map(x => x.Column_13_TAB7);
            Map(x => x.Column_14_TAB7);
            Map(x => x.Column_15_TAB7);
            Map(x => x.Column_16_TAB7);
            Map(x => x.Column_17_TAB7);
            Map(x => x.Column_18_TAB7);
            Map(x => x.Column_19_TAB7);
            Map(x => x.Column_20_TAB7);
            Map(x => x.Column_21_TAB7);
            Map(x => x.Column_22_TAB7);
            Map(x => x.Column_23_TAB7);
            Map(x => x.Column_24_TAB7);
            Map(x => x.Column_25_TAB7);
            Map(x => x.Column_26_TAB7);
            Map(x => x.Column_27_TAB7);
            Map(x => x.Column_28_TAB7);
            Map(x => x.Column_29_TAB7);
            Map(x => x.Column_30_TAB7);
            Table("Table_17");
        }
    }
}
