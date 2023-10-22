using Azure.AI.OpenAI;
using Courseify.OpenAI.Data;

namespace Courseify.OpenAI
{
    public interface IOpenAiService
    {
        Task<List<MultipleChoiceQuestion>> GetQuizzes(string context);
        FunctionDefinition QuizDef();
    }
}