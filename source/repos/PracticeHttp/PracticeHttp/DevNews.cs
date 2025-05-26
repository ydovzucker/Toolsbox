using System;
using System.Net.Http;
using System.Threading.Tasks;

class DevNews
{
    public static async Task<string> recentPosts()
        
    {
        using (HttpClient Client = new HttpClient())
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            HttpResponseMessage Response = await Client.GetAsync(url);
            string content = await Response.Content.ReadAsStringAsync();
            //Console.WriteLine(content);
            return content;


        }
    }
}
