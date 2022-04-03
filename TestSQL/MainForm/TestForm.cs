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
        #region SQL
        //-----ВСЕ СВЯЗАННОЕ С SQL-----//
        private DB dataBase = new DB();

        private MySqlDataAdapter sqlAdapter;
        
        private void GetList()
        {
            try
            {
                dataBase.OpenConnection();
                
                switch (CurrentState)
                {
                    case States.AUTOMOBILE_STATE:
                        sqlAdapter = new MySqlDataAdapter("SELECT automobile.*FROM automobile", dataBase.GetConnection());
                        break;
                    case States.ORDER_STATE:
                        sqlAdapter = new MySqlDataAdapter("SELECT orders.id, orders.price, orders.state, orders.automobile_id_automobile AS auto_id, orders.Cleints_id_client AS client_id, orders.t_start, orders.t_end FROM orders", dataBase.GetConnection());
                        break;
                    case States.CLIENT_STATE:
                        sqlAdapter = new MySqlDataAdapter("SELECT cleints.* FROM cleints", dataBase.GetConnection());
                        break;
                }

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
        //----------------------------//
        #endregion

        #region Состояния
        public States CurrentState { set; get; }

        #endregion



        //Способ сортировки
        private ISort m_sort = new AutomobileSort();
        //-----------------f

        //Последний цвет кнопки (используется при снятии выделении с кнопки)
        private System.Drawing.Color lastColor = System.Drawing.Color.FromArgb(0, 0, 0);

        //Форма добавления записей для автомобилей
        Form AddForm;

        //Форма удаления записи
        TestSQL.Forms.DeleteDataForm deleteDataForm;


        #region Инициализация
        //-----ИНИЦИАЛИЗАЦИЯ ФОРМЫ-----//
        public MainForm()
        {
            InitializeComponent();

            this.InitForm();

            this.GetList();
        }

        public void InitForm()
        {
            SortButton1.Checked = true;

            CurrentState = States.AUTOMOBILE_STATE;

            m_sort = new AutomobileSort();
            m_sort.Sort();

            //Цвет кнопок
            AutomobileMainButton.BackColor = Data.COLOR_BUTTON_ACTIVE;
            OrderMainButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
            ClientMainButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
            AddDataButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
            DeleteDataButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
            ChangeButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
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
            ChangeButton.FlatAppearance.BorderSize = 2;
            ChangeButton.FlatAppearance.BorderColor = Color.Black;
        }
        //-----------------------------// 
        #endregion


        //-----ВЕРХНИЕ КНОПКИ-----//
        //"Автомобили"
        private void AutomobileMainButton_Click(object sender, EventArgs e)
        {
            m_sort = new AutomobileSort();
            CurrentState = States.AUTOMOBILE_STATE;

            MainLabel.Text = Data.AUTOMOBILE_LABEL_TEXT;
            SortButton1.Text = Data.AUTOMOBILE_FIRSTCHECKBOX_TEXT;
            SortButton2.Text = Data.AUTOMOBILE_SECONDCHECKBOX_TEXT;
            SortButton3.Text = Data.AUTOMOBILE_THIRDCHECKBOX_TEXT;

            AutomobileMainButton.BackColor = Data.COLOR_BUTTON_ACTIVE;
            OrderMainButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
            ClientMainButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;

            lastColor = AutomobileMainButton.BackColor;

            this.GetList();
        }
        //"Заказы"
        private void OrderMainButton_Click(object sender, EventArgs e)
        {
            m_sort = new OrderSort();
            CurrentState = States.ORDER_STATE;

            MainLabel.Text = Data.ORDER_LABEL_TEXT;
            SortButton1.Text = Data.ORDER_FIRSTCHECKBOX_TEXT;
            SortButton2.Text = Data.ORDER_SECONDCHECKBOX_TEXT;
            SortButton3.Text = Data.ORDER_THIRDCHECKBOX_TEXT;

            AutomobileMainButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
            OrderMainButton.BackColor = Data.COLOR_BUTTON_ACTIVE;
            ClientMainButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;

            lastColor = OrderMainButton.BackColor;
            this.GetList();
        }
        //"Клиенты"
        private void ClientMainButton_Click(object sender, EventArgs e)
        {
            m_sort = new ClientSort();
            CurrentState = States.CLIENT_STATE;

            MainLabel.Text = Data.CLIENT_LABEL_TEXT;
            SortButton1.Text = Data.CLIENT_FIRSTCHECKBOX_TEXT;
            SortButton2.Text = Data.CLIENT_SECONDCHECKBOX_TEXT;
            SortButton3.Text = Data.CLIENT_THIRDCHECKBOX_TEXT;

            AutomobileMainButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
            OrderMainButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
            ClientMainButton.BackColor = Data.COLOR_BUTTON_ACTIVE;

            lastColor = ClientMainButton.BackColor;
            this.GetList();
        }
        //------------------------//


        //-----ЧЕКБОКСЫ СОРТИРОВКИ-----//
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
        //-----------------------------//


        //-----КНОПКИ ДОБАВЛЕНИЯ И УДАЛЕНИЯ ЗАПИСИ-----//
        private void AddDataButton_Click(object sender, EventArgs e)
        {
            switch (CurrentState)
            {
                case States.AUTOMOBILE_STATE:
                    AddForm = new AutomobileAddForm(this);
                    break;
                case States.ORDER_STATE:
                    AddForm = new TestSQL.Forms.OrdersAddForm(this);
                    break;
                case States.CLIENT_STATE:
                    AddForm = new TestSQL.Forms.ClientsAddForm(this);
                    break;
            }
            


            this.Enabled = false;
            AddForm.Show();
        }

        private void DeleteDataButton_Click(object sender, EventArgs e)
        {
            deleteDataForm = new TestSQL.Forms.DeleteDataForm(this);

            this.Enabled = false;
            deleteDataForm.Show();
        }
        //---------------------------------------------//


        #region ИЗМЕНЕНИЕ ЦВЕТА КНОПОК ПРИ НАВЕДЕНИИ
        //-----ИЗМЕНЕНИЕ ЦВЕТА КНОПОК ПРИ НАВЕДЕНИИ-----//
        //Автомобили
        private void AutomobileMainButton_MouseEnter(object sender, EventArgs e)
        {
            lastColor = AutomobileMainButton.BackColor;
            AutomobileMainButton.BackColor = Data.COLOR_BUTTON_SELECT;
        }
        private void AutomobileMainButton_MouseLeave(object sender, EventArgs e)
        {
            AutomobileMainButton.BackColor = lastColor;
        }

        //Клиенты
        private void ClientMainButton_MouseEnter(object sender, EventArgs e)
        {
            lastColor = ClientMainButton.BackColor;
            ClientMainButton.BackColor = Data.COLOR_BUTTON_SELECT;
        }
        private void ClientMainButton_MouseLeave(object sender, EventArgs e)
        {
            ClientMainButton.BackColor = lastColor;
        }

        //Заказы
        private void OrderMainButton_MouseEnter(object sender, EventArgs e)
        {
            lastColor = OrderMainButton.BackColor;
            OrderMainButton.BackColor = Data.COLOR_BUTTON_SELECT;
        }
        private void OrderMainButton_MouseLeave(object sender, EventArgs e)
        {
            OrderMainButton.BackColor = lastColor;
        }

        //Добавить запись
        private void AddDataButton_MouseEnter(object sender, EventArgs e)
        {
            lastColor = AddDataButton.BackColor;
            AddDataButton.BackColor = Data.COLOR_BUTTON_SELECT;
        }
        private void AddDataButton_MouseLeave(object sender, EventArgs e)
        {
            AddDataButton.BackColor = lastColor;
        }

        //Удалить запись
        private void DeleteDataButton_MouseEnter(object sender, EventArgs e)
        {
            lastColor = DeleteDataButton.BackColor;
            DeleteDataButton.BackColor = Data.COLOR_BUTTON_SELECT;
        }
        private void DeleteDataButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteDataButton.BackColor = lastColor;
        }

        //Изменить запись
        private void ChangeButton_MouseEnter(object sender, EventArgs e)
        {
            lastColor = ChangeButton.BackColor;
            ChangeButton.BackColor = Data.COLOR_BUTTON_SELECT;
        }
        private void ChangeButton_MouseLeave(object sender, EventArgs e)
        {
            ChangeButton.BackColor = lastColor;
        }

        //----------------------------------------------// 
        #endregion

        private void MainForm_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled.Equals(true))
            {
                this.GetList();
            }
        }

        
    }
}
