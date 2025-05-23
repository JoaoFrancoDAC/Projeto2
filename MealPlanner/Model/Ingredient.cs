
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace MealPlanner.Model
{
    public class Ingredient : IIngredient
    {
        public string Name { get; }
        public string Type { get; }

        public Ingredient(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public bool Equals(IIngredient other)
        {
            if (other == null)
                return false;

            return string.Equals(Name, other.Name, StringComparison.OrdinalIgnoreCase) &&
                   string.Equals(Type, other.Type, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as IIngredient);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name.ToLowerInvariant(), Type.ToLowerInvariant());
        }
    }
}