using System;
using System.Windows.Forms;

namespace LEO_System
{
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();
            
        }

        private void Dashboard()
        {
            Course frm = new Course();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            this.panMain.Controls.Add(frm);
            frm.Show();
        }

        private void panMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            Dashboard();
        }

        private void icoExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icoExpand_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void icoMinimize_Click(object sender, EventArgs e)
        {

            Dash frm = new Dash();
            frm.WindowState = FormWindowState.Minimized;
        }

        private void icoAssignment_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Hide();
            frm.Show();
        }
    }
}
