namespace TipAndTaxCalculator
{
    partial class TipAndTaxCalculator
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
            CalculateButton = new Button();
            ClearButton = new Button();
            Tip15RadioButton = new RadioButton();
            Tip18RadioButton = new RadioButton();
            Tip20RadioButton = new RadioButton();
            ExitButton = new Button();
            DiscountAAACheckBox = new CheckBox();
            DiscountDCCheckBox = new CheckBox();
            DollarAmountTextBox = new TextBox();
            AmountLabel = new Label();
            DisplayLabel = new Label();
            TipLabel = new Label();
            TipCustomRadioButton = new RadioButton();
            DiscountLabel = new Label();
            TipCustomTextBox = new TextBox();
            TipCurrancyLabel = new Label();
            SuspendLayout();
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(389, 390);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(129, 48);
            CalculateButton.TabIndex = 0;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(524, 390);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(129, 48);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // Tip15RadioButton
            // 
            Tip15RadioButton.AutoSize = true;
            Tip15RadioButton.Location = new Point(157, 87);
            Tip15RadioButton.Name = "Tip15RadioButton";
            Tip15RadioButton.Size = new Size(58, 24);
            Tip15RadioButton.TabIndex = 2;
            Tip15RadioButton.TabStop = true;
            Tip15RadioButton.Text = "15%";
            Tip15RadioButton.UseVisualStyleBackColor = true;
            // 
            // Tip18RadioButton
            // 
            Tip18RadioButton.AutoSize = true;
            Tip18RadioButton.Location = new Point(157, 117);
            Tip18RadioButton.Name = "Tip18RadioButton";
            Tip18RadioButton.Size = new Size(58, 24);
            Tip18RadioButton.TabIndex = 3;
            Tip18RadioButton.TabStop = true;
            Tip18RadioButton.Text = "18%";
            Tip18RadioButton.UseVisualStyleBackColor = true;
            // 
            // Tip20RadioButton
            // 
            Tip20RadioButton.AutoSize = true;
            Tip20RadioButton.Location = new Point(157, 147);
            Tip20RadioButton.Name = "Tip20RadioButton";
            Tip20RadioButton.Size = new Size(58, 24);
            Tip20RadioButton.TabIndex = 4;
            Tip20RadioButton.TabStop = true;
            Tip20RadioButton.Text = "20%";
            Tip20RadioButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(659, 390);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(129, 48);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DiscountAAACheckBox
            // 
            DiscountAAACheckBox.AutoSize = true;
            DiscountAAACheckBox.Location = new Point(157, 206);
            DiscountAAACheckBox.Name = "DiscountAAACheckBox";
            DiscountAAACheckBox.Size = new Size(61, 24);
            DiscountAAACheckBox.TabIndex = 6;
            DiscountAAACheckBox.Text = "AAA";
            DiscountAAACheckBox.UseVisualStyleBackColor = true;
            // 
            // DiscountDCCheckBox
            // 
            DiscountDCCheckBox.AutoSize = true;
            DiscountDCCheckBox.Location = new Point(157, 236);
            DiscountDCCheckBox.Name = "DiscountDCCheckBox";
            DiscountDCCheckBox.Size = new Size(111, 24);
            DiscountDCCheckBox.TabIndex = 7;
            DiscountDCCheckBox.Text = "Diner's Card";
            DiscountDCCheckBox.UseVisualStyleBackColor = true;
            // 
            // DollarAmountTextBox
            // 
            DollarAmountTextBox.Location = new Point(157, 51);
            DollarAmountTextBox.Name = "DollarAmountTextBox";
            DollarAmountTextBox.Size = new Size(125, 27);
            DollarAmountTextBox.TabIndex = 8;
            DollarAmountTextBox.TextChanged += DollarAmountTextBox_TextChanged;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(44, 54);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(107, 20);
            AmountLabel.TabIndex = 10;
            AmountLabel.Text = "Dollar Amount";
            // 
            // DisplayLabel
            // 
            DisplayLabel.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DisplayLabel.Location = new Point(389, 51);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(399, 285);
            DisplayLabel.TabIndex = 11;
            // 
            // TipLabel
            // 
            TipLabel.AutoSize = true;
            TipLabel.Location = new Point(64, 87);
            TipLabel.Name = "TipLabel";
            TipLabel.Size = new Size(87, 20);
            TipLabel.TabIndex = 12;
            TipLabel.Text = "Tip Amount";
            // 
            // TipCustomRadioButton
            // 
            TipCustomRadioButton.AutoSize = true;
            TipCustomRadioButton.Location = new Point(157, 177);
            TipCustomRadioButton.Name = "TipCustomRadioButton";
            TipCustomRadioButton.Size = new Size(80, 24);
            TipCustomRadioButton.TabIndex = 13;
            TipCustomRadioButton.TabStop = true;
            TipCustomRadioButton.Text = "Custom";
            TipCustomRadioButton.UseVisualStyleBackColor = true;
            TipCustomRadioButton.CheckedChanged += TipCustomRadioButton_CheckedChanged;
            // 
            // DiscountLabel
            // 
            DiscountLabel.AutoSize = true;
            DiscountLabel.Location = new Point(64, 207);
            DiscountLabel.Name = "DiscountLabel";
            DiscountLabel.Size = new Size(73, 20);
            DiscountLabel.TabIndex = 14;
            DiscountLabel.Text = "Discounts";
            // 
            // TipCustomTextBox
            // 
            TipCustomTextBox.Location = new Point(266, 178);
            TipCustomTextBox.Name = "TipCustomTextBox";
            TipCustomTextBox.Size = new Size(78, 27);
            TipCustomTextBox.TabIndex = 15;
            TipCustomTextBox.TabStop = false;
            // 
            // TipCurrancyLabel
            // 
            TipCurrancyLabel.AutoSize = true;
            TipCurrancyLabel.Location = new Point(243, 181);
            TipCurrancyLabel.Name = "TipCurrancyLabel";
            TipCurrancyLabel.Size = new Size(17, 20);
            TipCurrancyLabel.TabIndex = 16;
            TipCurrancyLabel.Text = "$";
            // 
            // TipAndTaxCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TipCurrancyLabel);
            Controls.Add(TipCustomTextBox);
            Controls.Add(DiscountLabel);
            Controls.Add(TipCustomRadioButton);
            Controls.Add(TipLabel);
            Controls.Add(DisplayLabel);
            Controls.Add(AmountLabel);
            Controls.Add(DollarAmountTextBox);
            Controls.Add(DiscountDCCheckBox);
            Controls.Add(DiscountAAACheckBox);
            Controls.Add(ExitButton);
            Controls.Add(Tip20RadioButton);
            Controls.Add(Tip18RadioButton);
            Controls.Add(Tip15RadioButton);
            Controls.Add(ClearButton);
            Controls.Add(CalculateButton);
            Name = "TipAndTaxCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tip And Tax Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalculateButton;
        private Button ClearButton;
        private RadioButton Tip15RadioButton;
        private RadioButton Tip18RadioButton;
        private RadioButton Tip20RadioButton;
        private Button ExitButton;
        private CheckBox DiscountAAACheckBox;
        private CheckBox DiscountDCCheckBox;
        private TextBox DollarAmountTextBox;
        private Label AmountLabel;
        private Label DisplayLabel;
        private Label TipLabel;
        private RadioButton TipCustomRadioButton;
        private Label DiscountLabel;
        private TextBox TipCustomTextBox;
        private Label TipCurrancyLabel;
    }
}
