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


        #region exitBtn events
        private void exitBtn_MouseHover(object sender, EventArgs e)
        {
            exitBtn.Image = Resources.exitBtn_Hover;
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.Image = Resources.exitBtn;
        }

        private void exitBtn_MouseDown(object sender, MouseEventArgs e)
        {
            exitBtn.Image = Resources.exitBtn_Clicked;
        }

        private void exitBtn_MouseUp(object sender, MouseEventArgs e)
        {
            exitBtn.Image = Resources.exitBtn;
            Application.Exit();
        }
        #endregion

        #region signUpBtn events
        private void signUpBtn_MouseHover(object sender, EventArgs e)
        {
            signUpBtn.Image = Resources.signUpBtn_Hover;
        }

        private void signUpBtn_MouseLeave(object sender, EventArgs e)
        {
            signUpBtn.Image = Resources.signUpBtn;
        }

        private void signUpBtn_MouseDown(object sender, MouseEventArgs e)
        {
            signUpBtn.Image = Resources.signUpBtn_Clicked;
        }

        private void signUpBtn_MouseUp(object sender, MouseEventArgs e)
        {
            signUpBtn.Image = Resources.signUpBtn;
        }
        #endregion

    }
}
