using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestSQL
{
    public partial class MainForm : Form
    {
        private DB dataBase = new DB();

        private MySqlDataAdapter sqlAdapter;

        
        private void GetList()
        {
            try
            {

                dataBase.OpenConnection();
                
                sqlAdapter = new MySqlDataAdapter("SELECT * FROM `automobile`", dataBase.GetConnection());

                DataTable dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);
                MainDataGrid.DataSource = dataTable;

                dataBase.CloseConnection();
            }
            catch
            {
                MessageBox.Show("Не удается установить соединение с базой данных");
            }
        }

        public DB GetDB()
        {
            return this.dataBase;
        }
        //Способ сортировки
        private ISort m_sort = new AutomobileSort();
        //-----------------

        //Последний цвет кнопки (используется при снятии выделении с кнопки)
        private System.Drawing.Color lastColor = System.Drawing.Color.FromArgb(0, 0, 0);

        //Форма добавления записей для автомобилей
        AutomobileAddForm autoAddForm;
        //Форма удаления записи
        TestSQL.Forms.DeleteDataForm deleteDataForm;

        public void InitForm()
        {
            SortButton1.Checked = true;


            m_sort = new AutomobileSort();
            m_sort.Sort();

            //Цвет кнопок
            AutomobileMainButton.BackColor = Data.COLOR_BUTTON_ACTIVE;
            OrderMainButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
            ClientMainButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
            AddDataButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
            DeleteDataButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
            lastColor = AutomobileMainButton.BackColor;

            //Границы кнопок
                //основные кнопки
            AutomobileMainButton.FlatAppearance.BorderSize = 3;
            AutomobileMainButton.FlatAppearance.BorderColor = Color.Black;
            OrderMainButton.FlatAppearance.BorderSize = 3;
            OrderMainButton.FlatAppearance.BorderColor = Color.Black;
            ClientMainButton.FlatAppearance.BorderSize = 3;
            ClientMainButton.FlatAppearance.BorderColor = Color.Black;

                //добавить удалить кнопки
            AddDataButton.FlatAppearance.BorderSize = 2;
            AddDataButton.FlatAppearance.BorderColor = Color.Black;
            DeleteDataButton.FlatAppearance.BorderSize = 2;
            DeleteDataButton.FlatAppearance.BorderColor = Color.Black;
        }

        public MainForm()
        {
            InitializeComponent();
            
            this.InitForm();

            this.GetList();
        }

        private void SortLabel_Click(object sender, EventArgs e)
        {

        }


        //-----КЛИК ПО ВЕРХНИМ КНОПКАМ-----//
        //"Автомобили"
        private void AutomobileMainButton_Click(object sender, EventArgs e)
        {
            m_sort = new AutomobileSort();

            MainLabel.Text = Data.AUTOMOBILE_LABEL_TEXT;
            SortButton1.Text = Data.AUTOMOBILE_FIRSTCHECKBOX_TEXT;
            SortButton2.Text = Data.AUTOMOBILE_SECONDCHECKBOX_TEXT;
            SortButton3.Text = Data.AUTOMOBILE_THIRDCHECKBOX_TEXT;

            AutomobileMainButton.BackColor = Data.COLOR_BUTTON_ACTIVE;
            OrderMainButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
            ClientMainButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;

            lastColor = AutomobileMainButton.BackColor;

            //TODO обновить данные в сетке
        }
        //"Заказы"
        private void OrderMainButton_Click(object sender, EventArgs e)
        {
            m_sort = new OrderSort();

            MainLabel.Text = Data.ORDER_LABEL_TEXT;
            SortButton1.Text = Data.ORDER_FIRSTCHECKBOX_TEXT;
            SortButton2.Text = Data.ORDER_SECONDCHECKBOX_TEXT;
            SortButton3.Text = Data.ORDER_THIRDCHECKBOX_TEXT;

            AutomobileMainButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
            OrderMainButton.BackColor = Data.COLOR_BUTTON_ACTIVE;
            ClientMainButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;

            lastColor = OrderMainButton.BackColor;
            //TODO обновить данные в сетке
        }
        //"Клиенты"
        private void ClientMainButton_Click(object sender, EventArgs e)
        {
            m_sort = new ClientSort();

            MainLabel.Text = Data.CLIENT_LABEL_TEXT;
            SortButton1.Text = Data.CLIENT_FIRSTCHECKBOX_TEXT;
            SortButton2.Text = Data.CLIENT_SECONDCHECKBOX_TEXT;
            SortButton3.Text = Data.CLIENT_THIRDCHECKBOX_TEXT;

            AutomobileMainButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
            OrderMainButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
            ClientMainButton.BackColor = Data.COLOR_BUTTON_ACTIVE;

            lastColor = ClientMainButton.BackColor;
            //TODO обновить данные в сетке
        }

        private void SortButton1_CheckedChanged(object sender, EventArgs e)
        {
            m_sort.Sort();
        }

        private void SortButton2_CheckedChanged(object sender, EventArgs e)
        {
            m_sort.Sort();
        }

        private void SortButton3_CheckedChanged(object sender, EventArgs e)
        {
            m_sort.Sort();
        }

        private void AutomobileMainButton_MouseEnter(object sender, EventArgs e)
        {
            lastColor = AutomobileMainButton.BackColor;
            AutomobileMainButton.BackColor = Data.COLOR_BUTTON_SELECT;
        }

        private void AutomobileMainButton_MouseLeave(object sender, EventArgs e)
        {
            AutomobileMainButton.BackColor = lastColor;
        }

        private void OrderMainButton_MouseEnter(object sender, EventArgs e)
        {
            lastColor = OrderMainButton.BackColor;
            OrderMainButton.BackColor = Data.COLOR_BUTTON_SELECT;
        }

        private void OrderMainButton_MouseLeave(object sender, EventArgs e)
        {
            OrderMainButton.BackColor = lastColor;
        }

        private void ClientMainButton_MouseEnter(object sender, EventArgs e)
        {
            lastColor = ClientMainButton.BackColor;
            ClientMainButton.BackColor = Data.COLOR_BUTTON_SELECT;
        }

        private void ClientMainButton_MouseLeave(object sender, EventArgs e)
        {
            ClientMainButton.BackColor = lastColor;
        }

        private void AddDataButton_Click(object sender, EventArgs e)
        {
            autoAddForm = new AutomobileAddForm(this);

            this.Enabled = false;
            autoAddForm.Show();
        }

        private void AddDataButton_MouseEnter(object sender, EventArgs e)
        {
            lastColor = AddDataButton.BackColor;
            AddDataButton.BackColor = Data.COLOR_BUTTON_SELECT;
        }

        private void AddDataButton_MouseLeave(object sender, EventArgs e)
        {
            AddDataButton.BackColor = lastColor;
        }

        private void DeleteDataButton_MouseEnter(object sender, EventArgs e)
        {
            lastColor = DeleteDataButton.BackColor;
            DeleteDataButton.BackColor = Data.COLOR_BUTTON_SELECT;
        }

        private void DeleteDataButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteDataButton.BackColor = lastColor;
        }

        private void DeleteDataButton_Click(object sender, EventArgs e)
        {
            deleteDataForm = new TestSQL.Forms.DeleteDataForm(this);

            this.Enabled = false;
            deleteDataForm.Show();
        }
    }
}
