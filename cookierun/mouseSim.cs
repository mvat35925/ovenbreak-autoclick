using System.Runtime.InteropServices;

public class MouseSimulator
{
    [DllImport("user32.dll", SetLastError = true)]
    public static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

    public const int MOUSEEVENTF_LEFTDOWN = 0x02;
    public const int MOUSEEVENTF_LEFTUP = 0x04;

    public static void MouseEvent(uint dwFlags, int x, int y)
    {
        mouse_event(dwFlags, x, y, 0, 0);
    }
}