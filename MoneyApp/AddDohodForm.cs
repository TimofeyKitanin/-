using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyApp
{
    public partial class AddDohodForm : Form
    {
        public AddDohodForm()
        {
            InitializeComponent();
        }
        private int suma;
        private void AddDohod()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Database.connectionString))
            {
                connection.Open();
                suma = Convert.ToInt32(sumaDohodTb.Text);
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = "INSERT INTO dohodOperation (type, suma) VALUES (@type, @suma)";
                    cmd.Parameters.AddWithValue("@type", categoriaDohodCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@suma", suma);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Доход успешно добавлен!");
                }
            }
        }

        private void ChangeBalance()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Database.connectionString))
            {
                connection.Open();
                using (SQLiteCommand selectCmd = new SQLiteCommand("SELECT balance, dohod FROM finance", connection))
                {
                    using (SQLiteDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int balance = Convert.ToInt32(reader["balance"]);
                            int dohod = Convert.ToInt32(reader["dohod"]);

                            dohod += suma;
                            balance += suma;

                            using (SQLiteCommand updateCmd = new SQLiteCommand(connection))
                            {
                                updateCmd.CommandText = "UPDATE finance SET dohod = @dohod, balance = @balance";
                                updateCmd.Parameters.AddWithValue("@dohod", dohod);
                                updateCmd.Parameters.AddWithValue("@balance", balance);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }
        private void addDohodBtn_Click(object sender, EventArgs e)
        {
            AddDohod();
            ChangeBalance();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
