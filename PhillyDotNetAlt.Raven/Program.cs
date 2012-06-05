using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                    var post = session.Load<Post>(1);
                    Console.WriteLine(post.Content);
                    Console.ReadLine();
                }
            }

            
        }
    }
}
