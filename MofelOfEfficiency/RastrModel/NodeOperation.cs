using ASTRALib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithRastrWin.Data.Table;

namespace WorkWithRastrWin.RastrModel
{
    public class NodeOperation
    {
        public RastrOperations ThisRastrOperations;

        public bool IsThisNodeUnManageSkrm(int index, bool ifOnNode = false, bool ifMarkNode = false)
        {
            var isThisNode = false;
            //проверка отмечен ли узел
            if (ThisRastrOperations.GetValueByIndex(RastrConst.TableNodeName, "sel", index)|| ifMarkNode)
            {
                //проверка включен ли узел
                if (!ThisRastrOperations.GetValueByIndex(RastrConst.TableNodeName, "sta", index)|| ifOnNode)
                {
                    //проверка задано ли заданное значение напряжения и нет ли генерации
                    if ((ThisRastrOperations.GetValueByIndex(RastrConst.TableNodeName, RastrConst.TableNodeUset, index) == 0) &&
                        (ThisRastrOperations.GetValueByIndex(RastrConst.TableNodeName, "pg", index) == 0))
                    {
                        //проверка задана ли проводимость
                        if (ThisRastrOperations.GetValueByIndex(RastrConst.TableNodeName, "bsh", index) != 0)
                        {
                            isThisNode = true;
                        }
                    }
                }
            }
            return isThisNode;
        }

        public bool IsThisNodeManageSkrm(int index, bool ifOnNode = false, bool ifMarkNode = false)
        {
            var isThisNode = false;
            //проверка отмечен ли узел
            if (ThisRastrOperations.GetValueByIndex(RastrConst.TableNodeName, "sel", index)|| ifMarkNode)
            {
                //проверка включен ли узел
                if (!ThisRastrOperations.GetValueByIndex(RastrConst.TableNodeName, "sta", index)|| ifOnNode)
                {
                    // TODO: корректна ли проверка отсутствия напряжения? может  быть отключен/зафиксирован
                    //проверка задано ли заданное значение напряжения и нет ли генерации
                    if ((ThisRastrOperations.GetValueByIndex(RastrConst.TableNodeName, RastrConst.TableNodeUset, index) != 0) &&
                        (ThisRastrOperations.GetValueByIndex(RastrConst.TableNodeName, "pg", index) == 0))
                    {
                        //проверка привязаны ли генераторы
                        var nodeNum = ThisRastrOperations.GetValueByIndex(RastrConst.TableNodeName, "ny", index);
                        if (!ThisRastrOperations.ExistRow("Generator", "Node=" + nodeNum))
                        {
                            //проверка заданы ли ограничения по генерации реактивной мощности
                            if ((ThisRastrOperations.GetValueByIndex(RastrConst.TableNodeName, "qmax", index) != 0) |
                                (ThisRastrOperations.GetValueByIndex(RastrConst.TableNodeName, "qmin", index) != 0))
                            {
                                isThisNode = true;
                            }
                        }
                    }
                }
            }
            return isThisNode;
        }

        public bool IsThisNodeGenerator(int index, bool ifOnNode = false, bool ifMarkNode = false)
        {
            var isThisNode = false;
            //проверка отмечен ли узел
            if (ThisRastrOperations.GetValueByIndex(RastrConst.TableNodeName, "sel", index) || ifMarkNode)
            {
                //проверка включен ли узел
                if (!ThisRastrOperations.GetValueByIndex(RastrConst.TableNodeName, "sta", index) || ifOnNode)
                {
                    //проверка задано ли заданное значение напряжения
                    if (ThisRastrOperations.GetValueByIndex(RastrConst.TableNodeName, RastrConst.TableNodeUset, index) != 0)
                    {
                        //проверка привязаны ли генераторы
                        var nodeNum = ThisRastrOperations.GetValueByIndex(RastrConst.TableNodeName, "ny", index);
                        if (ThisRastrOperations.ExistRow(RastrConst.TableGeneratorName, "Node=" + nodeNum))
                        {
                            isThisNode = true;
                        }
                    }
                }
            }
            return isThisNode;
        }

        public Node GetNodeByNum(int num)
        {
            return GetNodeByIndex(GetIndex("ny="+ num));
        }

        public List<Node> GetAllNode()
        {
            var listNode = new List<Node>();
            var countNode = GetRowCount();
            for (var index = 0; index < countNode; index++)
            {
                listNode.Add(GetNodeByIndex(index));
            }
            return listNode;
        }

        public Node GetNodeByIndex(int index)
        {
            var newNode = new Node
            {
                Mark = GetValue("sel", index),
                State = GetValue("sta", index),
                TypeOf = GetValue("tip", index),
                NodeNumder = GetValue("ny", index),
                NodeName = GetValue("name", index),
                Unom = GetValue(RastrConst.TableNodeUnom, index),
                AreaNumber = GetValue("na", index),
                Pn = GetValue("pn", index),
                Qn = GetValue("qn", index),
                Pg = GetValue("pg", index),
                Qg = GetValue("qg", index),
                Uset = GetValue(RastrConst.TableNodeUset, index),
                Qmin = GetValue(RastrConst.TableNodeQmin, index),
                Qmax = GetValue(RastrConst.TableNodeQmax, index),
                Bsh = GetValue("bsh", index),
                U = GetValue(RastrConst.TableNodeU, index)
            };
            return newNode;
        }

        public Dictionary<int, double> GetUsetDictionary()
        {
            return ThisRastrOperations.GetValueDoubleDictionary(RastrConst.TableNodeName, RastrConst.TableNodeUset); ;
        }

        public Dictionary<int, double> GetUDictionary()
        {
            return ThisRastrOperations.GetValueDoubleDictionary(RastrConst.TableNodeName, RastrConst.TableNodeU); ;
        }

        public Dictionary<int, double> GetUnomDictionary()
        {
            return ThisRastrOperations.GetValueDoubleDictionary(RastrConst.TableNodeName, RastrConst.TableNodeUnom); ;
        }

        public void MarkNode(List<int> listNode, bool clearMark = true)
        {
            //убираем отметки узлов
            if (clearMark)
            {
                ThisRastrOperations.ClearSel();
            }
            foreach (var nodeNum in listNode)
            {
                MarkNode(nodeNum);
            }
        }

        public void MarkNode(int nodeNum)
        {
            SetValueByNumber(RastrConst.TableNodeMark, nodeNum, true);
        }


        public dynamic GetValue(string columnName, int index)
        {
            return ThisRastrOperations.GetValueByIndex(RastrConst.TableNodeName, columnName, index);
        }

        public void SetValueByNumber(string columnName, int node, dynamic dataValue)
        {
            ThisRastrOperations.SetValue(RastrConst.TableNodeName, columnName, GetIndex("ny="+node), dataValue);
        }

        public void SetValueByIndex(string columnName, int index, dynamic dataValue)
        {
            ThisRastrOperations.SetValue(RastrConst.TableNodeName, columnName, index, dataValue);
        }

        public int GetIndex(string filter)
        {
            return ThisRastrOperations.GetIndex(RastrConst.TableNodeName, filter);
        }

        public int GetIndexByNode(int node)
        {
            return GetIndex("ny="+ node);
        }

        /// <summary>
        /// Вернуть информацию об узле
        /// </summary>
        /// <param name="colomnName"></param>
        /// <param name="nodeNumder"></param>
        /// <returns></returns>
        public dynamic GetValueByNumber(string colomnName, int nodeNumder)
        {
            var tableName = RastrConst.TableNodeName;
            var filter = "ny=" + nodeNumder;
            return ThisRastrOperations.GetInfoByKeyParametr(colomnName, tableName, filter);
        }

        public string GetNameByNumber( int nodeNumder)
        {
            return GetValueByNumber(RastrConst.TableNodNameNode, nodeNumder);
        }

        public double GetUByNumber(int nodeNumder)
        {
            return GetValueByNumber(RastrConst.TableNodeU, nodeNumder);
        }

        public int GetRowCount()
        {
            return ThisRastrOperations.GetRowCount(RastrConst.TableNodeName);
        }
    }
}
