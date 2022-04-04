using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;


namespace TestSQL
{
    public class DB
    {

        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=mydb");
        

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return this.connection;
        }

        public void AddData(string[] fieldNames, string tableName, object[] fieldObjects)
        {
            try
            {
                string expression = @"INSERT INTO " + tableName + " (";

                for (int i = 0; i < fieldNames.Length; ++i)
                {
                    expression += fieldNames[i];
                    if (i != fieldNames.Length - 1)
                        expression += ", ";
                }

                expression += ") VALUES (";

                for (int i = 0; i < fieldNames.Length; ++i)
                {
                    expression += "@";
                    expression += fieldNames[i];
                    if (i != fieldNames.Length - 1)
                        expression += ", ";
                }

                expression += ")";

                MySqlCommand cmd = new MySqlCommand(expression, connection);

                for (int i = 0; i < fieldObjects.Length; ++i)
                {
                    expression = "@";
                    expression += fieldNames[i];
                    cmd.Parameters.AddWithValue(expression, fieldObjects[i]);
                }

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        public DataTable SelectData(string tableName, string[] fields, string[] names, string subExpression = "")
        {
            string expression = "SELECT ";

            for (int i = 0; i<fields.Length; i++)
            {
                expression += tableName + "." + fields[i] + " AS " + "'" + names[i] + "'";

                if (i != fields.Length - 1)
                    expression += ", ";
            }

            expression += " FROM " + tableName;

            expression += subExpression;

            DataTable table = new DataTable();
            

            try
            {
                this.OpenConnection();

                MySqlDataAdapter adapter = new MySqlDataAdapter(expression,this.connection);
                adapter.Fill(table);

                this.CloseConnection();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }

            return table;
        }
    } 
}
