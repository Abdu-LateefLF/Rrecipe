using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Rrecipe.Pages
{
    public partial class RecipeView : UserControl
    {
        private ViewRecipesPanel recipesPanel;
        private MySqlConnection connection;
        private int recipeId;

        private string instructionsText;

        public RecipeView(ViewRecipesPanel panel, MySqlConnection conn, int id, string name, string prepTime, string description, string instructions)
        {
            InitializeComponent();

            recipesPanel = panel;
            connection = conn;
            recipeId = id;
            instructionsText = instructions;

            nameLbl.Text = name;
            prepTimeLbl.Text = "Prep Time: " + prepTime + " min(s)";
            descriptionLbl.Text = description;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete {nameLbl.Text}?", "Confirm Recipe Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;

                if (DeleteRecipe())
                {
                    recipesPanel.SearchRecipes();
                    MessageBox.Show("Recipe successfully deleted!");
                }
                else
                {
                    MessageBox.Show("Failed to delete recipe");
                }
                Cursor.Current = Cursors.Default;
            }
        }

        public bool DeleteRecipe()
        {
            string query;

            try
            {
                if (OpenConnection())
                {
                    // Delete all ingredients of the recipe from the database
                    query = "DELETE FROM ingredients WHERE recipeId = @recipeId;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@recipeId", recipeId);
                        command.ExecuteNonQuery();
                    }

                    // Delete the recipe from the database
                    query = "DELETE FROM recipes WHERE id = @recipeId;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@recipeId", recipeId);
                        command.ExecuteNonQuery();
                    }

                    connection.Close();

                    return true;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }

            return false;
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            string query;
            List<string> ingredientList = new List<string>();

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (OpenConnection())
                {
                    // Get all ingredients of the recipe using the recipeId
                    query = "SELECT * FROM ingredients WHERE recipeId = @recipeId;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        command.Parameters.AddWithValue("@recipeId", recipeId);

                        DataTable ingredients = new DataTable();
                        ingredients.Columns.Add("recipeId");
                        ingredients.Columns.Add("name");

                        adapter.Fill(ingredients);

                        // Add each ingredient to the ingredient list
                        for (int i = 0; i < ingredients.Rows.Count; i++)
                        {
                            var recipeInfo = ingredients.Rows[i];
                            ingredientList.Add(recipeInfo[1].ToString());
                        }
                    }

                    connection.Close();

                    HomePage.instance.ShowRecipeDetails(nameLbl.Text, prepTimeLbl.Text, ingredientList, descriptionLbl.Text, instructionsText);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }

            Cursor.Current = Cursors.Default;
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
    }
}
