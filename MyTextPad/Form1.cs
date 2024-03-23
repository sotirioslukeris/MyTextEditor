using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;

namespace MyTextPad
{
    public partial class Form1 : Form
    {
        string fileName = "Unsaved file";


        public Form1()
        {
            InitializeComponent();
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            if (rtb.Modified || fileName == "Unsaved file")
            {
                DialogResult res = MessageBox.Show("Do you want to save?", "MyTextPad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    menuSave_Click(sender, e);
                }
                else if (res == DialogResult.Cancel)
                {
                    saveDLG.FileName = "Unsaved file";
                    return;
                }





            }
            rtb.Clear();
            fileName = "Unsaved file";
            this.Text = $"My Text Pad - {fileName}";
            rtb.Modified = false;
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            openDLG.Title = "Open";
            openDLG.Filter = "All files(.)|*.*|RTF files(.rtf)|*.rtf|Text files(.txt)|*.txt|Word files(.doc;.docx)|*.doc;*.docx";
            openDLG.FilterIndex = 2;
            openDLG.Multiselect = false;


            if (rtb.Modified || fileName == "Unsaved file")
            {
                DialogResult res = MessageBox.Show("Do you want to save?", "MyTextPad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    menuSave_Click(sender, e);
                }
                else if (res == DialogResult.Cancel)
                {
                    openDLG.FileName = "Unsaved file";
                    return;
                }


            }

            if (openDLG.ShowDialog() == DialogResult.OK)
            {
                rtb.LoadFile(openDLG.FileName, RichTextBoxStreamType.RichText);
            }

            else
            {
                openDLG.FileName = "Unsaved file";
                return;
            }
            fileName = openDLG.FileName;
            this.Text = $"My Text Pad - {openDLG.FileName}";
            rtb.Modified = false;






        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (fileName == "Unsaved file")
            {
                menuSaveAs_Click(sender, e);
            }

            else
            {
                rtb.SaveFile(fileName, RichTextBoxStreamType.RichText);
            }

            fileName = saveDLG.FileName;
            this.Text = $"My Text Pad - {fileName}";
            rtb.Modified = false;

        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            saveDLG.Title = "Save";
            saveDLG.Filter = "All files(.)|*.*|RTF files(.rtf)|*.rtf|Text files(.txt)|*.txt|Word files(.doc;.docx)|*.doc;*.docx";
            saveDLG.FilterIndex = 2;

            if (saveDLG.ShowDialog() == DialogResult.OK)
            {
                rtb.SaveFile(saveDLG.FileName, RichTextBoxStreamType.RichText);
            }
            else
            {
                saveDLG.FileName = "Unsaved file";
                return;
            }


            fileName = saveDLG.FileName;
            this.Text = $"My Text Pad - {saveDLG.FileName}";

        }

        private void menuUndo_Click(object sender, EventArgs e)
        {
            rtb.Undo();
        }

        private void menuRedo_Click(object sender, EventArgs e)
        {
            rtb.Redo();
        }

        private void menuCut_Click(object sender, EventArgs e)
        {
            rtb.Cut();
        }

        private void menuCopy_Click(object sender, EventArgs e)
        {
            rtb.Copy();
        }

        private void menuPaste_Click(object sender, EventArgs e)
        {
            rtb.Paste();
        }

        private void menuSelectAll_Click(object sender, EventArgs e)
        {
            rtb.SelectAll();
        }

        private void menuWordWrap_Click(object sender, EventArgs e)
        {



            if (!menuWordWrap.Checked)
            {
                menuWordWrap.Checked = true;
                rtb.WordWrap = true;
            }
            else
            {
                menuWordWrap.Checked = false;
                rtb.WordWrap = false;

            }


        }

        private void menuFont_Click(object sender, EventArgs e)
        {
            fontDLG.ShowColor = true;
            fontDLG.ShowApply = true;

            if (fontDLG.ShowDialog() == DialogResult.OK)
            {
                rtb.SelectionFont = fontDLG.Font;
                rtb.SelectionColor = fontDLG.Color;

            }

            if (rtb.SelectedText == "")
            {
                rtb.Font = fontDLG.Font;
            }






        }
        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rtb.Modified || fileName == "Unsaved file")
            {
                DialogResult res = MessageBox.Show("Do you want to save?", "MyTextPad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    menuSave_Click(sender, e);
                }
                else if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }


            }
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDLG.ShowDialog() == DialogResult.OK)
            {
                rtb.BackColor = colorDLG.Color;
            }
        }

        private void viewStatusStrip_Click(object sender, EventArgs e)
        {
            if (viewStatusStrip.Checked)
            {
                statusStrip.Visible = true; //statusStrip.Show();
            }
            else
            {
                statusStrip.Visible = false; //statusStrip.Hide();
            }

            
        }
    }
}
