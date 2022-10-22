using HackerNewsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thread = HackerNewsLibrary.Thread;

namespace WinForms_HackerNews
{
    public partial class ThreadBox : UserControl
    {
        #region Fields
        public static Bitmap? upVoteImg;
        public static List<ThreadBox> Boxes = new List<ThreadBox>();
        private int _index;
        private Random rnd = new Random();
        #endregion
        #region Properties
        public Thread TheThread { get; set; }
        #endregion
        #region Constructor 
        public ThreadBox(Thread thread)
        {
            InitializeComponent();
            //initialize button click events
            btnUpvote.Click += BtnUpvote_Click;
            lbTitle.Click += LbTitle_Click;
            lbDetails.Click += LbDetails_Click;


            //init upvote image
            upVoteImg = File.Exists("upvote.png") ? new Bitmap("upvote.png") : null;
            btnUpvote.Image = upVoteImg;

            TheThread = thread;
            _index = Boxes.Count + 1; // get index of thread based on current count of static list

            UpdateThreadBox();
        }
        #endregion
        #region Click events
        private void LbDetails_Click(object? sender, EventArgs e) =>
            MessageBox.Show("[Go to comments]");

        private void LbTitle_Click(object? sender, EventArgs e) =>
            MessageBox.Show("[Go to external link]");


        private void BtnUpvote_Click(object? sender, EventArgs e)
        {
            TheThread.UpVote();
            UpdateThreadBox();
        }
        #endregion
        #region Methods
        public void UpdateThreadBox()
        {
            lbIndex.Text = $"{_index}.";
            lbTitle.Text = TheThread.Title;
            lbDetails.Text = $"{TheThread.UpVotes} points by {TheThread.Username} on " +
                $"{TheThread.DateCreated} | {TheThread.CommentCount} comments"; 
        }

        public override string ToString() => $"{TheThread.Username}'s Thread Box";

        #endregion

    }
}
