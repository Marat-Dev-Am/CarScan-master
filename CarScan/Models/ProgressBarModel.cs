using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using CarScan.Docs;

namespace CarScan.Models
{
    public class ProgressBarModel : ProgressBar
    {
        public ProgressBarModel()
        {
            Width = Program._MainForm.Width;
            Height = 7;
            Value = 0;
            Visible = false;
            ForeColor = Constants.ProgressBarColor;
            BackColor = Constants.ProgressBarColor;
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 0, this.Width, this.Height);
            double scaleFactor = (((double)Value - (double)Minimum) / ((double)Maximum - (double)Minimum));
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, rec);
            rec.Width = (int)((rec.Width * scaleFactor) - 4);
            rec.Height -= 4;
            LinearGradientBrush brush = new LinearGradientBrush(rec, this.ForeColor, this.BackColor, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, 2, 2, rec.Width, rec.Height);
        }
    }
}
