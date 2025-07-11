using System.IO;
using System.Runtime.Serialization.Json;

namespace PlaceHolderSDK.Utils
{
    internal static class JsonUtils
    {
        public static T Deserialize<T>(Stream stream)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));
            return (T)serializer.ReadObject(stream);
        }

        public static void Serialize<T>(T obj, Stream stream)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));
            serializer.WriteObject(stream, obj);
        }
    }
}