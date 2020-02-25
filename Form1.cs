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
using System.Net.Sockets;

namespace Chat_Messenger_Client
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        #region connectBtn events
        private void connectBtn_MouseHover(object sender, EventArgs e)
        {
            connectBtn.Image = Resources.connectBtn_Hover;
        }

        private void connectBtn_MouseLeave(object sender, EventArgs e)
        {
            connectBtn.Image = Resources.connectBtn;
        }

        private void connectBtn_MouseDown(object sender, MouseEventArgs e)
        {
            connectBtn.Image = Resources.connectBtn_Clicked;
        }

        private void connectBtn_MouseUp(object sender, MouseEventArgs e)
        {
            connectBtn.Image = Resources.connectBtn;
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            bool connectedToServer = ConnectionHandler.connect();

            if (connectedToServer)
                MessageBox.Show("Connected to server!");
            else
                MessageBox.Show("Failed to connect to server!");
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
            ConnectionHandler.socket.Close();
            Application.Exit();
        }



        #endregion

        
    }
}
