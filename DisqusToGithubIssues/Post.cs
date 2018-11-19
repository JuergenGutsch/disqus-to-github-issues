using System;

namespace DisqusToGithubIssues
{
    public class Post
    {
        public long Id { get; }
        public long ThreadId { get; set; }
        public long Parent { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Author { get; set; }

        public Post(long id)
        {
            Id = id;
        }
    }
}