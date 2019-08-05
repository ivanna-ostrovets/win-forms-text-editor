using System;
using System.Drawing;
using System.Windows.Forms;
using Font = System.Drawing.Font;

namespace TextEditor
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        private void MakeBold(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void MakeItalic(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void MakeUnderline(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void MakeStrikeout(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style ^ FontStyle.Strikeout);
        }

        private void CleanFormat(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Regular);
            richTextBox.SelectionColor = Color.Black;
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 8.25f, FontStyle.Regular);
        } 
          
        private void ChangeTextColor(object sender, EventArgs e) 
        { 
            if (colorDialog1.ShowDialog() == DialogResult.OK && colorDialog1.Color != richTextBox.SelectionColor)
            {
                richTextBox.SelectionColor = colorDialog1.Color;
            } 
        }   
         
        private void ChangeFont(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = richTextBox.SelectionFont;
            fontDialog1.Color = richTextBox.SelectionColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox.SelectionFont = fontDialog1.Font;
                richTextBox.SelectionColor = fontDialog1.Color;
            }
        }

        private void AlignCenter(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }
         
        private void AlignLeft(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }
         
        private void AlignRight(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        } 

        private void SaveFile(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "RTF files (*.rtf)|*.rtf";
             
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                richTextBox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "*.rtf";
            openFileDialog1.Filter = "RTF Files|*.rtf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox.LoadFile(openFileDialog1.FileName);
            }
        }

        private void CopyText(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox.SelectedText, TextDataFormat.Rtf);
        }

        private void PasteText(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }
    }
}
