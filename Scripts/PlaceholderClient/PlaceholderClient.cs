using System.Collections.Generic;
using System.Net;

namespace PlaceHolderSDK
{
    public class PlaceholderClient
    {
        private const string BaseUrl = "https://jsonplaceholder.typicode.com/";

        public List<Post> GetPosts()
        {
            var endpoint = $"{BaseUrl}posts";
            var request = (HttpWebRequest)WebRequest.Create(endpoint);
            request.Method = "GET";

            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                return JsonUtils.Deserialize<List<Post>>(stream);
            }
        }

        public Post CreatePost(PostCreateRequest post)
        {
            var endpoint = $"{BaseUrl}posts";
            var request = (HttpWebRequest)WebRequest.Create(endpoint);
            request.Method = "POST";
            request.ContentType = "application/json";

            using (var requestStream = request.GetRequestStream())
            {
                JsonUtils.Serialize(post, requestStream);
            }

            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                return JsonUtils.Deserialize<Post>(stream);
            }
        }

        public Post UpdatePost(int id, PostUpdateRequest update)
        {
            var endpoint = $"{BaseUrl}posts/{id}";
            var request = (HttpWebRequest)WebRequest.Create(endpoint);
            request.Method = "PUT";
            request.ContentType = "application/json";

            using (var requestStream = request.GetRequestStream())
            {
                JsonUtils.Serialize(update, requestStream);
            }

            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                return JsonUtils.Deserialize<Post>(stream);
            }
        }

        public void DeletePost(int id)
        {
            var endpoint = $"{BaseUrl}posts/{id}";
            var request = (HttpWebRequest)WebRequest.Create(endpoint);
            request.Method = "DELETE";

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                // Сервер возвращает (500) Internal Server Error
            }
        }
    }
}