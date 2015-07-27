using System.Windows.Forms;

namespace VisitorZoneApp.UI
{
    public partial class MainUi : Form
    {
        public MainUi()
        {
            InitializeComponent();
        }

        private void visitorEntryToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            VisitorEntryUi visitorEntry = new VisitorEntryUi();
            visitorEntry.Show();
        }

        private void zoneTypeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
           ZoneEntryUi aZoneEntryUi = new ZoneEntryUi();
           aZoneEntryUi.Show();
        }

        private void zoneToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ZoneSpecificVisitorReportUI aSpecificVisitorReportUi = new ZoneSpecificVisitorReportUI();
            aSpecificVisitorReportUi.Show();
        }

        private void zoneSpecificVisitorNumberToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ZoneWiseVisitorNumberUI aWiseVisitorNumberUi = new ZoneWiseVisitorNumberUI();
            aWiseVisitorNumberUi.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
