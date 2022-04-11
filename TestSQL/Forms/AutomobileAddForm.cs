using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace TestSQL
{
    public partial class AutomobileAddForm : Form
    {
        public ManipulateDataStates DataState { set; get; }       

        private MainForm mainForm;

        //Последний цвет кнопки (используется при снятии выделении с кнопки)
        private System.Drawing.Color lastColor = System.Drawing.Color.FromArgb(0, 0, 0);


        private void InitForm()
        {
            MarkaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ModelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        
            KyzovBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            StateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            MarkaBox.Items.AddRange(Data.nameAutos);

            StateBox.Items.AddRange(Data.AutomobileStates);

            AddButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;

            ModelBox.Enabled = false;
        
        }

        public AutomobileAddForm(MainForm mainForm, ManipulateDataStates dataState)
        {
            InitializeComponent();
            this.DataState = dataState;
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

            string[] names = { "marka", "model", "capacity", "color", "number", "type", "state" };
            object[] fields = { 
                MarkaBox.SelectedItem.ToString(),
                ModelBox.SelectedItem.ToString(),
                Convert.ToInt32(CapacityBox.Text),
                ColorBox.Text,
                NumberBox.Text,
                KyzovBox.SelectedItem.ToString(),
                StateBox.SelectedItem.ToString()                
            };

            mainForm.GetDB().AddData(names, "automobile", fields);      

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
