using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerNewsLibrary
{
    public class User
    {
        #region Properties
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public DateTime DateCreated { get; set; }
        #endregion

        #region Constructor
        public User(string usrnm, string pass, string email)
        {
            UserName = usrnm;
            Password = pass;
            Email = email;
            DateCreated = DateTime.Now;
        }
        #endregion

        #region Methods

        public bool CreateSubmission()
        {
            //user adds title, description, links to textboxes.
            //information is submitted to Threads table in DB.
            return true;
        }

        public bool AddComment()
        {
            //user adds title, and description to textboxes.
            //information is submitted to Comments table in DB
            return true;
        }

        public void upVote()
        {
            //user clicks upvote button.
            //username is validated. 
            //global upVote integer increments.
        }

        public void FavoriteSubmission()
        {
            //user clicks 'favorite' link / button on thread.
            //threadID and info is written into Favorites table in DB.
        }

        public void Submitquestion()
        {
            //CreateSubmission with unique metadata for Question?
        }

        #endregion
    }
}
