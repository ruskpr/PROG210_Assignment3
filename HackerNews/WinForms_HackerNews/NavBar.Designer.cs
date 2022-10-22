namespace WinForms_HackerNews
{
    partial class NavBar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.lbNew = new System.Windows.Forms.Label();
            this.lbThreads = new System.Windows.Forms.Label();
            this.lbAsk = new System.Windows.Forms.Label();
            this.lbPast = new System.Windows.Forms.Label();
            this.lbComments = new System.Windows.Forms.Label();
            this.lbShow = new System.Windows.Forms.Label();
            this.lbJobs = new System.Windows.Forms.Label();
            this.lbSumbit = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(13, 10);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(81, 15);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Hacker News";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Location = new System.Drawing.Point(109, 11);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(55, 15);
            this.lbWelcome.TabIndex = 1;
            this.lbWelcome.Text = "welcome";
            // 
            // lbNew
            // 
            this.lbNew.AutoSize = true;
            this.lbNew.Location = new System.Drawing.Point(180, 11);
            this.lbNew.Name = "lbNew";
            this.lbNew.Size = new System.Drawing.Size(29, 15);
            this.lbNew.TabIndex = 1;
            this.lbNew.Text = "new";
            // 
            // lbThreads
            // 
            this.lbThreads.AutoSize = true;
            this.lbThreads.Location = new System.Drawing.Point(224, 11);
            this.lbThreads.Name = "lbThreads";
            this.lbThreads.Size = new System.Drawing.Size(46, 15);
            this.lbThreads.TabIndex = 1;
            this.lbThreads.Text = "threads";
            // 
            // lbAsk
            // 
            this.lbAsk.AutoSize = true;
            this.lbAsk.Location = new System.Drawing.Point(400, 11);
            this.lbAsk.Name = "lbAsk";
            this.lbAsk.Size = new System.Drawing.Size(24, 15);
            this.lbAsk.TabIndex = 2;
            this.lbAsk.Text = "ask";
            // 
            // lbPast
            // 
            this.lbPast.AutoSize = true;
            this.lbPast.Location = new System.Drawing.Point(276, 11);
            this.lbPast.Name = "lbPast";
            this.lbPast.Size = new System.Drawing.Size(29, 15);
            this.lbPast.TabIndex = 3;
            this.lbPast.Text = "past";
            // 
            // lbComments
            // 
            this.lbComments.AutoSize = true;
            this.lbComments.Location = new System.Drawing.Point(321, 11);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(64, 15);
            this.lbComments.TabIndex = 4;
            this.lbComments.Text = "comments";
            // 
            // lbShow
            // 
            this.lbShow.AutoSize = true;
            this.lbShow.Location = new System.Drawing.Point(440, 11);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(35, 15);
            this.lbShow.TabIndex = 2;
            this.lbShow.Text = "show";
            // 
            // lbJobs
            // 
            this.lbJobs.AutoSize = true;
            this.lbJobs.Location = new System.Drawing.Point(490, 11);
            this.lbJobs.Name = "lbJobs";
            this.lbJobs.Size = new System.Drawing.Size(29, 15);
            this.lbJobs.TabIndex = 2;
            this.lbJobs.Text = "jobs";
            // 
            // lbSumbit
            // 
            this.lbSumbit.AutoSize = true;
            this.lbSumbit.Location = new System.Drawing.Point(536, 11);
            this.lbSumbit.Name = "lbSumbit";
            this.lbSumbit.Size = new System.Drawing.Size(44, 15);
            this.lbSumbit.TabIndex = 2;
            this.lbSumbit.Text = "submit";
            // 
            // lbLogin
            // 
            this.lbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(880, 11);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(42, 15);
            this.lbLogin.TabIndex = 2;
            this.lbLogin.Text = "logout";
            // 
            // lbUsername
            // 
            this.lbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(807, 11);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(67, 15);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "[username]";
            // 
            // NavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(86)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.lbPast);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbSumbit);
            this.Controls.Add(this.lbJobs);
            this.Controls.Add(this.lbShow);
            this.Controls.Add(this.lbAsk);
            this.Controls.Add(this.lbNew);
            this.Controls.Add(this.lbThreads);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.lbTitle);
            this.Name = "NavBar";
            this.Size = new System.Drawing.Size(940, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTitle;
        private Label lbWelcome;
        private Label lbNew;
        private Label lbThreads;
        private Label lbAsk;
        private Label lbPast;
        private Label lbComments;
        private Label lbShow;
        private Label lbJobs;
        private Label lbSumbit;
        private Label lbLogin;
        private Label lbUsername;
    }
}
