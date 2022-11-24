using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithRastrWin.Data.Table;

namespace WorkWithRastrWin.RastrModel
{
    public class VetvOperation
    {
        public RastrOperations ThisRastrOperations;

        public int GetIndex(int startNum, int endNum,int parallNum)
        {
            return ThisRastrOperations.GetIndex(RastrConst.TableVetvName, $"(ip={startNum})&(iq={endNum})&(np={parallNum})");
        }

        public void SetValueByIndex(string columnName, int index, dynamic dataValue)
        {
            ThisRastrOperations.SetValue(RastrConst.TableVetvName, columnName, index, dataValue);
        }

        public List<Vetv> GetAllVetv()
        {
            var listVetv = new List<Vetv>();
            var countNode = GetRowCount();
            for (var index = 0; index < countNode; index++)
            {
                listVetv.Add(GetVetvByIndex(index));
            }
            return listVetv;
        }

        public Vetv GetVetvByIndex(int index)
        {

            var state = true;
            if (GetValue("sta", index) == 0)
            {
                state = false;
            }
            var newVetv = new Vetv
            {
                Mark = GetValue("sel", index),
                State = state,
                TypeOf = GetValue("tip", index),
                NodeStartNumder = GetValue("ip", index),
                NodeEndNumder = GetValue("iq", index),
                ParallelNumber = GetValue("np", index),
                Name = GetValue("name", index),
                DispatchName = GetValue("dname", index),
            };
            return newVetv;
        }

        public dynamic GetValue(string columnName, int index)
        {
            return ThisRastrOperations.GetValueByIndex(RastrConst.TableVetvName, columnName, index);
        }

        public int GetRowCount()
        {
            return ThisRastrOperations.GetRowCount(RastrConst.TableVetvName);
        }

    }
}
