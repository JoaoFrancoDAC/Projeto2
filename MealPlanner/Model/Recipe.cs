using System;
using System.Collections.Generic;

namespace MealPlanner.Model
{
    public class Recipe : IRecipe
    {
        public string Name { get; }
        public IReadOnlyDictionary<IIngredient, int> IngredientsNeeded { get; }
        public double SuccessRate { get; }

        public Recipe(string name, Dictionary<IIngredient, int> ingredientsNeeded, double successRate)
        {
            Name = name;
            IngredientsNeeded = new Dictionary<IIngredient, int>(ingredientsNeeded);
            SuccessRate = successRate;
        }

        public int CompareTo(IRecipe other)
        {
            if (other == null)
                return 1;

            return string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
}