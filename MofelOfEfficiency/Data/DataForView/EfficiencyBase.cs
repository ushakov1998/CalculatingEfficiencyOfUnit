using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithRastrWin.Data.DataForView
{
    public class EfficiencyBase
    {
        #region Свойства

        public int NodeNumber { get; }

        public string NodeName { get; }

        public double UDel { get; set; }

        #endregion

        #region Конструкторы

        public EfficiencyBase(int nodeNumber,
            string nodeName, double uDel)
        {
            NodeNumber = nodeNumber;
            NodeName = nodeName;
            UDel = Math.Round(uDel, 2);
        }
        #endregion

        public override string ToString()
        {
            return $"Изменение напряжения {NodeName}: {UDel} Мвар/кВ.";
        }
    }
}
