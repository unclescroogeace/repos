
namespace Maze
{
    partial class Game
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
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.btnGenerateBoard = new System.Windows.Forms.Button();
            this.lblBlack = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblStartPoint = new System.Windows.Forms.Label();
            this.lblEndPoint = new System.Windows.Forms.Label();
            this.btnColorBlack = new System.Windows.Forms.Button();
            this.btnColorWhite = new System.Windows.Forms.Button();
            this.btnColorGreen = new System.Windows.Forms.Button();
            this.btnColorRed = new System.Windows.Forms.Button();
            this.lblInfoHeader = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.BtnFindSP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(37, 13);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(46, 23);
            this.tbX.TabIndex = 0;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(117, 13);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(49, 23);
            this.tbY.TabIndex = 1;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(9, 16);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(28, 15);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "X = ";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(89, 16);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(28, 15);
            this.labelY.TabIndex = 3;
            this.labelY.Text = "Y = ";
            // 
            // btnGenerateBoard
            // 
            this.btnGenerateBoard.Location = new System.Drawing.Point(186, 12);
            this.btnGenerateBoard.Name = "btnGenerateBoard";
            this.btnGenerateBoard.Size = new System.Drawing.Size(127, 23);
            this.btnGenerateBoard.TabIndex = 4;
            this.btnGenerateBoard.Text = "Generate Board";
            this.btnGenerateBoard.UseVisualStyleBackColor = true;
            this.btnGenerateBoard.Click += new System.EventHandler(this.BtnGenerateBoard_Click);
            // 
            // lblBlack
            // 
            this.lblBlack.AutoSize = true;
            this.lblBlack.Location = new System.Drawing.Point(486, 15);
            this.lblBlack.Name = "lblBlack";
            this.lblBlack.Size = new System.Drawing.Size(30, 15);
            this.lblBlack.TabIndex = 5;
            this.lblBlack.Text = "Wall";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(582, 16);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(31, 15);
            this.lblPath.TabIndex = 6;
            this.lblPath.Text = "Path";
            // 
            // lblStartPoint
            // 
            this.lblStartPoint.AutoSize = true;
            this.lblStartPoint.Location = new System.Drawing.Point(677, 16);
            this.lblStartPoint.Name = "lblStartPoint";
            this.lblStartPoint.Size = new System.Drawing.Size(31, 15);
            this.lblStartPoint.TabIndex = 7;
            this.lblStartPoint.Text = "Start";
            // 
            // lblEndPoint
            // 
            this.lblEndPoint.AutoSize = true;
            this.lblEndPoint.Location = new System.Drawing.Point(778, 16);
            this.lblEndPoint.Name = "lblEndPoint";
            this.lblEndPoint.Size = new System.Drawing.Size(27, 15);
            this.lblEndPoint.TabIndex = 8;
            this.lblEndPoint.Text = "End";
            // 
            // btnColorBlack
            // 
            this.btnColorBlack.BackColor = System.Drawing.Color.Black;
            this.btnColorBlack.Location = new System.Drawing.Point(522, 8);
            this.btnColorBlack.Name = "btnColorBlack";
            this.btnColorBlack.Size = new System.Drawing.Size(30, 30);
            this.btnColorBlack.TabIndex = 9;
            this.btnColorBlack.UseVisualStyleBackColor = false;
            this.btnColorBlack.Click += new System.EventHandler(this.BtnColorBlack_Click);
            // 
            // btnColorWhite
            // 
            this.btnColorWhite.BackColor = System.Drawing.Color.White;
            this.btnColorWhite.Location = new System.Drawing.Point(619, 7);
            this.btnColorWhite.Name = "btnColorWhite";
            this.btnColorWhite.Size = new System.Drawing.Size(30, 30);
            this.btnColorWhite.TabIndex = 10;
            this.btnColorWhite.UseVisualStyleBackColor = false;
            this.btnColorWhite.Click += new System.EventHandler(this.BtnColorWhite_Click);
            // 
            // btnColorGreen
            // 
            this.btnColorGreen.BackColor = System.Drawing.Color.Green;
            this.btnColorGreen.Location = new System.Drawing.Point(714, 8);
            this.btnColorGreen.Name = "btnColorGreen";
            this.btnColorGreen.Size = new System.Drawing.Size(30, 30);
            this.btnColorGreen.TabIndex = 11;
            this.btnColorGreen.UseVisualStyleBackColor = false;
            this.btnColorGreen.Click += new System.EventHandler(this.BtnColorGreen_Click);
            // 
            // btnColorRed
            // 
            this.btnColorRed.BackColor = System.Drawing.Color.Red;
            this.btnColorRed.Location = new System.Drawing.Point(811, 8);
            this.btnColorRed.Name = "btnColorRed";
            this.btnColorRed.Size = new System.Drawing.Size(30, 30);
            this.btnColorRed.TabIndex = 12;
            this.btnColorRed.UseVisualStyleBackColor = false;
            this.btnColorRed.Click += new System.EventHandler(this.BtnColorRed_Click);
            // 
            // lblInfoHeader
            // 
            this.lblInfoHeader.AutoSize = true;
            this.lblInfoHeader.Location = new System.Drawing.Point(849, 15);
            this.lblInfoHeader.Name = "lblInfoHeader";
            this.lblInfoHeader.Size = new System.Drawing.Size(28, 15);
            this.lblInfoHeader.TabIndex = 13;
            this.lblInfoHeader.Text = "Info";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(838, 15);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 15);
            this.lblInfo.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(319, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(48, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(372, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(47, 23);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnFindSP
            // 
            this.BtnFindSP.Location = new System.Drawing.Point(425, 12);
            this.BtnFindSP.Name = "BtnFindSP";
            this.BtnFindSP.Size = new System.Drawing.Size(55, 23);
            this.BtnFindSP.TabIndex = 17;
            this.BtnFindSP.Text = "Find SP";
            this.BtnFindSP.UseVisualStyleBackColor = true;
            this.BtnFindSP.Click += new System.EventHandler(this.BtnFindSP_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 843);
            this.Controls.Add(this.BtnFindSP);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblInfoHeader);
            this.Controls.Add(this.btnColorRed);
            this.Controls.Add(this.btnColorGreen);
            this.Controls.Add(this.btnColorWhite);
            this.Controls.Add(this.btnColorBlack);
            this.Controls.Add(this.lblEndPoint);
            this.Controls.Add(this.lblStartPoint);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblBlack);
            this.Controls.Add(this.btnGenerateBoard);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Name = "Game";
            this.Text = "Maze";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button btnGenerateBoard;
        private System.Windows.Forms.Label lblBlack;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblStartPoint;
        private System.Windows.Forms.Label lblEndPoint;
        private System.Windows.Forms.Button btnColorBlack;
        private System.Windows.Forms.Button btnColorWhite;
        private System.Windows.Forms.Button btnColorGreen;
        private System.Windows.Forms.Button btnColorRed;
        private System.Windows.Forms.Label lblInfoHeader;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button BtnFindSP;
    }
}

