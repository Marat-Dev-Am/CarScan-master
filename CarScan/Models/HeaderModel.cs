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
            Top = Program._MainForm.Top;
            Left = Program._MainForm.Left;
            //Location = new Point(Program._MainForm.Location.X, Program._MainForm.Location.Y);
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
            #region Group 1
            Program._MainForm.HeaderGroup1 = new GroupBox();
            Program._MainForm.HeaderGroup1.Width = this.Width / 5;
            Program._MainForm.HeaderGroup1.Height = this.Height;
            Program._MainForm.HeaderGroup1.BackColor = this.BackColor;
            Program._MainForm.HeaderGroup1.ForeColor = this.ForeColor;
            Program._MainForm.HeaderGroup1.Left = this.Left;
            Program._MainForm.HeaderGroup1.Top = this.Top;
            this.Controls.Add(Program._MainForm.HeaderGroup1);
            // Logo
            int logoWidth = 0;
            if (File.Exists(Constants.SoftLogoPath))
            {
                Program._MainForm.SoftLogo = new PicktureLogoModel(this);
                Program._MainForm.SoftLogo.BackColor = Constants.HeaderColor;
                Program._MainForm.SoftLogo.Top = ((this.Height - Program._MainForm.SoftLogo.Height) / 2);
                Program._MainForm.SoftLogo.Left = this.Left + 10;
                Program._MainForm.HeaderGroup1.Controls.Add(Program._MainForm.SoftLogo);
                logoWidth = Program._MainForm.SoftLogo.Width;
            }
            // Soft Name
            Program._MainForm.SoftName = new NormalLabelModel(Constants.SoftName, new Point(this.Location.X + logoWidth + 50, this.Location.Y + this.Height / 2), 18);
            Program._MainForm.HeaderGroup1.Controls.Add(Program._MainForm.SoftName);
            #endregion
            #region Group 2
            Program._MainForm.HeaderGroup2 = new GroupBox();
            Program._MainForm.HeaderGroup2.Width = this.Width * 65 / 100;
            Program._MainForm.HeaderGroup2.Height = this.Height;
            Program._MainForm.HeaderGroup2.BackColor = this.BackColor;
            Program._MainForm.HeaderGroup2.ForeColor = this.ForeColor;
            Program._MainForm.HeaderGroup2.Left =Program._MainForm.HeaderGroup1.Right;
            Program._MainForm.HeaderGroup2.Top = this.Top;
            this.Controls.Add(Program._MainForm.HeaderGroup2);
            #endregion
            #region Group 3
            Program._MainForm.HeaderGroup3 = new GroupBox();
            Program._MainForm.HeaderGroup3.Width = this.Width / 10;
            Program._MainForm.HeaderGroup3.Height = this.Height;
            Program._MainForm.HeaderGroup3.BackColor = this.BackColor;
            Program._MainForm.HeaderGroup3.ForeColor = this.ForeColor;
            Program._MainForm.HeaderGroup3.Left = Program._MainForm.HeaderGroup2.Right;
            Program._MainForm.HeaderGroup3.Top = this.Top;
            this.Controls.Add(Program._MainForm.HeaderGroup3);
            #endregion
            #region Group 4
            Program._MainForm.HeaderGroup4 = new GroupBox();
            Program._MainForm.HeaderGroup4.Width = this.Width / 20;
            Program._MainForm.HeaderGroup4.Height = this.Height;
            Program._MainForm.HeaderGroup4.BackColor = this.BackColor;
            Program._MainForm.HeaderGroup4.ForeColor = this.ForeColor;
            Program._MainForm.HeaderGroup4.Left = Program._MainForm.HeaderGroup3.Right ;
            Program._MainForm.HeaderGroup4.Top = this.Top;
            this.Controls.Add(Program._MainForm.HeaderGroup4);
            // Date Time
            Program._MainForm.CurrentDateTime = new NormalLabelModel(DateTime.Now.ToString(), new Point(this.Location.X + this.Width - 200), 10);
            Program._MainForm.CurrentDateTime.Top = Program._MainForm.HeaderGroup4.Top + 50;
            Program._MainForm.CurrentDateTime.Left = Program._MainForm.HeaderGroup4.Left + 5;
            Program._MainForm.HeaderGroup4.Controls.Add(Program._MainForm.CurrentDateTime);
            #endregion
        }
    }
}
