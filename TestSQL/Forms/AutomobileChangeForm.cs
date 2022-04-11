using System;
using System.Data;
using System.Windows.Forms;

namespace TestSQL.Forms
{
    public partial class AutomobileChangeForm : Form
    {
        private int NoteID { set; get; }
        private MainForm MainForm { set; get; }

        private System.Drawing.Color lastColor = System.Drawing.Color.FromArgb(0, 0, 0);

        public AutomobileChangeForm(int ID, MainForm mainForm)
        {
            InitializeComponent();

            NoteID = ID;
            MainForm = mainForm;

            InitForm();
        }
        
        private void InitForm()
        {
            ChangeButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;

            StateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            StateBox.Items.AddRange(Data.AutomobileStates);

            string subExpression = " WHERE id = " + NoteID.ToString();

            DataTable dataTable;
            dataTable = MainForm.GetDB().SelectData(Data.TABLENAME_AUTO, Data.AutomobileFields, Data.AutomobileFields, subExpression);

            ColorBox.Text = dataTable.Rows[0][4].ToString();
            ColorLast.Text = dataTable.Rows[0][4].ToString();

            NumberBox.Text = dataTable.Rows[0][5].ToString();
            NumberLast.Text = dataTable.Rows[0][5].ToString();

            StateBox.Text = dataTable.Rows[0][7].ToString();
            StateLast.Text = dataTable.Rows[0][7].ToString();
        }


        private void ChangeButton_Click(object sender, EventArgs e)
        {
            string[] fields =
            {
                "color",
                "number",
                "state",
            };

            string[] newItems =
            {
                ColorBox.Text,
                NumberBox.Text,
                StateBox.Text,
            };

            string whereExpression = "id = " + this.NoteID.ToString();

            MainForm.GetDB().UpdateData(Data.TABLENAME_AUTO, fields, newItems, whereExpression);

            this.Close();
        }

        private void AutomobileChangeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MainForm.Enabled = true;
        }

        private void ChangeButton_MouseEnter(object sender, EventArgs e)
        {
            lastColor = ChangeButton.BackColor;
            ChangeButton.BackColor = Data.COLOR_BUTTON_ACTIVE;
        }

        private void ChangeButton_MouseLeave(object sender, EventArgs e)
        {
            ChangeButton.BackColor = lastColor;
        }
    }
}
