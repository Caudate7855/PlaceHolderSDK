using System.Runtime.Serialization;

namespace PlaceHolderSDK
{
    [DataContract]
    public class PostCreateRequest
    {
        [DataMember(Name = "userId")]
        public int UserId;

        [DataMember(Name = "title")]
        public string Title;

        [DataMember(Name = "body")]
        public string Body;
    }
}