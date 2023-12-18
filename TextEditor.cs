using Microsoft.Win32;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class TextEditor : Form
    {
        const string DEFAULT_FONT_FAMILY = "Verdana";
        const float MIN_FONT_SIZE = 9.75F;
        const float MAX_FONT_SIZE = 16;
        const int DEFAULT_WINDOW_HEIGHT = 488;
        const int DEFAULT_WINDOW_WIDTH = 715;

        readonly Font originalRTBFont;
        const string subKeyName = "TextEditorConfig";

        public TextEditor()
        {
            InitializeComponent();

            originalRTBFont = EditorRichTextBox.Font;

            FontSizeNumericUpDown.DecimalPlaces = 2;
            FontSizeNumericUpDown.Increment = 0.1M;
            FontSizeNumericUpDown.Minimum = (decimal)MIN_FONT_SIZE;
            FontSizeNumericUpDown.Maximum = (decimal)MAX_FONT_SIZE;

            FontFamilyComboBox.Items.AddRange(FontFamily.Families);
            FontFamilyComboBox.DisplayMember = "Name";

            ColorsComboBox.Items.AddRange(new string[]{ "Red", "Blue", "Black", "Yellow", "Green" });
        }

        private void FontChanger(RichTextBox textBox, FontStyle style, Font originalFont)
        {
            if (textBox.SelectionLength == 0)
            {
                textBox.SelectAll();
            }

            if ((textBox.SelectionFont.Style & style) == style)
            {
                FontStyle currentStyle = textBox.SelectionFont.Style;

                currentStyle -= style;
                textBox.SelectionFont = new Font(textBox.SelectionFont, currentStyle);

                return;
            }

            textBox.SelectionFont = new Font(textBox.SelectionFont, textBox.SelectionFont.Style | style);
            textBox.Select(textBox.Text.Length, 0);
            textBox.SelectionFont = originalFont;
        }

        private void ItalicButton_Click(object sender, EventArgs e)
        {
            if(!EditorRichTextBox.SelectionFont.Italic)
            {
                FontChanger(EditorRichTextBox, FontStyle.Italic, originalRTBFont);
            }
        }

        private void BoldButton_Click(object sender, EventArgs e)
        {
            if (!EditorRichTextBox.SelectionFont.Bold)
            {
                FontChanger(EditorRichTextBox, FontStyle.Bold, originalRTBFont);
            }
        }

        private void UnderlineButton_Click(object sender, EventArgs e)
        {
            if (!EditorRichTextBox.SelectionFont.Underline)
            {
                FontChanger(EditorRichTextBox, FontStyle.Underline, originalRTBFont);
            }
        }

        private void CrossedButton_Click(object sender, EventArgs e)
        {
            if (!EditorRichTextBox.SelectionFont.Strikeout)
            {
                FontChanger(EditorRichTextBox, FontStyle.Strikeout, originalRTBFont);
            }
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {
            float fontSize = MIN_FONT_SIZE;
            string fontFamily = DEFAULT_FONT_FAMILY;
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(subKeyName);

            foreach (string key in registryKey.GetValueNames())
            {
                var registrySubKeyValue = registryKey.GetValue(key);

                if (registrySubKeyValue is Array)
                {
                    foreach (string parametr in registrySubKeyValue as string[])
                    {
                        string[] strings = parametr.Split(':');

                        switch(strings[0].Trim())
                        {
                            case "width":
                                this.Width = Int32.Parse(strings[1].Trim());
                                break;

                            case "height":
                                this.Height = Int32.Parse(strings[1].Trim());
                                break;

                            default:
                                MessageBox.Show("One of sizing parameters was corrupted =(", "Sizing Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                this.Width = DEFAULT_WINDOW_WIDTH;
                                this.Height = DEFAULT_WINDOW_HEIGHT;
                                break;
                        }
                    }

                    continue;
                }

                string value = registrySubKeyValue as String;

                switch (key)
                {
                    case "Font Color":
                        this.ForeColor = Color.FromName(value);
                        continue;

                    case "Font Family":
                        if(FontFamily.Families.Any((x) => x.Name == value))
                        {
                            fontFamily = value;
                        }
                        continue;

                    case "Font Size":
                        fontSize = float.Parse(value);

                        if(fontSize < MIN_FONT_SIZE || fontSize > MAX_FONT_SIZE)
                        {
                            fontSize = MIN_FONT_SIZE;
                        }
                        break;
                }
            }

            this.Font = new Font(fontFamily, fontSize);

            FontSizeNumericUpDown.Value = (decimal)this.Font.Size;
            FontFamilyComboBox.SelectedItem = this.Font.FontFamily;
        }

        private void TextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            string currentUser = Registry.CurrentUser.Name;
            string appKeyPath = $"{currentUser}\\{subKeyName}";

            Registry.SetValue(appKeyPath, "Window Size", new[] { $"width: {this.Width}", $"height: {this.Height}" });
            Registry.SetValue(appKeyPath, "Font Size", this.Font.Size.ToString(), RegistryValueKind.String);
            Registry.SetValue(appKeyPath, "Font Family", this.Font.FontFamily.Name, RegistryValueKind.String);
            Registry.SetValue(appKeyPath, "Font Color", this.ForeColor.Name, RegistryValueKind.String);
        }

        private void FontSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.Font = new Font(this.Font.FontFamily, (float)FontSizeNumericUpDown.Value);
        }

        private void FontFamilyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Font = new Font((FontFamilyComboBox.SelectedItem as FontFamily).Name, this.Font.Size);
        }

        private void ColorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.FromName(ColorsComboBox.SelectedItem.ToString());
        }
    }
}
