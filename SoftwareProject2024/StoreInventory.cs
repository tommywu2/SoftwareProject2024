using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SoftwareProject2024.LoginForm;

namespace SoftwareProject2024
{
    public partial class StoreInventory : Form
    {
        string selectedID;

        public StoreInventory()
        {
            InitializeComponent();
        }
        private void btnNewItem_Click(object sender, EventArgs e)
        {
            // Executes the method to add a new item when they click the button.
            NewItem();
        }
        private void StoreInventory_Load(object sender, EventArgs e)
        {
            // Loads data into the datagridview when the Form loads.
            ReadData();
        }
        private void ReadData()
        {
            // Creates a SQLiteConnection.
            using (SQLiteConnection sqlConnection = new SQLiteConnection())
            {
                // Define the connection location of the SQLiteConnection.
                sqlConnection.ConnectionString = "data source = StoreInventory.db";

                // Opens the SQLiteConnection.
                sqlConnection.Open();

                // Defines a string variable with a command to select the StoreInventory.
                string commandText = "SELECT * FROM StoreInventory";

                // Creates a DataTable.
                var dataTable = new DataTable();

                // Creates a SQLiteDataAdapter with the command and connection parameters filled.
                using (SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandText, sqlConnection))
                {
                    try
                    {
                        // Fills the dataTable with the data in the SQLiteDataAdapter.
                        myDataAdapter.Fill(dataTable);

                        // Fills the datagridview with the data in the dataTable by setting it as the data source.
                        dgvStoreInventory.DataSource = dataTable;
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show("Something went wrong refreshing the datagridview.");
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }
        }
        private void NewItem()
        {
            // Creates a copy of the NewItem Form.
            using (NewItem newItem = new NewItem())
            {
                // Checks for when the user pressed the button to add a new item in the NewItem Form from the DialogResult.
                if (newItem.ShowDialog() == DialogResult.OK)
                {
                    // Sets local variables in the method to data in the variables of the NewItem Form
                    string ProductCode = newItem.ProductCode;
                    string ProductName = newItem.ProductName;
                    string ProductCategory = newItem.ProductCategory;
                    string ProductBuyPrice = newItem.ProductBuyPrice;
                    string ProductSellPrice = newItem.ProductSellPrice;
                    string ProductSales = newItem.ProductSales;
                    string ProductStock = newItem.ProductStock;
                    string ProductMeasurement = newItem.ProductMeasurement;
                    string ProductSupplier = newItem.ProductSupplier;

                    // Creates an SQLiteConnection.
                    using (SQLiteConnection sqlConnection = new SQLiteConnection())
                    {
                        // Sets the connection location.
                        sqlConnection.ConnectionString = "data source = StoreInventory.db";

                        // Creates an SQLiteCommand to check if the Product Code of the item to add is unused.
                        using (SQLiteCommand selectCommand = new SQLiteCommand())
                        {
                            // Sets @ProductCode to the ProductCode variable.
                            selectCommand.Parameters.AddWithValue("@ProductCode", ProductCode);

                            // Defines the connection of the selectCommand.
                            selectCommand.Connection = sqlConnection;

                            // Defines the command to find the Product Code in the Product Code column in the database.
                            selectCommand.CommandText = "SELECT * FROM StoreInventory WHERE [Product Code] = @ProductCode";

                            // Opens the SQLiteConnection.
                            sqlConnection.Open();

                            // Executes the command using a SQLiteDataReader.
                            using (SQLiteDataReader sqlReader = selectCommand.ExecuteReader())
                            {
                                // If it finds data with the same Product Code it lets the user know the product can't be added.
                                if (sqlReader.Read())
                                {
                                    MessageBox.Show("Can't add product, Product Code already in use");
                                }
                                // Didn't find a product with the same code.
                                else
                                {
                                    // Creates a SQLiteCommand to add the new product.
                                    using (SQLiteCommand addCommand = new SQLiteCommand())
                                    {
                                        // Sets the connection of the addCommand.
                                        addCommand.Connection = sqlConnection;

                                        //Defines the command type.
                                        addCommand.CommandType = CommandType.Text;

                                        // Defines the command to add the data into their columns.
                                        addCommand.CommandText = "INSERT into StoreInventory ('Product Code', 'Product Name', 'Product Category', 'Product Buy Price', 'Product Sell Price', 'Product Sales', 'Product Stock', 'Product Measurement', 'Product Supplier') Values (@ProductCode, @ProductName, @ProductCategory, @ProductBuyPrice, @ProductSellPrice, @ProductSales, @ProductStock, @ProductMeasurement, @ProductSupplier)";

                                        // Sets the parameters in the addCommand to their variables.
                                        addCommand.Parameters.AddWithValue("@ProductCode", ProductCode);
                                        addCommand.Parameters.AddWithValue("@ProductName", ProductName);
                                        addCommand.Parameters.AddWithValue("@ProductCategory", ProductCategory);
                                        addCommand.Parameters.AddWithValue("@ProductBuyPrice", ProductBuyPrice);
                                        addCommand.Parameters.AddWithValue("@ProductSellPrice", ProductSellPrice);
                                        addCommand.Parameters.AddWithValue("@ProductSales", ProductSales);
                                        addCommand.Parameters.AddWithValue("@ProductStock", ProductStock);
                                        addCommand.Parameters.AddWithValue("@ProductMeasurement", ProductMeasurement);
                                        addCommand.Parameters.AddWithValue("@ProductSupplier", ProductSupplier);

                                        // Executes the addCommand.
                                        addCommand.ExecuteNonQuery();

                                        // Informs the user their data has been added to the database.
                                        MessageBox.Show("Your product has been added.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        ReadData(); // Refreshes the DataGridView
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            // Creates a SQLiteConnection.
            using (SQLiteConnection sqlConnection = new SQLiteConnection())
            {
                // Defines the connection location.
                sqlConnection.ConnectionString = "data source = StoreInventory.db";

                // Opens the SQLiteConnection.
                sqlConnection.Open();

                // Defines the command to select data from the database where there is a value similiar to the Search Value textbox in the column defined by the Search Category.
                string commandText = $"SELECT * FROM StoreInventory WHERE [{comboBoxSearchCategory.Text}] LIKE '%{txtSearchValue.Text}%'";

                // Creates a DataTable.
                var dataTable = new DataTable();

                // Checks if the Search Category is empty.
                if (string.IsNullOrEmpty(comboBoxSearchCategory.Text))
                {
                    // Informs the user the Search Category is empty.
                    MessageBox.Show("The Search Category is empty, please select one.");
                }
                // Searches for the data in the Category chosen.
                else
                {
                    // Creates a SQLiteDataAdapter with the command and connection location parameters filled with previous variables.
                    using (SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandText, sqlConnection))
                    {
                        try
                        {
                            // Fills the dataTable with the results.
                            myDataAdapter.Fill(dataTable);

                            // Sets the datagridview to view the data in the dataTable.
                            dgvStoreInventory.DataSource = dataTable;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Something went wrong with the search command.");
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                    }
                }
            }
        }
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            // Checks if you have any rows are selected before attempting to delete them.
            if (dgvStoreInventory.SelectedRows.Count > 0)
            {
                // Confirms with the user if they are sure they want to delete the data to prevent misclicks.
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Creates a SQLiteConnection.
                    using (SQLiteConnection sqlConnection = new SQLiteConnection())
                    {
                        // Defines the connection location.
                        sqlConnection.ConnectionString = "data source = StoreInventory.db";

                        // Creates a SQLiteCommand for deleting the product.
                        using (SQLiteCommand deleteCommand = new SQLiteCommand())
                        {
                            try
                            {
                                // Defines the connection location of the deleteCommand
                                deleteCommand.Connection = sqlConnection;

                                // Defines the command type.
                                deleteCommand.CommandType = CommandType.Text;

                                // Sets the command to delete the data from the database by finding the unique product code.
                                deleteCommand.CommandText = "DELETE FROM StoreInventory WHERE [Product Code] = @ProductCode";

                                // Sets the @ProductCode parameter to the selectedID variable which is set to the Product Code cell of the selected row.
                                deleteCommand.Parameters.AddWithValue("@ProductCode", selectedID);

                                // Opens the SQLiteConnection.
                                sqlConnection.Open();

                                // Executes the deleteCommand.
                                deleteCommand.ExecuteNonQuery();

                                // Informs the user that the product has been deleted from the database.
                                MessageBox.Show("Product has been deleted", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                // Calls the ReadData method to refresh the datagridview.
                                ReadData();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Something went wrong with the command to remove the product.");
                                MessageBox.Show($"An error occurred: {ex.Message}");
                            }
                        }

                    }
                }
            }
        }
        private void btnSearchReset_Click(object sender, EventArgs e)
        {
            // Clears the textbox for searching.
            txtSearchValue.Text = null;

            // Calls the ReadData method to refresh the datagridview.
            ReadData();
        }
        private void InsertItem()
        {
            // Creates a SQLiteConnection.
            using (SQLiteConnection sqlConnection = new SQLiteConnection())
            {
                // Defines the location for the connection.
                sqlConnection.ConnectionString = "data source = StoreInventory.db";

                // Creates a SQLiteCommand for selecting.
                using (SQLiteCommand selectCommand = new SQLiteCommand())
                {
                    // Sets the @ProductCode parameter to the Product Code textbox.
                    selectCommand.Parameters.AddWithValue("@ProductCode", txtProductCode.Text);

                    // Defines the connection.
                    selectCommand.Connection = sqlConnection;

                    // Defines the command to find in the database a Product Code with the same value as the one in the textbox.
                    selectCommand.CommandText = "SELECT * FROM StoreInventory WHERE [Product Code] = @ProductCode";

                    // Opens the SQLiteConnection.
                    sqlConnection.Open();

                    // Creates a SQLiteDataReader to read the data found using the selectCommand.
                    using (SQLiteDataReader sqlReader = selectCommand.ExecuteReader())
                    {
                        try
                        {
                            // If there is data that can be read that means the Product Code in the textbox is already used in the database.
                            if (sqlReader.Read())
                            {
                                // Lets the user know the Product Code is already used and the product can't be added as that is the unique identifer for the product.
                                MessageBox.Show("Can't add product, Product Code already in use");
                            }
                            // If no data could be read that means the Product Code is unused.
                            else
                            {
                                try
                                {
                                    // Creates a SQLiteCommand for inserting the product.
                                    using (SQLiteCommand addCommand = new SQLiteCommand())
                                    {
                                        // Defines the connection of the addCommand as the connection of the SQLiteConnection.
                                        addCommand.Connection = sqlConnection;

                                        // Clarifies the command type is text.
                                        addCommand.CommandType = CommandType.Text;

                                        // Defines the command which is inserting the @ into their respective columns.
                                        addCommand.CommandText = "INSERT into StoreInventory ('Product Code', 'Product Name', 'Product Category', 'Product Buy Price', 'Product Sell Price', 'Product Sales', 'Product Stock', 'Product Measurement', 'Product Supplier') Values (@ProductCode, @ProductName, @ProductCategory, @ProductBuyPrice, @ProductSellPrice, @ProductSales, @ProductStock, @ProductMeasurement, @ProductSupplier)";

                                        // Defines the paramaters of the @ that is to be added to the data inside their respective textboxes.
                                        addCommand.Parameters.AddWithValue("@ProductCode", txtProductCode.Text);
                                        addCommand.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                                        addCommand.Parameters.AddWithValue("@ProductCategory", txtProductCategory.Text);
                                        addCommand.Parameters.AddWithValue("@ProductBuyPrice", txtProductBuyPrice.Text);
                                        addCommand.Parameters.AddWithValue("@ProductSellPrice", txtProductSellPrice.Text);
                                        addCommand.Parameters.AddWithValue("@ProductSales", txtProductSales.Text);
                                        addCommand.Parameters.AddWithValue("@ProductStock", txtProductStock.Text);
                                        addCommand.Parameters.AddWithValue("@ProductMeasurement", txtProductMeasurement.Text);
                                        addCommand.Parameters.AddWithValue("@ProductSupplier", txtProductSupplier.Text);

                                        // Executes the command to insert the data.
                                        addCommand.ExecuteNonQuery();

                                        // Lets the user know their product was inserted.
                                        MessageBox.Show("Your product has been inserted.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        // Calls the ReadData method to updata the datagridview with the new data.
                                        ReadData();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Something went wrong with the command inserting your product.");
                                    MessageBox.Show($"An error occurred: {ex.Message}");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Something went wrong with checking if the Product Code is unique.");
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                    }
                }
            }
        }
        private void UpdateRecord()
        {
            // Creates a SQLiteConnection.
            using (SQLiteConnection sqlConnection = new SQLiteConnection())
            {
                // Declares the data source.
                sqlConnection.ConnectionString = "data source = StoreInventory.db";

                // Creates a SQLiteCommand
                using (SQLiteCommand sqlCommand = new SQLiteCommand())
                {
                    try
                    {
                        // Sets the SQLiteCommand connection to the connection of SQLiteConnection.
                        sqlCommand.Connection = sqlConnection;

                        // Specifies  the command is interpreted as text.
                        sqlCommand.CommandType = CommandType.Text;

                        // Defines the command.
                        sqlCommand.CommandText = "UPDATE StoreInventory SET [Product Name] = @ProductName, [Product Category] = @ProductCategory, [Product Buy Price] = @ProductBuyPrice, [Product Sell Price] = @ProductSellPrice, [Product Sales] = @ProductSales, [Product Stock] = @ProductStock, [Product Measurement] = @ProductMeasurement, [Product Supplier] = @ProductSupplier WHERE [Product Code] = @ProductCode";

                        // Defines the parameter placeholders to the textboxes except for the Product Code which is used to identify where to make the changes.
                        sqlCommand.Parameters.AddWithValue("@ProductCode", selectedID);
                        sqlCommand.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                        sqlCommand.Parameters.AddWithValue("@ProductCategory", txtProductCategory.Text);
                        sqlCommand.Parameters.AddWithValue("@ProductBuyPrice", txtProductBuyPrice.Text);
                        sqlCommand.Parameters.AddWithValue("@ProductSellPrice", txtProductSellPrice.Text);
                        sqlCommand.Parameters.AddWithValue("@ProductSales", txtProductSales.Text);
                        sqlCommand.Parameters.AddWithValue("@ProductStock", txtProductStock.Text);
                        sqlCommand.Parameters.AddWithValue("@ProductMeasurement", txtProductMeasurement.Text);
                        sqlCommand.Parameters.AddWithValue("@ProductSupplier", txtProductSupplier.Text);

                        // Opens the SQLiteConnection.
                        sqlConnection.Open();

                        // Executes the SQLiteCommand.
                        sqlCommand.ExecuteNonQuery();

                        // Informs the user that their data has been updated.
                        MessageBox.Show("Your data is updated.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Calls the ReadData method to update the datagridview with the new information.
                        ReadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something went wrong with the defining the command to update product data.");
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }
        }
        private void btnSaveStoreInventory_Click(object sender, EventArgs e)
        {
            // Checks if the amount of rows selected by the user is more than 0.
            if (dgvStoreInventory.SelectedRows.Count > 0)
            {
                // Informs the user that their the data of their selected item is getting saved.
                MessageBox.Show("Saving Item");

                // Sets the selectedID variable to the data of the first cell inside the product selected.
                selectedID = dgvStoreInventory.SelectedRows[0].Cells[0].Value.ToString();

                // Calls the UpdateRecord method to save the data in the textboxes to the selected rows.
                UpdateRecord();

            }
            else
            {
                // Informs the user that their the data in the textboxes is getting inserted into the database.
                MessageBox.Show("Inserting Item");

                // Calls the InsertItem method to insert the data in the textboxes into the database.
                InsertItem();
            }
        }
        private void dgvStoreInventory_SelectionChanged(object sender, EventArgs e)
        {
            // Checks if the amount of rows selected by the user is more than 0.
            if (dgvStoreInventory.SelectedRows.Count > 0)
            {
                // Sets the selectedID variable to the data of the first cell inside the product selected.
                selectedID = dgvStoreInventory.SelectedRows[0].Cells[0].Value.ToString();

                // Creates a SQLiteConnection.
                using (SQLiteConnection sqlConnection = new SQLiteConnection())
                {
                    if (string.IsNullOrEmpty(selectedID))
                    {
                        // Checks and informs the user if the selected product is empty.
                        MessageBox.Show("The selected item is null.");
                    }
                    else
                    {
                        // Declares the data source.
                        sqlConnection.ConnectionString = "data source = StoreInventory.db";

                        // Defines the command.
                        string commandText = $"SELECT * FROM StoreInventory WHERE [Product Code] = '{selectedID}'";

                        // Creates a variable with the DataTable class.
                        var dataTable = new DataTable();

                        // Creates a SQLiteDataAdapter filled with connection location and command.
                        using (SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandText, sqlConnection))
                        {
                            try
                            {
                                // Opens the connection.
                                sqlConnection.Open();

                                // Fills the dataTable variable with the data in the SQLiteDataAdapter
                                myDataAdapter.Fill(dataTable);

                                // Fills the textboxes with the relevant data from the dataTable
                                txtProductCode.Text = dataTable.Rows[0]["Product Code"].ToString();
                                txtProductName.Text = dataTable.Rows[0]["Product Name"].ToString();
                                txtProductCategory.Text = dataTable.Rows[0]["Product Category"].ToString();
                                txtProductBuyPrice.Text = dataTable.Rows[0]["Product Buy Price"].ToString();
                                txtProductSellPrice.Text = dataTable.Rows[0]["Product Sell Price"].ToString();
                                txtProductSales.Text = dataTable.Rows[0]["Product Sales"].ToString();
                                txtProductStock.Text = dataTable.Rows[0]["Product Stock"].ToString();
                                txtProductMeasurement.Text = dataTable.Rows[0]["Product Measurement"].ToString();
                                txtProductSupplier.Text = dataTable.Rows[0]["Product Supplier"].ToString();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Something went wrong with showing product data in the textboxes.");
                                MessageBox.Show($"An error occurred: {ex.Message}");
                            }
                        }
                    }
                }
            }
        }
    }
}

