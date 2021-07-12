using System.Drawing;
using System.Windows.Forms;
using CarScan.Docs;
using System.IO;
using System;

namespace CarScan.Models
{
    public class HeaderModel : GroupBox
    {
        public HeaderModel()
        {
            Width = Program._MainForm.Width;
            Height = Program._MainForm.Height / Constants.HeaderHeightForMainFormPart;
            Location = new Point(Program._MainForm.Location.X, Program._MainForm.Location.Y);
            BackColor = Constants.HeaderColor;
            ForeColor = Constants.HeaderForeColor;
            Paint += PaintBorderGroupBoxHeaderWindow;
            AddControls();
        }

        private void PaintBorderGroupBoxHeaderWindow(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(this.BackColor);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }

        private void AddControls()
        {
            // Logo
            int logoWidth = 0;
            if (File.Exists(Constants.SoftLogoPath))
            {
                Program._MainForm.SoftLogo = new PicktureLogoModel(this);
                this.Controls.Add(Program._MainForm.SoftLogo);
                logoWidth = Program._MainForm.SoftLogo.Width;
            }
            // Soft Name
            Program._MainForm.SoftName = new NormalLabelModel(Constants.SoftName, new Point(this.Location.X + logoWidth + 50, this.Location.Y + this.Height/2), 18);
            this.Controls.Add(Program._MainForm.SoftName);
            // Date Time
            Program._MainForm.CurrentDateTime = new NormalLabelModel(DateTime.Now.ToString(), new Point(this.Location.X + this.Width - 200),10);
            Program._MainForm.CurrentDateTime.Top = this.Top + 25;
            Program._MainForm.CurrentDateTime.Left = this.Left + this.Width - Program._MainForm.CurrentDateTime.Width - 75;
            this.Controls.Add(Program._MainForm.CurrentDateTime);

        }
    }
}
