using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeithDesktop
{
    public partial class ActionButton : Form
    {
        private Label right, left, top, bottom;
        public ActionButton()
        {
            InitializeComponent();
            this.right = new Label();
            this.left = new Label();
            this.top = new Label();
            this.bottom = new Label();
            this.Controls.AddRange(new Control[] { right, left, top, bottom });
        }
        private void ControlBorder()
        {
            this.right.Padding = this.left.Padding = this.top.Padding = this.bottom.Padding = new Padding(0);
            this.right.BackColor = this.left.BackColor = this.top.BackColor = this.bottom.BackColor = Color.Black;
            this.right.Width = this.left.Width = this.top.Height = this.bottom.Height = 2;
            this.right.Height = this.left.Height = this.Height;
            this.top.Width = this.bottom.Width = this.Width;
            this.bottom.Left = this.right.Top = this.top.Left = this.left.Left = this.top.Top = this.left.Top = 0;
            this.right.Left = this.Width - 2;
            this.bottom.Top = this.Height - 2;
        }

        private void ActionButton_Shown(object sender, EventArgs e)
        {

        }

        private void ActionButton_Activated(object sender, EventArgs e) { this.ControlBorder(); }
    }
}
