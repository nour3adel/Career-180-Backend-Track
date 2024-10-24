namespace Notepad
{
    public partial class MyNotepad : Form
    {
        private string path = null;
        public MyNotepad()
        {
            InitializeComponent();
        }

        #region Save Button



        private void Save_Click(object sender, EventArgs e)
        {
            if (path == null)
            {
                if (saveFD.ShowDialog() == DialogResult.OK)
                {
                    Canvas.SaveFile(saveFD.FileName);
                }
            }
            else
            {
                Canvas.SaveFile(path);
                Canvas.Clear();
                path = null;
            }
        }
        #endregion

        #region Open File Button

        private void open_button_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                Canvas.LoadFile(openFD.FileName);
                path = openFD.FileName;
            }
        }

        #endregion

        #region Clear Button
        private void Clear_Click(object sender, EventArgs e)
        {
            Canvas.Clear();
        }
        #endregion

        #region Change Font Button
        private void change_font_button_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                if (Canvas.SelectedText != "")
                {
                    Canvas.SelectionFont = fontDialog.Font;
                }
                else
                {
                    Canvas.Font = fontDialog.Font;
                }
            }
        }
        #endregion

        #region Change Color Button
        private void change_color_button_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (Canvas.SelectedText != "")
                {
                    Canvas.SelectionColor = colorDialog.Color;
                }
                else
                {
                    Canvas.ForeColor = colorDialog.Color;
                }
            }
        }
        #endregion

        #region Change Background Color Button
        private void background_color_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (Canvas.SelectedText != "")
                {
                    Canvas.SelectionBackColor = colorDialog.Color;
                }
                else
                {
                    Canvas.BackColor = colorDialog.Color;
                }
            }
        }

        #endregion

        #region ( New ) File Box  
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Canvas.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save changes?", "Notepad", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    Save_Click(sender, e);
                }
                else
                {
                    Canvas.Clear();
                }
            }
        }
        #endregion

        #region ( Open ) File Box  

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_button_Click(sender, e);
        }
        #endregion

        #region ( Save ) File Box  

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save_Click(sender, e);
        }
        #endregion

        #region ( Save As ) File Box  

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                Canvas.SaveFile(saveFD.FileName);
                Canvas.Clear();
                path = null;
            }
        }
        #endregion

        #region ( Close ) File Box  

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Canvas.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save changes?", "Notepad", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    Save_Click(sender, e);
                }
                else
                {
                    Canvas.Clear();
                }
            }

            this.Close();
        }

        #endregion

        #region About Box 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("""
                                Career 180 Backend BootCamp 

                                Day 5 Task 
                                By Nour Adel
    
                            """);
        }

        #endregion


    }
}
