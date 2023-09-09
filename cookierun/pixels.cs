using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cookierun
{
    public partial class pixels : Form
    {
        private Point currentCursorPosition;
        private Color currentPixelColor;
        public pixels()
        {
            InitializeComponent();
            delayTimer.Start();

        }

        private void pixels_Load(object sender, EventArgs e)
        {

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

        private void delayTimer_Tick(object sender, EventArgs e)
        {
            currentCursorPosition = Cursor.Position;

            // Capture the pixel color at the cursor position
            currentPixelColor = GetPixelColor(currentCursorPosition.X, currentCursorPosition.Y);

            // Display the pixel color information in the label
            pixelsLabel.Text = $"Color at ({currentCursorPosition.X}, {currentCursorPosition.Y}): R={currentPixelColor.R}, G={currentPixelColor.G}, B={currentPixelColor.B}";
        }
    

    private void pixels_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                // Copy coordinates to clipboard
                Clipboard.SetText($"X: {currentCursorPosition.X}, Y: {currentCursorPosition.Y}");
            }
            else if (e.KeyCode == Keys.F2)
            {
                // Copy color to clipboard
                Clipboard.SetText($"R: {currentPixelColor.R}, G: {currentPixelColor.G}, B: {currentPixelColor.B}");
            }
            else if (e.KeyCode == Keys.F3)
            {
                // Copy both coordinates and color to clipboard
                Clipboard.SetText($"{currentCursorPosition.X}, {currentCursorPosition.Y}, {currentPixelColor.R}, {currentPixelColor.G}, {currentPixelColor.B}");
            }
        }
    }
    
}
