using System;
using System.Linq;
using PhillyDotNetAlt.Raven.Domain.Model;
using Raven.Client.Document;

namespace PhillyDotNetAlt.Raven
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var store = new DocumentStore{Url="http://bflanagan-lp:8081"}.Initialize())
            {
                using (var session = store.OpenSession())
                {
                    var posts = session.Query<Post>().Where(x => x.By == "Vadim");
                    foreach (var post in posts)
                    {
                        Console.WriteLine(String.Concat(post.Content,"(",post.Hates,")"));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
