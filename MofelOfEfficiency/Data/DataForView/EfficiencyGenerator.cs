using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithRastrWin.Data.DataForView
{
    public class EfficiencyGenerator : EfficiencyManageSkrm
    {
        #region Свойства

        public int GenNumber { get; set; }

        public string GenName { get; set; }

        public string StationName { get; set; }

        #endregion

        #region Конструкторы


        public EfficiencyGenerator(int nodeNumber, string nodeName, double qDel, double uDel, int genNumber, string genName, string stationName) 
            : base(nodeNumber, nodeName, qDel, uDel)
        {
            StationName = stationName;
            GenNumber = genNumber;
            GenName = genName;
        }
        #endregion
    }
}
