using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class Recipe
    {
        public Recipe(string recipeName)
        {
            this.recipeName = recipeName;
            ingredientsList = new List<string>();
        }

        ~Recipe()
        {
            
        }

        public string recipeName;
        public List<string> ingredientsList;
        public string recipePicture;

        public void addIngredient(string ingredient)
        {
            ingredientsList.Add(ingredient);
        }

        
    }
}
