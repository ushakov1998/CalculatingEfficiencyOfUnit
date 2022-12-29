using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithRastrWin.Data.DataForView;
using WorkWithRastrWin.Data.Table;
using WorkWithRastrWin.RastrModel;

namespace WorkWithRastrWin
{
    public class EfficiencyOperation
    {
        public RastrOperations ThisRastrOperations { get; set; }

        public List<ManageSkrmPoint> GetEfficiencyPointManagedCkrm(int nodeKpNum, int manageSkrmNode, int qgPoint = 0)
        {

            var listManageSkrmPoint = new List<ManageSkrmPoint>();
            var indexSkrm = ThisRastrOperations.ThisNodeOperations.GetIndex("ny=" + manageSkrmNode);
            var stateSkrm = ThisRastrOperations.ThisNodeOperations.GetValue("sta", indexSkrm);
            if (!stateSkrm)
            {
                var qSkrmStart = ThisRastrOperations.ThisNodeOperations.GetValue("qg", indexSkrm);
                var qSkrmMax = ThisRastrOperations.ThisNodeOperations.GetValue(RastrConst.TableNodeQmax, indexSkrm);
                var qSkrmMin = ThisRastrOperations.ThisNodeOperations.GetValue("qmin", indexSkrm);
                var vZadStart = ThisRastrOperations.ThisNodeOperations.GetValue(RastrConst.TableNodeUset, indexSkrm);
                if (vZadStart != 0)
                {
                    ThisRastrOperations.ThisNodeOperations.SetValueByIndex(RastrConst.TableNodeUset, indexSkrm, 0);
                }
                var qSkrm = qSkrmMax;
                var flagBreak = true;
                double dQgSet = GetDqSet(qgPoint, qSkrmMax, qSkrmMin);
                //перебор всех точек
                do
                {
                    flagBreak = qSkrm == qSkrmMin ? false : true;
                    var qSkrmReal = 0.1;
                    double vRasThis = GetUKpOfGenSkrm(nodeKpNum, indexSkrm, qSkrm, ref qSkrmReal);
                    listManageSkrmPoint.Add(new ManageSkrmPoint(manageSkrmNode, qSkrm, vRasThis));
                    qSkrm -= dQgSet;
                    qSkrm = qSkrm < qSkrmMin ? qSkrmMin : qSkrm;
                } while (flagBreak);
                ThisRastrOperations.ThisNodeOperations.SetValueByIndex("qg", indexSkrm, qSkrmStart);
                if (vZadStart != 0)
                {
                    ThisRastrOperations.ThisNodeOperations.SetValueByIndex(RastrConst.TableNodeUset, indexSkrm, vZadStart);
                }
            }
            return listManageSkrmPoint;
        }

        private static double GetDqSet(int qgPoint, dynamic qSkrmMax, dynamic qSkrmMin)
        {
            double dQgSet = 50;
            if (qgPoint == 0)
            {
                dQgSet = Math.Round((Math.Abs(qSkrmMin) + Math.Abs(qSkrmMax)) / 5, 2)+0.2;
            }
            return dQgSet;
        }

        public EfficiencyManageSkrm GetEfficiencyManagedSkrm(int nodeKpNum, int manageSkrmNode)
        {
            var indexSkrm = ThisRastrOperations.ThisNodeOperations.GetIndex("ny=" + manageSkrmNode);
            var nodeName = ThisRastrOperations.ThisNodeOperations.GetNameByNumber(manageSkrmNode);
            var stateSkrm = ThisRastrOperations.ThisNodeOperations.GetValue("sta", indexSkrm);
            var qSkrmStart = ThisRastrOperations.ThisNodeOperations.GetValue("qg", indexSkrm);
            var qSkrmMax = ThisRastrOperations.ThisNodeOperations.GetValue(RastrConst.TableNodeQmax, indexSkrm);
            var qSkrmMin = ThisRastrOperations.ThisNodeOperations.GetValue("qmin", indexSkrm);
            var vZadStart = ThisRastrOperations.ThisNodeOperations.GetValue(RastrConst.TableNodeUset, indexSkrm);
            if (!stateSkrm)
            {
                if (vZadStart != 0)
                {
                    ThisRastrOperations.ThisNodeOperations.SetValueByIndex(RastrConst.TableNodeUset, indexSkrm, 0);
                }
                var qSkrm = qSkrmMax;
                var qRealMax = 0.1;
                var qRealMin = 0.1;
                //определение для максимального
                var vRasMax = GetUKpOfGenSkrm(nodeKpNum, indexSkrm, qSkrmMax, ref qRealMax);
                //определение для минимального 
                var vRasMin = GetUKpOfGenSkrm(nodeKpNum, indexSkrm, qSkrmMin, ref qRealMin);
                ThisRastrOperations.ThisNodeOperations.SetValueByIndex("qg", indexSkrm, qSkrmStart);
                if (vZadStart != 0)
                {
                    ThisRastrOperations.ThisNodeOperations.SetValueByIndex(RastrConst.TableNodeUset, indexSkrm, vZadStart);
                }
                return new EfficiencyManageSkrm(manageSkrmNode, nodeName,
                    Math.Abs(qSkrmMax - qSkrmMin), Math.Abs(vRasMax - vRasMin));
            }
            else
            {

                return new EfficiencyManageSkrm(manageSkrmNode, nodeName,
                    Math.Abs(qSkrmMax - qSkrmMin), 0);
            }
                
        }



        private double GetUKpOfGenSkrm(int nodeKpNum, int indexSkrm, dynamic qgSkrm, ref double qgSkrmReal)
        {
            qgSkrmReal = qgSkrm;
            ThisRastrOperations.ThisNodeOperations.SetValueByIndex(RastrConst.TableNodeQg, indexSkrm, qgSkrm);
            var vRas = 999.1;
            if (ThisRastrOperations.RunRGM())
            {
                vRas = ThisRastrOperations.ThisNodeOperations.GetValueByNumber(RastrConst.TableNodeU, nodeKpNum);
            }
            else
            {
                qgSkrmReal = qgSkrm-10;
                var flagBreak = true;
                do
                {
                    ThisRastrOperations.ThisNodeOperations.SetValueByIndex(RastrConst.TableNodeQg, indexSkrm, qgSkrmReal);
                    var kodRg = ThisRastrOperations.RunRGM();
                    if (kodRg)
                    {
                        vRas = ThisRastrOperations.ThisNodeOperations.GetValueByNumber(RastrConst.TableNodeU, nodeKpNum);
                    }
                    qgSkrmReal = qgSkrmReal - 10;
                    qgSkrmReal = qgSkrmReal < 0 ? 0 : qgSkrmReal;
                    if (qgSkrmReal == 0 | kodRg)
                    {
                        flagBreak = false;
                    }
                } while (flagBreak);
                /*
                qgSkrmReal = qgSkrm / 10;
                ThisRastrOperations.ThisNodeOperations.SetValueByIndex(RastrConst.TableNodeQg, indexSkrm, qgSkrm);
                vRas = ThisRastrOperations.ThisNodeOperations.GetValueByNumber(RastrConst.TableNodeU, nodeKpNum);
                */
            }
            return vRas;
        }

        public List<ManageSkrmPoint> GetEfficiencyPointGenerator(int nodeKpNum, int generatorNum, int qgPoint = 0, 
             bool fixationAllStation = false, bool fixationOnePart = false)
        {
            var listManageSkrmPoint = new List<ManageSkrmPoint>();
            var indexGenerator = ThisRastrOperations.ThisGeneratorOperations.GetIndexByNum(generatorNum);
            var stateGenerator = ThisRastrOperations.ThisGeneratorOperations.GetValue("sta", indexGenerator);
            if (!stateGenerator)
            {
                var nodeGen = ThisRastrOperations.ThisGeneratorOperations.GetNodeByNum(generatorNum);
                var listGeneratorNum = ThisRastrOperations.ThisGeneratorOperations.GetListGeneratorNumByNode(nodeGen);
                if (listGeneratorNum.Count() == 1)
                {
                    FixationGeneratorOnStation(generatorNum, fixationAllStation, out var dictionaryStartGenU, out var genNumList);
                    //проверяем каждый генератор на станции
                    foreach (var genNum in genNumList)
                    {
                        indexGenerator = ThisRastrOperations.ThisGeneratorOperations.GetIndexByNum(genNum);
                        nodeGen = ThisRastrOperations.ThisGeneratorOperations.GetNodeByNum(genNum);
                        var qGenMax = ThisRastrOperations.ThisGeneratorOperations
                            .GetValueByIndex(RastrConst.TableGenQmax, indexGenerator);
                        var qGenMin = ThisRastrOperations.ThisGeneratorOperations
                            .GetValueByIndex(RastrConst.TableGenQmin, indexGenerator);
                        var qGenStart = ThisRastrOperations.ThisGeneratorOperations
                            .GetValueByIndex(RastrConst.TableGenQ, indexGenerator);
                        var qGen = qGenMax;
                        var flagBreak = true;
                        double dQgSet = GetDqSet(qgPoint, qGenMax, qGenMin);
                        //перебор всех точек
                        do
                        {
                            flagBreak = qGen != qGenMin;
                            double vRasThis = GetUrasKpOfGenGenerator(nodeKpNum, indexGenerator, qGen);
                            listManageSkrmPoint.Add(new ManageSkrmPoint(genNum, qGen, vRasThis));
                            qGen -= dQgSet;
                            qGen = qGen < qGenMin ? qGenMin : qGen;
                        } while (flagBreak);
                        ThisRastrOperations.ThisGeneratorOperations
                            .SetValueByIndex(RastrConst.TableGenQ, indexGenerator, qGenStart);
                    }
                    //снятие фиксации с генераторов станции
                    UnFixationGeneratorOnStation(dictionaryStartGenU);
                }
                else
                {
                    // TODO : если генераторов несколько в одном узле как определять эффективность?
                }
            } 
            return listManageSkrmPoint;
        }

        public static void GetEfficiencyManagedSkrm()
        {
            throw new NotImplementedException();
        }

        public List<EfficiencyGenerator> GetEfficiencyGenerator(int nodeKpNum, int generatorNum, 
            bool fixationAllStation = false, bool fixationOnePart = false)
        {
            var listEfficiencyGenerator = new List<EfficiencyGenerator>();
            var indexGenerator = ThisRastrOperations.ThisGeneratorOperations.GetIndexByNum(generatorNum);
            var stateGenerator = ThisRastrOperations.ThisGeneratorOperations.GetValue("sta", indexGenerator);
            if (!stateGenerator)
            {
                var nodeGen = ThisRastrOperations.ThisGeneratorOperations.GetNodeByNum(generatorNum);
                var listGeneratorNum = ThisRastrOperations.ThisGeneratorOperations.GetListGeneratorNumByNode(nodeGen);
                if (listGeneratorNum.Count() == 1)
                {
                    var stationName = FixationGeneratorOnStation(generatorNum, fixationAllStation, 
                        out var dictionaryStartGenU, out var genNumList);
                    //проверяем каждый генератор на станции
                    foreach (var genNum in genNumList)
                    {
                        var stateGeneratorThis = ThisRastrOperations.ThisGeneratorOperations.GetStateByNum(genNum);
                        if (stateGeneratorThis) continue;
                        nodeGen = ThisRastrOperations.ThisGeneratorOperations.GetNodeByNum(genNum);
                        indexGenerator = ThisRastrOperations.ThisGeneratorOperations.GetIndexByNum(genNum);
                        var vZadStart = ThisRastrOperations.ThisNodeOperations
                            .GetValueByNumber(RastrConst.TableNodeUset, nodeGen);
                        if (vZadStart != 0)
                        {
                            ThisRastrOperations.ThisNodeOperations
                                .SetValueByNumber(RastrConst.TableNodeUset, nodeGen, 0);
                        }
                        var qGenMax = ThisRastrOperations.ThisGeneratorOperations
                            .GetValueByIndex(RastrConst.TableGenQmax, indexGenerator);
                        var qGenMin = ThisRastrOperations.ThisGeneratorOperations
                            .GetValueByIndex(RastrConst.TableGenQmin, indexGenerator);
                        var qGenStart = ThisRastrOperations.ThisGeneratorOperations
                            .GetValueByIndex(RastrConst.TableGenQ, indexGenerator);
                        var qGen = qGenMax;
                        //определение для максимального
                        var vRasMax = GetUrasKpOfGenGenerator(nodeKpNum, indexGenerator, qGenMax);
                        //определение для минимального 
                        var vRasMin = GetUrasKpOfGenGenerator(nodeKpNum, indexGenerator, qGenMin);
                        ThisRastrOperations.ThisGeneratorOperations
                            .SetValueByIndex(RastrConst.TableGenQ, indexGenerator, qGenStart);
                        if (vZadStart != 0)
                        {
                            ThisRastrOperations.ThisNodeOperations
                                .SetValueByNumber(RastrConst.TableNodeUset, nodeGen, 0);
                        }
                        listEfficiencyGenerator.Add(new EfficiencyGenerator(nodeGen, 
                            ThisRastrOperations.ThisNodeOperations.GetNameByNumber(nodeGen),
                            Math.Abs(qGenMax - qGenMin), Math.Abs(vRasMax - vRasMin), genNum,
                            ThisRastrOperations.ThisGeneratorOperations.GetNameByIndex(indexGenerator).ToString(), stationName));
                    }
                    //снятие фиксации с генераторов станции
                    UnFixationGeneratorOnStation(dictionaryStartGenU);
                }
                else
                {
                    // TODO : если генераторов несколько в одном узле как определять эффективность?
                }
            }
            return listEfficiencyGenerator;
        }

        private void UnFixationGeneratorOnStation(Dictionary<int, double> dictionaryStartGenU)
        {
            foreach (var genNode in dictionaryStartGenU)
            {
                ThisRastrOperations.ThisNodeOperations.SetValueByNumber(RastrConst.TableNodeUset, genNode.Key, genNode.Value);
            }
        }

        private string FixationGeneratorOnStation(int generatorNum, bool fixationAllStation, 
            out Dictionary<int, double> dictionaryStartGenU, out List<int> genNumList)
        {
            //определение генераторов на этой станции
            var genNumOnStationList = ThisRastrOperations.ThisGeneratorOperations.
                GetAllGenerationOnStation(generatorNum, fixationAllStation);
            //найти все узлы в которых генраторы этой станции и зафиксировать
            dictionaryStartGenU = new Dictionary<int, double>();
            genNumList = new List<int>();
            foreach (var genNumThis in genNumOnStationList)
            {
                var nodeGen = ThisRastrOperations.ThisGeneratorOperations.GetNodeByNum(genNumThis);
                genNumList.Add(genNumThis);
                if (dictionaryStartGenU.Any(it => it.Key == nodeGen)) continue;
                //фиксируем генератор, а значение заданного напряжения запоминаем
                var uset = ThisRastrOperations.ThisNodeOperations.GetValueByNumber(RastrConst.TableNodeUset, nodeGen);
                ThisRastrOperations.ThisNodeOperations.SetValueByNumber(RastrConst.TableNodeUset, nodeGen, 0);
                dictionaryStartGenU.Add(nodeGen, uset);
            }
            return ThisRastrOperations.ThisGeneratorOperations.GetStationNameByNum(generatorNum);
        }

        private double GetUrasKpOfGenGenerator(int nodeKpNum, int indexGenerator, dynamic qgGenerator)
        {
            ThisRastrOperations.ThisGeneratorOperations.SetValueByIndex("Q", indexGenerator, qgGenerator);
            var vRas = 999.1;
            if (ThisRastrOperations.RunRGM())
            {
                vRas = ThisRastrOperations.ThisNodeOperations.GetValueByNumber("vras", nodeKpNum);
            }
            return vRas;
        }

        public EfficiencyBase GetEfficiencyUnManageSkrm(int nodeKpNum, int unManageSkrmNode)
        {
            var indexSkrm = ThisRastrOperations.ThisNodeOperations.GetIndex("ny=" + unManageSkrmNode);
            var nodeName = ThisRastrOperations.ThisNodeOperations.GetNameByNumber(unManageSkrmNode);
            var stateSkrm = ThisRastrOperations.ThisNodeOperations.GetValue("sta", indexSkrm);
            var bshSkrm = ThisRastrOperations.ThisNodeOperations.GetValue("bsh", indexSkrm);
            if (!stateSkrm&& bshSkrm!=0)
            {
                //определение для отключенного
                var vRasOn = GetUrasKpOfUnManageSkrm(nodeKpNum);
                //определение для отключенного
                ThisRastrOperations.ThisNodeOperations.SetValueByIndex("bsh", indexSkrm, 0);
                var vRasOff = GetUrasKpOfUnManageSkrm(nodeKpNum);
                ThisRastrOperations.ThisNodeOperations.SetValueByIndex("bsh", indexSkrm, bshSkrm/1000000);
                return new EfficiencyBase(unManageSkrmNode, nodeName, vRasOn - vRasOff);
            }
            else
            {

                return new EfficiencyBase(unManageSkrmNode, nodeName, 0);
            }

        }
        private double GetUrasKpOfUnManageSkrm(int nodeKpNum)
        {
            var vRas = 999.1;
            if (ThisRastrOperations.RunRGM())
            {
                vRas = ThisRastrOperations.ThisNodeOperations.GetValueByNumber("vras", nodeKpNum);
            }
            return vRas;
        }

        public double GetEfficiencyOfNode(int nodeNum,int nodeKpNum)
        {
            double effisency = 9999;

            var indexSkrm = ThisRastrOperations.ThisNodeOperations.GetIndex("ny=" + nodeNum);
            var stateSkrm = ThisRastrOperations.ThisNodeOperations.GetValue("sta", indexSkrm);
            var qSkrmStart = ThisRastrOperations.ThisNodeOperations.GetValue("qg", indexSkrm);
            var qSkrmMax = 100;
            var qSkrmMin = 0;
            var vZadStart = ThisRastrOperations.ThisNodeOperations.GetValue(RastrConst.TableNodeUset, indexSkrm);
            if (!stateSkrm)
            {
                if (vZadStart != 0)
                {
                    ThisRastrOperations.ThisNodeOperations.SetValueByIndex(RastrConst.TableNodeUset, indexSkrm, 0);
                }
                var qSkrm = qSkrmMax;
                var qRealMax = (double)qSkrmMax;
                var qRealMin = (double)qSkrmMin;
                //определение для максимального
                var vRasMax = GetUKpOfGenSkrm(nodeKpNum, indexSkrm, qSkrmMax, ref qRealMax);
                //определение для минимального 
                var vRasMin = GetUKpOfGenSkrm(nodeKpNum, indexSkrm, qSkrmMin, ref qRealMin);
                ThisRastrOperations.ThisNodeOperations.SetValueByIndex("qg", indexSkrm, qSkrmStart);
                if (vZadStart != 0)
                {
                    ThisRastrOperations.ThisNodeOperations.SetValueByIndex(RastrConst.TableNodeUset, indexSkrm, vZadStart);
                }
                var delU = Math.Abs(vRasMax - vRasMin);
                var eff2 = Math.Abs(qRealMax - qRealMin) / delU;
                var eff = Math.Abs(qSkrmMax - qSkrmMin) / delU;
                if (eff2 != eff)
                {
                    eff = eff2;
                }
                if (eff>99999)
                {
                    eff = 99999;
                }
                effisency = Math.Round(eff, 3);
            }
            return effisency;
        }

    }
}
