
namespace BudgetCalculator
{
    partial class Expense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.comboBoxExpenseType = new System.Windows.Forms.ComboBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonAddExpense = new System.Windows.Forms.Button();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(74, 39);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(186, 23);
            this.textBoxAmount.TabIndex = 0;
            // 
            // comboBoxExpenseType
            // 
            this.comboBoxExpenseType.FormattingEnabled = true;
            this.comboBoxExpenseType.Location = new System.Drawing.Point(74, 10);
            this.comboBoxExpenseType.Name = "comboBoxExpenseType";
            this.comboBoxExpenseType.Size = new System.Drawing.Size(227, 23);
            this.comboBoxExpenseType.TabIndex = 1;
            this.comboBoxExpenseType.Text = "-- Default --";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(74, 69);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(227, 217);
            this.richTextBoxDescription.TabIndex = 2;
            this.richTextBoxDescription.Text = "";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(37, 13);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 15);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Type";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(18, 42);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(51, 15);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "Amount";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(4, 71);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(67, 15);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Description";
            // 
            // buttonAddExpense
            // 
            this.buttonAddExpense.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddExpense.Location = new System.Drawing.Point(88, 302);
            this.buttonAddExpense.Name = "buttonAddExpense";
            this.buttonAddExpense.Size = new System.Drawing.Size(138, 42);
            this.buttonAddExpense.TabIndex = 6;
            this.buttonAddExpense.Text = "Add Expense";
            this.buttonAddExpense.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddExpense.UseVisualStyleBackColor = true;
            this.buttonAddExpense.Click += new System.EventHandler(this.ButtonAddExpense_Click);
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Location = new System.Drawing.Point(261, 44);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(0, 15);
            this.labelCurrency.TabIndex = 7;
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 359);
            this.Controls.Add(this.labelCurrency);
            this.Controls.Add(this.buttonAddExpense);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.comboBoxExpenseType);
            this.Controls.Add(this.textBoxAmount);
            this.Name = "Expense";
            this.Text = "Expense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.ComboBox comboBoxExpenseType;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonAddExpense;
        private System.Windows.Forms.Label labelCurrency;
    }
}