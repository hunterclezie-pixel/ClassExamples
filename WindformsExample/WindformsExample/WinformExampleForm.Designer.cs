namespace WindformsExample
{
    partial class WinformExampleForm
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
            components = new System.ComponentModel.Container();
            SubmitButton = new Button();
            ExitButton = new Button();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            ClearButton = new Button();
            AgeLabel = new Label();
            AgeTextBox = new TextBox();
            PhoneLabel = new Label();
            PhoneTextBox = new TextBox();
            CityLabel = new Label();
            CityTextBox = new TextBox();
            ButtonGroupBox = new GroupBox();
            UserInfoGroupBox = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            UpperCaseRadioButton = new RadioButton();
            LowerCaseRadioButton = new RadioButton();
            ReverseCaseRadioButton = new RadioButton();
            ToolTip = new ToolTip(components);
            DisplayLabel = new Label();
            ButtonGroupBox.SuspendLayout();
            UserInfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(7, 26);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(107, 50);
            SubmitButton.TabIndex = 5;
            SubmitButton.Text = "&Submit";
            ToolTip.SetToolTip(SubmitButton, "Alt + s");
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(233, 26);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(107, 50);
            ExitButton.TabIndex = 7;
            ExitButton.TabStop = false;
            ExitButton.Text = "E&xit";
            ToolTip.SetToolTip(ExitButton, "Alt + x");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(73, 28);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(293, 27);
            NameTextBox.TabIndex = 1;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(17, 31);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Name";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(120, 26);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(107, 50);
            ClearButton.TabIndex = 6;
            ClearButton.TabStop = false;
            ClearButton.Text = "&Clear";
            ToolTip.SetToolTip(ClearButton, "Alt + c");
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(17, 64);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(36, 20);
            AgeLabel.TabIndex = 6;
            AgeLabel.Text = "Age";
            AgeLabel.Click += label1_Click;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(73, 61);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(293, 27);
            AgeTextBox.TabIndex = 2;
            AgeTextBox.TextChanged += AgeTextBox_TextChanged;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(17, 130);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(50, 20);
            PhoneLabel.TabIndex = 10;
            PhoneLabel.Text = "Phone";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(73, 127);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(293, 27);
            PhoneTextBox.TabIndex = 4;
            PhoneTextBox.TextChanged += PhoneTextBox_TextChanged;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(17, 97);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(34, 20);
            CityLabel.TabIndex = 8;
            CityLabel.Text = "City";
            CityLabel.Click += label3_Click;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(73, 94);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(293, 27);
            CityTextBox.TabIndex = 3;
            // 
            // ButtonGroupBox
            // 
            ButtonGroupBox.Controls.Add(ExitButton);
            ButtonGroupBox.Controls.Add(SubmitButton);
            ButtonGroupBox.Controls.Add(ClearButton);
            ButtonGroupBox.Location = new Point(390, 318);
            ButtonGroupBox.Name = "ButtonGroupBox";
            ButtonGroupBox.Size = new Size(351, 88);
            ButtonGroupBox.TabIndex = 5;
            ButtonGroupBox.TabStop = false;
            // 
            // UserInfoGroupBox
            // 
            UserInfoGroupBox.Controls.Add(PhoneTextBox);
            UserInfoGroupBox.Controls.Add(NameTextBox);
            UserInfoGroupBox.Controls.Add(PhoneLabel);
            UserInfoGroupBox.Controls.Add(NameLabel);
            UserInfoGroupBox.Controls.Add(AgeTextBox);
            UserInfoGroupBox.Controls.Add(CityLabel);
            UserInfoGroupBox.Controls.Add(AgeLabel);
            UserInfoGroupBox.Controls.Add(CityTextBox);
            UserInfoGroupBox.Location = new Point(12, 31);
            UserInfoGroupBox.Name = "UserInfoGroupBox";
            UserInfoGroupBox.Size = new Size(372, 172);
            UserInfoGroupBox.TabIndex = 0;
            UserInfoGroupBox.TabStop = false;
            UserInfoGroupBox.Text = "User Info";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(296, 255);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(101, 24);
            checkBox3.TabIndex = 12;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(296, 222);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(101, 24);
            checkBox4.TabIndex = 1;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // UpperCaseRadioButton
            // 
            UpperCaseRadioButton.AutoSize = true;
            UpperCaseRadioButton.Location = new Point(85, 216);
            UpperCaseRadioButton.Name = "UpperCaseRadioButton";
            UpperCaseRadioButton.Size = new Size(71, 24);
            UpperCaseRadioButton.TabIndex = 0;
            UpperCaseRadioButton.TabStop = true;
            UpperCaseRadioButton.Text = "Upper";
            ToolTip.SetToolTip(UpperCaseRadioButton, "Make all uppercase");
            UpperCaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // LowerCaseRadioButton
            // 
            LowerCaseRadioButton.AutoSize = true;
            LowerCaseRadioButton.Location = new Point(85, 243);
            LowerCaseRadioButton.Name = "LowerCaseRadioButton";
            LowerCaseRadioButton.Size = new Size(70, 24);
            LowerCaseRadioButton.TabIndex = 24;
            LowerCaseRadioButton.TabStop = true;
            LowerCaseRadioButton.Text = "Lower";
            LowerCaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // ReverseCaseRadioButton
            // 
            ReverseCaseRadioButton.AutoSize = true;
            ReverseCaseRadioButton.Location = new Point(85, 273);
            ReverseCaseRadioButton.Name = "ReverseCaseRadioButton";
            ReverseCaseRadioButton.Size = new Size(81, 24);
            ReverseCaseRadioButton.TabIndex = 23;
            ReverseCaseRadioButton.TabStop = true;
            ReverseCaseRadioButton.Text = "Reverse";
            ReverseCaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // DisplayLabel
            // 
            DisplayLabel.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DisplayLabel.Location = new Point(451, 31);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(279, 172);
            DisplayLabel.TabIndex = 25;
            DisplayLabel.Click += label1_Click_1;
            // 
            // WinformExampleForm
            // 
            AcceptButton = SubmitButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ClearButton;
            ClientSize = new Size(800, 450);
            Controls.Add(DisplayLabel);
            Controls.Add(LowerCaseRadioButton);
            Controls.Add(ReverseCaseRadioButton);
            Controls.Add(UpperCaseRadioButton);
            Controls.Add(checkBox3);
            Controls.Add(checkBox4);
            Controls.Add(UserInfoGroupBox);
            Controls.Add(ButtonGroupBox);
            Name = "WinformExampleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Example Form";
            ToolTip.SetToolTip(this, "These are control boxes");
            Load += Form1_Load;
            ButtonGroupBox.ResumeLayout(false);
            UserInfoGroupBox.ResumeLayout(false);
            UserInfoGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitButton;
        private Button ExitButton;
        private TextBox NameTextBox;
        private Label NameLabel;
        private Button ClearButton;
        private Label AgeLabel;
        private TextBox AgeTextBox;
        private Label PhoneLabel;
        private TextBox PhoneTextBox;
        private Label CityLabel;
        private TextBox CityTextBox;
        private GroupBox ButtonGroupBox;
        private GroupBox UserInfoGroupBox;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private RadioButton UpperCaseRadioButton;
        private RadioButton LowerCaseRadioButton;
        private RadioButton ReverseCaseRadioButton;
        private ToolTip ToolTip;
        private Label DisplayLabel;
    }
}
