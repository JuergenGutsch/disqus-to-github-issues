using System;
using System.Collections.Generic;

namespace DisqusToGithubIssues
{
    public class Thread
    {
        public long Id { get; }

        public string Title { get; set; }

        public string Url { get; set; }

        public List<Post> Posts { get; }

        public DateTime CreatedAt { get; set; }

        public Thread(long id)
        {
            Id = id;
            Posts = new List<Post>();
        }
    }
}