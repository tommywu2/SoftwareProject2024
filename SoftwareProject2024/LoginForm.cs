using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace SoftwareProject2024
{
    public partial class LoginForm : Form
    {
        string enteredUsername;
        string enteredPassword;
        bool isLogin;

        public LoginForm()
        {
            InitializeComponent();

            // Hides the Signup button and the link to switch to the Login button.
            btnSignup.Visible = false;
            lLblLogin.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Sets the variable for loggingin to true and calls the DataValidation with both parameters set to false.
            isLogin = true;
            DataValidation(false, false);
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            // Sets the variable for loggingin to false and calls the DataValidation with both parameters set to false.
            isLogin = false;
            DataValidation(false, false);
        }

        private void lLblSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hides the Login button, link to Signup and shows the Signup button, link to Login.
            btnSignup.Visible = true;
            lLblLogin.Visible = true;
            btnLogin.Visible = false;
            lLblSignup.Visible = false;
        }

        private void lLblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hides the Signup button, link to Login and shows the Login button, link to Signup.
            btnLogin.Visible = true;
            lLblSignup.Visible = true;
            btnSignup.Visible = false;
            lLblLogin.Visible = false;
        }

        private void lLblDeleteAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Calls the DataValidation method setting the parameters of deleting use account to true and opening customer data to false.
            DataValidation(true, false);
        }

        private void Login()
        {
            using (SQLiteConnection sqlConnection = new SQLiteConnection()) //Creates an instance of SQLiteConnection in the variable sqlConnection
            {
                try
                {
                    using (SQLiteCommand selectCommand = new SQLiteCommand()) // Creates an SQLiteCommand
                    {
                        sqlConnection.ConnectionString = "data source = UserData.db"; // Sets where the connection will connect to
                        sqlConnection.Open(); //Opens the connection

                        enteredUsername = txtLoginUsername.Text; // Sets the variables to the login info the user entered
                        enteredPassword = txtLoginPassword.Text;

                        selectCommand.Parameters.AddWithValue("@Username", enteredUsername); // Searches for the username entered in the username column of the database

                        selectCommand.Connection = sqlConnection; // Sets the connection

                        selectCommand.CommandText = "SELECT * FROM LoginData WHERE username = @Username"; // Defines the SELECT statement (data in the column named username)
                        try
                        {
                            using (SQLiteDataReader sqlReader = selectCommand.ExecuteReader())
                            {
                                if (sqlReader.Read()) // Does things if it username is in the database
                                {
                                    string storedPassword = sqlReader["password"].ToString(); // Sets a variable to the the data in the password column of the username entered in the same row

                                    if (storedPassword == enteredPassword) // Checks if the password entered is the password that is saved with the username
                                    {
                                        MessageBox.Show("Login successful!"); // Lets the user know that they successfully logged in

                                        // Lets the user in since they logged in
                                        StoreInventory storeInventory = new StoreInventory(); // Creates the Form for the StoreInventory
                                        storeInventory.ShowDialog(); // Shows the StoreInventory
                                    }
                                    else
                                    {
                                        //Lets the user know the user know the password isn't the one in the database
                                        MessageBox.Show("Incorrect password!");
                                    }
                                }
                                else
                                {
                                    // Lets the user know the username isn't in the database
                                    MessageBox.Show("Username not found!");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Something went wrong with the sqlReader");
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong with the sqlConnection");
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        private void Signup()
        {
            using (SQLiteConnection sqlConnection = new SQLiteConnection()) // Creates a connection and since it's a using statement it closes the connection for me
            {
                try
                {
                    using (SQLiteCommand selectCommand = new SQLiteCommand()) // Creates a new instance
                    {
                        try
                        {
                            if (!string.IsNullOrWhiteSpace(enteredUsername) && !string.IsNullOrWhiteSpace(enteredPassword)) // Checks if the entered data isn't null, empty, or white space.
                            {
                                sqlConnection.ConnectionString = "data source = UserData.db"; // Sets it to connect to the UserData database
                                sqlConnection.Open();

                                enteredUsername = txtLoginUsername.Text; // Sets the variables to the signup info the user entered
                                enteredPassword = txtLoginPassword.Text;

                                selectCommand.Parameters.AddWithValue("@Username", enteredUsername); // Sets @Username to enteredUsername

                                selectCommand.Connection = sqlConnection; // Defines the connection of the selectCommand

                                selectCommand.CommandText = "SELECT * FROM LoginData WHERE username = @Username"; // Command to search the username column for a row that equal the enteredUsername

                                using (SQLiteDataReader sqlReader = selectCommand.ExecuteReader()) // Tries to retrieve the username
                                {
                                    try
                                    {
                                        if (sqlReader.Read()) // If it can read it then it returns true and that means that the username already exists.
                                        {
                                            MessageBox.Show("Username already in use!");
                                        }
                                        else // If it can't be read or false that means the username isn't in the database so isn't registered.
                                        {
                                            using (SQLiteCommand insertCommand = new SQLiteCommand())
                                            {
                                                try
                                                {
                                                    insertCommand.Parameters.AddWithValue("@Username", enteredUsername);
                                                    insertCommand.Parameters.AddWithValue("@Password", enteredPassword);

                                                    insertCommand.Connection = sqlConnection;

                                                    insertCommand.CommandText = "INSERT into LoginData (username, password) Values (@Username, @Password)";

                                                    insertCommand.ExecuteNonQuery(); // Executes the command so the information actually gets saved.
                                                    MessageBox.Show("Signup Successful", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show("Something went wrong with the insertCommand");
                                                    MessageBox.Show($"An error occurred: {ex.Message}");
                                                }
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Something went wrong with the sqlReader");
                                        MessageBox.Show($"An error occurred: {ex.Message}");
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Something went wrong with the selectCommand");
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong with the sqlConnection");
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        private void DataValidation(bool deleteAccount, bool customerData)
        {
            // Creates a SQLiteConnection.
            using (SQLiteConnection sqlConnection = new SQLiteConnection())
            {
                // Creates a SQLiteCommand to check if the username is taken.
                using (SQLiteCommand selectCommand = new SQLiteCommand())
                {
                    // Sets the variables to the login data entered by the user.
                    enteredUsername = txtLoginUsername.Text;
                    enteredPassword = txtLoginPassword.Text;

                    //Checks that the login fields arent empty.
                    if (!string.IsNullOrWhiteSpace(enteredUsername) && !string.IsNullOrWhiteSpace(enteredPassword)) // Checks if the entered data isn't null, empty, or white space.
                    {
                        // Define the connection for the SQLiteConnection.
                        sqlConnection.ConnectionString = "data source = UserData.db";

                        // Sets the @Username to the variable.
                        selectCommand.Parameters.AddWithValue("@Username", enteredUsername);

                        // Defines the database that is getting connected to.
                        selectCommand.Connection = sqlConnection;

                        // Defines the command to check LoginData for a identical username.
                        selectCommand.CommandText = "SELECT * FROM LoginData WHERE username = @Username";

                        // Opens the connection.
                        sqlConnection.Open();

                        // Uses the SQLiteDataReader to execute the command.
                        using (SQLiteDataReader sqlReader = selectCommand.ExecuteReader())
                        {
                            try
                            {
                                // Found data in the LoginData that is the same username.
                                if (sqlReader.Read())
                                {
                                    // Checks if the user is logging in 
                                    if (isLogin == true && deleteAccount == false && customerData == false)
                                    {
                                        // Stores the password of the username.
                                        string storedPassword = sqlReader["password"].ToString();

                                        // Compares the password to the one the user entered.
                                        if (storedPassword == enteredPassword)
                                        {
                                            // Informs the user that password was correct.
                                            MessageBox.Show("Login Successful!");

                                            // Creates the StoreInventory Form and opens it.
                                            StoreInventory storeInventory = new StoreInventory();
                                            storeInventory.ShowDialog();
                                        }
                                        else
                                        {
                                            //Lets the user know the user know the password doesn't match.
                                            MessageBox.Show("Incorrect Password!");
                                        }
                                    }
                                    // Checks if the user is signing up.
                                    if (isLogin == false && deleteAccount == false && customerData == false)
                                    {
                                        // Lets the user know that the username is taken.
                                        MessageBox.Show("Username already in use!");
                                    }
                                    // Checks if the user is deleting their account.
                                    if (deleteAccount == true)
                                    {
                                        // Saves the password from the database.
                                        string storedPassword = sqlReader["password"].ToString();

                                        // Checks if the password is correct before deleting the account.
                                        if (storedPassword == enteredPassword)
                                        {
                                            // Creates a command to delete the account from the database.
                                            using (SQLiteCommand deleteCommand = new SQLiteCommand())
                                            {
                                                // Sets the parameter to the variable of the username the user entered.
                                                deleteCommand.Parameters.AddWithValue("@Username", enteredUsername);

                                                // Sets the connection location.
                                                deleteCommand.Connection = sqlConnection;

                                                // Defines the command to delete the user's account.
                                                deleteCommand.CommandText = "DELETE FROM LoginData WHERE username = @Username";

                                                // Executes the delete command.
                                                deleteCommand.ExecuteNonQuery();

                                                // Informs the user the account deletion was done.
                                                MessageBox.Show("Delete Successful", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                        }
                                        else
                                        {
                                            //Lets the user know the password isn't correct.
                                            MessageBox.Show("Incorrect password can't delete.");
                                        }
                                    }
                                    // Checks if the user is opening the customer data form.
                                    if (customerData == true)
                                    {
                                        // Saves the password of the username.
                                        string storedPassword = sqlReader["password"].ToString();

                                        // Checks if the password is correct.
                                        if (storedPassword == enteredPassword)
                                        {
                                            // Saves the permission level of the user.
                                            int permLevel = Convert.ToInt32(sqlReader["perm level"]);

                                            // Checks if the user has high enough permissions.
                                            if (permLevel > 4)
                                            {
                                                // Informs the user they are granted access.
                                                MessageBox.Show("Permission granted!");

                                                // Creates the customer data Form and opens it.
                                                CustomerData customerForm = new CustomerData();
                                                customerForm.ShowDialog();
                                            }
                                            else
                                            {
                                                // Informs the user their permission levels are not high enough.
                                                MessageBox.Show("Permission level not adequate!");
                                            }
                                        }
                                    }

                                }
                                // The username was not found in the database.
                                else
                                {
                                    // Check if the user is trying to login.
                                    if (isLogin == true && deleteAccount == false && customerData == false)
                                    {
                                        // Lets the user know the username can't be found.
                                        MessageBox.Show("Username not found!");
                                    }
                                    // Check if the user is signing up.
                                    if (isLogin == false && deleteAccount == false && customerData == false) // If they are signing up
                                    {
                                        // Creates a command to add the user info to the database.
                                        using (SQLiteCommand insertCommand = new SQLiteCommand())
                                        {
                                            try
                                            {
                                                // Sets the parameters to the info the user entered.
                                                insertCommand.Parameters.AddWithValue("@Username", enteredUsername);
                                                insertCommand.Parameters.AddWithValue("@Password", enteredPassword);

                                                // Sets the connection of the insertCommand.
                                                insertCommand.Connection = sqlConnection;

                                                // Defines th ecommand to insert the user's data into the LoginData.
                                                insertCommand.CommandText = "INSERT into LoginData (username, password, 'perm level') Values (@Username, @Password, 1)";

                                                // Executes the command to add the user's info.
                                                insertCommand.ExecuteNonQuery();

                                                // Informs the user the signup was successful.
                                                MessageBox.Show("Signup Successful", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("Something went wrong with the signup command.");
                                                MessageBox.Show($"An error occurred: {ex.Message}");
                                            }
                                        }
                                    }
                                    // Checks if the user is trying to delete their account.
                                    if (deleteAccount == true)
                                    {
                                        // Informs the user the username can't be found.
                                        MessageBox.Show("Username not found can't delete!");
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Something went wrong with the sqlReader in the DataValidation method.");
                                MessageBox.Show($"An error occurred: {ex.Message}");
                            }
                        }
                    }
                    else
                    {
                        // Lets the user know the login field/s are empty.
                        MessageBox.Show("Login field/s empty");
                    }

                }

            }
        }
        private void btnCustomerData_Click(object sender, EventArgs e)
        {
            // Calls for the DataValidation method and setting the parameters of deleting the user account to false and opening the customer data Form to true.
            DataValidation(false, true);
        }
        private void LoginForm_Resize(object sender, EventArgs e)
        {
            // Sets the x and y variable to the size of the form divided by two in the x and y (puts the Login in the middle of the Form)
            int x = (this.ClientSize.Width - gBoxLogin.Size.Width) / 2;
            int y = (this.ClientSize.Height - gBoxLogin.Size.Height) / 2;

            // Sets the location of the Login groupbox to the x and y variable.
            gBoxLogin.Location = new System.Drawing.Point(x, y);
        }
    }
}