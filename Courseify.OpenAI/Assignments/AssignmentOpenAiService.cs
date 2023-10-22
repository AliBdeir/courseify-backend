using Azure.AI.OpenAI;
using Azure;
using Courseify.OpenAI.Prompts;
using Polly;
using Rystem.OpenAi;
using System.Text.Json.Serialization;
using System.Text.Json;
using Courseify.OpenAI.Data;

namespace Courseify.OpenAI.Assignments
{
    public class AssignmentOpenAiService : IAssignmentOpenAiService
    {
        public AssignmentOpenAiService()
        {
        }

        public async Task<string> GetAssignment(string context)
        {
            OpenAIClient client = new OpenAIClient(new Uri("https://canadaeastalibdeir.openai.azure.com/"), new AzureKeyCredential(Environment.GetEnvironmentVariable("AzureApiKey") ?? throw new Exception("Azure api key is null")));
            var conversationMessages = new List<ChatMessage>()
            {
                
            };
            // ### If streaming is not selected
            Response<ChatCompletions> responseWithoutStream = await client.GetChatCompletionsAsync(
                "alibdeiropenai",
                new ChatCompletionsOptions()
                {
                    Messages =
                    {
                        new(ChatRole.System, AssignmentPrompts.AssignmentCreationText+ context),
                    },
                    Temperature = (float)0.7,
                    MaxTokens = 800,
                    NucleusSamplingFactor = (float)0.95,
                    FrequencyPenalty = 0,
                    PresencePenalty = 0,
                });
            return responseWithoutStream.Value.Choices[0].Message.Content;
        }

        public async Task<string> RateAssignment(string userInput, string assignment)
        {
            OpenAIClient client = new OpenAIClient(new Uri("https://canadaeastalibdeir.openai.azure.com/"), new AzureKeyCredential(Environment.GetEnvironmentVariable("AzureApiKey") ?? throw new Exception("Azure api key is null")));
            var conversationMessages = new List<ChatMessage>()
            {

            };
            // ### If streaming is not selected
            Response<ChatCompletions> responseWithoutStream = await client.GetChatCompletionsAsync(
                "alibdeiropenai",
                new ChatCompletionsOptions()
                {
                    Messages =
                    {
                        new(ChatRole.System, AssignmentPrompts.AssignmentGradingText),
                        new(ChatRole.User, $"Your assignment was:\n{assignment}The student entered:\n{userInput}"),
                    },
                    Temperature = (float)0.7,
                    MaxTokens = 800,
                    NucleusSamplingFactor = (float)0.95,
                    FrequencyPenalty = 0,
                    PresencePenalty = 0,
                });
            return responseWithoutStream.Value.Choices[0].Message.Content;
        }

     
    }
}