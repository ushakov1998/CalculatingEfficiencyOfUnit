using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatingEfficiencyOfUnit
{
    public partial class AreaSettingsForm : Form
    {
        public AreaSettingsForm()
        {
            InitializeComponent();
        }

        private void AddAreaButton_Click(object sender, EventArgs e)
        {
            AreaComboBox.Items.Add(AreaTextBox.Text);
        }

        private void buttonDeleteArea_Click(object sender, EventArgs e)
        {
            AreaComboBox.Items.Remove(AreaComboBox.SelectedItem);
        }

        private void AddKPNodeButton_Click(object sender, EventArgs e)
        {

            NodeAndNameKPComboBox.Items.Add(NameKPTextBox.Text + " Узел: " +NodeNumberTextBox.Text);
        }

       
    }
}
