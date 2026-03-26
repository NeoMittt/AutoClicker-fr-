using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;


namespace autoclicker
{
    public partial class Form1 : Form
    {
        // Импортируем функции работы с мышью и клавиатурой
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        private const int KEYEVENTF_KEYDOWN = 0x0000; // Key down flag
        private const int KEYEVENTF_KEYUP = 0x0002;   // Key up flag


        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;


        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point ipPoint);

        private const int WM_HOTKEY = 0x0312;
        private const int MOD_ALT = 0x0001;
        private const int MOD_CONTROL = 0x0002;
        private const int MOD_SHIFT = 0x0004;
        private const int MOD_WIN = 0x0008;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private int hotKeyId1 = 1;
        private int hotKeyId2 = 2;
        private int hotKeyId3 = 3;

        public bool mouse;
        static public bool isStart = false;
        static public bool cords = false;

        private string globalKey1 = "F3";
        private string globalKey2 = "F4";
        private string globalKey3 = "M";

        public Form1()
        {
            InitializeComponent();
            LoadKeysFromConfig(); // Загружаем значения клавиш при старте
            this.KeyPreview = true;

            RegisterGlobalHotKeys(); // Регистрируем горячие клавиши
            UpdateButtonTexts(); // Обновляем текст кнопок
            comboBox11.SelectedIndex = 0;
        }

        public void Updater()
        {
            LoadKeysFromConfig(); // Загружаем значения клавиш при старте
            this.KeyPreview = true;

            RegisterGlobalHotKeys(); // Регистрируем горячие клавиши
            UpdateButtonTexts(); // Обновляем текст кнопок
            Debug.Print("1");
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();
                if (id == hotKeyId1)
                {
                    buttonStart.PerformClick();
                    return;
                }
                else if (id == hotKeyId2)
                {
                    buttonPick.PerformClick();
                    return;
                }
            }
            base.WndProc(ref m);
        }


        private void RegisterGlobalHotKeys()
        {
            UnregisterGlobalHotKeys(); // Освобождаем предыдущие клавиши

            RegisterHotKeyFromConfig(globalKey1, hotKeyId1);
            RegisterHotKeyFromConfig(globalKey2, hotKeyId2);
            RegisterHotKeyFromConfig(globalKey3, hotKeyId3);
        }

        private void RegisterHotKeyFromConfig(string key, int id)
        {
            if (Enum.TryParse(key, true, out Keys parsedKey))
            {
                if (!RegisterHotKey(this.Handle, id, 0, (int)parsedKey))
                {
                    MessageBox.Show($"Failed to register global key: {key}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Invalid value for key: {key}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void UnregisterGlobalHotKeys()
        {
            UnregisterHotKey(this.Handle, hotKeyId1);
            UnregisterHotKey(this.Handle, hotKeyId2);
            UnregisterHotKey(this.Handle, hotKeyId3);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterGlobalHotKeys(); // Отменяем регистрацию горячих клавиш при закрытии формы
        }

        private void ValidateTextBoxInput(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void EnsureDefaultTextBoxValue(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text)) textBox.Text = "0";
        }

        private void textBoxMils_KeyPress(object sender, KeyPressEventArgs e) => ValidateTextBoxInput(e);
        private void textBoxSecs_KeyPress(object sender, KeyPressEventArgs e) => ValidateTextBoxInput(e);
        private void textBoxMins_KeyPress(object sender, KeyPressEventArgs e) => ValidateTextBoxInput(e);
        private void textBoxX_KeyPress(object sender, KeyPressEventArgs e) => ValidateTextBoxInput(e);
        private void textBoxY_KeyPress(object sender, KeyPressEventArgs e) => ValidateTextBoxInput(e);

        private void textBoxMils_Leave(object sender, EventArgs e) => EnsureDefaultTextBoxValue(textBoxMils);
        private void textBoxSecs_Leave(object sender, EventArgs e) => EnsureDefaultTextBoxValue(textBoxSecs);
        private void textBoxMins_Leave(object sender, EventArgs e) => EnsureDefaultTextBoxValue(textBoxMins);
        private void textBoxX_Leave(object sender, EventArgs e) => EnsureDefaultTextBoxValue(textBoxX);
        private void textBoxY_Leave(object sender, EventArgs e) => EnsureDefaultTextBoxValue(textBoxY);

        private void ToggleCoordinateControls(bool enabled)
        {
            labelX.Enabled = enabled;
            labelY.Enabled = enabled;
            textBoxX.Enabled = enabled;
            textBoxY.Enabled = enabled;
            buttonPick.Enabled = enabled;
        }

        private void buttonPick_Click(object sender, EventArgs e)
        {
            buttonPick.Text = $"Pick ({globalKey2})";
            Point defPnt = new Point();
            GetCursorPos(ref defPnt);
            textBoxX.Text = defPnt.X.ToString();
            textBoxY.Text = defPnt.Y.ToString();
        }

        async private void buttonStart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxMils.Text, out int mils) &&
                int.TryParse(textBoxSecs.Text, out int secs) &&
                int.TryParse(textBoxMins.Text, out int mins) &&
                (mils > 0 || secs > 0 || mins > 0))
            {
                isStart = !isStart;
                buttonStart.Text = isStart ? $"Stop ({globalKey1})" : $"Start ({globalKey1})";
                Debug.WriteLine(isStart);

                Size resolution = Screen.PrimaryScreen.Bounds.Size;

                while (isStart)
                {
                    SetControlsEnabled(false);

                    if (mouse)
                    {
                        int X = 0, Y = 0;

                        if (cords)
                        {
                            X = CalculateMousePosition(Convert.ToInt32(textBoxX.Text), resolution.Width);
                            Y = CalculateMousePosition(Convert.ToInt32(textBoxY.Text), resolution.Height);
                            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, X, Y, 0, 0);
                        }
                        else
                        {
                            Point currentPos = new Point();
                            GetCursorPos(ref currentPos);
                            X = CalculateMousePosition(currentPos.X, resolution.Width);
                            Y = CalculateMousePosition(currentPos.Y, resolution.Height);
                        }

                        uint mouseDown = GetMouseDownEvent();
                        uint mouseUp = GetMouseUpEvent();
                        ClickMouse(mouseDown, mouseUp);
                    }
                    else
                    {
                        if (Enum.TryParse(globalKey3, out Keys key))
                        {
                            Debug.WriteLine($"Parsed key: {key}");
                            PressKey(key);
                        }
                        else
                        {
                            Debug.WriteLine($"Failed to parse key: {globalKey3}");
                        }

                    }

                    await Task.Delay(mils + secs * 1000 + mins * 60000);
                }

                SetControlsEnabled(true);
            }
            else
            {
                MessageBox.Show("Set the time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetControlsEnabled(bool enabled)
        {
            textBoxMins.Enabled = enabled;
            textBoxSecs.Enabled = enabled;
            textBoxMils.Enabled = enabled;
            checkBox1.Enabled = enabled;

            buttonHot.Enabled = enabled;
            radioButtonLeft.Enabled = enabled;
            radioButtonMiddle.Enabled = enabled;
            radioButtonRight.Enabled = enabled;
            comboBox11.Enabled = enabled;
            checkBox1.Enabled= enabled;
        }

        private int CalculateMousePosition(int value, int screenSize)
        {
            return (65535 * Clamp(value, 0, screenSize) / screenSize);
        }

        private int Clamp(int value, int min, int max)
        {
            return Math.Max(min, Math.Min(value, max));
        }

        private uint GetMouseDownEvent()
        {
            if (radioButtonLeft.Checked) return MOUSEEVENTF_LEFTDOWN;
            if (radioButtonMiddle.Checked) return MOUSEEVENTF_MIDDLEDOWN;
            return MOUSEEVENTF_RIGHTDOWN;
        }

        private uint GetMouseUpEvent()
        {
            if (radioButtonLeft.Checked) return MOUSEEVENTF_LEFTUP;
            if (radioButtonMiddle.Checked) return MOUSEEVENTF_MIDDLEUP;
            return MOUSEEVENTF_RIGHTUP;
        }

        private void ClickMouse(uint down, uint up)
        {
            mouse_event(down, 0, 0, 0, 0);
            mouse_event(up, 0, 0, 0, 0);
        }

        private void PressKey(Keys key)
        {
            // Создаем экземпляр InputSimulator
            SendKeys.Send(globalKey3);
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cords = checkBox1.Checked;
            ToggleCoordinateControls(cords);
        }



        private void LoadKeysFromConfig()
        {
            // Пример загрузки клавиш из файла конфигурации
            try
            {
                string[] lines = File.ReadAllLines("config.txt");
                if (lines.Length >= 3)
                {
                    globalKey1 = lines[0];
                    globalKey2 = lines[1];
                    globalKey3 = lines[2];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading configuration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateButtonTexts()
        {
            buttonStart.Text = $"Start ({globalKey1})";
            buttonPick.Text = $"Pick ({globalKey2})";
        }

        private void buttonHot_Click(object sender, EventArgs e)
        {
            BindForm bindForm = new BindForm();
            bindForm.ShowDialog();
            Updater(); // Обновляем настройки после изменения
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox11.DropDownStyle = ComboBoxStyle.DropDownList;
            if (comboBox11.Text == "keyboard")
            {
                mouse = false;
                pictureBoxKey.Visible = true;

                AutoClicka.Enabled = false;
                AutoClicka.Visible = false;
                radioButtonLeft.Enabled = false;
                radioButtonLeft.Visible = false;
                radioButtonRight.Enabled = false;
                radioButtonRight.Visible = false;
                radioButtonMiddle.Enabled = false;
                radioButtonMiddle.Visible = false;
                labelX.Visible = false;
                labelY.Visible = false;
                textBoxX.Visible = false;
                textBoxY.Visible = false;
                buttonPick.Visible = false;

            }
            else if (comboBox11.Text == "mouse")
            {
                mouse = true;
                pictureBoxKey.Visible = false;

                AutoClicka.Enabled = true;
                AutoClicka.Visible = true;
                radioButtonLeft.Enabled = true;
                radioButtonLeft.Visible = true;
                radioButtonRight.Enabled = true;
                radioButtonRight.Visible = true;
                radioButtonMiddle.Enabled = true;
                radioButtonMiddle.Visible = true;
                labelX.Visible = true;
                labelY.Visible = true;
                textBoxX.Visible = true;
                textBoxY.Visible = true;
                buttonPick.Visible = true;

            }
        }
    }
}
