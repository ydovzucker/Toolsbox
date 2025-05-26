using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PracticeHttp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string jsonFromServer = await DevNews.recentPosts();
        
            Convert[] json = JsonSerializer.Deserialize<Convert[]>(jsonFromServer);
          

            //string userId { Get;Set; }
        
            for (int i = 0; i <= 5;i ++)
            {
                Console.WriteLine(json[i].title);
            }

        }
    }
}
