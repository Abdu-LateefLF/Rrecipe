using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Rrecipe.Pages
{
    public partial class ViewRecipesPanel : UserControl
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        private bool userInputted;
        private List<int> selectedRecipes;

        public ViewRecipesPanel()
        {
            InitializeComponent();

            clearSearchBtn.Hide();

            userInputted = false;
            selectedRecipes = new List<int>();

            // Create a connection to the MySql database
            server = "localhost";
            database = "rrecipe";
            uid = "root";
            password = "";

            string connectionString;
            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        private void enterSearchBtn_Click(object sender, EventArgs e)
        {
            SearchRecipes();

            // Show option to clear search if the user has typed something
            if (searchTxtbox.Text != "" && userInputted)
            {
                clearSearchBtn.Show();
            }
        }

        public void SearchRecipes()
        {
            string query;
            string search;

            Cursor.Current = Cursors.WaitCursor;

            if (searchTxtbox.Text == "Search" && !userInputted)
            {
                search = "";
            }
            else
            {
                search = searchTxtbox.Text;
            }

            selectedRecipes.Clear();

            try
            {
                if (OpenConnection())
                {
                    query = $"SELECT * FROM recipes WHERE name LIKE '%{search}%' AND userId = @userId;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        command.Parameters.AddWithValue("@userId", HomePage.instance.userId);

                        DataTable recipes = new DataTable();
                        recipes.Columns.Add("id");

                        adapter.Fill(recipes);

                        for (int i = 0; i < recipes.Rows.Count; i++)
                        {
                            selectedRecipes.Add(int.Parse(recipes.Rows[i][0].ToString()));
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error" + ex); }

            DisplayRecipes();

            Cursor.Current = Cursors.Default;
        }

        public void DisplayRecipes()
        {
            string query = "SELECT * FROM recipes WHERE userId = @userId AND id = @recipeId";

            try
            {
                if (OpenConnection())
                {
                    ClearRecipeView();

                    // Loop through all the recipes that should show up in the search result
                    for (int i = 0; i < selectedRecipes.Count; i++)
                    {
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            command.Parameters.AddWithValue("@userId", HomePage.instance.userId);
                            command.Parameters.AddWithValue("@recipeId", selectedRecipes[i]);

                            DataTable recipes = new DataTable();
                            recipes.Columns.Add("id");
                            recipes.Columns.Add("name");
                            recipes.Columns.Add("prepTime");
                            recipes.Columns.Add("instructions");
                            recipes.Columns.Add("description");
                            recipes.Columns.Add("userId");

                            adapter.Fill(recipes);

                            // Create a panel the recipe
                            var recipeInfo = recipes.Rows[0];

                            int recipeId = int.Parse(recipeInfo[0].ToString());
                            string name = recipeInfo[1].ToString();
                            string prepTime = recipeInfo[2].ToString();
                            string instructions = recipeInfo[3].ToString();
                            string description = recipeInfo[4].ToString();

                            RecipeView recipeView = new RecipeView(this, connection, recipeId, name, prepTime, description, instructions);
                            recipeView.Show();
                            recipeFlowPanel.Controls.Add(recipeView);
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error:" + ex); }
        }

        public void ClearRecipeView()
        {
            // Clear current recipes from view
            for (int i = 0; i < recipeFlowPanel.Controls.Count; i++)
            {
                recipeFlowPanel.Controls[i].Dispose();
            }
            recipeFlowPanel.Controls.Clear();
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

        private void searchTxtbox_Enter(object sender, EventArgs e)
        {
            if (searchTxtbox.Text == "Search" && !userInputted)
            {
                searchTxtbox.Text = "";
            }
        }
        
        private void searchTxtbox_Leave(object sender, EventArgs e)
        {
            if (searchTxtbox.Text == "")
            {
                searchTxtbox.Text = "Search";
                userInputted = false;
            }
            else
            {
                userInputted = true;
            }
        }

        private void clearSearchBtn_Click(object sender, EventArgs e)
        {
            searchTxtbox.Text = "";
            searchTxtbox_Leave(sender, e);
            SearchRecipes();
            clearSearchBtn.Hide();
        }
    }
}