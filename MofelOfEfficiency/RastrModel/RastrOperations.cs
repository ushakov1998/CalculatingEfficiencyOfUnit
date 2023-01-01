using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ASTRALib;
using WorkWithRastrWin.Data.Table;

namespace WorkWithRastrWin.RastrModel
{
    /// <summary>
    ////Операции в RastrWin3
    /// </summary>
    public class RastrOperations
    {


        /// <summary>
        /// Экземпляр класса RastrWin3
        /// </summary>
        public Rastr _rastr;

        public NodeOperation ThisNodeOperations;
        public GeneratorOperation ThisGeneratorOperations;
        public VetvOperation ThisVetvOperations;

        /// <summary>
        ////Создание нового экземпляра класса Rastr
        /// </summary>
        public RastrOperations()
        {
            _rastr = new Rastr();
            ThisNodeOperations = new NodeOperation();
            ThisNodeOperations.ThisRastrOperations = this;
            ThisGeneratorOperations = new GeneratorOperation();
            ThisGeneratorOperations.ThisRastrOperations = this;
            ThisVetvOperations = new VetvOperation();
            ThisVetvOperations.ThisRastrOperations = this;
        }

        public string InitialFilePath;

        public void SaveFile(string newName)
        {
            if (InitialFilePath == null) return;
            var filePath = InitialFilePath.Replace(".rg2", " " + newName + ".rg2");
            if (newName == "")
            {
                filePath = InitialFilePath;
            }
            Save(filePath);
        }

        public void RastrLockIvent()
        {
            _rastr.LockEvent = 1;
        }

        public void RastrLogUnEnable()
        {
            _rastr.LogEnable = 0;
        }

        public void RastrUnLockIvent()
        {
            _rastr.LockEvent = 0;
        }
        public void RastrLogEnable()
        {
            _rastr.LogEnable = 1;
        }

        /// <summary>
        /// Загрузить файл формата RastrWin3
        /// </summary>
        /// <param name="files"></param>
        public void LoadReplace(params string[] files)
        {
            foreach (var file in files)
            {
                _rastr.Load(RG_KOD.RG_REPL, file,
                    FindTemplatePathWithExtension(Path.GetExtension(file)));
            }
        }

        public void LoadAdd(params string[] files)
        {
            foreach (var file in files)
            {
                _rastr.Load(RG_KOD.RG_ADD, file,
                    FindTemplatePathWithExtension(Path.GetExtension(file)));
            }
        }

        /// <summary>
        /// Сохранить 
        /// </summary>
        /// <param name="file"></param>
        public void Save(string file)
        {
            _rastr.Save(file, FindTemplatePathWithExtension(Path.GetExtension(file)));
        }

        /// <summary>
        /// Расчет режима
        /// </summary>
        /// <param name="parameter">Параметр расчета режима</param>
        /// <returns>Результат</returns>
        public bool RunRGM(string parameter = @"")
        {
            return _rastr.rgm(parameter) == RastrRetCode.AST_OK ? true : false;
        }

        public bool ExistRow(string tableName, string filter)
        {
            var isRow = false;
            if (_rastr.Tables.Find[tableName] == -1)
            {
                throw new Exception("Таблицы нет в загруженном шаблоне:" + tableName);
            }
            ITable table = _rastr.Tables.Item(tableName);
            table.SetSel(filter);
            var nysome = table.FindNextSel[-1];
            if (nysome >= 1)
            {
                isRow = true;
            }
            return isRow;
        }

        public void AddRow(string tableName)
        {
            if (_rastr.Tables.Find[tableName] == -1)
            {
                throw new Exception("Таблицы нет в загруженном шаблоне:" + tableName);
            }
            ITable table = _rastr.Tables.Item(tableName);
            table.AddRow();
        }

        public int GetIndex(string tableName, string filter)
        {
            var index = 0;
            if (_rastr.Tables.Find[tableName] == -1)
            {
                throw new Exception("Таблицы нет в загруженном шаблоне:" + tableName);
            }
            ITable table = _rastr.Tables.Item(tableName);
            table.SetSel(filter);
            var nysome = table.FindNextSel[0];
            if (nysome >= 1)
            {
                index = nysome;
            }
            return index;
        }

        public List<int> GetAllGeneratorNum()
        {
            var generatorNumList = new List<int>();
            ITable table = _rastr.Tables.Item("Generator");
            var rowCount = GetRowCount("Generator");
            for (int index = 0; index < rowCount; index++)
            {
                if (!GetValueByIndex("Generator", "sta", index))
                {
                    generatorNumList.Add(GetValueByIndex("Generator", "Num", index));
                }
            }
            return generatorNumList;
        }

        public Dictionary<int, double> GetValueDoubleDictionary(string tableName, string columnName)
        {
            var dictionaryNode = new Dictionary<int, double>();
            ITable table = _rastr.Tables.Item(tableName);
            ICol columnState = table.Cols.Item(RastrConst.TableNodeState);
            ICol columnNode = table.Cols.Item(RastrConst.TableNodeNode);
            ICol columnThis = table.Cols.Item(columnName);
            var rowCount = table.Count;
            for (int index = 0; index < rowCount; index++)
            {
                if (!columnState.Z[index])
                {
                    dictionaryNode.Add(columnNode.Z[index], (double)columnThis.Z[index]);
                }
            }
            return dictionaryNode;
        }

        /// <summary>
        /// Получить значение
        /// </summary>
        /// <param name="tableName">Имя таблицы</param>
        /// <param name="columnName">Имя колонки</param>
        /// <param name="index">Индекс элемента</param>
        /// <returns>Значение</returns>
        public dynamic GetValueByIndex(string tableName, string columnName, int index)
        {
            ITable table = _rastr.Tables.Item(tableName);
            ICol column = table.Cols.Item(columnName);
            var data = column.get_ZN(index);
            return data;
        }

        public dynamic GetValue(string tableName, string columnName, string filter)
        {
            var inCell = new object();
            ITable table = _rastr.Tables.Item(tableName);
            ICol column = table.Cols.Item(columnName);
            table.SetSel(filter);
            var nysome = table.FindNextSel[-1];
            if (nysome >= 0)
            {
                inCell = column.ZN[table.FindNextSel[-1]];
            }
            return inCell;
        }

        /// <summary>
        /// Возвращает длинну указанной таблицы
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public int GetRowCount(string tableName)
        {
            ITable table = _rastr.Tables.Item(tableName);
            return table.Count;
        }

        public object GetInfoByKeyParametr(string colomnName, string tableName, string filter)
        {
            try
            {
                var inCell = new object();
                ITable table = _rastr.Tables.Item(tableName);
                ICol column = table.Cols.Item(colomnName);
                table.SetSel(filter);
                var nysome = table.FindNextSel[-1];
                if (nysome >= 0)
                {
                    inCell = column.ZN[table.FindNextSel[-1]];
                }
                return inCell;
            }
            catch (Exception)
            {
                new Exception("Ошибка при попытке получения значения по ключевым параметрам");
                return null;
            }
        }

        public dynamic SetByNodeNumber(string colomnName, int nodeNumder, object value)
        {
            var inCell = new object();
            var tableName = "node";
            var filter = "ny=" + nodeNumder;
            ITable table = _rastr.Tables.Item(tableName);
            ICol column = table.Cols.Item(colomnName);
            table.SetSel(filter);
            var nysome = table.FindNextSel[-1];
            if (nysome >= 1)
            {
                column.ZN[table.FindNextSel[0]] = value;
            }
            return inCell;
        }

        

        public dynamic GetBySechNumber(string colomnName, string sechNumder)
        {
            var inCell = new object();
            ITable table = _rastr.Tables.Item("sechen");
            ICol column = table.Cols.Item(colomnName);
            var filter = "ns=" + sechNumder;
            table.SetSel(filter);
            var some = table.FindNextSel[-1];
            if (some >= 1)
            {
                inCell = column.ZN[table.FindNextSel[0]];
            }
            return inCell;
        }

        public dynamic GetBySechIndex(string colomnName, int sechIndex)
        {
            var trtr = _rastr.Tables.Count;
            var inCell = new object();
            ITable table = _rastr.Tables.Item("sechen");
            ICol column = table.Cols.Item(colomnName);
            inCell = column.ZN[sechIndex];
            return inCell;
        }

        /// <summary>
        /// Убрать выделение
        /// </summary>
        public void ClearSel()
        {
            ITable table = _rastr.Tables.Item("node");
            ICol column = table.Cols.Item("sel");
            column.Calc("0");
        }

        /// <summary>
        /// Отметить узлы по фильтру
        /// </summary>
        /// <param name="filterString"></param>
        public void SetSelByFilter(string filterString)
        {
            ITable table = _rastr.Tables.Item("node");
            table.SetSel(filterString);
            ICol column = table.Cols.Item("sel");
            column.Calc("1");
        }

        /// <summary>
        /// Установить значение
        /// </summary>
        /// <param name="tableName">Имя таблицы</param>
        /// <param name="columnName">Имя колонки</param>
        /// <param name="index">Индекс</param>
        /// <param name="dataValue">Значение</param>
        public void SetValue(string tableName, string columnName, int index, dynamic dataValue)
        {
            ITable table = _rastr.Tables.Item(tableName);
            ICol column = table.Cols.Item(columnName);
            column.Z[index] = dataValue;
        }

        /// <summary>
        /// Инициализация утяжеления
        /// </summary>
        /// <returns></returns>
        public bool InitLoading()
        {
            //SetValue(@"ut_common", @"iter", 0, 10000);
            return _rastr.step_ut("i") == RastrRetCode.AST_OK ? true : false;
        }

        /// <summary>
        /// Выполнить шаг утяжеления
        /// </summary>
        /// <returns></returns>
        public bool PerformStep()
        {
            return _rastr.step_ut("z") == RastrRetCode.AST_OK ? true : false;
        }

        /// <summary>
        /// Выполнить утяжеление до конца
        /// </summary>
        public void PerformSteps()
        {
            var ok = _rastr.step_ut("i");
            while (ok == RastrRetCode.AST_OK)
            {
                ok = _rastr.step_ut("z");
            }
        }

        /// <summary>
        /// Найти путь до нужного шаблона
        /// </summary>
        /// <param name="extension">Расширение</param>
        /// <returns>Путь до шаблона с расширением</returns>
        public static string FindTemplatePathWithExtension(string extension)
        {
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                                  @"\RastrWin3\SHABLON\")) return null;
            var files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\RastrWIN3\SHABLON\");
            var path = files.FirstOrDefault(filename => Path.GetExtension(filename) == extension);
            if (path != null && path.Contains("базовый режим мт"))
            {
                 path = path.Replace("базовый режим мт", "режим");
            }
            return path;
        }

        /// <summary>
        /// Получить количество строк в таблице
        /// </summary>
        /// <param name="table">Название таблицы</param>
        /// <returns>Количество строк</returns>
        public int GetCount(string table)
        {
            return _rastr.Tables.Item(table).Count;
        }

        /// <summary>
        /// Проверка нарушения PU-моделей генераторов
        /// </summary>
        /// <returns>Результат проверки</returns>
        public bool CheckPQ()
        {
            for (int i = 0; i < GetCount("node"); i++)
            {
                if (GetValueByIndex("node", "tip", i) == 3 || GetValueByIndex("node", "tip", i) == 4)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Перевести все генераторный узлы в PU-модель
        /// </summary>
        public void MakePU()
        {
            while (CheckPQ())
            {
                for (int i = 0; i < GetCount("node"); i++)
                {
                    double k = 0.01;
                    if (GetValueByIndex("node", "tip", i) == 3)
                    {
                        var Uzad = GetValueByIndex("node", RastrConst.TableNodeUset, i);
                        SetValue("node", RastrConst.TableNodeUset, i, Uzad * (1 - k));
                    }
                    if (GetValueByIndex("node", "tip", i) == 4)
                    {
                        var Uzad = GetValueByIndex("node", RastrConst.TableNodeUset, i);
                        SetValue("node", RastrConst.TableNodeUset, i, Uzad * (1 + k));
                    }
                }
                RunRGM();
            }
        }

        /// <summary>
        /// Утяжеление с контролем сохранения PU-модели всех генераторных узлов
        /// </summary>
        public void PerformPUSteps()
        {
            RunRGM();
            MakePU();
            var ok = _rastr.step_ut("i");
            while (ok == RastrRetCode.AST_OK)
            {
                int i = 0;
                ok = _rastr.step_ut("z");
                Console.WriteLine(i);
                MakePU();
                i = i + 1;
            }
        }

        public void DelNitRepeat(int num)
        {
            var listForDel = new List<int>();
            ITable table = _rastr.Tables.Item("graphikIT");
            table.SetSel("Num=" + num);
            if (table.Count > 1)
            {
                var listTemp = new List<int>();
                var rowCount = table.Count;
                for (int index = 0; index < rowCount; index++)
                {
                    ICol column = table.Cols.Item("Tc");
                    var temp = Convert.ToInt32(column.get_ZN(index));
                    if (listTemp.Contains(temp))
                    {
                        listForDel.Add(temp);
                    }
                    else
                    {
                        listTemp.Add(temp);
                    }
                }
            }
            while(listForDel.Count !=0)
            {
                var tempThis = listForDel[0];
                ITable table2 = _rastr.Tables.Item("graphikIT");
                table2.SetSel($"(Num={num})&(Tc={tempThis})");
                if (table2.Count>1)
                {
                    var index = GetIndex("graphikIT", $"(Num={num})&(Tc={tempThis})");
                    DeleteRowIndex("graphikIT", index);
                }
                listForDel.RemoveAt(0);
            }
        }

        public void RemoveNit(int num)
        {
            ITable table = _rastr.Tables.Item("graphikIT");
            while (ExistRow("graphikIT", $"Num={num}"))
            {
                var index = GetIndex("graphikIT", $"Num={num}");
                DeleteRowIndex("graphikIT", index);
            }
        }

        public void RemoveNit(int num, int temp)
        {
            ITable table = _rastr.Tables.Item("graphikIT");
            while (ExistRow("graphikIT", $"(Num={num})&(Tc={temp})"))
            {
                var index = GetIndex("graphikIT", $"(Num={num})&(Tc={temp})");
                DeleteRowIndex("graphikIT", index);
            }
        }

        public void ChangeNit(dynamic n_it, dynamic n_it_ideal)
        {
            while (ExistRow("graphikIT", $"Num={n_it}"))
            {
                ITable table = _rastr.Tables.Item("graphikIT");
                table.SetSel($"Num={n_it}");
                if (table.Count > 0)
                {
                    var index = GetIndex("graphikIT", $"Num={n_it}");
                    SetValue("graphikIT", "Num", index, n_it_ideal);
                }
            }
        }

        public void DeleteRowIndex (string tableName, int index)
        {
            ITable table = _rastr.Tables.Item(tableName);
            table.DelRow(index);
        }
                
    }
}
