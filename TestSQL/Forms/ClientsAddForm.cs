using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestSQL.Forms
{
    public partial class ClientsAddForm : Form
    {
        //Последний цвет кнопки (используется при снятии выделении с кнопки)
        private System.Drawing.Color lastColor = System.Drawing.Color.FromArgb(0, 0, 0);
        private TestSQL.MainForm mainForm;

        public ClientsAddForm(TestSQL.MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.InitForm();
        }

        public void InitForm()
        {
            AddButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string[] names = { "FIO", "phone_number" };
            object[] fields = { FIOBox.Text, PhoneBox.Text };

            mainForm.GetDB().AddData(names, "cleints", fields);

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
            mainForm.Enabled = true;
        }
    }
}
