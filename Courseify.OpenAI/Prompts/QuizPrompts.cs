using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courseify.OpenAI.Prompts
{
    public static class QuizPrompts
    {
        public const string QuizGenerationPromptSystem = @"You are a Quiz generator. Given context, you are to generate 10 multiple choice questions for a quiz in the given json format.";
    }
}
