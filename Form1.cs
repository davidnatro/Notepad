using System;
using System.IO;
using System.Windows.Forms;

namespace Notepad_
{
    public partial class Form1 : Form
    {
        // Определяет открыт ли какой либо файл
        private bool IsOpened;
        //Определяет был ли изменён файл
        private bool IsChanged;

        /// <summary>
        /// Точка входа
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt|rtf File(*.rtf)|*.rtf";
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии</param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Выход из приложения
        /// </summary>
        /// <param name="e">Информация о событии</param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            object empty = new object();
            if (IsChanged)
            {
                Exit temp = new Exit();
                temp.ShowDialog();

                if (temp.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        if (!IsOpened)
                        {
                            MessageBox.Show("Для начала откройте сущетсвующий файл или сохраните этот" +
                            " с помощью функции \"Сохранить как...\"");
                            e.Cancel = true;
                            return;
                        }

                        string filename = openFileDialog1.FileName;
                        File.WriteAllText(filename, richTextBox1.Text);
                        IsChanged = false;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Для начала откройте сущетсвующий файл или сохраните этот" +
                                    " с помощью функции \"Сохранить как...\"");
                        e.Cancel = true;
                        return;
                    }
                }
                else if (temp.DialogResult == DialogResult.Ignore)
                {
                    Environment.Exit(0);
                    return;
                }
                else if (temp.DialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }        
            }
            Environment.Exit(0);
        }

        /// <summary>
        /// Открытие файла
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии</param>
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                string filename = openFileDialog1.FileName;
                string fileText = File.ReadAllText(filename);


                if (Path.GetExtension(filename) == ".rtf")
                {
                    //richTextBox1.LoadFile(filename);
                    richTextBox1.LoadFile(filename);
                    //tabControl1.SelectedTab.Text = richTextBox1.LoadFile(filename)
                }
                else
                {
                    //tabControl1.SelectedTab.Controls[0].Text = fileText;
                    richTextBox1.Text = fileText;
                }

                MessageBox.Show("Файл открыт!");
                IsOpened = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Сохранение в определенной директории и расширении
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии</param>
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                string fileName = saveFileDialog1.FileName;
                //richTextBox1.SaveFile(fileName);
                //File.WriteAllText(fileName, tabControl1.SelectedTab.Controls[0].Text);
                File.WriteAllText(fileName, richTextBox1.Text);
                MessageBox.Show("Файл сохранён!");
                IsOpened = true;
                IsChanged = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Сохранение
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии</param>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsOpened)
                {
                    MessageBox.Show("Для начала откройте сущетсвующий файл или сохраните этот" +
                    " с помощью функции \"Сохранить как...\"");
                    return;
                }

                string filename = openFileDialog1.FileName;
                File.WriteAllText(filename, richTextBox1.Text);
                IsChanged = false;
            }
            catch (Exception)
            {
                timer1.Enabled = false;
                MessageBox.Show("Для начала откройте сущетсвующий файл или сохраните этот" +
                    " с помощью функции \"Сохранить как...\"");
            }
        }

        /// <summary>
        /// Копия текста
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии</param>
        private void скопироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        /// <summary>
        /// Вставка текста
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии</param>
        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        /// <summary>
        /// Вырез текста
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии</param>
        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }


        /// <summary>
        /// Вызов меню для настройки шрифта
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии</param>
        private void настройкиШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }


        /// <summary>
        /// Вызов меню по нажатию правой кнопки мыши
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии</param>
        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                richTextBox1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        /// <summary>
        /// Копирование по нажатию из меню вызыванного правой кнопкой мыши
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии</param>
        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        /// <summary>
        /// Вставка по нажатию из меню вызыванного правой кнопкой мыши
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии</param>
        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        /// <summary>
        /// Вырезка по нажатию из меню вызыванного правой кнопкой мыши
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии</param>
        private void вырезатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        /// <summary>
        /// Выделение всего
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии</param>
        private void выделитьВсёToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength != 0)
            {
                richTextBox1.SelectAll();
            }
        }

        /// <summary>
        /// Выделение всего текста
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии</param>
        private void выделитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength != 0)
            {
                richTextBox1.SelectAll();
            }
        }

        /// <summary>
        /// Автосохранение
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии</param>
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ((int)numericUpDown1.Value == 0)
                {
                    MessageBox.Show("Автосохраение отключено!");
                    timer1.Enabled = false;
                    return;
                }

                if (!IsOpened)
                {
                    MessageBox.Show("Для начала откройте какой либо файл, либо" +
                        " сохраните текущий");
                    numericUpDown1.Value = 0;
                    return;
                }
                
                timer1.Interval = 1000;
                timer1.Interval *= (int)numericUpDown1.Value;
                timer1.Tick += new EventHandler(Timer1_Tick);
                timer1.Enabled = true;
                MessageBox.Show($"Автосохранение срабатывает каждые {(int)numericUpDown1.Value}с.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Частота автосохранения
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии</param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            сохранитьToolStripMenuItem_Click(sender, e);
        }

        /// <summary>
        /// Настройка фона
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии</param>
        private void настройкиФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        /// <summary>
        /// Проверка изменения текста
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии</param>
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            IsChanged = true;
        }

        /// <summary>
        /// Создание нового окна
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии</param>
        private void окноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form1();
            form2.Show();
        }

        /// <summary>
        /// Горячия клавиша создания нового окна
        /// </summary>
        /// <param name="sender">Издатель</param>
        /// <param name="e">Информация о событии</param>
        private void CreateForm(object sender, KeyEventArgs e)
        {
            if(e.KeyData == (Keys.Control | Keys.N))
            {
                окноToolStripMenuItem_Click(sender, e);
            }
            else if(e.KeyData == (Keys.Control | Keys.S))
            {
                сохранитьToolStripMenuItem_Click(sender, e);
            }
            else if (e.KeyData == (Keys.Control | Keys.Q))
            {
                Environment.Exit(0);
            }
        }
    }
}
