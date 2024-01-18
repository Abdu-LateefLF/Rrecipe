# Rrecipe
Rrecipe is a Windows-based recipe organizer application that I made using C# and SQL. It is a user-friendly platform where individuals can seamlessly create, manage, and search for their favorite recipes

# Features
* Database Integration: Integrated a MySQL database for robust user authentication and efficient storage of personalized recipes.

* Comprehensive Functionality: Engineered features for recipe creation, deletion, and a search function to enhance the overall user experience.

* Streamlined User Interface: Introduced a 'View Recipes' tab and incorporated a search algorithm, focusing on creating a straightforward and efficient user interface.

# How it works
When you open it up, you will see the login page where you can create a new account or login into an existing one.Screenshot 2024-01-17 120205

I have included checks to prevent issues due to:

Username, password, or both being empty.
Trying to register with a taken username.
Trying to login with an incorrect username or password.Screenshot 2024-01-17 120404
Once you have logged in you are brought to the 'Create Recipe' page. Here you can enter the name, preparation time, description, and instructions and add and remove ingredients. Once you are finished creating your recipe you can save it to your account or clear the recipe to restart. I have included checks to ensure:

Recipe name and prepation time are not empty.
Preparation time is an integer.
Ingredients added to the ingredient list are not empty.
I am using a recipe I found online (Link to site below)Screenshot 2024-01-17 122024Screenshot 2024-01-17 123630

You can navigate to the 'View Recipes' tab to see all the recipes created on your account.Screenshot 2024-01-17 124217

You can you the search bar to filter through your recipes based on thier names. I added more recipes so we can see what it looks like :).Screenshot 2024-01-17 125448Screenshot 2024-01-17 125724

You can press the 'View' button on each recipe to see the entirety of its contents.Screenshot 2024-01-17 125917

And you can press 'Delete' to remove a recipe.Screenshot 2024-01-17 182336Screenshot 2024-01-17 182629

Links
Recipes from https://www.allrecipes.com
