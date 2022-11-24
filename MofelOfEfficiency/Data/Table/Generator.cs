using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithRastrWin.Data.Table
{
    public class Generator : ManagedSkrm
    {
        public string StationName { get; set; }

        public int GenNumder { get; set; }

        public string GenName { get; set; }


        public Generator(Node node, string stationName, int genNumber, string genName) : base(node.Mark, node.State, node.TypeOf, node.NodeNumder, node.NodeName,
             node.Unom, node.AreaNumber, node.Pn, node.Qn, node.Pg, node.Qg, node.Uset, node.Qmin, node.Qmax, node.Bsh, node.U)
        {
            StationName = stationName;
            GenNumder = genNumber;
            GenName = genName;
        }

        public Generator()
        {

        }

        // TODO : генератор к строке.

    }
}
