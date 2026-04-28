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
            menuStrip1 = new MenuStrip();
            FileTopMenuStrip = new ToolStripMenuItem();
            OpenTopMenuItem = new ToolStripMenuItem();
            SubmitTopMenuItem = new ToolStripMenuItem();
            ClearTopMenuItem = new ToolStripMenuItem();
            ExitTopMenuItem = new ToolStripMenuItem();
            HelpStripMenu = new ToolStripMenuItem();
            AboutStripMenu = new ToolStripMenuItem();
            FormatOptionGroupBox = new GroupBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            UpperContextMenuItem = new ToolStripMenuItem();
            LowerContextMenuItem = new ToolStripMenuItem();
            ReverseContextMenuItem = new ToolStripMenuItem();
            MainOpenFileDialog = new OpenFileDialog();
            DisplayListBox = new ListBox();
            FilterComboBox = new ComboBox();
            FilterGroupBox = new GroupBox();
            FirstNameRadioButton = new RadioButton();
            LastNameRadioButton = new RadioButton();
            CityRadioButton = new RadioButton();
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            ButtonGroupBox.SuspendLayout();
            UserInfoGroupBox.SuspendLayout();
            menuStrip1.SuspendLayout();
            FormatOptionGroupBox.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            FilterGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(28, 26);
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
            ExitButton.Location = new Point(254, 26);
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
            NameTextBox.Size = new Size(206, 27);
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
            ClearButton.Location = new Point(141, 26);
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
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(73, 61);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(206, 27);
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
            PhoneTextBox.Size = new Size(206, 27);
            PhoneTextBox.TabIndex = 4;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(17, 97);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(34, 20);
            CityLabel.TabIndex = 8;
            CityLabel.Text = "City";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(73, 94);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(206, 27);
            CityTextBox.TabIndex = 3;
            // 
            // ButtonGroupBox
            // 
            ButtonGroupBox.Controls.Add(ExitButton);
            ButtonGroupBox.Controls.Add(SubmitButton);
            ButtonGroupBox.Controls.Add(ClearButton);
            ButtonGroupBox.Location = new Point(397, 327);
            ButtonGroupBox.Name = "ButtonGroupBox";
            ButtonGroupBox.Size = new Size(391, 88);
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
            UserInfoGroupBox.Location = new Point(12, 37);
            UserInfoGroupBox.Name = "UserInfoGroupBox";
            UserInfoGroupBox.Size = new Size(287, 172);
            UserInfoGroupBox.TabIndex = 0;
            UserInfoGroupBox.TabStop = false;
            UserInfoGroupBox.Text = "User Info";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(10, 152);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(101, 24);
            checkBox3.TabIndex = 12;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(10, 119);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(101, 24);
            checkBox4.TabIndex = 1;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // UpperCaseRadioButton
            // 
            UpperCaseRadioButton.AutoSize = true;
            UpperCaseRadioButton.Location = new Point(10, 24);
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
            LowerCaseRadioButton.Location = new Point(10, 54);
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
            ReverseCaseRadioButton.Location = new Point(10, 84);
            ReverseCaseRadioButton.Name = "ReverseCaseRadioButton";
            ReverseCaseRadioButton.Size = new Size(81, 24);
            ReverseCaseRadioButton.TabIndex = 23;
            ReverseCaseRadioButton.TabStop = true;
            ReverseCaseRadioButton.Text = "Reverse";
            ReverseCaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileTopMenuStrip, HelpStripMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            // 
            // FileTopMenuStrip
            // 
            FileTopMenuStrip.DropDownItems.AddRange(new ToolStripItem[] { OpenTopMenuItem, SubmitTopMenuItem, ClearTopMenuItem, ExitTopMenuItem });
            FileTopMenuStrip.Name = "FileTopMenuStrip";
            FileTopMenuStrip.Size = new Size(46, 24);
            FileTopMenuStrip.Text = "File";
            // 
            // OpenTopMenuItem
            // 
            OpenTopMenuItem.Name = "OpenTopMenuItem";
            OpenTopMenuItem.Size = new Size(139, 26);
            OpenTopMenuItem.Text = "Open";
            OpenTopMenuItem.Click += OpenTopMenuItem_Click;
            // 
            // SubmitTopMenuItem
            // 
            SubmitTopMenuItem.Name = "SubmitTopMenuItem";
            SubmitTopMenuItem.Size = new Size(139, 26);
            SubmitTopMenuItem.Text = "Submit";
            SubmitTopMenuItem.Click += SubmitButton_Click;
            // 
            // ClearTopMenuItem
            // 
            ClearTopMenuItem.Name = "ClearTopMenuItem";
            ClearTopMenuItem.Size = new Size(139, 26);
            ClearTopMenuItem.Text = "Clear";
            ClearTopMenuItem.Click += ClearButton_Click;
            // 
            // ExitTopMenuItem
            // 
            ExitTopMenuItem.Name = "ExitTopMenuItem";
            ExitTopMenuItem.Size = new Size(139, 26);
            ExitTopMenuItem.Text = "Exit";
            ExitTopMenuItem.Click += ExitButton_Click;
            // 
            // HelpStripMenu
            // 
            HelpStripMenu.DropDownItems.AddRange(new ToolStripItem[] { AboutStripMenu });
            HelpStripMenu.Name = "HelpStripMenu";
            HelpStripMenu.Size = new Size(55, 24);
            HelpStripMenu.Text = "Help";
            // 
            // AboutStripMenu
            // 
            AboutStripMenu.Name = "AboutStripMenu";
            AboutStripMenu.Size = new Size(133, 26);
            AboutStripMenu.Text = "About";
            // 
            // FormatOptionGroupBox
            // 
            FormatOptionGroupBox.Controls.Add(LowerCaseRadioButton);
            FormatOptionGroupBox.Controls.Add(ReverseCaseRadioButton);
            FormatOptionGroupBox.Controls.Add(UpperCaseRadioButton);
            FormatOptionGroupBox.Controls.Add(checkBox3);
            FormatOptionGroupBox.Controls.Add(checkBox4);
            FormatOptionGroupBox.Location = new Point(12, 215);
            FormatOptionGroupBox.Name = "FormatOptionGroupBox";
            FormatOptionGroupBox.Size = new Size(167, 200);
            FormatOptionGroupBox.TabIndex = 27;
            FormatOptionGroupBox.TabStop = false;
            FormatOptionGroupBox.Text = "Format Options";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { UpperContextMenuItem, LowerContextMenuItem, ReverseContextMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(165, 76);
            // 
            // UpperContextMenuItem
            // 
            UpperContextMenuItem.Name = "UpperContextMenuItem";
            UpperContextMenuItem.Size = new Size(164, 24);
            UpperContextMenuItem.Text = "Upper Case";
            UpperContextMenuItem.Click += UpperContextMenuItem_Click;
            // 
            // LowerContextMenuItem
            // 
            LowerContextMenuItem.Name = "LowerContextMenuItem";
            LowerContextMenuItem.Size = new Size(164, 24);
            LowerContextMenuItem.Text = "Lower Case";
            LowerContextMenuItem.Click += LowerContextMenuItem_Click;
            // 
            // ReverseContextMenuItem
            // 
            ReverseContextMenuItem.Name = "ReverseContextMenuItem";
            ReverseContextMenuItem.Size = new Size(164, 24);
            ReverseContextMenuItem.Text = "Reverse Case";
            ReverseContextMenuItem.Click += ReverseContextMenuItem_Click;
            // 
            // MainOpenFileDialog
            // 
            MainOpenFileDialog.FileName = "openFileDialog1";
            // 
            // DisplayListBox
            // 
            DisplayListBox.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DisplayListBox.FormattingEnabled = true;
            DisplayListBox.Location = new Point(397, 83);
            DisplayListBox.Name = "DisplayListBox";
            DisplayListBox.Size = new Size(391, 238);
            DisplayListBox.TabIndex = 28;
            // 
            // FilterComboBox
            // 
            FilterComboBox.FormattingEnabled = true;
            FilterComboBox.Location = new Point(397, 49);
            FilterComboBox.Name = "FilterComboBox";
            FilterComboBox.Size = new Size(206, 28);
            FilterComboBox.TabIndex = 29;
            // 
            // FilterGroupBox
            // 
            FilterGroupBox.Controls.Add(FirstNameRadioButton);
            FilterGroupBox.Controls.Add(LastNameRadioButton);
            FilterGroupBox.Controls.Add(CityRadioButton);
            FilterGroupBox.Location = new Point(185, 215);
            FilterGroupBox.Name = "FilterGroupBox";
            FilterGroupBox.Size = new Size(199, 200);
            FilterGroupBox.TabIndex = 25;
            FilterGroupBox.TabStop = false;
            FilterGroupBox.Text = "Filter Options";
            // 
            // FirstNameRadioButton
            // 
            FirstNameRadioButton.AutoSize = true;
            FirstNameRadioButton.Location = new Point(6, 84);
            FirstNameRadioButton.Name = "FirstNameRadioButton";
            FirstNameRadioButton.Size = new Size(101, 24);
            FirstNameRadioButton.TabIndex = 2;
            FirstNameRadioButton.TabStop = true;
            FirstNameRadioButton.Text = "First Name";
            FirstNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // LastNameRadioButton
            // 
            LastNameRadioButton.AutoSize = true;
            LastNameRadioButton.Location = new Point(6, 54);
            LastNameRadioButton.Name = "LastNameRadioButton";
            LastNameRadioButton.Size = new Size(100, 24);
            LastNameRadioButton.TabIndex = 1;
            LastNameRadioButton.TabStop = true;
            LastNameRadioButton.Text = "Last Name";
            LastNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // CityRadioButton
            // 
            CityRadioButton.AutoSize = true;
            CityRadioButton.Location = new Point(6, 26);
            CityRadioButton.Name = "CityRadioButton";
            CityRadioButton.Size = new Size(55, 24);
            CityRadioButton.TabIndex = 0;
            CityRadioButton.TabStop = true;
            CityRadioButton.Text = "City";
            CityRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(609, 49);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(179, 27);
            SearchTextBox.TabIndex = 30;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(305, 45);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(89, 35);
            SearchButton.TabIndex = 31;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // WinformExampleForm
            // 
            AcceptButton = SubmitButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ClearButton;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(FilterGroupBox);
            Controls.Add(FilterComboBox);
            Controls.Add(DisplayListBox);
            Controls.Add(FormatOptionGroupBox);
            Controls.Add(UserInfoGroupBox);
            Controls.Add(ButtonGroupBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "WinformExampleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Example Form";
            ToolTip.SetToolTip(this, "These are control boxes");
            ButtonGroupBox.ResumeLayout(false);
            UserInfoGroupBox.ResumeLayout(false);
            UserInfoGroupBox.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            FormatOptionGroupBox.ResumeLayout(false);
            FormatOptionGroupBox.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            FilterGroupBox.ResumeLayout(false);
            FilterGroupBox.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileTopMenuStrip;
        private ToolStripMenuItem HelpStripMenu;
        private ToolStripMenuItem AboutStripMenu;
        private ToolStripMenuItem SubmitTopMenuItem;
        private ToolStripMenuItem ClearTopMenuItem;
        private ToolStripMenuItem ExitTopMenuItem;
        private GroupBox FormatOptionGroupBox;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem UpperContextMenuItem;
        private ToolStripMenuItem LowerContextMenuItem;
        private ToolStripMenuItem ReverseContextMenuItem;
        private OpenFileDialog MainOpenFileDialog;
        private ToolStripMenuItem OpenTopMenuItem;
        private ListBox DisplayListBox;
        private ComboBox FilterComboBox;
        private GroupBox FilterGroupBox;
        private RadioButton FirstNameRadioButton;
        private RadioButton LastNameRadioButton;
        private RadioButton CityRadioButton;
        private TextBox SearchTextBox;
        private Button SearchButton;
    }
}
