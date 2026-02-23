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
            SubmitButton = new Button();
            ExitButton = new Button();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(565, 287);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(94, 29);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(565, 322);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(222, 124);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(293, 27);
            NameTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(166, 127);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Name";
            // 
            // WinformExampleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NameLabel);
            Controls.Add(NameTextBox);
            Controls.Add(ExitButton);
            Controls.Add(SubmitButton);
            Name = "WinformExampleForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitButton;
        private Button ExitButton;
        private TextBox NameTextBox;
        private Label NameLabel;
    }
}
