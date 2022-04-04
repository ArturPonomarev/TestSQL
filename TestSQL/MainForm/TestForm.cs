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

        private void GetList()
        {
            DataTable dataTable = new DataTable();

            string subExpression = "";

            switch (CurrentState)
            {
                case DeleteDataStates.AUTOMOBILE_STATE:
                    string[] autoNames =
                    {
                        "ID",
                        "Марка",
                        "Модель",
                        "Вместимость",
                        "Цвет",
                        "Гос. Номер",
                        "Тип кузова",
                        "Состояние"
                    };


                    if (SortButton2.Checked)
                        subExpression = " ORDER BY automobile.marka";
                    else if (SortButton3.Checked)
                        subExpression = " ORDER BY automobile.state";


                    dataTable = dataBase.SelectData(Data.TABLENAME_AUTO, Data.AutomobileFields, autoNames, subExpression);
                    break;

                case DeleteDataStates.ORDER_STATE:
                    string[] orderNames =
                    {
                        "ID",
                        "Цена",
                        "Состояние",
                        "ID Авто",
                        "ID Клиента",
                        "Дата-время начала",
                        "Дата-время окончания"
                    };

                    if (SortButton2.Checked)
                        subExpression = " ORDER BY orders.price";
                    else if (SortButton3.Checked)
                        subExpression = " ORDER BY orders.state";

                    dataTable = dataBase.SelectData(Data.TABLENAME_ORDERS, Data.OrderFields, orderNames, subExpression);
                    break;

                case DeleteDataStates.CLIENT_STATE:
                    string[] clientNames =
                    {
                        "ID",
                        "ФИО",
                        "Телефон"
                    };

                    if (SortButton2.Checked)
                        subExpression = " ORDER BY cleints.FIO";
                    else if (SortButton3.Checked)
                        subExpression = " ORDER BY cleints.phone_number";

                    dataTable = dataBase.SelectData(Data.TABLENAME_CLIENTS, Data.ClientsFields, clientNames, subExpression);
                    break;
            }

            MainDataGrid.DataSource = dataTable;
        }

        public DB GetDB()
        {
            return this.dataBase;
        }
        //----------------------------//
        #endregion

        #region Состояния
        public DeleteDataStates CurrentState { set; get; }

        #endregion



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

            CurrentState = DeleteDataStates.AUTOMOBILE_STATE;

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

            //добавить удалить изменить кнопки
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
            CurrentState = DeleteDataStates.AUTOMOBILE_STATE;

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
            CurrentState = DeleteDataStates.ORDER_STATE;

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
            CurrentState = DeleteDataStates.CLIENT_STATE;

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
            this.GetList();
        }

        private void SortButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.GetList();
        }

        private void SortButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.GetList();
        }
        //-----------------------------//


        //-----КНОПКИ ДОБАВЛЕНИЯ И УДАЛЕНИЯ ЗАПИСИ-----//
        private void AddDataButton_Click(object sender, EventArgs e)
        {
            switch (CurrentState)
            {
                case DeleteDataStates.AUTOMOBILE_STATE:
                    AddForm = new AutomobileAddForm(this, ManipulateDataStates.ADD_STATE);
                    break;
                case DeleteDataStates.ORDER_STATE:
                    AddForm = new TestSQL.Forms.OrdersAddForm(this);
                    break;
                case DeleteDataStates.CLIENT_STATE:
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
