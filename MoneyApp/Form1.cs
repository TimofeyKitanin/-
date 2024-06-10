using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;



namespace MoneyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int balance;
        private int rashod;
        private int dohod;
        private SQLiteConnection connection;

        private int selectedIDDohod;
        private int selectedSumaDohod;

        private int selectedIDRashod;
        private int selectedSumaRashod;

        public void FetchFinanceData()
        {
            connection = new SQLiteConnection(Database.connectionString);
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT balance, dohod, rasgod FROM finance", connection))
            {
                connection.Open();
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    balance = Convert.ToInt32(reader["balance"]);
                    dohod = Convert.ToInt32(reader["dohod"]);

                    if (!reader.IsDBNull(reader.GetOrdinal("rasgod")))
                    {
                        rashod = Convert.ToInt32(reader["rasgod"]);
                    }
                    else
                    {
                        rashod = 0;
                    }

                    balanceLb.Text = balance.ToString() + " рублей";
                    dohodLb.Text = dohod.ToString() + " рублей";
                    rashodLb.Text = rashod.ToString() + " рублей";
                }


                reader.Close();
                connection.Close();

            }
        }
        public void LoadDohodData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Database.connectionString))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT id, type, suma FROM dohodOperation", connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dohodDataGrid.DataSource = dataTable;

                        dohodDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dohodDataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);


                        dohodDataGrid.Columns[0].HeaderText = "ID";
                        dohodDataGrid.Columns[1].HeaderText = "Категория дохода";
                        dohodDataGrid.Columns[2].HeaderText = "Сумма, рублей";
                    }
                }
            }
        }

        private void DeleteDohod()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Database.connectionString))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = "DELETE FROM dohodOperation WHERE id = @selectedIDDohod";
                    cmd.Parameters.AddWithValue("@selectedIDDohod", selectedIDDohod);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void ChangeFinance()
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

                            dohod -= selectedSumaDohod;
                            balance -= selectedSumaDohod;

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
        private void Form1_Load(object sender, EventArgs e)
        {
            FetchFinanceData();
            LoadDohodData();
            LoadRashodData();
            AnalyzeDohodData();
            AnalyzeRashodData();
            VisualizeFinanceData(dataRashodPanel);
            VisualizeDohodOperationData(dataDohodPanel);
        }

        private void reloadData_Click(object sender, EventArgs e)
        {
            FetchFinanceData();
            LoadDohodData();
            LoadRashodData();
            AnalyzeDohodData();
            AnalyzeRashodData();
            VisualizeFinanceData(dataRashodPanel);
            VisualizeDohodOperationData(dataDohodPanel);
        }

        private void addDohodBtn_Click(object sender, EventArgs e)
        {
            AddDohodForm addDohodForm = new AddDohodForm();
            addDohodForm.ShowDialog();
        }

        private void dohodDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedIDDohod = Convert.ToInt32(dohodDataGrid.Rows[e.RowIndex].Cells[0].Value);
                selectedSumaDohod = Convert.ToInt32(dohodDataGrid.Rows[e.RowIndex].Cells[2].Value);

            }
        }

        private void deleteDohodBtn_Click(object sender, EventArgs e)
        {
            if (selectedIDDohod == 0)
            {
                MessageBox.Show("Выберите доход для удаления!");
            }
            else
            {
                DeleteDohod();
                ChangeFinance();
                MessageBox.Show("Доход успешно удален!");
                FetchFinanceData();
                LoadDohodData();

            }
        }

        private void LoadRashodData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Database.connectionString))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT id, type, suma FROM rashodOperation", connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        rashodDataGrid.DataSource = dataTable;

                        rashodDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        rashodDataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);


                        rashodDataGrid.Columns[0].HeaderText = "ID";
                        rashodDataGrid.Columns[1].HeaderText = "Категория расхода";
                        rashodDataGrid.Columns[2].HeaderText = "Сумма, рублей";
                    }
                }
            }
        }

        private void DeleteRashod()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Database.connectionString))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = "DELETE FROM rashodOperation WHERE id = @selectedIDRashod";
                    cmd.Parameters.AddWithValue("@selectedIDRashod", selectedIDRashod);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void ChangeFinanceRashod()
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

                            rashod -= selectedSumaRashod;
                            balance += selectedSumaRashod;

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
            AddRashodForm addRashodForm = new AddRashodForm();
            addRashodForm.ShowDialog();
        }

        private void rashodDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                selectedIDRashod = Convert.ToInt32(rashodDataGrid.Rows[e.RowIndex].Cells[0].Value);
                selectedSumaRashod = Convert.ToInt32(rashodDataGrid.Rows[e.RowIndex].Cells[2].Value);

            }
        }

        private void deleteRashodBtn_Click(object sender, EventArgs e)
        {
            if (selectedIDRashod == 0)
            {
                MessageBox.Show("Выберите расход для удаления!");
            }
            else
            {
                DeleteRashod();
                ChangeFinanceRashod();
                MessageBox.Show("Расход успешно удален!");
                FetchFinanceData();
                LoadRashodData();
            }
        }

        private void minFormBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maxFormBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void AnalyzeDohodData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Database.connectionString))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT type FROM dohodOperation", connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        var typeCounts = dataTable.AsEnumerable()
                            .GroupBy(row => row.Field<string>("type"))
                            .Select(group => new
                            {
                                Type = group.Key,
                                Count = group.Count()
                            })
                            .OrderByDescending(x => x.Count);

                        var mostCommonType = typeCounts.FirstOrDefault();

                        if (mostCommonType != null)
                        {
                            popularDohod.Text = mostCommonType.Type;
                        }
                        else
                        {
                            popularDohod.Text = "Нет данных";
                        }
                    }
                }
            }
        }

        public void AnalyzeRashodData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Database.connectionString))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT type FROM rashodOperation", connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        var typeCounts = dataTable.AsEnumerable()
                            .GroupBy(row => row.Field<string>("type"))
                            .Select(group => new
                            {
                                Type = group.Key,
                                Count = group.Count()
                            })
                            .OrderByDescending(x => x.Count);

                        var mostCommonType = typeCounts.FirstOrDefault();

                        if (mostCommonType != null)
                        {
                            popularRashod.Text = mostCommonType.Type;
                        }
                        else
                        {
                            popularRashod.Text = "Нет данных";
                        }
                    }
                }
            }
        }

        public void VisualizeFinanceData(Panel dataPanel)
        {
            using (SQLiteConnection connection = new SQLiteConnection(Database.connectionString))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT type, suma FROM rashodOperation", connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        PieChart pieChart = new PieChart();
                        pieChart.Dock = DockStyle.Fill;

                        var groupedData = dataTable.AsEnumerable()
                            .GroupBy(row => row.Field<string>("type"))
                            .Select(group => new
                            {
                                Type = group.Key,
                                Suma = group.Sum(row => row.Field<long>("suma"))
                            });

                        foreach (var item in groupedData)
                        {
                            pieChart.AddDataPoint(item.Type, (int)item.Suma);
                        }

                        dataPanel.Controls.Clear();
                        dataPanel.Controls.Add(pieChart);
                    }
                }
            }
        }

        public void VisualizeDohodOperationData(Panel dataPanel)
        {
            using (SQLiteConnection connection = new SQLiteConnection(Database.connectionString))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT type, suma FROM dohodOperation", connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        PieChart pieChart = new PieChart();
                        pieChart.Dock = DockStyle.Fill;

                        var groupedData = dataTable.AsEnumerable()
                            .GroupBy(row => row.Field<string>("type"))
                            .Select(group => new
                            {
                                Type = group.Key,
                                Suma = group.Sum(row => row.Field<long>("suma"))
                            });

                        foreach (var item in groupedData)
                        {
                            pieChart.AddDataPoint(item.Type, (int)item.Suma);
                        }

                        dataPanel.Controls.Clear();
                        dataPanel.Controls.Add(pieChart);
                    }
                }
            }
        }
    }



    public class PieChart : UserControl
    {
        private readonly List<(string Type, int Suma)> data = new List<(string Type, int Suma)>();
        private readonly Color[] colors = { Color.Blue, Color.Yellow, Color.Green, Color.Red, Color.Purple, Color.Orange, Color.Brown, Color.Pink, Color.Gray };
        private readonly Font legendFont = new Font("Arial", 8);
        private readonly int legendWidth = 100;
        private readonly int legendItemHeight = 20;
        private readonly int pieChartPadding = 20;
        private readonly StringFormat stringFormat = new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Near };

        public PieChart()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        public void AddDataPoint(string type, int suma)
        {
            data.Add((type, suma));
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            Rectangle clientRectangle = ClientRectangle;
            int chartWidth = clientRectangle.Width - legendWidth - 2 * pieChartPadding;
            int chartHeight = clientRectangle.Height - 2 * pieChartPadding;
            int legendX = chartWidth + 2 * pieChartPadding;
            int legendY = pieChartPadding;
            float centerX = chartWidth / 2f + pieChartPadding;
            float centerY = chartHeight / 2f + pieChartPadding;
            float radius = Math.Min(chartWidth, chartHeight) / 2f;

            if (data.Count == 0)
            {
                graphics.DrawString("No data", Font, Brushes.Black, clientRectangle, stringFormat);
                return;
            }

            float total = data.Sum(item => item.Suma);

            float startAngle = 0;
            for (int i = 0; i < data.Count; i++)
            {
                float sweepAngle = (float)(360 * (data[i].Suma / total));

                using (SolidBrush brush = new SolidBrush(colors[i % colors.Length]))
                {
                    graphics.FillPie(brush, pieChartPadding, pieChartPadding, chartWidth, chartHeight, startAngle, sweepAngle);
                }

                float midAngle = startAngle + sweepAngle / 2;
                float textX = (float)(centerX + radius * Math.Cos(midAngle * Math.PI / 180));
                float textY = (float)(centerY + radius * Math.Sin(midAngle * Math.PI / 180));

                string percentage = string.Format("({0:P})", data[i].Suma / total);
                graphics.DrawString(data[i].Type + " " + percentage, legendFont, Brushes.Black, textX, textY, stringFormat);

                startAngle += sweepAngle;
            }

            for (int i = 0; i < data.Count; i++)
            {
                int legendItemY = legendY + i * legendItemHeight;
                RectangleF legendRect = new RectangleF(legendX, legendItemY, legendItemHeight, legendItemHeight);
                using (SolidBrush brush = new SolidBrush(colors[i % colors.Length]))
                {
                    graphics.FillRectangle(brush, legendRect);
                }
                graphics.DrawString(data[i].Type, legendFont, Brushes.Black, legendRect.X + legendItemHeight + 5, legendRect.Y, stringFormat);
            }
        }
    }
}
