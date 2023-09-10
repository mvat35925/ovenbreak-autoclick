using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

namespace cookierun
{
    public partial class main : Form
    {
        int c = 0;

        // Define constants for hotkeys
        private const int MOD_CONTROL = 0x0002;
        private const int WM_HOTKEY = 0x0312;

        // Define hotkey IDs
        private const int HOTKEY_START = 1;
        private const int HOTKEY_STOP = 2;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, Keys vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private bool sizeCheck()
        {
            foreach (RadioButton radioButton in sizeGB.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    return true;
                }
            }

            return false;
        }
        // Setup globally keys
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_HOTKEY)
            {
                int id = (int)m.WParam;

                if (id == HOTKEY_START && sizeCheck())
                {
                    if (!autoclickTimer.Enabled)
                    {
                        statusLabel.Text = "status: running";
                        LockSizeGB();
                        autoclickTimer.Start();
                    }
                }
                else if (id == HOTKEY_STOP)
                {
                    statusLabel.Text = "status: stop";

                    if (autoclickTimer.Enabled)
                    {
                        UnlockSizeGB();
                        autoclickTimer.Stop();
                    }
                }
            }
        }

        private void LockSizeGB()
        {
            foreach (RadioButton radioButton in sizeGB.Controls.OfType<RadioButton>())
            {
                radioButton.Enabled = false;
            }
        }

        private void UnlockSizeGB()
        {
            foreach (RadioButton radioButton in sizeGB.Controls.OfType<RadioButton>())
            {
                radioButton.Enabled = true;
            }
        }

        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int x, int y);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        // Define key constant
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        public main()
        {
            InitializeComponent();

            this.KeyPreview = true;

            // Register hotkeys
            RegisterHotKey(this.Handle, HOTKEY_START, MOD_CONTROL, Keys.F1);
            RegisterHotKey(this.Handle, HOTKEY_STOP, MOD_CONTROL, Keys.F2);
        }



        public static void MouseEvent(uint dwFlags, int x, int y)
        {
            mouse_event(dwFlags, x, y, 0, 0);
        }

        private void pixelsBtn_Click(object sender, EventArgs e)
        {
            pixels form = new pixels();
            form.Show();
        }

        private Color GetPixelColor(int x, int y)
        {
            // Capture the screen
            using (Bitmap screenCapture = new Bitmap(1, 1))
            {
                using (Graphics g = Graphics.FromImage(screenCapture))
                {
                    g.CopyFromScreen(new Point(x, y), new Point(0, 0), new Size(1, 1));
                }

                // Get the pixel color
                Color pixelColor = screenCapture.GetPixel(0, 0);
                return pixelColor;
            }
        }
        private Boolean checkColor(int x, int y, int r,int g,int b)
        {
            Color pixelColor = GetPixelColor(x, y);
            Color targetColor = Color.FromArgb(r, g, b); // Replace with the RGB values of your target color
            if (pixelColor.R == targetColor.R && pixelColor.G == targetColor.G && pixelColor.B == targetColor.B)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void autoclickTimer_Tick(object sender, EventArgs e)
        {
            // check the screen size 1920 x 1080
            if (size1.Checked)
            {
                // PRACTICE BUTTON
                if (checkColor(250, 376, 113, 63, 28) && checkColor(900, 736, 42, 28, 21))
                {
                    SetCursorPos(1627, 956);
                    MouseEvent(MOUSEEVENTF_LEFTDOWN, 0, 0);
                    MouseEvent(MOUSEEVENTF_LEFTUP, 0, 0);
                }
                // popup PRACTICE
                else if (checkColor(1260, 697, 255, 194, 24) && checkColor(882, 708, 206, 194, 163))
                {
                    c += 1;
                    count.Text = "Run:" + c + " time(s)";
                    SetCursorPos(1260, 697);
                    MouseEvent(MOUSEEVENTF_LEFTDOWN, 0, 0);
                    MouseEvent(MOUSEEVENTF_LEFTUP, 0, 0);
                }

                // OK BUTTON ( end ) 
                else if (checkColor(209, 181, 255, 230, 37) && checkColor(1069, 968, 255, 194, 24))
                {
                    SetCursorPos(1069, 968);
                    MouseEvent(MOUSEEVENTF_LEFTDOWN, 0, 0);
                    MouseEvent(MOUSEEVENTF_LEFTUP, 0, 0);
                }

                // Pouches skip
                else if (checkColor(315, 99, 251, 199, 36) && checkColor(1047, 929, 255, 194, 24))
                {
                    SetCursorPos(1047, 929);
                    MouseEvent(MOUSEEVENTF_LEFTDOWN, 0, 0);
                    MouseEvent(MOUSEEVENTF_LEFTUP, 0, 0);
                }

                // ADS skip
                else if(checkColor(1471, 209, 155, 69, 0) && checkColor(1083, 841, 222, 72, 249))
                {
                    SetCursorPos(1471, 209);
                    MouseEvent(MOUSEEVENTF_LEFTDOWN, 0, 0);
                    MouseEvent(MOUSEEVENTF_LEFTUP, 0, 0);
                }
            }
        }

        private void contact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.instagram.com/mvat35925/");
        }
    }
}
