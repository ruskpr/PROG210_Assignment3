using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for ThreadBox.xaml
    /// </summary>
    public partial class ThreadBox : UserControl
    {
        #region Fields
        //public static Bitmap? upVoteImg;
        public static List<ThreadBox> Boxes = new List<ThreadBox>();
        private int _index;
        #endregion
        #region Properties
        public Thread TheThread { get; set; }
        #endregion
        #region Constructor 
        public ThreadBox(Thread thread)
        {
            InitializeComponent();
            //initialize button click event
            //this.btnUpvote.MouseDown


            VerticalContentAlignment = VerticalAlignment.Stretch;
            //init upvote image
            //upVoteImg = File.Exists("upvote.png") ? new Bitmap("upvote.png") : null;
            //btnUpvote.Image = upVoteImg;

            TheThread = thread;
            _index = Boxes.Count + 1; // get index of thread based on current count of static list

            UpdateThreadBox();
        }
        #endregion
        #region Click events
        private void lbTitle_MouseDown(object sender, MouseButtonEventArgs e) =>
            MessageBox.Show("[Go to external link]");

        private void lbDetails_MouseDown_1(object sender, MouseButtonEventArgs e) =>
            MessageBox.Show("[Go to comments]");

        private void BtnUpvote_MouseDown(object? sender, EventArgs e)
        {
            TheThread.UpVote();
            UpdateThreadBox();
        }
        #endregion
        #region Methods
        public void UpdateThreadBox()
        {
            lbIndex.Content = $"{_index}.";
            lbTitle.Content = TheThread.Title;
            lbDetails.Content = $"{TheThread.UpVotes} points by {TheThread.Username} on " +
                $"{TheThread.DateCreated} | {TheThread.Comments.Count} comments";
        }

        public override string ToString() => $"{TheThread.Username}'s Thread Box";

        #endregion

        
    }
}
