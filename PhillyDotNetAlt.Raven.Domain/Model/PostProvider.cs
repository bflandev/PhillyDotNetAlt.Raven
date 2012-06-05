using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhillyDotNetAlt.Raven.Domain.Model
{
    public class PostProvider
    {
        public IList<Post> GetPosts()
        {
            return new List<Post>
                       {
                           new Post{Content = "RavenDB is cool.",By = "Brian",Hates = 100},
                           new Post{Content = "Sql is lame", By ="Brian",Hates = 0},
                           new Post{Content = "Anything that isn't ruby sucks",By="Vadim"}
                       };
        }
    }
}
