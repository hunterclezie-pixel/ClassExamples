namespace ListExamples
{
    partial class ListExampleForm
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
            ExitButton = new Button();
            ClearButton = new Button();
            SubmitButton = new Button();
            InfoGroupBox = new GroupBox();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            CompanyTextBox = new TextBox();
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            CompanyLabel = new Label();
            OutputGroupBox = new GroupBox();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            InfoGroupBox.SuspendLayout();
            OutputGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(694, 384);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 54);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(594, 384);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 54);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(494, 384);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(94, 54);
            SubmitButton.TabIndex = 2;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            // 
            // InfoGroupBox
            // 
            InfoGroupBox.Controls.Add(CompanyLabel);
            InfoGroupBox.Controls.Add(LastNameLabel);
            InfoGroupBox.Controls.Add(FirstNameLabel);
            InfoGroupBox.Controls.Add(CompanyTextBox);
            InfoGroupBox.Controls.Add(LastNameTextBox);
            InfoGroupBox.Controls.Add(FirstNameTextBox);
            InfoGroupBox.Location = new Point(12, 12);
            InfoGroupBox.Name = "InfoGroupBox";
            InfoGroupBox.Size = new Size(319, 393);
            InfoGroupBox.TabIndex = 3;
            InfoGroupBox.TabStop = false;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(88, 41);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(184, 27);
            FirstNameTextBox.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(88, 74);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(184, 27);
            LastNameTextBox.TabIndex = 1;
            // 
            // CompanyTextBox
            // 
            CompanyTextBox.Location = new Point(88, 107);
            CompanyTextBox.Name = "CompanyTextBox";
            CompanyTextBox.Size = new Size(184, 27);
            CompanyTextBox.TabIndex = 2;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(47, 44);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(36, 20);
            FirstNameLabel.TabIndex = 3;
            FirstNameLabel.Text = "First";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(47, 77);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(35, 20);
            LastNameLabel.TabIndex = 4;
            LastNameLabel.Text = "Last";
            // 
            // CompanyLabel
            // 
            CompanyLabel.AutoSize = true;
            CompanyLabel.Location = new Point(10, 110);
            CompanyLabel.Name = "CompanyLabel";
            CompanyLabel.Size = new Size(72, 20);
            CompanyLabel.TabIndex = 5;
            CompanyLabel.Text = "Company";
            // 
            // OutputGroupBox
            // 
            OutputGroupBox.Controls.Add(listBox1);
            OutputGroupBox.Controls.Add(comboBox1);
            OutputGroupBox.Location = new Point(386, 33);
            OutputGroupBox.Name = "OutputGroupBox";
            OutputGroupBox.Size = new Size(390, 339);
            OutputGroupBox.TabIndex = 4;
            OutputGroupBox.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(6, 109);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(378, 224);
            listBox1.TabIndex = 1;
            // 
            // ListExampleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OutputGroupBox);
            Controls.Add(InfoGroupBox);
            Controls.Add(SubmitButton);
            Controls.Add(ClearButton);
            Controls.Add(ExitButton);
            Name = "ListExampleForm";
            Text = "Form1";
            InfoGroupBox.ResumeLayout(false);
            InfoGroupBox.PerformLayout();
            OutputGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private Button ClearButton;
        private Button SubmitButton;
        private GroupBox InfoGroupBox;
        private Label CompanyLabel;
        private Label LastNameLabel;
        private Label FirstNameLabel;
        private TextBox CompanyTextBox;
        private TextBox LastNameTextBox;
        private TextBox FirstNameTextBox;
        private GroupBox OutputGroupBox;
        private ListBox listBox1;
        private ComboBox comboBox1;
    }
}
