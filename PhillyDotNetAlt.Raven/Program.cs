using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                    
                }
            }
        }
    }
}
