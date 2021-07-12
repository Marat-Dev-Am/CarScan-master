using System;
using System.Drawing;
using System.Windows.Forms;
using CarScan.Models;
using CarScan.Docs;
using System.Collections.Generic;
using System.Linq;

namespace CarScan
{
    public partial class MainForm : Form
    {
        #region Initialize
        public MainForm()
        {
            TopMost = true;git
            Program._MainForm = this;
            InitializeComponent();
            this.TimerDateTime.Tick += new EventHandler(this.TimerDateTime_Tick);
            this.TimerProgress.Tick += new EventHandler(this.TimerProgress_Tick);
        }
        #endregion

        #region Properties
        public int CurrentPage = 1;
        #endregion
        #region Controls
        #region GroupBox
        public GroupBox Header;
        public GroupBox Body;
        public GroupBox Footer;
        #endregion
        #region Buttons
        public Button BT_Close;
        public Button BT_Next;
        public Button BT_Prev;
        public Button BT_Print;
        #endregion
        #region PictureBox
        public PictureBox SoftLogo;
        #endregion
        #region Labels
        public Label SoftName;
        public Label CurrentDateTime;
        #endregion
        #region Timers
        public Timer TimerDateTime = new Timer();
        public Timer TimerProgress = new Timer();
        #endregion
        #region ProgressBar
        public ProgressBar Progress;
        #endregion
        #endregion
        #region Pages List
        public List<PagesModel> PagesList = SoftPages.LoadPageNumbers();
        #endregion

        #region Events
        #region Form Load/Close
        private void MainForm_Load(object sender, EventArgs e)
        {
            CurrentPage = 1;
            LoadControls();
            PostLoadForm();
            TimerDateTime.Start();
        }
        #endregion
        #region Timers
        private void TimerDateTime_Tick(object sender, EventArgs e)
        {
            CurrentDateTime.Text = DateTime.Now.ToString();
        }
        private void TimerProgress_Tick(object sender, EventArgs e)
        {
            TimerProgress.Interval = 1;
            Progress.Visible = true;
            Progress.Value += 2;
            if (Progress.Value == 100)
            {
                Progress.Value = 0;
                Progress.Visible = false;
                TimerProgress.Stop();
            }
        }
        #endregion
        #region Buttons
        public void BT_Next_Click(object sender, EventArgs e)
        {
            if (!CheckCurrentStep(CurrentPage + 1))
            {
                return;
            }
            CurrentPage += 1;
            LoadControls();
            ShowProgressBar();
        }
        public void BT_Prev_Click(object sender, EventArgs e)
        {
            if (!CheckCurrentStep(CurrentPage - 1))
            {
                return;
            }
            CurrentPage -= 1;
            LoadControls();
            ShowProgressBar();
        }
        public void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void BT_Print_Click(object sender, EventArgs e)
        {}
        public void BT_Test_Click(object sender, EventArgs e)
        {
            LanguagesModel.ChangeLanguages("RU");
            //ReLoadControls();
        }
        #endregion
        #endregion

        #region Helps
        private void PostLoadForm()
        {
            Progress = new ProgressBarModel();
        }

        private bool CheckCurrentStep(int step)
        {
            if (step == 0) return false;

            switch (step)
            {
                case 1:
                   
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
                case 5:
                    
                    break;
                case 6:
                    
                    break;
            }    

            return true;
        }

        private void LoadControls()
        {
            this.Controls.Clear();
            PagesModel Currpage = PagesList.Where(po => po.CurrentPageNumber == CurrentPage).FirstOrDefault();
            if (Currpage != null && Currpage.CurrentBody != null && Currpage.CurrentFooter != null && Currpage.CurrentHeader != null)
            {
                Body = Currpage.CurrentBody;
                Footer = Currpage.CurrentFooter;
                Header = Currpage.CurrentHeader;
                this.Controls.Add(Header);
                this.Controls.Add(Footer);
                this.Controls.Add(Body);
                EnableDisableHideShowControls();
                return;
            }

            Header = new HeaderModel();
            this.Controls.Add(Header);
            Footer = new FooterModel();
            this.Controls.Add(Footer);
            Body = new BodyModel();
            this.Controls.Add(Body);
            EnableDisableHideShowControls();

            PagesModel page = PagesList.Where(po => po.CurrentPageNumber == CurrentPage).FirstOrDefault();
            if (page != null)
            {
                page.CurrentBody = Body;
                page.CurrentFooter = Footer;
                page.CurrentHeader = Header;
            }
        }

        private void EnableDisableHideShowControls()
        {
            BT_Close.Visible = true;
            this.SoftName.Visible = true;
            this.CurrentDateTime.Visible = true;

            if (this.CurrentPage == SoftPages.PageMain)
            {
                this.BT_Prev.Visible = false;
                this.BT_Next.Visible = true;
                //
                return;
            }
            if (this.CurrentPage == SoftPages.PageCurrentCarIformation)
            {
                this.BT_Prev.Visible = true;
                this.BT_Next.Visible = true;
                //
                return;
            }
            if (this.CurrentPage == SoftPages.PagePayment)
            {
                this.BT_Prev.Visible = true;
                this.BT_Next.Visible = true;
                //
                return;
            }
            if (this.CurrentPage == SoftPages.PageCarConnections)
            {
                this.BT_Prev.Visible = true;
                this.BT_Next.Visible = true;
               
                //
                return;
            }
            if (this.CurrentPage == SoftPages.PageMoreInformation)
            {
                this.BT_Prev.Visible = true;
                this.BT_Next.Visible = true;
             
                //
                return;
            }
            if (this.CurrentPage == SoftPages.PageScanning)
            {
                this.BT_Next.Visible = false;
                this.BT_Prev.Visible = true;
                this.BT_Print.Visible = true;
                //
                return;
            }
        }

        private void ShowProgressBar()
        {
            this.Body.Controls.Add(this.Progress);
            if (this.Progress.Visible)
            {
                this.Progress.Visible = false;
                this.Progress.Value = 0;
            }
            TimerProgress.Start();
        }
        #endregion
    }
}
