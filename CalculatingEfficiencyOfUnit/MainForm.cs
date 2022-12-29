using ModelOfEfficiency;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WorkWithRastrWin;
using WorkWithRastrWin.Data.DataForView;
using WorkWithRastrWin.Data.Table;
using WorkWithRastrWin.RastrModel;

namespace CalculatingEfficiencyOfUnit
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Путь к файлу исходного режима
        /// </summary>
        private string _rg2FileName;


        private NodeOperation newNodeOperation = new NodeOperation();
        private RastrOperations newRastrOperation = new RastrOperations();
        private EfficiencyOperation newEfficiencyOperation = new EfficiencyOperation();
             
        /// <summary>
        /// Главная форма
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            // comboBoxAreaName
            this.comboBoxAreaName.Items.AddRange(new object[] {"ОДУ Востока",
                "ОДУ Сибири"});
            buttonUploadAndCheck.Enabled = false;
            comboBoxKPName.Enabled = false;

        }


        

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataGridViewTools.CreateTableForProtocol(ProtocolDataGrid);
            /*EfficiencyOperations.Message += MessageHandler;
            EfficiencyOperations.Step += ProgressHandler;
                        */
            buttornCalculate.Enabled = false;
            labelCheckIndex.Hide();
            newNodeOperation.ThisRastrOperations = newRastrOperation;
            newEfficiencyOperation.ThisRastrOperations = newRastrOperation;
                        
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
                    newRastrOperation.LoadReplace(openFileDialog.FileName);
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
        /// Обработчик сообщений
        /// </summary>
        private void MessageHandler(object sender, EventMessageProtocol e)
        {
            this.Invoke((Action)delegate
            {
                AddMessageToDataGrid(e.MessageType, e.Message);

            });
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

        /// <summary>
        /// Вызов формы добавления КП
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAreaSettings_Click(object sender, EventArgs e)
        {
            AreaSettingsForm newForm = new AreaSettingsForm();
            newForm.Show();
        }

        /// <summary>
        /// Временная замена xml-структуре #1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAreaName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAreaName.SelectedIndex == 0)
            {
                comboBoxKPName.Items.Clear();
            }

            if (comboBoxAreaName.SelectedIndex == 1)
            {
                comboBoxKPName.Enabled = true;
                comboBoxKPName.Items.Clear();
                this.comboBoxKPName.Items.AddRange(new object[] {"ПС Юрга 500 кВ",
                "ПС 500 кВ Заря"});
            }
        }

        /// <summary>
        /// Временная замена xml-структуре #2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxKPName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAreaName.SelectedIndex == 1 & comboBoxKPName.SelectedIndex == 0)
            {
                nodeNumberTextBox.Clear();
                nodeNumberTextBox.Text = "60690352";
            }

            if (comboBoxAreaName.SelectedIndex == 1 & comboBoxKPName.SelectedIndex == 1)
            {
                nodeNumberTextBox.Clear();
                nodeNumberTextBox.Text = "60700807";
            }
                     
        }

        /// <summary>
        /// Обработка ввода номера узла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nodeNumberTextBox_KeyPess(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.KeyChar = '\0';
            }
        }

        private void nodeNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            buttonUploadAndCheck.Enabled = true;
            buttornCalculate.Enabled = PrepareForCalculation();
        }

        /// <summary>
        /// Проверка наличия узла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUploadAndCheck_Click(object sender, EventArgs e)
        {
            
            if (nodeNumberTextBox.Text != String.Empty)
            {
                try
                {
                    var data = newNodeOperation.GetNodeByNum(Convert.ToInt32(nodeNumberTextBox.Text)).NodeName;
                    
                    labelCheckIndex.Show();
                    AddMessageToDataGrid(MessageType.Info, $"Найден узел: '{data}'." );
                    
                }
                catch (Exception exeption)
                {
                    MessageBox.Show("Ошибка! Данный узел не найден в расчетной модели." +
                        "\nПопробуйте ещё раз.\n" + exeption.Message);
                }
            }

        }
        
        /// <summary>
        /// Подготовка к расчету, проверка валидности
        /// заполненных данных
        /// </summary>
        /// <returns></returns>
        bool PrepareForCalculation()
        {
            if (nodeNumberTextBox.Text != String.Empty & LoadRg2TextBox.Text != String.Empty)
                return true;
            else return false;
        }

        /// <summary>
        /// Начать расчет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttornCalculate_Click(object sender, EventArgs e)
        {
            if (nodeNumberTextBox.Text != String.Empty & LoadRg2TextBox.Text != String.Empty)
            {
                try
                {
                    var efficiency = newEfficiencyOperation.GetEfficiencyManagedSkrm(3213, 123231);
                    
                }
                catch (Exception exeption)
                {
                    MessageBox.Show("Ошибка! Данный узел не найден в расчетной модели." +
                        "\nПопробуйте ещё раз.\n" + exeption.Message);
                }
            }
            else
            {

                AddMessageToDataGrid(MessageType.Error, $"Запуск расчета невозможен. Отсуствует файл режима или номер исследуемого КП.");
            }
        }
    }
}
