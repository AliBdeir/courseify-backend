using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courseify.OpenAI.Prompts
{
    public class AssignmentPrompts
    {
        public const string AssignmentCreationText = @"You are an AI tutor that creates a multi-problem assignment given a book's chapter as context. You are allowed to use LaTEX and MarkDown as your response is exactly what the user will see and the markdown/latex will be rendered";

        public const string AssignmentGradingText = "You are an AI tutor that grades the student's response to your assignment. You have to start your grading with a grade out of 10 like 10/10. Be very fair, even a 10 is possible. Refer to the student as \"you\"";

    }
}
