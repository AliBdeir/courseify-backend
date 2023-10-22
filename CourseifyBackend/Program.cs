using Courseify.DataAccessLayer;
using Courseify.OpenAI.Quiz;
using Courseify.PdfMan.Bookmarks;
using Courseify.PdfMan.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ISessionDatabaseService, SessionDatabaseService>();
builder.Services.AddScoped<IPdfTextService, PdfTextService>();
builder.Services.AddScoped<IPdfBookmarkService, PdfBookmarkService>();
builder.Services.AddScoped<IQuizOpenAiService, QuizOpenAiService>();
//builder.Services.AddOpenAi(settings =>
//{
//    settings.ApiKey = Environment.GetEnvironmentVariable("AzureApiKey") ?? throw new Exception("Azure api key is null");
//    settings.Azure.ResourceName = "canadaeastalibdeir";
//    settings.Azure.MapDeploymentChatModel("alibdeiropenai", Rystem.OpenAi.ChatModelType.Gpt4_32K);
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseDeveloperExceptionPage();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
