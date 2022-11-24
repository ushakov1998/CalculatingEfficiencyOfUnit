using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithRastrWin.Data
{
    public class NitRow
    {
        public int Num { get; set; }

        public int Tc { get; set; }

        public double Idop { get; set; }

        public NitRow()
        {

        }

        public NitRow(int num, int tc, double idop)
        {
            Num = num;
            Tc = tc;
            Idop = idop;
        }
    }
}
