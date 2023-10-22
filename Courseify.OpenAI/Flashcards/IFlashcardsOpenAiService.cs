using Azure.AI.OpenAI;
using Courseify.OpenAI.Data;

namespace Courseify.OpenAI.Flashcards
{
    public interface IFlashcardsOpenAiService
    {
        FunctionDefinition FlashcardDef();
        Task<List<Flashcard>> GetFlashcards(string context);
    }
}