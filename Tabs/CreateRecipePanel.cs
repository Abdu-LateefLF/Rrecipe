using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Rrecipe.Pages
{
    public partial class CreateRecipePanel : UserControl
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public CreateRecipePanel()
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
        }

        private void addIngredientBtn_Click(object sender, EventArgs e)
        {
            if (newIngredientTxtbox.Text != "")
            {
                ingredientListbox.Items.Add(newIngredientTxtbox.Text);
                newIngredientTxtbox.Text = "";
            }
        }

        private void removeIngredientBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ingredientListbox.Items.Remove(ingredientListbox.SelectedItem);
            }
            catch (Exception ex){ MessageBox.Show("Error: " + ex); }
        }

        private void clearRecipeBtn_Click(object sender, EventArgs e)
        {
            recipeNameTxtbox.Text = "";
            prepTimeTxtbox.Text = "";
            newIngredientTxtbox.Text = "";
            instructionTxtbox.Text = "";
            descriptionTxtbox.Text = "";
            ingredientListbox.Items.Clear();
        }

        private void saveRecipeBtn_Click(object sender, EventArgs e)
        {
            if (recipeNameTxtbox.Text != "" && prepTimeTxtbox.Text != "")
            {
                Cursor.Current = Cursors.WaitCursor;

                if (SaveRecipe())
                {
                    MessageBox.Show("Recipe successfully created!");
                    clearRecipeBtn_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed to create recipe");
                }
                Cursor.Current = Cursors.Default;
            }
            else
            {
                MessageBox.Show("Please enter the recipe name and prep time");
            }
        }

        private bool SaveRecipe()
        {
            string query;
            int prepTime;

            // Check if the prep time inputted is an int
            if (!int.TryParse(prepTimeTxtbox.Text, out prepTime))
            {
                MessageBox.Show("Enter an integer for the preparation time");
                return false;
            }

            // Try to save the recipe to the database
            try
            {
                if (OpenConnection())
                {
                    // Check if the user already has a recipe of the same name
                    query = "SELECT * FROM recipes WHERE name = @recipeName AND userId = @userId";

                    using (MySqlCommand sameNameCheck = new MySqlCommand(query, connection))
                    {
                        sameNameCheck.Parameters.AddWithValue("@recipeName", recipeNameTxtbox.Text);
                        sameNameCheck.Parameters.AddWithValue("@userId", HomePage.instance.userId);

                        MySqlDataReader reader = sameNameCheck.ExecuteReader();

                        if (!reader.Read())
                        {
                            reader.Close();

                            // Insert the recipe into the recipe datatable
                            query = "INSERT INTO recipes (id, name, prepTime, instructions, description, userId)"
                            + " VALUES ('', @recipeName, @prepTime, @instructions, @description, @userId);";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@recipeName", recipeNameTxtbox.Text);
                                command.Parameters.AddWithValue("@prepTime", prepTime);
                                command.Parameters.AddWithValue("@instructions", instructionTxtbox.Text);
                                command.Parameters.AddWithValue("@description", descriptionTxtbox.Text);
                                command.Parameters.AddWithValue("@userId", HomePage.instance.userId);

                                command.ExecuteNonQuery();
                            }

                            int recipeId = GetRecipeId(recipeNameTxtbox.Text, HomePage.instance.userId);

                            // Insert the list of ingredients into the ingredient datatable
                            query = "INSERT INTO ingredients (recipeId, name) VALUES (@recipeId, @ingredientName);";
                            for (int i = 0; i < ingredientListbox.Items.Count; i++)
                            {
                                using (MySqlCommand command = new MySqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@recipeId", recipeId);
                                    command.Parameters.AddWithValue("@ingredientName", ingredientListbox.Items[i].ToString());
                                    command.ExecuteNonQuery();
                                }
                            }

                            connection.Close();

                            return true;
                        }
                        else
                        {
                            MessageBox.Show("A recipe with the same name already exists");
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error " + ex); }

            connection.Close();

            return false;
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

        public int GetRecipeId(string name, int userId)
        {
            int id = -1;

            // Check if the user already has a recipe of the same name
            string query = "SELECT a.id FROM recipes a WHERE a.name = @recipeName AND a.userId = @userId";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@recipeName", name);
                    command.Parameters.AddWithValue("@userId", userId);

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {                       
                        id = reader.GetInt32(0);
                        reader.Close();

                        return id;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed to find recipe Id");
            }

            // return a dummy number
            return -1;
        }
    }
}
