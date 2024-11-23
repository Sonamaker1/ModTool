using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class CustomBtn : Button
{
    private bool ShouldDraw = false;
    private LinearGradientBrush myBrush = null;
    public String fileName = "";
    public String fileEXT= "";
    public String fileAssetType = "";
    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        ShouldDraw = true;
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        ShouldDraw = false;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        //painting = true;

        base.OnPaint(e);

        StringFormat format = new StringFormat();
        Int32 lNum = (Int32)Math.Log((Double)this.TextAlign, 2);
        format.LineAlignment = (StringAlignment)(lNum / 4);
        format.Alignment = (StringAlignment)(lNum % 4);

        int padding = 2;

        SizeF txt = e.Graphics.MeasureString(Text, this.Font);
        SizeF sz = e.Graphics.VisibleClipBounds.Size;
        /*switch (Rotation)
        {
            case RotationType.Right:  //90 degrees
                {
                    e.Graphics.TranslateTransform(sz.Width, 0);
                    e.Graphics.RotateTransform(90);
                    break;
                }
            case RotationType.Flip: //180 degrees
                {
                    e.Graphics.TranslateTransform(sz.Width, sz.Height);
                    e.Graphics.RotateTransform(180);
                    break;
                }
            case RotationType.Left: //270 degrees
                {
                    e.Graphics.TranslateTransform(0, sz.Height);
                    e.Graphics.RotateTransform(270);
                    break;
                }
            default: //0 = 360 degrees
                {
                    e.Graphics.TranslateTransform(0, 0);
                    e.Graphics.RotateTransform(0);
                    break;
                }
        }*/
        e.Graphics.TranslateTransform(0, sz.Height + txt.Height);
        var u = 0; //padding
        //e.Graphics.DrawString(Text, this.Font, Brushes.Black, new RectangleF(u, u + txt.Height, sz.Height - u, sz.Width - u), format);
        e.Graphics.ResetTransform();

        //painting = false;
    }
}