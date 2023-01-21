using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public class Post
    {
        public Post()
        {
            Votes = 0;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public int Votes { get; private set; }

        public void UpVote()
        {
            Votes++;
        }

        public void DownVote()
        {
            if (Votes != 0)
                Votes--;
        }
    }
}
