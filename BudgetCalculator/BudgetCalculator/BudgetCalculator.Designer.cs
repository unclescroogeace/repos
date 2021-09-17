
namespace BudgetCalculator
{
    partial class BudgetCalculator
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
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.buttonAddIncome = new System.Windows.Forms.Button();
            this.ButtonAddExpense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Location = new System.Drawing.Point(723, 8);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(65, 23);
            this.comboBoxCurrency.TabIndex = 0;
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Location = new System.Drawing.Point(660, 11);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(61, 15);
            this.labelCurrency.TabIndex = 1;
            this.labelCurrency.Text = "Currency :";
            // 
            // buttonAddIncome
            // 
            this.buttonAddIncome.Location = new System.Drawing.Point(13, 11);
            this.buttonAddIncome.Name = "buttonAddIncome";
            this.buttonAddIncome.Size = new System.Drawing.Size(91, 23);
            this.buttonAddIncome.TabIndex = 2;
            this.buttonAddIncome.Text = "Add Income";
            this.buttonAddIncome.UseVisualStyleBackColor = true;
            this.buttonAddIncome.Click += new System.EventHandler(this.ButtonAddIncome_Click);
            // 
            // ButtonAddExpense
            // 
            this.ButtonAddExpense.Location = new System.Drawing.Point(110, 11);
            this.ButtonAddExpense.Name = "ButtonAddExpense";
            this.ButtonAddExpense.Size = new System.Drawing.Size(93, 23);
            this.ButtonAddExpense.TabIndex = 3;
            this.ButtonAddExpense.Text = "Add Expense";
            this.ButtonAddExpense.UseVisualStyleBackColor = true;
            this.ButtonAddExpense.Click += new System.EventHandler(this.ButtonAddExpense_Click);
            // 
            // BudgetCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonAddExpense);
            this.Controls.Add(this.buttonAddIncome);
            this.Controls.Add(this.labelCurrency);
            this.Controls.Add(this.comboBoxCurrency);
            this.Name = "BudgetCalculator";
            this.Text = "Budget Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.Button buttonAddIncome;
        private System.Windows.Forms.Button ButtonAddExpense;
    }
}

