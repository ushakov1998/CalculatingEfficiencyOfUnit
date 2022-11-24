using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ASTRALib;

namespace MDAWin
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

        /// <summary>
        ////Создание нового экземпляра класса Rastr
        /// </summary>
        public RastrOperations()
        {
            _rastr = new Rastr();
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
        public void LoadRepl(params string[] files)
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

        public bool IsSomeRow(string tableName, string filter)
        {
            var isRow = false;
            if(_rastr.Tables.Find[tableName] == -1)
            {
                throw new Exception("Таблицы нет в загруженом шаблоне:" + tableName);
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

        public int GetIndex(string tableName, string filter)
        {
            var index = 0;
            if (_rastr.Tables.Find[tableName] == -1)
            {
                throw new Exception("Таблицы нет в загруженом шаблоне:" + tableName);
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
                if (!GetValue("Generator", "sta", index))
                {
                    generatorNumList.Add(GetValue("Generator", "Num", index));
                }
            }
            return generatorNumList;
        }

        public List<int> GetListGeneratorNum(int nodeNumber)
        {
            var generatorNumList = new List<int>();
            ITable table = _rastr.Tables.Item("Generator");
            table.SetSel("Node=" + nodeNumber);
            if (table.Count > 1)
            {
                var rowCount = GetRowCount("Generator");
                for (int index = 0; index < rowCount; index++)
                {
                    if (GetValue("Generator", "Node", index) == nodeNumber)
                    {
                        if (!GetValue("Generator", "sta", index))
                        {
                            generatorNumList.Add(GetValue("Generator", "Num", index));
                        }
                    }
                }
            }
            else
            {
                var genNum = GetValue("Generator", "Num", table.FindNextSel[0]);
                var index = GetIndex("Generator", "Num=" + genNum.ToString());
                if (GetValue("Generator", "Node", index) == nodeNumber)
                {
                    if (!GetValue("Generator", "sta", index))
                    {
                        generatorNumList.Add(genNum);
                    }
                }
                
            }
            return generatorNumList;
        }

        /// <summary>
        /// Получить значение
        /// </summary>
        /// <param name="tableName">Имя таблицы</param>
        /// <param name="columnName">Имя колонки</param>
        /// <param name="index">Индекс элемента</param>
        /// <returns>Значение</returns>
        public dynamic GetValue(string tableName, string columnName, int index)
        {
            ITable table = _rastr.Tables.Item(tableName);
            ICol column = table.Cols.Item(columnName);
            var data = column.get_ZN(index);
            return data;
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

        /// <summary>
        /// Вернуть информацию об узле
        /// </summary>
        /// <param name="colomnName"></param>
        /// <param name="nodeNumder"></param>
        /// <returns></returns>
        public dynamic GetByNodeNumber(string colomnName,int nodeNumder)
        {
            var tableName = "node";
            var filter = "ny=" + nodeNumder;
            return GetInfoByKeyParametr(colomnName, tableName, filter);
        }

        public dynamic GetByNumNumber(string colomnName, int numNumber)
        {
            var tableName = "Generator";
            var filter = "Num=" + numNumber;
            return GetInfoByKeyParametr(colomnName, tableName, filter);
        }

        private object GetInfoByKeyParametr(string colomnName, string tableName, string filter)
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
            ICol colomn = table.Cols.Item("sel");
            colomn.Calc("0");
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
        /// <param name="value">Значение</param>
        public void SetValue(string tableName, string columnName, int index, dynamic value)
        {
            ITable table = _rastr.Tables.Item(tableName);
            ICol column = table.Cols.Item(columnName);
            column.Z[index] = value;
        }

        /// <summary>
        /// Инициализация утяжеления
        /// </summary>
        /// <returns></returns>
        public bool InitLoading()
        {
           return _rastr.step_ut("i") == RastrRetCode.AST_OK ? true : false;
        }

        /// <summary>
        ////Выполнить шаг утяжеления
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
            if(path.Contains("базовый режим мт"))
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

                            
    }
}
