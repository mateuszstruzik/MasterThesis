using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtract.Models.TableModels.SingleTablesModels
{
    public class Table_51 : IModels
    {
        [Key]
        public virtual int Column_1_TAB1 { get; set; }
        public virtual string Column_2_TAB1 { get; set; }
        public virtual string Column_3_TAB1 { get; set; }
        public virtual string Column_4_TAB1 { get; set; }
        public virtual string Column_5_TAB1 { get; set; }
        public virtual string Column_6_TAB1 { get; set; }
        public virtual string Column_7_TAB1 { get; set; }
        public virtual string Column_8_TAB1 { get; set; }
        public virtual string Column_9_TAB1 { get; set; }
        public virtual string Column_10_TAB1 { get; set; }

        public Table_51()
        {

        }
        public virtual void SetModel(int id, List<string> propertyList)
        {
            Column_1_TAB1 = id;
            Column_2_TAB1 = propertyList[0];
            Column_3_TAB1 = propertyList[1];
            Column_4_TAB1 = propertyList[2];
            Column_5_TAB1 = propertyList[3];
            Column_6_TAB1 = propertyList[4];
            Column_7_TAB1 = propertyList[5];
            Column_8_TAB1 = propertyList[6];
            Column_9_TAB1 = propertyList[7];
            Column_10_TAB1 = propertyList[8];
        }
    }
}
