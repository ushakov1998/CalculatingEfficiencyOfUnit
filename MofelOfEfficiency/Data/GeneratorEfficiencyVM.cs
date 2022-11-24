using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithRastrWin.Data
{
    public class GeneratorEfficiencyVM
    {
        #region Свойства

        public int GenNumber { get; set; }

        public int NodeNumber { get; set; }

        public string GenName { get; set; }

        public string StationName { get; set; }
        
        public double QUd { get; set; }

        public double QDel { get; set; }

        public double UDel { get; set; }



        #endregion

        #region Конструкторы

        public GeneratorEfficiencyVM(int genNumber, int nodeNumber,
            string genName, string stationName, 
            double qUd, double qDel, double uDel)
        {
            GenNumber = genNumber;
            NodeNumber = nodeNumber;
            GenName = genName;
            StationName = stationName;
            QUd = qUd;
            QDel = qDel;
            UDel = uDel;
        }
        #endregion
    }
}
