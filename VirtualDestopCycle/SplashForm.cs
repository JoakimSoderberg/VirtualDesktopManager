using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualDesktopManager
{
    public partial class SplashForm : Form
    {
        Timer timer;

        public SplashForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Opacity = 0.7;
            this.BackColor = Color.Gray;
            this.TransparencyKey = this.BackColor;
            this.TopMost = true;
            this.Font = new System.Drawing.Font("Segoe UI Black", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.timer = new System.Windows.Forms.Timer();
            this.timer.Interval = 5;
            this.timer.Tick += Timer_Tick;
            this.timer.Start();
        }

        public SplashForm(string text) : this()
        {
            this.Text = text;
        }

        public SplashForm(string text, Point location) : this()
        {
            this.Text = text;
            this.Location = location;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.01;

            if (this.Opacity <= 0.0)
            {
                this.Close();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Point(0, 0), Color.White);
        }
    }
}
