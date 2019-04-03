using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.TableModels.SingleTablesModels
{
    public class Table_43 : IModels
    {
        //table_3 and table_9 (DB 10 SQL)
        [Key]
        public virtual int Column_1_TAB3 { get; set; }
        public virtual string Column_2_TAB3 { get; set; }
        public virtual string Column_3_TAB3 { get; set; }
        public virtual string Column_4_TAB3 { get; set; }
        public virtual string Column_5_TAB3 { get; set; }
        public virtual string Column_6_TAB3 { get; set; }
        public virtual string Column_7_TAB3 { get; set; }
        public virtual string Column_8_TAB3 { get; set; }
        public virtual string Column_9_TAB3 { get; set; }
        public virtual string Column_10_TAB3 { get; set; }
        public virtual string Column_11_TAB3 { get; set; }
        public virtual string Column_12_TAB3 { get; set; }
        public virtual string Column_13_TAB3 { get; set; }
        public virtual string Column_14_TAB3 { get; set; }
        public virtual string Column_15_TAB3 { get; set; }
        public virtual string Column_16_TAB3 { get; set; }
        public virtual string Column_17_TAB3 { get; set; }
        public virtual string Column_18_TAB3 { get; set; }
        public virtual string Column_19_TAB3 { get; set; }
        public virtual string Column_20_TAB3 { get; set; }

        public Table_43()
        {

        }
        public virtual void SetModel(int id, List<string> propertyList)
        {
            Column_1_TAB3 = id;
            Column_2_TAB3 = propertyList[0];
            Column_3_TAB3 = propertyList[1];
            Column_4_TAB3 = propertyList[2];
            Column_5_TAB3 = propertyList[3];
            Column_6_TAB3 = propertyList[4];
            Column_7_TAB3 = propertyList[5];
            Column_8_TAB3 = propertyList[6];
            Column_9_TAB3 = propertyList[7];
            Column_10_TAB3 = propertyList[8];
            Column_11_TAB3 = propertyList[9];
            Column_12_TAB3 = propertyList[10];
            Column_13_TAB3 = propertyList[11];
            Column_14_TAB3 = propertyList[12];
            Column_15_TAB3 = propertyList[13];
            Column_16_TAB3 = propertyList[14];
            Column_17_TAB3 = propertyList[15];
            Column_18_TAB3 = propertyList[16];
            Column_19_TAB3 = propertyList[17];
            Column_20_TAB3 = propertyList[18];
        }
    }
}
