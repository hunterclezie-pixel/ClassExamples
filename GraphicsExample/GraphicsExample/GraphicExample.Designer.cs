namespace GraphicsExample
{
    partial class GraphicExample
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
            DisplayPictureBox = new PictureBox();
            DrawButton = new Button();
            ExitButton = new Button();
            ClearButton = new Button();
            PenColorDialog = new ColorDialog();
            MenuStrip = new MenuStrip();
            FileTopMenuItem = new ToolStripMenuItem();
            DrawTopMenuItem = new ToolStripMenuItem();
            ClearTopMenuItem = new ToolStripMenuItem();
            ExitTopMenuItem = new ToolStripMenuItem();
            HelpTopMenuItem = new ToolStripMenuItem();
            AboutTopMenuItem = new ToolStripMenuItem();
            DisplayContextMenuStrip = new ContextMenuStrip(components);
            DrawContextMenuItem = new ToolStripMenuItem();
            ClearContextMenuItem = new ToolStripMenuItem();
            ColorContextMenuItem = new ToolStripMenuItem();
            PenContextMenuItem = new ToolStripMenuItem();
            BackgroundColorContextMenuItem = new ToolStripMenuItem();
            PenSizeContextMenuItem = new ToolStripMenuItem();
            PenSizeComboBox = new ToolStripComboBox();
            BottomStatusStrip = new StatusStrip();
            DrawingStatusLabel = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            MenuStrip.SuspendLayout();
            DisplayContextMenuStrip.SuspendLayout();
            BottomStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisplayPictureBox.BackColor = SystemColors.ActiveCaption;
            DisplayPictureBox.Location = new Point(14, 36);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(1055, 384);
            DisplayPictureBox.TabIndex = 0;
            DisplayPictureBox.TabStop = false;
            // 
            // DrawButton
            // 
            DrawButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DrawButton.Location = new Point(663, 431);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(130, 61);
            DrawButton.TabIndex = 1;
            DrawButton.Text = "Draw";
            DrawButton.UseVisualStyleBackColor = true;
            DrawButton.Click += DrawButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitButton.Location = new Point(938, 431);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(130, 61);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearButton.Location = new Point(800, 431);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(130, 61);
            ClearButton.TabIndex = 3;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // MenuStrip
            // 
            MenuStrip.ImageScalingSize = new Size(20, 20);
            MenuStrip.Items.AddRange(new ToolStripItem[] { FileTopMenuItem, HelpTopMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Padding = new Padding(7, 2, 0, 2);
            MenuStrip.Size = new Size(1082, 31);
            MenuStrip.TabIndex = 4;
            MenuStrip.Text = "menuStrip1";
            // 
            // FileTopMenuItem
            // 
            FileTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DrawTopMenuItem, ClearTopMenuItem, ExitTopMenuItem });
            FileTopMenuItem.Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FileTopMenuItem.Name = "FileTopMenuItem";
            FileTopMenuItem.Size = new Size(60, 27);
            FileTopMenuItem.Text = "File";
            // 
            // DrawTopMenuItem
            // 
            DrawTopMenuItem.Name = "DrawTopMenuItem";
            DrawTopMenuItem.Size = new Size(224, 28);
            DrawTopMenuItem.Text = "Draw";
            // 
            // ClearTopMenuItem
            // 
            ClearTopMenuItem.Name = "ClearTopMenuItem";
            ClearTopMenuItem.Size = new Size(224, 28);
            ClearTopMenuItem.Text = "Clear";
            // 
            // ExitTopMenuItem
            // 
            ExitTopMenuItem.Name = "ExitTopMenuItem";
            ExitTopMenuItem.Size = new Size(224, 28);
            ExitTopMenuItem.Text = "Exit";
            // 
            // HelpTopMenuItem
            // 
            HelpTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutTopMenuItem });
            HelpTopMenuItem.Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HelpTopMenuItem.Name = "HelpTopMenuItem";
            HelpTopMenuItem.Size = new Size(60, 27);
            HelpTopMenuItem.Text = "Help";
            // 
            // AboutTopMenuItem
            // 
            AboutTopMenuItem.Name = "AboutTopMenuItem";
            AboutTopMenuItem.Size = new Size(224, 28);
            AboutTopMenuItem.Text = "About";
            // 
            // DisplayContextMenuStrip
            // 
            DisplayContextMenuStrip.ImageScalingSize = new Size(20, 20);
            DisplayContextMenuStrip.Items.AddRange(new ToolStripItem[] { DrawContextMenuItem, ClearContextMenuItem, ColorContextMenuItem, PenSizeContextMenuItem });
            DisplayContextMenuStrip.Name = "DisplayContextMenuStrip";
            DisplayContextMenuStrip.Size = new Size(133, 100);
            // 
            // DrawContextMenuItem
            // 
            DrawContextMenuItem.Name = "DrawContextMenuItem";
            DrawContextMenuItem.Size = new Size(132, 24);
            DrawContextMenuItem.Text = "Draw";
            // 
            // ClearContextMenuItem
            // 
            ClearContextMenuItem.Name = "ClearContextMenuItem";
            ClearContextMenuItem.Size = new Size(132, 24);
            ClearContextMenuItem.Text = "Clear";
            // 
            // ColorContextMenuItem
            // 
            ColorContextMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PenContextMenuItem, BackgroundColorContextMenuItem });
            ColorContextMenuItem.Name = "ColorContextMenuItem";
            ColorContextMenuItem.Size = new Size(132, 24);
            ColorContextMenuItem.Text = "Color";
            // 
            // PenContextMenuItem
            // 
            PenContextMenuItem.Name = "PenContextMenuItem";
            PenContextMenuItem.Size = new Size(211, 26);
            PenContextMenuItem.Text = "Pen";
            // 
            // BackgroundColorContextMenuItem
            // 
            BackgroundColorContextMenuItem.Name = "BackgroundColorContextMenuItem";
            BackgroundColorContextMenuItem.Size = new Size(211, 26);
            BackgroundColorContextMenuItem.Text = "Background Color";
            // 
            // PenSizeContextMenuItem
            // 
            PenSizeContextMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PenSizeComboBox });
            PenSizeContextMenuItem.Name = "PenSizeContextMenuItem";
            PenSizeContextMenuItem.Size = new Size(132, 24);
            PenSizeContextMenuItem.Text = "Pen Size";
            // 
            // PenSizeComboBox
            // 
            PenSizeComboBox.Name = "PenSizeComboBox";
            PenSizeComboBox.Size = new Size(121, 28);
            // 
            // BottomStatusStrip
            // 
            BottomStatusStrip.ImageScalingSize = new Size(20, 20);
            BottomStatusStrip.Items.AddRange(new ToolStripItem[] { DrawingStatusLabel });
            BottomStatusStrip.Location = new Point(0, 492);
            BottomStatusStrip.Name = "BottomStatusStrip";
            BottomStatusStrip.Padding = new Padding(1, 0, 16, 0);
            BottomStatusStrip.Size = new Size(1082, 29);
            BottomStatusStrip.TabIndex = 5;
            BottomStatusStrip.Text = "statusStrip1";
            // 
            // DrawingStatusLabel
            // 
            DrawingStatusLabel.Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DrawingStatusLabel.Name = "DrawingStatusLabel";
            DrawingStatusLabel.Size = new Size(136, 23);
            DrawingStatusLabel.Text = "Please Wait...";
            // 
            // GraphicExample
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 521);
            Controls.Add(BottomStatusStrip);
            Controls.Add(ClearButton);
            Controls.Add(ExitButton);
            Controls.Add(DrawButton);
            Controls.Add(DisplayPictureBox);
            Controls.Add(MenuStrip);
            Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = MenuStrip;
            MinimumSize = new Size(560, 568);
            Name = "GraphicExample";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            DisplayContextMenuStrip.ResumeLayout(false);
            BottomStatusStrip.ResumeLayout(false);
            BottomStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox DisplayPictureBox;
        private Button DrawButton;
        private Button ExitButton;
        private Button ClearButton;
        private ColorDialog PenColorDialog;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem FileTopMenuItem;
        private ToolStripMenuItem DrawTopMenuItem;
        private ToolStripMenuItem ClearTopMenuItem;
        private ToolStripMenuItem ExitTopMenuItem;
        private ToolStripMenuItem HelpTopMenuItem;
        private ToolStripMenuItem AboutTopMenuItem;
        private ContextMenuStrip DisplayContextMenuStrip;
        private ToolStripMenuItem DrawContextMenuItem;
        private ToolStripMenuItem ClearContextMenuItem;
        private ToolStripMenuItem ColorContextMenuItem;
        private ToolStripMenuItem PenContextMenuItem;
        private ToolStripMenuItem BackgroundColorContextMenuItem;
        private ToolStripMenuItem PenSizeContextMenuItem;
        private ToolStripComboBox PenSizeComboBox;
        private StatusStrip BottomStatusStrip;
        private ToolStripStatusLabel DrawingStatusLabel;
    }
}
