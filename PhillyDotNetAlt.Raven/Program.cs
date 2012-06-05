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
                    var post = new Post {Id = 1, By = "Brian", Content = "RavenDb is cool", Hates = 100};
                    session.Store(post);
                    session.SaveChanges();
                }
            }
        }
    }
}
