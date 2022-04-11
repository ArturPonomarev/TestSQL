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
    public partial class OrdersAddForm : Form
    {
        //Последний цвет кнопки (используется при снятии выделении с кнопки)
        private System.Drawing.Color lastColor = System.Drawing.Color.FromArgb(0, 0, 0);

        private TestSQL.MainForm mainForm;

        public void InitForm()
        {
            AddButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
            
            ClientBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            AutoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;


            DataTable freeClientsTable; //Фамилии клиентов не на заказе
            DataTable freeAutoTable; //Марки, модели авто не на заказе

            //-----Внесение айди клиентов в список-----//
            //Запрос ФИО клиентов, статус заказа которых - не выполняется

            string subExpression = @" WHERE NOT EXISTS (SELECT orders.Cleints_id_client FROM orders 
                                                    WHERE orders.state = 'Выполняется'
                                                        AND cleints.id = orders.Cleints_id_client)";

            string[] clientFields = { "FIO" };
            freeClientsTable = this.mainForm.GetDB().SelectData(Data.TABLENAME_CLIENTS, clientFields, clientFields, subExpression);

            ClientBox.Items.Clear();
            for (int i = 0; i< freeClientsTable.Rows.Count; i++)
            {  
                ClientBox.Items.Add(freeClientsTable.Rows[i][0].ToString());
            }


            subExpression = @" WHERE NOT EXISTS (SELECT orders.automobile_id_automobile FROM orders 
                                                WHERE orders.state = 'Выполняется' 
                                                AND automobile.id = orders.automobile_id_automobile)";
            string[] autoFields = { "marka", "model" };
            

            //запрос МОДЕЛЕЙ и МАРОК авто, статус заказа которых = не выполняется
            freeAutoTable = this.mainForm.GetDB().SelectData(Data.TABLENAME_AUTO, autoFields, autoFields, subExpression);


            AutoBox.Items.Clear();
            for (int i = 0; i < freeAutoTable.Rows.Count; i++)
            {
                AutoBox.Items.Add(freeAutoTable.Rows[i][0].ToString() + " " + freeAutoTable.Rows[i][1].ToString());
            }
            //-----------------------------------------//


        }

        public OrdersAddForm(TestSQL.MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            InitForm();
        }

        private void OrdersAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            int autoID = -1;
            int clientID = -1;

            try
            {
                //Получение айди клиентов по фио
                string expression;
                expression = string.Format("SELECT cleints.id FROM cleints WHERE cleints.FIO = '{0}'", ClientBox.SelectedItem.ToString());
                MySqlDataAdapter adapter = new MySqlDataAdapter(expression, mainForm.GetDB().GetConnection());
                DataTable clients = new DataTable();
                adapter.Fill(clients);
                clientID = Convert.ToInt32(clients.Rows[0][0]);

                //Получение айди авто по марка модель
                char[] separator = { ' ', };
                string[] markaModel = AutoBox.SelectedItem.ToString().Split(separator,2);
                expression = string.Format(@"SELECT automobile.id FROM automobile WHERE automobile.marka = '{0}' and automobile.model = '{1}'",
                    markaModel[0], markaModel[1]);
                adapter = new MySqlDataAdapter(expression, mainForm.GetDB().GetConnection());

                DataTable auto = new DataTable();
                
                adapter.Fill(auto);
                autoID = Convert.ToInt32(auto.Rows[0][0]);

            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }


            string[] names = { "price", "state", "automobile_id_automobile", "Cleints_id_client", "t_start"};

            object[] fields =
            {
                Convert.ToInt32(PriceBox.Text),
                Data.OrderStates[0],
                autoID,
                clientID,
                DateTime.Now,
            };

            mainForm.GetDB().AddData(names, Data.TABLENAME_ORDERS, fields);

            this.Close();
        }
    }
}
