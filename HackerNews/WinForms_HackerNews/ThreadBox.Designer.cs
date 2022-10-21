namespace WinForms_HackerNews
{
    partial class ThreadBox
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
            this.lbIndex = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbDetails = new System.Windows.Forms.Label();
            this.btnUpvote = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpvote)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIndex
            // 
            this.lbIndex.AutoSize = true;
            this.lbIndex.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIndex.ForeColor = System.Drawing.Color.DimGray;
            this.lbIndex.Location = new System.Drawing.Point(3, 18);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.Size = new System.Drawing.Size(32, 32);
            this.lbIndex.TabIndex = 0;
            this.lbIndex.Text = "1.";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(70, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(533, 21);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Students are acing their homework by turning in machine-generated essays";
            // 
            // lbDetails
            // 
            this.lbDetails.AutoSize = true;
            this.lbDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDetails.ForeColor = System.Drawing.Color.DimGray;
            this.lbDetails.Location = new System.Drawing.Point(70, 38);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.Size = new System.Drawing.Size(349, 17);
            this.lbDetails.TabIndex = 2;
            this.lbDetails.Text = "5 points by [username] 2 hours ago | hide | 102 comments";
            // 
            // btnUpvote
            // 
            this.btnUpvote.BackColor = System.Drawing.Color.Black;
            this.btnUpvote.Location = new System.Drawing.Point(34, 22);
            this.btnUpvote.Name = "btnUpvote";
            this.btnUpvote.Size = new System.Drawing.Size(30, 30);
            this.btnUpvote.TabIndex = 3;
            this.btnUpvote.TabStop = false;
            // 
            // ThreadBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpvote);
            this.Controls.Add(this.lbDetails);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbIndex);
            this.Name = "ThreadBox";
            this.Size = new System.Drawing.Size(741, 73);
            ((System.ComponentModel.ISupportInitialize)(this.btnUpvote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbIndex;
        private Label lbTitle;
        private Label lbDetails;
        private PictureBox btnUpvote;
    }
}
