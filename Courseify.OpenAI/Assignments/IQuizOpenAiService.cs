using Azure.AI.OpenAI;
using Courseify.OpenAI.Data;

namespace Courseify.OpenAI.Assignments
{
    public interface IAssignmentOpenAiService
    {
        Task<string> GetAssignment(string context);
        Task<string> RateAssignment(string userInput, string assignment);
    }
}