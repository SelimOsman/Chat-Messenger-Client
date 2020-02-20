using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chat_Messenger_Client.Properties;

namespace Chat_Messenger_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            exitBtn.Image = Resources.exitBtn_Clicked;
            Application.Exit();
        }

        private void exitBtn_MouseHover(object sender, EventArgs e)
        {
            exitBtn.Image = Resources.exitBtn_Hover;
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.Image = Resources.exitBtn;
        }
    }
}
