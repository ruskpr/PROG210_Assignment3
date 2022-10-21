using HackerNewsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thread = HackerNewsLibrary.Thread;

namespace WinForms_HackerNews
{
    public partial class ThreadBox : UserControl
    {
        public static Bitmap? upVoteImg = new Bitmap("upvote.png");

        public static List<ThreadBox> Boxes = new List<ThreadBox>();
        public Thread TheThread { get; set; }
        public int Index { get; set; }
        public ThreadBox(Thread thread)
        {
            InitializeComponent();
            //initialize button click events
            btnUpvote.Click += BtnUpvote_Click;
            lbTitle.Click += LbTitle_Click;
            lbDetails.Click += LbDetails_Click;

            //set upvote image
            upVoteImg ??= null;
            btnUpvote.Image = upVoteImg;


            TheThread = thread;
            this.Index = Boxes.Count + 1;
            UpdateThreadBox();
        }

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
            lbIndex.Text = $"{Index}.";
            lbTitle.Text = TheThread.Title;
            lbDetails.Text = $"{TheThread.UpVotes} points by {TheThread.Username} on " +
                $"{TheThread.DateCreated} | {TheThread.Comments.Count} comments";
        }
        #endregion
    }
}
