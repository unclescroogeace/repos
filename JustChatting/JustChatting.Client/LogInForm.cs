﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustChatting.Client
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LabelSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new();
            signUpForm.ShowDialog();
        }
    }
}