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
    public partial class CustomerData : Form
    {
        string selectedID;

        public CustomerData()
        {
            InitializeComponent();
        }
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            // Executes the method to add a new customer when they click the button.
            NewCustomer();
        }
        private void CustomerData_Load(object sender, EventArgs e)
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

                // Defines a string variable with a command to select the Customers.
                string commandText = "SELECT * FROM Customers";

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
                        dgvCustomerData.DataSource = dataTable;
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show("Something went wrong refreshing the datagridview.");
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }
        }
        private void NewCustomer()
        {
            // Creates a copy of the NewCustomer Form.
            using (NewCustomer newCustomer = new NewCustomer())
            {
                // Checks for when the user pressed the button to add a new customer in the NewCustomer Form from the DialogResult.
                if (newCustomer.ShowDialog() == DialogResult.OK)
                {
                    // Sets local variables in the method to data in the variables of the NewCustomer Form
                    string CustomerID = newCustomer.CustomerID;
                    string FirstName = newCustomer.FirstName;
                    string Surname = newCustomer.Surname;
                    string Address = newCustomer.Address;
                    string CardNumber = newCustomer.CardNumber;
                    string CardName = newCustomer.CardName;
                    string CardDate = newCustomer.CardDate;
                    string CardCVV = newCustomer.CardCVV;

                    // Creates an SQLiteConnection.
                    using (SQLiteConnection sqlConnection = new SQLiteConnection())
                    {
                        // Sets the connection location.
                        sqlConnection.ConnectionString = "data source = StoreInventory.db";

                        // Creates an SQLiteCommand to check if the Customer ID of the customer to add is unused.
                        using (SQLiteCommand selectCommand = new SQLiteCommand())
                        {
                            // Sets @CustomerID to the CustomerID variable.
                            selectCommand.Parameters.AddWithValue("@CustomerID", CustomerID);

                            // Defines the connection of the selectCommand.
                            selectCommand.Connection = sqlConnection;

                            // Defines the command to find the Customer ID in the Customer ID column in the database.
                            selectCommand.CommandText = "SELECT * FROM Customers WHERE [Customer ID] = @CustomerID";

                            // Opens the SQLiteConnection.
                            sqlConnection.Open();

                            // Executes the command using a SQLiteDataReader.
                            using (SQLiteDataReader sqlReader = selectCommand.ExecuteReader())
                            {
                                // If it finds data with the same Customer ID it lets the user know the customer can't be added.
                                if (sqlReader.Read())
                                {
                                    MessageBox.Show("Can't add customer, Customer ID already in use");
                                }
                                // Didn't find a customer with the same code.
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
                                        addCommand.CommandText = "INSERT into Customers ('Customer ID', 'First Name', 'Surname', 'Address', 'Card Number', 'Card Name', 'Card Date', 'Card CVV') Values (@CustomerID, @FirstName, @Surname, @Address, @CardNumber, @CardName, @CardDate, @CardCVV)";

                                        // Sets the parameters in the addCommand to their variables.
                                        addCommand.Parameters.AddWithValue("@CustomerID", CustomerID);
                                        addCommand.Parameters.AddWithValue("@FirstName", FirstName);
                                        addCommand.Parameters.AddWithValue("@Surname", Surname);
                                        addCommand.Parameters.AddWithValue("@Address", Address);
                                        addCommand.Parameters.AddWithValue("@CardNumber", CardNumber);
                                        addCommand.Parameters.AddWithValue("@CardName", CardName);
                                        addCommand.Parameters.AddWithValue("@CardDate", CardCVV);
                                        addCommand.Parameters.AddWithValue("@CardCVV", CardCVV);

                                        // Executes the addCommand.
                                        addCommand.ExecuteNonQuery();

                                        // Informs the user the customer has been added to the database.
                                        MessageBox.Show("The customer has been added.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        ReadData(); // Refreshes the DataGridView
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            // Creates a SQLiteConnection.
            using (SQLiteConnection sqlConnection = new SQLiteConnection())
            {
                // Defines the connection location.
                sqlConnection.ConnectionString = "data source = StoreInventory.db";

                // Opens the SQLiteConnection.
                sqlConnection.Open();

                // Defines the command to select data from the database where there is a value similiar to the Search Value textbox in the column defined by the Search Category.
                string commandText = $"SELECT * FROM Customers WHERE [{comboBoxSearchCategory.Text}] LIKE '%{txtSearchValue.Text}%'";

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
                            dgvCustomerData.DataSource = dataTable;
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
        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            // Checks if you have any rows are selected before attempting to delete them.
            if (dgvCustomerData.SelectedRows.Count > 0)
            {
                // Confirms with the user if they are sure they want to delete the customer data to prevent misclicks.
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

                                // Sets the command to delete the data from the database by finding the unique customer id.
                                deleteCommand.CommandText = "DELETE FROM Customers WHERE [Customer ID] = @CustomerID";

                                // Sets the @CustomerID parameter to the selectedID variable which is set to the Customer ID cell of the selected row.
                                deleteCommand.Parameters.AddWithValue("@CustomerID", selectedID);

                                // Opens the SQLiteConnection.
                                sqlConnection.Open();

                                // Executes the deleteCommand.
                                deleteCommand.ExecuteNonQuery();

                                // Informs the user that the customer data has been deleted from the database.
                                MessageBox.Show("Customer data has been deleted", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                // Calls the ReadData method to refresh the datagridview.
                                ReadData();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Something went wrong with the command to remove the customer data.");
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
        private void InsertCustomer()
        {
            // Creates a SQLiteConnection.
            using (SQLiteConnection sqlConnection = new SQLiteConnection())
            {
                // Defines the location for the connection.
                sqlConnection.ConnectionString = "data source = StoreInventory.db";

                // Creates a SQLiteCommand for selecting.
                using (SQLiteCommand selectCommand = new SQLiteCommand())
                {
                    // Sets the @CustomerID parameter to the Customer ID textbox.
                    selectCommand.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);

                    // Defines the connection.
                    selectCommand.Connection = sqlConnection;

                    // Defines the command to find in the database a customer id with the same value as the one in the textbox.
                    selectCommand.CommandText = "SELECT * FROM Customers WHERE [Customer ID] = @CustomerID";

                    // Opens the SQLiteConnection.
                    sqlConnection.Open();

                    // Creates a SQLiteDataReader to read the data found using the selectCommand.
                    using (SQLiteDataReader sqlReader = selectCommand.ExecuteReader())
                    {
                        try
                        {
                            // If there is data that can be read that means the customer id in the textbox is already used in the database.
                            if (sqlReader.Read())
                            {
                                // Lets the user know the customer id is already used and the customer can't be added as that is the unique identifer for the customer.
                                MessageBox.Show("Can't add customer, Customer ID already in use");
                            }
                            // If no data could be read that means the customer id is unused.
                            else
                            {
                                try
                                {
                                    // Creates a SQLiteCommand for inserting the new customer.
                                    using (SQLiteCommand addCommand = new SQLiteCommand())
                                    {
                                        // Defines the connection of the addCommand as the connection of the SQLiteConnection.
                                        addCommand.Connection = sqlConnection;

                                        // Clarifies the command type is text.
                                        addCommand.CommandType = CommandType.Text;

                                        // Defines the command which is inserting the @ into their respective columns.
                                        addCommand.CommandText = "INSERT into Customers ('Customer ID', 'First Name', 'Surname', 'Address', 'Card Number', 'Card Name', 'Card Date', 'Card CVV') Values (@CustomerID, @FirstName, @Surname, @Address, @CardNumber, @CardName, @CardDate, @CardCVV)";

                                        // Defines the paramaters of the @ that is to be added to the data inside their respective textboxes.
                                        addCommand.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);
                                        addCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                                        addCommand.Parameters.AddWithValue("@Surname", txtSurname.Text);
                                        addCommand.Parameters.AddWithValue("@Address", txtAddress.Text);
                                        addCommand.Parameters.AddWithValue("@CardNumber", txtCardNumber.Text);
                                        addCommand.Parameters.AddWithValue("@CardName", txtCardName.Text);
                                        addCommand.Parameters.AddWithValue("@CardDate", txtCardDate.Text);
                                        addCommand.Parameters.AddWithValue("@CardCVV", txtCardCVV.Text);

                                        // Executes the command to insert the customer data.
                                        addCommand.ExecuteNonQuery();

                                        // Lets the user know the customer data was inserted.
                                        MessageBox.Show("The customer has been inserted.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        // Calls the ReadData method to updata the datagridview with the new data.
                                        ReadData();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Something went wrong with the command inserting your customer.");
                                    MessageBox.Show($"An error occurred: {ex.Message}");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Something went wrong with checking if the Customer ID is unique.");
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
                        sqlCommand.CommandText = "UPDATE Customers SET [First Name] = @FirstName, [Surname] = @Surname, [Address] = @Address, [Card Number] = @CardNumber, [Card Name] = @CardName, [Card Date] = @CardDate, [Card CVV] = @CardCVV WHERE [Customer ID] = @CustomerID";

                        // Defines the parameter placeholders to the textboxes except for the Customer ID which is used to identify where to make the changes.
                        sqlCommand.Parameters.AddWithValue("@CustomerID", selectedID);
                        sqlCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                        sqlCommand.Parameters.AddWithValue("@Surname", txtSurname.Text);
                        sqlCommand.Parameters.AddWithValue("@Address", txtAddress.Text);
                        sqlCommand.Parameters.AddWithValue("@CardNumber", txtCardNumber.Text);
                        sqlCommand.Parameters.AddWithValue("@CardName", txtCardName.Text);
                        sqlCommand.Parameters.AddWithValue("@CardDate", txtCardDate.Text);
                        sqlCommand.Parameters.AddWithValue("@CardCVV", txtCardCVV.Text);

                        // Opens the SQLiteConnection.
                        sqlConnection.Open();

                        // Executes the SQLiteCommand.
                        sqlCommand.ExecuteNonQuery();

                        // Informs the user that the customer data has been updated.
                        MessageBox.Show("Customer data updated.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Calls the ReadData method to update the datagridview with the new information.
                        ReadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something went wrong with the defining the command to update customer data.");
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }
        }
        private void btnSaveCustomerData_Click(object sender, EventArgs e)
        {
            // Checks if the amount of rows selected by the user is more than 0.
            if (dgvCustomerData.SelectedRows.Count > 0)
            {
                // Informs the user that their the data of their selected customer is getting saved.
                MessageBox.Show("Saving Customer");

                // Sets the selectedID variable to the data of the first cell inside the selected customer which is their id.
                selectedID = dgvCustomerData.SelectedRows[0].Cells[0].Value.ToString();

                // Calls the UpdateRecord method to save the data in the textboxes to the selected rows.
                UpdateRecord();

            }
            else
            {
                // Informs the user that their the data in the textboxes is getting inserted into the database.
                MessageBox.Show("Inserting Customer");

                // Calls the InsertCustomer method to insert the data in the textboxes into the database.
                InsertCustomer();
            }
        }
        private void dgvCustomerData_SelectionChanged(object sender, EventArgs e)
        {
            // Checks if the amount of rows selected by the user is more than 0.
            if (dgvCustomerData.SelectedRows.Count > 0)
            {
                // Sets the selectedID variable to the data of the first cell inside the selected customer which is their id.
                selectedID = dgvCustomerData.SelectedRows[0].Cells[0].Value.ToString();

                // Creates a SQLiteConnection.
                using (SQLiteConnection sqlConnection = new SQLiteConnection())
                {
                    if (string.IsNullOrEmpty(selectedID))
                    {
                        // Checks and informs the user if the selected customer id is empty.
                        MessageBox.Show("The selected customer's id is null.");
                    }
                    else
                    {
                        // Declares the data source.
                        sqlConnection.ConnectionString = "data source = StoreInventory.db";

                        // Defines the command.
                        string commandText = $"SELECT * FROM Customers WHERE [Customer ID] = '{selectedID}'";

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
                                txtCustomerID.Text = dataTable.Rows[0]["Customer ID"].ToString();
                                txtFirstName.Text = dataTable.Rows[0]["First Name"].ToString();
                                txtSurname.Text = dataTable.Rows[0]["Surname"].ToString();
                                txtAddress.Text = dataTable.Rows[0]["Address"].ToString();
                                txtCardNumber.Text = dataTable.Rows[0]["Card Number"].ToString();
                                txtCardName.Text = dataTable.Rows[0]["Card Name"].ToString();
                                txtCardDate.Text = dataTable.Rows[0]["Card Date"].ToString();
                                txtCardCVV.Text = dataTable.Rows[0]["Card CVV"].ToString();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Something went wrong with showing customer data in the textboxes.");
                                MessageBox.Show($"An error occurred: {ex.Message}");
                            }
                        }
                    }
                }
            }
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveStoreInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {

        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvStoreInventory_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}

