using System.Windows.Forms;

namespace TextEditor
{
    partial class TextEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bold = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.italic = new System.Windows.Forms.Button();
            this.underline = new System.Windows.Forms.Button();
            this.strikeout = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.textColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.font = new System.Windows.Forms.Button();
            this.rightAlign = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFile = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.copy = new System.Windows.Forms.Button();
            this.paste = new System.Windows.Forms.Button();
            this.leftAlign = new System.Windows.Forms.Button();
            this.centerAlign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bold
            // 
            this.bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bold.Location = new System.Drawing.Point(30, 41);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(26, 23);
            this.bold.TabIndex = 1;
            this.bold.Text = "B";
            this.bold.UseVisualStyleBackColor = true;
            this.bold.Click += new System.EventHandler(this.MakeBold);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(30, 82);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox.Size = new System.Drawing.Size(344, 319);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // italic
            // 
            this.italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italic.Location = new System.Drawing.Point(62, 41);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(26, 23);
            this.italic.TabIndex = 3;
            this.italic.Text = "I";
            this.italic.UseVisualStyleBackColor = true;
            this.italic.Click += new System.EventHandler(this.MakeItalic);
            // 
            // underline
            // 
            this.underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underline.Location = new System.Drawing.Point(94, 41);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(26, 23);
            this.underline.TabIndex = 4;
            this.underline.Text = "U";
            this.underline.UseVisualStyleBackColor = true;
            this.underline.Click += new System.EventHandler(this.MakeUnderline);
            // 
            // strikeout
            // 
            this.strikeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strikeout.Location = new System.Drawing.Point(126, 41);
            this.strikeout.Name = "strikeout";
            this.strikeout.Size = new System.Drawing.Size(26, 23);
            this.strikeout.TabIndex = 5;
            this.strikeout.Text = "S";
            this.strikeout.UseVisualStyleBackColor = true;
            this.strikeout.Click += new System.EventHandler(this.MakeStrikeout);
            // 
            // clean
            // 
            this.clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clean.Location = new System.Drawing.Point(332, 41);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(42, 23);
            this.clean.TabIndex = 6;
            this.clean.Text = "Clean";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.CleanFormat);
            // 
            // textColor
            // 
            this.textColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textColor.Location = new System.Drawing.Point(158, 41);
            this.textColor.Name = "textColor";
            this.textColor.Size = new System.Drawing.Size(26, 23);
            this.textColor.TabIndex = 8;
            this.textColor.Text = "A";
            this.textColor.UseVisualStyleBackColor = true;
            this.textColor.Click += new System.EventHandler(this.ChangeTextColor);
            // 
            // font
            // 
            this.font.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.font.Location = new System.Drawing.Point(190, 41);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(40, 23);
            this.font.TabIndex = 9;
            this.font.Text = "Size";
            this.font.UseVisualStyleBackColor = true;
            this.font.Click += new System.EventHandler(this.ChangeFont);
            // 
            // rightAlign
            // 
            this.rightAlign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightAlign.Image = global::Lab2.Properties.Resources.right_alignment;
            this.rightAlign.Location = new System.Drawing.Point(300, 41);
            this.rightAlign.Name = "rightAlign";
            this.rightAlign.Size = new System.Drawing.Size(26, 23);
            this.rightAlign.TabIndex = 12;
            this.rightAlign.UseVisualStyleBackColor = true;
            this.rightAlign.Click += new System.EventHandler(this.AlignRight);
            // 
            // saveFile
            // 
            this.saveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFile.Location = new System.Drawing.Point(94, 12);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(58, 23);
            this.saveFile.TabIndex = 13;
            this.saveFile.Text = "Save file";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.SaveFile);
            // 
            // openFile
            // 
            this.openFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFile.Location = new System.Drawing.Point(30, 12);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(58, 23);
            this.openFile.TabIndex = 14;
            this.openFile.Text = "Open file";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.OpenFile);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // copy
            // 
            this.copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy.Location = new System.Drawing.Point(158, 12);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(58, 23);
            this.copy.TabIndex = 15;
            this.copy.Text = "Copy";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.CopyText);
            // 
            // paste
            // 
            this.paste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paste.Location = new System.Drawing.Point(222, 12);
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(58, 23);
            this.paste.TabIndex = 16;
            this.paste.Text = "Paste";
            this.paste.UseVisualStyleBackColor = true;
            this.paste.Click += new System.EventHandler(this.PasteText);
            // 
            // leftAlign
            // 
            this.leftAlign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftAlign.Image = global::Lab2.Properties.Resources.left_alignment;
            this.leftAlign.Location = new System.Drawing.Point(236, 41);
            this.leftAlign.Name = "leftAlign";
            this.leftAlign.Size = new System.Drawing.Size(26, 23);
            this.leftAlign.TabIndex = 11;
            this.leftAlign.UseVisualStyleBackColor = true;
            this.leftAlign.Click += new System.EventHandler(this.AlignLeft);
            // 
            // centerAlign
            // 
            this.centerAlign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerAlign.Image = global::Lab2.Properties.Resources.center_alignment;
            this.centerAlign.Location = new System.Drawing.Point(268, 41);
            this.centerAlign.Name = "centerAlign";
            this.centerAlign.Size = new System.Drawing.Size(26, 23);
            this.centerAlign.TabIndex = 10;
            this.centerAlign.UseVisualStyleBackColor = true;
            this.centerAlign.Click += new System.EventHandler(this.AlignCenter);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 429);
            this.Controls.Add(this.paste);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.rightAlign);
            this.Controls.Add(this.leftAlign);
            this.Controls.Add(this.centerAlign);
            this.Controls.Add(this.font);
            this.Controls.Add(this.textColor);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.strikeout);
            this.Controls.Add(this.underline);
            this.Controls.Add(this.italic);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.bold);
            this.Name = "TextEditor";
            this.Text = "Text Editor";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bold;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button italic;
        private System.Windows.Forms.Button underline;
        private System.Windows.Forms.Button strikeout;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button textColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button font;
        private System.Windows.Forms.Button centerAlign;
        private System.Windows.Forms.Button leftAlign;
        private System.Windows.Forms.Button rightAlign;
        private SaveFileDialog saveFileDialog1;
        private Button saveFile;
        private Button openFile;
        private OpenFileDialog openFileDialog1;
        private Button copy;
        private Button paste;
    }
}

