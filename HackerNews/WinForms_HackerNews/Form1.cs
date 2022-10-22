using HackerNewsLibrary;
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
            GenerateNewThreads();
        }
        #endregion
        #region Delegates
        // if anything on the nav bar is clicked
        private void Nav_NavbarClick() => GenerateNewThreads();
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
        }
        // add users to list
        private List<User> AddUsers(int amount)
        {
            List<User> users = new List<User>();

            for (int i = 0; i <= amount; i++)
            {
                string username = TmpData.usernames[rnd.Next(TmpData.usernames.Length)];
                users.Add(new User(username, "password", "myemail@email.com"));
            }
            return users;
        }

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
        }
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