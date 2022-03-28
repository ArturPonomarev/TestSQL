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
    public partial class DeleteDataForm : Form
    {
        private MainForm mainForm;

        //Последний цвет кнопки (используется при снятии выделении с кнопки)
        private System.Drawing.Color lastColor = System.Drawing.Color.FromArgb(0, 0, 0);


        public DeleteDataForm(MainForm mainForm)
        {
            this.mainForm = mainForm;

            InitializeComponent();
            this.InitForm();
        }
        
        public void InitForm()
        {
            DeleteButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
        }

        private void DeleteDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
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

            this.Close();
        }

        private void DeleteButton_MouseEnter(object sender, EventArgs e)
        {
            lastColor = DeleteButton.BackColor;
            DeleteButton.BackColor = Data.COLOR_BUTTON_ACTIVE;
        }

        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton.BackColor = lastColor;
        }
    }
}
