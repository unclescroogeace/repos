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

namespace JustChatting.Client
{
    public partial class MainForm : Form
    {
        private User _loggedUser;
        public MainForm(User loggedUser)
        {
            InitializeComponent();
            _loggedUser = loggedUser;
            Text = "JustChatting -  " + _loggedUser.Username;
        }
    }
}
