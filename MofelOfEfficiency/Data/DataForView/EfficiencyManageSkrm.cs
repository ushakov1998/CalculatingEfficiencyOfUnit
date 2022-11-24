using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithRastrWin.Data.DataForView
{
    public class EfficiencyManageSkrm : EfficiencyBase
    {
        #region Свойства

        public double QEfficiency { get; set; }

        public double QRange { get; set; }


        #endregion

        #region Конструкторы
        


        public EfficiencyManageSkrm(int nodeNumber, string nodeName, double qDel, double uDel) : base(nodeNumber, nodeName, uDel)
        {
            if (uDel < 0.01)
            {
                QEfficiency = 9999;
            }
            else
            {
                QEfficiency = Math.Round(qDel / uDel, 2);
            }
            QRange = Math.Round(qDel, 2);
            UDel = Math.Round(uDel, 2);
        }
        #endregion

        public override string ToString()
        {
            return $"Эффективность {NodeName}: {QEfficiency} Мвар/кВ." ;
        }
    }
}
