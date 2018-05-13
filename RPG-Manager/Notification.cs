using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Manager
{
    public partial class Notification : Form
    {
        // A simple notification window that allows the application to send messages to the user.
        public Notification()
        {
            InitializeComponent();
            textBox1.Text = "";
            textBox1.Invalidate();
        }

        public Notification(string message)
        {
            InitializeComponent();
            textBox1.Text = message;
            textBox1.Invalidate();
        }

        private void okayBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
