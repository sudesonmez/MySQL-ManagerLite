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


namespace baharfinalsudesonmez
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server= localhost;Uid = root; Pwd='';";

        public Form1()
        {
            InitializeComponent();
            LoadDatabases();

        }
        private void LoadDatabases()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new MySqlCommand("SHOW DATABASES;", connection);
                    using (var reader = command.ExecuteReader()) //veritabanı 
                    {
                        while (reader.Read())
                        {
                            listBox1.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            dataGridView1.DataSource = null;
            string selectedDatabase = listBox1.SelectedItem.ToString();
            LoadTables(selectedDatabase);
        }
        private void LoadTables(string database)
        {
            try
            { //bağlantı nesnesi oluşturmasını sağlıyor
                using (var connection = new MySqlConnection($"{connectionString}database={database};"))
                {
                    connection.Open();
                    var command = new MySqlCommand("SHOW TABLES;", connection);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBox2.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDatabase = listBox1.SelectedItem.ToString();
            string selectedTable = listBox2.SelectedItem.ToString();
            LoadTableData(selectedDatabase, selectedTable);

        }
        private void LoadTableData(string database, string table)
        {
            try
            {
                using (var connection = new MySqlConnection($"{connectionString}database={database};"))
                {
                    connection.Open();
                    var command = new MySqlCommand($"SELECT * FROM {table};", connection);
                    var adapter = new MySqlDataAdapter(command);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cdatabase_Click(object sender, EventArgs e)
        {
            string newDatabaseName = create_database.Text;
            if (string.IsNullOrWhiteSpace(newDatabaseName))
            {
                MessageBox.Show("Please enter a valid database name.");
                return;
            }

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new MySqlCommand($"CREATE DATABASE {newDatabaseName};", connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Database created successfully.");
                    listBox1.Items.Clear();
                    LoadDatabases(); //veritabanını ekranda gösterir

                    // Textbox'ları temizle
                    create_database.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void ctable_Click(object sender, EventArgs e)
        {
            string selectedDatabase = listBox1.SelectedItem.ToString();
            string newTableName = create_table.Text;
            if (string.IsNullOrWhiteSpace(newTableName))
            {
                MessageBox.Show("Please enter a valid table name.");
                return;
            }

            try
            {
                using (var connection = new MySqlConnection($"{connectionString}database={selectedDatabase};"))
                {
                    connection.Open();
                    var command = new MySqlCommand($"CREATE TABLE {newTableName} (ID INT PRIMARY KEY AUTO_INCREMENT);", connection);
                    command.ExecuteNonQuery(); 
                    MessageBox.Show("Table created successfully.");
                    listBox2.Items.Clear();
                    LoadTables(selectedDatabase);

                    // Textbox'ları temizle
                    create_table.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void add_Click(object sender, EventArgs e)
        {
            string selectedDatabase = listBox1.SelectedItem.ToString();
            string selectedTable = listBox2.SelectedItem.ToString();
            string newColumnName = add_column.Text;
            if (string.IsNullOrWhiteSpace(newColumnName))
            {
                MessageBox.Show("Please enter a valid column name.");
                return;
            }

            try
            {
                using (var connection = new MySqlConnection($"{connectionString}database={selectedDatabase};"))
                {
                    connection.Open();
                    var command = new MySqlCommand($"ALTER TABLE {selectedTable} ADD COLUMN {newColumnName} VARCHAR(255);", connection); 
                   // Bu satır, MySQL veritabanında belirtilen tabloya yeni bir sütun eklemek için kullanılan bir SQL komutunu hazırlar


                    command.ExecuteNonQuery();
                    MessageBox.Show("Column added successfully.");
                    LoadTableData(selectedDatabase, selectedTable);

                    // Textbox'ları temizle
                    add_column.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a database.");
                return;
            }

            if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a table.");
                return;
            }

            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a cell to update.");
                return;
            }

            string selectedDatabase = listBox1.SelectedItem.ToString();
            string selectedTable = listBox2.SelectedItem.ToString();
            string newValue = update_cell.Text;
            var cell = dataGridView1.SelectedCells[0];
            int rowIndex = cell.RowIndex;
            int columnIndex = cell.ColumnIndex;
            string columnName = dataGridView1.Columns[columnIndex].Name;

            if (columnName == "ID")
            {
                MessageBox.Show("ID column cannot be updated.");
                return;
            }

            // Debugging: Show which cell is being updated
            MessageBox.Show($"Updating row {rowIndex}, column {columnName} with value {newValue}");

            try
            {
                using (var connection = new MySqlConnection($"{connectionString}database={selectedDatabase};"))
                {
                    connection.Open();
                    var command = new MySqlCommand($"UPDATE {selectedTable} SET {columnName} = @value WHERE ID = @id;", connection);
                    command.Parameters.AddWithValue("@value", newValue);
                    command.Parameters.AddWithValue("@id", dataGridView1.Rows[rowIndex].Cells["ID"].Value);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cell updated successfully.");
                    LoadTableData(selectedDatabase, selectedTable);
                    update_cell.Text = "";

                    // New lines to focus on the last row after updating
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
                    dataGridView1.BeginEdit(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void cleartable_Click(object sender, EventArgs e)
        {
            string selectedDatabase = listBox1.SelectedItem.ToString();
            string selectedTable = listBox2.SelectedItem.ToString();

            try
            {
                using (var connection = new MySqlConnection($"{connectionString}database={selectedDatabase};"))
                {
                    connection.Open();
                    var command = new MySqlCommand($"TRUNCATE TABLE {selectedTable};", connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Table cleared successfully.");
                    LoadTableData(selectedDatabase, selectedTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void clearcell_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                var cell = dataGridView1.SelectedCells[0];
                int rowIndex = cell.RowIndex;
                int columnIndex = cell.ColumnIndex;
                string columnName = dataGridView1.Columns[columnIndex].Name;

                try
                {
                    string selectedDatabase = listBox1.SelectedItem.ToString();
                    string selectedTable = listBox2.SelectedItem.ToString();
                    using (var connection = new MySqlConnection($"{connectionString}database={selectedDatabase};"))
                    {
                        connection.Open();
                        var command = new MySqlCommand($"UPDATE {selectedTable} SET {columnName} = NULL WHERE ID = @id;", connection);
                        command.Parameters.AddWithValue("@id", dataGridView1.Rows[rowIndex].Cells["ID"].Value);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Cell cleared successfully.");
                        LoadTableData(selectedDatabase, selectedTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a cell to clear.");
            }

        }

        private void addnewrow_Click(object sender, EventArgs e)
        {
            string selectedDatabase = listBox1.SelectedItem.ToString();
            string selectedTable = listBox2.SelectedItem.ToString();

            try
            {
                using (var connection = new MySqlConnection($"{connectionString}database={selectedDatabase};"))
                {
                    connection.Open();
                    var command = new MySqlCommand($"INSERT INTO {selectedTable} () VALUES ();", connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("New row added successfully.");
                    LoadTableData(selectedDatabase, selectedTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void deletecrow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                var cell = dataGridView1.SelectedCells[0];
                int rowIndex = cell.RowIndex;

                try
                {
                    string selectedDatabase = listBox1.SelectedItem.ToString();
                    string selectedTable = listBox2.SelectedItem.ToString();
                    using (var connection = new MySqlConnection($"{connectionString}database={selectedDatabase};"))
                    {
                        connection.Open();
                        var command = new MySqlCommand($"DELETE FROM {selectedTable} WHERE ID = @id;", connection);
                        command.Parameters.AddWithValue("@id", dataGridView1.Rows[rowIndex].Cells["ID"].Value);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Row deleted successfully.");
                        LoadTableData(selectedDatabase, selectedTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }

        }

        private void deleteccolumn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                var cell = dataGridView1.SelectedCells[0];
                int columnIndex = cell.ColumnIndex;
                string columnName = dataGridView1.Columns[columnIndex].Name;

                try
                {
                    string selectedDatabase = listBox1.SelectedItem.ToString();
                    string selectedTable = listBox2.SelectedItem.ToString();
                    using (var connection = new MySqlConnection($"{connectionString}database={selectedDatabase};"))
                    {
                        connection.Open();
                        var command = new MySqlCommand($"ALTER TABLE {selectedTable} DROP COLUMN {columnName};", connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Column deleted successfully.");
                        LoadTableData(selectedDatabase, selectedTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a column to delete.");
            }

        }

        private void deletedata_Click(object sender, EventArgs e)
        {
            string selectedDatabase = listBox1.SelectedItem.ToString();

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new MySqlCommand($"DROP DATABASE {selectedDatabase};", connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Database deleted successfully.");
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    dataGridView1.DataSource = null;
                    LoadDatabases();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void deletetable_Click(object sender, EventArgs e)
        {
            string selectedDatabase = listBox1.SelectedItem.ToString();
            string selectedTable = listBox2.SelectedItem.ToString();

            try
            {
                using (var connection = new MySqlConnection($"{connectionString}database={selectedDatabase};"))
                {
                    connection.Open();
                    var command = new MySqlCommand($"DROP TABLE {selectedTable};", connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Table deleted successfully.");
                    listBox2.Items.Clear();
                    LoadTables(selectedDatabase);
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Seçilen hücrenin değerini update_cell TextBox'ına aktar
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Hücrenin satır ve sütun indeksleri geçerliyse
            {
                DataGridViewCell selectedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                update_cell.Text = selectedCell.Value.ToString();

            }
        }

      
    }
}
