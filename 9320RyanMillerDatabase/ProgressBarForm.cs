using _9320RyanMillerDatabase.ProgressBar; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9320RyanMillerDatabase
{
    public partial class ProgressBarForm : Form
    {
        public ProgressBarForm()
        {
            InitializeComponent();
            CenterToScreen();
            ThreeSecondWait.Interval = 1000;
            FullyLoadedSmile.Visible = false;
         
        }
        private int _timre = 5;

        private void ProgressBarForm_Load(object sender, EventArgs e)
        {
            LoadingMethod();
        }
        public async void LoadingMethod()
        {
            List<string> list = new List<string>();

            for (int i = 0; i < 1000; i++)
                list.Add(i.ToString());

            ProgBarLbl.Text = "Loading...";

            var progress = new Progress<ProgressReport>();
            progress.ProgressChanged += (o, report) =>
            {
                ProgBarLbl.Text = string.Format("Loading...{0}%", report.PercentageDone);
                ProgBar.Value = report.PercentageDone;
                ProgBar.Update();
            };
            await ProcessData(list, progress);
            ProgBarLbl.Text = "Done!";
            FullyLoadedSmile.Visible = true;
            ThreeSecondWait.Start();
        }

        private Task ProcessData(List<string> list, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var ProgressReport = new ProgressReport();
            return Task.Run(() => {
                for (int i = 0; i < totalProcess; i++)
                {
                    ProgressReport.PercentageDone = index++ * 100 / totalProcess;
                    progress.Report(ProgressReport);
                    Thread.Sleep(10);
                }
            });
        }

        private void AllDone()
        {
            Hide();
            new LoginScreen().Show();
        }
        
        private void ThreeSecondWait_Tick(object sender, EventArgs e)
        {
            _timre--;

            if (_timre == 0) 
            {
                AllDone();
            }
        }
    }
}
