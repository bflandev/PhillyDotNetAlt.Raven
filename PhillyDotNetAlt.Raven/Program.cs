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
                    var post = session.Load<Post>(2);
                    post.Tags.Add("Ruby");
                    post.Hates++;
                    session.Store(post);
                    session.SaveChanges();
                }
            }
            Console.ReadLine();
        }
    }
}
