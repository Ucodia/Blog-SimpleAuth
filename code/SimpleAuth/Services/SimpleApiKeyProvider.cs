namespace Ucodia.SimpleAuth.Services
{
    public class SimpleApiKeyProvider : IApiKeyProvider
    {
        private const string ApiKey = "iL0UCJtAwwq8nVjvUJoVkM9CjFhyycLp";

        public string GetApiKey()
        {
            return ApiKey;
        }
    }
}