namespace Notepad
{
    partial class MyNotepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyNotepad));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            Canvas = new RichTextBox();
            open_btn = new Button();
            save_btn = new Button();
            clear_btn = new Button();
            font_btn = new Button();
            color_btn = new Button();
            saveFD = new SaveFileDialog();
            openFD = new OpenFileDialog();
            fontDialog = new FontDialog();
            colorDialog = new ColorDialog();
            backColor_btn = new Button();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.ControlText;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1172, 21);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
          
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, newToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fileToolStripMenuItem.ForeColor = Color.Coral;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(38, 17);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(115, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(115, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(115, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(115, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(115, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
            aboutToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aboutToolStripMenuItem.ForeColor = Color.Coral;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(53, 17);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // Canvas
            // 
            Canvas.BackColor = SystemColors.InactiveCaption;
            Canvas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Canvas.HideSelection = false;
            Canvas.Location = new Point(28, 40);
            Canvas.Margin = new Padding(3, 2, 3, 2);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(873, 649);
            Canvas.TabIndex = 1;
            Canvas.Text = "";
          
            // 
            // open_btn
            // 
            open_btn.BackColor = Color.Chartreuse;
            open_btn.Cursor = Cursors.Hand;
            open_btn.FlatStyle = FlatStyle.Popup;
            open_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            open_btn.Location = new Point(945, 76);
            open_btn.Margin = new Padding(3, 2, 3, 2);
            open_btn.Name = "open_btn";
            open_btn.Size = new Size(189, 53);
            open_btn.TabIndex = 4;
            open_btn.Text = "Open File";
            open_btn.UseVisualStyleBackColor = false;
            open_btn.Click += open_button_Click;
            // 
            // save_btn
            // 
            save_btn.BackColor = Color.Fuchsia;
            save_btn.Cursor = Cursors.Hand;
            save_btn.FlatStyle = FlatStyle.Popup;
            save_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save_btn.ForeColor = SystemColors.ButtonHighlight;
            save_btn.Location = new Point(945, 149);
            save_btn.Margin = new Padding(3, 2, 3, 2);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(189, 60);
            save_btn.TabIndex = 5;
            save_btn.Text = " Save As";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += Save_Click;
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.FromArgb(255, 128, 0);
            clear_btn.FlatStyle = FlatStyle.Popup;
            clear_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear_btn.Location = new Point(945, 239);
            clear_btn.Margin = new Padding(3, 2, 3, 2);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(189, 58);
            clear_btn.TabIndex = 6;
            clear_btn.Text = "Clear Canvas";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += Clear_Click;
            // 
            // font_btn
            // 
            font_btn.BackColor = Color.Khaki;
            font_btn.FlatStyle = FlatStyle.Popup;
            font_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            font_btn.Location = new Point(945, 560);
            font_btn.Margin = new Padding(3, 2, 3, 2);
            font_btn.Name = "font_btn";
            font_btn.Size = new Size(189, 54);
            font_btn.TabIndex = 7;
            font_btn.Text = "Font";
            font_btn.UseVisualStyleBackColor = false;
            font_btn.Click += change_font_button_Click;
            // 
            // color_btn
            // 
            color_btn.BackColor = Color.Moccasin;
            color_btn.FlatStyle = FlatStyle.Popup;
            color_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            color_btn.Location = new Point(945, 481);
            color_btn.Margin = new Padding(3, 2, 3, 2);
            color_btn.Name = "color_btn";
            color_btn.Size = new Size(189, 53);
            color_btn.TabIndex = 8;
            color_btn.Text = "Color";
            color_btn.UseVisualStyleBackColor = false;
            color_btn.Click += change_color_button_Click;
            // 
            // openFD
            // 
            openFD.FileName = "openFileDialog1";
            // 
            // backColor_btn
            // 
            backColor_btn.BackColor = Color.FromArgb(0, 192, 192);
            backColor_btn.FlatStyle = FlatStyle.Popup;
            backColor_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backColor_btn.Location = new Point(945, 397);
            backColor_btn.Margin = new Padding(3, 2, 3, 2);
            backColor_btn.Name = "backColor_btn";
            backColor_btn.Size = new Size(189, 57);
            backColor_btn.TabIndex = 9;
            backColor_btn.Text = "Background Color";
            backColor_btn.UseVisualStyleBackColor = false;
            backColor_btn.Click += background_color_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaptionText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(255, 128, 0);
            textBox1.Location = new Point(1005, 340);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(70, 32);
            textBox1.TabIndex = 10;
            textBox1.Text = "Style";
           
            // 
            // MyNotepad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InfoText;
            ClientSize = new Size(1172, 717);
            Controls.Add(textBox1);
            Controls.Add(backColor_btn);
            Controls.Add(color_btn);
            Controls.Add(font_btn);
            Controls.Add(clear_btn);
            Controls.Add(save_btn);
            Controls.Add(open_btn);
            Controls.Add(Canvas);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MyNotepad";
            Text = "Day6 NoteBook";
         
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private RichTextBox Canvas;
        private Button open_btn;
        private Button save_btn;
        private Button clear_btn;
        private Button font_btn;
        private Button color_btn;
        private SaveFileDialog saveFD;
        private OpenFileDialog openFD;
        private FontDialog fontDialog;
        private ColorDialog colorDialog;
        private Button backColor_btn;
        private TextBox textBox1;
    }
}
