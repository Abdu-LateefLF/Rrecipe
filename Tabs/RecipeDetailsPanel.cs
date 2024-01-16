using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rrecipe.Pages
{
    public partial class RecipeDetailsPanel : UserControl
    {
        public RecipeDetailsPanel()
        {
            InitializeComponent();
        }

        public void UpdateInfo(string recipeName, string prepTime, List<string> ingredients, string description, string instructions)
        {
            recipeNameLbl.Text = recipeName;
            prepTimeLbl.Text = prepTime;
            descriptionTxtBox.Text = description;
            instructionsTxtbox.Text = instructions;

            // Show the ingredients in a listbox
            ingredientsListBox.Items.Clear();
            for (int i = 0; i < ingredients.Count; i++)
            {
                ingredientsListBox.Items.Add(ingredients[i]);
            }
        }

        private void backToListBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
