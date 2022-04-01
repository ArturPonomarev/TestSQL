using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSQL.Forms
{
    public partial class OrdersAddForm : Form
    {
        //Последний цвет кнопки (используется при снятии выделении с кнопки)
        private System.Drawing.Color lastColor = System.Drawing.Color.FromArgb(0, 0, 0);

        private TestSQL.MainForm m_mainForm;

        public void InitForm()
        {
            AddButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
            
            StateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        public OrdersAddForm(TestSQL.MainForm mainForm)
        {
            this.m_mainForm = mainForm;
            InitializeComponent();
            InitForm();
        }

        private void OrdersAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_mainForm.Enabled = true;
        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            lastColor = AddButton.BackColor;
            AddButton.BackColor = Data.COLOR_BUTTON_ACTIVE;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.BackColor = lastColor;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                m_mainForm.GetDB().OpenConnection();


                m_mainForm.GetDB().CloseConnection();
            }
            catch
            {
                MessageBox.Show("Не удается установить соединение с базой данных");
            }

            this.Close();
        }
    }
}
