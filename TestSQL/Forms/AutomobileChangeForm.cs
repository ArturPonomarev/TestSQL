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
    public partial class AutomobileChangeForm : Form
    {
        private int NoteID { set; get; }
        MainForm MainForm { set; get; }

        public AutomobileChangeForm(int ID, MainForm mainForm)
        {
            InitializeComponent();

            NoteID = ID;
            MainForm = mainForm;

            InitForm();
        }
        
        private void InitForm()
        {
            MarkaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ModelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            KyzovBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            StateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            StateBox.Items.AddRange(Data.AutomobileStates);

            string subExpression = " WHERE id = " + NoteID.ToString();

            DataTable dataTable;
            dataTable = MainForm.GetDB().SelectData(Data.TABLENAME_AUTO, Data.AutomobileFields, Data.AutomobileFields, subExpression);

            MarkaBox.Text = dataTable.Rows[0][1].ToString();
            this.InitModels();
            ModelBox.Text = dataTable.Rows[0][2].ToString();
            CapacityBox.Text = dataTable.Rows[0][3].ToString();
            ColorBox.Text = dataTable.Rows[0][4].ToString();
            NumberBox.Text = dataTable.Rows[0][5].ToString();
            KyzovBox.Text = dataTable.Rows[0][6].ToString();
            StateBox.Text = dataTable.Rows[0][7].ToString();
        }

        private void InitModels()
        {
            ModelBox.Items.Clear();

            ModelBox.Enabled = true;

            foreach (string newItem in Data.MarkaModel[MarkaBox.SelectedItem.ToString()])
            {
                ModelBox.Items.Add(newItem);
            }
        }

        private void MarkaBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            InitModels();
        }

        private void AutomobileChangeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MainForm.Enabled = true;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            string[] newItems =
            {
                this.NoteID.ToString(),
                MarkaBox.SelectedItem.ToString(),
                ModelBox.SelectedItem.ToString(),
                CapacityBox.Text,
                ColorBox.Text,
                NumberBox.Text,
                KyzovBox.SelectedItem.ToString(),
                StateBox.Text,
            };

            string whereExpression = "id = " + this.NoteID.ToString();

            MainForm.GetDB().UpdateData(Data.TABLENAME_AUTO, Data.AutomobileFields, newItems, whereExpression);

            this.Close();
        }
    }
}
