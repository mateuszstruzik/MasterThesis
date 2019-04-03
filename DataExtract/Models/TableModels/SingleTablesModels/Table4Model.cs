using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.TableModels
{
    //table_4 and table_8 (DB 10 SQL)
    public class Table_4 : IModels
    {
        [Key]
        public virtual int Column_1_TAB4 { get; set; }
        public virtual string Column_2_TAB4 { get; set; }
        public virtual string Column_3_TAB4 { get; set; }
        public virtual string Column_4_TAB4 { get; set; }
        public virtual string Column_5_TAB4 { get; set; }
        public virtual string Column_6_TAB4 { get; set; }
        public virtual string Column_7_TAB4 { get; set; }
        public virtual string Column_8_TAB4 { get; set; }
        public virtual string Column_9_TAB4 { get; set; }
        public virtual string Column_10_TAB4 { get; set; }
        public virtual string Column_11_TAB4 { get; set; }
        public virtual string Column_12_TAB4 { get; set; }
        public virtual string Column_13_TAB4 { get; set; }
        public virtual string Column_14_TAB4 { get; set; }
        public virtual string Column_15_TAB4 { get; set; }
        public virtual string Column_16_TAB4 { get; set; }
        public virtual string Column_17_TAB4 { get; set; }
        public virtual string Column_18_TAB4 { get; set; }
        public virtual string Column_19_TAB4 { get; set; }
        public virtual string Column_20_TAB4 { get; set; }
        public virtual string Column_21_TAB4 { get; set; }
        public virtual string Column_22_TAB4 { get; set; }
        public virtual string Column_23_TAB4 { get; set; }
        public virtual string Column_24_TAB4 { get; set; }
        public virtual string Column_25_TAB4 { get; set; }

        public Table_4()
        {

        }
        public virtual void SetModel(int id, List<string> propertyList)
        {
            Column_1_TAB4 = id;
            Column_2_TAB4 = propertyList[0];
            Column_3_TAB4 = propertyList[1];
            Column_4_TAB4 = propertyList[2];
            Column_5_TAB4 = propertyList[3];
            Column_6_TAB4 = propertyList[4];
            Column_7_TAB4 = propertyList[5];
            Column_8_TAB4 = propertyList[6];
            Column_9_TAB4 = propertyList[7];
            Column_10_TAB4 = propertyList[8];
            Column_11_TAB4 = propertyList[9];
            Column_12_TAB4 = propertyList[10];
            Column_13_TAB4 = propertyList[11];
            Column_14_TAB4 = propertyList[12];
            Column_15_TAB4 = propertyList[13];
            Column_16_TAB4 = propertyList[14];
            Column_17_TAB4 = propertyList[15];
            Column_18_TAB4 = propertyList[16];
            Column_19_TAB4 = propertyList[17];
            Column_20_TAB4 = propertyList[18];
            Column_21_TAB4 = propertyList[19];
            Column_22_TAB4 = propertyList[20];
            Column_23_TAB4 = propertyList[21];
            Column_24_TAB4 = propertyList[22];
            Column_25_TAB4 = propertyList[23];

        }
    }
}
