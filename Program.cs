using System;

namespace RecipeApplication
{
    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the details for the recipe:");

            // Get the number of ingredients from user input
            Console.Write("Number of ingredients: ");
            int numOfIngredients = int.Parse(Console.ReadLine());

            // Get the number of steps from user input
            Console.Write("Number of steps: ");
            int numOfSteps = int.Parse(Console.ReadLine());

            // Create a new Recipe object with the provided number of ingredients and steps
            Recipe recipe = new Recipe(numOfIngredients, numOfSteps);

            // Enter details for each ingredient
            recipe.EnterIngredients();
            // Enter details for each step
            recipe.EnterSteps();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nCommands:");
                Console.WriteLine("1. Display recipe");
                Console.WriteLine("2. Scale recipe");
                Console.WriteLine("3. Reset quantities");
                Console.WriteLine("4. Clear all data");
                Console.WriteLine("5. Exit");

                Console.Write("\nEnter command number: ");
                int command = int.Parse(Console.ReadLine());

                switch (command)
                {
                    case 1:
                        // Display the recipe
                        recipe.DisplayRecipe();
                        break;
                    case 2:
                        Console.Write("\nEnter scaling factor: ");
                        double factor = double.Parse(Console.ReadLine());
                        // Scale the recipe by the provided factor
                        recipe.ScaleRecipe(factor);
                        Console.WriteLine("\nRecipe scaled successfully!");
                        break;
                    case 3:
                        // Reset the quantities of ingredients
                        recipe.ResetQuantities();
                        Console.WriteLine("\nQuantities reset successfully!");
                        break;
                    case 4:
                        // Clear all data in the recipe
                        recipe.ClearRecipe();
                        Console.WriteLine("\nRecipe cleared successfully!");
                        break;
                    case 5:
                        // Exit the program
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid command!");
                        break;
                }
            }
        }
    }
}