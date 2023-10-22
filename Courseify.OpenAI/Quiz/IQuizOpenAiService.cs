using Azure.AI.OpenAI;
using Courseify.OpenAI.Data;

namespace Courseify.OpenAI.Quiz
{
    public interface IQuizOpenAiService
    {
        Task<List<MultipleChoiceQuestion>> GetQuizzes(string context);
        FunctionDefinition QuizDef();
    }
}