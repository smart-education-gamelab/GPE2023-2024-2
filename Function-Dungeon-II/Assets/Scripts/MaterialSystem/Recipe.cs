using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MaterialSystem
{
    /// <summary>
    /// Recipe class that holds the required materials for crafting an item
    /// </summary>
    [CreateAssetMenu(fileName = "NewRecipe", menuName = "Crafting/Recipe")]
    public class Recipe : ScriptableObject
    {
        [SerializeField] private string recipeName;
        [SerializeField] private Item item;
        [SerializeField] private List<MaterialRequirement> requiredMaterials;
        
        /// <summary>
        /// List of required materials
        /// </summary>
        public List<MaterialRequirement> RequiredMaterials => requiredMaterials;
        
        public string RecipeName => recipeName;
        
        public Item Item => item;
    
        /// <summary>
        /// Returns the recipe details
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetRecipeDetails()
        {
            return requiredMaterials.ToDictionary(material => material.Material.ItemName, material => material.Amount);
        }
    }
}