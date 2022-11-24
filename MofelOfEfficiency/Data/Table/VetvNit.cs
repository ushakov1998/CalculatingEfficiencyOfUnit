using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithRastrWin.Data.Table
{
    public class VetvNit : Vetv
    {
        public int Nit { get; set; }
        public int NitAv { get; set; }
        public double IdopOb { get; set; }
        public double Idop { get; set; }
        public double IdopAv { get; set; }
        public double IdopObAv { get; set; }

        public VetvNit()
        {

        }
    }
}
