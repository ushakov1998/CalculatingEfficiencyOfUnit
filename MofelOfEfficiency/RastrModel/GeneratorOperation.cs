using ASTRALib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithRastrWin.Data.Table;

namespace WorkWithRastrWin.RastrModel
{
    public class GeneratorOperation  
    {
        public RastrOperations ThisRastrOperations ;

        public List<int> GetAllGenerationOnStation(int genNum, bool allStation = false)
        {
            var listGenNode = new List<int>();
            var stationName1 = GetStationNameByNum(genNum, allStation);
            listGenNode.Add(genNum);
            var rowCount = GetRowCount();
            for (var index = 0; index < rowCount; index++)
            {
                var stationName2 = GetStationNameByNum(GetNumByIndex(index), allStation);
                if ((stationName1 == stationName2)
                    && (stationName1 != "нет") && (stationName2 != "нет"))
                {
                    listGenNode.Add(GetNumByIndex(index));
                }
            }
            return listGenNode.Distinct().ToList();
        }

        public string GetStationNameByNum(int genNum, bool allStation = false)
        {
            //определение названия станции
            var some = GetNameByNum(genNum);
            string generatorName;
            if (some is string)
            {
                generatorName = (string)some;
            }
            else
            {
                generatorName = "нет";
            }
            var stationName = generatorName.Split(new char[] { '_' })[0];
            if (allStation)
            {
                if (stationName.Contains("(") && stationName.Contains(")"))
                {
                    stationName = stationName.Split(new char[] { '(' })[0];
                }
            }
            return stationName;
        }

        public List<int> GetListGeneratorNumByNode(int nodeNumber)
        {
            var generatorNumList = new List<int>();
            ITable table = ThisRastrOperations._rastr.Tables.Item(RastrConst.TableGeneratorName);
            table.SetSel("Node=" + nodeNumber);
            if (table.Count > 1)
            {
                var rowCount = GetRowCount();
                for (var index = 0; index < rowCount; index++)
                {
                    if (GetValue("Node", index) == nodeNumber)
                    {
                        if (!GetValue("sta", index))
                        {
                            generatorNumList.Add(GetValue("Num", index));
                        }
                    }
                }
            }
            else
            {
                var genNum = GetValue("Num", table.FindNextSel[0]);
                var index = GetIndex("Num=" + genNum.ToString());
                if (GetValue("Node", index) == nodeNumber)
                {
                    if (!GetValue( "sta", index))
                    {
                        generatorNumList.Add(genNum);
                    }
                }

            }
            return generatorNumList;
        }

        public Generator GetGenerator(int index)
        {
            var thisNode = ThisRastrOperations.ThisNodeOperations
                .GetNodeByIndex(ThisRastrOperations.ThisNodeOperations.GetIndexByNode(GetNodeByIndex(index)));
            var genNew = new Generator
            {
                Mark = thisNode.Mark,
                State = GetValue(RastrConst.TableGenState, index),
                TypeOf = thisNode.TypeOf,
                NodeNumder = thisNode.NodeNumder,
                NodeName = thisNode.NodeName,
                Unom = thisNode.Unom,
                AreaNumber = thisNode.AreaNumber,
                Pn = thisNode.Pn,
                Qn = thisNode.Qn,
                Pg = GetValue(RastrConst.TableGenP, index),
                Qg = GetValue(RastrConst.TableGenQ, index),
                Uset = thisNode.Uset,
                Qmin = GetValue(RastrConst.TableGenQmin, index),
                Qmax = GetValue(RastrConst.TableGenQmax, index),
                Bsh = thisNode.Bsh,
                U = thisNode.U,
                GenNumder = GetNumByIndex(index)
            };
            genNew.GenName = GetNameByNum(genNew.GenNumder);
            genNew.StationName = (GetStationNameByNum(genNew.GenNumder));
            return genNew;
        }

        public int GetNodeByIndex(int index)
        {
            return (int)GetValueByIndex("Node", index);
        }

        public int GetNumByIndex(int index)
        {
            return (int)GetValueByIndex("Num", index);
        }

        public string GetNameByIndex(int index)
        {
            return GetValueByIndex("Name", index);
        }

        public dynamic GetValueByIndex(string colomnName, int index)
        {
            return ThisRastrOperations.GetValueByIndex(RastrConst.TableGeneratorName, colomnName, index);
        }

        public int GetIndexByNum(int num)
        {
            return ThisRastrOperations.GetIndex(RastrConst.TableGeneratorName, "Num="+ num);
        }

        public int GetIndex(string filter)
        {
            return ThisRastrOperations.GetIndex(RastrConst.TableGeneratorName, filter);
        }

        public int GetRowCount()
        { 
            return ThisRastrOperations.GetRowCount(RastrConst.TableGeneratorName);
        }

        public bool GetStateByNum(int numNumber)
        {
            return (bool)GetByNumber("sta", numNumber);
        }

        public int GetNodeByNum(int numNumber)
        {
            return (int)GetByNumber("Node", numNumber);
        }

        public dynamic GetNameByNum(int numNumber)
        {
            return GetByNumber("Name", numNumber);
        }

        public dynamic GetByNumber(string columnName, int numNumber)
        {
            var filter = "Num=" + numNumber;
            return GetValue(columnName,  filter);
        }

        public dynamic GetValue(string columnName, int index)
        {
            return ThisRastrOperations.GetValueByIndex(RastrConst.TableGeneratorName, columnName, index);
        }

        public dynamic GetValue(string columnName, string filter)
        {
            return ThisRastrOperations.GetValue(RastrConst.TableGeneratorName, columnName, filter);
        }

        public void SetValueByIndex(string columnName, int index, dynamic dataValue)
        {
            ThisRastrOperations.SetValue(RastrConst.TableGeneratorName, columnName, index, dataValue);
        }

    }
}
