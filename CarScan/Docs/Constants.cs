using System;
using System.Drawing;
using CarScan.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarScan.Docs
{
    public class Constants
    {
        #region Disagn
        public static Color ButtonsColor = Color.DeepSkyBlue;
        public static Color HeaderColor = Color.RoyalBlue;
        public static Color BodyColor = Color.Empty;
        public static Color FooterColor = Color.RoyalBlue;
        public static Color HeaderForeColor = Color.White;
        public static Color BodyForeColor = Color.White;
        public static Color FooterForeColor = Color.White;
        public static Color ProgressBarColor = Color.Red;
        public static int HeaderHeightForMainFormPart = 16;
        public static int FooterHeightForMainFormPart = 12;
        #endregion
        #region Local Path
        public static string SoftLogoPath = Environment.CurrentDirectory + @"\Icons\Logo.png";
        #endregion
        #region Constant Properties
        public static string SoftName = "Scanning Cars";
        public static string DefaultLanguage = "ARM";
        public static string SoftFont = "Arial sans-serif";
        #endregion
        

      
    }
}
