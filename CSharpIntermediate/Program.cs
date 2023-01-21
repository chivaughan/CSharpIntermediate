
using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post
            {
                Id = 1,
                Title = "What is C#",
                Description = "This article describes the C# programming language",
                CreationDate = DateTime.Now                
            };

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.DownVote();
            Console.WriteLine("Votes: " + post.Votes);

        }
    }
}
