using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithRastrWin.Data.Table
{
    public class Node
    {
        public bool Mark { get; set; }
        public bool State { get; set; }
        public int TypeOf { get; set; }
        public int NodeNumder { get; set; }
        public string NodeName { get; set; }
        public double Unom { get; set; }
        public int AreaNumber { get; set; }
        public double Pn { get; set; }
        public double Qn { get; set; }

        private double pg;
        public double Pg
        {
            set => pg = Math.Round(value, 2);
            get => pg;
        }

        private double qg;
        public double Qg
        {
            set => qg = Math.Round(value, 2);
            get => qg;
        }

        private double uset;
        public double Uset
        {
            set => uset = Math.Round(value, 2);
            get => uset;
        }
        private double qmin;
        public double Qmin
        {
            set => qmin = Math.Round(value, 2);
            get => qmin;
        }
        private double qmax;
        public double Qmax
        {
            set => qmax = Math.Round(value, 2);
            get => qmax;
        }
        public double Bsh { get; set; }

        private double u;
        public double U
        {
            set => u = Math.Round(value, 2);
            get => u;
        }


        public Node ()
        {

        }

        public Node(bool mark, bool state, int typeOf, int nodeNumder, string nodeName,
            double uNom, int areaNumber, double pN, double qN, double pG, double qG, 
            double uSet, double qMin, double qMax, double bSh, double u)
        {
            Mark = mark;
            State = state;
            TypeOf = typeOf;
            NodeNumder = nodeNumder;
            NodeName = nodeName;
            Unom = uNom;
            AreaNumber = areaNumber;
            Pn = pN;
            Qn = qN;
            Pg = pG;
            Qg = qG;
            Uset = uSet;
            Qmin = qMin;
            Qmax = qMax;
            Bsh = bSh;
            U = u;
        }
    }
}
