
namespace Notepad_
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mainMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuFileCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuExitExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuFormatFormatSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuSettingsBackgroundSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuSettingsSavingSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuSettingsSavingSettingsSavingFrequency = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuSettingsSavingSettingsSeconds = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainMenu.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuFile,
            this.mainMenuEdit,
            this.mainMenuFormat,
            this.mainMenuSettings});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mainMenuFile
            // 
            this.mainMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuFileOpen,
            this.mainMenuFileSaveAs,
            this.mainMenuFileSave,
            this.mainMenuFileCreate,
            this.mainMenuExitExit});
            this.mainMenuFile.Name = "mainMenuFile";
            this.mainMenuFile.Size = new System.Drawing.Size(48, 20);
            this.mainMenuFile.Text = "Файл";
            // 
            // mainMenuFileOpen
            // 
            this.mainMenuFileOpen.Name = "mainMenuFileOpen";
            this.mainMenuFileOpen.Size = new System.Drawing.Size(180, 22);
            this.mainMenuFileOpen.Text = "Открыть";
            this.mainMenuFileOpen.Click += new System.EventHandler(this.mainMenuFileOpen_Click);
            // 
            // mainMenuFileSaveAs
            // 
            this.mainMenuFileSaveAs.Name = "mainMenuFileSaveAs";
            this.mainMenuFileSaveAs.Size = new System.Drawing.Size(180, 22);
            this.mainMenuFileSaveAs.Text = "Сохранить как";
            this.mainMenuFileSaveAs.Click += new System.EventHandler(this.mainMenuFileSaveAs_Click);
            // 
            // mainMenuFileSave
            // 
            this.mainMenuFileSave.Name = "mainMenuFileSave";
            this.mainMenuFileSave.Size = new System.Drawing.Size(180, 22);
            this.mainMenuFileSave.Text = "Сохранить";
            this.mainMenuFileSave.Click += new System.EventHandler(this.mainMenuFileSave_Click);
            // 
            // mainMenuFileCreate
            // 
            this.mainMenuFileCreate.Name = "mainMenuFileCreate";
            this.mainMenuFileCreate.Size = new System.Drawing.Size(180, 22);
            this.mainMenuFileCreate.Text = "Создать новый";
            this.mainMenuFileCreate.Click += new System.EventHandler(this.mainMenuFileCreate_Click);
            // 
            // mainMenuExitExit
            // 
            this.mainMenuExitExit.Name = "mainMenuExitExit";
            this.mainMenuExitExit.Size = new System.Drawing.Size(180, 22);
            this.mainMenuExitExit.Text = "Выход";
            this.mainMenuExitExit.Click += new System.EventHandler(this.mainMenuFileExit_Click);
            // 
            // mainMenuEdit
            // 
            this.mainMenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuEditCopy,
            this.mainMenuEditPaste,
            this.mainMenuEditCut,
            this.mainMenuEditSelectAll});
            this.mainMenuEdit.Name = "mainMenuEdit";
            this.mainMenuEdit.Size = new System.Drawing.Size(59, 20);
            this.mainMenuEdit.Text = "Правка";
            // 
            // mainMenuEditCopy
            // 
            this.mainMenuEditCopy.Name = "mainMenuEditCopy";
            this.mainMenuEditCopy.Size = new System.Drawing.Size(148, 22);
            this.mainMenuEditCopy.Text = "Копировать";
            this.mainMenuEditCopy.Click += new System.EventHandler(this.mainMenuEditCopy_Click);
            // 
            // mainMenuEditPaste
            // 
            this.mainMenuEditPaste.Name = "mainMenuEditPaste";
            this.mainMenuEditPaste.Size = new System.Drawing.Size(148, 22);
            this.mainMenuEditPaste.Text = "Вставить";
            this.mainMenuEditPaste.Click += new System.EventHandler(this.mainMenuEditPaste_Click);
            // 
            // mainMenuEditCut
            // 
            this.mainMenuEditCut.Name = "mainMenuEditCut";
            this.mainMenuEditCut.Size = new System.Drawing.Size(148, 22);
            this.mainMenuEditCut.Text = "Вырезать";
            this.mainMenuEditCut.Click += new System.EventHandler(this.mainMenuEditCut_Click);
            // 
            // mainMenuEditSelectAll
            // 
            this.mainMenuEditSelectAll.Name = "mainMenuEditSelectAll";
            this.mainMenuEditSelectAll.Size = new System.Drawing.Size(148, 22);
            this.mainMenuEditSelectAll.Text = "Выделить все";
            this.mainMenuEditSelectAll.Click += new System.EventHandler(this.mainMenuEditSelectAll_Click);
            // 
            // mainMenuFormat
            // 
            this.mainMenuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuFormatFormatSettings});
            this.mainMenuFormat.Name = "mainMenuFormat";
            this.mainMenuFormat.Size = new System.Drawing.Size(62, 20);
            this.mainMenuFormat.Text = "Формат";
            // 
            // mainMenuFormatFormatSettings
            // 
            this.mainMenuFormatFormatSettings.Name = "mainMenuFormatFormatSettings";
            this.mainMenuFormatFormatSettings.Size = new System.Drawing.Size(182, 22);
            this.mainMenuFormatFormatSettings.Text = "Настройки шрифта";
            this.mainMenuFormatFormatSettings.Click += new System.EventHandler(this.mainMenuFormatFormatSettings_Click);
            // 
            // mainMenuSettings
            // 
            this.mainMenuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuSettingsBackgroundSettings,
            this.mainMenuSettingsSavingSettings});
            this.mainMenuSettings.Name = "mainMenuSettings";
            this.mainMenuSettings.Size = new System.Drawing.Size(79, 20);
            this.mainMenuSettings.Text = "Настройки";
            // 
            // mainMenuSettingsBackgroundSettings
            // 
            this.mainMenuSettingsBackgroundSettings.Name = "mainMenuSettingsBackgroundSettings";
            this.mainMenuSettingsBackgroundSettings.Size = new System.Drawing.Size(202, 22);
            this.mainMenuSettingsBackgroundSettings.Text = "Настройки фона";
            this.mainMenuSettingsBackgroundSettings.Click += new System.EventHandler(this.mainMenuSettingsBackgroundSettings_Click);
            // 
            // mainMenuSettingsSavingSettings
            // 
            this.mainMenuSettingsSavingSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuSettingsSavingSettingsSavingFrequency,
            this.mainMenuSettingsSavingSettingsSeconds});
            this.mainMenuSettingsSavingSettings.Name = "mainMenuSettingsSavingSettings";
            this.mainMenuSettingsSavingSettings.Size = new System.Drawing.Size(202, 22);
            this.mainMenuSettingsSavingSettings.Text = "Настройки сохранения";
            // 
            // mainMenuSettingsSavingSettingsSavingFrequency
            // 
            this.mainMenuSettingsSavingSettingsSavingFrequency.Name = "mainMenuSettingsSavingSettingsSavingFrequency";
            this.mainMenuSettingsSavingSettingsSavingFrequency.Size = new System.Drawing.Size(242, 22);
            this.mainMenuSettingsSavingSettingsSavingFrequency.Text = "Частота сохранения (секунды)";
            // 
            // mainMenuSettingsSavingSettingsSeconds
            // 
            this.mainMenuSettingsSavingSettingsSeconds.Name = "mainMenuSettingsSavingSettingsSeconds";
            this.mainMenuSettingsSavingSettingsSeconds.Size = new System.Drawing.Size(100, 23);
            this.mainMenuSettingsSavingSettingsSeconds.Text = "30";
            this.mainMenuSettingsSavingSettingsSeconds.TextChanged += new System.EventHandler(this.mainMenuSettingsSavingSettingsSeconds_TextChanged);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuCopy,
            this.contextMenuPaste,
            this.contextMenuCut,
            this.contextMenuSelectAll,
            this.contextMenuFormat});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(149, 114);
            this.contextMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox_MouseUp);
            // 
            // contextMenuCopy
            // 
            this.contextMenuCopy.Name = "contextMenuCopy";
            this.contextMenuCopy.Size = new System.Drawing.Size(148, 22);
            this.contextMenuCopy.Text = "Копировать";
            this.contextMenuCopy.Click += new System.EventHandler(this.contextMenuCopy_Click);
            // 
            // contextMenuPaste
            // 
            this.contextMenuPaste.Name = "contextMenuPaste";
            this.contextMenuPaste.Size = new System.Drawing.Size(148, 22);
            this.contextMenuPaste.Text = "Вставить";
            this.contextMenuPaste.Click += new System.EventHandler(this.contextMenuPaste_Click);
            // 
            // contextMenuCut
            // 
            this.contextMenuCut.Name = "contextMenuCut";
            this.contextMenuCut.Size = new System.Drawing.Size(148, 22);
            this.contextMenuCut.Text = "Вырезать";
            this.contextMenuCut.Click += new System.EventHandler(this.contextMenuCut_Click);
            // 
            // contextMenuSelectAll
            // 
            this.contextMenuSelectAll.Name = "contextMenuSelectAll";
            this.contextMenuSelectAll.Size = new System.Drawing.Size(148, 22);
            this.contextMenuSelectAll.Text = "Выделить все";
            this.contextMenuSelectAll.Click += new System.EventHandler(this.contextMenuSelectAll_Click);
            // 
            // contextMenuFormat
            // 
            this.contextMenuFormat.Name = "contextMenuFormat";
            this.contextMenuFormat.Size = new System.Drawing.Size(148, 22);
            this.contextMenuFormat.Text = "Формат";
            this.contextMenuFormat.Click += new System.EventHandler(this.contextMenuFormat_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(3, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(786, 392);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(786, 392);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox_MouseUp);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 426);
            this.tabControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "Notepad+";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mainMenuFile;
        private System.Windows.Forms.ToolStripMenuItem mainMenuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mainMenuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mainMenuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mainMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem mainMenuFormat;
        private System.Windows.Forms.ToolStripMenuItem mainMenuSettings;
        private System.Windows.Forms.ToolStripMenuItem mainMenuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem mainMenuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem mainMenuEditCut;
        private System.Windows.Forms.ToolStripMenuItem mainMenuEditSelectAll;
        private System.Windows.Forms.ToolStripMenuItem mainMenuFormatFormatSettings;
        private System.Windows.Forms.ToolStripMenuItem mainMenuSettingsBackgroundSettings;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextMenuCopy;
        private System.Windows.Forms.ToolStripMenuItem contextMenuPaste;
        private System.Windows.Forms.ToolStripMenuItem contextMenuCut;
        private System.Windows.Forms.ToolStripMenuItem contextMenuSelectAll;
        private System.Windows.Forms.ToolStripMenuItem contextMenuFormat;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuSettingsSavingSettings;
        private System.Windows.Forms.ToolStripMenuItem mainMenuSettingsSavingSettingsSavingFrequency;
        private System.Windows.Forms.ToolStripTextBox mainMenuSettingsSavingSettingsSeconds;
        private System.Windows.Forms.ToolStripMenuItem mainMenuFileCreate;
        private System.Windows.Forms.ToolStripMenuItem mainMenuExitExit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

