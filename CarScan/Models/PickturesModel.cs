using System.Windows.Forms;
using System.Drawing;
using CarScan.Docs;

namespace CarScan.Models
{
    public class PicktureLogoModel : PictureBox
    {
        public PicktureLogoModel(GroupBox groupBox)
        {
            Width = groupBox.Height / 2 + 10;
            Height = groupBox.Height / 2 + 10;
            Image = new Bitmap(Constants.SoftLogoPath);
            BorderStyle = BorderStyle.None;
            SizeMode = PictureBoxSizeMode.Zoom;
            Location = new Point(groupBox.Height / 2, groupBox.Height / 2 - 20);
        }
    }
}
