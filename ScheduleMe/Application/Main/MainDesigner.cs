namespace ScheduleMe.Tab;

internal static class MainDesigner
{
    static internal readonly Color ThemeColor = Color.FromArgb(15, 76, 129);
    static internal readonly Color HighlightColor = Color.FromArgb(64, 64, 64);

    static internal short BaseWidthFactor()
    {
        return (short)(Screen.PrimaryScreen.Bounds.Width * 1366);
    }

    static internal short BaseHeightFactor()
    {
        return (short)(Screen.PrimaryScreen.Bounds.Height * 768);
    }
}
