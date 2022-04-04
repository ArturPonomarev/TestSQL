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
    public partial class DeleteDataForm : Form
    {
        private MainForm mainForm;
        private string tableName;

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
            switch(mainForm.CurrentState)
            {
                case DeleteDataStates.AUTOMOBILE_STATE:
                    IDLabel.Text = "ID авто";
                    tableName = "automobile";
                    break;
                case DeleteDataStates.ORDER_STATE:
                    IDLabel.Text = "ID заказа";
                    tableName = "orders";
                    break;
                case DeleteDataStates.CLIENT_STATE:
                    IDLabel.Text = "ID клиента";
                    tableName = "cleints";
                    break;
            }

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
                string expression;
                expression = string.Format(@"DELETE FROM " + tableName + " WHERE id = {0}",
                                Convert.ToInt32(DeleteBox.Text));

                MySqlCommand cmd = new MySqlCommand(expression,mainForm.GetDB().GetConnection());

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }

            this.Close();
        }

        #region Изменение цвета кнопки
        private void DeleteButton_MouseEnter(object sender, EventArgs e)
        {
            lastColor = DeleteButton.BackColor;
            DeleteButton.BackColor = Data.COLOR_BUTTON_ACTIVE;
        }

        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton.BackColor = lastColor;
        }
        #endregion
    }
}
