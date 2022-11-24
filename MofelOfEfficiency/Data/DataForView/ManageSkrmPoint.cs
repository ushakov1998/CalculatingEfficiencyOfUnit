using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithRastrWin.Data.DataForView
{
    public class ManageSkrmPoint
    {
        public int NodeNumder { get; }
        public double Qgen { get; }

        public double U { get; }

        public ManageSkrmPoint(int nodeNumder, double qgen, double u)
        {
            NodeNumder = nodeNumder;
            Qgen = qgen;
            U = u;
        }
    }
}
