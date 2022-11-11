
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBoxFileSelection = new System.Windows.Forms.GroupBox();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.textBoxForFilePath = new System.Windows.Forms.TextBox();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.groupBoxInitialData = new System.Windows.Forms.GroupBox();
            this.buttonUploadAndCheck = new System.Windows.Forms.Button();
            this.textBoxForNodeNumber = new System.Windows.Forms.TextBox();
            this.labelNodeNumber = new System.Windows.Forms.Label();
            this.dataGridViewForResult = new System.Windows.Forms.DataGridView();
            this.nodeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatcherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deltaU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efficiency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttornCalculate = new System.Windows.Forms.Button();
            this.buttonSaveExcel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxFileSelection.SuspendLayout();
            this.groupBoxInitialData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForResult)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 663);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(733, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // groupBoxFileSelection
            // 
            this.groupBoxFileSelection.Controls.Add(this.buttonSelectFile);
            this.groupBoxFileSelection.Controls.Add(this.textBoxForFilePath);
            this.groupBoxFileSelection.Controls.Add(this.labelFilePath);
            this.groupBoxFileSelection.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.groupBoxFileSelection.Location = new System.Drawing.Point(18, 38);
            this.groupBoxFileSelection.Name = "groupBoxFileSelection";
            this.groupBoxFileSelection.Size = new System.Drawing.Size(340, 110);
            this.groupBoxFileSelection.TabIndex = 1;
            this.groupBoxFileSelection.TabStop = false;
            this.groupBoxFileSelection.Text = "Выбор файла режима";
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectFile.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.buttonSelectFile.ForeColor = System.Drawing.Color.Black;
            this.buttonSelectFile.Location = new System.Drawing.Point(248, 65);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(75, 27);
            this.buttonSelectFile.TabIndex = 2;
            this.buttonSelectFile.Text = "Выбрать";
            this.toolTip1.SetToolTip(this.buttonSelectFile, "Выбрать путь до файла режима");
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            // 
            // textBoxForFilePath
            // 
            this.textBoxForFilePath.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.textBoxForFilePath.Location = new System.Drawing.Point(120, 30);
            this.textBoxForFilePath.Name = "textBoxForFilePath";
            this.textBoxForFilePath.Size = new System.Drawing.Size(203, 23);
            this.textBoxForFilePath.TabIndex = 1;
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilePath.ForeColor = System.Drawing.Color.Black;
            this.labelFilePath.Location = new System.Drawing.Point(16, 32);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(90, 16);
            this.labelFilePath.TabIndex = 0;
            this.labelFilePath.Text = "Файл режима:";
            // 
            // groupBoxInitialData
            // 
            this.groupBoxInitialData.Controls.Add(this.buttonUploadAndCheck);
            this.groupBoxInitialData.Controls.Add(this.textBoxForNodeNumber);
            this.groupBoxInitialData.Controls.Add(this.labelNodeNumber);
            this.groupBoxInitialData.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.groupBoxInitialData.Location = new System.Drawing.Point(372, 38);
            this.groupBoxInitialData.Name = "groupBoxInitialData";
            this.groupBoxInitialData.Size = new System.Drawing.Size(349, 110);
            this.groupBoxInitialData.TabIndex = 2;
            this.groupBoxInitialData.TabStop = false;
            this.groupBoxInitialData.Text = "Исходные данные";
            // 
            // buttonUploadAndCheck
            // 
            this.buttonUploadAndCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUploadAndCheck.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.buttonUploadAndCheck.ForeColor = System.Drawing.Color.Black;
            this.buttonUploadAndCheck.Location = new System.Drawing.Point(169, 65);
            this.buttonUploadAndCheck.Name = "buttonUploadAndCheck";
            this.buttonUploadAndCheck.Size = new System.Drawing.Size(155, 27);
            this.buttonUploadAndCheck.TabIndex = 3;
            this.buttonUploadAndCheck.Text = "Загрузить и проверить";
            this.toolTip1.SetToolTip(this.buttonUploadAndCheck, "Загрузка и проверка файла режима");
            this.buttonUploadAndCheck.UseVisualStyleBackColor = true;
            // 
            // textBoxForNodeNumber
            // 
            this.textBoxForNodeNumber.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.textBoxForNodeNumber.Location = new System.Drawing.Point(121, 32);
            this.textBoxForNodeNumber.Name = "textBoxForNodeNumber";
            this.textBoxForNodeNumber.Size = new System.Drawing.Size(203, 23);
            this.textBoxForNodeNumber.TabIndex = 3;
            // 
            // labelNodeNumber
            // 
            this.labelNodeNumber.AutoSize = true;
            this.labelNodeNumber.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.labelNodeNumber.ForeColor = System.Drawing.Color.Black;
            this.labelNodeNumber.Location = new System.Drawing.Point(20, 34);
            this.labelNodeNumber.Name = "labelNodeNumber";
            this.labelNodeNumber.Size = new System.Drawing.Size(78, 16);
            this.labelNodeNumber.TabIndex = 3;
            this.labelNodeNumber.Text = "Номер узла:";
            // 
            // dataGridViewForResult
            // 
            this.dataGridViewForResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewForResult.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewForResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewForResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewForResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewForResult.ColumnHeadersHeight = 35;
            this.dataGridViewForResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewForResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nodeNumber,
            this.dispatcherName,
            this.deltaU,
            this.efficiency});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewForResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewForResult.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridViewForResult.Location = new System.Drawing.Point(18, 158);
            this.dataGridViewForResult.Name = "dataGridViewForResult";
            this.dataGridViewForResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewForResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewForResult.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.GhostWhite;
            this.dataGridViewForResult.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewForResult.RowTemplate.Height = 24;
            this.dataGridViewForResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewForResult.Size = new System.Drawing.Size(703, 314);
            this.dataGridViewForResult.TabIndex = 3;
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
            // buttornCalculate
            // 
            this.buttornCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttornCalculate.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.buttornCalculate.ForeColor = System.Drawing.Color.Black;
            this.buttornCalculate.Location = new System.Drawing.Point(566, 478);
            this.buttornCalculate.Name = "buttornCalculate";
            this.buttornCalculate.Size = new System.Drawing.Size(155, 27);
            this.buttornCalculate.TabIndex = 4;
            this.buttornCalculate.Text = "Выполнить расчет";
            this.toolTip1.SetToolTip(this.buttornCalculate, "Рассчитать эффективность СРН");
            this.buttornCalculate.UseVisualStyleBackColor = true;
            // 
            // buttonSaveExcel
            // 
            this.buttonSaveExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSaveExcel.BackgroundImage")));
            this.buttonSaveExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSaveExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveExcel.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.buttonSaveExcel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSaveExcel.Location = new System.Drawing.Point(682, 3);
            this.buttonSaveExcel.Name = "buttonSaveExcel";
            this.buttonSaveExcel.Size = new System.Drawing.Size(39, 39);
            this.buttonSaveExcel.TabIndex = 5;
            this.toolTip1.SetToolTip(this.buttonSaveExcel, "Сохранить отчет в Excel");
            this.buttonSaveExcel.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 687);
            this.Controls.Add(this.buttonSaveExcel);
            this.Controls.Add(this.buttornCalculate);
            this.Controls.Add(this.dataGridViewForResult);
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
            this.groupBoxFileSelection.ResumeLayout(false);
            this.groupBoxFileSelection.PerformLayout();
            this.groupBoxInitialData.ResumeLayout(false);
            this.groupBoxInitialData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBoxFileSelection;
        private System.Windows.Forms.GroupBox groupBoxInitialData;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.TextBox textBoxForFilePath;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.Button buttonUploadAndCheck;
        private System.Windows.Forms.TextBox textBoxForNodeNumber;
        private System.Windows.Forms.Label labelNodeNumber;
        private System.Windows.Forms.DataGridView dataGridViewForResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatcherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn deltaU;
        private System.Windows.Forms.DataGridViewTextBoxColumn efficiency;
        private System.Windows.Forms.Button buttornCalculate;
        private System.Windows.Forms.Button buttonSaveExcel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

