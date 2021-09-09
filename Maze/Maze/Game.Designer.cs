
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
            this.btnGenerateBoard.Click += new System.EventHandler(this.btnGenerateBoard_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 641);
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
    }
}

