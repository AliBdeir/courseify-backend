using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courseify.OpenAI.Data
{
    public class FlashcardResult
    {
        public required List<Flashcard> Flashcards { get; set; }
    }

    public class Flashcard
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
    }

}
