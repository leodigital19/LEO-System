using System;
using System.Windows.Forms;

namespace LEO_System
{
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Dock = DockStyle.Fill;
            this.AutoSize = true;
            this.AutoScaleMode = AutoScaleMode.Inherit;
        }

        private void Course_Load(object sender, EventArgs e)
        {

        }
    }
}
