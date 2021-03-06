
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
            this.labelIncome = new System.Windows.Forms.Label();
            this.textBoxIncome = new System.Windows.Forms.TextBox();
            this.labelExpenses = new System.Windows.Forms.Label();
            this.labelAnnually = new System.Windows.Forms.Label();
            this.ButtonIncomeSet = new System.Windows.Forms.Button();
            this.labelHousing = new System.Windows.Forms.Label();
            this.textBoxHousing = new System.Windows.Forms.TextBox();
            this.textBoxTransportation = new System.Windows.Forms.TextBox();
            this.textBoxTaxes = new System.Windows.Forms.TextBox();
            this.textBoxUtilities = new System.Windows.Forms.TextBox();
            this.labelTransportation = new System.Windows.Forms.Label();
            this.labelTaxes = new System.Windows.Forms.Label();
            this.labelUtilities = new System.Windows.Forms.Label();
            this.labelFood = new System.Windows.Forms.Label();
            this.labelInsurance = new System.Windows.Forms.Label();
            this.labelEntertainment = new System.Windows.Forms.Label();
            this.labelEducation = new System.Windows.Forms.Label();
            this.textBoxFood = new System.Windows.Forms.TextBox();
            this.textBoxInsurance = new System.Windows.Forms.TextBox();
            this.textBoxEntertainment = new System.Windows.Forms.TextBox();
            this.textBoxEducation = new System.Windows.Forms.TextBox();
            this.labelVices = new System.Windows.Forms.Label();
            this.labelMiscellaneous = new System.Windows.Forms.Label();
            this.textBoxVices = new System.Windows.Forms.TextBox();
            this.textBoxMiscellaneous = new System.Windows.Forms.TextBox();
            this.ButtonSetExpense = new System.Windows.Forms.Button();
            this.labelSavingsGoals = new System.Windows.Forms.Label();
            this.labelSavings = new System.Windows.Forms.Label();
            this.labelTotalExpenses = new System.Windows.Forms.Label();
            this.labelTotalExpensesAmount = new System.Windows.Forms.Label();
            this.labelGoals = new System.Windows.Forms.Label();
            this.textBoxGoals = new System.Windows.Forms.TextBox();
            this.labelSavingsAmount = new System.Windows.Forms.Label();
            this.ButtonSetGoals = new System.Windows.Forms.Button();
            this.labelHousingBudget = new System.Windows.Forms.Label();
            this.labelTransportationBudget = new System.Windows.Forms.Label();
            this.labelTaxesBudget = new System.Windows.Forms.Label();
            this.labelUtilitiesBudget = new System.Windows.Forms.Label();
            this.labelVicesBudget = new System.Windows.Forms.Label();
            this.labelFoodBudget = new System.Windows.Forms.Label();
            this.labelInsuranceBudget = new System.Windows.Forms.Label();
            this.labelEntertainmentBudget = new System.Windows.Forms.Label();
            this.labelEducationBudget = new System.Windows.Forms.Label();
            this.labelMiscellaneousBudget = new System.Windows.Forms.Label();
            this.labelSavingsCalculation = new System.Windows.Forms.Label();
            this.labelIncomePerMonth = new System.Windows.Forms.Label();
            this.labelSavingsPerMonth = new System.Windows.Forms.Label();
            this.labelTotalExpensesPerMonth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Location = new System.Drawing.Point(36, 12);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(47, 15);
            this.labelIncome.TabIndex = 2;
            this.labelIncome.Text = "Income";
            // 
            // textBoxIncome
            // 
            this.textBoxIncome.Location = new System.Drawing.Point(100, 9);
            this.textBoxIncome.Name = "textBoxIncome";
            this.textBoxIncome.Size = new System.Drawing.Size(100, 23);
            this.textBoxIncome.TabIndex = 3;
            // 
            // labelExpenses
            // 
            this.labelExpenses.AutoSize = true;
            this.labelExpenses.Location = new System.Drawing.Point(6, 42);
            this.labelExpenses.Name = "labelExpenses";
            this.labelExpenses.Size = new System.Drawing.Size(81, 15);
            this.labelExpenses.TabIndex = 4;
            this.labelExpenses.Text = "-- Expenses --";
            // 
            // labelAnnually
            // 
            this.labelAnnually.AutoSize = true;
            this.labelAnnually.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAnnually.ForeColor = System.Drawing.Color.Red;
            this.labelAnnually.Location = new System.Drawing.Point(544, 8);
            this.labelAnnually.Name = "labelAnnually";
            this.labelAnnually.Size = new System.Drawing.Size(360, 15);
            this.labelAnnually.TabIndex = 5;
            this.labelAnnually.Text = "* All amounts which need to be entered are in amount per year!";
            // 
            // ButtonIncomeSet
            // 
            this.ButtonIncomeSet.Location = new System.Drawing.Point(213, 9);
            this.ButtonIncomeSet.Name = "ButtonIncomeSet";
            this.ButtonIncomeSet.Size = new System.Drawing.Size(75, 23);
            this.ButtonIncomeSet.TabIndex = 6;
            this.ButtonIncomeSet.Text = "Set";
            this.ButtonIncomeSet.UseVisualStyleBackColor = true;
            this.ButtonIncomeSet.Click += new System.EventHandler(this.ButtonSetIncome_Click);
            // 
            // labelHousing
            // 
            this.labelHousing.AutoSize = true;
            this.labelHousing.Location = new System.Drawing.Point(32, 72);
            this.labelHousing.Name = "labelHousing";
            this.labelHousing.Size = new System.Drawing.Size(52, 15);
            this.labelHousing.TabIndex = 7;
            this.labelHousing.Text = "Housing";
            // 
            // textBoxHousing
            // 
            this.textBoxHousing.Location = new System.Drawing.Point(101, 69);
            this.textBoxHousing.Name = "textBoxHousing";
            this.textBoxHousing.Size = new System.Drawing.Size(100, 23);
            this.textBoxHousing.TabIndex = 8;
            // 
            // textBoxTransportation
            // 
            this.textBoxTransportation.Location = new System.Drawing.Point(101, 98);
            this.textBoxTransportation.Name = "textBoxTransportation";
            this.textBoxTransportation.Size = new System.Drawing.Size(100, 23);
            this.textBoxTransportation.TabIndex = 9;
            // 
            // textBoxTaxes
            // 
            this.textBoxTaxes.Location = new System.Drawing.Point(101, 127);
            this.textBoxTaxes.Name = "textBoxTaxes";
            this.textBoxTaxes.Size = new System.Drawing.Size(100, 23);
            this.textBoxTaxes.TabIndex = 10;
            // 
            // textBoxUtilities
            // 
            this.textBoxUtilities.Location = new System.Drawing.Point(101, 156);
            this.textBoxUtilities.Name = "textBoxUtilities";
            this.textBoxUtilities.Size = new System.Drawing.Size(100, 23);
            this.textBoxUtilities.TabIndex = 11;
            // 
            // labelTransportation
            // 
            this.labelTransportation.AutoSize = true;
            this.labelTransportation.Location = new System.Drawing.Point(1, 101);
            this.labelTransportation.Name = "labelTransportation";
            this.labelTransportation.Size = new System.Drawing.Size(83, 15);
            this.labelTransportation.TabIndex = 12;
            this.labelTransportation.Text = "Transportation";
            // 
            // labelTaxes
            // 
            this.labelTaxes.AutoSize = true;
            this.labelTaxes.Location = new System.Drawing.Point(49, 127);
            this.labelTaxes.Name = "labelTaxes";
            this.labelTaxes.Size = new System.Drawing.Size(35, 15);
            this.labelTaxes.TabIndex = 13;
            this.labelTaxes.Text = "Taxes";
            // 
            // labelUtilities
            // 
            this.labelUtilities.AutoSize = true;
            this.labelUtilities.Location = new System.Drawing.Point(38, 159);
            this.labelUtilities.Name = "labelUtilities";
            this.labelUtilities.Size = new System.Drawing.Size(46, 15);
            this.labelUtilities.TabIndex = 14;
            this.labelUtilities.Text = "Utilities";
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Location = new System.Drawing.Point(277, 72);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(34, 15);
            this.labelFood.TabIndex = 15;
            this.labelFood.Text = "Food";
            // 
            // labelInsurance
            // 
            this.labelInsurance.AutoSize = true;
            this.labelInsurance.Location = new System.Drawing.Point(253, 101);
            this.labelInsurance.Name = "labelInsurance";
            this.labelInsurance.Size = new System.Drawing.Size(58, 15);
            this.labelInsurance.TabIndex = 16;
            this.labelInsurance.Text = "Insurance";
            // 
            // labelEntertainment
            // 
            this.labelEntertainment.AutoSize = true;
            this.labelEntertainment.Location = new System.Drawing.Point(229, 129);
            this.labelEntertainment.Name = "labelEntertainment";
            this.labelEntertainment.Size = new System.Drawing.Size(82, 15);
            this.labelEntertainment.TabIndex = 17;
            this.labelEntertainment.Text = "Entertainment";
            // 
            // labelEducation
            // 
            this.labelEducation.AutoSize = true;
            this.labelEducation.Location = new System.Drawing.Point(251, 158);
            this.labelEducation.Name = "labelEducation";
            this.labelEducation.Size = new System.Drawing.Size(60, 15);
            this.labelEducation.TabIndex = 18;
            this.labelEducation.Text = "Education";
            // 
            // textBoxFood
            // 
            this.textBoxFood.Location = new System.Drawing.Point(327, 68);
            this.textBoxFood.Name = "textBoxFood";
            this.textBoxFood.Size = new System.Drawing.Size(100, 23);
            this.textBoxFood.TabIndex = 19;
            // 
            // textBoxInsurance
            // 
            this.textBoxInsurance.Location = new System.Drawing.Point(327, 98);
            this.textBoxInsurance.Name = "textBoxInsurance";
            this.textBoxInsurance.Size = new System.Drawing.Size(100, 23);
            this.textBoxInsurance.TabIndex = 20;
            // 
            // textBoxEntertainment
            // 
            this.textBoxEntertainment.Location = new System.Drawing.Point(327, 126);
            this.textBoxEntertainment.Name = "textBoxEntertainment";
            this.textBoxEntertainment.Size = new System.Drawing.Size(100, 23);
            this.textBoxEntertainment.TabIndex = 21;
            // 
            // textBoxEducation
            // 
            this.textBoxEducation.Location = new System.Drawing.Point(327, 155);
            this.textBoxEducation.Name = "textBoxEducation";
            this.textBoxEducation.Size = new System.Drawing.Size(100, 23);
            this.textBoxEducation.TabIndex = 22;
            // 
            // labelVices
            // 
            this.labelVices.AutoSize = true;
            this.labelVices.Location = new System.Drawing.Point(50, 188);
            this.labelVices.Name = "labelVices";
            this.labelVices.Size = new System.Drawing.Size(34, 15);
            this.labelVices.TabIndex = 23;
            this.labelVices.Text = "Vices";
            // 
            // labelMiscellaneous
            // 
            this.labelMiscellaneous.AutoSize = true;
            this.labelMiscellaneous.Location = new System.Drawing.Point(228, 188);
            this.labelMiscellaneous.Name = "labelMiscellaneous";
            this.labelMiscellaneous.Size = new System.Drawing.Size(82, 15);
            this.labelMiscellaneous.TabIndex = 24;
            this.labelMiscellaneous.Text = "Miscellaneous";
            // 
            // textBoxVices
            // 
            this.textBoxVices.Location = new System.Drawing.Point(101, 185);
            this.textBoxVices.Name = "textBoxVices";
            this.textBoxVices.Size = new System.Drawing.Size(100, 23);
            this.textBoxVices.TabIndex = 25;
            // 
            // textBoxMiscellaneous
            // 
            this.textBoxMiscellaneous.Location = new System.Drawing.Point(327, 184);
            this.textBoxMiscellaneous.Name = "textBoxMiscellaneous";
            this.textBoxMiscellaneous.Size = new System.Drawing.Size(100, 23);
            this.textBoxMiscellaneous.TabIndex = 26;
            // 
            // ButtonSetExpense
            // 
            this.ButtonSetExpense.Location = new System.Drawing.Point(352, 221);
            this.ButtonSetExpense.Name = "ButtonSetExpense";
            this.ButtonSetExpense.Size = new System.Drawing.Size(75, 23);
            this.ButtonSetExpense.TabIndex = 27;
            this.ButtonSetExpense.Text = "Set";
            this.ButtonSetExpense.UseVisualStyleBackColor = true;
            this.ButtonSetExpense.Click += new System.EventHandler(this.ButtonSetExpense_Click);
            // 
            // labelSavingsGoals
            // 
            this.labelSavingsGoals.AutoSize = true;
            this.labelSavingsGoals.Location = new System.Drawing.Point(6, 264);
            this.labelSavingsGoals.Name = "labelSavingsGoals";
            this.labelSavingsGoals.Size = new System.Drawing.Size(113, 15);
            this.labelSavingsGoals.TabIndex = 28;
            this.labelSavingsGoals.Text = "-- Savings / Goals --";
            // 
            // labelSavings
            // 
            this.labelSavings.AutoSize = true;
            this.labelSavings.Location = new System.Drawing.Point(40, 298);
            this.labelSavings.Name = "labelSavings";
            this.labelSavings.Size = new System.Drawing.Size(47, 15);
            this.labelSavings.TabIndex = 29;
            this.labelSavings.Text = "Savings";
            // 
            // labelTotalExpenses
            // 
            this.labelTotalExpenses.AutoSize = true;
            this.labelTotalExpenses.Location = new System.Drawing.Point(43, 225);
            this.labelTotalExpenses.Name = "labelTotalExpenses";
            this.labelTotalExpenses.Size = new System.Drawing.Size(89, 15);
            this.labelTotalExpenses.TabIndex = 31;
            this.labelTotalExpenses.Text = "Total Expenses :";
            // 
            // labelTotalExpensesAmount
            // 
            this.labelTotalExpensesAmount.AutoSize = true;
            this.labelTotalExpensesAmount.Location = new System.Drawing.Point(131, 225);
            this.labelTotalExpensesAmount.Name = "labelTotalExpensesAmount";
            this.labelTotalExpensesAmount.Size = new System.Drawing.Size(0, 15);
            this.labelTotalExpensesAmount.TabIndex = 32;
            // 
            // labelGoals
            // 
            this.labelGoals.AutoSize = true;
            this.labelGoals.Location = new System.Drawing.Point(51, 327);
            this.labelGoals.Name = "labelGoals";
            this.labelGoals.Size = new System.Drawing.Size(36, 15);
            this.labelGoals.TabIndex = 33;
            this.labelGoals.Text = "Goals";
            // 
            // textBoxGoals
            // 
            this.textBoxGoals.Location = new System.Drawing.Point(101, 324);
            this.textBoxGoals.Name = "textBoxGoals";
            this.textBoxGoals.Size = new System.Drawing.Size(100, 23);
            this.textBoxGoals.TabIndex = 34;
            // 
            // labelSavingsAmount
            // 
            this.labelSavingsAmount.AutoSize = true;
            this.labelSavingsAmount.Location = new System.Drawing.Point(101, 298);
            this.labelSavingsAmount.Name = "labelSavingsAmount";
            this.labelSavingsAmount.Size = new System.Drawing.Size(0, 15);
            this.labelSavingsAmount.TabIndex = 35;
            // 
            // ButtonSetGoals
            // 
            this.ButtonSetGoals.Location = new System.Drawing.Point(213, 323);
            this.ButtonSetGoals.Name = "ButtonSetGoals";
            this.ButtonSetGoals.Size = new System.Drawing.Size(75, 23);
            this.ButtonSetGoals.TabIndex = 36;
            this.ButtonSetGoals.Text = "Set";
            this.ButtonSetGoals.UseVisualStyleBackColor = true;
            this.ButtonSetGoals.Click += new System.EventHandler(this.ButtonSetGoals_Click);
            // 
            // labelHousingBudget
            // 
            this.labelHousingBudget.AutoSize = true;
            this.labelHousingBudget.Location = new System.Drawing.Point(484, 69);
            this.labelHousingBudget.Name = "labelHousingBudget";
            this.labelHousingBudget.Size = new System.Drawing.Size(0, 15);
            this.labelHousingBudget.TabIndex = 39;
            // 
            // labelTransportationBudget
            // 
            this.labelTransportationBudget.AutoSize = true;
            this.labelTransportationBudget.Location = new System.Drawing.Point(484, 109);
            this.labelTransportationBudget.Name = "labelTransportationBudget";
            this.labelTransportationBudget.Size = new System.Drawing.Size(0, 15);
            this.labelTransportationBudget.TabIndex = 40;
            // 
            // labelTaxesBudget
            // 
            this.labelTaxesBudget.AutoSize = true;
            this.labelTaxesBudget.Location = new System.Drawing.Point(484, 148);
            this.labelTaxesBudget.Name = "labelTaxesBudget";
            this.labelTaxesBudget.Size = new System.Drawing.Size(0, 15);
            this.labelTaxesBudget.TabIndex = 41;
            // 
            // labelUtilitiesBudget
            // 
            this.labelUtilitiesBudget.AutoSize = true;
            this.labelUtilitiesBudget.Location = new System.Drawing.Point(484, 186);
            this.labelUtilitiesBudget.Name = "labelUtilitiesBudget";
            this.labelUtilitiesBudget.Size = new System.Drawing.Size(0, 15);
            this.labelUtilitiesBudget.TabIndex = 42;
            // 
            // labelVicesBudget
            // 
            this.labelVicesBudget.AutoSize = true;
            this.labelVicesBudget.Location = new System.Drawing.Point(484, 224);
            this.labelVicesBudget.Name = "labelVicesBudget";
            this.labelVicesBudget.Size = new System.Drawing.Size(0, 15);
            this.labelVicesBudget.TabIndex = 43;
            // 
            // labelFoodBudget
            // 
            this.labelFoodBudget.AutoSize = true;
            this.labelFoodBudget.Location = new System.Drawing.Point(484, 264);
            this.labelFoodBudget.Name = "labelFoodBudget";
            this.labelFoodBudget.Size = new System.Drawing.Size(0, 15);
            this.labelFoodBudget.TabIndex = 44;
            // 
            // labelInsuranceBudget
            // 
            this.labelInsuranceBudget.AutoSize = true;
            this.labelInsuranceBudget.Location = new System.Drawing.Point(484, 305);
            this.labelInsuranceBudget.Name = "labelInsuranceBudget";
            this.labelInsuranceBudget.Size = new System.Drawing.Size(0, 15);
            this.labelInsuranceBudget.TabIndex = 45;
            // 
            // labelEntertainmentBudget
            // 
            this.labelEntertainmentBudget.AutoSize = true;
            this.labelEntertainmentBudget.Location = new System.Drawing.Point(484, 343);
            this.labelEntertainmentBudget.Name = "labelEntertainmentBudget";
            this.labelEntertainmentBudget.Size = new System.Drawing.Size(0, 15);
            this.labelEntertainmentBudget.TabIndex = 46;
            // 
            // labelEducationBudget
            // 
            this.labelEducationBudget.AutoSize = true;
            this.labelEducationBudget.Location = new System.Drawing.Point(484, 379);
            this.labelEducationBudget.Name = "labelEducationBudget";
            this.labelEducationBudget.Size = new System.Drawing.Size(0, 15);
            this.labelEducationBudget.TabIndex = 47;
            // 
            // labelMiscellaneousBudget
            // 
            this.labelMiscellaneousBudget.AutoSize = true;
            this.labelMiscellaneousBudget.Location = new System.Drawing.Point(484, 418);
            this.labelMiscellaneousBudget.Name = "labelMiscellaneousBudget";
            this.labelMiscellaneousBudget.Size = new System.Drawing.Size(0, 15);
            this.labelMiscellaneousBudget.TabIndex = 48;
            // 
            // labelSavingsCalculation
            // 
            this.labelSavingsCalculation.AutoSize = true;
            this.labelSavingsCalculation.Location = new System.Drawing.Point(44, 381);
            this.labelSavingsCalculation.Name = "labelSavingsCalculation";
            this.labelSavingsCalculation.Size = new System.Drawing.Size(0, 15);
            this.labelSavingsCalculation.TabIndex = 50;
            // 
            // labelIncomePerMonth
            // 
            this.labelIncomePerMonth.AutoSize = true;
            this.labelIncomePerMonth.Location = new System.Drawing.Point(295, 11);
            this.labelIncomePerMonth.Name = "labelIncomePerMonth";
            this.labelIncomePerMonth.Size = new System.Drawing.Size(0, 15);
            this.labelIncomePerMonth.TabIndex = 52;
            // 
            // labelSavingsPerMonth
            // 
            this.labelSavingsPerMonth.AutoSize = true;
            this.labelSavingsPerMonth.Location = new System.Drawing.Point(192, 298);
            this.labelSavingsPerMonth.Name = "labelSavingsPerMonth";
            this.labelSavingsPerMonth.Size = new System.Drawing.Size(0, 15);
            this.labelSavingsPerMonth.TabIndex = 53;
            // 
            // labelTotalExpensesPerMonth
            // 
            this.labelTotalExpensesPerMonth.AutoSize = true;
            this.labelTotalExpensesPerMonth.Location = new System.Drawing.Point(244, 225);
            this.labelTotalExpensesPerMonth.Name = "labelTotalExpensesPerMonth";
            this.labelTotalExpensesPerMonth.Size = new System.Drawing.Size(0, 15);
            this.labelTotalExpensesPerMonth.TabIndex = 54;
            // 
            // BudgetCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 513);
            this.Controls.Add(this.labelTotalExpensesPerMonth);
            this.Controls.Add(this.labelSavingsPerMonth);
            this.Controls.Add(this.labelIncomePerMonth);
            this.Controls.Add(this.labelSavingsCalculation);
            this.Controls.Add(this.labelMiscellaneousBudget);
            this.Controls.Add(this.labelEducationBudget);
            this.Controls.Add(this.labelEntertainmentBudget);
            this.Controls.Add(this.labelInsuranceBudget);
            this.Controls.Add(this.labelFoodBudget);
            this.Controls.Add(this.labelVicesBudget);
            this.Controls.Add(this.labelUtilitiesBudget);
            this.Controls.Add(this.labelTaxesBudget);
            this.Controls.Add(this.labelTransportationBudget);
            this.Controls.Add(this.labelHousingBudget);
            this.Controls.Add(this.ButtonSetGoals);
            this.Controls.Add(this.labelSavingsAmount);
            this.Controls.Add(this.textBoxGoals);
            this.Controls.Add(this.labelGoals);
            this.Controls.Add(this.labelTotalExpensesAmount);
            this.Controls.Add(this.labelTotalExpenses);
            this.Controls.Add(this.labelSavings);
            this.Controls.Add(this.labelSavingsGoals);
            this.Controls.Add(this.ButtonSetExpense);
            this.Controls.Add(this.textBoxMiscellaneous);
            this.Controls.Add(this.textBoxVices);
            this.Controls.Add(this.labelMiscellaneous);
            this.Controls.Add(this.labelVices);
            this.Controls.Add(this.textBoxEducation);
            this.Controls.Add(this.textBoxEntertainment);
            this.Controls.Add(this.textBoxInsurance);
            this.Controls.Add(this.textBoxFood);
            this.Controls.Add(this.labelEducation);
            this.Controls.Add(this.labelEntertainment);
            this.Controls.Add(this.labelInsurance);
            this.Controls.Add(this.labelFood);
            this.Controls.Add(this.labelUtilities);
            this.Controls.Add(this.labelTaxes);
            this.Controls.Add(this.labelTransportation);
            this.Controls.Add(this.textBoxUtilities);
            this.Controls.Add(this.textBoxTaxes);
            this.Controls.Add(this.textBoxTransportation);
            this.Controls.Add(this.textBoxHousing);
            this.Controls.Add(this.labelHousing);
            this.Controls.Add(this.ButtonIncomeSet);
            this.Controls.Add(this.labelAnnually);
            this.Controls.Add(this.labelExpenses);
            this.Controls.Add(this.textBoxIncome);
            this.Controls.Add(this.labelIncome);
            this.Name = "BudgetCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.TextBox textBoxIncome;
        private System.Windows.Forms.Label labelExpenses;
        private System.Windows.Forms.Label labelAnnually;
        private System.Windows.Forms.Button ButtonIncomeSet;
        private System.Windows.Forms.Label labelHousing;
        private System.Windows.Forms.TextBox textBoxHousing;
        private System.Windows.Forms.TextBox textBoxTransportation;
        private System.Windows.Forms.TextBox textBoxTaxes;
        private System.Windows.Forms.TextBox textBoxUtilities;
        private System.Windows.Forms.Label labelTransportation;
        private System.Windows.Forms.Label labelTaxes;
        private System.Windows.Forms.Label labelUtilities;
        private System.Windows.Forms.Label labelFood;
        private System.Windows.Forms.Label labelInsurance;
        private System.Windows.Forms.Label labelEntertainment;
        private System.Windows.Forms.Label labelEducation;
        private System.Windows.Forms.TextBox textBoxFood;
        private System.Windows.Forms.TextBox textBoxInsurance;
        private System.Windows.Forms.TextBox textBoxEntertainment;
        private System.Windows.Forms.TextBox textBoxEducation;
        private System.Windows.Forms.Label labelVices;
        private System.Windows.Forms.Label labelMiscellaneous;
        private System.Windows.Forms.TextBox textBoxVices;
        private System.Windows.Forms.TextBox textBoxMiscellaneous;
        private System.Windows.Forms.Button ButtonSetExpense;
        private System.Windows.Forms.Label labelSavingsGoals;
        private System.Windows.Forms.Label labelSavings;
        private System.Windows.Forms.Label labelTotalExpenses;
        private System.Windows.Forms.Label labelTotalExpensesAmount;
        private System.Windows.Forms.Label labelGoals;
        private System.Windows.Forms.TextBox textBoxGoals;
        private System.Windows.Forms.Label labelSavingsAmount;
        private System.Windows.Forms.Button ButtonSetGoals;
        private System.Windows.Forms.Label labelHousingBudget;
        private System.Windows.Forms.Label labelTransportationBudget;
        private System.Windows.Forms.Label labelTaxesBudget;
        private System.Windows.Forms.Label labelUtilitiesBudget;
        private System.Windows.Forms.Label labelVicesBudget;
        private System.Windows.Forms.Label labelFoodBudget;
        private System.Windows.Forms.Label labelInsuranceBudget;
        private System.Windows.Forms.Label labelEntertainmentBudget;
        private System.Windows.Forms.Label labelEducationBudget;
        private System.Windows.Forms.Label labelMiscellaneousBudget;
        private System.Windows.Forms.Label labelSavingsCalculation;
        private System.Windows.Forms.Label labelIncomePerMonth;
        private System.Windows.Forms.Label labelSavingsPerMonth;
        private System.Windows.Forms.Label labelTotalExpensesPerMonth;
    }
}

