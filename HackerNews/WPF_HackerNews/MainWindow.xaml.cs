using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HackerNewsLibrary;
using Thread = HackerNewsLibrary.Thread;

namespace WPF_HackerNews
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<User> users = new List<User>();
        public static List<Thread> threads = new List<Thread>();
        public Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();

            //generate list of threads
            threads.AddRange(AddThreads());

            // get threads from list and attach them to thread boxes
            foreach (Thread t in threads)
                ThreadBox.Boxes.Add(new ThreadBox(t));

            //add to container
            foreach (ThreadBox t in ThreadBox.Boxes)
                stpContainer.Children.Add(t);
            //wrpContainer.Children.Add(t);

            //start with some threads.
            GenerateNewThreads();
        }

        //button to sort by OLD Threads (Past)
        private void lblnew_Copy_MouseDown(object sender, MouseButtonEventArgs e)
        {
            GenerateNewThreads();
        }

        //button to sort by NEW Threads (new)
        private void lblpast_MouseDown(object sender, MouseButtonEventArgs e)
        {
            GenerateNewThreads();
        }

        private void lblthreads_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //search page
        }

        // add users to list
        private List<User> AddUsers()
        {
            List<User> users = new List<User>();

            users.Add(new User("russ", "password", "russ@email.com"));
            users.Add(new User("ron", "password", "ron@email.com"));

            return users;
        }

        //Generate New Threads
        private void GenerateNewThreads()
        {
            threads.Clear();
            users.Clear();
            ThreadBox.Boxes.Clear();

            threads.AddRange(AddThreads(30));


            foreach (Thread t in threads)
                ThreadBox.Boxes.Add(new ThreadBox(t));

            stpContainer.Children.Clear();
            foreach (ThreadBox t in ThreadBox.Boxes)
                stpContainer.Children.Add(t);
        }

        //Add Threads
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

        //Add Users
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

        //Add Threads
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
