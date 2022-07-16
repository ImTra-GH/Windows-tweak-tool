using System;
using System.Drawing;
using System.Windows.Forms;

namespace ITT
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Point lastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.panelctrlsloader.Controls.Clear();
            Tweaks Tweaks_Vrb = new Tweaks() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelctrlsloader.Controls.Add(Tweaks_Vrb);
            Tweaks_Vrb.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.panelctrlsloader.Controls.Clear();
            Tweaks Tweaks_Vrb = new Tweaks() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelctrlsloader.Controls.Add(Tweaks_Vrb);
            Tweaks_Vrb.Show();
            button9.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panelctrlsloader.Controls.Clear();
            Revert Revert_Vrb = new Revert() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelctrlsloader.Controls.Add(Revert_Vrb);
            Revert_Vrb.Show();
            button9.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void X_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panelctrlsloader.Controls.Clear();
            About About_Vrb = new About() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelctrlsloader.Controls.Add(About_Vrb);
            About_Vrb.Show();
            button9.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
