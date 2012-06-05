using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhillyDotNetAlt.Raven.Domain.Model
{
    public class Post
    {
        public int Id { get; set; }
        public String Content { get; set; }
        public String By { get; set; }
        public int Hates { get; set; }
        public IList<String> Tags { get; set; }

        public Post()
        {
            Tags = new List<string>();
        }
    }
}
