using System.Collections.Generic;
using System.Windows.Forms;

namespace CarScan.Models
{
    public class SoftPages
    {
        #region Pages
        public static int PageMain = 1;
        public static int PageCurrentCarIformation =2;
        public static int PagePayment = 3;
        public static int PageCarConnections = 4;
        public static int PageMoreInformation = 5;
        public static int PageScanning = 6;
        public static int PageScanningInformation = 7;
        public static int PagePrintInformation = 8;
        #endregion

        public static List<PagesModel> LoadPageNumbers()
        {
            List<PagesModel> pages = new List<PagesModel>();

            pages.Add(new PagesModel { CurrentPageNumber = PageMain });
            pages.Add(new PagesModel { CurrentPageNumber = PageCurrentCarIformation });
            pages.Add(new PagesModel { CurrentPageNumber = PagePayment });
            pages.Add(new PagesModel { CurrentPageNumber = PageCarConnections });
            pages.Add(new PagesModel { CurrentPageNumber = PageMoreInformation });
            pages.Add(new PagesModel { CurrentPageNumber = PageScanning });
            pages.Add(new PagesModel { CurrentPageNumber = PageScanningInformation });
            pages.Add(new PagesModel { CurrentPageNumber = PagePrintInformation });
            
            return pages;
        }
    }

    public class PagesModel
    {
        public GroupBox CurrentHeader { get; set; }
        public GroupBox CurrentBody { get; set; }
        public GroupBox CurrentFooter { get; set; }
        public int CurrentPageNumber { get; set; }
    }
}
