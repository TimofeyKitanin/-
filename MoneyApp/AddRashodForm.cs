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
    public partial class AddRashodForm : Form
    {
        public AddRashodForm()
        {
            InitializeComponent();
        }
        private int suma;

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddRashod()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Database.connectionString))
            {
                connection.Open();
                suma = Convert.ToInt32(sumaRashodTb.Text);
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = "INSERT INTO rashodOperation (type, suma) VALUES (@type, @suma)";
                    cmd.Parameters.AddWithValue("@type", categoriaRashodCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@suma", suma);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Расход успешно добавлен!");
                }
            }
        }

        private void ChangeBalance()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Database.connectionString))
            {
                connection.Open();
                using (SQLiteCommand selectCmd = new SQLiteCommand("SELECT balance, rasgod FROM finance", connection))
                {
                    using (SQLiteDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int balance = Convert.ToInt32(reader["balance"]);
                            int rashod = Convert.ToInt32(reader["rasgod"]);

                            rashod += suma;
                            balance -= suma;

                            using (SQLiteCommand updateCmd = new SQLiteCommand(connection))
                            {
                                updateCmd.CommandText = "UPDATE finance SET rasgod = @rashod, balance = @balance";
                                updateCmd.Parameters.AddWithValue("@rashod", rashod);
                                updateCmd.Parameters.AddWithValue("@balance", balance);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }

        private void addRashodBtn_Click(object sender, EventArgs e)
        {
            AddRashod();
            ChangeBalance();
        }
    }
}
