using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }

            for (int i = 8; i <= 72; i += 2)
            {
                toolStripComboBox2.Items.Add(i.ToString());
            }

            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "14";
            rtbEditor.Font = new Font("Tahoma", 14);
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "14";
            rtbEditor.Font = new Font("Tahoma", 14);
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Rich Text Format|*.rtf|Text File|*.txt";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(saveDialog.FileName).ToLower() == ".rtf")
                    rtbEditor.SaveFile(saveDialog.FileName);
                else
                    File.WriteAllText(saveDialog.FileName, rtbEditor.Text);
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Rich Text Format|*.rtf|Text File|*.txt";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openDialog.FileName).ToLower() == ".rtf")
                    rtbEditor.LoadFile(openDialog.FileName);
                else
                    rtbEditor.Text = File.ReadAllText(openDialog.FileName);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FontToolStrip_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = rtbEditor.SelectionFont;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.SelectionFont = fontDialog.Font;
            }
        }
        private void Bold_Click(object sender, EventArgs e)
        {
            if (rtbEditor.SelectionFont != null)
            {
                Font current = rtbEditor.SelectionFont;
                FontStyle style = current.Style;

                style = current.Bold ? (style & ~FontStyle.Bold) : (style | FontStyle.Bold);
                rtbEditor.SelectionFont = new Font(current.FontFamily, current.Size, style);
            }
        }
        private void Italic_Click(object sender, EventArgs e)
        {
            if (rtbEditor.SelectionFont != null)
            {
                Font current = rtbEditor.SelectionFont;
                FontStyle style = current.Style;

                style = current.Italic ? (style & ~FontStyle.Italic) : (style | FontStyle.Italic);
                rtbEditor.SelectionFont = new Font(current.FontFamily, current.Size, style);
            }
        }

        private void Underline_Click(object sender, EventArgs e)
        {
            if (rtbEditor.SelectionFont != null)
            {
                Font current = rtbEditor.SelectionFont;
                FontStyle style = current.Style;

                style = current.Underline ? (style & ~FontStyle.Underline) : (style | FontStyle.Underline);
                rtbEditor.SelectionFont = new Font(current.FontFamily, current.Size, style);
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rtbEditor.SelectionFont != null && toolStripComboBox1.SelectedItem != null)
            {
                string fontName = toolStripComboBox1.SelectedItem.ToString();
                float fontSize = rtbEditor.SelectionFont.Size;
                FontStyle style = rtbEditor.SelectionFont.Style;

                rtbEditor.SelectionFont = new Font(fontName, fontSize, style);
            }
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rtbEditor.SelectionFont != null && toolStripComboBox2.SelectedItem != null)
            {
                string fontName = rtbEditor.SelectionFont.Name;
                float fontSize = float.Parse(toolStripComboBox2.SelectedItem.ToString());
                FontStyle style = rtbEditor.SelectionFont.Style;

                rtbEditor.SelectionFont = new Font(fontName, fontSize, style);
            }
        }
    }
}
