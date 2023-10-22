using Courseify.PdfMan.Bookmarks.Data;
using Firebase.Database;
using Firebase.Database.Query;

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

        public async Task<string> GenerateSession(BookmarkNodeWithText node)
        {
            using FirebaseClient firebaseClient = GetFirebaseClient();
            FirebaseObject<BookmarkNodeWithText> result = await firebaseClient.Child("Sessions")
                .PostAsync(node);
            return result.Key;
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