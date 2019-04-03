using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.TableModels
{
    public class Table_9 : IModels
    {
        [Key]
        public virtual int Column_1_TAB9 { get; set; }
        public virtual string Column_2_TAB9 { get; set; }
        public virtual string Column_3_TAB9 { get; set; }
        public virtual string Column_4_TAB9 { get; set; }
        public virtual string Column_5_TAB9 { get; set; }
        public virtual string Column_6_TAB9 { get; set; }
        public virtual string Column_7_TAB9 { get; set; }
        public virtual string Column_8_TAB9 { get; set; }
        public virtual string Column_9_TAB9 { get; set; }
        public virtual string Column_10_TAB9 { get; set; }
        public virtual string Column_11_TAB9 { get; set; }
        public virtual string Column_12_TAB9 { get; set; }
        public virtual string Column_13_TAB9 { get; set; }
        public virtual string Column_14_TAB9 { get; set; }
        public virtual string Column_15_TAB9 { get; set; }
        public virtual string Column_16_TAB9 { get; set; }
        public virtual string Column_17_TAB9 { get; set; }
        public virtual string Column_18_TAB9 { get; set; }
        public virtual string Column_19_TAB9 { get; set; }
        public virtual string Column_20_TAB9 { get; set; }

        public Table_9()
        {

        }
        public virtual void SetModel(int id, List<string> propertyList)
        {
            Column_1_TAB9 = id;
            Column_2_TAB9 = propertyList[0];
            Column_3_TAB9 = propertyList[1];
            Column_4_TAB9 = propertyList[2];
            Column_5_TAB9 = propertyList[3];
            Column_6_TAB9 = propertyList[4];
            Column_7_TAB9 = propertyList[5];
            Column_8_TAB9 = propertyList[6];
            Column_9_TAB9 = propertyList[7];
            Column_10_TAB9 = propertyList[8];
            Column_11_TAB9 = propertyList[9];
            Column_12_TAB9 = propertyList[10];
            Column_13_TAB9 = propertyList[11];
            Column_14_TAB9 = propertyList[12];
            Column_15_TAB9 = propertyList[13];
            Column_16_TAB9 = propertyList[14];
            Column_17_TAB9 = propertyList[15];
            Column_18_TAB9 = propertyList[16];
            Column_19_TAB9 = propertyList[17];
            Column_20_TAB9 = propertyList[18];
        }
    }
}
