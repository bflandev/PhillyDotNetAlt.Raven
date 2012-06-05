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
                    var query = session.Query<TagCount>("Posts/TagCount");
                    foreach (var tagcount in query)
                    {
                        Console.WriteLine("{0}-{1}", tagcount.Tag,tagcount.Count);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
