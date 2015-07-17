using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeithDesktop
{
    public partial class CloseButton : UserControl
    {
        public CloseButton()
        {
            InitializeComponent();
        }

        private void CloseButton_Load(object sender, EventArgs e)
        {
            Label l = new Label();
            l.Font = new Font("KaiTi", 30, FontStyle.Bold);
            l.Padding = new Padding(0);
            l.Text = "X";
            this.Controls.Add(l);
            this.Location = new Point(0, 0);
            l.Size = this.Size = TextRenderer.MeasureText(l.Text, l.Font);
            l.Click += CloseButton_Click;
            l.MouseEnter += delegate(object a, EventArgs b) { ((Controller)this.Parent).TurnRed(); ChangeColors(true, l); };
            l.MouseLeave += delegate(object a, EventArgs b) { ((Controller)this.Parent).TurnNotRed(); ChangeColors(false, l); };
            this.MouseLeave += delegate(object a, EventArgs b) { ((Controller)this.Parent).TurnNotRed(); ChangeColors(false, l); };
            this.MouseEnter += delegate(object a, EventArgs b) { ((Controller)this.Parent).TurnRed(); ChangeColors(true, l); };
            l.BorderStyle = this.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
        private void CloseButton_Click(object sender, EventArgs e) { ((Controller)this.Parent).Controller_Click((object)this.Parent, e); }
        private void ChangeColors(bool red, Label l) { l.BackColor = this.BackColor = (red ? Color.Red : SystemColors.ControlDarkDark); }
    }
}
