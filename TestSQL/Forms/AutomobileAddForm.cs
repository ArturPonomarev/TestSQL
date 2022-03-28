using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSQL
{
    public partial class AutomobileAddForm : Form
    {
        private MainForm mainForm;

        private void InitForm()
        {
            MarkaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ModelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ModelBox.Enabled = false;

            KyzovBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            StateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        public AutomobileAddForm(MainForm mainForm)
        {
            InitializeComponent();
            this.InitForm();
            this.mainForm = mainForm;
        }

        private void AutomobileAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }


        private void MarkaBox_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            ModelBox.Items.Clear();

            ModelBox.Enabled = true;

            foreach (string newItem in Data.MarkaModel[MarkaBox.SelectedItem.ToString()])
            {
                ModelBox.Items.Add(newItem);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                mainForm.GetDB().OpenConnection();

                
                mainForm.GetDB().CloseConnection();
            }
            catch
            {
                MessageBox.Show("Не удается установить соединение с базой данных");
            }
        }
    }
}
