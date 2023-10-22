using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courseify.OpenAI.Data
{
    public class MultipleChoiceQuestion
    {
        public int SetId { get; set; }
        public required List<Option> Options { get; set; }
        public required string CorrectChoiceId { get; set; }
    }

    public class Option
    {
        public required string ChoiceId { get; set; }
        public required string Text { get; set; }
    }
}
