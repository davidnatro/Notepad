using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_
{
    /// <summary>
    /// Класс формы.
    /// </summary>
    public partial class Form1 : Form
    {
        bool[] saved = { false };
        bool[] savedAs = { false };
        string[] fileName = {null};
        int seconds = 30;
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text File(*.txt)|*.txt|RTF Files|*.rtf";
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt|Rich Text Format(*.rtf)|*.rtf";
            TabPage del = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
            tabControl1.TabPages.Remove(del);
        }

        /// <summary>
        /// Описывает клик на копку "Открыть" в главном меню.
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        private void mainMenuFileOpen_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox rich = (RichTextBox)tabControl1.SelectedTab.Controls.Find($"richTextBox{tabControl1.SelectedIndex + 1}", true)[0];
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                fileName[tabControl1.SelectedIndex] = openFileDialog1.FileName;
                if (Path.GetExtension(fileName[tabControl1.SelectedIndex]) == ".rtf")
                {
                    rich.LoadFile(Path.Combine(fileName[tabControl1.SelectedIndex]), RichTextBoxStreamType.RichText);
                }
                else
                {
                    string fileText = File.ReadAllText(fileName[tabControl1.SelectedIndex]);
                    rich.Text = fileText;
                }
                savedAs[tabControl1.SelectedIndex] = true;
                savedAs[tabControl1.SelectedIndex] = true;
                MessageBox.Show("Файл успешно открыт");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Описывает клик на кнопку "Сохранить как" в главном меню.
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        /// </summary>
        private void mainMenuFileSaveAs_Click(object sender, EventArgs e)
        {
            try{
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                timer1.Stop();
                fileName[tabControl1.SelectedIndex] = saveFileDialog1.FileName;
                if (Path.GetExtension(fileName[tabControl1.SelectedIndex]) == ".rtf")
                {
                    RichTextBox rich = (RichTextBox)tabControl1.SelectedTab.Controls.Find($"richTextBox{tabControl1.SelectedIndex + 1}", true)[0];
                    richTextBox1.SaveFile(fileName[tabControl1.SelectedIndex]);
                }
                else
                {
                    RichTextBox rich = (RichTextBox)tabControl1.SelectedTab.Controls.Find($"richTextBox{tabControl1.SelectedIndex + 1}", true)[0];
                    File.WriteAllText(fileName[tabControl1.SelectedIndex], rich.Text);
                }
                savedAs[tabControl1.SelectedIndex] = true;
                saved[tabControl1.SelectedIndex] = true;
                timer1.Interval = seconds * 1000;
                timer1.Start();
                MessageBox.Show("Файл успешно сохранен");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Описывает клик на кнопку "Сохранить" в главном меню.
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        /// </summary>
        private void mainMenuFileSave_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox rich = (RichTextBox)tabControl1.SelectedTab.Controls.Find($"richTextBox{tabControl1.SelectedIndex + 1}", true)[0];
                if (!savedAs[tabControl1.SelectedIndex])
                {
                    mainMenuFileSaveAs_Click(mainMenuFileSaveAs, e);
                }
                else
                {
                    File.WriteAllText(fileName[tabControl1.SelectedIndex], rich.Text);
                    saved[tabControl1.SelectedIndex] = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Описывает клик на кнопку "Копировать" в главном меню.
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        /// </summary>
        private void mainMenuEditCopy_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox rich = (RichTextBox)tabControl1.SelectedTab.Controls.Find($"richTextBox{tabControl1.SelectedIndex + 1}", true)[0];
                if (rich.TextLength > 0)
                {
                    rich.Copy();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Описывает клик на кнопку "Вставить" в главном меню.
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        /// </summary>
        private void mainMenuEditPaste_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox rich = (RichTextBox)tabControl1.SelectedTab.Controls.Find($"richTextBox{tabControl1.SelectedIndex + 1}", true)[0];
                rich.Paste();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            } 
        }

        /// <summary>
        /// Описывает клик на кнопку "Вырезать" в главном меню.
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        /// </summary>
        private void mainMenuEditCut_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox rich = (RichTextBox)tabControl1.SelectedTab.Controls.Find($"richTextBox{tabControl1.SelectedIndex + 1}", true)[0];
                if (rich.TextLength > 0)
                {
                    rich.Cut();
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Описывает клик на кнопку "Выделить все" в главном меню.
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        /// </summary>
        private void mainMenuEditSelectAll_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox rich = (RichTextBox)tabControl1.SelectedTab.Controls.Find($"richTextBox{tabControl1.SelectedIndex + 1}", true)[0];
                if (rich.TextLength > 0)
                {
                    rich.SelectAll();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            } 
        }

        /// <summary>
        /// Описывает клик на кнопку "Настройки шрифта" в главном меню".
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        /// </summary>
        private void mainMenuFormatFormatSettings_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox rich = (RichTextBox)tabControl1.SelectedTab.Controls.Find($"richTextBox{tabControl1.SelectedIndex + 1}", true)[0];
                fontDialog1.ShowDialog();
                if (rich.SelectedText.Length == 0)
                {
                    rich.Font = fontDialog1.Font;
                }
                else
                {
                    rich.SelectionFont = fontDialog1.Font;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Описывает клик на кнопку "Настройки фона" в главном меню.
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        /// </summary>
        private void mainMenuSettingsBackgroundSettings_Click(object sender, EventArgs e)
        {
            try 
            {
                colorDialog1.ShowDialog();
                for (int i = 0; i < tabControl1.TabPages.Count; ++i)
                {
                    tabControl1.SelectedIndex = i;
                    RichTextBox rich = (RichTextBox)tabControl1.SelectedTab.Controls.Find($"richTextBox{tabControl1.SelectedIndex + 1}", true)[0];
                    rich.BackColor = colorDialog1.Color;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Описывает изменения поля "Частота сохранения" в главном меню.
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        /// </summary>
        private void mainMenuSettingsSavingSettingsSeconds_TextChanged(object sender, EventArgs e)
        {
            try
            {
                seconds = int.Parse(mainMenuSettingsSavingSettingsSeconds.Text);
                timer1.Interval = seconds * 1000;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Описывает поведение таймера.
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < tabControl1.TabPages.Count; ++i)
                {
                    if (savedAs[i])
                    {
                        tabControl1.SelectedIndex = i;
                        mainMenuFileSave_Click(mainMenuFileSave, e);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Описывает клик на кнопку "Копировать" в контекстном меню.
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        /// </summary>
        private void contextMenuCopy_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox rich = (RichTextBox)tabControl1.SelectedTab.Controls.Find($"richTextBox{tabControl1.SelectedIndex + 1}", true)[0];
                if (rich.TextLength > 0)
                {
                    rich.Copy();
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            } 
        }

        /// <summary>
        /// Описывает клик на кнопку "Вставить" в контекстном меню.
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        /// </summary>
        private void contextMenuPaste_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox rich = (RichTextBox)tabControl1.SelectedTab.Controls.Find($"richTextBox{tabControl1.SelectedIndex + 1}", true)[0];
                rich.Paste();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
        }

        /// <summary>
        /// Описывает клик на кнопку "Вырезать" в контекстном меню.
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        /// </summary>
        private void contextMenuCut_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox rich = (RichTextBox)tabControl1.SelectedTab.Controls.Find($"richTextBox{tabControl1.SelectedIndex + 1}", true)[0];
                if (rich.TextLength > 0)
                {
                    rich.Cut();
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            } 
        }

        /// <summary>
        /// Описывает клик на кнопку "Выделить все" в контекстном меню.
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        /// </summary>
        private void contextMenuSelectAll_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox rich = (RichTextBox)tabControl1.SelectedTab.Controls.Find($"richTextBox{tabControl1.SelectedIndex + 1}", true)[0];
                if (rich.TextLength > 0)
                {
                    rich.SelectAll();
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            } 
        }

        /// <summary>
        /// Описывает клик на кнопку "Формат" в контекстном меню.
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        /// </summary>
        private void contextMenuFormat_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox rich = (RichTextBox)tabControl1.SelectedTab.Controls.Find($"richTextBox{tabControl1.SelectedIndex + 1}", true)[0];
                fontDialog1.ShowDialog();
                rich.SelectionFont = fontDialog1.Font;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Описывает поведение приложения при изменении контента.
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        /// основного блока для текста.
        /// </summary>
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                saved[tabControl1.SelectedIndex] = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Описывает поведение приложения при его закрытии.
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                bool flag = false;
                for(int i = 0; i < saved.Length; ++i)
                {
                    if (!saved[i])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    DialogResult dialog = MessageBox.Show("Вы хотите сохранить все файлы?", "Выход", MessageBoxButtons.YesNoCancel);
                    if (dialog == DialogResult.Yes)
                    {
                        for (int i = 0; i < tabControl1.TabPages.Count; ++i)
                        {
                            tabControl1.SelectedIndex = i;
                            mainMenuFileSave_Click(mainMenuFileSave, e);
                        }
                    }
                    else if (dialog == DialogResult.No)
                    {
                        for (int i = 0; i < saved.Length; ++i)
                        {
                            saved[tabControl1.SelectedIndex] = true;
                            savedAs[tabControl1.SelectedIndex] = true;
                        }
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    saved[tabControl1.SelectedIndex] = true;
                    savedAs[tabControl1.SelectedIndex] = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Описывает клик на кнопку "Выход" в главном меню.
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        /// </summary>
        private void mainMenuFileExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Описывает клик на кнопку "Создать" в главном меню.
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        /// </summary>
        private void mainMenuFileCreate_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl1.TabPages.Add($"tabPage{tabControl1.TabPages.Count + 1}");
                RichTextBox rich = new RichTextBox();
                rich.Name = $"richTextBox{tabControl1.TabPages.Count}";
                tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(rich);
                rich.Dock = DockStyle.Fill;
                rich.BackColor = tabControl1.TabPages[0].Controls.Find($"richTextBox1", true)[0].BackColor;
                rich.MouseUp += new MouseEventHandler(richTextBox_MouseUp);
                Array.Resize(ref fileName, fileName.Length + 1);
                Array.Resize(ref saved, fileName.Length + 1);
                Array.Resize(ref savedAs, fileName.Length + 1);
                fileName[fileName.Length - 1] = null;
                saved[saved.Length - 1] = false;
                savedAs[savedAs.Length - 1] = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Контекстное меню.
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация событий</param>
        /// </summary>
        private void richTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                RichTextBox rich = (RichTextBox)tabControl1.SelectedTab.Controls.Find($"richTextBox{tabControl1.SelectedIndex + 1}", true)[0];
                rich.ContextMenuStrip = contextMenu;
            }
        }
    }
}
