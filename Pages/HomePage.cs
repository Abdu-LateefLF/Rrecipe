using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Rrecipe
{
    public partial class HomePage : Form
    {
        public static HomePage instance;

        public string username { get; set; }
        public int userId { get; set; }

        public HomePage(string name, int Id)
        {
            InitializeComponent();

            username = name;
            userId = Id;
            usernameLbl.Text = username;

            createRecipeTabBtn_Click(null, EventArgs.Empty);
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LoginPage.instance.Show();
            this.Dispose();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createRecipeTabBtn_Click(object sender, EventArgs e)
        {
            // Switch tab
            createRecipePanel.Show();
            viewRecipesPanel.Hide();
            HideRecipeDetails();

            // Align select indictor with the button
            selectIndictor.Height = createRecipeTabBtn.Height;
            selectIndictor.Top = createRecipeTabBtn.Top;
            selectIndictor.Left = createRecipeTabBtn.Left;
        }

        private void viewRecipesBtn_Click(object sender, EventArgs e)
        {
            // Switch tab
            createRecipePanel.Hide();
            viewRecipesPanel.Show();

            // Align select indictor with the button
            selectIndictor.Height = viewRecipesBtn.Height;
            selectIndictor.Top = viewRecipesBtn.Top;
            selectIndictor.Left = viewRecipesBtn.Left;

            viewRecipesPanel.SearchRecipes();
        }

        public void ShowRecipeDetails(string recipeName, string prepTime, List<string> ingredients, string description, string instructions)
        {
            recipeDetailsPanel.UpdateInfo(recipeName, prepTime, ingredients, description, instructions);
            recipeDetailsPanel.Show();
            recipeDetailsPanel.BringToFront();
        }

        public void HideRecipeDetails()
        {
            recipeDetailsPanel.Hide();
        }
    }
}
