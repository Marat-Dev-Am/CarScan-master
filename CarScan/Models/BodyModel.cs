using System;
using System.Drawing;
using System.Windows.Forms;
using CarScan.Docs;

namespace CarScan.Models
{
    public class BodyModel : GroupBox
    {
        public BodyModel()
        {
            Width = Program._MainForm.Width;
            Height = Program._MainForm.Height - Program._MainForm.Height / Constants.FooterHeightForMainFormPart - Program._MainForm.Height / Constants.HeaderHeightForMainFormPart;
            Top = Program._MainForm.Header.Bottom;
            Left = Program._MainForm.Left;
            //Location = new Point(Program._MainForm.Location.X, Program._MainForm.Location.Y + Program._MainForm.Height / Constants.HeaderHeightForMainFormPart);
            BackColor = Constants.BodyColor;
            ForeColor = Constants.BodyForeColor;
            Paint += PaintBorderGroupBoxBodyWindow;
            AddControls();
        }

        private void PaintBorderGroupBoxBodyWindow(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(this.BackColor);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }

        private void AddControls()
        {
        }
    }
}
