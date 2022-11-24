using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithRastrWin.Data.Table
{
    public class Vetv
    {
        public bool Mark { get; set; }
        public bool State { get; set; }
        public int TypeOf { get; set; }
        public int NodeStartNumder { get; set; }
        public int NodeEndNumder { get; set; }
        public int ParallelNumber { get; set; }
        public string Name { get; set; }
        public string DispatchName { get; set; }
        


        public Vetv()
        {

        }

        public Vetv(bool mark, bool state, int typeOf, int nodeStartNumder, int nodeEndNumder, int parallelNumber, string name, string dispatchName)
        {
            Mark = mark;
            State = state;
            TypeOf = typeOf;
            NodeStartNumder = nodeStartNumder;
            NodeEndNumder = nodeEndNumder;
            ParallelNumber = parallelNumber;
            Name = name;
            DispatchName = dispatchName;
        }
    }
}
