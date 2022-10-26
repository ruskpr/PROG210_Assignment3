using HackerNewsLibrary;
using System.DirectoryServices;
using Thread = HackerNewsLibrary.Thread;

namespace WinForms_HackerNews
{
    public partial class Form1 : Form
    {
        #region Static lists (users & threads)
        public static List<User> users = new List<User>();
        public static List<Thread> threads = new List<Thread>();
        #endregion
        #region Fields
        private NavBar nav;
        private Random rnd = new Random();
        #endregion
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(750, 300);
            flowContainer.Left = 0;
            flowContainer.Top = 36;
            UpdateContainer();

            //initialize nav bar
            nav = new NavBar(this);
            nav.NavbarClick += Nav_NavbarClick;
            nav.SendSearch += Nav_SendSearch;

            GenerateNewThreads();
        }
        #endregion
        #region Delegates
        // if anything on the nav bar is clicked show new threads
        private void Nav_NavbarClick() => GenerateNewThreads();
        // search specific thread
        private void Nav_SendSearch(string searchText)
        {
            List<Thread> searchResult = new List<Thread>();
            List<ThreadBox> tmpThreadBox = new List<ThreadBox>();

            foreach (Thread thread in threads)
                if (thread.Title.ToLower().Contains(searchText.ToLower()))
                    searchResult.Add(thread);


            flowContainer.Controls.Clear();
            foreach (Thread t in searchResult)
            {
                ThreadBox box = new ThreadBox(t);
                tmpThreadBox.Add(new ThreadBox(t));
            }
            
            foreach (ThreadBox t in tmpThreadBox)
                flowContainer.Controls.Add(t);

            for (int i = 0; i < tmpThreadBox.Count; i++)
            {
                tmpThreadBox[i].Index = i + 1;
                tmpThreadBox[i].UpdateThreadBox();
            }

        }
        #endregion
        #region Methods to generate thread boxes and users
        private void GenerateNewThreads()
        {
            threads.Clear();
            users.Clear();
            ThreadBox.Boxes.Clear();
            threads.AddRange(AddThreads(30));


            foreach (Thread t in threads)
                ThreadBox.Boxes.Add(new ThreadBox(t));

            flowContainer.Controls.Clear();
            foreach (ThreadBox t in ThreadBox.Boxes)
                flowContainer.Controls.Add(t);
        } // take created user and thread objects and
                                             // put them in ThreadBox user control
        private List<User> AddUsers(int amount)
        {
            List<User> users = new List<User>();

            for (int i = 0; i <= amount; i++)
            {
                string username = TmpData.usernames[rnd.Next(TmpData.usernames.Length)];
                users.Add(new User(username, "password", "myemail@email.com"));
            }
            return users;
        } // create tmp user objects
        private List<Thread> AddThreads(int amount)
        {
            //get users from AddUsers method and attach them to thread
            users.AddRange(AddUsers(30));

            List<Thread> threads = new List<Thread>();


            for (int i = 0; i < amount; i++)
            {
                string title = TmpData.titles[rnd.Next(TmpData.titles.Length)];
                threads.Add(new Thread(users[rnd.Next(users.Count)], title, "https://news.ycombinator.com/", "lorem ipsum."));
            }

            return threads;
        } // create tmp thread objects
        #endregion
        #region Methods for responsive controls
        void UpdateNavBar()
        {
            nav.Width = this.Width;
        }
        void UpdateContainer()
        {
            flowContainer.Width = this.Width;
            flowContainer.Height = this.Height;

            foreach (ThreadBox t in ThreadBox.Boxes)
                t.Width = flowContainer.Width - 50;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            UpdateNavBar();
            UpdateContainer();
        }
        #endregion
    }
}