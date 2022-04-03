using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestSQL
{
    public partial class AutomobileAddForm : Form
    {
               

        private MainForm mainForm;

        //Последний цвет кнопки (используется при снятии выделении с кнопки)
        private System.Drawing.Color lastColor = System.Drawing.Color.FromArgb(0, 0, 0);


        private void InitForm()
        {
            MarkaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ModelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ModelBox.Enabled = false;

            KyzovBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            StateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            StateBox.Items.AddRange(Data.AutomobileStates);

            AddButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
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
            int testInt;
            if (!int.TryParse(CapacityBox.Text, out testInt))
            {
                MessageBox.Show("Поле 'Вместимость' должно быть числом");
                return;
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(@"INSERT INTO 
                        automobile (marka, model, capacity, color, number, type, state) 
                        VALUES 
                        (@marka, @model, @capacity, @color, @number, @type, @state)", mainForm.GetDB().GetConnection());

                
                cmd.Parameters.AddWithValue("@marka", MarkaBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@model", ModelBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@number", NumberBox.Text);
                cmd.Parameters.AddWithValue("@type", KyzovBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@state", StateBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@capacity", Convert.ToInt32(CapacityBox.Text));
                cmd.Parameters.AddWithValue("@color", ColorBox.Text);

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

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            lastColor = AddButton.BackColor;
            AddButton.BackColor = Data.COLOR_BUTTON_ACTIVE;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.BackColor = lastColor;
        }
    }
}
