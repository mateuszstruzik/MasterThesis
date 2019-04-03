﻿using DataExtract.Models.TableModels;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.NHibernateMappingClass
{
    public class Table18ModelMap : ClassMap<Table_18>
    {
        public Table18ModelMap()
        {
            Id(x => x.Column_1_TAB8);
            Map(x => x.Column_2_TAB8);
            Map(x => x.Column_3_TAB8);
            Map(x => x.Column_4_TAB8);
            Map(x => x.Column_5_TAB8);
            Map(x => x.Column_6_TAB8);
            Map(x => x.Column_7_TAB8);
            Map(x => x.Column_8_TAB8);
            Map(x => x.Column_9_TAB8);
            Map(x => x.Column_10_TAB8);
            Map(x => x.Column_11_TAB8);
            Map(x => x.Column_12_TAB8);
            Map(x => x.Column_13_TAB8);
            Map(x => x.Column_14_TAB8);
            Map(x => x.Column_15_TAB8);
            Map(x => x.Column_16_TAB8);
            Map(x => x.Column_17_TAB8);
            Map(x => x.Column_18_TAB8);
            Map(x => x.Column_19_TAB8);
            Map(x => x.Column_20_TAB8);
            Map(x => x.Column_21_TAB8);
            Map(x => x.Column_22_TAB8);
            Map(x => x.Column_23_TAB8);
            Map(x => x.Column_24_TAB8);
            Map(x => x.Column_25_TAB8);
            Table("Table_18");
        }
    }
}