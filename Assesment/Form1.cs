namespace Assesment
{
    public partial class Form1 : Form
    {
        List<Recipe> recipes;
        public Form1()
        {
            InitializeComponent();
            recipes = new List<Recipe>();
            recipes.Add(new Recipe("Eggs Benedict"));
            recipes[0].addIngredient(" 4 Large eggs");
            recipes[0].addIngredient("8 slices of bacon");
            recipes[0].addIngredient("2 teaspoons of white vinegar");
            recipes[0].addIngredient("2 english muffins");
            recipes[0].addIngredient("Butter");
            recipes[0].addIngredient("2 tablespoons of chopped parsley");
            recipes.Add(new Recipe("chicken curry"));
            recipes[1].addIngredient(" 2 tablespoon of sunflower oil");
            recipes[1].addIngredient("1 onion thinly sliced");
            recipes[1].addIngredient("2 garlic onions crushed");
            recipes[1].addIngredient("piece of ginger");
            recipes[1].addIngredient("6 chicken thighs");
            recipes[1].addIngredient("3 tablespoon meduim spice paste");
            recipes[1].addIngredient("400grams of chopped tomato");
            recipes[1].addIngredient("100grams of greek yogurt");
            recipes[1].addIngredient("1 small bunch of coriandor");
            recipes[1].addIngredient("50g of ground almonds");
            recipes.Add(new Recipe("choclate waffle"));
            recipes[2].addIngredient("1 cup of purpose flour");
            recipes[2].addIngredient("1 cup of duthc process cocoa");
            recipes[2].addIngredient("1 cup of granulated sugar");
            recipes[2].addIngredient("1 teapsoon of salt");
            recipes[2].addIngredient("2 eggs");
            recipes[2].addIngredient("1 cup of oil");
            recipes[2].addIngredient("2 cups of milk");

        }

        private List<Recipe> findByIngredient(string ingredient)
        {
            List<Recipe> recipesFound = new List<Recipe>();
            for(int i = 0; i < recipes.Count(); i++)
            {
                for(int j = 0; j < recipes[i].ingredientsList.Count(); j++)
                {
                    if (recipes[i].ingredientsList[j].Contains(ingredient)) ;
                    {
                        recipesFound.Add(recipes[i]);
                        break;
                    }
                    
                }
            }
            
            //Search the list of recipes for the ingredient, and if the ingredient is in the list, put the recipe into recipes found
            return recipesFound;

        }

        private void Recipe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Addbtn1_Click(object sender, EventArgs e)
        {
            string newingredient = txtbox1.Text;
            if (newingredient.Length > 0)
            {
                Ingredientslstbox.Items.Add(newingredient);
            }
        }

        private void Deletebtn1_Click(object sender, EventArgs e)
        {
            if (Ingredientslstbox.SelectedItem != null)
            {
                string currentlyselected = Ingredientslstbox.SelectedItem.ToString();
                Ingredientslstbox.Items.Remove(currentlyselected);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string ingredientName = Ingredientslstbox.SelectedItem.ToString();
            List<Recipe> recipesFound = findByIngredient(ingredientName);
            foreach (Recipe recipefound in recipesFound)
            {
                recipeListBox.Items.Add(recipefound.recipeName);
            }

        }
    }
}


//collections
