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
    public partial class OrdersChangeForm : Form
    {
        private int NoteID { set; get; }
        private MainForm MainForm { set; get; }

        private System.Drawing.Color lastColor = System.Drawing.Color.FromArgb(0, 0, 0);

        public OrdersChangeForm(int id, MainForm mainForm)
        {
            InitializeComponent();

            NoteID = id;
            MainForm = mainForm;

            this.InitForm();
        }
    
        public void InitForm()
        {
            ChangeButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;

            StateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            StateBox.Items.Add(Data.OrderStates[1]);
            StateBox.Items.Add(Data.OrderStates[2]);
            StateBox.Items.Add(Data.OrderStates[3]);

            TimeFinishBox.ShowUpDown = true;

            string subExpression = " WHERE id = " + NoteID.ToString();

            DataTable table;
            table = this.MainForm.GetDB().SelectData(Data.TABLENAME_ORDERS, Data.OrderFields, Data.OrderFields, subExpression);

            StateLast.Text = table.Rows[0][2].ToString();
            DateStartLabel.Text = table.Rows[0][5].ToString();
        }


        private void ChangeButton_Click(object sender, EventArgs e)
        {
            string[] fields =
            {
                "state",
                "t_end"
            };

            string[] values =
            {
                StateBox.SelectedItem.ToString(),
                
                @DateFinishBox.Value.Year.ToString() + "-" + 
                 DateFinishBox.Value.Month.ToString() + "-" +
                 DateFinishBox.Value.Day.ToString() + " " + 
                 TimeFinishBox.Value.TimeOfDay.ToString(), 
            };

            string whereExpression = "id = " + this.NoteID.ToString();

            this.MainForm.GetDB().UpdateData(Data.TABLENAME_ORDERS, fields, values, whereExpression);

            this.Close();
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

        private void OrdersChangeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MainForm.Enabled = true;
        }
    }
}
