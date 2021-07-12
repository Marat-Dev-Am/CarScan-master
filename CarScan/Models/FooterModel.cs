using System;
using System.Drawing;
using System.Windows.Forms;
using CarScan.Docs;

namespace CarScan.Models
{
    public class FooterModel : GroupBox
    {
        public FooterModel()
        {
            Width = Program._MainForm.Width;
            Height = Program._MainForm.Height / Constants.FooterHeightForMainFormPart;
            Top = Program._MainForm.Body.Bottom;
            Left = Program._MainForm.Left;
            //Location = new Point(Program._MainForm.Location.X, Program._MainForm.Location.Y + Program._MainForm.Height - (Program._MainForm.Height / Constants.FooterHeightForMainFormPart));
            BackColor = Constants.FooterColor;
            ForeColor = Constants.FooterForeColor;
            Paint += PaintBorderGroupBoxFooterWindow;
            AddControls();
        }

        private void PaintBorderGroupBoxFooterWindow(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(this.BackColor);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }

        private void AddControls()
        {
            // Next
            Program._MainForm.BT_Next = new ButtonModel(Program._MainForm.BT_Next_Click, MessagesModel.Next);
            Program._MainForm.BT_Next.Top = this.Top ;//((this.Top - this.Bottom )/2);//this.Height - ((this.Height- Program._MainForm.BT_Next.Height )/2);
            Program._MainForm.BT_Next.Left = this.Width - Program._MainForm.BT_Next.Width - 20;
            this.Controls.Add(Program._MainForm.BT_Next);
            // Prev
            Program._MainForm.BT_Prev = new ButtonModel(Program._MainForm.BT_Prev_Click, MessagesModel.Prev);
            Program._MainForm.BT_Prev.Top = (this.Height - Program._MainForm.BT_Prev.Height) / 2 - 2;
            Program._MainForm.BT_Prev.Left = Program._MainForm.BT_Next.Left - Program._MainForm.BT_Next.Width - 5;
            this.Controls.Add(Program._MainForm.BT_Prev);
            // Print
            Program._MainForm.BT_Print = new ButtonModel(Program._MainForm.BT_Test_Click, MessagesModel.Print);
            Program._MainForm.BT_Print.Top = (this.Height - Program._MainForm.BT_Print.Height) / 2 - 2;
            Program._MainForm.BT_Print.Left = 15;
            this.Controls.Add(Program._MainForm.BT_Print);
            // Close
            Program._MainForm.BT_Close = new ButtonModel(Program._MainForm.BT_Close_Click, MessagesModel.Close);
            Program._MainForm.BT_Close.Top = (this.Height - Program._MainForm.BT_Close.Height) / 2  -2;
            Program._MainForm.BT_Close.Left = Program._MainForm.BT_Print.Width + 20;
            this.Controls.Add(Program._MainForm.BT_Close);
        }
    }
}
