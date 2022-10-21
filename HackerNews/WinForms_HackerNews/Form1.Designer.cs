namespace WinForms_HackerNews
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowContainer
            // 
            this.flowContainer.AutoScroll = true;
            this.flowContainer.BackColor = System.Drawing.Color.Gainsboro;
            this.flowContainer.Location = new System.Drawing.Point(12, 32);
            this.flowContainer.Name = "flowContainer";
            this.flowContainer.Size = new System.Drawing.Size(848, 441);
            this.flowContainer.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 696);
            this.Controls.Add(this.flowContainer);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Hacker News";
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowContainer;
    }
}