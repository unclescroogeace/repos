
namespace JustChatting.Client
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.TextBoxUsername = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopTextBox();
            this.LabelLogInScreen = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel();
            this.LabelUsername = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel();
            this.labelPassword = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel();
            this.TextBoxPassword = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonLogIn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.LabelDontHaveRegistration = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel();
            this.LabelSignUp = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.DisabledStringColor = System.Drawing.Color.Silver;
            this.TextBoxUsername.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.TextBoxUsername.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.TextBoxUsername.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.TextBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.TextBoxUsername.IsEnabled = true;
            this.TextBoxUsername.Location = new System.Drawing.Point(57, 237);
            this.TextBoxUsername.MaxLength = 32767;
            this.TextBoxUsername.Multiline = false;
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.PasswordChar = '\0';
            this.TextBoxUsername.ReadOnly = false;
            this.TextBoxUsername.Size = new System.Drawing.Size(300, 24);
            this.TextBoxUsername.TabIndex = 0;
            this.TextBoxUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxUsername.TextBackgroundColor = System.Drawing.SystemColors.Window;
            this.TextBoxUsername.UseSystemPasswordChar = false;
            this.TextBoxUsername.WordWrap = true;
            // 
            // LabelLogInScreen
            // 
            this.LabelLogInScreen.AllowTransparency = true;
            this.LabelLogInScreen.AutoSize = true;
            this.LabelLogInScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelLogInScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.LabelLogInScreen.Location = new System.Drawing.Point(81, 142);
            this.LabelLogInScreen.Name = "LabelLogInScreen";
            this.LabelLogInScreen.Size = new System.Drawing.Size(251, 34);
            this.LabelLogInScreen.TabIndex = 1;
            this.LabelLogInScreen.Text = "Welcome to JustChatting.\r\nYou need to Log In before to continue.";
            this.LabelLogInScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelUsername
            // 
            this.LabelUsername.AllowTransparency = true;
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.LabelUsername.Location = new System.Drawing.Point(57, 215);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(73, 17);
            this.LabelUsername.TabIndex = 2;
            this.LabelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AllowTransparency = true;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.labelPassword.Location = new System.Drawing.Point(57, 282);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 17);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.TextBoxPassword.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.TextBoxPassword.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.TextBoxPassword.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.TextBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.TextBoxPassword.IsEnabled = true;
            this.TextBoxPassword.Location = new System.Drawing.Point(57, 305);
            this.TextBoxPassword.MaxLength = 32767;
            this.TextBoxPassword.Multiline = false;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '\0';
            this.TextBoxPassword.ReadOnly = false;
            this.TextBoxPassword.Size = new System.Drawing.Size(300, 24);
            this.TextBoxPassword.TabIndex = 4;
            this.TextBoxPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxPassword.TextBackgroundColor = System.Drawing.SystemColors.Window;
            this.TextBoxPassword.UseSystemPasswordChar = false;
            this.TextBoxPassword.WordWrap = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonLogIn
            // 
            this.ButtonLogIn.AllowTransparency = true;
            this.ButtonLogIn.AnimationInterval = 1;
            this.ButtonLogIn.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLogIn.BGColor = "#508ef5";
            this.ButtonLogIn.Corners = 1F;
            this.ButtonLogIn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.ButtonLogIn.DoubleRipple = false;
            this.ButtonLogIn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.ButtonLogIn.FontColor = "#ffffff";
            this.ButtonLogIn.Location = new System.Drawing.Point(150, 352);
            this.ButtonLogIn.Name = "ButtonLogIn";
            this.ButtonLogIn.RippleEffectColor = System.Drawing.Color.Black;
            this.ButtonLogIn.RippleOpacity = 25;
            this.ButtonLogIn.Size = new System.Drawing.Size(90, 30);
            this.ButtonLogIn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.ButtonLogIn.TabIndex = 6;
            this.ButtonLogIn.Text = "Log In";
            this.ButtonLogIn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.ButtonLogIn.Click += new System.EventHandler(this.ButtonLogIn_Click);
            // 
            // LabelDontHaveRegistration
            // 
            this.LabelDontHaveRegistration.AllowTransparency = true;
            this.LabelDontHaveRegistration.AutoSize = true;
            this.LabelDontHaveRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDontHaveRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.LabelDontHaveRegistration.Location = new System.Drawing.Point(92, 433);
            this.LabelDontHaveRegistration.Name = "LabelDontHaveRegistration";
            this.LabelDontHaveRegistration.Size = new System.Drawing.Size(158, 17);
            this.LabelDontHaveRegistration.TabIndex = 7;
            this.LabelDontHaveRegistration.Text = "Don\'t have an account?";
            // 
            // LabelSignUp
            // 
            this.LabelSignUp.AllowTransparency = true;
            this.LabelSignUp.AutoSize = true;
            this.LabelSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.LabelSignUp.Location = new System.Drawing.Point(250, 433);
            this.LabelSignUp.Name = "LabelSignUp";
            this.LabelSignUp.Size = new System.Drawing.Size(63, 17);
            this.LabelSignUp.TabIndex = 8;
            this.LabelSignUp.Text = "Sign up";
            this.LabelSignUp.Click += new System.EventHandler(this.LabelSignUp_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(414, 491);
            this.Controls.Add(this.LabelSignUp);
            this.Controls.Add(this.LabelDontHaveRegistration);
            this.Controls.Add(this.ButtonLogIn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.LabelLogInScreen);
            this.Controls.Add(this.TextBoxUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Just Chatting";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopTextBox TextBoxUsername;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel LabelLogInScreen;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel LabelUsername;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel labelPassword;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopTextBox TextBoxPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton ButtonLogIn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel LabelDontHaveRegistration;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel LabelSignUp;
    }
}

