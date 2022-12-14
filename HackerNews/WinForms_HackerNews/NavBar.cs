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
        public delegate void delNavbarClick();
        public event delNavbarClick NavbarClick;

        public delegate void delSendSeach(string searchText);
        public event delSendSeach SendSearch;



        public NavBar(Form pntr)
        {
            InitializeComponent();
            this.btnSeacrh.MouseDown += BtnSeacrh_MouseDown;

            this.Width = pntr.Width;

            pntr.Controls.Add(this);

            foreach(Control c in this.Controls.OfType<Label>())
            {
                c.Click += Control_Click;
                c.Cursor = Cursors.Hand;
            }
        }

        private void BtnSeacrh_MouseDown(object? sender, MouseEventArgs e)
        {
            SendSearch.Invoke(tbSearch.Text);
        }

        private void Control_Click(object? sender, EventArgs e)
        {
            NavbarClick.Invoke();
        }
    }
}
