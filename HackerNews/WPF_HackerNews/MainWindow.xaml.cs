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

        private void lblnew_Copy_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //sort by new
        }

        private void lblpast_MouseDown(object sender, MouseButtonEventArgs e)
        {
          //sort by old
        }

        private void lblthreads_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //search page
        }
    }
}
