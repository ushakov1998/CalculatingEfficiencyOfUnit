
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBoxFileSelection = new System.Windows.Forms.GroupBox();
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
            this.deltaU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efficiency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rg2OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxFileSelection.SuspendLayout();
            this.groupBoxInitialData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProtocolDataGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForResult)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-5, 752);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(751, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // groupBoxFileSelection
            // 
            this.groupBoxFileSelection.Controls.Add(this.label1);
            this.groupBoxFileSelection.Controls.Add(this.LoadRg2Button);
            this.groupBoxFileSelection.Controls.Add(this.buttonUploadAndCheck);
            this.groupBoxFileSelection.Controls.Add(this.LoadRg2TextBox);
            this.groupBoxFileSelection.Controls.Add(this.labelFilePath);
            this.groupBoxFileSelection.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.groupBoxFileSelection.Location = new System.Drawing.Point(18, 38);
            this.groupBoxFileSelection.Name = "groupBoxFileSelection";
            this.groupBoxFileSelection.Size = new System.Drawing.Size(340, 110);
            this.groupBoxFileSelection.TabIndex = 1;
            this.groupBoxFileSelection.TabStop = false;
            this.groupBoxFileSelection.Text = "Выбор файла режима";
            // 
            // LoadRg2Button
            // 
            this.LoadRg2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadRg2Button.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadRg2Button.ForeColor = System.Drawing.Color.Black;
            this.LoadRg2Button.Location = new System.Drawing.Point(14, 66);
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
            this.buttonUploadAndCheck.Location = new System.Drawing.Point(82, 66);
            this.buttonUploadAndCheck.Name = "buttonUploadAndCheck";
            this.buttonUploadAndCheck.Size = new System.Drawing.Size(136, 27);
            this.buttonUploadAndCheck.TabIndex = 3;
            this.buttonUploadAndCheck.Text = "Загрузить и проверить";
            this.toolTip1.SetToolTip(this.buttonUploadAndCheck, "Загрузка и проверка файла режима");
            this.buttonUploadAndCheck.UseVisualStyleBackColor = true;
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
            this.groupBoxInitialData.Location = new System.Drawing.Point(372, 12);
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
            this.buttonAreaSettings.Location = new System.Drawing.Point(18, 2);
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
            this.ClearProtocol.Location = new System.Drawing.Point(653, 16);
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
            this.buttonSaveExcel.Location = new System.Drawing.Point(59, 2);
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
            this.groupBox1.Location = new System.Drawing.Point(18, 487);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 259);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Расчёт";
            // 
            // ProtocolDataGrid
            // 
            this.ProtocolDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.ProtocolDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProtocolDataGrid.Location = new System.Drawing.Point(14, 56);
            this.ProtocolDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.ProtocolDataGrid.Name = "ProtocolDataGrid";
            this.ProtocolDataGrid.RowHeadersWidth = 51;
            this.ProtocolDataGrid.RowTemplate.Height = 24;
            this.ProtocolDataGrid.Size = new System.Drawing.Size(674, 188);
            this.ProtocolDataGrid.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewForResult);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(18, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 327);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат расчёта";
            // 
            // dataGridViewForResult
            // 
            this.dataGridViewForResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewForResult.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewForResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewForResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewForResult.ColumnHeadersHeight = 35;
            this.dataGridViewForResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewForResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nodeNumber,
            this.dispatcherName,
            this.deltaU,
            this.efficiency});
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewForResult.DefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridViewForResult.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridViewForResult.Location = new System.Drawing.Point(14, 24);
            this.dataGridViewForResult.Name = "dataGridViewForResult";
            this.dataGridViewForResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewForResult.RowHeadersVisible = false;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.GhostWhite;
            this.dataGridViewForResult.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridViewForResult.RowTemplate.Height = 24;
            this.dataGridViewForResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewForResult.Size = new System.Drawing.Size(674, 279);
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
            // deltaU
            // 
            this.deltaU.FillWeight = 50F;
            this.deltaU.HeaderText = "ΔU";
            this.deltaU.Name = "deltaU";
            // 
            // efficiency
            // 
            this.efficiency.HeaderText = "Эффективность";
            this.efficiency.Name = "efficiency";
            // 
            // Rg2OpenFileDialog
            // 
            this.Rg2OpenFileDialog.FileName = "Rg2OpenFileDialog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(239, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Узел найден";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 776);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nodeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatcherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn deltaU;
        private System.Windows.Forms.DataGridViewTextBoxColumn efficiency;
        private System.Windows.Forms.Button ClearProtocol;
        private System.Windows.Forms.OpenFileDialog Rg2OpenFileDialog;
        private System.Windows.Forms.Button buttonAreaSettings;
        private System.Windows.Forms.ComboBox comboBoxAreaName;
        private System.Windows.Forms.ComboBox comboBoxKPName;
        private System.Windows.Forms.Label labelKPName;
        private System.Windows.Forms.Label labelNodeNumber;
        private System.Windows.Forms.TextBox nodeNumberTextBox;
        private System.Windows.Forms.Label label1;
    }
}

