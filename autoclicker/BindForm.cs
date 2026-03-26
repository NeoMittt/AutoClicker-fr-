using System;
using System.IO;
using System.Windows.Forms;

namespace autoclicker
{
    public partial class BindForm : Form
    {
        public string globalKey1 = "F3"; // Глобальная переменная для первой клавиши, значение по умолчанию
        public string globalKey2 = "F4"; // Глобальная переменная для второй клавиши, значение по умолчанию
        public string globalKey3 = "M";
        private const string configFilePath = "config.txt";
        public delegate void FormClosedEventHandler(object sender, EventArgs e);
        public event FormClosedEventHandler FormClosedEvent;

        public BindForm()
        {
            InitializeComponent();
            LoadKeysFromConfig();
            
             // Загружаем сохраненные значения при старте
        }


        // Обработчик клавиш для первой кнопки и текстбокса
        private void BindForm_KeyDown1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape)
            {
                globalKey1 = e.KeyCode.ToString();
                textBoxkey1.Text = Convert.ToChar(e.KeyCode).ToString();

                // Скрываем сообщение
                label2.Visible = false;
                label3.Visible = true;

                // Отключаем обработку клавиш, чтобы избежать повторного срабатывания
                this.KeyDown -= BindForm_KeyDown1;
                this.KeyPreview = false;
            }
        }

        // Обработчик клавиш для второй кнопки и текстбокса
        private void BindForm_KeyDown2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape)
            {
                
                globalKey2 = e.KeyCode.ToString();
                textBoxkey2.Text = Convert.ToChar(e.KeyCode).ToString();


                // Скрываем сообщение
                label2.Visible = false;
                label3.Visible = true;

                // Отключаем обработку клавиш, чтобы избежать повторного срабатывания
                this.KeyDown -= BindForm_KeyDown2;
                this.KeyPreview = false;
            }
        }
        private void BindForm_KeyDown3(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape)
            {

                globalKey3 = e.KeyCode.ToString();
                textBoxkey3.Text = Convert.ToChar(e.KeyCode).ToString();


                // Скрываем сообщение
                label2.Visible = false;
                label3.Visible = true;

                // Отключаем обработку клавиш, чтобы избежать повторного срабатывания
                this.KeyDown -= BindForm_KeyDown3;
                this.KeyPreview = false;
            }
        }



        // Метод для сохранения значений глобальных переменных в текстовый файл
        private void SaveKeysToConfig()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(configFilePath))
                {
                    writer.WriteLine(globalKey1);
                    writer.WriteLine(globalKey2);
                    writer.WriteLine(globalKey3);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving configuration: " + ex.Message);
            }
        }


        // Метод для загрузки значений из текстового файла при запуске
        private void LoadKeysFromConfig()
        {
            if (File.Exists(configFilePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(configFilePath);
                    if (lines.Length >= 3)
                    {
                        globalKey1 = string.IsNullOrEmpty(lines[0]) ? "F3" : lines[0];
                        globalKey2 = string.IsNullOrEmpty(lines[1]) ? "F4" : lines[1];
                        globalKey3 = string.IsNullOrEmpty(lines[2]) ? "M" : lines[2];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading configuration: " + ex.Message);

                }
            }

            // Устанавливаем загруженные или значения по умолчанию в текстбоксы
            textBoxkey1.Text = globalKey1;
            textBoxkey2.Text = globalKey2;
            textBoxkey3.Text = globalKey3;
        }

        private void buttonkey1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = false;

            // Включаем обработку клавиш на форме
            this.KeyPreview = true;
            this.KeyDown += BindForm_KeyDown1;
        }

        private void buttonkey2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = false;// Показываем второе сообщение

            // Включаем обработку клавиш на форме
            this.KeyPreview = true;
            this.KeyDown += BindForm_KeyDown2;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (globalKey1 == globalKey2 || globalKey1 == globalKey3 || globalKey2 == globalKey3)
            {
                MessageBox.Show("The two keys must not match.", "Error ;(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveKeysToConfig(); // Сохраняем значения в конфиг
                FormClosedEvent?.Invoke(this, EventArgs.Empty); // Trigger the event
                this.Close(); // Закрываем форму после сохранения
            }
        }

        private void buttonkey3_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = false;// Показываем второе сообщение

            // Включаем обработку клавиш на форме
            this.KeyPreview = true;
            this.KeyDown += BindForm_KeyDown3;
        }
    }
}
