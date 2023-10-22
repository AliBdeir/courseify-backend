using Azure.AI.OpenAI;
using Azure;
using Courseify.OpenAI.Data;
using Courseify.OpenAI.Prompts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Courseify.OpenAI.Flashcards
{
    public class FlashcardsOpenAiService : IFlashcardsOpenAiService
    {
        public FlashcardsOpenAiService() { }

        public async Task<List<Flashcard>> GetFlashcards(string context)
        {
            OpenAIClient client = new OpenAIClient(new Uri("https://canadaeastalibdeir.openai.azure.com/"), new AzureKeyCredential(Environment.GetEnvironmentVariable("AzureApiKey") ?? throw new Exception("Azure api key is null")));
            var conversationMessages = new List<ChatMessage>()
            {
                new(ChatRole.System, FlashcardsPrompts.FlashcardSystemPrompt + context),
            };

            var chatCompletionsOptions = new ChatCompletionsOptions();
            foreach (ChatMessage chatMessage in conversationMessages)
            {
                chatCompletionsOptions.Messages.Add(chatMessage);
            }
            chatCompletionsOptions.Functions.Add(FlashcardDef());

            Response<ChatCompletions> response = await client.GetChatCompletionsAsync(
                "alibdeiropenai",
                chatCompletionsOptions);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            return JsonSerializer.Deserialize<FlashcardResult>(response.Value.Choices[0].Message.Content, options)!.Flashcards;

        }

        public FunctionDefinition FlashcardDef()
        {
            return new FunctionDefinition()
            {
                Name = "get_flashcards",
                Description = "Retrieve an array of objects that represent a flashcard given the book chapter's content as context. Each flashcard has a \"title\" and \"description\"",
                Parameters = BinaryData.FromObjectAsJson(
    new
    {
        Type = "object",
        Properties = new
        {
            Flashcards = new
            {
                Type = "array",
                Items = new
                {
                    Type = "object",
                    Properties = new
                    {
                        Title = new
                        {
                            Type = "string",
                            Description = "Title of a flashcard which will have a description/definition",
                        },
                        Description = new
                        {
                            Type = "string",
                            Description = "Description/Definition of the title of the flashcard.",
                        },
                    },
                }
            }
        },
        Required = new[] { "flashcards", "title", "description" },
    },
    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }),
            };

        }

    }
}
