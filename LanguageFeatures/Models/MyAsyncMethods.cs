using System.Net.Http;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        //public static Task<long?> GetPageLength()
        //{
        //    HttpClient client = new HttpClient();

        //    var httpTask = client.GetAsync("http://apress.com");

        //    return httpTask.ContinueWith(
        //        (Task<HttpResponseMessage> antecedent) => antecedent.Result.Content.Headers.ContentLength);
        //}

        public async static Task<long?> GetPageLength()
        {
            HttpClient client = new();

            var httpMassage = await client.GetAsync("http://apress.com");

            return httpMassage.Content.Headers.ContentLength;
        }
    }
}
