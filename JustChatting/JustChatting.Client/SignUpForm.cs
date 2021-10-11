using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JustChatting.Data;
using JustChatting.Client.Networking;

namespace JustChatting.Client
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            TextBoxPassword.PasswordChar = '•';
            TextBoxRepeatPassword.PasswordChar = '•';
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            LabelSomethingWentWrong.Text = string.Empty;
            int failedValidations = 0;
            if (string.IsNullOrEmpty(TextBoxUsername.Text))
            {
                TextBoxUsername.EnabledUnFocusedColor = Color.FromArgb(255, 0, 0);
                failedValidations++;
            }
            else
            {
                TextBoxUsername.EnabledUnFocusedColor = Color.FromArgb(0, 255, 0);
            }
            if (string.IsNullOrEmpty(TextBoxPassword.Text) || TextBoxPassword.Text != TextBoxRepeatPassword.Text)
            {
                TextBoxPassword.EnabledUnFocusedColor = Color.FromArgb(255, 0, 0);
                failedValidations++;
            }
            else
            {
                TextBoxPassword.EnabledUnFocusedColor = Color.FromArgb(0, 255, 0);
            }
            if(string.IsNullOrEmpty(TextBoxRepeatPassword.Text) || TextBoxRepeatPassword.Text != TextBoxPassword.Text)
            {
                TextBoxRepeatPassword.EnabledUnFocusedColor = Color.FromArgb(255, 0, 0);
                failedValidations++;
            }
            else
            {
                TextBoxRepeatPassword.EnabledUnFocusedColor = Color.FromArgb(0, 255, 0);
            }

            ButtonSignUp.Focus();

            if (failedValidations == 0)
            {
                //User user = new();
                //user.Username = TextBoxUsername.Text;
                //user.Password = TextBoxPassword.Text;
                //user.Created = DateTime.Now;

                //if (ClientTcp.Register("127.0.0.1", 13300 , user))
                //{
                //    this.Close();
                //}
                //else
                //{
                //    LabelSomethingWentWrong.Text = "Something went wrong!";
                //}
            }
        }
    }
}