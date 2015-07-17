namespace KeithDesktop
{
    partial class Controller
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.closeButton1 = new KeithDesktop.CloseButton();
            this.SuspendLayout();
            // 
            // closeButton1
            // 
            this.closeButton1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.closeButton1.Location = new System.Drawing.Point(0, 0);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(38, 40);
            this.closeButton1.TabIndex = 0;
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.closeButton1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Controller";
            this.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark;
            this.Load += new System.EventHandler(this.Controller_Load);
            this.Shown += new System.EventHandler(this.Controller_Shown);
            this.Click += new System.EventHandler(this.Controller_Click);
            this.StyleChanged += new System.EventHandler(this.Controller_StyleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private CloseButton closeButton1;
    }
}

