
namespace CalculatingEfficiencyOfUnit
{
    partial class AreaSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxOZSelection = new System.Windows.Forms.GroupBox();
            this.AddAreaButton = new System.Windows.Forms.Button();
            this.AreaTextBox = new System.Windows.Forms.TextBox();
            this.labelSoName = new System.Windows.Forms.Label();
            this.AreaComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NodeNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddKPNodeButton = new System.Windows.Forms.Button();
            this.NameKPTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NodeAndNameKPComboBox = new System.Windows.Forms.ComboBox();
            this.buttonDeleteArea = new System.Windows.Forms.Button();
            this.buttonDeleteNameAndNode = new System.Windows.Forms.Button();
            this.groupBoxOZSelection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOZSelection
            // 
            this.groupBoxOZSelection.Controls.Add(this.AddAreaButton);
            this.groupBoxOZSelection.Controls.Add(this.AreaTextBox);
            this.groupBoxOZSelection.Controls.Add(this.labelSoName);
            this.groupBoxOZSelection.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.groupBoxOZSelection.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOZSelection.Name = "groupBoxOZSelection";
            this.groupBoxOZSelection.Size = new System.Drawing.Size(330, 95);
            this.groupBoxOZSelection.TabIndex = 2;
            this.groupBoxOZSelection.TabStop = false;
            this.groupBoxOZSelection.Text = "Добавление ОЗ";
            // 
            // AddAreaButton
            // 
            this.AddAreaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAreaButton.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAreaButton.ForeColor = System.Drawing.Color.Black;
            this.AddAreaButton.Location = new System.Drawing.Point(240, 59);
            this.AddAreaButton.Name = "AddAreaButton";
            this.AddAreaButton.Size = new System.Drawing.Size(74, 23);
            this.AddAreaButton.TabIndex = 2;
            this.AddAreaButton.Text = "Добавить";
            this.AddAreaButton.UseVisualStyleBackColor = true;
            this.AddAreaButton.Click += new System.EventHandler(this.AddAreaButton_Click);
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.AreaTextBox.Location = new System.Drawing.Point(131, 27);
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.Size = new System.Drawing.Size(183, 23);
            this.AreaTextBox.TabIndex = 1;
            // 
            // labelSoName
            // 
            this.labelSoName.AutoSize = true;
            this.labelSoName.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSoName.ForeColor = System.Drawing.Color.Black;
            this.labelSoName.Location = new System.Drawing.Point(6, 30);
            this.labelSoName.Name = "labelSoName";
            this.labelSoName.Size = new System.Drawing.Size(119, 16);
            this.labelSoName.TabIndex = 0;
            this.labelSoName.Text = "Название филиала";
            // 
            // AreaComboBox
            // 
            this.AreaComboBox.FormattingEnabled = true;
            this.AreaComboBox.Location = new System.Drawing.Point(12, 113);
            this.AreaComboBox.Name = "AreaComboBox";
            this.AreaComboBox.Size = new System.Drawing.Size(300, 21);
            this.AreaComboBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NodeNumberTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddKPNodeButton);
            this.groupBox1.Controls.Add(this.NameKPTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(348, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 95);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление контрольного пункта";
            // 
            // NodeNumberTextBox
            // 
            this.NodeNumberTextBox.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.NodeNumberTextBox.Location = new System.Drawing.Point(106, 56);
            this.NodeNumberTextBox.Name = "NodeNumberTextBox";
            this.NodeNumberTextBox.Size = new System.Drawing.Size(128, 23);
            this.NodeNumberTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер узла";
            // 
            // AddKPNodeButton
            // 
            this.AddKPNodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddKPNodeButton.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddKPNodeButton.ForeColor = System.Drawing.Color.Black;
            this.AddKPNodeButton.Location = new System.Drawing.Point(240, 56);
            this.AddKPNodeButton.Name = "AddKPNodeButton";
            this.AddKPNodeButton.Size = new System.Drawing.Size(74, 23);
            this.AddKPNodeButton.TabIndex = 2;
            this.AddKPNodeButton.Text = "Добавить";
            this.AddKPNodeButton.UseVisualStyleBackColor = true;
            this.AddKPNodeButton.Click += new System.EventHandler(this.AddKPNodeButton_Click);
            // 
            // NameKPTextBox
            // 
            this.NameKPTextBox.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.NameKPTextBox.Location = new System.Drawing.Point(106, 27);
            this.NameKPTextBox.Name = "NameKPTextBox";
            this.NameKPTextBox.Size = new System.Drawing.Size(208, 23);
            this.NameKPTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название КП";
            // 
            // NodeAndNameKPComboBox
            // 
            this.NodeAndNameKPComboBox.FormattingEnabled = true;
            this.NodeAndNameKPComboBox.Location = new System.Drawing.Point(348, 113);
            this.NodeAndNameKPComboBox.Name = "NodeAndNameKPComboBox";
            this.NodeAndNameKPComboBox.Size = new System.Drawing.Size(300, 21);
            this.NodeAndNameKPComboBox.TabIndex = 4;
            // 
            // buttonDeleteArea
            // 
            this.buttonDeleteArea.BackgroundImage = global::CalculatingEfficiencyOfUnit.Properties.Resources.free_icon_bin_484662;
            this.buttonDeleteArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDeleteArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteArea.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.buttonDeleteArea.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDeleteArea.Location = new System.Drawing.Point(318, 113);
            this.buttonDeleteArea.Name = "buttonDeleteArea";
            this.buttonDeleteArea.Size = new System.Drawing.Size(18, 19);
            this.buttonDeleteArea.TabIndex = 6;
            this.buttonDeleteArea.UseVisualStyleBackColor = true;
            this.buttonDeleteArea.Click += new System.EventHandler(this.buttonDeleteArea_Click);
            // 
            // buttonDeleteNameAndNode
            // 
            this.buttonDeleteNameAndNode.BackgroundImage = global::CalculatingEfficiencyOfUnit.Properties.Resources.free_icon_bin_484662;
            this.buttonDeleteNameAndNode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDeleteNameAndNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteNameAndNode.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.buttonDeleteNameAndNode.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDeleteNameAndNode.Location = new System.Drawing.Point(654, 113);
            this.buttonDeleteNameAndNode.Name = "buttonDeleteNameAndNode";
            this.buttonDeleteNameAndNode.Size = new System.Drawing.Size(18, 19);
            this.buttonDeleteNameAndNode.TabIndex = 7;
            this.buttonDeleteNameAndNode.UseVisualStyleBackColor = true;
            // 
            // AreaSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 149);
            this.Controls.Add(this.buttonDeleteNameAndNode);
            this.Controls.Add(this.buttonDeleteArea);
            this.Controls.Add(this.NodeAndNameKPComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AreaComboBox);
            this.Controls.Add(this.groupBoxOZSelection);
            this.Name = "AreaSettingsForm";
            this.Text = "Добавление исходных данных";
            this.groupBoxOZSelection.ResumeLayout(false);
            this.groupBoxOZSelection.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOZSelection;
        private System.Windows.Forms.Button AddAreaButton;
        private System.Windows.Forms.TextBox AreaTextBox;
        private System.Windows.Forms.Label labelSoName;
        private System.Windows.Forms.ComboBox AreaComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddKPNodeButton;
        private System.Windows.Forms.TextBox NameKPTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NodeAndNameKPComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NodeNumberTextBox;
        private System.Windows.Forms.Button buttonDeleteArea;
        private System.Windows.Forms.Button buttonDeleteNameAndNode;
    }
}