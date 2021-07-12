using System.Drawing;
using System.Windows.Forms;
using CarScan.Docs;

namespace CarScan.Models
{
    public class NormalLabelModel : Label
    {
        public NormalLabelModel(string text,Point location, float size)
        {
            AutoSize = true;
            Text = text;
            //Location = location;
            Visible = false;
            Font = new Font(Constants.SoftFont, size);
        }
    }
}
