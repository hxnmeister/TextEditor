namespace TextEditor
{
    partial class TextEditor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.BoldButton = new System.Windows.Forms.Button();
            this.ItalicButton = new System.Windows.Forms.Button();
            this.UnderlineButton = new System.Windows.Forms.Button();
            this.CrossedButton = new System.Windows.Forms.Button();
            this.TextStyleGroupBox = new System.Windows.Forms.GroupBox();
            this.EditorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FontSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.FontFamilyComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorsComboBox = new System.Windows.Forms.ComboBox();
            this.TextStyleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // BoldButton
            // 
            this.BoldButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BoldButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoldButton.Location = new System.Drawing.Point(254, 22);
            this.BoldButton.Name = "BoldButton";
            this.BoldButton.Size = new System.Drawing.Size(80, 27);
            this.BoldButton.TabIndex = 1;
            this.BoldButton.Text = "Bold";
            this.BoldButton.UseVisualStyleBackColor = true;
            this.BoldButton.Click += new System.EventHandler(this.BoldButton_Click);
            // 
            // ItalicButton
            // 
            this.ItalicButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ItalicButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItalicButton.Location = new System.Drawing.Point(168, 22);
            this.ItalicButton.Name = "ItalicButton";
            this.ItalicButton.Size = new System.Drawing.Size(80, 27);
            this.ItalicButton.TabIndex = 2;
            this.ItalicButton.Text = "Italic";
            this.ItalicButton.UseVisualStyleBackColor = true;
            this.ItalicButton.Click += new System.EventHandler(this.ItalicButton_Click);
            // 
            // UnderlineButton
            // 
            this.UnderlineButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UnderlineButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnderlineButton.Location = new System.Drawing.Point(340, 22);
            this.UnderlineButton.Name = "UnderlineButton";
            this.UnderlineButton.Size = new System.Drawing.Size(80, 27);
            this.UnderlineButton.TabIndex = 3;
            this.UnderlineButton.Text = "Underline";
            this.UnderlineButton.UseVisualStyleBackColor = true;
            this.UnderlineButton.Click += new System.EventHandler(this.UnderlineButton_Click);
            // 
            // CrossedButton
            // 
            this.CrossedButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CrossedButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrossedButton.Location = new System.Drawing.Point(426, 22);
            this.CrossedButton.Name = "CrossedButton";
            this.CrossedButton.Size = new System.Drawing.Size(80, 27);
            this.CrossedButton.TabIndex = 4;
            this.CrossedButton.Text = "Crossed";
            this.CrossedButton.UseVisualStyleBackColor = true;
            this.CrossedButton.Click += new System.EventHandler(this.CrossedButton_Click);
            // 
            // TextStyleGroupBox
            // 
            this.TextStyleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextStyleGroupBox.Controls.Add(this.BoldButton);
            this.TextStyleGroupBox.Controls.Add(this.UnderlineButton);
            this.TextStyleGroupBox.Controls.Add(this.CrossedButton);
            this.TextStyleGroupBox.Controls.Add(this.ItalicButton);
            this.TextStyleGroupBox.Location = new System.Drawing.Point(12, 162);
            this.TextStyleGroupBox.Name = "TextStyleGroupBox";
            this.TextStyleGroupBox.Size = new System.Drawing.Size(675, 56);
            this.TextStyleGroupBox.TabIndex = 5;
            this.TextStyleGroupBox.TabStop = false;
            this.TextStyleGroupBox.Text = "Text Styles";
            // 
            // EditorRichTextBox
            // 
            this.EditorRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditorRichTextBox.Location = new System.Drawing.Point(12, 224);
            this.EditorRichTextBox.Name = "EditorRichTextBox";
            this.EditorRichTextBox.Size = new System.Drawing.Size(675, 347);
            this.EditorRichTextBox.TabIndex = 10;
            this.EditorRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Font Size:";
            // 
            // FontSizeNumericUpDown
            // 
            this.FontSizeNumericUpDown.Location = new System.Drawing.Point(93, 27);
            this.FontSizeNumericUpDown.Name = "FontSizeNumericUpDown";
            this.FontSizeNumericUpDown.Size = new System.Drawing.Size(85, 23);
            this.FontSizeNumericUpDown.TabIndex = 15;
            this.FontSizeNumericUpDown.ValueChanged += new System.EventHandler(this.FontSizeNumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Font Family:";
            // 
            // FontFamilyComboBox
            // 
            this.FontFamilyComboBox.FormattingEnabled = true;
            this.FontFamilyComboBox.Location = new System.Drawing.Point(107, 59);
            this.FontFamilyComboBox.Name = "FontFamilyComboBox";
            this.FontFamilyComboBox.Size = new System.Drawing.Size(325, 24);
            this.FontFamilyComboBox.TabIndex = 17;
            this.FontFamilyComboBox.SelectedIndexChanged += new System.EventHandler(this.FontFamilyComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Font Color:";
            // 
            // ColorsComboBox
            // 
            this.ColorsComboBox.FormattingEnabled = true;
            this.ColorsComboBox.Location = new System.Drawing.Point(107, 100);
            this.ColorsComboBox.Name = "ColorsComboBox";
            this.ColorsComboBox.Size = new System.Drawing.Size(121, 24);
            this.ColorsComboBox.TabIndex = 19;
            this.ColorsComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorsComboBox_SelectedIndexChanged);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 583);
            this.Controls.Add(this.ColorsComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FontFamilyComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FontSizeNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditorRichTextBox);
            this.Controls.Add(this.TextStyleGroupBox);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(715, 488);
            this.Name = "TextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextEditor_FormClosing);
            this.Load += new System.EventHandler(this.TextEditor_Load);
            this.TextStyleGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BoldButton;
        private System.Windows.Forms.Button ItalicButton;
        private System.Windows.Forms.Button UnderlineButton;
        private System.Windows.Forms.Button CrossedButton;
        private System.Windows.Forms.GroupBox TextStyleGroupBox;
        private System.Windows.Forms.RichTextBox EditorRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown FontSizeNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FontFamilyComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ColorsComboBox;
    }
}

