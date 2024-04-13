using AIChef.Shared;

namespace AIChef.Server.Services
{
    public interface IOpenAIAPI
    {
        Task<List<RecipeIdea>> CreateRecipeIdeas(string mealtime, List<string> ingredients);
        


    }
}
