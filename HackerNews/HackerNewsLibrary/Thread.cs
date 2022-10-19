using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerNewsLibrary
{
    public class Thread
    {
        public List<Comment> Comments = new List<Comment>();


        public User Username { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }


        public Thread(User user, string title, string link, string desc)
        {
            Username = user;
            Title = title;
            Link = link;
            Description = desc;
            DateCreated = DateTime.Now;
        }
    }
}
