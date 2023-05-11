using System.Drawing.Drawing2D;

namespace ScheduleMe.Tab;

public partial class EventContainer : UserControl
{
    public EventContainer()
    {
        InitializeComponent();
    }

    private void panelEvent_Paint(object sender, PaintEventArgs e)
    {
        int borderWidth = 2;
        int borderRadius = 10;

        e.Graphics.Clear(panelEvent.BackColor);
        GraphicsPath path = new GraphicsPath();
        path.AddArc(panelEvent.ClientRectangle.X,
                    panelEvent.ClientRectangle.Y,
                    borderRadius,
                    borderRadius,
                    180,
                    90);
        path.AddArc(panelEvent.ClientRectangle.Right - borderRadius,
                    panelEvent.ClientRectangle.Y,
                    borderRadius,
                    borderRadius,
                    270,
                    90);
        path.AddArc(panelEvent.ClientRectangle.Right - borderRadius,
                    panelEvent.ClientRectangle.Bottom - borderRadius,
                    borderRadius,
                    borderRadius,
                    0,
                    90);
        path.AddArc(panelEvent.ClientRectangle.X,
                    panelEvent.ClientRectangle.Bottom - borderRadius,
                    borderRadius,
                    borderRadius,
                    90,
                    90);

        e.Graphics.FillPath(new SolidBrush(panelEvent.BackColor), path);
        e.Graphics.DrawPath(new Pen(Color.Black, borderWidth), path);
    }
}
