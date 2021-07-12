using System;
using System.Drawing;
using System.Windows.Forms;
using CarScan.Docs;

namespace CarScan.Models
{
    public class ButtonModel : Button
    {
        public ButtonModel(EventHandler _Click, string btnType)
        {
            Click += new EventHandler(_Click);
            Width = 200;
            Height = 60;
            Text = btnType;
            AutoSize = false;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            TabStop = false;
            BackColor = Constants.ButtonsColor;
            //Padding = new Padding(6);
            Visible = false;
            Font = new Font(Constants.SoftFont, 20);
        }
    }
}
