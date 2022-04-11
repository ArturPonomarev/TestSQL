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
    public partial class ClientsChangeForm : Form
    {
        private int NoteID { set; get; }
        private MainForm MainForm { set; get; }

        private System.Drawing.Color lastColor = System.Drawing.Color.FromArgb(0, 0, 0);

        public ClientsChangeForm(int ID, MainForm mainForm)
        {
            InitializeComponent();

            NoteID = ID;
            MainForm = mainForm;

            InitForm();
        }

        public void InitForm()
        {
            string subExpression = " WHERE id = " + NoteID.ToString();

            DataTable dataTable;
            dataTable = MainForm.GetDB().SelectData(Data.TABLENAME_CLIENTS, Data.ClientsFields, Data.ClientsFields, subExpression);

            FIOLast.Text = dataTable.Rows[0][1].ToString();
            PhoneLast.Text = dataTable.Rows[0][2].ToString();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            string[] names =
            {
                "FIO",
                "phone_number"
            };

            string[] values =
            {
                FIOBox.Text,
                PhoneBox.Text
            };

            string whereExpression = "id = " + this.NoteID.ToString();

            this.MainForm.GetDB().UpdateData(Data.TABLENAME_CLIENTS, names, values, whereExpression);

            this.Close();
        }

        private void ClientsChangeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MainForm.Enabled = true;
        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            lastColor = ChangeButton.BackColor;
            ChangeButton.BackColor = Data.COLOR_BUTTON_ACTIVE;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            ChangeButton.BackColor = lastColor;
        }
    }
}
