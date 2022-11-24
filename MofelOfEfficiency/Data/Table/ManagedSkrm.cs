using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithRastrWin.Data.Table
{
    public class ManagedSkrm : Node
    {
        public double DQplus => Math.Round(Math.Abs(this.Qmax - this.Qg),2);

        public double DQminus => Math.Round(Math.Abs(this.Qmin - this.Qg), 2);

        public ManagedSkrm()
        {

        }

        public ManagedSkrm(bool mark , bool state, int typeOf, int nodeNumder, string nodeName,
            double uNom, int areaNumber, double pN, double qN, double pG, double qG,
            double uSet, double qMin, double qMax, double bSh, double u) 
            :base (mark ,state, typeOf, nodeNumder, nodeName,
             uNom,  areaNumber, pN, qN, pG, qG, uSet, qMin, qMax, bSh, u)
        {
        }

        public ManagedSkrm(Node node) : base(node.Mark, node.State, node.TypeOf, node.NodeNumder, node.NodeName,
             node.Unom, node.AreaNumber, node.Pn, node.Qn, node.Pg, node.Qg, node.Uset, node.Qmin, node.Qmax, node.Bsh, node.U)
        {

        }

        public override string ToString()
        {
            var stringThis = "";
            if (this is ManagedSkrm)
            {
                string stateString = State ? "выключен" : "включен";
                string modeString = Qg > 0 ? "генерации" : "потребления"; 
                stringThis = "Управляемый СКРМ: " + NodeName + " (узел: " + NodeNumder + "), СКРМ " + State + ".\n";
                stringThis += "Диапазон регулирования реактивной мощности: от " + Math.Round(Qmin, 2) + " Мвар до" + Math.Round(Qmax, 2) + " Мвар.\n";
                stringThis += "Текущие параметры: Qг: " + Math.Round(Qg,2) + " Мвар, Vзад: " + Uset + " Кв, режим: " + modeString + ".\n";
                stringThis += "Диапазон на загрузку: " + Math.Round(DQplus, 2) + " Мвар, на разгрузку: " + Math.Round(DQminus, 2) + " Мвар.";
            }
            return stringThis;
        }
    }
}
