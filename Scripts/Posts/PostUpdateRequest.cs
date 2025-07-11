using System.Runtime.Serialization;

namespace PlaceHolderSDK
{
    [DataContract]
    public class PostUpdateRequest
    {
        [DataMember(Name = "title")]
        public string Title;

        [DataMember(Name = "body")]
        public string Body;
    }
}