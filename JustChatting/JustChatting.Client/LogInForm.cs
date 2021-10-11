using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using JustChatting.Client.Models;
using JustChatting.Client.Networking;

namespace JustChatting.Client
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            TextBoxPassword.PasswordChar = '•';
        }

        private void LabelSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new();
            signUpForm.ShowDialog();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            AsynchronousClient.StartClient(new LogIn(TextBoxUsername.Text, TextBoxPassword.Text));
            if (AsynchronousClient.response == "1")
            {
                LabelDontHaveRegistration.Text = "You have";
            }
            else
            {
                LabelDontHaveRegistration.Text = "But you don't";
            }
        }
    }
}