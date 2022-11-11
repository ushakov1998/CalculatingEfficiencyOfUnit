using ModelOfEfficiency;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace CalculatingEfficiencyOfUnit
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Путь к файлу исходного режима
        /// </summary>
        private string _rg2FileName;
             
        /// <summary>
        /// Главная форма
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка файла режима
        /// </summary>
        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            string Rg2Filter = "Файл режима (*.rg2)|*.rg2";
            string shablon = @"C:\Users\Aleksandr\source\repos\ushakov1998\Diploma\CalculatingEfficiencyOfUnit\CalculatingEfficiencyOfUnit\Resources\режим.rg2";

            try
            {
                if (File.Exists(shablon))
                {

                    LoadInitialFile(Rg2Filter, Rg2OpenFileDialog, LoadRg2TextBox, shablon);
                    _rg2FileName = LoadRg2TextBox.Text;
                }
                else
                {
                    MessageBox.Show("Вам необходимо добавить шаблон 'режим.rg2' в папку Resources!");
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// Добавить сообщение в протокол
        /// </summary>
        public void AddMessageToDataGrid(MessageType type, string message)
        {
            switch (type)
            {
                case MessageType.Error:
                    {
                        Bitmap img = new Bitmap(@"C:\Users\Aleksandr\source\repos\ushakov1998\Diploma\CalculatingEfficiencyOfUnit\CalculatingEfficiencyOfUnit\Resources\new_close.png");
                        ProtocolDataGrid.Rows.Add(img, message);
                        break;
                    }

                case MessageType.Info:
                    {
                        Bitmap img = new Bitmap(@"C:\Users\Aleksandr\source\repos\ushakov1998\Diploma\CalculatingEfficiencyOfUnit\CalculatingEfficiencyOfUnit\Resources\info.png");
                        ProtocolDataGrid.Rows.Add(img, message);
                        break;
                    }
            }

            ProtocolDataGrid.FirstDisplayedCell = ProtocolDataGrid.Rows[ProtocolDataGrid.Rows.Count - 1].Cells[0];
            ProtocolDataGrid.CurrentCell = null;
        }


        /// <summary>
        ///  Открытие диалогового окна, выбор и загрузка файла 
        ///  и запись его пути в Текстбокс
        /// </summary>
        public void LoadInitialFile(string openFileDialogFilter, OpenFileDialog openFileDialog,
            TextBox textbox, string shablon)
        {
            openFileDialog.Filter = openFileDialogFilter;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textbox.Text = openFileDialog.FileName;
                    RastrSupplier.LoadFile(openFileDialog.FileName, shablon);
                    AddMessageToDataGrid(MessageType.Info, $"Загружен файл '{openFileDialog.FileName}'.");
                }
                catch (Exception exeption)
                {
                    textbox.Text = "";
                    MessageBox.Show("Ошибка! Вы загрузили файл неверного формата." +
                        "\nПопробуйте ещё раз.\n" + exeption.Message);
                }
            }
        }

        /// <summary>
        /// Очистить протокол
        /// </summary>
        private void ClearProtocol_Click(object sender, EventArgs e)
        {
            ProtocolDataGrid.Rows.Clear();
        }

        /// <summary>
        /// Событие, благодаря которому в протоколе нельзя выделить ни одну строку
        /// </summary>
        private void ProtocolDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            ProtocolDataGrid.ClearSelection();
        }
    }
}
