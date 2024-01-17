using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Rrecipe
{
    public partial class LoginPage : Form
    {
        public static LoginPage instance;
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public LoginPage()
        {
            InitializeComponent();

            // Create a connection to the MySql database
            server = "localhost";
            database = "rrecipe";
            uid = "root";
            password = "";

            string connectionString;
            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);

            instance = this;
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            int result;

            Cursor.Current = Cursors.WaitCursor;

            result = Register(usernameTextbox.Text, passwordTextbox.Text);
            Cursor.Current = Cursors.Default;

            switch (result)
            {
                case -2:
                    MessageBox.Show("Neither a username or password can be empty");
                    break;
                case -1:
                    MessageBox.Show("Username is taken");
                    break;
                case 0:
                    MessageBox.Show("Failed to register");
                    break;
                case 1:
                    MessageBox.Show("Account successfully created");
                    usernameTextbox.Text = "";
                    passwordTextbox.Text = "";
                    break;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            int result;
            int userId;

            Cursor.Current = Cursors.WaitCursor;

            result = Login(usernameTextbox.Text, passwordTextbox.Text);
            Cursor.Current = Cursors.Default;

            switch (result)
            {
                case -1:
                    MessageBox.Show("Login attempt failed");
                    break;

                case 0:
                    MessageBox.Show("Username or password is incorrect");
                    break;

                case 1:
                    Cursor.Current = Cursors.WaitCursor;
                    
                    userId = GetUserId();
                    Cursor.Current = Cursors.Default;

                    // Check if we successfully found the user Id
                    if (userId != -1)
                    {
                        MessageBox.Show("Login Successful!");

                        // Open the main page
                        HomePage.instance = new HomePage(usernameTextbox.Text, userId);
                        usernameTextbox.Text = "";
                        passwordTextbox.Text = "";

                        HomePage.instance.Show();
                        this.Hide();
                    }
                    break;
            }
        }

        public int Register(string username, string password)
        {
            string query;

            if (username == string.Empty || password == string.Empty)
            {
                return -2;
            }

            try
            {
                if (OpenConnection())
                {
                    // Check if the proposed username is already in use
                    query = "SELECT * FROM users WHERE username = @username";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@username", username);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        command.Dispose();
                        reader.Close();
                        connection.Close();
                        return -1;
                    }
                    else
                    {
                        reader.Close();
                    }

                    // Add the user's info into the database
                    query = "INSERT INTO users (id, username, password) VALUES ('', @username, @password)";
                    command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();

                    connection.Close();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                connection.Close();
                return 0;
            }
        }

        public int Login(string username, string password)
        {
            string query = "SELECT * FROM users WHERE username = @username AND password = @password;";

            if (username == string.Empty || password == string.Empty)
            {
                return 0;
            }

            try
            {
                if (OpenConnection())
                {
                    // Check if the inputted credentials match any on the database
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        command.Dispose();
                        reader.Close();
                        connection.Close();

                        return 1;
                    }
                    else
                    {
                        command.Dispose();
                        reader.Close();
                        connection.Close();

                        return 0;
                    }
                }
                else
                {
                    return -1;
                }
            }

            catch
            {
                connection.Close();
                return -1;
            }
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch
            {
                MessageBox.Show("Failed to connect to server");
                return false;
            }
        }

        private int GetUserId()
        {
            int userId = -1;

            try
            {
                if (OpenConnection())
                {
                    // Find the id in the database assigned to the username
                    string query = "SELECT a.id FROM users a WHERE a.username = @username;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", usernameTextbox.Text);
                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            userId = reader.GetInt32(0);
                        }
                    }

                    connection.Close();
                }

                return userId;
            }
            catch
            {
                // return a dummy number if the operation failed
                return -1;
            }
        }
    }
}
