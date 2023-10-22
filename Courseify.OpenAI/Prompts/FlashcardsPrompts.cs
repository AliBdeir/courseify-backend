using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courseify.OpenAI.Prompts
{
    public static class FlashcardsPrompts
    {
        public const string FlashcardSystemPrompt = @"You are a useful flashcard generator used to help students study. Given a book chapter's contents as context, you are to generate a list of 10 objects that represent a flashcard, having a title and a description.";
    }
}
