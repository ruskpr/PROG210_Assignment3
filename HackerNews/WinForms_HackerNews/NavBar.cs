using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_HackerNews
{
    public partial class NavBar : UserControl
    {
        public NavBar(Form pntr)
        {
            InitializeComponent();

            this.Width = pntr.Width;

            pntr.Controls.Add(this);
        }
    }
}
