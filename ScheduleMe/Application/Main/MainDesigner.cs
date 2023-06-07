using System.Drawing;

namespace ScheduleMe.Tab;

internal static class MainDesigner
{
    static internal readonly Color ThemeColor = Color.FromArgb(15, 76, 129);
    static internal readonly Color HighlightColor = Color.FromArgb(64, 64, 64);

    static float GetSystemDisplayScale()
    {
        return Graphics.FromHwnd(IntPtr.Zero).DpiX / 96f;
    }

    static internal float BaseWidthFactor()
    {
        return (Screen.PrimaryScreen.Bounds.Width / 1366f) * GetSystemDisplayScale();
        //return (1920f / 1366f);
    }

    static internal float BaseHeightFactor()
    {
        return (Screen.PrimaryScreen.Bounds.Height / 768f) * GetSystemDisplayScale();
        //return (1080f / 768f);
    }
}
