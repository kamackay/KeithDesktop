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
    public partial class Controller : Form
    {
        private int i;
        private List<Form> children;
        public Controller()
        {
            InitializeComponent();
            children = new List<Form>();
            this.Activated += delegate(object a, EventArgs b) { this.ShowAll(); };
        }

        private void Controller_Load(object sender, EventArgs e)
        {
            ActionButton ab = new ActionButton(Chrome);
            ab.Show();
            children.Add(ab);
            this.MouseEnter += delegate(object a, EventArgs b) { this.TurnRed(); };
            this.MouseLeave += delegate(object a, EventArgs b) { this.TurnNotRed(); };
        }

        private void Controller_Shown(object sender, EventArgs e)
        {
            this.Size = this.closeButton1.Size;
            Screen main = Screen.PrimaryScreen;
            this.Location = new Point(main.Bounds.Width - this.Width, 0);
        }

        public void Controller_Click(object sender, EventArgs e) { Environment.Exit(0); }
        public void TurnNotRed() { this.BackColor = System.Drawing.SystemColors.ControlDarkDark; }
        public void TurnRed() { this.BackColor = Color.Red; }

        private void Controller_StyleChanged(object sender, EventArgs e) { this.ShowAll(); }
        public void ShowAll()
        {
            if (i <= 3 && this.BackColor != Color.Red)
            {
                foreach (Form f in this.children) f.BringToFront();
                this.i++;
            }
            else { i = 0; }
        }
        public void Chrome() { }
    }
}
