using System;

namespace RecipeApplication
{
    // Class to represent an ingredient in a recipe
    class Ingredient
    {
        public string Name { get; set; }     // Name of the ingredient
        public double Quantity { get; set; } // Quantity of the ingredient
        public string Unit { get; set; }     // Unit of measurement for the ingredient
    }
}