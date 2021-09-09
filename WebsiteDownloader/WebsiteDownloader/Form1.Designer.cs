
namespace WebsiteDownloader
{
    partial class AsyncExample
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
            this.normalExecute = new System.Windows.Forms.Button();
            this.normalParallelExecute = new System.Windows.Forms.Button();
            this.asyncExecute = new System.Windows.Forms.Button();
            this.parallelAsyncExecute = new System.Windows.Forms.Button();
            this.cancelation = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // normalExecute
            // 
            this.normalExecute.Location = new System.Drawing.Point(12, 21);
            this.normalExecute.Name = "normalExecute";
            this.normalExecute.Size = new System.Drawing.Size(651, 51);
            this.normalExecute.TabIndex = 0;
            this.normalExecute.Text = "Normal Execute";
            this.normalExecute.UseVisualStyleBackColor = true;
            this.normalExecute.Click += new System.EventHandler(this.normalExecute_Click);
            // 
            // normalParallelExecute
            // 
            this.normalParallelExecute.Location = new System.Drawing.Point(12, 78);
            this.normalParallelExecute.Name = "normalParallelExecute";
            this.normalParallelExecute.Size = new System.Drawing.Size(651, 51);
            this.normalParallelExecute.TabIndex = 1;
            this.normalParallelExecute.Text = "Normal Parallel Execute";
            this.normalParallelExecute.UseVisualStyleBackColor = true;
            this.normalParallelExecute.Click += new System.EventHandler(this.normalParallelExecute_Click);
            // 
            // asyncExecute
            // 
            this.asyncExecute.Location = new System.Drawing.Point(12, 135);
            this.asyncExecute.Name = "asyncExecute";
            this.asyncExecute.Size = new System.Drawing.Size(651, 51);
            this.asyncExecute.TabIndex = 2;
            this.asyncExecute.Text = "Async Execute";
            this.asyncExecute.UseVisualStyleBackColor = true;
            this.asyncExecute.Click += new System.EventHandler(this.asyncExecute_Click);
            // 
            // parallelAsyncExecute
            // 
            this.parallelAsyncExecute.Location = new System.Drawing.Point(12, 192);
            this.parallelAsyncExecute.Name = "parallelAsyncExecute";
            this.parallelAsyncExecute.Size = new System.Drawing.Size(651, 51);
            this.parallelAsyncExecute.TabIndex = 3;
            this.parallelAsyncExecute.Text = "Parallel Async Execute";
            this.parallelAsyncExecute.UseVisualStyleBackColor = true;
            this.parallelAsyncExecute.Click += new System.EventHandler(this.parallelAsyncExecute_Click);
            // 
            // cancelation
            // 
            this.cancelation.Location = new System.Drawing.Point(12, 249);
            this.cancelation.Name = "cancelation";
            this.cancelation.Size = new System.Drawing.Size(651, 51);
            this.cancelation.TabIndex = 4;
            this.cancelation.Text = "Cancel Operation";
            this.cancelation.UseVisualStyleBackColor = true;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 349);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(651, 285);
            this.resultBox.TabIndex = 5;
            this.resultBox.Text = "";
            // 
            // AsyncExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 646);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.cancelation);
            this.Controls.Add(this.parallelAsyncExecute);
            this.Controls.Add(this.asyncExecute);
            this.Controls.Add(this.normalParallelExecute);
            this.Controls.Add(this.normalExecute);
            this.Name = "AsyncExample";
            this.Text = "Async Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button normalExecute;
        private System.Windows.Forms.Button normalParallelExecute;
        private System.Windows.Forms.Button asyncExecute;
        private System.Windows.Forms.Button parallelAsyncExecute;
        private System.Windows.Forms.Button cancelation;
        private System.Windows.Forms.RichTextBox resultBox;
    }
}

