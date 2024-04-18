using AIChef.Shared;

namespace AIChef.Server.Services
{
    public interface IOpenAIAPI
    {
        Task<List<RecipeIdea>> CreateRecipeIdeas(string aMealtime, List<string> aIngredients);
        
        Task<Recipe?> CreateRecipe(string aTitle, List<string> aIngredients);

    }
}
