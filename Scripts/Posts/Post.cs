using System.Runtime.Serialization;

namespace PlaceHolderSDK
{
    [DataContract]
    public class Post
    {
        [DataMember(Name = "id")]
        public int Id;

        [DataMember(Name = "userId")]
        public int UserId;

        [DataMember(Name = "title")]
        public string Title;

        [DataMember(Name = "body")]
        public string Body;
    }
}