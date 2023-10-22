using Firebase.Database;
using Firebase.Database.Query;
using static Courseify.PdfMan.Bookmarks.IPdfBookmarkService;

namespace Courseify.DataAccessLayer
{
    public class SessionDatabaseService : ISessionDatabaseService
    {
        private readonly string appSecret;
        const string baseUrl = "https://courseify-4b7d9-default-rtdb.firebaseio.com/";

        public SessionDatabaseService()
        {
            appSecret = Environment.GetEnvironmentVariable("Firebase_Secret") ?? throw new Exception("Firebase secret not found");
        }

        public async Task<string> GenerateSession(BookmarkNode node)
        {
            using FirebaseClient firebaseClient = GetFirebaseClient();
            FirebaseObject<BookmarkNode> result = await firebaseClient.Child("Sessions")
                .PostAsync(node);
            return result.Key;
            //var dataToSave = new { Name = "John", Age = 30 };
            //await firebaseClient
            //    .Child("Users")
            //    .PostAsync(dataToSave);

            //// Read data from database
            //var data = await firebaseClient
            //    .Child("Users")
            //    .OnceAsync<dynamic>();

            //foreach (var item in data)
            //{
            //    Console.WriteLine($"{item.Object.Name}, {item.Object.Age}");
            //}
        }

        private FirebaseClient GetFirebaseClient()
        {
            return new FirebaseClient(baseUrl, new FirebaseOptions()
            {
                AuthTokenAsyncFactory = () => Task.FromResult(appSecret)
            });
        }
    }
}