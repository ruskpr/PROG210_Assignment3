using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerNewsLibrary
{
    public class Comment
    {
        #region Properties
        public Thread ParentThread { get; set; }
        public User Author { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; }
        public int UpVotes { get; set; }
        #endregion

        #region Constructor
        public Comment(Thread parentThread, User author, string content)
        {
            ParentThread = parentThread;
            Author = author;    
            Content = content;
            DateCreated = DateTime.Now;
            UpVotes = 0;
        }
        #endregion

        #region Methods
        public void UpVote() => UpVotes++;

        public override string ToString() =>
            $"{Author}'s comment on {ParentThread}";
        #endregion
    }
}
