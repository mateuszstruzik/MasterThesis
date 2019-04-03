using DataExtract.Models.TableModels;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.NHibernateMappingClass
{
    public class Table29ModelMap : ClassMap<Table_29>
    {
        public Table29ModelMap()
        {
            Id(x => x.Column_1_TAB9);
            Map(x => x.Column_2_TAB9);
            Map(x => x.Column_3_TAB9);
            Map(x => x.Column_4_TAB9);
            Map(x => x.Column_5_TAB9);
            Map(x => x.Column_6_TAB9);
            Map(x => x.Column_7_TAB9);
            Map(x => x.Column_8_TAB9);
            Map(x => x.Column_9_TAB9);
            Map(x => x.Column_10_TAB9);
            Map(x => x.Column_11_TAB9);
            Map(x => x.Column_12_TAB9);
            Map(x => x.Column_13_TAB9);
            Map(x => x.Column_14_TAB9);
            Map(x => x.Column_15_TAB9);
            Map(x => x.Column_16_TAB9);
            Map(x => x.Column_17_TAB9);
            Map(x => x.Column_18_TAB9);
            Map(x => x.Column_19_TAB9);
            Map(x => x.Column_20_TAB9);
            Table("Table_29");
        }
    }
}
