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
    public partial class ClientsAddForm : Form
    {
        //Последний цвет кнопки (используется при снятии выделении с кнопки)
        private System.Drawing.Color lastColor = System.Drawing.Color.FromArgb(0, 0, 0);
        private TestSQL.MainForm m_mainForm;

        public ClientsAddForm(TestSQL.MainForm mainForm)
        {
            m_mainForm = mainForm;
            InitializeComponent();
        }
        public void InitForm()
        {
            AddButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                m_mainForm.GetDB().OpenConnection();


                m_mainForm.GetDB().CloseConnection();

                MessageBox.Show("");
            }
            catch
            {
                MessageBox.Show("Не удается установить соединение с базой данных");
            }

            this.Close();
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

        private void ClientsAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_mainForm.Enabled = true;
        }
    }
}
