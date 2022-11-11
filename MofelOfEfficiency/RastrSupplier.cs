using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using ASTRALib;
using System.Threading;
using System.Windows.Forms;

namespace ModelOfEfficiency
{
    /// <summary>
    /// Класс, осуществляющий взаимодействие с RastrWin3
    /// </summary>
    public abstract class RastrSupplier
    {
        /// <summary>
        /// Экземпляр класса Rastr
        /// </summary>
        public static Rastr _rastr = new Rastr();

        /// <summary>
        /// Загрузка файла в рабочую область 
        /// </summary>
        public static void LoadFile(string filePath, string shablon)
        {
            _rastr.Load(RG_KOD.RG_REPL, filePath, shablon);
        }

        /// <summary>
        /// Сохранение файла
        /// </summary>
        public static void SaveFile(string fileName, string shablon)
        {
            try //если нет лицензии, то файл не сохранится
            {
                _rastr.Save(fileName, shablon);
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
