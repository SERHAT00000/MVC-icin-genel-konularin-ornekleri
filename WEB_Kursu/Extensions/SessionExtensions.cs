using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace WEB_Kursu.Extensions
{
    public static class SessionExtensions
    {
        public static void SetJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T? GetJson<T>(this ISession session, string key) where T : class
        {
            var value = session.GetString(key);
            
            return value == null ? null : JsonSerializer.Deserialize<T>(value);
        }
    }
}
