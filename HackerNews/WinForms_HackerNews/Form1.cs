using HackerNewsLibrary;
using Thread = HackerNewsLibrary.Thread;

namespace WinForms_HackerNews
{
    public partial class Form1 : Form
    {
        public static List<User> users = new List<User>();
        public static List<Thread> threads = new List<Thread>();


        public Form1()
        {
            InitializeComponent();

            threads.AddRange(AddThreads());

            foreach (Thread t in threads)
                ThreadBox.Boxes.Add(new ThreadBox(t));

            foreach (ThreadBox t in ThreadBox.Boxes)
                flowContainer.Controls.Add(t);
        }

        // add users to list
        private List<User> AddUsers()
        {
            List<User> users = new List<User>();

            users.Add(new User("russ", "password", "russ@email.com"));
            users.Add(new User("ron", "password", "ron@email.com"));

            return users;
        }

        private List<Thread> AddThreads()
        {
            //get users from AddUsers method and attach them to thread
            users.AddRange(AddUsers());
            List<Thread> threads = new List<Thread>();

            threads.Add(new Thread(users[1], "Inflation is going up.", "https://news.ycombinator.com/", "lorem ipsum."));
            threads.Add(new Thread(users[0], "Global warming is a serious issue.", "https://www.youtube.com/", "lorem ipsum test."));

            return threads;
        }
    }
}