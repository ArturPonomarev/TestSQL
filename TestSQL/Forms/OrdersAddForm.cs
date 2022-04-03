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

        private TestSQL.MainForm m_mainForm;

        public void InitForm()
        {
            AddButton.BackColor = Data.COLOR_BUTTON_UNACTIVE;
            
            StateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ClientBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            AutoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            StateBox.Items.AddRange(Data.OrderStates);

            try
            {
                MySqlDataAdapter adapter;

                DataTable freeClientsTable = new DataTable();
                DataTable freeAutoTable = new DataTable();

                //-----Внесение айди клиентов в список-----//
                //Запрос ФИО клиентов, статус заказа которых - не выполняется
                string expression = @"SELECT cleints.FIO FROM cleints
	                                  WHERE NOT EXISTS (SELECT orders.Cleints_id_client FROM orders 
                                                        WHERE orders.state = 'Выполняется' 
                                                          AND cleints.id = orders.Cleints_id_client)";
                adapter = new MySqlDataAdapter(expression, m_mainForm.GetDB().GetConnection());
                adapter.Fill(freeClientsTable);

                ClientBox.Items.Clear();
                for (int i = 0; i< freeClientsTable.Rows.Count; i++)
                {  
                    ClientBox.Items.Add(freeClientsTable.Rows[i][0].ToString());
                }

                //запрос МОДЕЛЕЙ и МАРОК авто, статус заказа которых = не выполняется
                expression = @"SELECT automobile.marka,automobile.model FROM automobile 
                               WHERE NOT EXISTS (SELECT orders.automobile_id_automobile FROM orders 
                                                 WHERE orders.state = 'Выполняется' 
                                                   AND automobile.id = orders.automobile_id_automobile)";
                adapter = new MySqlDataAdapter(expression, m_mainForm.GetDB().GetConnection());
                adapter.Fill(freeAutoTable);

                AutoBox.Items.Clear();
                for (int i = 0; i < freeAutoTable.Rows.Count; i++)
                {
                    AutoBox.Items.Add(freeAutoTable.Rows[i][0].ToString() + " " + freeAutoTable.Rows[i][1].ToString());
                }
                //-----------------------------------------//
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }


        }

        public OrdersAddForm(TestSQL.MainForm mainForm)
        {
            this.m_mainForm = mainForm;
            InitializeComponent();
            InitForm();
        }

        private void OrdersAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_mainForm.Enabled = true;
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
            try
            {
                MySqlCommand cmd = new MySqlCommand(@"INSERT INTO 
                        orders (price, state, automobile_id_automobile, Cleints_id_client, t_start, t_end) 
                        VALUES 
                        (@price, @state, @auto_id, @client_id, @t_start, @t_end)", m_mainForm.GetDB().GetConnection());


                //Получение айди клиентов по фио
                string expression;
                expression = string.Format("SELECT cleints.id FROM cleints WHERE cleints.FIO = '{0}'", ClientBox.SelectedItem.ToString());          
                MySqlDataAdapter adapter = new MySqlDataAdapter(expression,m_mainForm.GetDB().GetConnection());
                DataTable clients = new DataTable();
                adapter.Fill(clients);
                

                //Получение айди авто по марка модель
                string[] markaModel = AutoBox.SelectedItem.ToString().Split(' ');
                expression = string.Format(@"SELECT automobile.id FROM automobile WHERE automobile.marka = '{0}' and automobile.model = '{1}'",
                    markaModel[0], markaModel[1]);
                adapter = new MySqlDataAdapter(expression, m_mainForm.GetDB().GetConnection());
                DataTable auto = new DataTable();
                adapter.Fill(auto);


                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(PriceBox.Text));
                cmd.Parameters.AddWithValue("@state", StateBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@auto_id", Convert.ToInt32(auto.Rows[0][0]));
                cmd.Parameters.AddWithValue("@client_id", Convert.ToInt32(clients.Rows[0][0]));
                cmd.Parameters.AddWithValue("@t_start", DateTime.Parse(DataStartBox.Text));
                cmd.Parameters.AddWithValue("@t_end", DateTime.Parse(DataFinishBox.Text));

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
    }
}
