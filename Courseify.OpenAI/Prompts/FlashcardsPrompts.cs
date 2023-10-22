using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courseify.OpenAI.Prompts
{
    public static class FlashcardsPrompts
    {
        public const string FlashcardSystemPrompt = @"You are a flashcard generator. Given context, you are to generate 10 multiple choice questions for a quiz in the given json format.";
    }
}
