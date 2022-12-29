
namespace CalculatingEfficiencyOfUnit
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBoxFileSelection = new System.Windows.Forms.GroupBox();
            this.labelCheckIndex = new System.Windows.Forms.Label();
            this.LoadRg2Button = new System.Windows.Forms.Button();
            this.buttonUploadAndCheck = new System.Windows.Forms.Button();
            this.LoadRg2TextBox = new System.Windows.Forms.TextBox();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.groupBoxInitialData = new System.Windows.Forms.GroupBox();
            this.nodeNumberTextBox = new System.Windows.Forms.TextBox();
            this.labelNodeNumber = new System.Windows.Forms.Label();
            this.comboBoxKPName = new System.Windows.Forms.ComboBox();
            this.labelKPName = new System.Windows.Forms.Label();
            this.comboBoxAreaName = new System.Windows.Forms.ComboBox();
            this.labelAreaName = new System.Windows.Forms.Label();
            this.buttornCalculate = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonStopCalculating = new System.Windows.Forms.Button();
            this.buttonAreaSettings = new System.Windows.Forms.Button();
            this.ClearProtocol = new System.Windows.Forms.Button();
            this.buttonSaveExcel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProtocolDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewForResult = new System.Windows.Forms.DataGridView();
            this.nodeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatcherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EfficiencyMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EfficiencyMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rg2OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonGeneratorOperations = new System.Windows.Forms.Button();
            this.buttonSwitchOperations = new System.Windows.Forms.Button();
            this.groupBoxFileSelection.SuspendLayout();
            this.groupBoxInitialData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProtocolDataGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForResult)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-6, 759);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(992, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            // 
            // groupBoxFileSelection
            // 
            this.groupBoxFileSelection.Controls.Add(this.labelCheckIndex);
            this.groupBoxFileSelection.Controls.Add(this.LoadRg2Button);
            this.groupBoxFileSelection.Controls.Add(this.buttonUploadAndCheck);
            this.groupBoxFileSelection.Controls.Add(this.LoadRg2TextBox);
            this.groupBoxFileSelection.Controls.Add(this.labelFilePath);
            this.groupBoxFileSelection.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.groupBoxFileSelection.Location = new System.Drawing.Point(17, 12);
            this.groupBoxFileSelection.Name = "groupBoxFileSelection";
            this.groupBoxFileSelection.Size = new System.Drawing.Size(340, 134);
            this.groupBoxFileSelection.TabIndex = 1;
            this.groupBoxFileSelection.TabStop = false;
            this.groupBoxFileSelection.Text = "Выбор файла режима";
            // 
            // labelCheckIndex
            // 
            this.labelCheckIndex.AutoSize = true;
            this.labelCheckIndex.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelCheckIndex.Location = new System.Drawing.Point(241, 94);
            this.labelCheckIndex.Name = "labelCheckIndex";
            this.labelCheckIndex.Size = new System.Drawing.Size(82, 16);
            this.labelCheckIndex.TabIndex = 4;
            this.labelCheckIndex.Text = "Узел найден";
            // 
            // LoadRg2Button
            // 
            this.LoadRg2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadRg2Button.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadRg2Button.ForeColor = System.Drawing.Color.Black;
            this.LoadRg2Button.Location = new System.Drawing.Point(155, 56);
            this.LoadRg2Button.Name = "LoadRg2Button";
            this.LoadRg2Button.Size = new System.Drawing.Size(62, 27);
            this.LoadRg2Button.TabIndex = 2;
            this.LoadRg2Button.Text = "Выбрать";
            this.toolTip1.SetToolTip(this.LoadRg2Button, "Выбрать путь до файла режима");
            this.LoadRg2Button.UseVisualStyleBackColor = true;
            this.LoadRg2Button.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // buttonUploadAndCheck
            // 
            this.buttonUploadAndCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUploadAndCheck.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUploadAndCheck.ForeColor = System.Drawing.Color.Black;
            this.buttonUploadAndCheck.Location = new System.Drawing.Point(223, 56);
            this.buttonUploadAndCheck.Name = "buttonUploadAndCheck";
            this.buttonUploadAndCheck.Size = new System.Drawing.Size(101, 27);
            this.buttonUploadAndCheck.TabIndex = 3;
            this.buttonUploadAndCheck.Text = "Проверить узел";
            this.toolTip1.SetToolTip(this.buttonUploadAndCheck, "Загрузка и проверка файла режима");
            this.buttonUploadAndCheck.UseVisualStyleBackColor = true;
            this.buttonUploadAndCheck.Click += new System.EventHandler(this.buttonUploadAndCheck_Click);
            // 
            // LoadRg2TextBox
            // 
            this.LoadRg2TextBox.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadRg2TextBox.Location = new System.Drawing.Point(120, 27);
            this.LoadRg2TextBox.Name = "LoadRg2TextBox";
            this.LoadRg2TextBox.ReadOnly = true;
            this.LoadRg2TextBox.Size = new System.Drawing.Size(203, 21);
            this.LoadRg2TextBox.TabIndex = 1;
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilePath.ForeColor = System.Drawing.Color.Black;
            this.labelFilePath.Location = new System.Drawing.Point(11, 28);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(90, 16);
            this.labelFilePath.TabIndex = 0;
            this.labelFilePath.Text = "Файл режима:";
            // 
            // groupBoxInitialData
            // 
            this.groupBoxInitialData.Controls.Add(this.nodeNumberTextBox);
            this.groupBoxInitialData.Controls.Add(this.labelNodeNumber);
            this.groupBoxInitialData.Controls.Add(this.comboBoxKPName);
            this.groupBoxInitialData.Controls.Add(this.labelKPName);
            this.groupBoxInitialData.Controls.Add(this.comboBoxAreaName);
            this.groupBoxInitialData.Controls.Add(this.labelAreaName);
            this.groupBoxInitialData.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.groupBoxInitialData.Location = new System.Drawing.Point(363, 12);
            this.groupBoxInitialData.Name = "groupBoxInitialData";
            this.groupBoxInitialData.Size = new System.Drawing.Size(349, 136);
            this.groupBoxInitialData.TabIndex = 2;
            this.groupBoxInitialData.TabStop = false;
            this.groupBoxInitialData.Text = "Исходные данные";
            // 
            // nodeNumberTextBox
            // 
            this.nodeNumberTextBox.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.nodeNumberTextBox.Location = new System.Drawing.Point(146, 91);
            this.nodeNumberTextBox.Name = "nodeNumberTextBox";
            this.nodeNumberTextBox.Size = new System.Drawing.Size(188, 21);
            this.nodeNumberTextBox.TabIndex = 8;
            this.nodeNumberTextBox.TextChanged += new System.EventHandler(this.nodeNumberTextBox_TextChanged);
            this.nodeNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nodeNumberTextBox_KeyPess);
            // 
            // labelNodeNumber
            // 
            this.labelNodeNumber.AutoSize = true;
            this.labelNodeNumber.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.labelNodeNumber.ForeColor = System.Drawing.Color.Black;
            this.labelNodeNumber.Location = new System.Drawing.Point(65, 92);
            this.labelNodeNumber.Name = "labelNodeNumber";
            this.labelNodeNumber.Size = new System.Drawing.Size(75, 16);
            this.labelNodeNumber.TabIndex = 7;
            this.labelNodeNumber.Text = "Номер узла";
            // 
            // comboBoxKPName
            // 
            this.comboBoxKPName.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxKPName.FormattingEnabled = true;
            this.comboBoxKPName.Location = new System.Drawing.Point(146, 58);
            this.comboBoxKPName.Name = "comboBoxKPName";
            this.comboBoxKPName.Size = new System.Drawing.Size(188, 21);
            this.comboBoxKPName.TabIndex = 6;
            this.comboBoxKPName.SelectedIndexChanged += new System.EventHandler(this.comboBoxKPName_SelectedIndexChanged);
            // 
            // labelKPName
            // 
            this.labelKPName.AutoSize = true;
            this.labelKPName.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.labelKPName.ForeColor = System.Drawing.Color.Black;
            this.labelKPName.Location = new System.Drawing.Point(16, 58);
            this.labelKPName.Name = "labelKPName";
            this.labelKPName.Size = new System.Drawing.Size(125, 16);
            this.labelKPName.TabIndex = 5;
            this.labelKPName.Text = "Контрольный пункт";
            // 
            // comboBoxAreaName
            // 
            this.comboBoxAreaName.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAreaName.FormattingEnabled = true;
            this.comboBoxAreaName.Location = new System.Drawing.Point(146, 23);
            this.comboBoxAreaName.Name = "comboBoxAreaName";
            this.comboBoxAreaName.Size = new System.Drawing.Size(188, 21);
            this.comboBoxAreaName.TabIndex = 4;
            this.comboBoxAreaName.SelectedIndexChanged += new System.EventHandler(this.comboBoxAreaName_SelectedIndexChanged);
            // 
            // labelAreaName
            // 
            this.labelAreaName.AutoSize = true;
            this.labelAreaName.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.labelAreaName.ForeColor = System.Drawing.Color.Black;
            this.labelAreaName.Location = new System.Drawing.Point(16, 24);
            this.labelAreaName.Name = "labelAreaName";
            this.labelAreaName.Size = new System.Drawing.Size(124, 16);
            this.labelAreaName.TabIndex = 3;
            this.labelAreaName.Text = "Операционная зона";
            // 
            // buttornCalculate
            // 
            this.buttornCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttornCalculate.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.buttornCalculate.ForeColor = System.Drawing.Color.Black;
            this.buttornCalculate.Location = new System.Drawing.Point(14, 22);
            this.buttornCalculate.Name = "buttornCalculate";
            this.buttornCalculate.Size = new System.Drawing.Size(155, 27);
            this.buttornCalculate.TabIndex = 4;
            this.buttornCalculate.Text = "Начать расчёт";
            this.toolTip1.SetToolTip(this.buttornCalculate, "Рассчитать эффективность СРН");
            this.buttornCalculate.UseVisualStyleBackColor = true;
            this.buttornCalculate.Click += new System.EventHandler(this.buttornCalculate_Click);
            // 
            // buttonStopCalculating
            // 
            this.buttonStopCalculating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopCalculating.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.buttonStopCalculating.ForeColor = System.Drawing.Color.Black;
            this.buttonStopCalculating.Location = new System.Drawing.Point(178, 22);
            this.buttonStopCalculating.Name = "buttonStopCalculating";
            this.buttonStopCalculating.Size = new System.Drawing.Size(155, 27);
            this.buttonStopCalculating.TabIndex = 6;
            this.buttonStopCalculating.Text = "Остановить расчёт";
            this.toolTip1.SetToolTip(this.buttonStopCalculating, "Остановить процесс расчета");
            this.buttonStopCalculating.UseVisualStyleBackColor = true;
            // 
            // buttonAreaSettings
            // 
            this.buttonAreaSettings.BackgroundImage = global::CalculatingEfficiencyOfUnit.Properties.Resources.free_icon_gear_1357766;
            this.buttonAreaSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAreaSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAreaSettings.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.buttonAreaSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAreaSettings.Location = new System.Drawing.Point(926, 12);
            this.buttonAreaSettings.Name = "buttonAreaSettings";
            this.buttonAreaSettings.Size = new System.Drawing.Size(35, 35);
            this.buttonAreaSettings.TabIndex = 9;
            this.toolTip1.SetToolTip(this.buttonAreaSettings, "Редактирование исходных данных");
            this.buttonAreaSettings.UseVisualStyleBackColor = true;
            this.buttonAreaSettings.Click += new System.EventHandler(this.buttonAreaSettings_Click);
            // 
            // ClearProtocol
            // 
            this.ClearProtocol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearProtocol.BackgroundImage")));
            this.ClearProtocol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClearProtocol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearProtocol.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.ClearProtocol.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearProtocol.Location = new System.Drawing.Point(906, 16);
            this.ClearProtocol.Name = "ClearProtocol";
            this.ClearProtocol.Size = new System.Drawing.Size(35, 35);
            this.ClearProtocol.TabIndex = 18;
            this.toolTip1.SetToolTip(this.ClearProtocol, "Очистить протокол");
            this.ClearProtocol.UseVisualStyleBackColor = true;
            this.ClearProtocol.Click += new System.EventHandler(this.ClearProtocol_Click);
            // 
            // buttonSaveExcel
            // 
            this.buttonSaveExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSaveExcel.BackgroundImage")));
            this.buttonSaveExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSaveExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveExcel.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.buttonSaveExcel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSaveExcel.Location = new System.Drawing.Point(926, 53);
            this.buttonSaveExcel.Name = "buttonSaveExcel";
            this.buttonSaveExcel.Size = new System.Drawing.Size(35, 35);
            this.buttonSaveExcel.TabIndex = 5;
            this.toolTip1.SetToolTip(this.buttonSaveExcel, "Сохранить отчет в Excel");
            this.buttonSaveExcel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearProtocol);
            this.groupBox1.Controls.Add(this.ProtocolDataGrid);
            this.groupBox1.Controls.Add(this.buttornCalculate);
            this.groupBox1.Controls.Add(this.buttonStopCalculating);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(17, 487);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 259);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Расчёт";
            // 
            // ProtocolDataGrid
            // 
            this.ProtocolDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProtocolDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProtocolDataGrid.Location = new System.Drawing.Point(14, 56);
            this.ProtocolDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.ProtocolDataGrid.Name = "ProtocolDataGrid";
            this.ProtocolDataGrid.RowHeadersWidth = 51;
            this.ProtocolDataGrid.RowTemplate.Height = 24;
            this.ProtocolDataGrid.Size = new System.Drawing.Size(930, 188);
            this.ProtocolDataGrid.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewForResult);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(17, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(950, 327);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат расчёта";
            // 
            // dataGridViewForResult
            // 
            this.dataGridViewForResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewForResult.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewForResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewForResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewForResult.ColumnHeadersHeight = 40;
            this.dataGridViewForResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewForResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nodeNumber,
            this.dispatcherName,
            this.EfficiencyMax,
            this.EfficiencyMin});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewForResult.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewForResult.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridViewForResult.Location = new System.Drawing.Point(10, 24);
            this.dataGridViewForResult.Name = "dataGridViewForResult";
            this.dataGridViewForResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewForResult.RowHeadersVisible = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.GhostWhite;
            this.dataGridViewForResult.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewForResult.RowTemplate.Height = 24;
            this.dataGridViewForResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewForResult.Size = new System.Drawing.Size(934, 279);
            this.dataGridViewForResult.TabIndex = 4;
            // 
            // nodeNumber
            // 
            this.nodeNumber.HeaderText = "Номер узла";
            this.nodeNumber.Name = "nodeNumber";
            // 
            // dispatcherName
            // 
            this.dispatcherName.FillWeight = 175F;
            this.dispatcherName.HeaderText = "Диспетчерское наименование";
            this.dispatcherName.Name = "dispatcherName";
            // 
            // EfficiencyMax
            // 
            this.EfficiencyMax.HeaderText = "Эффективность (Max), [МВар/кВ]";
            this.EfficiencyMax.Name = "EfficiencyMax";
            // 
            // EfficiencyMin
            // 
            this.EfficiencyMin.HeaderText = "Эффективность (Min), [МВар/кВ]";
            this.EfficiencyMin.Name = "EfficiencyMin";
            // 
            // Rg2OpenFileDialog
            // 
            this.Rg2OpenFileDialog.FileName = "Rg2OpenFileDialog";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSwitchOperations);
            this.groupBox3.Controls.Add(this.buttonGeneratorOperations);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.groupBox3.Location = new System.Drawing.Point(718, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 136);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Влияющие факторы";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(8, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(188, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Сохранять файлы режимов";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonGeneratorOperations
            // 
            this.buttonGeneratorOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeneratorOperations.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGeneratorOperations.ForeColor = System.Drawing.Color.Black;
            this.buttonGeneratorOperations.Location = new System.Drawing.Point(8, 53);
            this.buttonGeneratorOperations.Name = "buttonGeneratorOperations";
            this.buttonGeneratorOperations.Size = new System.Drawing.Size(185, 27);
            this.buttonGeneratorOperations.TabIndex = 5;
            this.buttonGeneratorOperations.Text = "Выбрать файл траектории";
            this.toolTip1.SetToolTip(this.buttonGeneratorOperations, "Загрузка и проверка файла режима");
            this.buttonGeneratorOperations.UseVisualStyleBackColor = true;
            // 
            // buttonSwitchOperations
            // 
            this.buttonSwitchOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwitchOperations.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSwitchOperations.ForeColor = System.Drawing.Color.Black;
            this.buttonSwitchOperations.Location = new System.Drawing.Point(8, 86);
            this.buttonSwitchOperations.Name = "buttonSwitchOperations";
            this.buttonSwitchOperations.Size = new System.Drawing.Size(185, 41);
            this.buttonSwitchOperations.TabIndex = 6;
            this.buttonSwitchOperations.Text = "Эксплуатационное состояние СРН";
            this.toolTip1.SetToolTip(this.buttonSwitchOperations, "Загрузка и проверка файла режима");
            this.buttonSwitchOperations.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 781);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonAreaSettings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSaveExcel);
            this.Controls.Add(this.groupBoxInitialData);
            this.Controls.Add(this.groupBoxFileSelection);
            this.Controls.Add(this.progressBar1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Автоматизация анализа режима";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxFileSelection.ResumeLayout(false);
            this.groupBoxFileSelection.PerformLayout();
            this.groupBoxInitialData.ResumeLayout(false);
            this.groupBoxInitialData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProtocolDataGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForResult)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBoxFileSelection;
        private System.Windows.Forms.GroupBox groupBoxInitialData;
        private System.Windows.Forms.Button LoadRg2Button;
        private System.Windows.Forms.TextBox LoadRg2TextBox;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.Button buttonUploadAndCheck;
        private System.Windows.Forms.Label labelAreaName;
        private System.Windows.Forms.Button buttornCalculate;
        private System.Windows.Forms.Button buttonSaveExcel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonStopCalculating;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ProtocolDataGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewForResult;
        private System.Windows.Forms.Button ClearProtocol;
        private System.Windows.Forms.OpenFileDialog Rg2OpenFileDialog;
        private System.Windows.Forms.Button buttonAreaSettings;
        private System.Windows.Forms.ComboBox comboBoxAreaName;
        private System.Windows.Forms.ComboBox comboBoxKPName;
        private System.Windows.Forms.Label labelKPName;
        private System.Windows.Forms.Label labelNodeNumber;
        private System.Windows.Forms.TextBox nodeNumberTextBox;
        private System.Windows.Forms.Label labelCheckIndex;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatcherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EfficiencyMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn EfficiencyMin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonSwitchOperations;
        private System.Windows.Forms.Button buttonGeneratorOperations;
    }
}

