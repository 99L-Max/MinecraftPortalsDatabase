using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace MinecraftPortalsDatabase
{
    static class JsonManager
    {
        public static Dictionary<TKey, TValue> GetDictionary<TKey, TValue>(byte[] array)
        {
            var jString = Encoding.UTF8.GetString(array);
            return JsonConvert.DeserializeObject<Dictionary<TKey, TValue>>(jString);
        }
    }
}
