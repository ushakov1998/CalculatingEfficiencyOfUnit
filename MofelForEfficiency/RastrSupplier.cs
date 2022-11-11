using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using ASTRALib;

namespace MofelForEfficiency
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
    }
}
