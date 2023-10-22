using Azure.AI.OpenAI;
using Courseify.OpenAI.Data;

namespace Courseify.OpenAI.Quiz
{
    public interface IQuizOpenIService
    {
        Task<List<MultipleChoiceQuestion>> GetAssignment(string context);
        FunctionDefinition QuizDef();
    }
}