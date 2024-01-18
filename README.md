# Rrecipe
Rrecipe is a Windows-based recipe organizer application that I made using C# and SQL. It is a user-friendly platform where individuals can seamlessly create, manage, and search for their favorite recipes.

# Features
* Database Integration: Integrated a MySQL database for robust user authentication and efficient storage of personalized recipes.

* Comprehensive Functionality: Engineered features for recipe creation, deletion, and a search function to enhance the overall user experience.

* Streamlined User Interface: Introduced a 'View Recipes' tab and incorporated a search algorithm, focusing on creating a straightforward and efficient user interface.

# How it works
When you open it up, you will see the login page where you can create a new account or login into an existing one.
![Screenshot 2024-01-17 120205](https://github.com/Abdu-LateefLF/Rrecipe/assets/101940953/f2a42db3-d5c7-42b1-8332-7d8cf87c519b)

I have included checks to prevent issues due to:
* Username, password, or both being empty.
* Trying to register with a taken username.
* Trying to login with an incorrect username or password.
![Screenshot 2024-01-17 120404](https://github.com/Abdu-LateefLF/Rrecipe/assets/101940953/26288f5f-2b5d-428f-a96a-bb30164e795e)

Once you have logged in you are brought to the 'Create Recipe' page. Here you can enter the name, preparation time, description, and instructions and add and remove ingredients. Once you are finished creating your recipe you can save it to your account or clear the recipe to restart. I have included checks to ensure:

Recipe name and prepation time are not empty.
* Preparation time is an integer.
* Ingredients added to the ingredient list are not empty.

I am using a recipe I found online (Link to site below)
![Screenshot 2024-01-17 122024](https://github.com/Abdu-LateefLF/Rrecipe/assets/101940953/97dd8d9a-35f6-411e-b5b8-c58cb6096427)
![Screenshot 2024-01-17 123630](https://github.com/Abdu-LateefLF/Rrecipe/assets/101940953/0f3411a2-e975-4537-aefd-788e5cf6ed6f)

You can navigate to the 'View Recipes' tab to see all the recipes created on your account.
![Screenshot 2024-01-17 124217](https://github.com/Abdu-LateefLF/Rrecipe/assets/101940953/83165f01-8f4b-42bb-a033-355e5c18223a)

You can you the search bar to filter through your recipes based on thier names. I added more recipes so we can see what it looks like :)
![Screenshot 2024-01-17 125448](https://github.com/Abdu-LateefLF/Rrecipe/assets/101940953/2f72649e-82ba-4f78-a816-74f658950bcc)
![Screenshot 2024-01-17 125724](https://github.com/Abdu-LateefLF/Rrecipe/assets/101940953/09327b42-37d8-4a4e-beea-4e4aff6ee9b6)

You can press the 'View' button on each recipe to see the entirety of its contents.
![Screenshot 2024-01-17 125917](https://github.com/Abdu-LateefLF/Rrecipe/assets/101940953/f52dd659-b4d2-45cf-885d-ddb178a84edb)

And you can press 'Delete' to remove a recipe.
![Screenshot 2024-01-17 125724](https://github.com/Abdu-LateefLF/Rrecipe/assets/101940953/26ea906d-bf89-4d54-8c51-9cbdd0872713)
![Screenshot 2024-01-17 182629](https://github.com/Abdu-LateefLF/Rrecipe/assets/101940953/3ce51592-ae79-4dd9-995d-3aa6569e4c59)

Links
Recipes from https://www.allrecipes.com
