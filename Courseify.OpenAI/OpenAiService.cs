using Azure.AI.OpenAI;
using Azure;
using Courseify.OpenAI.Prompts;
using Polly;
using Rystem.OpenAi;
using System.Text.Json.Serialization;
using System.Text.Json;
using Courseify.OpenAI.Data;

namespace Courseify.OpenAI
{
    public class OpenAiService
    {
        private readonly IOpenAiFactory openai;
        public OpenAiService(IOpenAiFactory openai)
        {
            this.openai = openai;
        }

        public async Task GetQuizzes(string context)
        {
            OpenAIClient client = new OpenAIClient(new Uri("https://canadaeastalibdeir.openai.azure.com/"), new AzureKeyCredential(Environment.GetEnvironmentVariable("AzureApiKey") ?? throw new Exception("Azure api key is null")));
            var conversationMessages = new List<ChatMessage>()
            {
                new(ChatRole.System, QuizPrompts.QuizGenerationPromptSystem + context),
            };

            var chatCompletionsOptions = new ChatCompletionsOptions();
            foreach (ChatMessage chatMessage in conversationMessages)
            {
                chatCompletionsOptions.Messages.Add(chatMessage);
            }
            chatCompletionsOptions.Functions.Add(QuizDef());

            Response<ChatCompletions> response = await client.GetChatCompletionsAsync(
                "alibdeiropenai",
                chatCompletionsOptions);
            return JsonSerializer.Deserialize<List<MultipleChoiceQuestion>>(response.Value.Choices[0].Message.Content);

        }

        public FunctionDefinition QuizDef()
        {
            return new FunctionDefinition()
            {
                Name = "get_multiple_choice_questions",
                Description = "Retrieve an array containing 10 sets of multiple-choice questions",
                Parameters = BinaryData.FromObjectAsJson(
    new
    {
        Type = "object",
        Properties = new
        {
            SetId = new
            {
                Type = "integer",
                Description = "The unique identifier for the question set",
            },
            Options = new
            {
                Type = "array",
                Items = new
                {
                    Type = "object",
                    Properties = new
                    {
                        ChoiceId = new
                        {
                            Type = "string",
                            Description = "The unique identifier for the choice",
                        },
                        Text = new
                        {
                            Type = "string",
                            Description = "The text content of the choice"
                        }
                    }
                }
            },
            CorrectChoiceId = new
            {
                Type = "string",
                Description = "The 'choiceId' indicating the correct answer"
            }
        },
        Required = new[] { "setId", "options", "correctChoiceId" },
    },
    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }),
            };

        }

    }
}